<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listTabProcess = New System.Windows.Forms.ListView()
        Me.head1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.head2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.head3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.head4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.head5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.memEndreco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.memProcesso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.listMemoriaPrincipal = New System.Windows.Forms.ListView()
        Me.endreco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.processo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.listTableMemoriaVirtual = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.listMemoriaSwap = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNovoProcesso = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.chkAutoExec = New System.Windows.Forms.CheckBox()
        Me.btnGerarProcessos = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trkSpeed = New System.Windows.Forms.TrackBar()
        Me.txtExec = New System.Windows.Forms.TextBox()
        Me.btnExec = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtLimiteMemPrincipal = New System.Windows.Forms.TextBox()
        Me.btnProcFrag = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtDelPid = New System.Windows.Forms.TextBox()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTamanho = New System.Windows.Forms.TextBox()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listTabProcess)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 169)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabela de Processos"
        '
        'listTabProcess
        '
        Me.listTabProcess.AutoArrange = False
        Me.listTabProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.listTabProcess.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listTabProcess.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.head1, Me.head2, Me.head3, Me.head4, Me.head5})
        Me.listTabProcess.Cursor = System.Windows.Forms.Cursors.Default
        Me.listTabProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listTabProcess.GridLines = True
        Me.listTabProcess.Location = New System.Drawing.Point(3, 16)
        Me.listTabProcess.Name = "listTabProcess"
        Me.listTabProcess.Size = New System.Drawing.Size(383, 150)
        Me.listTabProcess.TabIndex = 0
        Me.listTabProcess.UseCompatibleStateImageBehavior = False
        Me.listTabProcess.View = System.Windows.Forms.View.Details
        '
        'head1
        '
        Me.head1.Text = "PID"
        Me.head1.Width = 31
        '
        'head2
        '
        Me.head2.Text = "Nome"
        Me.head2.Width = 99
        '
        'head3
        '
        Me.head3.Text = "Size (bytes)"
        Me.head3.Width = 68
        '
        'head4
        '
        Me.head4.Text = "Page Fault"
        Me.head4.Width = 65
        '
        'head5
        '
        Me.head5.Text = "Próx. Pag."
        Me.head5.Width = 64
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Location = New System.Drawing.Point(184, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(169, 446)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Memória Secundaria (swap )"
        '
        'ListView1
        '
        Me.ListView1.AutoArrange = False
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.memEndreco, Me.memProcesso})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(3, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(163, 427)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.UseWaitCursor = True
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'memEndreco
        '
        Me.memEndreco.Text = "Endereço"
        Me.memEndreco.Width = 69
        '
        'memProcesso
        '
        Me.memProcesso.Text = "Processo"
        Me.memProcesso.Width = 64
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listMemoriaPrincipal)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 446)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Memória Principal"
        '
        'listMemoriaPrincipal
        '
        Me.listMemoriaPrincipal.AutoArrange = False
        Me.listMemoriaPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.listMemoriaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMemoriaPrincipal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.endreco, Me.processo, Me.ColumnHeader7})
        Me.listMemoriaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listMemoriaPrincipal.GridLines = True
        Me.listMemoriaPrincipal.Location = New System.Drawing.Point(3, 16)
        Me.listMemoriaPrincipal.Name = "listMemoriaPrincipal"
        Me.listMemoriaPrincipal.Size = New System.Drawing.Size(184, 427)
        Me.listMemoriaPrincipal.TabIndex = 0
        Me.listMemoriaPrincipal.UseCompatibleStateImageBehavior = False
        Me.listMemoriaPrincipal.View = System.Windows.Forms.View.Details
        '
        'endreco
        '
        Me.endreco.Text = "Endereço"
        Me.endreco.Width = 59
        '
        'processo
        '
        Me.processo.Text = "Processo"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Parte"
        Me.ColumnHeader7.Width = 38
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.listTableMemoriaVirtual)
        Me.GroupBox4.Location = New System.Drawing.Point(407, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(618, 409)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tabela de Memória Virtual (size 1 byte)"
        '
        'listTableMemoriaVirtual
        '
        Me.listTableMemoriaVirtual.AutoArrange = False
        Me.listTableMemoriaVirtual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.listTableMemoriaVirtual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listTableMemoriaVirtual.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.listTableMemoriaVirtual.Cursor = System.Windows.Forms.Cursors.Default
        Me.listTableMemoriaVirtual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listTableMemoriaVirtual.GridLines = True
        Me.listTableMemoriaVirtual.Location = New System.Drawing.Point(3, 16)
        Me.listTableMemoriaVirtual.Name = "listTableMemoriaVirtual"
        Me.listTableMemoriaVirtual.Size = New System.Drawing.Size(612, 390)
        Me.listTableMemoriaVirtual.TabIndex = 0
        Me.listTableMemoriaVirtual.UseCompatibleStateImageBehavior = False
        Me.listTableMemoriaVirtual.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Pagina (end de memoria Virtual)"
        Me.ColumnHeader1.Width = 164
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Processo"
        Me.ColumnHeader2.Width = 69
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Parte"
        Me.ColumnHeader9.Width = 56
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "bit de validade (bit de presença)"
        Me.ColumnHeader3.Width = 164
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "End. (Frame ou Swap)"
        Me.ColumnHeader4.Width = 117
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.listMemoriaSwap)
        Me.GroupBox5.Location = New System.Drawing.Point(211, 187)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(190, 446)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Memória Secundaria (swap)"
        '
        'listMemoriaSwap
        '
        Me.listMemoriaSwap.AutoArrange = False
        Me.listMemoriaSwap.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.listMemoriaSwap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMemoriaSwap.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8})
        Me.listMemoriaSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listMemoriaSwap.GridLines = True
        Me.listMemoriaSwap.Location = New System.Drawing.Point(3, 16)
        Me.listMemoriaSwap.Name = "listMemoriaSwap"
        Me.listMemoriaSwap.Size = New System.Drawing.Size(184, 427)
        Me.listMemoriaSwap.TabIndex = 0
        Me.listMemoriaSwap.UseCompatibleStateImageBehavior = False
        Me.listMemoriaSwap.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Endereço"
        Me.ColumnHeader5.Width = 59
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Processo"
        Me.ColumnHeader6.Width = 62
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Parte"
        Me.ColumnHeader8.Width = 37
        '
        'btnNovoProcesso
        '
        Me.btnNovoProcesso.Location = New System.Drawing.Point(7, 149)
        Me.btnNovoProcesso.Name = "btnNovoProcesso"
        Me.btnNovoProcesso.Size = New System.Drawing.Size(109, 23)
        Me.btnNovoProcesso.TabIndex = 9
        Me.btnNovoProcesso.Text = "Criar"
        Me.btnNovoProcesso.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox11)
        Me.GroupBox6.Controls.Add(Me.GroupBox10)
        Me.GroupBox6.Controls.Add(Me.GroupBox9)
        Me.GroupBox6.Controls.Add(Me.btnProcFrag)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(410, 427)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(615, 206)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Controles"
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox11.Controls.Add(Me.chkAutoExec)
        Me.GroupBox11.Controls.Add(Me.btnGerarProcessos)
        Me.GroupBox11.Location = New System.Drawing.Point(396, 19)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(124, 101)
        Me.GroupBox11.TabIndex = 17
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Automatico"
        '
        'chkAutoExec
        '
        Me.chkAutoExec.AutoSize = True
        Me.chkAutoExec.Location = New System.Drawing.Point(25, 75)
        Me.chkAutoExec.Name = "chkAutoExec"
        Me.chkAutoExec.Size = New System.Drawing.Size(93, 17)
        Me.chkAutoExec.TabIndex = 18
        Me.chkAutoExec.Text = "Auto Executar"
        Me.chkAutoExec.UseVisualStyleBackColor = True
        '
        'btnGerarProcessos
        '
        Me.btnGerarProcessos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGerarProcessos.ForeColor = System.Drawing.Color.Black
        Me.btnGerarProcessos.Location = New System.Drawing.Point(6, 19)
        Me.btnGerarProcessos.Name = "btnGerarProcessos"
        Me.btnGerarProcessos.Size = New System.Drawing.Size(112, 44)
        Me.btnGerarProcessos.TabIndex = 16
        Me.btnGerarProcessos.Text = "Auto Insere Processos"
        Me.btnGerarProcessos.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox10.Controls.Add(Me.Label4)
        Me.GroupBox10.Controls.Add(Me.trkSpeed)
        Me.GroupBox10.Controls.Add(Me.txtExec)
        Me.GroupBox10.Controls.Add(Me.btnExec)
        Me.GroupBox10.Location = New System.Drawing.Point(266, 48)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(124, 150)
        Me.GroupBox10.TabIndex = 15
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Executar Processo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Velocidade de 1 a 12s"
        '
        'trkSpeed
        '
        Me.trkSpeed.Location = New System.Drawing.Point(9, 96)
        Me.trkSpeed.Maximum = 12000
        Me.trkSpeed.Minimum = 1000
        Me.trkSpeed.Name = "trkSpeed"
        Me.trkSpeed.Size = New System.Drawing.Size(109, 45)
        Me.trkSpeed.SmallChange = 4000
        Me.trkSpeed.TabIndex = 16
        Me.trkSpeed.TickFrequency = 4000
        Me.trkSpeed.Value = 1000
        '
        'txtExec
        '
        Me.txtExec.Location = New System.Drawing.Point(6, 23)
        Me.txtExec.Name = "txtExec"
        Me.txtExec.Size = New System.Drawing.Size(109, 20)
        Me.txtExec.TabIndex = 11
        '
        'btnExec
        '
        Me.btnExec.Location = New System.Drawing.Point(6, 49)
        Me.btnExec.Name = "btnExec"
        Me.btnExec.Size = New System.Drawing.Size(109, 23)
        Me.btnExec.TabIndex = 15
        Me.btnExec.Text = "Executar"
        Me.btnExec.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox9.Controls.Add(Me.txtLimiteMemPrincipal)
        Me.GroupBox9.Location = New System.Drawing.Point(136, 139)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(124, 58)
        Me.GroupBox9.TabIndex = 14
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Limite da Memória Principal"
        '
        'txtLimiteMemPrincipal
        '
        Me.txtLimiteMemPrincipal.Location = New System.Drawing.Point(6, 29)
        Me.txtLimiteMemPrincipal.Name = "txtLimiteMemPrincipal"
        Me.txtLimiteMemPrincipal.Size = New System.Drawing.Size(109, 20)
        Me.txtLimiteMemPrincipal.TabIndex = 10
        '
        'btnProcFrag
        '
        Me.btnProcFrag.Location = New System.Drawing.Point(266, 19)
        Me.btnProcFrag.Name = "btnProcFrag"
        Me.btnProcFrag.Size = New System.Drawing.Size(124, 23)
        Me.btnProcFrag.TabIndex = 13
        Me.btnProcFrag.Text = "Fragmentar Processos"
        Me.btnProcFrag.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox8.Controls.Add(Me.txtDelPid)
        Me.GroupBox8.Controls.Add(Me.btnRemover)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Location = New System.Drawing.Point(136, 19)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(124, 114)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Remove Processo"
        '
        'txtDelPid
        '
        Me.txtDelPid.Location = New System.Drawing.Point(8, 39)
        Me.txtDelPid.Name = "txtDelPid"
        Me.txtDelPid.Size = New System.Drawing.Size(110, 20)
        Me.txtDelPid.TabIndex = 6
        '
        'btnRemover
        '
        Me.btnRemover.Location = New System.Drawing.Point(6, 75)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(109, 23)
        Me.btnRemover.TabIndex = 9
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "PID"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.txtTamanho)
        Me.GroupBox7.Controls.Add(Me.txtPid)
        Me.GroupBox7.Controls.Add(Me.btnNovoProcesso)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.txtNome)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(124, 178)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Novo Processo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tamanho"
        '
        'txtTamanho
        '
        Me.txtTamanho.Location = New System.Drawing.Point(6, 117)
        Me.txtTamanho.Name = "txtTamanho"
        Me.txtTamanho.Size = New System.Drawing.Size(110, 20)
        Me.txtTamanho.TabIndex = 8
        '
        'txtPid
        '
        Me.txtPid.Location = New System.Drawing.Point(8, 39)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(110, 20)
        Me.txtPid.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PID"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(6, 78)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(110, 20)
        Me.txtNome.TabIndex = 7
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.statusBar.Location = New System.Drawing.Point(0, 644)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(1037, 22)
        Me.statusBar.TabIndex = 5
        Me.statusBar.Text = "StatusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 666)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulador de Memória Virtual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listTabProcess As ListView
    Friend WithEvents head1 As ColumnHeader
    Friend WithEvents head2 As ColumnHeader
    Friend WithEvents head3 As ColumnHeader
    Friend WithEvents head4 As ColumnHeader
    Friend WithEvents head5 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents listMemoriaPrincipal As ListView
    Friend WithEvents endreco As ColumnHeader
    Friend WithEvents processo As ColumnHeader
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents memEndreco As ColumnHeader
    Friend WithEvents memProcesso As ColumnHeader
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents listTableMemoriaVirtual As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents listMemoriaSwap As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnNovoProcesso As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents statusBar As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtPid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTamanho As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents txtDelPid As TextBox
    Friend WithEvents btnRemover As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProcFrag As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents txtLimiteMemPrincipal As TextBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnExec As Button
    Friend WithEvents txtExec As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents trkSpeed As TrackBar
    Friend WithEvents btnGerarProcessos As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents chkAutoExec As CheckBox
End Class
