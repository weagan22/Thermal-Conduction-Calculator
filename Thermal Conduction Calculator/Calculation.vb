Module Calculation
    Sub calculate() 'inEndTime As Double)

        Dim currentTime As Double = 0
        Dim endTime As Double = 113 * 60 'inEndTime
        Dim timeStep As Double = 0.0005 'inTimeStep

        Dim sampleRate As Integer = 1000
        Dim counter As Integer = sampleRate

        Dim externalTemp As Double = 113

        Dim matList() As String = {"TPS", "Shroud", "Insulation", "Air"}
        Dim matMass() As Double = {0.3416, 0.1084, 0.0246, 0.0246}
        Dim matConductive() As Double = {3.5, 0.2427, 0.1819, 0.1819}
        Dim matSpecHeat() As Double = {6.45932, 7.9212, 7.737016, 7.737016}
        Dim matTemp() As Double = {60, 60, 60, 60}

        Dim efficiency() As Double = {0.92, 0.92, 0.95, 0.95}
        Dim contactArea() As Double = {3016.6, 2996.9, 2996.9, 2996.9}
        Dim deltaX() As Double = {0.03, 2.03, 3.5, 3.5}

        For i = 0 To UBound(matConductive)
            matConductive(i) = matConductive(i) / 518400
        Next

        Call outputValues(currentTime, matTemp)

        Do While currentTime < endTime
            Dim newMatTemp() As Double
            ReDim newMatTemp(UBound(matList))

            For i = 0 To (UBound(matList))
                Dim extTemp As Double = 0
                If i = 0 Then
                    extTemp = ExternalTemp
                Else
                    extTemp = matTemp(i - 1)
                End If
                newMatTemp(i) = steadyHeatTransfer(matConductive(i), contactArea(i), efficiency(i), matMass(i), matSpecHeat(i), extTemp, matTemp(i), deltaX(i), currentTime, currentTime + timeStep, matTemp(i))
            Next


            If counter Mod sampleRate = 0 Then
                Call outputValues(currentTime, newMatTemp)
                counter = 1
            End If

            counter = counter + 1

            For i = 0 To (UBound(matList))
                matTemp(i) = newMatTemp(i)
            Next
            currentTime = currentTime + timeStep
        Loop


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

        My.Computer.FileSystem.WriteAllText(MainForm.filePath, InputString, True)

    End Sub


End Module
