<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblKarokeMusicNight = New System.Windows.Forms.Label()
        Me.cmbxPrivateKarokeBooth = New System.Windows.Forms.ComboBox()
        Me.lblHourlyRentalofRoom = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.lblCostofKaraoke = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKarokeMusicNight
        '
        Me.lblKarokeMusicNight.Font = New System.Drawing.Font("Stencil", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKarokeMusicNight.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblKarokeMusicNight.Location = New System.Drawing.Point(374, 27)
        Me.lblKarokeMusicNight.Name = "lblKarokeMusicNight"
        Me.lblKarokeMusicNight.Size = New System.Drawing.Size(620, 53)
        Me.lblKarokeMusicNight.TabIndex = 3
        Me.lblKarokeMusicNight.Text = "Karaoke Music Night"
        '
        'cmbxPrivateKarokeBooth
        '
        Me.cmbxPrivateKarokeBooth.FormattingEnabled = True
        Me.cmbxPrivateKarokeBooth.Items.AddRange(New Object() {"Numbers of Songs ($2.99 per song)", "Hours in Private Karaoke Booth($8.99 per hour)"})
        Me.cmbxPrivateKarokeBooth.Location = New System.Drawing.Point(466, 143)
        Me.cmbxPrivateKarokeBooth.Name = "cmbxPrivateKarokeBooth"
        Me.cmbxPrivateKarokeBooth.Size = New System.Drawing.Size(380, 28)
        Me.cmbxPrivateKarokeBooth.TabIndex = 4
        Me.cmbxPrivateKarokeBooth.Text = "Customize Your  Karaoke Night"
        '
        'lblHourlyRentalofRoom
        '
        Me.lblHourlyRentalofRoom.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyRentalofRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHourlyRentalofRoom.Location = New System.Drawing.Point(376, 197)
        Me.lblHourlyRentalofRoom.Name = "lblHourlyRentalofRoom"
        Me.lblHourlyRentalofRoom.Size = New System.Drawing.Size(539, 38)
        Me.lblHourlyRentalofRoom.TabIndex = 5
        Me.lblHourlyRentalofRoom.Text = "Hourly Rental of Karaoke Room:"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(573, 280)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(46, 26)
        Me.txtHours.TabIndex = 6
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Location = New System.Drawing.Point(391, 341)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(207, 61)
        Me.btnTotalCost.TabIndex = 7
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Location = New System.Drawing.Point(652, 341)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(207, 61)
        Me.btnClearForm.TabIndex = 8
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'lblCostofKaraoke
        '
        Me.lblCostofKaraoke.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCostofKaraoke.Location = New System.Drawing.Point(448, 443)
        Me.lblCostofKaraoke.Name = "lblCostofKaraoke"
        Me.lblCostofKaraoke.Size = New System.Drawing.Size(312, 41)
        Me.lblCostofKaraoke.TabIndex = 9
        Me.lblCostofKaraoke.Text = "cost"
        Me.lblCostofKaraoke.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.karaoke
        Me.PictureBox1.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 513)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1006, 511)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCostofKaraoke)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnTotalCost)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblHourlyRentalofRoom)
        Me.Controls.Add(Me.cmbxPrivateKarokeBooth)
        Me.Controls.Add(Me.lblKarokeMusicNight)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKarokeMusicNight As Label
    Friend WithEvents cmbxPrivateKarokeBooth As ComboBox
    Friend WithEvents lblHourlyRentalofRoom As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents lblCostofKaraoke As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
