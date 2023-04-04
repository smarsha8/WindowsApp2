Option Strict On
Public Class Form1

    Private _decSong As Decimal = 2.99D
    Private _decHourlyRate As Decimal = 8.99D
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)

    End Sub

    Private Function ValidateInput() As Boolean
        'input
        Dim intNumber As Integer
        Dim blnValid As Boolean = False


        Try

            intNumber = Convert.ToInt32(txtHours.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater that 0",, "Error")

            End If

        Catch Exception As FormatException
            MsgBox("Please enter a valid amount",, "Error")

        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable amount",, "Attention")

        Catch Exception As SystemException
            MsgBox("Invalid Entry. Please enta a valid number of members",, "Error")

        End Try

        'back to textbox
        txtHours.Focus()
        txtHours.Clear()
        Return blnValid
    End Function



    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * _decSong
        Return decPassCost
    End Function

    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * _decHourlyRate
        Return decTicketCost
    End Function




    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        ClearForm()


    End Sub
    Private Sub ClearForm()
        cmbxPrivateKarokeBooth.SelectedIndex = -1
        lblCostofKaraoke.Visible = False
        txtHours.Visible = False
        btnTotalCost.Visible = False
        btnClearForm.Visible = False
        lblHourlyRentalofRoom.Visible = False
        txtHours.Clear()

    End Sub

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        'Function is called to validate the value entered
        blnAmountIsValid = ValidateInput()
        If blnAmountIsValid = True Then
            'Input assigned to variable
            intValue = Convert.ToInt32(txtHours.Text)

            If cmbxPrivateKarokeBooth.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)

            End If
            lblCostofKaraoke.Visible = True
            lblCostofKaraoke.Text = "Total Cost of Karaoke Night - " & decTotal.ToString("C")

        End If
    End Sub

    Private Sub cmbxPrivateKarokeBooth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxPrivateKarokeBooth.SelectedIndexChanged
        'combo selection event places the objects on the form
        If cmbxPrivateKarokeBooth.SelectedIndex = 0 Then
            lblCostofKaraoke.Text = "Number of Karaoke Songs"
            lblCostofKaraoke.Visible = True
            txtHours.Visible = True
            btnClearForm.Visible = True
            btnTotalCost.Visible = True
            'focus towards the textbox
            txtHours.Focus()
        End If

        If cmbxPrivateKarokeBooth.SelectedIndex = 1 Then
            lblCostofKaraoke.Text = "Hourly Rental of Karaoke Room:"
            lblCostofKaraoke.Visible = True
            txtHours.Visible = True
        End If
    End Sub
End Class