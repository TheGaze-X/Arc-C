using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200227C RID: 8828
	[Token(Token = "0x200227C")]
	public class StrifeModeGlobalBuff : GlobalBuff
	{
		// Token: 0x0600DE15 RID: 56853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE15")]
		[Address(RVA = "0x3641010", Offset = "0x363FC10", VA = "0x183641010", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DE16 RID: 56854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE16")]
		[Address(RVA = "0x36418D0", Offset = "0x36404D0", VA = "0x1836418D0", Slot = "12")]
		public override void TryAddBuff(Unit unit, bool isInit = true)
		{
		}

		// Token: 0x0600DE17 RID: 56855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE17")]
		[Address(RVA = "0x3641670", Offset = "0x3640270", VA = "0x183641670", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DE18 RID: 56856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE18")]
		[Address(RVA = "0x3641E40", Offset = "0x3640A40", VA = "0x183641E40")]
		private void _OnWaveWillFinish(float showTime)
		{
		}

		// Token: 0x0600DE19 RID: 56857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE19")]
		[Address(RVA = "0x3641C60", Offset = "0x3640860", VA = "0x183641C60")]
		private void _FinishCurWaveBecauseTimeUp()
		{
		}

		// Token: 0x0600DE1A RID: 56858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE1A")]
		[Address(RVA = "0x3641F10", Offset = "0x3640B10", VA = "0x183641F10")]
		public StrifeModeGlobalBuff()
		{
		}

		// Token: 0x0600DE1C RID: 56860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE1C")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DE1D RID: 56861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE1D")]
		[Address(RVA = "0x362AB70", Offset = "0x3629770", VA = "0x18362AB70")]
		private void <>xLuaBaseProxy_TryAddBuff(Unit P0, bool P1)
		{
		}

		// Token: 0x0600DE1E RID: 56862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE1E")]
		[Address(RVA = "0x362C380", Offset = "0x362AF80", VA = "0x18362C380")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F0D3 RID: 61651
		[Token(Token = "0x400F0D3")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private List<Blackboard.DataPair> _initBlackboard;

		// Token: 0x0400F0D4 RID: 61652
		[Token(Token = "0x400F0D4")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<ObjectPtr<Buff>> m_buffs;

		// Token: 0x0400F0D5 RID: 61653
		[Token(Token = "0x400F0D5")]
		[FieldOffset(Offset = "0x158")]
		private int m_curWaveIndex;

		// Token: 0x0400F0D6 RID: 61654
		[Token(Token = "0x400F0D6")]
		[FieldOffset(Offset = "0x15C")]
		private int m_curWaveDuration;

		// Token: 0x0400F0D7 RID: 61655
		[Token(Token = "0x400F0D7")]
		[FieldOffset(Offset = "0x160")]
		private FP m_remaningDuration;

		// Token: 0x0400F0D8 RID: 61656
		[Token(Token = "0x400F0D8")]
		[FieldOffset(Offset = "0x168")]
		private bool m_hasSwitchedWave;

		// Token: 0x0400F0D9 RID: 61657
		[Token(Token = "0x400F0D9")]
		[FieldOffset(Offset = "0x169")]
		private bool m_killAllOneWaveMode;

		// Token: 0x0400F0DA RID: 61658
		[Token(Token = "0x400F0DA")]
		[FieldOffset(Offset = "0x170")]
		private List<int> m_durationEachWave;

		// Token: 0x0400F0DB RID: 61659
		[Token(Token = "0x400F0DB")]
		[FieldOffset(Offset = "0x178")]
		private GameModeFactory.StrifeGameMode m_gameMode;

		// Token: 0x0400F0DC RID: 61660
		[Token(Token = "0x400F0DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F0DD RID: 61661
		[Token(Token = "0x400F0DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryAddBuff;

		// Token: 0x0400F0DE RID: 61662
		[Token(Token = "0x400F0DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F0DF RID: 61663
		[Token(Token = "0x400F0DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnWaveWillFinish;

		// Token: 0x0400F0E0 RID: 61664
		[Token(Token = "0x400F0E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FinishCurWaveBecauseTimeUp;

		// Token: 0x0400F0E1 RID: 61665
		[Token(Token = "0x400F0E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
