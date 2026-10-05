using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B8D RID: 11149
	[Token(Token = "0x2002B8D")]
	public class BsnakeSummonHint : AbilityStandard
	{
		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x06012C26 RID: 76838 RVA: 0x00072E40 File Offset: 0x00071040
		[Token(Token = "0x1700295C")]
		public override FP cooldown
		{
			[Token(Token = "0x6012C26")]
			[Address(RVA = "0xAB3890", Offset = "0xAB2490", VA = "0x180AB3890", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x06012C27 RID: 76839 RVA: 0x00072E58 File Offset: 0x00071058
		[Token(Token = "0x1700295D")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012C27")]
			[Address(RVA = "0xAB3830", Offset = "0xAB2430", VA = "0x180AB3830", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x06012C28 RID: 76840 RVA: 0x00072E70 File Offset: 0x00071070
		[Token(Token = "0x1700295E")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012C28")]
			[Address(RVA = "0xAB3910", Offset = "0xAB2510", VA = "0x180AB3910", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x06012C29 RID: 76841 RVA: 0x00072E88 File Offset: 0x00071088
		[Token(Token = "0x1700295F")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012C29")]
			[Address(RVA = "0xAB37D0", Offset = "0xAB23D0", VA = "0x180AB37D0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012C2A RID: 76842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C2A")]
		[Address(RVA = "0xAB2F50", Offset = "0xAB1B50", VA = "0x180AB2F50", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012C2B RID: 76843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C2B")]
		[Address(RVA = "0xAB2E80", Offset = "0xAB1A80", VA = "0x180AB2E80", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012C2C RID: 76844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C2C")]
		[Address(RVA = "0xAB2FB0", Offset = "0xAB1BB0", VA = "0x180AB2FB0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012C2D RID: 76845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C2D")]
		[Address(RVA = "0xAB2EE0", Offset = "0xAB1AE0", VA = "0x180AB2EE0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012C2E RID: 76846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C2E")]
		[Address(RVA = "0xAB30D0", Offset = "0xAB1CD0", VA = "0x180AB30D0", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012C2F RID: 76847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012C2F")]
		[Address(RVA = "0xAB3040", Offset = "0xAB1C40", VA = "0x180AB3040", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012C30 RID: 76848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C30")]
		[Address(RVA = "0xAB3160", Offset = "0xAB1D60", VA = "0x180AB3160")]
		private void _InitTilePresetList()
		{
		}

		// Token: 0x06012C31 RID: 76849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C31")]
		[Address(RVA = "0xAB2D00", Offset = "0xAB1900", VA = "0x180AB2D00", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012C32 RID: 76850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C32")]
		[Address(RVA = "0xAB2C90", Offset = "0xAB1890", VA = "0x180AB2C90", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012C33 RID: 76851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C33")]
		[Address(RVA = "0xAB3650", Offset = "0xAB2250", VA = "0x180AB3650")]
		private void _RemoveEffects()
		{
		}

		// Token: 0x06012C34 RID: 76852 RVA: 0x00072EA0 File Offset: 0x000710A0
		[Token(Token = "0x6012C34")]
		[Address(RVA = "0xAB2970", Offset = "0xAB1570", VA = "0x180AB2970", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012C35 RID: 76853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C35")]
		[Address(RVA = "0xAB2DC0", Offset = "0xAB19C0", VA = "0x180AB2DC0", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012C36 RID: 76854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C36")]
		[Address(RVA = "0xAB3760", Offset = "0xAB2360", VA = "0x180AB3760")]
		public BsnakeSummonHint()
		{
		}

		// Token: 0x06012C37 RID: 76855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C37")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012C38 RID: 76856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C38")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012C39 RID: 76857 RVA: 0x00072EB8 File Offset: 0x000710B8
		[Token(Token = "0x6012C39")]
		[Address(RVA = "0xA38650", Offset = "0xA37250", VA = "0x180A38650")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x06012C3A RID: 76858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012C3A")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0401531B RID: 86811
		[Token(Token = "0x401531B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x0401531C RID: 86812
		[Token(Token = "0x401531C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _cancelBuffKey;

		// Token: 0x0401531D RID: 86813
		[Token(Token = "0x401531D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<Effect> m_effectList;

		// Token: 0x0401531E RID: 86814
		[Token(Token = "0x401531E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int m_cursor;

		// Token: 0x0401531F RID: 86815
		[Token(Token = "0x401531F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<List<Tile>> m_tilePresetList;

		// Token: 0x04015320 RID: 86816
		[Token(Token = "0x4015320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x04015321 RID: 86817
		[Token(Token = "0x4015321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04015322 RID: 86818
		[Token(Token = "0x4015322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x04015323 RID: 86819
		[Token(Token = "0x4015323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x04015324 RID: 86820
		[Token(Token = "0x4015324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x04015325 RID: 86821
		[Token(Token = "0x4015325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x04015326 RID: 86822
		[Token(Token = "0x4015326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015327 RID: 86823
		[Token(Token = "0x4015327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015328 RID: 86824
		[Token(Token = "0x4015328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x04015329 RID: 86825
		[Token(Token = "0x4015329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x0401532A RID: 86826
		[Token(Token = "0x401532A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitTilePresetList;

		// Token: 0x0401532B RID: 86827
		[Token(Token = "0x401532B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401532C RID: 86828
		[Token(Token = "0x401532C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x0401532D RID: 86829
		[Token(Token = "0x401532D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RemoveEffects;

		// Token: 0x0401532E RID: 86830
		[Token(Token = "0x401532E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x0401532F RID: 86831
		[Token(Token = "0x401532F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04015330 RID: 86832
		[Token(Token = "0x4015330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
