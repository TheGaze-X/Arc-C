using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	internal abstract class ScheduledItem
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public long startMs
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public long delayMs
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		public long intervalMs
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x20339E0", Offset = "0x20325E0", VA = "0x1820339E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x17000089")]
		public long endTimeMs
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x5A3B440", Offset = "0x5A3A040", VA = "0x185A3B440")]
		public ScheduledItem()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x5A3B1C0", Offset = "0x5A39DC0", VA = "0x185A3B1C0")]
		protected void ResetStartTime()
		{
		}

		// Token: 0x0600024B RID: 587
		[Token(Token = "0x600024B")]
		public abstract void PerformTimerUpdate(TimerState state);

		// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		internal virtual void OnItemUnscheduled()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x5A3B2C0", Offset = "0x5A39EC0", VA = "0x185A3B2C0", Slot = "6")]
		public virtual bool ShouldUnschedule()
		{
			return default(bool);
		}

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x10")]
		public Func<bool> timerUpdateStopCondition;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Func<bool> OnceCondition;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Func<bool> ForeverCondition;
	}
}
