using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Legion;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200226D RID: 8813
	[Token(Token = "0x200226D")]
	public class DynamicGlobalBuff : GlobalBuff, IHotfixable
	{
		// Token: 0x0600DDA0 RID: 56736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA0")]
		[Address(RVA = "0x36306C0", Offset = "0x362F2C0", VA = "0x1836306C0", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DDA1 RID: 56737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA1")]
		[Address(RVA = "0x3631600", Offset = "0x3630200", VA = "0x183631600", Slot = "12")]
		public override void TryAddBuff(Unit unit, bool isInit = true)
		{
		}

		// Token: 0x0600DDA2 RID: 56738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA2")]
		[Address(RVA = "0x3631EB0", Offset = "0x3630AB0", VA = "0x183631EB0")]
		private void _RefreshBuff()
		{
		}

		// Token: 0x0600DDA3 RID: 56739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA3")]
		[Address(RVA = "0x3632550", Offset = "0x3631150", VA = "0x183632550")]
		private void _UpdateMaxStackCnt()
		{
		}

		// Token: 0x0600DDA4 RID: 56740 RVA: 0x00050D60 File Offset: 0x0004EF60
		[Token(Token = "0x600DDA4")]
		[Address(RVA = "0x3631B80", Offset = "0x3630780", VA = "0x183631B80")]
		private bool _RefreshBlackboard(bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600DDA5 RID: 56741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA5")]
		[Address(RVA = "0x3630FF0", Offset = "0x362FBF0", VA = "0x183630FF0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DDA6 RID: 56742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA6")]
		[Address(RVA = "0x36322E0", Offset = "0x3630EE0", VA = "0x1836322E0")]
		private void _RefreshTimeScale()
		{
		}

		// Token: 0x0600DDA7 RID: 56743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA7")]
		[Address(RVA = "0x36318C0", Offset = "0x36304C0", VA = "0x1836318C0")]
		private void _ClearInvalidDangerScaleBuffs()
		{
		}

		// Token: 0x0600DDA8 RID: 56744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA8")]
		[Address(RVA = "0x36321E0", Offset = "0x3630DE0", VA = "0x1836321E0")]
		private void _RefreshLegionModeDangerLevel()
		{
		}

		// Token: 0x0600DDA9 RID: 56745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDA9")]
		[Address(RVA = "0x3631A40", Offset = "0x3630640", VA = "0x183631A40")]
		private void _OnWaveWillStart()
		{
		}

		// Token: 0x0600DDAA RID: 56746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDAA")]
		[Address(RVA = "0x3630470", Offset = "0x362F070", VA = "0x183630470")]
		public void ModifyRefreshTimeScale(Buff modifier, FP scale)
		{
		}

		// Token: 0x0600DDAB RID: 56747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDAB")]
		[Address(RVA = "0x36314A0", Offset = "0x36300A0", VA = "0x1836314A0")]
		public void ResetRefreshTimeScale(Buff modifier)
		{
		}

		// Token: 0x0600DDAC RID: 56748 RVA: 0x00050D78 File Offset: 0x0004EF78
		[Token(Token = "0x600DDAC")]
		[Address(RVA = "0x3632660", Offset = "0x3631260", VA = "0x183632660", Slot = "15")]
		protected override bool _VerifyTarget(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x0600DDAD RID: 56749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDAD")]
		[Address(RVA = "0x3630570", Offset = "0x362F170", VA = "0x183630570")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600DDAE RID: 56750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDAE")]
		[Address(RVA = "0x3632740", Offset = "0x3631340", VA = "0x183632740")]
		public DynamicGlobalBuff()
		{
		}

		// Token: 0x0600DDAF RID: 56751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDAF")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DDB0 RID: 56752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB0")]
		[Address(RVA = "0x362AB70", Offset = "0x3629770", VA = "0x18362AB70")]
		private void <>xLuaBaseProxy_TryAddBuff(Unit P0, bool P1)
		{
		}

		// Token: 0x0600DDB1 RID: 56753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDB1")]
		[Address(RVA = "0x362C380", Offset = "0x362AF80", VA = "0x18362C380")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600DDB2 RID: 56754 RVA: 0x00050D90 File Offset: 0x0004EF90
		[Token(Token = "0x600DDB2")]
		[Address(RVA = "0x36318B0", Offset = "0x36304B0", VA = "0x1836318B0")]
		private bool <>xLuaBaseProxy__VerifyTarget(Unit P0)
		{
			return default(bool);
		}

		// Token: 0x0400F02B RID: 61483
		[Token(Token = "0x400F02B")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private List<string> _keysScaleWithTime;

		// Token: 0x0400F02C RID: 61484
		[Token(Token = "0x400F02C")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private bool _untickInWavePostDelay;

		// Token: 0x0400F02D RID: 61485
		[Token(Token = "0x400F02D")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private List<Blackboard.DataPair> _initBlackboard;

		// Token: 0x0400F02E RID: 61486
		[Token(Token = "0x400F02E")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<ObjectPtr<Buff>> m_buffs;

		// Token: 0x0400F02F RID: 61487
		[Token(Token = "0x400F02F")]
		[FieldOffset(Offset = "0x168")]
		private readonly List<int> m_buffDataIndices;

		// Token: 0x0400F030 RID: 61488
		[Token(Token = "0x400F030")]
		[FieldOffset(Offset = "0x170")]
		private FP m_refreshInterval;

		// Token: 0x0400F031 RID: 61489
		[Token(Token = "0x400F031")]
		[FieldOffset(Offset = "0x178")]
		private FP m_originRefreshTimeScale;

		// Token: 0x0400F032 RID: 61490
		[Token(Token = "0x400F032")]
		[FieldOffset(Offset = "0x180")]
		private FP m_refreshTimeScale;

		// Token: 0x0400F033 RID: 61491
		[Token(Token = "0x400F033")]
		[FieldOffset(Offset = "0x188")]
		private FP m_refreshProgressValue;

		// Token: 0x0400F034 RID: 61492
		[Token(Token = "0x400F034")]
		[FieldOffset(Offset = "0x190")]
		private int m_stackCnt;

		// Token: 0x0400F035 RID: 61493
		[Token(Token = "0x400F035")]
		[FieldOffset(Offset = "0x194")]
		private int m_maxStackCnt;

		// Token: 0x0400F036 RID: 61494
		[Token(Token = "0x400F036")]
		[FieldOffset(Offset = "0x198")]
		private int m_curStackCntIndex;

		// Token: 0x0400F037 RID: 61495
		[Token(Token = "0x400F037")]
		[FieldOffset(Offset = "0x1A0")]
		private List<int> m_stackCntLimit;

		// Token: 0x0400F038 RID: 61496
		[Token(Token = "0x400F038")]
		[FieldOffset(Offset = "0x1A8")]
		private Blackboard m_scaledBlackboard;

		// Token: 0x0400F039 RID: 61497
		[Token(Token = "0x400F039")]
		[FieldOffset(Offset = "0x1B0")]
		private LegionUIPlugin m_legionPlugin;

		// Token: 0x0400F03A RID: 61498
		[Token(Token = "0x400F03A")]
		[FieldOffset(Offset = "0x1B8")]
		private GameModeFactory.LegionGameMode m_gameMode;

		// Token: 0x0400F03B RID: 61499
		[Token(Token = "0x400F03B")]
		[FieldOffset(Offset = "0x1C0")]
		private ListDict<ObjectPtr<Buff>, FP> m_dangerScaleModifierBuffs;

		// Token: 0x0400F03C RID: 61500
		[Token(Token = "0x400F03C")]
		[FieldOffset(Offset = "0x1C8")]
		private bool m_dangerScaleDirty;

		// Token: 0x0400F03D RID: 61501
		[Token(Token = "0x400F03D")]
		[FieldOffset(Offset = "0x1D0")]
		private HashSet<string> m_buffBlacklist;

		// Token: 0x0400F03E RID: 61502
		[Token(Token = "0x400F03E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F03F RID: 61503
		[Token(Token = "0x400F03F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryAddBuff;

		// Token: 0x0400F040 RID: 61504
		[Token(Token = "0x400F040")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshBuff;

		// Token: 0x0400F041 RID: 61505
		[Token(Token = "0x400F041")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateMaxStackCnt;

		// Token: 0x0400F042 RID: 61506
		[Token(Token = "0x400F042")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshBlackboard;

		// Token: 0x0400F043 RID: 61507
		[Token(Token = "0x400F043")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F044 RID: 61508
		[Token(Token = "0x400F044")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshTimeScale;

		// Token: 0x0400F045 RID: 61509
		[Token(Token = "0x400F045")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ClearInvalidDangerScaleBuffs;

		// Token: 0x0400F046 RID: 61510
		[Token(Token = "0x400F046")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshLegionModeDangerLevel;

		// Token: 0x0400F047 RID: 61511
		[Token(Token = "0x400F047")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnWaveWillStart;

		// Token: 0x0400F048 RID: 61512
		[Token(Token = "0x400F048")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ModifyRefreshTimeScale;

		// Token: 0x0400F049 RID: 61513
		[Token(Token = "0x400F049")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ResetRefreshTimeScale;

		// Token: 0x0400F04A RID: 61514
		[Token(Token = "0x400F04A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__VerifyTarget;

		// Token: 0x0400F04B RID: 61515
		[Token(Token = "0x400F04B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F04C RID: 61516
		[Token(Token = "0x400F04C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
