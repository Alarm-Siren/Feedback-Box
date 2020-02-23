<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.FoundDevicesLabel = New System.Windows.Forms.Label()
        Me.NumberOfFoundDevicesLabel = New System.Windows.Forms.Label()
        Me.FoundDevicesComboBox = New System.Windows.Forms.ComboBox()
        Me.SerialPortTextBox = New System.Windows.Forms.TextBox()
        Me.SerialPortLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeviceManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.DeviceDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DeviceManufacturerLabel = New System.Windows.Forms.Label()
        Me.DeviceDescriptionLabel = New System.Windows.Forms.Label()
        Me.FriendlyNameTextBox = New System.Windows.Forms.TextBox()
        Me.FriendlyNameLabel = New System.Windows.Forms.Label()
        Me.DeviceInstanceIDTextBox = New System.Windows.Forms.TextBox()
        Me.DeviceInstanceIDLabel = New System.Windows.Forms.Label()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuDevice = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeviceScanforDevices = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeviceSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NoDevicesDetectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'FoundDevicesLabel
        '
        Me.FoundDevicesLabel.AutoSize = True
        Me.FoundDevicesLabel.Location = New System.Drawing.Point(10, 36)
        Me.FoundDevicesLabel.Name = "FoundDevicesLabel"
        Me.FoundDevicesLabel.Size = New System.Drawing.Size(79, 13)
        Me.FoundDevicesLabel.TabIndex = 7
        Me.FoundDevicesLabel.Text = "Found Devices"
        '
        'NumberOfFoundDevicesLabel
        '
        Me.NumberOfFoundDevicesLabel.AutoSize = True
        Me.NumberOfFoundDevicesLabel.Location = New System.Drawing.Point(259, 36)
        Me.NumberOfFoundDevicesLabel.Name = "NumberOfFoundDevicesLabel"
        Me.NumberOfFoundDevicesLabel.Size = New System.Drawing.Size(138, 13)
        Me.NumberOfFoundDevicesLabel.TabIndex = 24
        Me.NumberOfFoundDevicesLabel.Text = "Number of found devices: 0"
        '
        'FoundDevicesComboBox
        '
        Me.FoundDevicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FoundDevicesComboBox.Enabled = False
        Me.FoundDevicesComboBox.Location = New System.Drawing.Point(132, 33)
        Me.FoundDevicesComboBox.Name = "FoundDevicesComboBox"
        Me.FoundDevicesComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FoundDevicesComboBox.TabIndex = 37
        '
        'SerialPortTextBox
        '
        Me.SerialPortTextBox.Location = New System.Drawing.Point(104, 212)
        Me.SerialPortTextBox.Name = "SerialPortTextBox"
        Me.SerialPortTextBox.ReadOnly = True
        Me.SerialPortTextBox.Size = New System.Drawing.Size(515, 20)
        Me.SerialPortTextBox.TabIndex = 30
        Me.SerialPortTextBox.TabStop = False
        '
        'SerialPortLabel
        '
        Me.SerialPortLabel.AutoSize = True
        Me.SerialPortLabel.Location = New System.Drawing.Point(10, 215)
        Me.SerialPortLabel.Name = "SerialPortLabel"
        Me.SerialPortLabel.Size = New System.Drawing.Size(55, 13)
        Me.SerialPortLabel.TabIndex = 22
        Me.SerialPortLabel.Text = "Serial Port"
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(452, 31)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(65, 23)
        Me.UpdateButton.TabIndex = 35
        Me.UpdateButton.Text = "Update!"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeviceManufacturerTextBox
        '
        Me.DeviceManufacturerTextBox.Location = New System.Drawing.Point(120, 160)
        Me.DeviceManufacturerTextBox.Name = "DeviceManufacturerTextBox"
        Me.DeviceManufacturerTextBox.ReadOnly = True
        Me.DeviceManufacturerTextBox.Size = New System.Drawing.Size(499, 20)
        Me.DeviceManufacturerTextBox.TabIndex = 15
        Me.DeviceManufacturerTextBox.TabStop = False
        '
        'DeviceDescriptionTextBox
        '
        Me.DeviceDescriptionTextBox.Location = New System.Drawing.Point(104, 128)
        Me.DeviceDescriptionTextBox.Name = "DeviceDescriptionTextBox"
        Me.DeviceDescriptionTextBox.ReadOnly = True
        Me.DeviceDescriptionTextBox.Size = New System.Drawing.Size(515, 20)
        Me.DeviceDescriptionTextBox.TabIndex = 14
        Me.DeviceDescriptionTextBox.TabStop = False
        '
        'DeviceManufacturerLabel
        '
        Me.DeviceManufacturerLabel.AutoSize = True
        Me.DeviceManufacturerLabel.Location = New System.Drawing.Point(10, 164)
        Me.DeviceManufacturerLabel.Name = "DeviceManufacturerLabel"
        Me.DeviceManufacturerLabel.Size = New System.Drawing.Size(104, 13)
        Me.DeviceManufacturerLabel.TabIndex = 13
        Me.DeviceManufacturerLabel.Text = "DeviceManufacturer"
        '
        'DeviceDescriptionLabel
        '
        Me.DeviceDescriptionLabel.AutoSize = True
        Me.DeviceDescriptionLabel.Location = New System.Drawing.Point(10, 132)
        Me.DeviceDescriptionLabel.Name = "DeviceDescriptionLabel"
        Me.DeviceDescriptionLabel.Size = New System.Drawing.Size(94, 13)
        Me.DeviceDescriptionLabel.TabIndex = 12
        Me.DeviceDescriptionLabel.Text = "DeviceDescription"
        '
        'FriendlyNameTextBox
        '
        Me.FriendlyNameTextBox.Location = New System.Drawing.Point(104, 96)
        Me.FriendlyNameTextBox.Name = "FriendlyNameTextBox"
        Me.FriendlyNameTextBox.ReadOnly = True
        Me.FriendlyNameTextBox.Size = New System.Drawing.Size(515, 20)
        Me.FriendlyNameTextBox.TabIndex = 11
        Me.FriendlyNameTextBox.TabStop = False
        '
        'FriendlyNameLabel
        '
        Me.FriendlyNameLabel.AutoSize = True
        Me.FriendlyNameLabel.Location = New System.Drawing.Point(10, 100)
        Me.FriendlyNameLabel.Name = "FriendlyNameLabel"
        Me.FriendlyNameLabel.Size = New System.Drawing.Size(71, 13)
        Me.FriendlyNameLabel.TabIndex = 9
        Me.FriendlyNameLabel.Text = "FriendlyName"
        '
        'DeviceInstanceIDTextBox
        '
        Me.DeviceInstanceIDTextBox.Location = New System.Drawing.Point(120, 186)
        Me.DeviceInstanceIDTextBox.Name = "DeviceInstanceIDTextBox"
        Me.DeviceInstanceIDTextBox.ReadOnly = True
        Me.DeviceInstanceIDTextBox.Size = New System.Drawing.Size(499, 20)
        Me.DeviceInstanceIDTextBox.TabIndex = 39
        Me.DeviceInstanceIDTextBox.TabStop = False
        '
        'DeviceInstanceIDLabel
        '
        Me.DeviceInstanceIDLabel.AutoSize = True
        Me.DeviceInstanceIDLabel.Location = New System.Drawing.Point(10, 190)
        Me.DeviceInstanceIDLabel.Name = "DeviceInstanceIDLabel"
        Me.DeviceInstanceIDLabel.Size = New System.Drawing.Size(93, 13)
        Me.DeviceInstanceIDLabel.TabIndex = 38
        Me.DeviceInstanceIDLabel.Text = "DeviceInstanceID"
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDevice, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(634, 24)
        Me.mnuMain.TabIndex = 40
        Me.mnuMain.Text = "Main Menu"
        '
        'mnuDevice
        '
        Me.mnuDevice.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDeviceScanforDevices, Me.mnuDeviceSep1, Me.NoDevicesDetectedToolStripMenuItem})
        Me.mnuDevice.Name = "mnuDevice"
        Me.mnuDevice.Size = New System.Drawing.Size(54, 20)
        Me.mnuDevice.Text = "&Device"
        '
        'mnuDeviceScanforDevices
        '
        Me.mnuDeviceScanforDevices.Name = "mnuDeviceScanforDevices"
        Me.mnuDeviceScanforDevices.Size = New System.Drawing.Size(183, 22)
        Me.mnuDeviceScanforDevices.Text = "&Scan for Devices"
        '
        'mnuDeviceSep1
        '
        Me.mnuDeviceSep1.Name = "mnuDeviceSep1"
        Me.mnuDeviceSep1.Size = New System.Drawing.Size(180, 6)
        '
        'NoDevicesDetectedToolStripMenuItem
        '
        Me.NoDevicesDetectedToolStripMenuItem.Enabled = False
        Me.NoDevicesDetectedToolStripMenuItem.Name = "NoDevicesDetectedToolStripMenuItem"
        Me.NoDevicesDetectedToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.NoDevicesDetectedToolStripMenuItem.Text = "No Devices Detected"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(116, 22)
        Me.mnuHelpAbout.Text = "&About..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 373)
        Me.Controls.Add(Me.DeviceInstanceIDTextBox)
        Me.Controls.Add(Me.DeviceInstanceIDLabel)
        Me.Controls.Add(Me.FoundDevicesLabel)
        Me.Controls.Add(Me.NumberOfFoundDevicesLabel)
        Me.Controls.Add(Me.FoundDevicesComboBox)
        Me.Controls.Add(Me.SerialPortTextBox)
        Me.Controls.Add(Me.SerialPortLabel)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeviceManufacturerTextBox)
        Me.Controls.Add(Me.DeviceDescriptionTextBox)
        Me.Controls.Add(Me.DeviceManufacturerLabel)
        Me.Controls.Add(Me.DeviceDescriptionLabel)
        Me.Controls.Add(Me.FriendlyNameTextBox)
        Me.Controls.Add(Me.FriendlyNameLabel)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "MainForm"
        Me.Text = "Feedback Box Interface"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents FoundDevicesLabel As System.Windows.Forms.Label
    Private WithEvents NumberOfFoundDevicesLabel As System.Windows.Forms.Label
    Private WithEvents FoundDevicesComboBox As System.Windows.Forms.ComboBox
    Private WithEvents SerialPortTextBox As System.Windows.Forms.TextBox
    Private WithEvents SerialPortLabel As System.Windows.Forms.Label
    Private WithEvents UpdateButton As System.Windows.Forms.Button
    Private WithEvents DeviceManufacturerTextBox As System.Windows.Forms.TextBox
    Private WithEvents DeviceDescriptionTextBox As System.Windows.Forms.TextBox
    Private WithEvents DeviceManufacturerLabel As System.Windows.Forms.Label
    Private WithEvents DeviceDescriptionLabel As System.Windows.Forms.Label
    Private WithEvents FriendlyNameTextBox As System.Windows.Forms.TextBox
    Private WithEvents FriendlyNameLabel As System.Windows.Forms.Label
    Private WithEvents DeviceInstanceIDTextBox As System.Windows.Forms.TextBox
    Private WithEvents DeviceInstanceIDLabel As System.Windows.Forms.Label
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDevice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeviceScanforDevices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeviceSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NoDevicesDetectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem

End Class
