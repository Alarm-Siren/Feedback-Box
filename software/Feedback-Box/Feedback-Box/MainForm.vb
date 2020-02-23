Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports USBClassLibrary

Public Class MainForm
    Private UsbListener As USBClass
    Private UsbDevices As List(Of USBClass.DeviceProperties)
    Private Const FTDI_VID As UInt32 = &H403
    Private Const FTDI_PID As UInt32 = &H6001
    Private Const FTDI_DevEnum As String = "FTDIBUS"

    Private Sub MainForm_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        UsbListener.RegisterForDeviceChange(False, Me.Handle)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup the USB Device Change listeners
        UsbListener = New USBClass()
        UsbDevices = New List(Of USBClass.DeviceProperties)
        AddHandler UsbListener.USBDeviceAttached, AddressOf USBPort_USBDeviceAttached
        AddHandler UsbListener.USBDeviceRemoved, AddressOf USBPort_USBDeviceRemoved
        UsbListener.RegisterForDeviceChange(True, Me.Handle)

    End Sub

    Private Sub USBPort_USBDeviceQueryRemove(sender As Object, e As USBClass.USBDeviceEventArgs)

        If (USBClass.GetUSBDevice(FTDI_DevEnum, FTDI_VID, FTDI_PID, UsbDevices, False)) Then
            'MyUSBDeviceConnected = True
            MsgBox("Device Removal Queried!")
        End If

    End Sub

    Private Sub USBPort_USBDeviceAttached(sender As Object, e As USBClass.USBDeviceEventArgs)
        If (USBClass.GetUSBDevice(FTDI_DevEnum, FTDI_VID, FTDI_PID, UsbDevices, False)) Then
            MsgBox("Device Attached!")
        End If

    End Sub

    Private Sub USBPort_USBDeviceRemoved(sender As Object, e As USBClass.USBDeviceEventArgs)
        If (Not USBClass.GetUSBDevice(FTDI_DevEnum, FTDI_VID, FTDI_PID, UsbDevices, False)) Then
            MsgBox("Device Disconnected!")
            UsbDevices = UsbDevices
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim IsHandled As Boolean = False
        If (UsbListener IsNot Nothing) Then
            UsbListener.ProcessWindowsMessage(m.Msg, m.WParam, m.LParam, IsHandled)
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        NumberOfFoundDevicesLabel.Text = "0"
        If (USBClass.GetUSBDevice(FTDI_DevEnum, FTDI_VID, FTDI_PID, UsbDevices, True)) Then
            'My Device is attached
            NumberOfFoundDevicesLabel.Text = "Number of found devices: " + UsbDevices.Count.ToString()
            FoundDevicesComboBox.Items.Clear()
            For i As Integer = 0 To UsbDevices.Count - 1
                FoundDevicesComboBox.Items.Add("Device " + i.ToString())
            Next
            FoundDevicesComboBox.Enabled = (UsbDevices.Count > 1)
            FoundDevicesComboBox.SelectedIndex = 0

            'Connect();
        End If

    End Sub

    Private Sub FoundDevicesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FoundDevicesComboBox.SelectedIndexChanged
        Dim SelectedDevice As Integer = (CType(sender, System.Windows.Forms.ComboBox)).SelectedIndex

        FriendlyNameTextBox.Text = UsbDevices(SelectedDevice).FriendlyName
        DeviceDescriptionTextBox.Text = UsbDevices(SelectedDevice).DeviceDescription
        DeviceManufacturerTextBox.Text = UsbDevices(SelectedDevice).DeviceManufacturer
        SerialPortTextBox.Text = UsbDevices(SelectedDevice).SerialComPort
        DeviceInstanceIDTextBox.Text = UsbDevices(SelectedDevice).DeviceInstanceID


    End Sub

    Private Sub mnuDeviceScanforDevices_Click(sender As Object, e As EventArgs) Handles mnuDeviceScanforDevices.Click

    End Sub
End Class