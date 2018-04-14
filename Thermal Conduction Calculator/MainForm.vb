Public Class MainForm

    Public filePath As String
    Public endTime As Double
    Public timeStep As Double
    Public sampleRate As Integer
    Public externalTemp As Double

    Public matMass() As Double = {0}
    Public matConductive() As Double = {0}
    Public matSpecHeat() As Double = {0}
    Public matTemp() As Double = {0}

    Public efficiency() As Double = {0}
    Public contactArea() As Double = {0}
    Public deltaX() As Double = {0}

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

    End Sub

    Sub loadValues(table As DataGridView, columnToLoad As Integer, array() As Double)
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
    End Sub
End Class
