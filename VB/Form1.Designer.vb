Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerNonStandardTimeInterval
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.rangeTrackBarControl1 = New DevExpress.XtraEditors.RangeTrackBarControl()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rangeTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.schedulerControl1.Location = New System.Drawing.Point(84, 15)
			Me.schedulerControl1.Margin = New System.Windows.Forms.Padding(4)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(751, 418)
			Me.schedulerControl1.Start = New System.DateTime(2008, 9, 4, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.MonthView.Enabled = False
			Me.schedulerControl1.Views.TimelineView.Enabled = False
			Me.schedulerControl1.Views.WeekView.Enabled = False
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' rangeTrackBarControl1
			' 
			Me.rangeTrackBarControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.rangeTrackBarControl1.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(18, 42)
			Me.rangeTrackBarControl1.Location = New System.Drawing.Point(16, 15)
			Me.rangeTrackBarControl1.Margin = New System.Windows.Forms.Padding(4)
			Me.rangeTrackBarControl1.Name = "rangeTrackBarControl1"
			Me.rangeTrackBarControl1.Properties.Maximum = 48
			Me.rangeTrackBarControl1.Properties.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.rangeTrackBarControl1.Properties.ShowValueToolTip = True
			Me.rangeTrackBarControl1.Size = New System.Drawing.Size(56, 418)
			Me.rangeTrackBarControl1.TabIndex = 0
			Me.rangeTrackBarControl1.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(18, 42)
'			Me.rangeTrackBarControl1.EditValueChanged += New System.EventHandler(Me.rangeTrackBarControl1_EditValueChanged);
'			Me.rangeTrackBarControl1.BeforeShowValueToolTip += New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(Me.rangeTrackBarControl1_BeforeShowValueToolTip);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(851, 447)
			Me.Controls.Add(Me.rangeTrackBarControl1)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rangeTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private WithEvents rangeTrackBarControl1 As DevExpress.XtraEditors.RangeTrackBarControl
	End Class
End Namespace

