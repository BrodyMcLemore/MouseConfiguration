Imports System.ComponentModel
Imports System.IO

Public Class mainWindow

    Private toggle As Integer = 0

    Function getFormData()
        Dim message As String = "An Error has occurred"
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            Dim filePath As String = FolderBrowserDialog.SelectedPath
            Dim fileName As String
            If fileNameTextbox.TextLength.Equals(0) Then
                fileName = "Output"
            Else
                fileName = fileNameTextbox.Text
            End If

            filePath = System.IO.Path.Combine(filePath, fileName)

            Dim newFile As FileStream = File.Create(filePath)
            newFile.Close()

            Dim sizeValue As String
            If sizeSmallButton.Checked Then
                sizeValue = "Small"
            ElseIf sizeMediumButton.Checked Then
                sizeValue = "Medium"
            Else
                sizeValue = "Large"
            End If

            Dim handValue As String
            If handLeftButton.Checked Then
                handValue = "Left Handed"
            ElseIf handRightButton.Checked Then
                handValue = "Right Handed"
            Else
                handValue = "Ambidextrous"
            End If

            Dim sideScrollValue As String
            If sideScrollYesButton.Checked Then
                sideScrollValue = "Side Scroll Wheel"
            Else
                sideScrollValue = "NO Side Scroll Wheel"
            End If

            Dim fbButtonValue As String
            If navYesButton.Checked Then
                fbButtonValue = "Forward-Backward Navigation Buttons"
            Else
                fbButtonValue = "NO Forward-Backward Navigation Buttons"
            End If

            Dim ergoValue As String
            If ergoYesButton.Checked Then
                ergoValue = "Ergonomic Design"
            Else
                ergoValue = "NO Erogonomic Design"
            End If

            Dim silentValue As String
            If silentYesButton.Checked Then
                silentValue = "Silent Clicks"
            Else
                silentValue = "NO Silent Clicks"
            End If

            Dim primaryColor As String = TypeDescriptor.GetConverter(primaryColorBox.BackColor.GetType).ConvertToInvariantString(primaryColorBox.BackColor)
            Dim secondaryColor As String = TypeDescriptor.GetConverter(secondayColorBox.BackColor.GetType).ConvertToInvariantString(secondayColorBox.BackColor)

            Dim strLabel() As String = {
                primaryColor + ",,",
                secondaryColor + ",,",
                sizeValue + ",,",
                brandTextBox.Text.ToString + ",,",
                handValue + ",,",
                sideScrollValue + ",,",
                fbButtonValue + ",,",
                ergoValue + ",,",
                silentValue + ",,",
                purposeTextbox.Text.ToString + ",,"}
            Dim lstLabels As New List(Of String)(strLabel)

            For Each line As String In lstLabels
                My.Computer.FileSystem.WriteAllText(filePath, line, True)
            Next

            message = "'" + fileName + "'" + " has been created and stored at " + filePath
        End If

        Return message
    End Function
    Private Sub menuButton_Click(sender As Object, e As EventArgs) Handles menuButton.Click
        If Not sideMenuPanel.Visible Then
            sideMenuPanel.Visible = True
        Else
            sideMenuPanel.Visible = False
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Close()
    End Sub

    Private Sub maximizeButton_Click(sender As Object, e As EventArgs) Handles maximizeButton.Click
        If toggle.Equals(0) Then
            Me.WindowState = FormWindowState.Maximized
            toggle = 1
        Else
            Me.WindowState = FormWindowState.Normal
            toggle = 0
        End If
    End Sub

    Private Sub minimizeButton_Click(sender As Object, e As EventArgs) Handles minimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub primaryColorLabel_Click(sender As Object, e As EventArgs) Handles primaryColorLabel.Click
        If primaryColor.ShowDialog = DialogResult.OK Then
            primaryColorBox.BackColor = primaryColor.Color
        End If
    End Sub

    Private Sub secondColorLabel_Click(sender As Object, e As EventArgs) Handles secondColorLabel.Click
        If secondaryColor.ShowDialog = DialogResult.OK Then
            secondayColorBox.BackColor = secondaryColor.Color
        End If
    End Sub

    Private Sub clearAllButton_Click(sender As Object, e As EventArgs) Handles clearAllButton.Click
        primaryColorBox.BackColor = Control.DefaultBackColor
        secondayColorBox.BackColor = Control.DefaultBackColor

        sizeSmallButton.Checked = False
        sizeMediumButton.Checked = False
        sizeLargeButton.Checked = False

        brandTextBox.Clear()

        handLeftButton.Checked = False
        handRightButton.Checked = False
        handBothButton.Checked = False

        sideScrollYesButton.Checked = False
        sideScrollNoButton.Checked = False

        navYesButton.Checked = False
        navNoButton.Checked = False

        ergoYesButton.Checked = False
        ergoNoButton.Checked = False

        silentYesButton.Checked = False
        silentNoButton.Checked = False

        purposeTextbox.Clear()

    End Sub

    Private Sub primaryColorBox_Click(sender As Object, e As EventArgs) Handles primaryColorBox.Click
        If primaryColor.ShowDialog = DialogResult.OK Then
            primaryColorBox.BackColor = primaryColor.Color
        End If
    End Sub

    Private Sub secondayColorBox_Click(sender As Object, e As EventArgs) Handles secondayColorBox.Click
        If secondaryColor.ShowDialog = DialogResult.OK Then
            secondayColorBox.BackColor = secondaryColor.Color
        End If
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        MsgBox(getFormData())
    End Sub

    Private Sub saveAndCloseButton_Click(sender As Object, e As EventArgs) Handles saveAndCloseButton.Click
        Dim result As DialogResult = MsgBox(getFormData())

        If result.OK Then
            Close()
        End If

    End Sub

    Private Sub addMenuButton_Click(sender As Object, e As EventArgs) Handles addMenuButton.Click
        primaryColorBox.BackColor = Control.DefaultBackColor
        secondayColorBox.BackColor = Control.DefaultBackColor

        sizeSmallButton.Checked = False
        sizeMediumButton.Checked = False
        sizeLargeButton.Checked = False

        brandTextBox.Clear()

        handLeftButton.Checked = False
        handRightButton.Checked = False
        handBothButton.Checked = False

        sideScrollYesButton.Checked = False
        sideScrollNoButton.Checked = False

        navYesButton.Checked = False
        navNoButton.Checked = False

        ergoYesButton.Checked = False
        ergoNoButton.Checked = False

        silentYesButton.Checked = False
        silentNoButton.Checked = False

        purposeTextbox.Clear()
    End Sub

    Private Sub openMenuButton_Click(sender As Object, e As EventArgs) Handles openMenuButton.Click
        Dim filePath As String = "C:\"
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            filePath = OpenFileDialog.FileName
        ElseIf OpenFileDialog.ShowDialog = DialogResult.Cancel Then
            MsgBox("Select a File to open.")
            Exit Sub
        End If

        Dim currentRow As String()
        Dim valueList As New List(Of String)
        Using Reader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)
            Reader.SetDelimiters(",,")
            While Not Reader.EndOfData
                Try
                    currentRow = Reader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        valueList.Add(currentField)
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    Console.WriteLine(ex.Message)
                End Try
            End While
        End Using

        Dim primaryColor As Color = TypeDescriptor.GetConverter(GetType(System.Drawing.Color)) _
                                                .ConvertFromInvariantString(valueList.Item(0))

        Dim secondaryColor As Color = TypeDescriptor.GetConverter(GetType(System.Drawing.Color)) _
                                                .ConvertFromInvariantString(valueList.Item(1))

        primaryColorBox.BackColor = primaryColor
        secondayColorBox.BackColor = secondaryColor

        If valueList.Item(2).ToString.Equals("Small") Then
            sizeSmallButton.Checked = True
        ElseIf valueList.Item(2).ToString.Equals("Medium") Then
            sizeMediumButton.Checked = True
        Else
            sizeLargeButton.Checked = True
        End If

        brandTextBox.Text = valueList.Item(3).ToString

        If valueList.Item(4).ToString.Equals("Left Handed") Then
            handLeftButton.Checked = True
        ElseIf valueList.Item(4).ToString.Equals("Right Handed") Then
            handRightButton.Checked = True
        Else
            handBothButton.Checked = True
        End If

        If valueList.Item(5).ToString.Equals("Side Scroll Wheel") Then
            sideScrollYesButton.Checked = True
        Else
            sideScrollNoButton.Checked = True
        End If

        If valueList.Item(6).ToString.Equals("Forward-Backward Navigation Buttons") Then
            navYesButton.Checked = True
        Else
            navNoButton.Checked = True
        End If

        If valueList.Item(7).ToString.Equals("Ergonomic Design") Then
            ergoYesButton.Checked = True
        Else
            ergoNoButton.Checked = True
        End If

        If valueList.Item(8).ToString.Equals("Silent Clicks") Then
            silentYesButton.Checked = True
        Else
            silentNoButton.Checked = True
        End If

        purposeTextbox.Text = valueList.Item(9).ToString

    End Sub
End Class
