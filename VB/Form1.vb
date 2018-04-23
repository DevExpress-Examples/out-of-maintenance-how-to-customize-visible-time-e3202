Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace SchedulerNonStandardTimeInterval
	Partial Public Class Form1
		Inherits Form
		Public ReadOnly Property StartTimeOffset() As TimeSpan
			Get
				Return TimeSpan.FromHours(rangeTrackBarControl1.Properties.Maximum - rangeTrackBarControl1.Value.Maximum)
			End Get
		End Property
		Public ReadOnly Property EndTimeOffset() As TimeSpan
			Get
				Return TimeSpan.FromHours(rangeTrackBarControl1.Properties.Maximum - rangeTrackBarControl1.Value.Minimum)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			UpdateVisibleTime()
		End Sub

		Private Sub rangeTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rangeTrackBarControl1.EditValueChanged
			UpdateVisibleTime()
		End Sub

		Private Sub UpdateVisibleTime()
			schedulerControl1.DayView.VisibleTime = New DevExpress.XtraScheduler.TimeOfDayInterval(StartTimeOffset, EndTimeOffset)
			schedulerControl1.WorkWeekView.VisibleTime = New DevExpress.XtraScheduler.TimeOfDayInterval(StartTimeOffset, EndTimeOffset)
		End Sub

		Private Sub rangeTrackBarControl1_BeforeShowValueToolTip(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TrackBarValueToolTipEventArgs) Handles rangeTrackBarControl1.BeforeShowValueToolTip
			e.ShowArgs.ToolTip = String.Format("Interval = [{0}; {1}]", StartTimeOffset, EndTimeOffset)
		End Sub
	End Class
End Namespace