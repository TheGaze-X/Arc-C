using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public class TickFunctionTimer : IHotfixable
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x17000037")]
		public TickFunctionTimer.Status timerStatus
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x54F1080", Offset = "0x54EFC80", VA = "0x1854F1080")]
			get
			{
				return TickFunctionTimer.Status.CLOSE;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x54F0B10", Offset = "0x54EF710", VA = "0x1854F0B10")]
		private bool _IsTimerAvail()
		{
			return default(bool);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x54F0BB0", Offset = "0x54EF7B0", VA = "0x1854F0BB0")]
		private void _Tick(float deltaTime)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x54F0C90", Offset = "0x54EF890", VA = "0x1854F0C90")]
		private void _UpdateTimerLoopCount()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x54F02C0", Offset = "0x54EEEC0", VA = "0x1854F02C0")]
		public static TickFunctionTimer Create(TickFunctionTimer.Input input)
		{
			return null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x54F0E70", Offset = "0x54EFA70", VA = "0x1854F0E70")]
		private TickFunctionTimer(TickFunctionTimer.Input timerInput)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x54F0910", Offset = "0x54EF510", VA = "0x1854F0910")]
		private TickFunction _CreateTickFunction()
		{
			return null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x54F06F0", Offset = "0x54EF2F0", VA = "0x1854F06F0")]
		public bool StartTimer(bool isRestart = false)
		{
			return default(bool);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x54F05E0", Offset = "0x54EF1E0", VA = "0x1854F05E0")]
		public bool ResumeTimer()
		{
			return default(bool);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x54F0880", Offset = "0x54EF480", VA = "0x1854F0880")]
		public bool StopTimer()
		{
			return default(bool);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x54F0560", Offset = "0x54EF160", VA = "0x1854F0560")]
		public void ReleaseTimer()
		{
		}

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x10")]
		private TickGroupType m_tickGroupType;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x14")]
		private float m_targetTime;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x18")]
		private float m_timeCount;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x20")]
		private TickFunction m_tickFunction;

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x28")]
		private Action m_callback;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x30")]
		private object m_context;

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasSetOwner;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_owner;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x48")]
		private int m_targetLoopLimitCount;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x4C")]
		private int m_curLoopCount;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate30 __Hotfix0_get_timerStatus;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate21 __Hotfix0__IsTimerAvail;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate24 __Hotfix0__Tick;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0__UpdateTimerLoopCount;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate31 __Hotfix0_Create;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate32 _c__Hotfix0_ctor;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate33 __Hotfix0__CreateTickFunction;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate34 __Hotfix0_StartTimer;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate21 __Hotfix0_ResumeTimer;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate21 __Hotfix0_StopTimer;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ReleaseTimer;

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x200008C")]
		public struct Input
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x00002F0C File Offset: 0x0000110C
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x54E4040", Offset = "0x54E2C40", VA = "0x1854E4040")]
			public static TickFunctionTimer.Input CreateCommonTimerInput(float delay, Action callback, Transform owner)
			{
				return default(TickFunctionTimer.Input);
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x00002F24 File Offset: 0x00001124
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x54E40A0", Offset = "0x54E2CA0", VA = "0x1854E40A0")]
			public static TickFunctionTimer.Input CreateEndlessTimerInput(float delay, Action callback, Transform owner)
			{
				return default(TickFunctionTimer.Input);
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x00002F3C File Offset: 0x0000113C
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x54E4100", Offset = "0x54E2D00", VA = "0x1854E4100")]
			public static TickFunctionTimer.Input CreateLimitTimeInput(float delay, int timerLoopTimeLimit, Action callback, Transform owner)
			{
				return default(TickFunctionTimer.Input);
			}

			// Token: 0x04000371 RID: 881
			[Token(Token = "0x4000371")]
			[FieldOffset(Offset = "0x0")]
			public TickFunctionTimer.TimerLoopType timerLoopType;

			// Token: 0x04000372 RID: 882
			[Token(Token = "0x4000372")]
			[FieldOffset(Offset = "0x4")]
			public int timerLoopTimeLimit;

			// Token: 0x04000373 RID: 883
			[Token(Token = "0x4000373")]
			[FieldOffset(Offset = "0x8")]
			public TickGroupType tickGroupType;

			// Token: 0x04000374 RID: 884
			[Token(Token = "0x4000374")]
			[FieldOffset(Offset = "0xC")]
			public float delay;

			// Token: 0x04000375 RID: 885
			[Token(Token = "0x4000375")]
			[FieldOffset(Offset = "0x10")]
			public Action callback;

			// Token: 0x04000376 RID: 886
			[Token(Token = "0x4000376")]
			[FieldOffset(Offset = "0x18")]
			public object context;

			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			[FieldOffset(Offset = "0x20")]
			public Transform owner;
		}

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		public enum TimerLoopType
		{
			// Token: 0x04000379 RID: 889
			[Token(Token = "0x4000379")]
			ONCE,
			// Token: 0x0400037A RID: 890
			[Token(Token = "0x400037A")]
			ENDLESS,
			// Token: 0x0400037B RID: 891
			[Token(Token = "0x400037B")]
			LIMIT_TIME
		}

		// Token: 0x0200008E RID: 142
		[Token(Token = "0x200008E")]
		public enum Status
		{
			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			CLOSE,
			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			RUNNING,
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			STOPPING
		}
	}
}
