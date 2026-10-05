using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using XLua;

namespace Torappu.TimeModule
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	public class TimerGroup : IHotfixable
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0000683C File Offset: 0x00004A3C
		[Token(Token = "0x1700009F")]
		public bool thisFrameTicked
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x5529FF0", Offset = "0x5528BF0", VA = "0x185529FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00006854 File Offset: 0x00004A54
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x5528B10", Offset = "0x5527710", VA = "0x185528B10")]
		public int AddTimer(Action timerMethod, Action callbackOnRemoved, float interval, int loopCnt)
		{
			return 0;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x5528BD0", Offset = "0x55277D0", VA = "0x185528BD0")]
		public void ClearAll()
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x5528C90", Offset = "0x5527890", VA = "0x185528C90")]
		public void ClearTimer(int timerId)
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x5528DF0", Offset = "0x55279F0", VA = "0x185528DF0")]
		public TimerGroup.Timer FindTimer(int timerId)
		{
			return null;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0000686C File Offset: 0x00004A6C
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x5528EB0", Offset = "0x5527AB0", VA = "0x185528EB0")]
		public float GetLeftTime(TimerGroup.Timer timer)
		{
			return 0f;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x5528F80", Offset = "0x5527B80", VA = "0x185528F80")]
		public void Tick(float deltaTime)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00006884 File Offset: 0x00004A84
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x5529860", Offset = "0x5528460", VA = "0x185529860")]
		private int _AddTimerInternal(Action timerMethod, Action callbackOnRemoved, float interval, int loopCnt)
		{
			return 0;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x5529AF0", Offset = "0x55286F0", VA = "0x185529AF0")]
		private void _ClearTimerInternal(TimerGroup.Timer timer)
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x5529BE0", Offset = "0x55287E0", VA = "0x185529BE0")]
		private TimerGroup.Timer _CreateTimer()
		{
			return null;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x5529CB0", Offset = "0x55288B0", VA = "0x185529CB0")]
		private void _RemoveTimer(TimerGroup.Timer timer)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x5529D80", Offset = "0x5528980", VA = "0x185529D80")]
		public TimerGroup()
		{
		}

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, TimerGroup.Timer> m_timers;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x18")]
		private readonly Heap<TimerGroup.Timer> m_activeTimers;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x20")]
		private readonly IntHashSet m_pendingToActiveTimerIds;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x28")]
		private readonly LocalGenericPool<TimerGroup.Timer> m_timerPool;

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x30")]
		private float m_internalTime;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x38")]
		private ulong m_lastFrameCount;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_thisFrameTicked;

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate135 __Hotfix0_AddTimer;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ClearAll;

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate26 __Hotfix0_ClearTimer;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate136 __Hotfix0_FindTimer;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate137 __Hotfix0_GetLeftTime;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate24 __Hotfix0_Tick;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate135 __Hotfix0__AddTimerInternal;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate0 __Hotfix0__ClearTimerInternal;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate138 __Hotfix0__CreateTimer;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate0 __Hotfix0__RemoveTimer;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000139 RID: 313
		[Token(Token = "0x2000139")]
		public class Timer : IComparable<TimerGroup.Timer>
		{
			// Token: 0x06000772 RID: 1906 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x5535EC0", Offset = "0x5534AC0", VA = "0x185535EC0")]
			public void OnAllocate()
			{
			}

			// Token: 0x06000773 RID: 1907 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x5535F30", Offset = "0x5534B30", VA = "0x185535F30")]
			public void OnRecycle()
			{
			}

			// Token: 0x06000774 RID: 1908 RVA: 0x0000689C File Offset: 0x00004A9C
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x5535E90", Offset = "0x5534A90", VA = "0x185535E90", Slot = "4")]
			public int CompareTo(TimerGroup.Timer other)
			{
				return 0;
			}

			// Token: 0x06000775 RID: 1909 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Timer()
			{
			}

			// Token: 0x04000672 RID: 1650
			[Token(Token = "0x4000672")]
			[FieldOffset(Offset = "0x0")]
			private static int s_uniqueId;

			// Token: 0x04000673 RID: 1651
			[Token(Token = "0x4000673")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			// Token: 0x04000674 RID: 1652
			[Token(Token = "0x4000674")]
			[FieldOffset(Offset = "0x14")]
			public TimerStatus status;

			// Token: 0x04000675 RID: 1653
			[Token(Token = "0x4000675")]
			[FieldOffset(Offset = "0x18")]
			public int loopCount;

			// Token: 0x04000676 RID: 1654
			[Token(Token = "0x4000676")]
			[FieldOffset(Offset = "0x1C")]
			public float expireTime;

			// Token: 0x04000677 RID: 1655
			[Token(Token = "0x4000677")]
			[FieldOffset(Offset = "0x20")]
			public float interval;

			// Token: 0x04000678 RID: 1656
			[Token(Token = "0x4000678")]
			[FieldOffset(Offset = "0x28")]
			public Action callback;

			// Token: 0x04000679 RID: 1657
			[Token(Token = "0x4000679")]
			[FieldOffset(Offset = "0x30")]
			public Action callbackOnRemoved;
		}
	}
}
