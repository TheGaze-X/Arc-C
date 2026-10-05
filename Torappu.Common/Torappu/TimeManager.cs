using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.TimeModule;
using XLua;

namespace Torappu
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class TimeManager : Singleton<TimeManager>
	{
		// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x54F3F70", Offset = "0x54F2B70", VA = "0x1854F3F70")]
		private TickGroup.Root _PickTickRoot(TickGroupType type)
		{
			return null;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002F6C File Offset: 0x0000116C
		// (set) Token: 0x06000201 RID: 513 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700003A")]
		public ulong frameCount
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x54F4870", Offset = "0x54F3470", VA = "0x1854F4870")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x54F49F0", Offset = "0x54F35F0", VA = "0x1854F49F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00002F84 File Offset: 0x00001184
		// (set) Token: 0x06000203 RID: 515 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700003B")]
		public bool isInited
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x54F48D0", Offset = "0x54F34D0", VA = "0x1854F48D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x54F4A60", Offset = "0x54F3660", VA = "0x1854F4A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x1700003C")]
		public float timeScale
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x54F4930", Offset = "0x54F3530", VA = "0x1854F4930")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x1700003D")]
		public double unscaledTime
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x54F4990", Offset = "0x54F3590", VA = "0x1854F4990")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x54F3020", Offset = "0x54F1C20", VA = "0x1854F3020")]
		public void Init(TimeManager.Options options)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x54F39D0", Offset = "0x54F25D0", VA = "0x1854F39D0")]
		public void UnInit()
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x54F3700", Offset = "0x54F2300", VA = "0x1854F3700")]
		public void Tick(float unscaledDeltaTime)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x54F3340", Offset = "0x54F1F40", VA = "0x1854F3340")]
		public TickFunction NewRoughLogicTick(Action<float> tickFunc, object context)
		{
			return null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x54F32A0", Offset = "0x54F1EA0", VA = "0x1854F32A0")]
		public TickFunction NewRoughLogicTickWithOwner(ITickOwner owner, Action<float> tickFunc)
		{
			return null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x54F3200", Offset = "0x54F1E00", VA = "0x1854F3200")]
		public TickFunction NewFrameTick(Action<float> tickFunc, object context)
		{
			return null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x54F3160", Offset = "0x54F1D60", VA = "0x1854F3160")]
		public TickFunction NewFrameTickWithOwner(ITickOwner owner, Action<float> tickFunc)
		{
			return null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x54F3E90", Offset = "0x54F2A90", VA = "0x1854F3E90")]
		private TickFunction _NewTickFunc(TickGroupType type, Action<float> tickFunc, object context)
		{
			return null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x54F3DB0", Offset = "0x54F29B0", VA = "0x1854F3DB0")]
		private TickFunction _NewTickFuncWithOwner(TickGroupType type, ITickOwner owner, Action<float> tickFunc)
		{
			return null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x54F4250", Offset = "0x54F2E50", VA = "0x1854F4250")]
		[Conditional("TEST")]
		private static void _TestOnlyDebugNameByContext(object context, string tickType, ref string debugName)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x54F44E0", Offset = "0x54F30E0", VA = "0x1854F44E0")]
		[Conditional("TEST")]
		private static void _TestOnlyDebugNameByOwner(ITickOwner owner, string tickType, ref string debugName)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x54F3540", Offset = "0x54F2140", VA = "0x1854F3540")]
		public TickFunction StartInstruciton(TickYieldInstruction inst)
		{
			return null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x54F2A60", Offset = "0x54F1660", VA = "0x1854F2A60")]
		public int AddDelayTimer(float delay, Action callback, bool unscaled = true)
		{
			return 0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x54F2980", Offset = "0x54F1580", VA = "0x1854F2980")]
		public int AddDelayTimer(float delay, Action callback, Action callbackOnRemoved, bool unscaled = true)
		{
			return 0;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x54F2B30", Offset = "0x54F1730", VA = "0x1854F2B30")]
		public int AddLoopTimer(float interval, Action callback, int loopCnt, [Optional] Action callbackOnRemoved, bool unscaled = true)
		{
			return 0;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x54F2DD0", Offset = "0x54F19D0", VA = "0x1854F2DD0")]
		public void ClearTimer(int timerId)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x54F2E70", Offset = "0x54F1A70", VA = "0x1854F2E70")]
		public float GetTimerLeftTime(int timerId)
		{
			return 0f;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x54F2F60", Offset = "0x54F1B60", VA = "0x1854F2F60")]
		public TimerStatus GetTimerStatus(int timerId)
		{
			return TimerStatus.INACTIVE;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x54F4030", Offset = "0x54F2C30", VA = "0x1854F4030")]
		private TimerGroup _PickTimerGroup(bool unscaled)
		{
			return null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x54F3480", Offset = "0x54F2080", VA = "0x1854F3480")]
		public int StartChangeTimeScale(float inTimeScale)
		{
			return 0;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x54F2C20", Offset = "0x54F1820", VA = "0x1854F2C20")]
		public bool ChangeTimeScaleByExistingKey(int key, float inTimeScale)
		{
			return default(bool);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x54F3650", Offset = "0x54F2250", VA = "0x1854F3650")]
		public void StopChangeTimeScale(int key)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x54F33E0", Offset = "0x54F1FE0", VA = "0x1854F33E0")]
		public void ResetTimeScale()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x54F3BE0", Offset = "0x54F27E0", VA = "0x1854F3BE0")]
		private float _GetLowestTimeScale()
		{
			return 0f;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x54F40C0", Offset = "0x54F2CC0", VA = "0x1854F40C0")]
		private void _SetTimeScale(float inTimeScale)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x54F4610", Offset = "0x54F3210", VA = "0x1854F4610")]
		private TimeManager()
		{
		}

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		public const float DEFAULT_TIME_SCALE = 1f;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		public const int EMPTY_TIMER = 0;

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		private const string NAME_ROUGH_LOGIC = "RoughLogicTick";

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		private const string NAME_FRAME = "FrameTick";

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_unscaledTime;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, float> m_timeScaleDic;

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_timeScaleKeyCounter;

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_timeScale;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_maxTimeDelta;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ListDict<int, TickGroup.Root> m_tickRoots;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly TimerGroup m_unscaledTimers;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly TimerGroup m_scaledTimers;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate35 __Hotfix0__PickTickRoot;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate36 __Hotfix0_get_frameCount;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate37 __Hotfix0_set_frameCount;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isInited;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_isInited;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_timeScale;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate38 __Hotfix0_get_unscaledTime;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate39 __Hotfix0_Init;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate1 __Hotfix0_UnInit;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate24 __Hotfix0_Tick;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate40 __Hotfix0_NewRoughLogicTick;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate40 __Hotfix0_NewRoughLogicTickWithOwner;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate40 __Hotfix0_NewFrameTick;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate40 __Hotfix0_NewFrameTickWithOwner;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate41 __Hotfix0__NewTickFunc;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate41 __Hotfix0__NewTickFuncWithOwner;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate42 __Hotfix0__TestOnlyDebugNameByContext;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate42 __Hotfix0__TestOnlyDebugNameByOwner;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate43 __Hotfix0_StartInstruciton;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate44 __Hotfix0_AddDelayTimer;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate45 __Hotfix1_AddDelayTimer;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate46 __Hotfix0_AddLoopTimer;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate26 __Hotfix0_ClearTimer;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate47 __Hotfix0_GetTimerLeftTime;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate48 __Hotfix0_GetTimerStatus;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static __XLua_Gen_Delegate49 __Hotfix0__PickTimerGroup;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static __XLua_Gen_Delegate29 __Hotfix0_StartChangeTimeScale;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static __XLua_Gen_Delegate50 __Hotfix0_ChangeTimeScaleByExistingKey;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static __XLua_Gen_Delegate26 __Hotfix0_StopChangeTimeScale;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ResetTimeScale;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static __XLua_Gen_Delegate23 __Hotfix0__GetLowestTimeScale;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static __XLua_Gen_Delegate24 __Hotfix0__SetTimeScale;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		public struct Options
		{
			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int maxDeltaTimeRate;

			// Token: 0x040003BF RID: 959
			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int roughLogicRate;
		}
	}
}
