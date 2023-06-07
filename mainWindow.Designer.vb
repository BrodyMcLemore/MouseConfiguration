<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.minimizeButton = New System.Windows.Forms.PictureBox()
        Me.maximizeButton = New System.Windows.Forms.PictureBox()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.menuButton = New System.Windows.Forms.PictureBox()
        Me.sideMenuPanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.openMenuButton = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.addMenuButton = New System.Windows.Forms.PictureBox()
        Me.addToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.openToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.addConfigPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.addMainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.handLabel = New System.Windows.Forms.Label()
        Me.addMainTitle = New System.Windows.Forms.Label()
        Me.primaryColorLabel = New System.Windows.Forms.Label()
        Me.secondColorLabel = New System.Windows.Forms.Label()
        Me.sizeLabel = New System.Windows.Forms.Label()
        Me.brandLabel = New System.Windows.Forms.Label()
        Me.secondayColorBox = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.sizeSmallButton = New System.Windows.Forms.RadioButton()
        Me.sizeMediumButton = New System.Windows.Forms.RadioButton()
        Me.sizeLargeButton = New System.Windows.Forms.RadioButton()
        Me.brandTextBox = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.handLeftButton = New System.Windows.Forms.RadioButton()
        Me.handRightButton = New System.Windows.Forms.RadioButton()
        Me.handBothButton = New System.Windows.Forms.RadioButton()
        Me.controlButtonStrip = New System.Windows.Forms.ToolStrip()
        Me.saveButton = New System.Windows.Forms.ToolStripLabel()
        Me.saveAndCloseButton = New System.Windows.Forms.ToolStripLabel()
        Me.clearAllButton = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.fileNameLabel = New System.Windows.Forms.ToolStripLabel()
        Me.fileNameTextbox = New System.Windows.Forms.ToolStripTextBox()
        Me.primaryColorBox = New System.Windows.Forms.PictureBox()
        Me.addSecondPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sideScrolLabel = New System.Windows.Forms.Label()
        Me.forwardBackLabel = New System.Windows.Forms.Label()
        Me.ergoLabel = New System.Windows.Forms.Label()
        Me.clickLabel = New System.Windows.Forms.Label()
        Me.purposeLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.sideScrollYesButton = New System.Windows.Forms.RadioButton()
        Me.sideScrollNoButton = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.navYesButton = New System.Windows.Forms.RadioButton()
        Me.navNoButton = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ergoYesButton = New System.Windows.Forms.RadioButton()
        Me.ergoNoButton = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.silentYesButton = New System.Windows.Forms.RadioButton()
        Me.silentNoButton = New System.Windows.Forms.RadioButton()
        Me.purposeTextbox = New System.Windows.Forms.TextBox()
        Me.primaryColor = New System.Windows.Forms.ColorDialog()
        Me.secondaryColor = New System.Windows.Forms.ColorDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.minimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sideMenuPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.openMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.addMenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addConfigPanel.SuspendLayout()
        Me.addMainPanel.SuspendLayout()
        CType(Me.secondayColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.controlButtonStrip.SuspendLayout()
        CType(Me.primaryColorBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addSecondPanel.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.menuButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 50)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.minimizeButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.maximizeButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.closeButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(654, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(144, 48)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'minimizeButton
        '
        Me.minimizeButton.Image = CType(resources.GetObject("minimizeButton.Image"), System.Drawing.Image)
        Me.minimizeButton.Location = New System.Drawing.Point(3, 3)
        Me.minimizeButton.Name = "minimizeButton"
        Me.minimizeButton.Size = New System.Drawing.Size(42, 42)
        Me.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimizeButton.TabIndex = 0
        Me.minimizeButton.TabStop = False
        '
        'maximizeButton
        '
        Me.maximizeButton.Image = CType(resources.GetObject("maximizeButton.Image"), System.Drawing.Image)
        Me.maximizeButton.Location = New System.Drawing.Point(51, 3)
        Me.maximizeButton.Name = "maximizeButton"
        Me.maximizeButton.Size = New System.Drawing.Size(42, 42)
        Me.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.maximizeButton.TabIndex = 1
        Me.maximizeButton.TabStop = False
        '
        'closeButton
        '
        Me.closeButton.Image = CType(resources.GetObject("closeButton.Image"), System.Drawing.Image)
        Me.closeButton.Location = New System.Drawing.Point(99, 3)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(42, 42)
        Me.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeButton.TabIndex = 2
        Me.closeButton.TabStop = False
        '
        'menuButton
        '
        Me.menuButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.menuButton.Image = CType(resources.GetObject("menuButton.Image"), System.Drawing.Image)
        Me.menuButton.Location = New System.Drawing.Point(0, 0)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(70, 48)
        Me.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.menuButton.TabIndex = 0
        Me.menuButton.TabStop = False
        '
        'sideMenuPanel
        '
        Me.sideMenuPanel.Controls.Add(Me.Panel4)
        Me.sideMenuPanel.Controls.Add(Me.Panel3)
        Me.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideMenuPanel.Location = New System.Drawing.Point(0, 50)
        Me.sideMenuPanel.Name = "sideMenuPanel"
        Me.sideMenuPanel.Size = New System.Drawing.Size(70, 400)
        Me.sideMenuPanel.TabIndex = 1
        Me.sideMenuPanel.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.openMenuButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(70, 100)
        Me.Panel4.TabIndex = 1
        '
        'openMenuButton
        '
        Me.openMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.openMenuButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.openMenuButton.Image = CType(resources.GetObject("openMenuButton.Image"), System.Drawing.Image)
        Me.openMenuButton.Location = New System.Drawing.Point(0, 0)
        Me.openMenuButton.Name = "openMenuButton"
        Me.openMenuButton.Size = New System.Drawing.Size(70, 100)
        Me.openMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.openMenuButton.TabIndex = 0
        Me.openMenuButton.TabStop = False
        Me.openToolTip.SetToolTip(Me.openMenuButton, "Open and Edit a previous Mouse Configuration")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.addMenuButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(70, 100)
        Me.Panel3.TabIndex = 0
        '
        'addMenuButton
        '
        Me.addMenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addMenuButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addMenuButton.Image = CType(resources.GetObject("addMenuButton.Image"), System.Drawing.Image)
        Me.addMenuButton.Location = New System.Drawing.Point(0, 0)
        Me.addMenuButton.Name = "addMenuButton"
        Me.addMenuButton.Size = New System.Drawing.Size(70, 100)
        Me.addMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addMenuButton.TabIndex = 0
        Me.addMenuButton.TabStop = False
        Me.addToolTip.SetToolTip(Me.addMenuButton, "Create a New Mouse Configuration")
        '
        'addConfigPanel
        '
        Me.addConfigPanel.ColumnCount = 1
        Me.addConfigPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.addConfigPanel.Controls.Add(Me.addMainPanel, 0, 0)
        Me.addConfigPanel.Controls.Add(Me.addSecondPanel, 0, 1)
        Me.addConfigPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addConfigPanel.Location = New System.Drawing.Point(70, 50)
        Me.addConfigPanel.Name = "addConfigPanel"
        Me.addConfigPanel.RowCount = 2
        Me.addConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.addConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.addConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.addConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.addConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.addConfigPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.addConfigPanel.Size = New System.Drawing.Size(730, 400)
        Me.addConfigPanel.TabIndex = 2
        '
        'addMainPanel
        '
        Me.addMainPanel.ColumnCount = 2
        Me.addMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.addMainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.addMainPanel.Controls.Add(Me.handLabel, 0, 6)
        Me.addMainPanel.Controls.Add(Me.addMainTitle, 0, 1)
        Me.addMainPanel.Controls.Add(Me.primaryColorLabel, 0, 2)
        Me.addMainPanel.Controls.Add(Me.secondColorLabel, 0, 3)
        Me.addMainPanel.Controls.Add(Me.sizeLabel, 0, 4)
        Me.addMainPanel.Controls.Add(Me.brandLabel, 0, 5)
        Me.addMainPanel.Controls.Add(Me.secondayColorBox, 1, 3)
        Me.addMainPanel.Controls.Add(Me.FlowLayoutPanel2, 1, 4)
        Me.addMainPanel.Controls.Add(Me.brandTextBox, 1, 5)
        Me.addMainPanel.Controls.Add(Me.FlowLayoutPanel3, 1, 6)
        Me.addMainPanel.Controls.Add(Me.controlButtonStrip, 0, 0)
        Me.addMainPanel.Controls.Add(Me.primaryColorBox, 1, 2)
        Me.addMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addMainPanel.Location = New System.Drawing.Point(3, 3)
        Me.addMainPanel.Name = "addMainPanel"
        Me.addMainPanel.RowCount = 7
        Me.addMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.502263!))
        Me.addMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.79638!))
        Me.addMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14027!))
        Me.addMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14027!))
        Me.addMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14027!))
        Me.addMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14027!))
        Me.addMainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14027!))
        Me.addMainPanel.Size = New System.Drawing.Size(724, 194)
        Me.addMainPanel.TabIndex = 0
        '
        'handLabel
        '
        Me.handLabel.AutoSize = True
        Me.handLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.handLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.handLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.handLabel.Location = New System.Drawing.Point(3, 164)
        Me.handLabel.Name = "handLabel"
        Me.handLabel.Size = New System.Drawing.Size(128, 30)
        Me.handLabel.TabIndex = 2
        Me.handLabel.Text = "Handedness"
        Me.handLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addMainTitle
        '
        Me.addMainTitle.AutoSize = True
        Me.addMainTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.addMainPanel.SetColumnSpan(Me.addMainTitle, 2)
        Me.addMainTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addMainTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMainTitle.Location = New System.Drawing.Point(3, 18)
        Me.addMainTitle.Name = "addMainTitle"
        Me.addMainTitle.Size = New System.Drawing.Size(718, 38)
        Me.addMainTitle.TabIndex = 0
        Me.addMainTitle.Text = "Main Mouse Configuration Settings"
        Me.addMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'primaryColorLabel
        '
        Me.primaryColorLabel.AutoSize = True
        Me.primaryColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.primaryColorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primaryColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.primaryColorLabel.Location = New System.Drawing.Point(3, 56)
        Me.primaryColorLabel.Name = "primaryColorLabel"
        Me.primaryColorLabel.Size = New System.Drawing.Size(128, 27)
        Me.primaryColorLabel.TabIndex = 1
        Me.primaryColorLabel.Text = "Primary Color"
        Me.primaryColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'secondColorLabel
        '
        Me.secondColorLabel.AutoSize = True
        Me.secondColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.secondColorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.secondColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondColorLabel.Location = New System.Drawing.Point(3, 83)
        Me.secondColorLabel.Name = "secondColorLabel"
        Me.secondColorLabel.Size = New System.Drawing.Size(128, 27)
        Me.secondColorLabel.TabIndex = 3
        Me.secondColorLabel.Text = "Secondary Color"
        Me.secondColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sizeLabel
        '
        Me.sizeLabel.AutoSize = True
        Me.sizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sizeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeLabel.Location = New System.Drawing.Point(3, 110)
        Me.sizeLabel.Name = "sizeLabel"
        Me.sizeLabel.Size = New System.Drawing.Size(128, 27)
        Me.sizeLabel.TabIndex = 4
        Me.sizeLabel.Text = "Size"
        Me.sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'brandLabel
        '
        Me.brandLabel.AutoSize = True
        Me.brandLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brandLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brandLabel.Location = New System.Drawing.Point(3, 137)
        Me.brandLabel.Name = "brandLabel"
        Me.brandLabel.Size = New System.Drawing.Size(128, 27)
        Me.brandLabel.TabIndex = 5
        Me.brandLabel.Text = "Brand"
        Me.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'secondayColorBox
        '
        Me.secondayColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.secondayColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.secondayColorBox.Location = New System.Drawing.Point(137, 86)
        Me.secondayColorBox.Name = "secondayColorBox"
        Me.secondayColorBox.Size = New System.Drawing.Size(584, 21)
        Me.secondayColorBox.TabIndex = 7
        Me.secondayColorBox.TabStop = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Controls.Add(Me.sizeSmallButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.sizeMediumButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.sizeLargeButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(137, 113)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(584, 21)
        Me.FlowLayoutPanel2.TabIndex = 8
        '
        'sizeSmallButton
        '
        Me.sizeSmallButton.AutoSize = True
        Me.sizeSmallButton.Location = New System.Drawing.Point(3, 3)
        Me.sizeSmallButton.Name = "sizeSmallButton"
        Me.sizeSmallButton.Size = New System.Drawing.Size(50, 17)
        Me.sizeSmallButton.TabIndex = 0
        Me.sizeSmallButton.Text = "Small"
        Me.sizeSmallButton.UseVisualStyleBackColor = True
        '
        'sizeMediumButton
        '
        Me.sizeMediumButton.AutoSize = True
        Me.sizeMediumButton.Location = New System.Drawing.Point(59, 3)
        Me.sizeMediumButton.Name = "sizeMediumButton"
        Me.sizeMediumButton.Size = New System.Drawing.Size(62, 17)
        Me.sizeMediumButton.TabIndex = 1
        Me.sizeMediumButton.Text = "Medium"
        Me.sizeMediumButton.UseVisualStyleBackColor = True
        '
        'sizeLargeButton
        '
        Me.sizeLargeButton.AutoSize = True
        Me.sizeLargeButton.Location = New System.Drawing.Point(127, 3)
        Me.sizeLargeButton.Name = "sizeLargeButton"
        Me.sizeLargeButton.Size = New System.Drawing.Size(52, 17)
        Me.sizeLargeButton.TabIndex = 2
        Me.sizeLargeButton.Text = "Large"
        Me.sizeLargeButton.UseVisualStyleBackColor = True
        '
        'brandTextBox
        '
        Me.brandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.brandTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brandTextBox.Location = New System.Drawing.Point(137, 140)
        Me.brandTextBox.Name = "brandTextBox"
        Me.brandTextBox.Size = New System.Drawing.Size(584, 20)
        Me.brandTextBox.TabIndex = 9
        Me.brandTextBox.TabStop = False
        Me.brandTextBox.WordWrap = False
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel3.Controls.Add(Me.handLeftButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.handRightButton)
        Me.FlowLayoutPanel3.Controls.Add(Me.handBothButton)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(137, 167)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(584, 24)
        Me.FlowLayoutPanel3.TabIndex = 10
        '
        'handLeftButton
        '
        Me.handLeftButton.AutoSize = True
        Me.handLeftButton.Location = New System.Drawing.Point(3, 3)
        Me.handLeftButton.Name = "handLeftButton"
        Me.handLeftButton.Size = New System.Drawing.Size(116, 17)
        Me.handLeftButton.TabIndex = 0
        Me.handLeftButton.TabStop = True
        Me.handLeftButton.Text = "Left Hand Focused"
        Me.handLeftButton.UseVisualStyleBackColor = True
        '
        'handRightButton
        '
        Me.handRightButton.AutoSize = True
        Me.handRightButton.Location = New System.Drawing.Point(125, 3)
        Me.handRightButton.Name = "handRightButton"
        Me.handRightButton.Size = New System.Drawing.Size(123, 17)
        Me.handRightButton.TabIndex = 1
        Me.handRightButton.TabStop = True
        Me.handRightButton.Text = "Right Hand Focused"
        Me.handRightButton.UseVisualStyleBackColor = True
        '
        'handBothButton
        '
        Me.handBothButton.AutoSize = True
        Me.handBothButton.Location = New System.Drawing.Point(254, 3)
        Me.handBothButton.Name = "handBothButton"
        Me.handBothButton.Size = New System.Drawing.Size(88, 17)
        Me.handBothButton.TabIndex = 2
        Me.handBothButton.TabStop = True
        Me.handBothButton.Text = "Ambidextrous"
        Me.handBothButton.UseVisualStyleBackColor = True
        '
        'controlButtonStrip
        '
        Me.addMainPanel.SetColumnSpan(Me.controlButtonStrip, 2)
        Me.controlButtonStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.saveButton, Me.saveAndCloseButton, Me.clearAllButton, Me.ToolStripSeparator1, Me.fileNameLabel, Me.fileNameTextbox})
        Me.controlButtonStrip.Location = New System.Drawing.Point(0, 0)
        Me.controlButtonStrip.Name = "controlButtonStrip"
        Me.controlButtonStrip.Size = New System.Drawing.Size(724, 18)
        Me.controlButtonStrip.TabIndex = 11
        Me.controlButtonStrip.Text = "ToolStrip1"
        '
        'saveButton
        '
        Me.saveButton.Image = CType(resources.GetObject("saveButton.Image"), System.Drawing.Image)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(47, 15)
        Me.saveButton.Text = "Save"
        '
        'saveAndCloseButton
        '
        Me.saveAndCloseButton.Image = CType(resources.GetObject("saveAndCloseButton.Image"), System.Drawing.Image)
        Me.saveAndCloseButton.Name = "saveAndCloseButton"
        Me.saveAndCloseButton.Size = New System.Drawing.Size(102, 15)
        Me.saveAndCloseButton.Text = "Save and Close"
        '
        'clearAllButton
        '
        Me.clearAllButton.Image = CType(resources.GetObject("clearAllButton.Image"), System.Drawing.Image)
        Me.clearAllButton.Name = "clearAllButton"
        Me.clearAllButton.Size = New System.Drawing.Size(67, 15)
        Me.clearAllButton.Text = "Clear All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 18)
        '
        'fileNameLabel
        '
        Me.fileNameLabel.Name = "fileNameLabel"
        Me.fileNameLabel.Size = New System.Drawing.Size(60, 15)
        Me.fileNameLabel.Text = "File Name"
        '
        'fileNameTextbox
        '
        Me.fileNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fileNameTextbox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.fileNameTextbox.Name = "fileNameTextbox"
        Me.fileNameTextbox.Size = New System.Drawing.Size(100, 18)
        '
        'primaryColorBox
        '
        Me.primaryColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.primaryColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primaryColorBox.Location = New System.Drawing.Point(137, 59)
        Me.primaryColorBox.Name = "primaryColorBox"
        Me.primaryColorBox.Size = New System.Drawing.Size(584, 21)
        Me.primaryColorBox.TabIndex = 12
        Me.primaryColorBox.TabStop = False
        '
        'addSecondPanel
        '
        Me.addSecondPanel.ColumnCount = 2
        Me.addSecondPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.addSecondPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.addSecondPanel.Controls.Add(Me.Label1, 0, 0)
        Me.addSecondPanel.Controls.Add(Me.sideScrolLabel, 0, 1)
        Me.addSecondPanel.Controls.Add(Me.forwardBackLabel, 0, 2)
        Me.addSecondPanel.Controls.Add(Me.ergoLabel, 0, 3)
        Me.addSecondPanel.Controls.Add(Me.clickLabel, 0, 4)
        Me.addSecondPanel.Controls.Add(Me.purposeLabel, 0, 5)
        Me.addSecondPanel.Controls.Add(Me.FlowLayoutPanel4, 1, 1)
        Me.addSecondPanel.Controls.Add(Me.FlowLayoutPanel5, 1, 2)
        Me.addSecondPanel.Controls.Add(Me.FlowLayoutPanel6, 1, 3)
        Me.addSecondPanel.Controls.Add(Me.FlowLayoutPanel7, 1, 4)
        Me.addSecondPanel.Controls.Add(Me.purposeTextbox, 1, 5)
        Me.addSecondPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addSecondPanel.Location = New System.Drawing.Point(3, 203)
        Me.addSecondPanel.Name = "addSecondPanel"
        Me.addSecondPanel.RowCount = 6
        Me.addSecondPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.addSecondPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.addSecondPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.addSecondPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.addSecondPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.addSecondPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.addSecondPanel.Size = New System.Drawing.Size(724, 194)
        Me.addSecondPanel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.addSecondPanel.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(718, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Other Mouse Configuration Settigns"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sideScrolLabel
        '
        Me.sideScrolLabel.AutoSize = True
        Me.sideScrolLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sideScrolLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sideScrolLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sideScrolLabel.Location = New System.Drawing.Point(3, 55)
        Me.sideScrolLabel.Name = "sideScrolLabel"
        Me.sideScrolLabel.Size = New System.Drawing.Size(248, 27)
        Me.sideScrolLabel.TabIndex = 1
        Me.sideScrolLabel.Text = "Side Horizontal Scroll Wheel"
        Me.sideScrolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'forwardBackLabel
        '
        Me.forwardBackLabel.AutoSize = True
        Me.forwardBackLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.forwardBackLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.forwardBackLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forwardBackLabel.Location = New System.Drawing.Point(3, 82)
        Me.forwardBackLabel.Name = "forwardBackLabel"
        Me.forwardBackLabel.Size = New System.Drawing.Size(248, 27)
        Me.forwardBackLabel.TabIndex = 2
        Me.forwardBackLabel.Text = "Forward-Back Navigation Buttons"
        Me.forwardBackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ergoLabel
        '
        Me.ergoLabel.AutoSize = True
        Me.ergoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ergoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ergoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ergoLabel.Location = New System.Drawing.Point(3, 109)
        Me.ergoLabel.Name = "ergoLabel"
        Me.ergoLabel.Size = New System.Drawing.Size(248, 27)
        Me.ergoLabel.TabIndex = 3
        Me.ergoLabel.Text = "Ergonomic Design"
        Me.ergoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clickLabel
        '
        Me.clickLabel.AutoSize = True
        Me.clickLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clickLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clickLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clickLabel.Location = New System.Drawing.Point(3, 136)
        Me.clickLabel.Name = "clickLabel"
        Me.clickLabel.Size = New System.Drawing.Size(248, 27)
        Me.clickLabel.TabIndex = 4
        Me.clickLabel.Text = "Silent Clicks"
        Me.clickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'purposeLabel
        '
        Me.purposeLabel.AutoSize = True
        Me.purposeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.purposeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.purposeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purposeLabel.Location = New System.Drawing.Point(3, 163)
        Me.purposeLabel.Name = "purposeLabel"
        Me.purposeLabel.Size = New System.Drawing.Size(248, 31)
        Me.purposeLabel.TabIndex = 5
        Me.purposeLabel.Text = "Built Purpose"
        Me.purposeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.sideScrollYesButton)
        Me.FlowLayoutPanel4.Controls.Add(Me.sideScrollNoButton)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(257, 58)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(464, 21)
        Me.FlowLayoutPanel4.TabIndex = 6
        '
        'sideScrollYesButton
        '
        Me.sideScrollYesButton.AutoSize = True
        Me.sideScrollYesButton.Location = New System.Drawing.Point(3, 3)
        Me.sideScrollYesButton.Name = "sideScrollYesButton"
        Me.sideScrollYesButton.Size = New System.Drawing.Size(43, 17)
        Me.sideScrollYesButton.TabIndex = 0
        Me.sideScrollYesButton.TabStop = True
        Me.sideScrollYesButton.Text = "Yes"
        Me.sideScrollYesButton.UseVisualStyleBackColor = True
        '
        'sideScrollNoButton
        '
        Me.sideScrollNoButton.AutoSize = True
        Me.sideScrollNoButton.Location = New System.Drawing.Point(52, 3)
        Me.sideScrollNoButton.Name = "sideScrollNoButton"
        Me.sideScrollNoButton.Size = New System.Drawing.Size(39, 17)
        Me.sideScrollNoButton.TabIndex = 1
        Me.sideScrollNoButton.TabStop = True
        Me.sideScrollNoButton.Text = "No"
        Me.sideScrollNoButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.navYesButton)
        Me.FlowLayoutPanel5.Controls.Add(Me.navNoButton)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(257, 85)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(464, 21)
        Me.FlowLayoutPanel5.TabIndex = 7
        '
        'navYesButton
        '
        Me.navYesButton.AutoSize = True
        Me.navYesButton.Location = New System.Drawing.Point(3, 3)
        Me.navYesButton.Name = "navYesButton"
        Me.navYesButton.Size = New System.Drawing.Size(43, 17)
        Me.navYesButton.TabIndex = 0
        Me.navYesButton.TabStop = True
        Me.navYesButton.Text = "Yes"
        Me.navYesButton.UseVisualStyleBackColor = True
        '
        'navNoButton
        '
        Me.navNoButton.AutoSize = True
        Me.navNoButton.Location = New System.Drawing.Point(52, 3)
        Me.navNoButton.Name = "navNoButton"
        Me.navNoButton.Size = New System.Drawing.Size(39, 17)
        Me.navNoButton.TabIndex = 1
        Me.navNoButton.TabStop = True
        Me.navNoButton.Text = "No"
        Me.navNoButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.ergoYesButton)
        Me.FlowLayoutPanel6.Controls.Add(Me.ergoNoButton)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(257, 112)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(464, 21)
        Me.FlowLayoutPanel6.TabIndex = 8
        '
        'ergoYesButton
        '
        Me.ergoYesButton.AutoSize = True
        Me.ergoYesButton.Location = New System.Drawing.Point(3, 3)
        Me.ergoYesButton.Name = "ergoYesButton"
        Me.ergoYesButton.Size = New System.Drawing.Size(43, 17)
        Me.ergoYesButton.TabIndex = 0
        Me.ergoYesButton.TabStop = True
        Me.ergoYesButton.Text = "Yes"
        Me.ergoYesButton.UseVisualStyleBackColor = True
        '
        'ergoNoButton
        '
        Me.ergoNoButton.AutoSize = True
        Me.ergoNoButton.Location = New System.Drawing.Point(52, 3)
        Me.ergoNoButton.Name = "ergoNoButton"
        Me.ergoNoButton.Size = New System.Drawing.Size(39, 17)
        Me.ergoNoButton.TabIndex = 1
        Me.ergoNoButton.TabStop = True
        Me.ergoNoButton.Text = "No"
        Me.ergoNoButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.silentYesButton)
        Me.FlowLayoutPanel7.Controls.Add(Me.silentNoButton)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(257, 139)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(464, 21)
        Me.FlowLayoutPanel7.TabIndex = 9
        '
        'silentYesButton
        '
        Me.silentYesButton.AutoSize = True
        Me.silentYesButton.Location = New System.Drawing.Point(3, 3)
        Me.silentYesButton.Name = "silentYesButton"
        Me.silentYesButton.Size = New System.Drawing.Size(43, 17)
        Me.silentYesButton.TabIndex = 0
        Me.silentYesButton.TabStop = True
        Me.silentYesButton.Text = "Yes"
        Me.silentYesButton.UseVisualStyleBackColor = True
        '
        'silentNoButton
        '
        Me.silentNoButton.AutoSize = True
        Me.silentNoButton.Location = New System.Drawing.Point(52, 3)
        Me.silentNoButton.Name = "silentNoButton"
        Me.silentNoButton.Size = New System.Drawing.Size(39, 17)
        Me.silentNoButton.TabIndex = 1
        Me.silentNoButton.TabStop = True
        Me.silentNoButton.Text = "No"
        Me.silentNoButton.UseVisualStyleBackColor = True
        '
        'purposeTextbox
        '
        Me.purposeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.purposeTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.purposeTextbox.Location = New System.Drawing.Point(257, 166)
        Me.purposeTextbox.Name = "purposeTextbox"
        Me.purposeTextbox.Size = New System.Drawing.Size(464, 20)
        Me.purposeTextbox.TabIndex = 10
        Me.purposeTextbox.TabStop = False
        '
        'primaryColor
        '
        Me.primaryColor.AnyColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.addConfigPanel)
        Me.Controls.Add(Me.sideMenuPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "mainWindow"
        Me.Text = "Mouse Configuration"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.minimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sideMenuPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.openMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.addMenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addConfigPanel.ResumeLayout(False)
        Me.addMainPanel.ResumeLayout(False)
        Me.addMainPanel.PerformLayout()
        CType(Me.secondayColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.controlButtonStrip.ResumeLayout(False)
        Me.controlButtonStrip.PerformLayout()
        CType(Me.primaryColorBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addSecondPanel.ResumeLayout(False)
        Me.addSecondPanel.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents sideMenuPanel As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents minimizeButton As PictureBox
    Friend WithEvents menuButton As PictureBox
    Friend WithEvents maximizeButton As PictureBox
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents openMenuButton As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents addMenuButton As PictureBox
    Friend WithEvents openToolTip As ToolTip
    Friend WithEvents addToolTip As ToolTip
    Friend WithEvents addConfigPanel As TableLayoutPanel
    Friend WithEvents addMainPanel As TableLayoutPanel
    Friend WithEvents addSecondPanel As TableLayoutPanel
    Friend WithEvents addMainTitle As Label
    Friend WithEvents primaryColorLabel As Label
    Friend WithEvents handLabel As Label
    Friend WithEvents secondColorLabel As Label
    Friend WithEvents sizeLabel As Label
    Friend WithEvents brandLabel As Label
    Friend WithEvents primaryColor As ColorDialog
    Friend WithEvents secondayColorBox As PictureBox
    Friend WithEvents secondaryColor As ColorDialog
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents sizeSmallButton As RadioButton
    Friend WithEvents sizeMediumButton As RadioButton
    Friend WithEvents sizeLargeButton As RadioButton
    Friend WithEvents brandTextBox As TextBox
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents handLeftButton As RadioButton
    Friend WithEvents handRightButton As RadioButton
    Friend WithEvents handBothButton As RadioButton
    Friend WithEvents controlButtonStrip As ToolStrip
    Friend WithEvents saveButton As ToolStripLabel
    Friend WithEvents saveAndCloseButton As ToolStripLabel
    Friend WithEvents clearAllButton As ToolStripLabel
    Friend WithEvents primaryColorBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sideScrolLabel As Label
    Friend WithEvents forwardBackLabel As Label
    Friend WithEvents ergoLabel As Label
    Friend WithEvents clickLabel As Label
    Friend WithEvents purposeLabel As Label
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents sideScrollYesButton As RadioButton
    Friend WithEvents sideScrollNoButton As RadioButton
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents navYesButton As RadioButton
    Friend WithEvents navNoButton As RadioButton
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents ergoYesButton As RadioButton
    Friend WithEvents ergoNoButton As RadioButton
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents silentYesButton As RadioButton
    Friend WithEvents silentNoButton As RadioButton
    Friend WithEvents purposeTextbox As TextBox
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents fileNameLabel As ToolStripLabel
    Friend WithEvents fileNameTextbox As ToolStripTextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
