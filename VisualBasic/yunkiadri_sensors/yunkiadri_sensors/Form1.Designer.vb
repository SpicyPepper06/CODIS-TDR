﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.cmb_ports = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_conectar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_baud = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_comunicacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.PanelMega = New System.Windows.Forms.Panel()
        Me.ButtonT2 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.txt_comand = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_poss = New System.Windows.Forms.Label()
        Me.lbl_posb = New System.Windows.Forms.Label()
        Me.lbl_posa = New System.Windows.Forms.Label()
        Me.lbl_posz = New System.Windows.Forms.Label()
        Me.lbl_posy = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_posx = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerSensors = New System.Windows.Forms.Timer(Me.components)
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'cmb_ports
        '
        Me.cmb_ports.FormattingEnabled = True
        Me.cmb_ports.Location = New System.Drawing.Point(216, 14)
        Me.cmb_ports.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_ports.Name = "cmb_ports"
        Me.cmb_ports.Size = New System.Drawing.Size(189, 24)
        Me.cmb_ports.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_conectar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmb_baud)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmb_ports)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 52)
        Me.Panel1.TabIndex = 1
        '
        'btn_conectar
        '
        Me.btn_conectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_conectar.Location = New System.Drawing.Point(773, 9)
        Me.btn_conectar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_conectar.Name = "btn_conectar"
        Me.btn_conectar.Size = New System.Drawing.Size(168, 31)
        Me.btn_conectar.TabIndex = 4
        Me.btn_conectar.Text = "Conectar"
        Me.btn_conectar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(423, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Velocity:"
        '
        'cmb_baud
        '
        Me.cmb_baud.FormattingEnabled = True
        Me.cmb_baud.Items.AddRange(New Object() {"2400", "9600", "19200", "38400", "57600", "115200", "250000"})
        Me.cmb_baud.Location = New System.Drawing.Point(508, 14)
        Me.cmb_baud.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_baud.Name = "cmb_baud"
        Me.cmb_baud.Size = New System.Drawing.Size(213, 24)
        Me.cmb_baud.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Port:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONNECTION:"
        '
        'txt_comunicacion
        '
        Me.txt_comunicacion.BackColor = System.Drawing.Color.White
        Me.txt_comunicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comunicacion.Location = New System.Drawing.Point(7, 46)
        Me.txt_comunicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_comunicacion.Multiline = True
        Me.txt_comunicacion.Name = "txt_comunicacion"
        Me.txt_comunicacion.ReadOnly = True
        Me.txt_comunicacion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_comunicacion.Size = New System.Drawing.Size(450, 163)
        Me.txt_comunicacion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(132, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "COMUNICATION:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button27)
        Me.Panel2.Controls.Add(Me.Button26)
        Me.Panel2.Controls.Add(Me.PanelMega)
        Me.Panel2.Controls.Add(Me.ButtonT2)
        Me.Panel2.Controls.Add(Me.Button24)
        Me.Panel2.Controls.Add(Me.Button22)
        Me.Panel2.Controls.Add(Me.Button21)
        Me.Panel2.Controls.Add(Me.txt_comand)
        Me.Panel2.Controls.Add(Me.txt_comunicacion)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(980, 63)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 598)
        Me.Panel2.TabIndex = 4
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(7, 227)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(75, 23)
        Me.Button26.TabIndex = 19
        Me.Button26.Text = "Button26"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'PanelMega
        '
        Me.PanelMega.BackColor = System.Drawing.Color.SkyBlue
        Me.PanelMega.Location = New System.Drawing.Point(7, 311)
        Me.PanelMega.Name = "PanelMega"
        Me.PanelMega.Size = New System.Drawing.Size(449, 259)
        Me.PanelMega.TabIndex = 18
        '
        'ButtonT2
        '
        Me.ButtonT2.Location = New System.Drawing.Point(109, 227)
        Me.ButtonT2.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonT2.Name = "ButtonT2"
        Me.ButtonT2.Size = New System.Drawing.Size(100, 44)
        Me.ButtonT2.TabIndex = 17
        Me.ButtonT2.Text = "TascaObre"
        Me.ButtonT2.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(7, 245)
        Me.Button24.Margin = New System.Windows.Forms.Padding(4)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(100, 44)
        Me.Button24.TabIndex = 15
        Me.Button24.Text = "Reset pos"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(376, 245)
        Me.Button22.Margin = New System.Windows.Forms.Padding(4)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(81, 63)
        Me.Button22.TabIndex = 14
        Me.Button22.Text = "SEND"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(292, 245)
        Me.Button21.Margin = New System.Windows.Forms.Padding(4)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(81, 63)
        Me.Button21.TabIndex = 13
        Me.Button21.Text = "CLEAR"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'txt_comand
        '
        Me.txt_comand.Location = New System.Drawing.Point(7, 213)
        Me.txt_comand.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_comand.Name = "txt_comand"
        Me.txt_comand.Size = New System.Drawing.Size(449, 22)
        Me.txt_comand.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(11, 89)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 49)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "▲"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(73, 89)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 49)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "▲"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(137, 89)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 49)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "▲"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(201, 89)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 49)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "▲"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(265, 89)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 49)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "▲"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(9, 203)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 49)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "▼"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(75, 203)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 49)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "▼"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(139, 203)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(56, 49)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "▼"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(201, 203)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 49)
        Me.Button11.TabIndex = 16
        Me.Button11.Text = "▼"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(265, 203)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(56, 49)
        Me.Button12.TabIndex = 17
        Me.Button12.Text = "▼"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 46)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "X"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 39)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 46)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Y"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(139, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 46)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Z"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(203, 39)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 46)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(267, 39)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 46)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "B"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(329, 146)
        Me.Button14.Margin = New System.Windows.Forms.Padding(4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(56, 49)
        Me.Button14.TabIndex = 25
        Me.Button14.Text = "◄"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(444, 146)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(56, 49)
        Me.Button15.TabIndex = 26
        Me.Button15.Text = "►"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(381, 97)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 46)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "S"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lbl_poss)
        Me.Panel3.Controls.Add(Me.lbl_posb)
        Me.Panel3.Controls.Add(Me.lbl_posa)
        Me.Panel3.Controls.Add(Me.lbl_posz)
        Me.Panel3.Controls.Add(Me.lbl_posy)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lbl_posx)
        Me.Panel3.Controls.Add(Me.Button15)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button14)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Button9)
        Me.Panel3.Controls.Add(Me.Button10)
        Me.Panel3.Controls.Add(Me.Button12)
        Me.Panel3.Controls.Add(Me.Button11)
        Me.Panel3.Location = New System.Drawing.Point(1, 362)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(523, 276)
        Me.Panel3.TabIndex = 28
        '
        'lbl_poss
        '
        Me.lbl_poss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_poss.Location = New System.Drawing.Point(387, 164)
        Me.lbl_poss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_poss.Name = "lbl_poss"
        Me.lbl_poss.Size = New System.Drawing.Size(56, 20)
        Me.lbl_poss.TabIndex = 36
        Me.lbl_poss.Text = "0"
        Me.lbl_poss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_posb
        '
        Me.lbl_posb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_posb.Location = New System.Drawing.Point(265, 162)
        Me.lbl_posb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_posb.Name = "lbl_posb"
        Me.lbl_posb.Size = New System.Drawing.Size(56, 20)
        Me.lbl_posb.TabIndex = 35
        Me.lbl_posb.Text = "0"
        Me.lbl_posb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_posa
        '
        Me.lbl_posa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_posa.Location = New System.Drawing.Point(201, 162)
        Me.lbl_posa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_posa.Name = "lbl_posa"
        Me.lbl_posa.Size = New System.Drawing.Size(56, 20)
        Me.lbl_posa.TabIndex = 34
        Me.lbl_posa.Text = "0"
        Me.lbl_posa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_posz
        '
        Me.lbl_posz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_posz.Location = New System.Drawing.Point(139, 162)
        Me.lbl_posz.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_posz.Name = "lbl_posz"
        Me.lbl_posz.Size = New System.Drawing.Size(55, 20)
        Me.lbl_posz.TabIndex = 33
        Me.lbl_posz.Text = "0"
        Me.lbl_posz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_posy
        '
        Me.lbl_posy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_posy.Location = New System.Drawing.Point(75, 162)
        Me.lbl_posy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_posy.Name = "lbl_posy"
        Me.lbl_posy.Size = New System.Drawing.Size(55, 20)
        Me.lbl_posy.TabIndex = 32
        Me.lbl_posy.Text = "0"
        Me.lbl_posy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 12)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "CONTROL:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(343, 218)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 29)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Paso:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(427, 215)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(67, 34)
        Me.NumericUpDown1.TabIndex = 28
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_posx
        '
        Me.lbl_posx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_posx.Location = New System.Drawing.Point(11, 162)
        Me.lbl_posx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_posx.Name = "lbl_posx"
        Me.lbl_posx.Size = New System.Drawing.Size(55, 20)
        Me.lbl_posx.TabIndex = 30
        Me.lbl_posx.Text = "0"
        Me.lbl_posx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Button23)
        Me.Panel4.Controls.Add(Me.Button19)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.ListBox1)
        Me.Panel4.Controls.Add(Me.Button20)
        Me.Panel4.Controls.Add(Me.Button18)
        Me.Panel4.Controls.Add(Me.Button17)
        Me.Panel4.Controls.Add(Me.Button16)
        Me.Panel4.Controls.Add(Me.Button13)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(533, 64)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(437, 575)
        Me.Panel4.TabIndex = 29
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(341, 322)
        Me.Button23.Margin = New System.Windows.Forms.Padding(4)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(81, 31)
        Me.Button23.TabIndex = 17
        Me.Button23.Text = "PASTE"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(341, 284)
        Me.Button19.Margin = New System.Windows.Forms.Padding(4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(81, 31)
        Me.Button19.TabIndex = 16
        Me.Button19.Text = "COPY"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(4, 526)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(324, 38)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "EXECUTE ALL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(4, 46)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(328, 464)
        Me.ListBox1.TabIndex = 13
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(341, 361)
        Me.Button20.Margin = New System.Windows.Forms.Padding(4)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(81, 63)
        Me.Button20.TabIndex = 12
        Me.Button20.Text = "CLEAR"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(341, 186)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(81, 63)
        Me.Button18.TabIndex = 10
        Me.Button18.Text = "EDIT"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(341, 431)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(81, 63)
        Me.Button17.TabIndex = 9
        Me.Button17.Text = "LOAD"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(341, 501)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(81, 63)
        Me.Button16.TabIndex = 8
        Me.Button16.Text = "SAVE"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(341, 116)
        Me.Button13.Margin = New System.Windows.Forms.Padding(4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(81, 63)
        Me.Button13.TabIndex = 7
        Me.Button13.Text = "DEL"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(341, 46)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(81, 63)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "ADD"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(67, 22)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 20)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "COORDINATES:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "moveo foix files(*.mff)|*.mff"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "moveo foix files(*.mff)|*.mff"
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(15, 64)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(511, 290)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(980, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'TimerSensors
        '
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(1091, 31)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(222, 23)
        Me.Button25.TabIndex = 32
        Me.Button25.Text = "ButtonDesxifra"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(109, 272)
        Me.Button27.Margin = New System.Windows.Forms.Padding(4)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(100, 44)
        Me.Button27.TabIndex = 20
        Me.Button27.Text = "TascaTanca"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1460, 647)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "BCN MOVEO CONNECTION SOFTWARE v0.1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents cmb_ports As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_baud As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_conectar As Button
    Friend WithEvents txt_comunicacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lbl_posx As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_comand As TextBox
    Friend WithEvents lbl_posb As Label
    Friend WithEvents lbl_posa As Label
    Friend WithEvents lbl_posz As Label
    Friend WithEvents lbl_posy As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_poss As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button23 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ButtonT2 As Button
    Friend WithEvents PanelMega As Panel
    Friend WithEvents TimerSensors As Timer
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
End Class