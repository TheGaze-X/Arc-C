using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public class TickFunction : AutoReleasableGroup.ICustom, IHotfixable
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x17000030")]
		public float timeScale
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x54F2480", Offset = "0x54F1080", VA = "0x1854F2480")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x54F16A0", Offset = "0x54F02A0", VA = "0x1854F16A0")]
		public void SetTimeScale(float inScale)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002DD4 File Offset: 0x00000FD4
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000031")]
		public float baseSelfTimeScale
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x54F2000", Offset = "0x54F0C00", VA = "0x1854F2000")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x54F2500", Offset = "0x54F1100", VA = "0x1854F2500")]
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x17000032")]
		public float selfTimeScale
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x54F2280", Offset = "0x54F0E80", VA = "0x1854F2280")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002E04 File Offset: 0x00001004
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000033")]
		public bool ignoreGlobalTimeScale
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x54F2100", Offset = "0x54F0D00", VA = "0x1854F2100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x54F2670", Offset = "0x54F1270", VA = "0x1854F2670")]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002E1C File Offset: 0x0000101C
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000034")]
		public bool isReleased
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x54F2180", Offset = "0x54F0D80", VA = "0x1854F2180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x54F2710", Offset = "0x54F1310", VA = "0x1854F2710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002E34 File Offset: 0x00001034
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000035")]
		public bool isTicking
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x54F2200", Offset = "0x54F0E00", VA = "0x1854F2200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x54F27A0", Offset = "0x54F13A0", VA = "0x1854F27A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002E4C File Offset: 0x0000104C
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000036")]
		public int frame
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x54F2080", Offset = "0x54F0C80", VA = "0x1854F2080")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x54F25E0", Offset = "0x54F11E0", VA = "0x1854F25E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x54F1EF0", Offset = "0x54F0AF0", VA = "0x1854F1EF0")]
		public TickFunction(ITickOwner owner, Action<float> func, string debugName)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x54F1320", Offset = "0x54EFF20", VA = "0x1854F1320")]
		public void ClearFrameCount()
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x54F1940", Offset = "0x54F0540", VA = "0x1854F1940")]
		public void Tick(float unscaledDeltaTime, double unscaledTime)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x54F13A0", Offset = "0x54EFFA0", VA = "0x1854F13A0")]
		public void OnGlobalTimeScaleChange(float globalTimeScale)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x54F1840", Offset = "0x54F0440", VA = "0x1854F1840")]
		public void Start()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x54F18C0", Offset = "0x54F04C0", VA = "0x1854F18C0")]
		public void Stop()
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x54F1620", Offset = "0x54F0220", VA = "0x1854F1620")]
		public void Resume()
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x54F1290", Offset = "0x54EFE90", VA = "0x1854F1290", Slot = "4")]
		public bool CheckActive()
		{
			return default(bool);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x54F1450", Offset = "0x54F0050", VA = "0x1854F1450", Slot = "5")]
		public void Release()
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x54F1120", Offset = "0x54EFD20", VA = "0x1854F1120")]
		public int AddSelfTimeScaleModifier(float value)
		{
			return 0;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x54F1560", Offset = "0x54F0160", VA = "0x1854F1560")]
		public void RemoveSelfTimeScaleModifier(int handle)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x54F1B10", Offset = "0x54F0710", VA = "0x1854F1B10")]
		private void _OnTick(float deltaTime)
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x54F1BF0", Offset = "0x54F07F0", VA = "0x1854F1BF0")]
		private void _OnTimeScaleChange(float newTimeScale)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x54F1D30", Offset = "0x54F0930", VA = "0x1854F1D30")]
		private void _ReCalculateTimeScale()
		{
		}

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x0")]
		private static int s_selfModifierInstanceId;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x10")]
		private readonly ITickOwner m_owner;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action<float> m_func;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x20")]
		private float m_timeScale;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x24")]
		private float m_baseSelfTimeScale;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x28")]
		private bool m_ignoreGlobalTimeScale;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, float> m_selfTimeScaleModifier;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x38")]
		private double m_lastTickTs;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x40")]
		public bool tickWhenTimeScaleZero;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_timeScale;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate24 __Hotfix0_SetTimeScale;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_baseSelfTimeScale;

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate24 __Hotfix0_set_baseSelfTimeScale;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_selfTimeScale;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_ignoreGlobalTimeScale;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_ignoreGlobalTimeScale;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isReleased;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_isReleased;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isTicking;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_isTicking;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_frame;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate26 __Hotfix0_set_frame;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate27 _c__Hotfix0_ctor;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ClearFrameCount;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate28 __Hotfix0_Tick;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate24 __Hotfix0_OnGlobalTimeScaleChange;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Start;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Stop;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Resume;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckActive;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Release;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate29 __Hotfix0_AddSelfTimeScaleModifier;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate26 __Hotfix0_RemoveSelfTimeScaleModifier;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0xC8")]
		private static __XLua_Gen_Delegate24 __Hotfix0__OnTick;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0xD0")]
		private static __XLua_Gen_Delegate24 __Hotfix0__OnTimeScaleChange;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0xD8")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ReCalculateTimeScale;
	}
}
