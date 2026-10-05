using System;
using System.ComponentModel;
using System.Threading;
using Il2CppDummyDll;

namespace System.Timers
{
	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[DefaultProperty("Interval")]
	[DefaultEvent("Elapsed")]
	public class Timer : Component, ISupportInitialize
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x5103940", Offset = "0x5102540", VA = "0x185103940")]
		public Timer()
		{
		}

		// Token: 0x170000C3 RID: 195
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C3")]
		[DefaultValue(true)]
		[Category("Behavior")]
		[TimersDescription("Indicates whether the timer will be restarted when it is enabled.")]
		public bool AutoReset
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x5103D70", Offset = "0x5102970", VA = "0x185103D70")]
			set
			{
			}
		}

		// Token: 0x170000C4 RID: 196
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C4")]
		[TimersDescription("Indicates whether the timer is enabled to fire events at a defined interval.")]
		[Category("Behavior")]
		[DefaultValue(false)]
		public bool Enabled
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x5103DF0", Offset = "0x51029F0", VA = "0x185103DF0")]
			set
			{
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x51032C0", Offset = "0x5101EC0", VA = "0x1851032C0")]
		private static int CalculateRoundedInterval(double interval, bool argumentCheck = false)
		{
			return 0;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x51038F0", Offset = "0x51024F0", VA = "0x1851038F0")]
		private void UpdateTimer()
		{
		}

		// Token: 0x170000C5 RID: 197
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C5")]
		[Category("Behavior")]
		[TimersDescription("The number of milliseconds between timer events.")]
		[DefaultValue(100.0)]
		[SettingsBindable(true)]
		public double Interval
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x5104010", Offset = "0x5102C10", VA = "0x185104010")]
			set
			{
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600046F RID: 1135 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000470 RID: 1136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000001")]
		[TimersDescription("Occurs when the Interval has elapsed.")]
		[Category("Behavior")]
		public event ElapsedEventHandler Elapsed
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x5103A10", Offset = "0x5102610", VA = "0x185103A10")]
			add
			{
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x5103CD0", Offset = "0x51028D0", VA = "0x185103CD0")]
			remove
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C6")]
		public override ISite Site
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x5104190", Offset = "0x5102D90", VA = "0x185104190", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		[TimersDescription("The object used to marshal the event handler calls issued when an interval has elapsed.")]
		[DefaultValue(null)]
		[Browsable(false)]
		public ISynchronizeInvoke SynchronizingObject
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x5103AB0", Offset = "0x51026B0", VA = "0x185103AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x5103270", Offset = "0x5101E70", VA = "0x185103270", Slot = "16")]
		public void BeginInit()
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x51034C0", Offset = "0x51020C0", VA = "0x1851034C0")]
		public void Close()
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x5103500", Offset = "0x5102100", VA = "0x185103500", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x5103570", Offset = "0x5102170", VA = "0x185103570", Slot = "17")]
		public void EndInit()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x51038E0", Offset = "0x51024E0", VA = "0x1851038E0")]
		public void Start()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x5103580", Offset = "0x5102180", VA = "0x185103580")]
		private void MyTimerCallback(object state)
		{
		}

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x28")]
		private double interval;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x30")]
		private bool enabled;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x31")]
		private bool initializing;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x32")]
		private bool delayedEnable;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x38")]
		private ElapsedEventHandler onIntervalElapsed;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x40")]
		private bool autoReset;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x48")]
		private ISynchronizeInvoke synchronizingObject;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x50")]
		private bool disposed;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x58")]
		private Timer timer;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x60")]
		private TimerCallback callback;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x68")]
		private object cookie;
	}
}
