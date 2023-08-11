<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.NumericUpDown()
        Me.coTicketZone = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dispName = New System.Windows.Forms.Label()
        Me.dispZone = New System.Windows.Forms.Label()
        Me.dispQuantity = New System.Windows.Forms.Label()
        Me.dispUnitPrice = New System.Windows.Forms.Label()
        Me.dispPrice = New System.Windows.Forms.Label()
        Me.dispDiscount = New System.Windows.Forms.Label()
        Me.dispTotalPrice = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "e-Ticketing System"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnTotal)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.coTicketZone)
        Me.Panel1.Controls.Add(Me.txtQuantity)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(193, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 252)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ticket zone:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(130, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(235, 29)
        Me.txtName.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(130, 86)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(235, 29)
        Me.txtQuantity.TabIndex = 4
        '
        'coTicketZone
        '
        Me.coTicketZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coTicketZone.FormattingEnabled = True
        Me.coTicketZone.Items.AddRange(New Object() {"ZONE A", "ZONE B", "ZONE C", "ZONE D"})
        Me.coTicketZone.Location = New System.Drawing.Point(130, 143)
        Me.coTicketZone.Name = "coTicketZone"
        Me.coTicketZone.Size = New System.Drawing.Size(235, 32)
        Me.coTicketZone.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(452, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 158)
        Me.Panel2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ZONE A: RM 200 per ticket"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ZONE B: RM 150 per ticket"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ZONE C: RM 100 per ticket"
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(187, 193)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(124, 42)
        Me.btnTotal.TabIndex = 7
        Me.btnTotal.Text = "Calculate Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Location = New System.Drawing.Point(193, 361)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(755, 241)
        Me.Panel3.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dispTotalPrice)
        Me.GroupBox2.Controls.Add(Me.dispDiscount)
        Me.GroupBox2.Controls.Add(Me.dispPrice)
        Me.GroupBox2.Controls.Add(Me.dispUnitPrice)
        Me.GroupBox2.Controls.Add(Me.dispQuantity)
        Me.GroupBox2.Controls.Add(Me.dispZone)
        Me.GroupBox2.Controls.Add(Me.dispName)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(722, 216)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Zone:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Quanity:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Unit Price:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Total Price:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(386, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 18)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Applicable for discount?:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(386, 183)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(184, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Total Price After Discount: "
        '
        'dispName
        '
        Me.dispName.AutoSize = True
        Me.dispName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispName.Location = New System.Drawing.Point(85, 29)
        Me.dispName.Name = "dispName"
        Me.dispName.Size = New System.Drawing.Size(23, 18)
        Me.dispName.TabIndex = 15
        Me.dispName.Text = "---"
        '
        'dispZone
        '
        Me.dispZone.AutoSize = True
        Me.dispZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispZone.Location = New System.Drawing.Point(85, 65)
        Me.dispZone.Name = "dispZone"
        Me.dispZone.Size = New System.Drawing.Size(23, 18)
        Me.dispZone.TabIndex = 16
        Me.dispZone.Text = "---"
        '
        'dispQuantity
        '
        Me.dispQuantity.AutoSize = True
        Me.dispQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispQuantity.Location = New System.Drawing.Point(85, 107)
        Me.dispQuantity.Name = "dispQuantity"
        Me.dispQuantity.Size = New System.Drawing.Size(23, 18)
        Me.dispQuantity.TabIndex = 17
        Me.dispQuantity.Text = "---"
        '
        'dispUnitPrice
        '
        Me.dispUnitPrice.AutoSize = True
        Me.dispUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispUnitPrice.Location = New System.Drawing.Point(85, 147)
        Me.dispUnitPrice.Name = "dispUnitPrice"
        Me.dispUnitPrice.Size = New System.Drawing.Size(23, 18)
        Me.dispUnitPrice.TabIndex = 18
        Me.dispUnitPrice.Text = "---"
        '
        'dispPrice
        '
        Me.dispPrice.AutoSize = True
        Me.dispPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispPrice.Location = New System.Drawing.Point(85, 183)
        Me.dispPrice.Name = "dispPrice"
        Me.dispPrice.Size = New System.Drawing.Size(23, 18)
        Me.dispPrice.TabIndex = 19
        Me.dispPrice.Text = "---"
        '
        'dispDiscount
        '
        Me.dispDiscount.AutoSize = True
        Me.dispDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispDiscount.Location = New System.Drawing.Point(576, 147)
        Me.dispDiscount.Name = "dispDiscount"
        Me.dispDiscount.Size = New System.Drawing.Size(23, 18)
        Me.dispDiscount.TabIndex = 20
        Me.dispDiscount.Text = "---"
        '
        'dispTotalPrice
        '
        Me.dispTotalPrice.AutoSize = True
        Me.dispTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispTotalPrice.Location = New System.Drawing.Point(576, 183)
        Me.dispTotalPrice.Name = "dispTotalPrice"
        Me.dispTotalPrice.Size = New System.Drawing.Size(23, 18)
        Me.dispTotalPrice.TabIndex = 21
        Me.dispTotalPrice.Text = "---"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1126, 662)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "ColdPlay Ticketing System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTotal As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents coTicketZone As ComboBox
    Friend WithEvents txtQuantity As NumericUpDown
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dispTotalPrice As Label
    Friend WithEvents dispDiscount As Label
    Friend WithEvents dispPrice As Label
    Friend WithEvents dispUnitPrice As Label
    Friend WithEvents dispQuantity As Label
    Friend WithEvents dispZone As Label
    Friend WithEvents dispName As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
