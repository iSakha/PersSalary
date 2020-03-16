<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.eventList_cmb = New System.Windows.Forms.ComboBox()
        Me.loadEvent_btn = New System.Windows.Forms.Button()
        Me.newEvent_btn = New System.Windows.Forms.Button()
        Me.eventOK_btn = New System.Windows.Forms.Button()
        Me.persQty_txt = New System.Windows.Forms.TextBox()
        Me.daysQty_txt = New System.Windows.Forms.TextBox()
        Me.eventNumber_txt = New System.Windows.Forms.TextBox()
        Me.manager_txt = New System.Windows.Forms.TextBox()
        Me.location_txt = New System.Windows.Forms.TextBox()
        Me.event_txt = New System.Windows.Forms.TextBox()
        Me.endDTP = New System.Windows.Forms.DateTimePicker()
        Me.eventDTP = New System.Windows.Forms.DateTimePicker()
        Me.startDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.eventNumber_lbl = New System.Windows.Forms.Label()
        Me.manager_lbl = New System.Windows.Forms.Label()
        Me.location_lbl = New System.Windows.Forms.Label()
        Me.event_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.daysQty_lbl = New System.Windows.Forms.Label()
        Me.endDate_lbl = New System.Windows.Forms.Label()
        Me.eventDate_lbl = New System.Windows.Forms.Label()
        Me.startDate_lbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.next1_btn = New System.Windows.Forms.Button()
        Me.addPers_btn = New System.Windows.Forms.Button()
        Me.subtractPers_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(716, 652)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Linen
        Me.TabPage1.Controls.Add(Me.next1_btn)
        Me.TabPage1.Controls.Add(Me.eventList_cmb)
        Me.TabPage1.Controls.Add(Me.loadEvent_btn)
        Me.TabPage1.Controls.Add(Me.newEvent_btn)
        Me.TabPage1.Controls.Add(Me.eventOK_btn)
        Me.TabPage1.Controls.Add(Me.persQty_txt)
        Me.TabPage1.Controls.Add(Me.daysQty_txt)
        Me.TabPage1.Controls.Add(Me.eventNumber_txt)
        Me.TabPage1.Controls.Add(Me.manager_txt)
        Me.TabPage1.Controls.Add(Me.location_txt)
        Me.TabPage1.Controls.Add(Me.event_txt)
        Me.TabPage1.Controls.Add(Me.endDTP)
        Me.TabPage1.Controls.Add(Me.eventDTP)
        Me.TabPage1.Controls.Add(Me.startDTP)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(708, 626)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Мероприятие"
        '
        'eventList_cmb
        '
        Me.eventList_cmb.FormattingEnabled = True
        Me.eventList_cmb.Location = New System.Drawing.Point(359, 477)
        Me.eventList_cmb.Name = "eventList_cmb"
        Me.eventList_cmb.Size = New System.Drawing.Size(270, 21)
        Me.eventList_cmb.TabIndex = 25
        '
        'loadEvent_btn
        '
        Me.loadEvent_btn.Location = New System.Drawing.Point(278, 477)
        Me.loadEvent_btn.Name = "loadEvent_btn"
        Me.loadEvent_btn.Size = New System.Drawing.Size(75, 23)
        Me.loadEvent_btn.TabIndex = 24
        Me.loadEvent_btn.Text = "LOAD"
        Me.loadEvent_btn.UseVisualStyleBackColor = True
        '
        'newEvent_btn
        '
        Me.newEvent_btn.Location = New System.Drawing.Point(197, 477)
        Me.newEvent_btn.Name = "newEvent_btn"
        Me.newEvent_btn.Size = New System.Drawing.Size(75, 23)
        Me.newEvent_btn.TabIndex = 23
        Me.newEvent_btn.Text = "NEW"
        Me.newEvent_btn.UseVisualStyleBackColor = True
        '
        'eventOK_btn
        '
        Me.eventOK_btn.Location = New System.Drawing.Point(197, 519)
        Me.eventOK_btn.Name = "eventOK_btn"
        Me.eventOK_btn.Size = New System.Drawing.Size(156, 42)
        Me.eventOK_btn.TabIndex = 22
        Me.eventOK_btn.Text = "OK"
        Me.eventOK_btn.UseVisualStyleBackColor = True
        '
        'persQty_txt
        '
        Me.persQty_txt.Location = New System.Drawing.Point(197, 411)
        Me.persQty_txt.Name = "persQty_txt"
        Me.persQty_txt.Size = New System.Drawing.Size(200, 20)
        Me.persQty_txt.TabIndex = 21
        Me.persQty_txt.Text = "0"
        '
        'daysQty_txt
        '
        Me.daysQty_txt.Enabled = False
        Me.daysQty_txt.Location = New System.Drawing.Point(197, 379)
        Me.daysQty_txt.Name = "daysQty_txt"
        Me.daysQty_txt.Size = New System.Drawing.Size(200, 20)
        Me.daysQty_txt.TabIndex = 20
        Me.daysQty_txt.Text = "0"
        '
        'eventNumber_txt
        '
        Me.eventNumber_txt.Location = New System.Drawing.Point(197, 251)
        Me.eventNumber_txt.Name = "eventNumber_txt"
        Me.eventNumber_txt.Size = New System.Drawing.Size(200, 20)
        Me.eventNumber_txt.TabIndex = 19
        '
        'manager_txt
        '
        Me.manager_txt.Location = New System.Drawing.Point(197, 219)
        Me.manager_txt.Name = "manager_txt"
        Me.manager_txt.Size = New System.Drawing.Size(432, 20)
        Me.manager_txt.TabIndex = 18
        '
        'location_txt
        '
        Me.location_txt.Location = New System.Drawing.Point(197, 187)
        Me.location_txt.Name = "location_txt"
        Me.location_txt.Size = New System.Drawing.Size(432, 20)
        Me.location_txt.TabIndex = 17
        '
        'event_txt
        '
        Me.event_txt.Location = New System.Drawing.Point(197, 155)
        Me.event_txt.Name = "event_txt"
        Me.event_txt.Size = New System.Drawing.Size(432, 20)
        Me.event_txt.TabIndex = 16
        '
        'endDTP
        '
        Me.endDTP.CustomFormat = "dd.MM.yyyy"
        Me.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endDTP.Location = New System.Drawing.Point(197, 347)
        Me.endDTP.Name = "endDTP"
        Me.endDTP.Size = New System.Drawing.Size(200, 20)
        Me.endDTP.TabIndex = 15
        '
        'eventDTP
        '
        Me.eventDTP.CustomFormat = "dd.MM.yyyy"
        Me.eventDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.eventDTP.Location = New System.Drawing.Point(197, 315)
        Me.eventDTP.Name = "eventDTP"
        Me.eventDTP.Size = New System.Drawing.Size(200, 20)
        Me.eventDTP.TabIndex = 14
        '
        'startDTP
        '
        Me.startDTP.CustomFormat = "dd.MM.yyyy"
        Me.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startDTP.Location = New System.Drawing.Point(197, 283)
        Me.startDTP.Name = "startDTP"
        Me.startDTP.Size = New System.Drawing.Size(200, 20)
        Me.startDTP.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(23, 411)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 13)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Количество людей"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(23, 380)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Количество дней"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(23, 349)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(122, 13)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Окончание демонтажа"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(23, 318)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Дата проведения"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(23, 287)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(92, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Начало монтажа"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "№ Мероприятия"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 225)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Менеджер"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(23, 194)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Место проведения"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 163)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Мероприятие"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.subtractPers_btn)
        Me.TabPage2.Controls.Add(Me.addPers_btn)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(708, 626)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Персонал"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(708, 626)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Данные"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Controls.Add(Me.eventNumber_lbl)
        Me.GroupBox1.Controls.Add(Me.manager_lbl)
        Me.GroupBox1.Controls.Add(Me.location_lbl)
        Me.GroupBox1.Controls.Add(Me.event_lbl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 659)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 110)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'eventNumber_lbl
        '
        Me.eventNumber_lbl.AutoSize = True
        Me.eventNumber_lbl.BackColor = System.Drawing.Color.Cornsilk
        Me.eventNumber_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.eventNumber_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.eventNumber_lbl.Location = New System.Drawing.Point(128, 92)
        Me.eventNumber_lbl.Name = "eventNumber_lbl"
        Me.eventNumber_lbl.Size = New System.Drawing.Size(19, 15)
        Me.eventNumber_lbl.TabIndex = 7
        Me.eventNumber_lbl.Text = "---"
        '
        'manager_lbl
        '
        Me.manager_lbl.AutoSize = True
        Me.manager_lbl.BackColor = System.Drawing.Color.Cornsilk
        Me.manager_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.manager_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.manager_lbl.Location = New System.Drawing.Point(128, 68)
        Me.manager_lbl.Name = "manager_lbl"
        Me.manager_lbl.Size = New System.Drawing.Size(19, 15)
        Me.manager_lbl.TabIndex = 6
        Me.manager_lbl.Text = "---"
        '
        'location_lbl
        '
        Me.location_lbl.AutoSize = True
        Me.location_lbl.BackColor = System.Drawing.Color.Cornsilk
        Me.location_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.location_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.location_lbl.Location = New System.Drawing.Point(128, 44)
        Me.location_lbl.Name = "location_lbl"
        Me.location_lbl.Size = New System.Drawing.Size(19, 15)
        Me.location_lbl.TabIndex = 5
        Me.location_lbl.Text = "---"
        '
        'event_lbl
        '
        Me.event_lbl.AutoSize = True
        Me.event_lbl.BackColor = System.Drawing.Color.Cornsilk
        Me.event_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.event_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.event_lbl.Location = New System.Drawing.Point(128, 20)
        Me.event_lbl.Name = "event_lbl"
        Me.event_lbl.Size = New System.Drawing.Size(19, 15)
        Me.event_lbl.TabIndex = 4
        Me.event_lbl.Text = "---"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "№ Мероприятия"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Менеджер"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Место проведения"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Мероприятие"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Linen
        Me.GroupBox2.Controls.Add(Me.daysQty_lbl)
        Me.GroupBox2.Controls.Add(Me.endDate_lbl)
        Me.GroupBox2.Controls.Add(Me.eventDate_lbl)
        Me.GroupBox2.Controls.Add(Me.startDate_lbl)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(407, 659)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 110)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'daysQty_lbl
        '
        Me.daysQty_lbl.AutoSize = True
        Me.daysQty_lbl.BackColor = System.Drawing.Color.Cornsilk
        Me.daysQty_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.daysQty_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.daysQty_lbl.Location = New System.Drawing.Point(141, 92)
        Me.daysQty_lbl.Name = "daysQty_lbl"
        Me.daysQty_lbl.Size = New System.Drawing.Size(19, 15)
        Me.daysQty_lbl.TabIndex = 7
        Me.daysQty_lbl.Text = "---"
        '
        'endDate_lbl
        '
        Me.endDate_lbl.AutoSize = True
        Me.endDate_lbl.BackColor = System.Drawing.Color.Cornsilk
        Me.endDate_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.endDate_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.endDate_lbl.Location = New System.Drawing.Point(141, 68)
        Me.endDate_lbl.Name = "endDate_lbl"
        Me.endDate_lbl.Size = New System.Drawing.Size(19, 15)
        Me.endDate_lbl.TabIndex = 6
        Me.endDate_lbl.Text = "---"
        '
        'eventDate_lbl
        '
        Me.eventDate_lbl.AutoSize = True
        Me.eventDate_lbl.BackColor = System.Drawing.Color.Cornsilk
        Me.eventDate_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.eventDate_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.eventDate_lbl.Location = New System.Drawing.Point(141, 44)
        Me.eventDate_lbl.Name = "eventDate_lbl"
        Me.eventDate_lbl.Size = New System.Drawing.Size(19, 15)
        Me.eventDate_lbl.TabIndex = 5
        Me.eventDate_lbl.Text = "---"
        '
        'startDate_lbl
        '
        Me.startDate_lbl.AutoSize = True
        Me.startDate_lbl.BackColor = System.Drawing.Color.Cornsilk
        Me.startDate_lbl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.startDate_lbl.ForeColor = System.Drawing.Color.MidnightBlue
        Me.startDate_lbl.Location = New System.Drawing.Point(141, 20)
        Me.startDate_lbl.Name = "startDate_lbl"
        Me.startDate_lbl.Size = New System.Drawing.Size(19, 15)
        Me.startDate_lbl.TabIndex = 4
        Me.startDate_lbl.Text = "---"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Количество дней"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Окончание демонтажа"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Дата проведения"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Начало монтажа"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(19, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(199, 589)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(376, 14)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(199, 589)
        Me.ListBox2.TabIndex = 1
        '
        'next1_btn
        '
        Me.next1_btn.Location = New System.Drawing.Point(473, 519)
        Me.next1_btn.Name = "next1_btn"
        Me.next1_btn.Size = New System.Drawing.Size(156, 42)
        Me.next1_btn.TabIndex = 26
        Me.next1_btn.Text = "NEXT"
        Me.next1_btn.UseVisualStyleBackColor = True
        '
        'addPers_btn
        '
        Me.addPers_btn.Location = New System.Drawing.Point(259, 261)
        Me.addPers_btn.Name = "addPers_btn"
        Me.addPers_btn.Size = New System.Drawing.Size(75, 23)
        Me.addPers_btn.TabIndex = 2
        Me.addPers_btn.Text = ">>>"
        Me.addPers_btn.UseVisualStyleBackColor = True
        '
        'subtractPers_btn
        '
        Me.subtractPers_btn.Location = New System.Drawing.Point(259, 308)
        Me.subtractPers_btn.Name = "subtractPers_btn"
        Me.subtractPers_btn.Size = New System.Drawing.Size(75, 23)
        Me.subtractPers_btn.TabIndex = 3
        Me.subtractPers_btn.Text = "<<<"
        Me.subtractPers_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 42)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "NEXT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 781)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "mainForm"
        Me.Text = "Awesome!"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents endDTP As DateTimePicker
    Friend WithEvents eventDTP As DateTimePicker
    Friend WithEvents startDTP As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents eventNumber_lbl As Label
    Friend WithEvents manager_lbl As Label
    Friend WithEvents location_lbl As Label
    Friend WithEvents event_lbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents daysQty_lbl As Label
    Friend WithEvents endDate_lbl As Label
    Friend WithEvents eventDate_lbl As Label
    Friend WithEvents startDate_lbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents eventOK_btn As Button
    Friend WithEvents persQty_txt As TextBox
    Friend WithEvents daysQty_txt As TextBox
    Friend WithEvents eventNumber_txt As TextBox
    Friend WithEvents manager_txt As TextBox
    Friend WithEvents location_txt As TextBox
    Friend WithEvents event_txt As TextBox
    Friend WithEvents eventList_cmb As ComboBox
    Friend WithEvents loadEvent_btn As Button
    Friend WithEvents newEvent_btn As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents next1_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents subtractPers_btn As Button
    Friend WithEvents addPers_btn As Button
End Class
