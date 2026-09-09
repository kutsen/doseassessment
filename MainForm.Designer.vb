<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm

    Inherits System.Windows.Forms.Form
    'Implements CustDGV
    'Inherits Class1
    '   <system.Security.Permissions.SecurityPermission( _
    '      system.Security.Permissions.SecurityAction.LinkDemand, Flags:= _
    '      system.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)> _
    ' Protected Overrides Function ProcessDataGridViewKey( _
    '    ByVal e As System.Windows.Forms.KeyEventArgs) As Boolean

    ' Handle the ENTER key as if it were a RIGHT ARROW key. 
    '    If e.KeyCode = Keys.Enter Then
    '        Return Me.ProcessRightKey(e.KeyData)
    '    End If

    '   Return MyBase.ProcessDataGridViewKey(e)

    ' End Function


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ProcTree = New System.Windows.Forms.TreeView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Patient = New System.Windows.Forms.TabPage
        Me.PatientDataLabel = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.PatientWeightTextBox = New System.Windows.Forms.TextBox
        Me.HeightTextBox = New System.Windows.Forms.TextBox
        Me.PatientWeightLabel = New System.Windows.Forms.Label
        Me.HeightLabel = New System.Windows.Forms.Label
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.PatronymicTextBox = New System.Windows.Forms.TextBox
        Me.GivenNameTextBox = New System.Windows.Forms.TextBox
        Me.FamilyNameTextBox = New System.Windows.Forms.TextBox
        Me.RegistryNumTextBox = New System.Windows.Forms.TextBox
        Me.BirthDateLabel = New System.Windows.Forms.Label
        Me.PatronymicLabel = New System.Windows.Forms.Label
        Me.GivenNameLabel = New System.Windows.Forms.Label
        Me.FamilyNameLabel = New System.Windows.Forms.Label
        Me.RegistryNumLabel = New System.Windows.Forms.Label
        Me.Procedure = New System.Windows.Forms.TabPage
        Me.RippleTextBox = New System.Windows.Forms.TextBox
        Me.RippleLabel = New System.Windows.Forms.Label
        Me.FilterTextBox = New System.Windows.Forms.TextBox
        Me.FilterLabel = New System.Windows.Forms.Label
        Me.FieldSizeComboBox = New System.Windows.Forms.ComboBox
        Me.FieldSizeLabel = New System.Windows.Forms.Label
        Me.FIDComboBox = New System.Windows.Forms.ComboBox
        Me.FIDLabel = New System.Windows.Forms.Label
        Me.VoltageProcTextBox = New System.Windows.Forms.TextBox
        Me.VoltageProcLabel = New System.Windows.Forms.Label
        Me.mAsLabel = New System.Windows.Forms.Label
        Me.mAsTextBox = New System.Windows.Forms.TextBox
        Me.ProcedureParamsLabel = New System.Windows.Forms.Label
        Me.ExaminationDateLabel = New System.Windows.Forms.Label
        Me.ProcedureDataGridView = New System.Windows.Forms.DataGridView
        Me.FID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PowerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProcedureCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FieldWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FieldHeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FilterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ripple = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProceduresListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New RentgenCalculator.DataDataSet
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Device = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.KeyField = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeviceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeviceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.YieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rip = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PowerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FilterDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MyDevicesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripButton
        Me.XRayUnitListLabel = New System.Windows.Forms.Label
        Me.ExitButton = New System.Windows.Forms.Button
        Me.RunButton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MyDevicesListTableAdapter = New RentgenCalculator.DataDataSetTableAdapters.MyDevicesListTableAdapter
        Me.ProceduresListTableAdapter = New RentgenCalculator.DataDataSetTableAdapters.ProceduresListTableAdapter
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Patient.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Procedure.SuspendLayout()
        CType(Me.ProcedureDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProceduresListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Device.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDevicesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AccessibleDescription = Nothing
        Me.SplitContainer1.AccessibleName = Nothing
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.BackgroundImage = Nothing
        Me.SplitContainer1.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.SplitContainer1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.SplitContainer1, CType(resources.GetObject("SplitContainer1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.SplitContainer1, Nothing)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AccessibleDescription = Nothing
        Me.SplitContainer1.Panel1.AccessibleName = Nothing
        resources.ApplyResources(Me.SplitContainer1.Panel1, "SplitContainer1.Panel1")
        Me.SplitContainer1.Panel1.BackgroundImage = Nothing
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProcTree)
        Me.SplitContainer1.Panel1.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.SplitContainer1.Panel1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.SplitContainer1.Panel1, CType(resources.GetObject("SplitContainer1.Panel1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.SplitContainer1.Panel1, Nothing)
        Me.HelpProvider1.SetShowHelp(Me.SplitContainer1.Panel1, CType(resources.GetObject("SplitContainer1.Panel1.ShowHelp"), Boolean))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AccessibleDescription = Nothing
        Me.SplitContainer1.Panel2.AccessibleName = Nothing
        resources.ApplyResources(Me.SplitContainer1.Panel2, "SplitContainer1.Panel2")
        Me.SplitContainer1.Panel2.BackgroundImage = Nothing
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.SplitContainer1.Panel2, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.SplitContainer1.Panel2, CType(resources.GetObject("SplitContainer1.Panel2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.SplitContainer1.Panel2, Nothing)
        Me.HelpProvider1.SetShowHelp(Me.SplitContainer1.Panel2, CType(resources.GetObject("SplitContainer1.Panel2.ShowHelp"), Boolean))
        Me.HelpProvider1.SetShowHelp(Me.SplitContainer1, CType(resources.GetObject("SplitContainer1.ShowHelp"), Boolean))
        '
        'ProcTree
        '
        Me.ProcTree.AccessibleDescription = Nothing
        Me.ProcTree.AccessibleName = Nothing
        resources.ApplyResources(Me.ProcTree, "ProcTree")
        Me.ProcTree.BackgroundImage = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.ProcTree, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.ProcTree, CType(resources.GetObject("ProcTree.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ProcTree, Nothing)
        Me.ProcTree.HideSelection = False
        Me.ProcTree.Name = "ProcTree"
        Me.ProcTree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("ProcTree.Nodes"), System.Windows.Forms.TreeNode), CType(resources.GetObject("ProcTree.Nodes1"), System.Windows.Forms.TreeNode), CType(resources.GetObject("ProcTree.Nodes2"), System.Windows.Forms.TreeNode), CType(resources.GetObject("ProcTree.Nodes3"), System.Windows.Forms.TreeNode), CType(resources.GetObject("ProcTree.Nodes4"), System.Windows.Forms.TreeNode)})
        Me.HelpProvider1.SetShowHelp(Me.ProcTree, CType(resources.GetObject("ProcTree.ShowHelp"), Boolean))
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleDescription = Nothing
        Me.TabControl1.AccessibleName = Nothing
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.BackgroundImage = Nothing
        Me.TabControl1.Controls.Add(Me.Patient)
        Me.TabControl1.Controls.Add(Me.Procedure)
        Me.TabControl1.Controls.Add(Me.Device)
        Me.HelpProvider1.SetHelpKeyword(Me.TabControl1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.TabControl1, CType(resources.GetObject("TabControl1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.TabControl1, Nothing)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.HelpProvider1.SetShowHelp(Me.TabControl1, CType(resources.GetObject("TabControl1.ShowHelp"), Boolean))
        Me.TabControl1.TabStop = False
        '
        'Patient
        '
        Me.Patient.AccessibleDescription = Nothing
        Me.Patient.AccessibleName = Nothing
        resources.ApplyResources(Me.Patient, "Patient")
        Me.Patient.BackgroundImage = Nothing
        Me.Patient.Controls.Add(Me.PatientDataLabel)
        Me.Patient.Controls.Add(Me.GroupBox1)
        Me.Patient.Controls.Add(Me.PatientWeightTextBox)
        Me.Patient.Controls.Add(Me.HeightTextBox)
        Me.Patient.Controls.Add(Me.PatientWeightLabel)
        Me.Patient.Controls.Add(Me.HeightLabel)
        Me.Patient.Controls.Add(Me.MaskedTextBox1)
        Me.Patient.Controls.Add(Me.PatronymicTextBox)
        Me.Patient.Controls.Add(Me.GivenNameTextBox)
        Me.Patient.Controls.Add(Me.FamilyNameTextBox)
        Me.Patient.Controls.Add(Me.RegistryNumTextBox)
        Me.Patient.Controls.Add(Me.BirthDateLabel)
        Me.Patient.Controls.Add(Me.PatronymicLabel)
        Me.Patient.Controls.Add(Me.GivenNameLabel)
        Me.Patient.Controls.Add(Me.FamilyNameLabel)
        Me.Patient.Controls.Add(Me.RegistryNumLabel)
        Me.HelpProvider1.SetHelpKeyword(Me.Patient, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.Patient, CType(resources.GetObject("Patient.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Patient, Nothing)
        Me.Patient.Name = "Patient"
        Me.HelpProvider1.SetShowHelp(Me.Patient, CType(resources.GetObject("Patient.ShowHelp"), Boolean))
        Me.Patient.Text = Global.RentgenCalculator.My.Resources.Resources.PatientLabel
        Me.Patient.UseVisualStyleBackColor = True
        '
        'PatientDataLabel
        '
        Me.PatientDataLabel.AccessibleDescription = Nothing
        Me.PatientDataLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.PatientDataLabel, "PatientDataLabel")
        Me.HelpProvider1.SetHelpKeyword(Me.PatientDataLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.PatientDataLabel, CType(resources.GetObject("PatientDataLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.PatientDataLabel, Nothing)
        Me.PatientDataLabel.Name = "PatientDataLabel"
        Me.HelpProvider1.SetShowHelp(Me.PatientDataLabel, CType(resources.GetObject("PatientDataLabel.ShowHelp"), Boolean))
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = Nothing
        Me.GroupBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackgroundImage = Nothing
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.HelpProvider1.SetHelpKeyword(Me.GroupBox1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.GroupBox1, CType(resources.GetObject("GroupBox1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.GroupBox1, Nothing)
        Me.GroupBox1.Name = "GroupBox1"
        Me.HelpProvider1.SetShowHelp(Me.GroupBox1, CType(resources.GetObject("GroupBox1.ShowHelp"), Boolean))
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AccessibleDescription = Nothing
        Me.RadioButton2.AccessibleName = Nothing
        resources.ApplyResources(Me.RadioButton2, "RadioButton2")
        Me.RadioButton2.BackgroundImage = Nothing
        Me.RadioButton2.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.RadioButton2, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.RadioButton2, CType(resources.GetObject("RadioButton2.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.RadioButton2, Nothing)
        Me.RadioButton2.Name = "RadioButton2"
        Me.HelpProvider1.SetShowHelp(Me.RadioButton2, CType(resources.GetObject("RadioButton2.ShowHelp"), Boolean))
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = Global.RentgenCalculator.My.Resources.Resources.FemaleLabel
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AccessibleDescription = Nothing
        Me.RadioButton1.AccessibleName = Nothing
        resources.ApplyResources(Me.RadioButton1, "RadioButton1")
        Me.RadioButton1.BackgroundImage = Nothing
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.RadioButton1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.RadioButton1, CType(resources.GetObject("RadioButton1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.RadioButton1, Nothing)
        Me.RadioButton1.Name = "RadioButton1"
        Me.HelpProvider1.SetShowHelp(Me.RadioButton1, CType(resources.GetObject("RadioButton1.ShowHelp"), Boolean))
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = Global.RentgenCalculator.My.Resources.Resources.MaleLabel
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PatientWeightTextBox
        '
        Me.PatientWeightTextBox.AccessibleDescription = Nothing
        Me.PatientWeightTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.PatientWeightTextBox, "PatientWeightTextBox")
        Me.PatientWeightTextBox.BackgroundImage = Nothing
        Me.PatientWeightTextBox.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.PatientWeightTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.PatientWeightTextBox, CType(resources.GetObject("PatientWeightTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.PatientWeightTextBox, Nothing)
        Me.PatientWeightTextBox.Name = "PatientWeightTextBox"
        Me.HelpProvider1.SetShowHelp(Me.PatientWeightTextBox, CType(resources.GetObject("PatientWeightTextBox.ShowHelp"), Boolean))
        '
        'HeightTextBox
        '
        Me.HeightTextBox.AcceptsReturn = True
        Me.HeightTextBox.AcceptsTab = True
        resources.ApplyResources(Me.HeightTextBox, "HeightTextBox")
        Me.HeightTextBox.BackgroundImage = Nothing
        Me.HeightTextBox.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.HeightTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.HeightTextBox, CType(resources.GetObject("HeightTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.HeightTextBox, Nothing)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HelpProvider1.SetShowHelp(Me.HeightTextBox, CType(resources.GetObject("HeightTextBox.ShowHelp"), Boolean))
        '
        'PatientWeightLabel
        '
        Me.PatientWeightLabel.AccessibleDescription = Nothing
        Me.PatientWeightLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.PatientWeightLabel, "PatientWeightLabel")
        Me.PatientWeightLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.PatientWeightLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.PatientWeightLabel, CType(resources.GetObject("PatientWeightLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.PatientWeightLabel, Nothing)
        Me.PatientWeightLabel.Name = "PatientWeightLabel"
        Me.HelpProvider1.SetShowHelp(Me.PatientWeightLabel, CType(resources.GetObject("PatientWeightLabel.ShowHelp"), Boolean))
        '
        'HeightLabel
        '
        Me.HeightLabel.AccessibleDescription = Nothing
        Me.HeightLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.HeightLabel, "HeightLabel")
        Me.HeightLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.HeightLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.HeightLabel, CType(resources.GetObject("HeightLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.HeightLabel, Nothing)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HelpProvider1.SetShowHelp(Me.HeightLabel, CType(resources.GetObject("HeightLabel.ShowHelp"), Boolean))
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.AccessibleDescription = Nothing
        Me.MaskedTextBox1.AccessibleName = Nothing
        resources.ApplyResources(Me.MaskedTextBox1, "MaskedTextBox1")
        Me.MaskedTextBox1.BackgroundImage = Nothing
        Me.MaskedTextBox1.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.MaskedTextBox1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.MaskedTextBox1, CType(resources.GetObject("MaskedTextBox1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.MaskedTextBox1, Nothing)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.MaskedTextBox1, CType(resources.GetObject("MaskedTextBox1.ShowHelp"), Boolean))
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'PatronymicTextBox
        '
        Me.PatronymicTextBox.AccessibleDescription = Nothing
        Me.PatronymicTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.PatronymicTextBox, "PatronymicTextBox")
        Me.PatronymicTextBox.BackgroundImage = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.PatronymicTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.PatronymicTextBox, CType(resources.GetObject("PatronymicTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.PatronymicTextBox, Nothing)
        Me.PatronymicTextBox.Name = "PatronymicTextBox"
        Me.HelpProvider1.SetShowHelp(Me.PatronymicTextBox, CType(resources.GetObject("PatronymicTextBox.ShowHelp"), Boolean))
        '
        'GivenNameTextBox
        '
        Me.GivenNameTextBox.AccessibleDescription = Nothing
        Me.GivenNameTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.GivenNameTextBox, "GivenNameTextBox")
        Me.GivenNameTextBox.BackgroundImage = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.GivenNameTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.GivenNameTextBox, CType(resources.GetObject("GivenNameTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.GivenNameTextBox, Nothing)
        Me.GivenNameTextBox.Name = "GivenNameTextBox"
        Me.HelpProvider1.SetShowHelp(Me.GivenNameTextBox, CType(resources.GetObject("GivenNameTextBox.ShowHelp"), Boolean))
        '
        'FamilyNameTextBox
        '
        Me.FamilyNameTextBox.AccessibleDescription = Nothing
        Me.FamilyNameTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.FamilyNameTextBox, "FamilyNameTextBox")
        Me.FamilyNameTextBox.BackgroundImage = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.FamilyNameTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.FamilyNameTextBox, CType(resources.GetObject("FamilyNameTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FamilyNameTextBox, Nothing)
        Me.FamilyNameTextBox.Name = "FamilyNameTextBox"
        Me.HelpProvider1.SetShowHelp(Me.FamilyNameTextBox, CType(resources.GetObject("FamilyNameTextBox.ShowHelp"), Boolean))
        '
        'RegistryNumTextBox
        '
        Me.RegistryNumTextBox.AccessibleDescription = Nothing
        Me.RegistryNumTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.RegistryNumTextBox, "RegistryNumTextBox")
        Me.RegistryNumTextBox.BackgroundImage = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.RegistryNumTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.RegistryNumTextBox, CType(resources.GetObject("RegistryNumTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.RegistryNumTextBox, Nothing)
        Me.RegistryNumTextBox.Name = "RegistryNumTextBox"
        Me.HelpProvider1.SetShowHelp(Me.RegistryNumTextBox, CType(resources.GetObject("RegistryNumTextBox.ShowHelp"), Boolean))
        '
        'BirthDateLabel
        '
        Me.BirthDateLabel.AccessibleDescription = Nothing
        Me.BirthDateLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.BirthDateLabel, "BirthDateLabel")
        Me.BirthDateLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.BirthDateLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.BirthDateLabel, CType(resources.GetObject("BirthDateLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.BirthDateLabel, Nothing)
        Me.BirthDateLabel.Name = "BirthDateLabel"
        Me.HelpProvider1.SetShowHelp(Me.BirthDateLabel, CType(resources.GetObject("BirthDateLabel.ShowHelp"), Boolean))
        '
        'PatronymicLabel
        '
        Me.PatronymicLabel.AccessibleDescription = Nothing
        Me.PatronymicLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.PatronymicLabel, "PatronymicLabel")
        Me.HelpProvider1.SetHelpKeyword(Me.PatronymicLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.PatronymicLabel, CType(resources.GetObject("PatronymicLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.PatronymicLabel, Nothing)
        Me.PatronymicLabel.Name = "PatronymicLabel"
        Me.HelpProvider1.SetShowHelp(Me.PatronymicLabel, CType(resources.GetObject("PatronymicLabel.ShowHelp"), Boolean))
        '
        'GivenNameLabel
        '
        Me.GivenNameLabel.AccessibleDescription = Nothing
        Me.GivenNameLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.GivenNameLabel, "GivenNameLabel")
        Me.HelpProvider1.SetHelpKeyword(Me.GivenNameLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.GivenNameLabel, CType(resources.GetObject("GivenNameLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.GivenNameLabel, Nothing)
        Me.GivenNameLabel.Name = "GivenNameLabel"
        Me.HelpProvider1.SetShowHelp(Me.GivenNameLabel, CType(resources.GetObject("GivenNameLabel.ShowHelp"), Boolean))
        '
        'FamilyNameLabel
        '
        Me.FamilyNameLabel.AccessibleDescription = Nothing
        Me.FamilyNameLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.FamilyNameLabel, "FamilyNameLabel")
        Me.HelpProvider1.SetHelpKeyword(Me.FamilyNameLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.FamilyNameLabel, CType(resources.GetObject("FamilyNameLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FamilyNameLabel, Nothing)
        Me.FamilyNameLabel.Name = "FamilyNameLabel"
        Me.HelpProvider1.SetShowHelp(Me.FamilyNameLabel, CType(resources.GetObject("FamilyNameLabel.ShowHelp"), Boolean))
        '
        'RegistryNumLabel
        '
        Me.RegistryNumLabel.AccessibleDescription = Nothing
        Me.RegistryNumLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.RegistryNumLabel, "RegistryNumLabel")
        Me.HelpProvider1.SetHelpKeyword(Me.RegistryNumLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.RegistryNumLabel, CType(resources.GetObject("RegistryNumLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.RegistryNumLabel, Nothing)
        Me.RegistryNumLabel.Name = "RegistryNumLabel"
        Me.HelpProvider1.SetShowHelp(Me.RegistryNumLabel, CType(resources.GetObject("RegistryNumLabel.ShowHelp"), Boolean))
        '
        'Procedure
        '
        Me.Procedure.AccessibleDescription = Nothing
        Me.Procedure.AccessibleName = Nothing
        resources.ApplyResources(Me.Procedure, "Procedure")
        Me.Procedure.BackgroundImage = Nothing
        Me.Procedure.Controls.Add(Me.RippleTextBox)
        Me.Procedure.Controls.Add(Me.RippleLabel)
        Me.Procedure.Controls.Add(Me.FilterTextBox)
        Me.Procedure.Controls.Add(Me.FilterLabel)
        Me.Procedure.Controls.Add(Me.FieldSizeComboBox)
        Me.Procedure.Controls.Add(Me.FieldSizeLabel)
        Me.Procedure.Controls.Add(Me.FIDComboBox)
        Me.Procedure.Controls.Add(Me.FIDLabel)
        Me.Procedure.Controls.Add(Me.VoltageProcTextBox)
        Me.Procedure.Controls.Add(Me.VoltageProcLabel)
        Me.Procedure.Controls.Add(Me.mAsLabel)
        Me.Procedure.Controls.Add(Me.mAsTextBox)
        Me.Procedure.Controls.Add(Me.ProcedureParamsLabel)
        Me.Procedure.Controls.Add(Me.ExaminationDateLabel)
        Me.Procedure.Controls.Add(Me.ProcedureDataGridView)
        Me.Procedure.Controls.Add(Me.DateTimePicker1)
        Me.Procedure.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Procedure.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.Procedure, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.Procedure, CType(resources.GetObject("Procedure.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Procedure, Nothing)
        Me.Procedure.Name = "Procedure"
        Me.HelpProvider1.SetShowHelp(Me.Procedure, CType(resources.GetObject("Procedure.ShowHelp"), Boolean))
        Me.Procedure.Text = Global.RentgenCalculator.My.Resources.Resources.ProcNameLabel
        Me.Procedure.UseVisualStyleBackColor = True
        '
        'RippleTextBox
        '
        Me.RippleTextBox.AccessibleDescription = Nothing
        Me.RippleTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.RippleTextBox, "RippleTextBox")
        Me.RippleTextBox.BackgroundImage = Nothing
        Me.RippleTextBox.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.RippleTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.RippleTextBox, CType(resources.GetObject("RippleTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.RippleTextBox, Nothing)
        Me.RippleTextBox.Name = "RippleTextBox"
        Me.HelpProvider1.SetShowHelp(Me.RippleTextBox, CType(resources.GetObject("RippleTextBox.ShowHelp"), Boolean))
        '
        'RippleLabel
        '
        Me.RippleLabel.AccessibleDescription = Nothing
        Me.RippleLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.RippleLabel, "RippleLabel")
        Me.RippleLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.RippleLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.RippleLabel, CType(resources.GetObject("RippleLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.RippleLabel, Nothing)
        Me.RippleLabel.Name = "RippleLabel"
        Me.HelpProvider1.SetShowHelp(Me.RippleLabel, CType(resources.GetObject("RippleLabel.ShowHelp"), Boolean))
        '
        'FilterTextBox
        '
        Me.FilterTextBox.AccessibleDescription = Nothing
        Me.FilterTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.FilterTextBox, "FilterTextBox")
        Me.FilterTextBox.BackgroundImage = Nothing
        Me.FilterTextBox.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.FilterTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.FilterTextBox, CType(resources.GetObject("FilterTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FilterTextBox, Nothing)
        Me.FilterTextBox.Name = "FilterTextBox"
        Me.HelpProvider1.SetShowHelp(Me.FilterTextBox, CType(resources.GetObject("FilterTextBox.ShowHelp"), Boolean))
        '
        'FilterLabel
        '
        Me.FilterLabel.AccessibleDescription = Nothing
        Me.FilterLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.FilterLabel, "FilterLabel")
        Me.FilterLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.FilterLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.FilterLabel, CType(resources.GetObject("FilterLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FilterLabel, Nothing)
        Me.FilterLabel.Name = "FilterLabel"
        Me.HelpProvider1.SetShowHelp(Me.FilterLabel, CType(resources.GetObject("FilterLabel.ShowHelp"), Boolean))
        '
        'FieldSizeComboBox
        '
        Me.FieldSizeComboBox.AccessibleDescription = Nothing
        Me.FieldSizeComboBox.AccessibleName = Nothing
        resources.ApplyResources(Me.FieldSizeComboBox, "FieldSizeComboBox")
        Me.FieldSizeComboBox.BackgroundImage = Nothing
        Me.FieldSizeComboBox.Font = Nothing
        Me.FieldSizeComboBox.FormatString = "00x00"
        Me.FieldSizeComboBox.FormattingEnabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.FieldSizeComboBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.FieldSizeComboBox, CType(resources.GetObject("FieldSizeComboBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FieldSizeComboBox, Nothing)
        Me.FieldSizeComboBox.Name = "FieldSizeComboBox"
        Me.HelpProvider1.SetShowHelp(Me.FieldSizeComboBox, CType(resources.GetObject("FieldSizeComboBox.ShowHelp"), Boolean))
        '
        'FieldSizeLabel
        '
        Me.FieldSizeLabel.AccessibleDescription = Nothing
        Me.FieldSizeLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.FieldSizeLabel, "FieldSizeLabel")
        Me.FieldSizeLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.FieldSizeLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.FieldSizeLabel, CType(resources.GetObject("FieldSizeLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FieldSizeLabel, Nothing)
        Me.FieldSizeLabel.Name = "FieldSizeLabel"
        Me.HelpProvider1.SetShowHelp(Me.FieldSizeLabel, CType(resources.GetObject("FieldSizeLabel.ShowHelp"), Boolean))
        '
        'FIDComboBox
        '
        Me.FIDComboBox.AccessibleDescription = Nothing
        Me.FIDComboBox.AccessibleName = Nothing
        resources.ApplyResources(Me.FIDComboBox, "FIDComboBox")
        Me.FIDComboBox.BackgroundImage = Nothing
        Me.FIDComboBox.Font = Nothing
        Me.FIDComboBox.FormattingEnabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.FIDComboBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.FIDComboBox, CType(resources.GetObject("FIDComboBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FIDComboBox, Nothing)
        Me.FIDComboBox.Name = "FIDComboBox"
        Me.HelpProvider1.SetShowHelp(Me.FIDComboBox, CType(resources.GetObject("FIDComboBox.ShowHelp"), Boolean))
        '
        'FIDLabel
        '
        Me.FIDLabel.AccessibleDescription = Nothing
        Me.FIDLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.FIDLabel, "FIDLabel")
        Me.FIDLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.FIDLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.FIDLabel, CType(resources.GetObject("FIDLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.FIDLabel, Nothing)
        Me.FIDLabel.Name = "FIDLabel"
        Me.HelpProvider1.SetShowHelp(Me.FIDLabel, CType(resources.GetObject("FIDLabel.ShowHelp"), Boolean))
        '
        'VoltageProcTextBox
        '
        Me.VoltageProcTextBox.AccessibleDescription = Nothing
        Me.VoltageProcTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.VoltageProcTextBox, "VoltageProcTextBox")
        Me.VoltageProcTextBox.BackgroundImage = Nothing
        Me.VoltageProcTextBox.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.VoltageProcTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.VoltageProcTextBox, CType(resources.GetObject("VoltageProcTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.VoltageProcTextBox, Nothing)
        Me.VoltageProcTextBox.Name = "VoltageProcTextBox"
        Me.HelpProvider1.SetShowHelp(Me.VoltageProcTextBox, CType(resources.GetObject("VoltageProcTextBox.ShowHelp"), Boolean))
        '
        'VoltageProcLabel
        '
        Me.VoltageProcLabel.AccessibleDescription = Nothing
        Me.VoltageProcLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.VoltageProcLabel, "VoltageProcLabel")
        Me.VoltageProcLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.VoltageProcLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.VoltageProcLabel, CType(resources.GetObject("VoltageProcLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.VoltageProcLabel, Nothing)
        Me.VoltageProcLabel.Name = "VoltageProcLabel"
        Me.HelpProvider1.SetShowHelp(Me.VoltageProcLabel, CType(resources.GetObject("VoltageProcLabel.ShowHelp"), Boolean))
        '
        'mAsLabel
        '
        Me.mAsLabel.AccessibleDescription = Nothing
        Me.mAsLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.mAsLabel, "mAsLabel")
        Me.mAsLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.mAsLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.mAsLabel, CType(resources.GetObject("mAsLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.mAsLabel, Nothing)
        Me.mAsLabel.Name = "mAsLabel"
        Me.HelpProvider1.SetShowHelp(Me.mAsLabel, CType(resources.GetObject("mAsLabel.ShowHelp"), Boolean))
        '
        'mAsTextBox
        '
        Me.mAsTextBox.AccessibleDescription = Nothing
        Me.mAsTextBox.AccessibleName = Nothing
        resources.ApplyResources(Me.mAsTextBox, "mAsTextBox")
        Me.mAsTextBox.BackgroundImage = Nothing
        Me.mAsTextBox.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.mAsTextBox, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.mAsTextBox, CType(resources.GetObject("mAsTextBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.mAsTextBox, Nothing)
        Me.mAsTextBox.Name = "mAsTextBox"
        Me.HelpProvider1.SetShowHelp(Me.mAsTextBox, CType(resources.GetObject("mAsTextBox.ShowHelp"), Boolean))
        '
        'ProcedureParamsLabel
        '
        Me.ProcedureParamsLabel.AccessibleDescription = Nothing
        Me.ProcedureParamsLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.ProcedureParamsLabel, "ProcedureParamsLabel")
        Me.HelpProvider1.SetHelpKeyword(Me.ProcedureParamsLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.ProcedureParamsLabel, CType(resources.GetObject("ProcedureParamsLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ProcedureParamsLabel, Nothing)
        Me.ProcedureParamsLabel.Name = "ProcedureParamsLabel"
        Me.HelpProvider1.SetShowHelp(Me.ProcedureParamsLabel, CType(resources.GetObject("ProcedureParamsLabel.ShowHelp"), Boolean))
        '
        'ExaminationDateLabel
        '
        Me.ExaminationDateLabel.AccessibleDescription = Nothing
        Me.ExaminationDateLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.ExaminationDateLabel, "ExaminationDateLabel")
        Me.ExaminationDateLabel.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.ExaminationDateLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.ExaminationDateLabel, CType(resources.GetObject("ExaminationDateLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ExaminationDateLabel, Nothing)
        Me.ExaminationDateLabel.Name = "ExaminationDateLabel"
        Me.HelpProvider1.SetShowHelp(Me.ExaminationDateLabel, CType(resources.GetObject("ExaminationDateLabel.ShowHelp"), Boolean))
        '
        'ProcedureDataGridView
        '
        Me.ProcedureDataGridView.AccessibleDescription = Nothing
        Me.ProcedureDataGridView.AccessibleName = Nothing
        resources.ApplyResources(Me.ProcedureDataGridView, "ProcedureDataGridView")
        Me.ProcedureDataGridView.AutoGenerateColumns = False
        Me.ProcedureDataGridView.BackgroundImage = Nothing
        Me.ProcedureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProcedureDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FID, Me.PowerDataGridViewTextBoxColumn, Me.ProcedureCodeDataGridViewTextBoxColumn, Me.FieldWidthDataGridViewTextBoxColumn, Me.FieldHeightDataGridViewTextBoxColumn, Me.FilterDataGridViewTextBoxColumn, Me.ripple})
        Me.ProcedureDataGridView.DataSource = Me.ProceduresListBindingSource
        Me.ProcedureDataGridView.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.ProcedureDataGridView, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.ProcedureDataGridView, CType(resources.GetObject("ProcedureDataGridView.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ProcedureDataGridView, Nothing)
        Me.ProcedureDataGridView.MultiSelect = False
        Me.ProcedureDataGridView.Name = "ProcedureDataGridView"
        Me.ProcedureDataGridView.RowTemplate.Height = 24
        Me.ProcedureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ProcedureDataGridView.ShowCellToolTips = False
        Me.HelpProvider1.SetShowHelp(Me.ProcedureDataGridView, CType(resources.GetObject("ProcedureDataGridView.ShowHelp"), Boolean))
        '
        'FID
        '
        Me.FID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FID.DataPropertyName = "FID"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FID.DefaultCellStyle = DataGridViewCellStyle1
        Me.FID.Frozen = True
        Me.FID.HeaderText = Global.RentgenCalculator.My.Resources.Resources.FFDHeader
        resources.ApplyResources(Me.FID, "FID")
        Me.FID.Name = "FID"
        Me.FID.ReadOnly = True
        '
        'PowerDataGridViewTextBoxColumn
        '
        Me.PowerDataGridViewTextBoxColumn.DataPropertyName = "Power"
        Me.PowerDataGridViewTextBoxColumn.FillWeight = 58.43952!
        resources.ApplyResources(Me.PowerDataGridViewTextBoxColumn, "PowerDataGridViewTextBoxColumn")
        Me.PowerDataGridViewTextBoxColumn.Name = "PowerDataGridViewTextBoxColumn"
        '
        'ProcedureCodeDataGridViewTextBoxColumn
        '
        Me.ProcedureCodeDataGridViewTextBoxColumn.DataPropertyName = "ProcedureCode"
        resources.ApplyResources(Me.ProcedureCodeDataGridViewTextBoxColumn, "ProcedureCodeDataGridViewTextBoxColumn")
        Me.ProcedureCodeDataGridViewTextBoxColumn.Name = "ProcedureCodeDataGridViewTextBoxColumn"
        '
        'FieldWidthDataGridViewTextBoxColumn
        '
        Me.FieldWidthDataGridViewTextBoxColumn.DataPropertyName = "FieldWidth"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FieldWidthDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FieldWidthDataGridViewTextBoxColumn.FillWeight = 58.43952!
        Me.FieldWidthDataGridViewTextBoxColumn.HeaderText = Global.RentgenCalculator.My.Resources.Resources.WidthLabel
        resources.ApplyResources(Me.FieldWidthDataGridViewTextBoxColumn, "FieldWidthDataGridViewTextBoxColumn")
        Me.FieldWidthDataGridViewTextBoxColumn.Name = "FieldWidthDataGridViewTextBoxColumn"
        Me.FieldWidthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FieldHeightDataGridViewTextBoxColumn
        '
        Me.FieldHeightDataGridViewTextBoxColumn.DataPropertyName = "FieldHeight"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FieldHeightDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FieldHeightDataGridViewTextBoxColumn.FillWeight = 58.43952!
        Me.FieldHeightDataGridViewTextBoxColumn.HeaderText = Global.RentgenCalculator.My.Resources.Resources.FieldHeightLabel
        resources.ApplyResources(Me.FieldHeightDataGridViewTextBoxColumn, "FieldHeightDataGridViewTextBoxColumn")
        Me.FieldHeightDataGridViewTextBoxColumn.Name = "FieldHeightDataGridViewTextBoxColumn"
        Me.FieldHeightDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FilterDataGridViewTextBoxColumn
        '
        Me.FilterDataGridViewTextBoxColumn.DataPropertyName = "Filter"
        Me.FilterDataGridViewTextBoxColumn.FillWeight = 58.43952!
        Me.FilterDataGridViewTextBoxColumn.HeaderText = Global.RentgenCalculator.My.Resources.Resources.FilterHeader
        resources.ApplyResources(Me.FilterDataGridViewTextBoxColumn, "FilterDataGridViewTextBoxColumn")
        Me.FilterDataGridViewTextBoxColumn.Name = "FilterDataGridViewTextBoxColumn"
        '
        'ripple
        '
        Me.ripple.DataPropertyName = "ripple"
        resources.ApplyResources(Me.ripple, "ripple")
        Me.ripple.Name = "ripple"
        '
        'ProceduresListBindingSource
        '
        Me.ProceduresListBindingSource.DataMember = "ProceduresList"
        Me.ProceduresListBindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "DataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.AccessibleDescription = Nothing
        Me.DateTimePicker1.AccessibleName = Nothing
        resources.ApplyResources(Me.DateTimePicker1, "DateTimePicker1")
        Me.DateTimePicker1.BackgroundImage = Nothing
        Me.DateTimePicker1.CalendarFont = Nothing
        Me.DateTimePicker1.CustomFormat = Nothing
        Me.DateTimePicker1.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.DateTimePicker1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.DateTimePicker1, CType(resources.GetObject("DateTimePicker1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.DateTimePicker1, Nothing)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.HelpProvider1.SetShowHelp(Me.DateTimePicker1, CType(resources.GetObject("DateTimePicker1.ShowHelp"), Boolean))
        '
        'Device
        '
        Me.Device.AccessibleDescription = Nothing
        Me.Device.AccessibleName = Nothing
        resources.ApplyResources(Me.Device, "Device")
        Me.Device.BackgroundImage = Nothing
        Me.Device.Controls.Add(Me.DataGridView1)
        Me.Device.Controls.Add(Me.ToolStrip1)
        Me.Device.Controls.Add(Me.XRayUnitListLabel)
        Me.Device.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Device.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.Device, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.Device, CType(resources.GetObject("Device.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Device, Nothing)
        Me.Device.Name = "Device"
        Me.HelpProvider1.SetShowHelp(Me.Device, CType(resources.GetObject("Device.ShowHelp"), Boolean))
        Me.Device.Text = Global.RentgenCalculator.My.Resources.Resources.ApparTitle
        Me.Device.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleDescription = Nothing
        Me.DataGridView1.AccessibleName = Nothing
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundImage = Nothing
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyField, Me.DeviceNumberDataGridViewTextBoxColumn, Me.DeviceNameDataGridViewTextBoxColumn, Me.YieldDataGridViewTextBoxColumn, Me.Rip, Me.PowerDataGridViewTextBoxColumn1, Me.FilterDataGridViewTextBoxColumn1, Me.CommentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MyDevicesListBindingSource
        Me.DataGridView1.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.DataGridView1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.DataGridView1, CType(resources.GetObject("DataGridView1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.DataGridView1, Nothing)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.HelpProvider1.SetShowHelp(Me.DataGridView1, CType(resources.GetObject("DataGridView1.ShowHelp"), Boolean))
        '
        'KeyField
        '
        Me.KeyField.DataPropertyName = "IntKey"
        resources.ApplyResources(Me.KeyField, "KeyField")
        Me.KeyField.Name = "KeyField"
        '
        'DeviceNumberDataGridViewTextBoxColumn
        '
        Me.DeviceNumberDataGridViewTextBoxColumn.DataPropertyName = "DeviceNumber"
        resources.ApplyResources(Me.DeviceNumberDataGridViewTextBoxColumn, "DeviceNumberDataGridViewTextBoxColumn")
        Me.DeviceNumberDataGridViewTextBoxColumn.Name = "DeviceNumberDataGridViewTextBoxColumn"
        '
        'DeviceNameDataGridViewTextBoxColumn
        '
        Me.DeviceNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceName"
        Me.DeviceNameDataGridViewTextBoxColumn.HeaderText = Global.RentgenCalculator.My.Resources.Resources.Title
        resources.ApplyResources(Me.DeviceNameDataGridViewTextBoxColumn, "DeviceNameDataGridViewTextBoxColumn")
        Me.DeviceNameDataGridViewTextBoxColumn.Name = "DeviceNameDataGridViewTextBoxColumn"
        '
        'YieldDataGridViewTextBoxColumn
        '
        Me.YieldDataGridViewTextBoxColumn.DataPropertyName = "Yield"
        resources.ApplyResources(Me.YieldDataGridViewTextBoxColumn, "YieldDataGridViewTextBoxColumn")
        Me.YieldDataGridViewTextBoxColumn.Name = "YieldDataGridViewTextBoxColumn"
        '
        'Rip
        '
        Me.Rip.DataPropertyName = "Rip"
        Me.Rip.HeaderText = Global.RentgenCalculator.My.Resources.Resources.FFDHeader
        resources.ApplyResources(Me.Rip, "Rip")
        Me.Rip.Name = "Rip"
        '
        'PowerDataGridViewTextBoxColumn1
        '
        Me.PowerDataGridViewTextBoxColumn1.DataPropertyName = "Power"
        resources.ApplyResources(Me.PowerDataGridViewTextBoxColumn1, "PowerDataGridViewTextBoxColumn1")
        Me.PowerDataGridViewTextBoxColumn1.Name = "PowerDataGridViewTextBoxColumn1"
        '
        'FilterDataGridViewTextBoxColumn1
        '
        Me.FilterDataGridViewTextBoxColumn1.DataPropertyName = "Filter"
        Me.FilterDataGridViewTextBoxColumn1.HeaderText = Global.RentgenCalculator.My.Resources.Resources.FilterHeader
        resources.ApplyResources(Me.FilterDataGridViewTextBoxColumn1, "FilterDataGridViewTextBoxColumn1")
        Me.FilterDataGridViewTextBoxColumn1.Name = "FilterDataGridViewTextBoxColumn1"
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        resources.ApplyResources(Me.CommentsDataGridViewTextBoxColumn, "CommentsDataGridViewTextBoxColumn")
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        '
        'MyDevicesListBindingSource
        '
        Me.MyDevicesListBindingSource.DataMember = "MyDevicesList"
        Me.MyDevicesListBindingSource.DataSource = Me.DataDataSet
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AccessibleDescription = Nothing
        Me.ToolStrip1.AccessibleName = Nothing
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.BackgroundImage = Nothing
        Me.ToolStrip1.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.ToolStrip1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.ToolStrip1, CType(resources.GetObject("ToolStrip1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ToolStrip1, Nothing)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3})
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HelpProvider1.SetShowHelp(Me.ToolStrip1, CType(resources.GetObject("ToolStrip1.ShowHelp"), Boolean))
        Me.ToolStrip1.Stretch = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AccessibleDescription = Nothing
        Me.ToolStripLabel1.AccessibleName = Nothing
        resources.ApplyResources(Me.ToolStripLabel1, "ToolStripLabel1")
        Me.ToolStripLabel1.BackgroundImage = Nothing
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Text = Global.RentgenCalculator.My.Resources.Resources.AddNewApparLabel
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AccessibleDescription = Nothing
        Me.ToolStripLabel2.AccessibleName = Nothing
        resources.ApplyResources(Me.ToolStripLabel2, "ToolStripLabel2")
        Me.ToolStripLabel2.BackgroundImage = Nothing
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Text = Global.RentgenCalculator.My.Resources.Resources.RemoveApparLabel
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.AccessibleDescription = Nothing
        Me.ToolStripLabel3.AccessibleName = Nothing
        resources.ApplyResources(Me.ToolStripLabel3, "ToolStripLabel3")
        Me.ToolStripLabel3.BackgroundImage = Nothing
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Text = Global.RentgenCalculator.My.Resources.Resources.SaveAppSettingsLabel
        Me.ToolStripLabel3.ToolTipText = Global.RentgenCalculator.My.Resources.Resources.TipSaveAppSettings
        '
        'XRayUnitListLabel
        '
        Me.XRayUnitListLabel.AccessibleDescription = Nothing
        Me.XRayUnitListLabel.AccessibleName = Nothing
        resources.ApplyResources(Me.XRayUnitListLabel, "XRayUnitListLabel")
        Me.HelpProvider1.SetHelpKeyword(Me.XRayUnitListLabel, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.XRayUnitListLabel, CType(resources.GetObject("XRayUnitListLabel.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.XRayUnitListLabel, Nothing)
        Me.XRayUnitListLabel.Name = "XRayUnitListLabel"
        Me.HelpProvider1.SetShowHelp(Me.XRayUnitListLabel, CType(resources.GetObject("XRayUnitListLabel.ShowHelp"), Boolean))
        '
        'ExitButton
        '
        Me.ExitButton.AccessibleDescription = Nothing
        Me.ExitButton.AccessibleName = Nothing
        resources.ApplyResources(Me.ExitButton, "ExitButton")
        Me.ExitButton.BackgroundImage = Nothing
        Me.ExitButton.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.ExitButton, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.ExitButton, CType(resources.GetObject("ExitButton.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.ExitButton, Nothing)
        Me.ExitButton.Name = "ExitButton"
        Me.HelpProvider1.SetShowHelp(Me.ExitButton, CType(resources.GetObject("ExitButton.ShowHelp"), Boolean))
        Me.ExitButton.Text = Global.RentgenCalculator.My.Resources.Resources.ExitButtonText
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RunButton
        '
        Me.RunButton.AccessibleDescription = Nothing
        Me.RunButton.AccessibleName = Nothing
        resources.ApplyResources(Me.RunButton, "RunButton")
        Me.RunButton.BackgroundImage = Nothing
        Me.RunButton.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.RunButton, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.RunButton, CType(resources.GetObject("RunButton.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.RunButton, Nothing)
        Me.RunButton.Name = "RunButton"
        Me.HelpProvider1.SetShowHelp(Me.RunButton, CType(resources.GetObject("RunButton.ShowHelp"), Boolean))
        Me.RunButton.Text = Global.RentgenCalculator.My.Resources.Resources.RunButtonText
        Me.RunButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")
        '
        'HelpProvider1
        '
        resources.ApplyResources(Me.HelpProvider1, "HelpProvider1")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AccessibleDescription = Nothing
        Me.MenuStrip1.AccessibleName = Nothing
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackgroundImage = Nothing
        Me.MenuStrip1.Font = Nothing
        Me.HelpProvider1.SetHelpKeyword(Me.MenuStrip1, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me.MenuStrip1, CType(resources.GetObject("MenuStrip1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.MenuStrip1, Nothing)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.MinimumSize = New System.Drawing.Size(140, 38)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.HelpProvider1.SetShowHelp(Me.MenuStrip1, CType(resources.GetObject("MenuStrip1.ShowHelp"), Boolean))
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.AccessibleDescription = Nothing
        Me.FileToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        Me.FileToolStripMenuItem.BackgroundImage = Nothing
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.toolStripSeparator, Me.PrintToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        Me.FileToolStripMenuItem.Text = Global.RentgenCalculator.My.Resources.Resources.FileMnuItem
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.AccessibleDescription = Nothing
        Me.OpenToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        Me.OpenToolStripMenuItem.BackgroundImage = Nothing
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        Me.OpenToolStripMenuItem.Text = Global.RentgenCalculator.My.Resources.Resources.OpenMnuItem
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.AccessibleDescription = Nothing
        Me.SettingsToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.SettingsToolStripMenuItem, "SettingsToolStripMenuItem")
        Me.SettingsToolStripMenuItem.BackgroundImage = Nothing
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        Me.SettingsToolStripMenuItem.Text = Global.RentgenCalculator.My.Resources.Resources.SettingsLabel
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.AccessibleDescription = Nothing
        Me.toolStripSeparator.AccessibleName = Nothing
        resources.ApplyResources(Me.toolStripSeparator, "toolStripSeparator")
        Me.toolStripSeparator.Name = "toolStripSeparator"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.AccessibleDescription = Nothing
        Me.PrintToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.PrintToolStripMenuItem, "PrintToolStripMenuItem")
        Me.PrintToolStripMenuItem.BackgroundImage = Nothing
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        Me.PrintToolStripMenuItem.Text = Global.RentgenCalculator.My.Resources.Resources.PrintMnuItem
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.AccessibleDescription = Nothing
        Me.toolStripSeparator2.AccessibleName = Nothing
        resources.ApplyResources(Me.toolStripSeparator2, "toolStripSeparator2")
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.AccessibleDescription = Nothing
        Me.ExitToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        Me.ExitToolStripMenuItem.BackgroundImage = Nothing
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        Me.ExitToolStripMenuItem.Text = Global.RentgenCalculator.My.Resources.Resources.ExitButtonText
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.AccessibleDescription = Nothing
        Me.HelpToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        Me.HelpToolStripMenuItem.BackgroundImage = Nothing
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        Me.HelpToolStripMenuItem.Text = Global.RentgenCalculator.My.Resources.Resources.HelpMnuItem
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.AccessibleDescription = Nothing
        Me.ContentsToolStripMenuItem.AccessibleName = Nothing
        resources.ApplyResources(Me.ContentsToolStripMenuItem, "ContentsToolStripMenuItem")
        Me.ContentsToolStripMenuItem.BackgroundImage = Nothing
        Me.ContentsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeyDisplayString = Nothing
        Me.ContentsToolStripMenuItem.Text = Global.RentgenCalculator.My.Resources.Resources.HelpContMnuItem
        '
        'MyDevicesListTableAdapter
        '
        Me.MyDevicesListTableAdapter.ClearBeforeFill = True
        '
        'ProceduresListTableAdapter
        '
        Me.ProceduresListTableAdapter.ClearBeforeFill = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AccessibleDescription = Nothing
        Me.ToolStripButton1.AccessibleName = Nothing
        resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
        Me.ToolStripButton1.BackgroundImage = Nothing
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Text = Global.RentgenCalculator.My.Resources.Resources.AddNewApparLabel
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AccessibleDescription = Nothing
        Me.ToolStripButton2.AccessibleName = Nothing
        resources.ApplyResources(Me.ToolStripButton2, "ToolStripButton2")
        Me.ToolStripButton2.BackgroundImage = Nothing
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Text = Global.RentgenCalculator.My.Resources.Resources.RemoveApparLabel
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AccessibleDescription = Nothing
        Me.ToolStripButton3.AccessibleName = Nothing
        resources.ApplyResources(Me.ToolStripButton3, "ToolStripButton3")
        Me.ToolStripButton3.BackgroundImage = Nothing
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Text = Global.RentgenCalculator.My.Resources.Resources.SaveAppSettingsLabel
        Me.ToolStripButton3.ToolTipText = Global.RentgenCalculator.My.Resources.Resources.TipSaveAppSettings
        '
        'MainForm
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RunButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Font = Nothing
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpKeyword(Me, Nothing)
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, Nothing)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Patient.ResumeLayout(False)
        Me.Patient.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Procedure.ResumeLayout(False)
        Me.Procedure.PerformLayout()
        CType(Me.ProcedureDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProceduresListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Device.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDevicesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents DataDataSet As RentgenCalculator.DataDataSet
    Friend WithEvents MyDevicesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MyDevicesListTableAdapter As RentgenCalculator.DataDataSetTableAdapters.MyDevicesListTableAdapter
    Friend WithEvents ProceduresListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProceduresListTableAdapter As RentgenCalculator.DataDataSetTableAdapters.ProceduresListTableAdapter
    Friend WithEvents RunButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Patient As System.Windows.Forms.TabPage
    Friend WithEvents PatientDataLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PatientWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientWeightLabel As System.Windows.Forms.Label
    Friend WithEvents HeightLabel As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PatronymicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GivenNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FamilyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegistryNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthDateLabel As System.Windows.Forms.Label
    Friend WithEvents PatronymicLabel As System.Windows.Forms.Label
    Friend WithEvents GivenNameLabel As System.Windows.Forms.Label
    Friend WithEvents FamilyNameLabel As System.Windows.Forms.Label
    Friend WithEvents RegistryNumLabel As System.Windows.Forms.Label
    Friend WithEvents Procedure As System.Windows.Forms.TabPage
    Friend WithEvents ProcedureParamsLabel As System.Windows.Forms.Label
    Friend WithEvents ExaminationDateLabel As System.Windows.Forms.Label
    Friend WithEvents ProcedureDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Device As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents XRayUnitListLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcTree As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mAsLabel As System.Windows.Forms.Label
    Friend WithEvents mAsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VoltageProcLabel As System.Windows.Forms.Label
    Friend WithEvents VoltageProcTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIDLabel As System.Windows.Forms.Label
    Friend WithEvents FIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FieldSizeLabel As System.Windows.Forms.Label
    Friend WithEvents FieldSizeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FilterLabel As System.Windows.Forms.Label
    Friend WithEvents FilterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RippleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RippleLabel As System.Windows.Forms.Label
    Friend WithEvents FID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcedureCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FieldWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FieldHeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ripple As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents KeyField As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YieldDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PowerDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilterDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

    'Friend WithEvents processdatagridviewkey As RentgenCalculator.Class1
End Class