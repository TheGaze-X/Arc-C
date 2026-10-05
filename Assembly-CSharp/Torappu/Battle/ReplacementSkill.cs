using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200245C RID: 9308
	[Token(Token = "0x200245C")]
	public class ReplacementSkill : NextAttackOrCombatSkill, Character.IReplacement
	{
		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x0600EF4C RID: 61260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F0B")]
		public override IDrawableRange rangeToShow
		{
			[Token(Token = "0x600EF4C")]
			[Address(RVA = "0x6793C0", Offset = "0x677FC0", VA = "0x1806793C0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EF4D RID: 61261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF4D")]
		[Address(RVA = "0x678E40", Offset = "0x677A40", VA = "0x180678E40", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EF4E RID: 61262 RVA: 0x000580E0 File Offset: 0x000562E0
		[Token(Token = "0x600EF4E")]
		[Address(RVA = "0x6789B0", Offset = "0x6775B0", VA = "0x1806789B0", Slot = "80")]
		protected override bool CheckIfToModify(Ability atkOrCbt, bool isCombat)
		{
			return default(bool);
		}

		// Token: 0x0600EF4F RID: 61263 RVA: 0x000580F8 File Offset: 0x000562F8
		[Token(Token = "0x600EF4F")]
		[Address(RVA = "0x678A80", Offset = "0x677680", VA = "0x180678A80", Slot = "49")]
		protected override bool DoCast(Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF50 RID: 61264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF50")]
		[Address(RVA = "0x678690", Offset = "0x677290", VA = "0x180678690", Slot = "81")]
		protected override void ApplyModification()
		{
		}

		// Token: 0x0600EF51 RID: 61265 RVA: 0x00058110 File Offset: 0x00056310
		[Token(Token = "0x600EF51")]
		[Address(RVA = "0x678870", Offset = "0x677470", VA = "0x180678870", Slot = "82")]
		protected override bool CancelAfterAttack(Ability atkOrCbt, bool isCombat, Ability.FinishReason reason)
		{
			return default(bool);
		}

		// Token: 0x0600EF52 RID: 61266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF52")]
		[Address(RVA = "0x678B90", Offset = "0x677790", VA = "0x180678B90", Slot = "76")]
		protected override void OnCastFinish(Ability ability, Ability.FinishReason reason, bool resetCd)
		{
		}

		// Token: 0x0600EF53 RID: 61267 RVA: 0x00058128 File Offset: 0x00056328
		[Token(Token = "0x600EF53")]
		[Address(RVA = "0x678F50", Offset = "0x677B50", VA = "0x180678F50", Slot = "86")]
		public bool TryHookSearchTarget(out bool isFound)
		{
			return default(bool);
		}

		// Token: 0x0600EF54 RID: 61268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF54")]
		[Address(RVA = "0x679120", Offset = "0x677D20", VA = "0x180679120")]
		private void _RecoverSp(int delta)
		{
		}

		// Token: 0x0600EF55 RID: 61269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF55")]
		[Address(RVA = "0x679310", Offset = "0x677F10", VA = "0x180679310")]
		public ReplacementSkill()
		{
		}

		// Token: 0x0600EF56 RID: 61270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EF56")]
		[Address(RVA = "0x679110", Offset = "0x677D10", VA = "0x180679110")]
		private IDrawableRange <>xLuaBaseProxy_get_rangeToShow()
		{
			return null;
		}

		// Token: 0x0600EF57 RID: 61271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF57")]
		[Address(RVA = "0x634E10", Offset = "0x633A10", VA = "0x180634E10")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600EF58 RID: 61272 RVA: 0x00058140 File Offset: 0x00056340
		[Token(Token = "0x600EF58")]
		[Address(RVA = "0x679100", Offset = "0x677D00", VA = "0x180679100")]
		private bool <>xLuaBaseProxy_DoCast(Ability.FinishCallbackDelegate P0, PlayerSide P1)
		{
			return default(bool);
		}

		// Token: 0x0600EF59 RID: 61273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF59")]
		[Address(RVA = "0x6462C0", Offset = "0x644EC0", VA = "0x1806462C0")]
		private void <>xLuaBaseProxy_OnCastFinish(Ability P0, Ability.FinishReason P1, bool P2)
		{
		}

		// Token: 0x0401089D RID: 67741
		[Token(Token = "0x401089D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _cancelIfSearchTargetFailed;

		// Token: 0x0401089E RID: 67742
		[Token(Token = "0x401089E")]
		[FieldOffset(Offset = "0x121")]
		[SerializeField]
		private bool _recoverSpIfTargetDead;

		// Token: 0x0401089F RID: 67743
		[Token(Token = "0x401089F")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private TargetSelector _rangeToShow;

		// Token: 0x040108A0 RID: 67744
		[Token(Token = "0x40108A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rangeToShow;

		// Token: 0x040108A1 RID: 67745
		[Token(Token = "0x40108A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040108A2 RID: 67746
		[Token(Token = "0x40108A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfToModify;

		// Token: 0x040108A3 RID: 67747
		[Token(Token = "0x40108A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x040108A4 RID: 67748
		[Token(Token = "0x40108A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyModification;

		// Token: 0x040108A5 RID: 67749
		[Token(Token = "0x40108A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CancelAfterAttack;

		// Token: 0x040108A6 RID: 67750
		[Token(Token = "0x40108A6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCastFinish;

		// Token: 0x040108A7 RID: 67751
		[Token(Token = "0x40108A7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryHookSearchTarget;

		// Token: 0x040108A8 RID: 67752
		[Token(Token = "0x40108A8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RecoverSp;

		// Token: 0x040108A9 RID: 67753
		[Token(Token = "0x40108A9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
