Public Class MainForm

    Public filePath As String
    Public endTime As Double
    Public timeStep As Double
    Public sampleRate As Integer
    Public externalTemp As Double

    Public matMass() As Double
    Public matConductive() As Double
    Public matSpecHeat() As Double
    Public matTemp() As Double

    Public efficiency() As Double
    Public contactArea() As Double
    Public deltaX() As Double

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    End Sub

    Sub runCheck()
        If numericCheck(txtEndTime) And numericCheck(txtTimeStep) And numericCheck(txtSampleRate) And numericCheck(txtExtTemp) And checkCellNumeric(matTable) And checkCellNumeric(interactionTable) And System.IO.Directory.Exists(txtFilePath.Text) Then
            Call getValues()
        Else
                MsgBox("Check your input values.",, "Error")
        End If

    End Sub

    Private Sub matTable_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles matTable.CellEndEdit
        If interactionTable.RowCount < matTable.RowCount - 1 Then
            Do While interactionTable.RowCount < matTable.RowCount - 1
                interactionTable.Rows.Add()
            Loop
        ElseIf interactionTable.RowCount > matTable.RowCount - 1 Then
            Do While interactionTable.RowCount > matTable.RowCount - 1
                interactionTable.Rows.Remove(interactionTable.Rows.Item(interactionTable.Rows.Count))
            Loop
        End If

        interactionTable.Item(0, 0).Value = "Ext - " & matTable.Item(0, 0).Value
        For i = 1 To matTable.RowCount - 2
            interactionTable.Item(0, i).Value = matTable.Item(0, i - 1).Value & "-" & matTable.Item(0, i).Value
        Next

        Call checkCellNumeric(matTable)
        Call checkCellNumeric(interactionTable)
    End Sub

    Private Sub interactionTable_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles interactionTable.CellEndEdit
        Call checkCellNumeric(interactionTable)
        Call checkCellNumeric(matTable)
    End Sub

    Private Sub txtEndTime_TextChanged(sender As Object, e As EventArgs) Handles txtEndTime.TextChanged
        numericCheck(txtEndTime)
    End Sub

    Private Sub txtTimeStep_TextChanged(sender As Object, e As EventArgs) Handles txtTimeStep.TextChanged
        numericCheck(txtTimeStep)
    End Sub

    Private Sub txtSampleRate_TextChanged(sender As Object, e As EventArgs) Handles txtSampleRate.TextChanged
        numericCheck(txtSampleRate)
    End Sub

    Private Sub txtExtTemp_TextChanged(sender As Object, e As EventArgs) Handles txtExtTemp.TextChanged
        numericCheck(txtExtTemp)
    End Sub

    Function numericCheck(textBox As TextBox) As Boolean
        Dim returnVal As Boolean = True

        If IsNumeric(textBox.Text) Then
            textBox.BackColor = Color.White
        Else
            textBox.BackColor = Color.Red
            returnVal = False
        End If

        Return returnVal
    End Function

    Function checkCellNumeric(table As DataGridView) As Boolean
        Dim returnVal As Boolean = True

        For i = 1 To table.ColumnCount - 1
            For z = 0 To table.RowCount - 1
                If table.Item(0, z).Value <> "" Then
                    If IsNumeric(table.Item(i, z).Value) Then
                        table.Item(i, z).Style.BackColor = Color.White
                    Else
                        table.Item(i, z).Style.BackColor = Color.Red
                        returnVal = False
                    End If
                End If
            Next
        Next

        Return returnVal
    End Function

    Private Sub txtFilePath_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath.TextChanged, txtFilePath.TextChanged
        If System.IO.Directory.Exists(txtFilePath.Text) Then
            txtFilePath.BackColor = Color.White
        Else
            txtFilePath.BackColor = Color.Red
        End If
    End Sub

    Sub getValues()
        filePath = txtFilePath.Text
        If Strings.Right(filePath, 1) <> "\" Then
            filePath = filePath & "\"
        End If
        filePath = filePath & "output" & Now.Hour.ToString & Now.Minute.ToString & Now.Second.ToString & ".txt"

        endTime = CDbl(txtEndTime.Text) * 60
        timeStep = CDbl(txtTimeStep.Text)
        sampleRate = Int(CDbl(txtSampleRate.Text) / timeStep)
        externalTemp = CDbl(txtExtTemp.Text)

        Call loadValues(matTable, 1, matMass)
        Call loadValues(matTable, 2, matConductive)
        Call loadValues(matTable, 3, matSpecHeat)
        Call loadValues(matTable, 4, matTemp)

        Call loadValues(interactionTable, 1, efficiency)
        Call loadValues(interactionTable, 2, contactArea)
        Call loadValues(interactionTable, 3, deltaX)

        For i = 0 To UBound(matConductive)
            matConductive(i) = matConductive(i) / 518400
        Next

        For i = 0 To UBound(matMass)
            matMass(i) = matMass(i) / 32.2
        Next

        For i = 0 To UBound(matSpecHeat)
            matSpecHeat(i) = matSpecHeat(i) * 32.2
        Next
    End Sub

    Sub loadValues(table As DataGridView, columnToLoad As Integer, ByRef array() As Double)
        For i = 0 To table.Rows.Count - 1
            If table.Item(0, i).Value <> "" Then
                If array Is Nothing Then
                    ReDim array(0)
                Else
                    ReDim Preserve array(UBound(array) + 1)
                End If

                array(UBound(array)) = CDbl(table.Item(columnToLoad, i).Value)
            End If
        Next
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Call runCheck()
        Call calculate()
    End Sub


    Sub calculate() 'inEndTime As Double)

        Dim currentTime As Double = 0
        'Dim endTime As Double = 113 * 60 'inEndTime
        'Dim timeStep As Double = 0.0005 'inTimeStep

        'Dim sampleRate As Integer = 1000
        Dim counter As Integer = sampleRate

        'Dim externalTemp As Double = 113

        'Dim matList() As String = {"TPS", "Shroud", "Insulation", "Air"}
        'Dim matMass() As Double = {0.3416, 0.1084, 0.0246, 0.0246}
        'Dim matConductive() As Double = {3.5, 0.2427, 0.1819, 0.1819}
        'Dim matSpecHeat() As Double = {6.45932, 7.9212, 7.737016, 7.737016}
        'Dim matTemp() As Double = {60, 60, 60, 60}

        'Dim efficiency() As Double = {0.92, 0.92, 0.95, 0.95}
        'Dim contactArea() As Double = {3016.6, 2996.9, 2996.9, 2996.9}
        'Dim deltaX() As Double = {0.03, 2.03, 3.5, 3.5}

        'For i = 0 To UBound(matConductive)
        '    matConductive(i) = matConductive(i) / 518400
        'Next

        Call outputValues(currentTime, matTemp)

        Do While currentTime < endTime
            Dim newMatTemp() As Double
            ReDim newMatTemp(UBound(matMass))

            For i = 0 To (UBound(matMass))
                Dim extTemp As Double = 0
                If i = 0 Then
                    extTemp = externalTemp
                Else
                    extTemp = matTemp(i - 1)
                End If
                newMatTemp(i) = steadyHeatTransfer(matConductive(i), contactArea(i), efficiency(i), matMass(i), matSpecHeat(i), extTemp, matTemp(i), deltaX(i), currentTime, currentTime + timeStep, matTemp(i))
            Next


            If counter Mod sampleRate = 0 Then
                Call outputValues(currentTime + timeStep, newMatTemp)
                counter = 1
            End If

            counter = counter + 1

            For i = 0 To (UBound(matMass))
                matTemp(i) = newMatTemp(i)
            Next
            currentTime = currentTime + timeStep

            ToolStripStatusLabel1.Text = Math.Round(currentTime / 60, 2) & " of " & endTime / 60
            StatusStrip1.Refresh()
        Loop

        ToolStripStatusLabel1.Text = "Complete, see file: " & filePath
        StatusStrip1.Refresh()
    End Sub

    Function steadyHeatTransfer(k As Double, area As Double, efficiency As Double, mass As Double, specHeat As Double, Te As Double, Tc As Double, deltaX As Double, time1 As Double, time2 As Double, initialTemp As Double) As Double

        Dim holdValue As Double = k * area * efficiency * ((Te - Tc) / deltaX)

        holdValue = holdValue * ((time2 - time1) / (mass * specHeat))

        Return holdValue + initialTemp

    End Function

    Sub outputValues(currentTime As Double, inValues() As Double)
        Dim InputString As String = Math.Round(currentTime, 3) & ","

        For i = 0 To UBound(inValues)
            If i = UBound(inValues) Then
                InputString = InputString & Math.Round(inValues(i), 3) & vbNewLine
            Else
                InputString = InputString & Math.Round(inValues(i), 3) & ","
            End If
        Next

        My.Computer.FileSystem.WriteAllText(filePath, InputString, True)

    End Sub

End Class
