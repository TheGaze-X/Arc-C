using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B72 RID: 11122
	[Token(Token = "0x2002B72")]
	public abstract class TriggablePassiveAbility : AbilityStandard, IActionNodeSource
	{
		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x06012AD0 RID: 76496 RVA: 0x00072720 File Offset: 0x00070920
		[Token(Token = "0x1700291A")]
		public override FP cooldown
		{
			[Token(Token = "0x6012AD0")]
			[Address(RVA = "0xAA9790", Offset = "0xAA8390", VA = "0x180AA9790", Slot = "16")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x06012AD1 RID: 76497 RVA: 0x00072738 File Offset: 0x00070938
		[Token(Token = "0x1700291B")]
		public override Ability.Category category
		{
			[Token(Token = "0x6012AD1")]
			[Address(RVA = "0xAA9730", Offset = "0xAA8330", VA = "0x180AA9730", Slot = "13")]
			get
			{
				return Ability.Category.NONE;
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x06012AD2 RID: 76498 RVA: 0x00072750 File Offset: 0x00070950
		[Token(Token = "0x1700291C")]
		public override AbilityStandard.SelectTargetSource selectTargetSource
		{
			[Token(Token = "0x6012AD2")]
			[Address(RVA = "0xAA9810", Offset = "0xAA8410", VA = "0x180AA9810", Slot = "65")]
			get
			{
				return AbilityStandard.SelectTargetSource.NONE;
			}
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x06012AD3 RID: 76499 RVA: 0x00072768 File Offset: 0x00070968
		[Token(Token = "0x1700291D")]
		protected override bool alwaysIncludeTarget
		{
			[Token(Token = "0x6012AD3")]
			[Address(RVA = "0xAA96D0", Offset = "0xAA82D0", VA = "0x180AA96D0", Slot = "67")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012AD4 RID: 76500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AD4")]
		[Address(RVA = "0xAA8DA0", Offset = "0xAA79A0", VA = "0x180AA8DA0", Slot = "48")]
		public override void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x06012AD5 RID: 76501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AD5")]
		[Address(RVA = "0xAA8E40", Offset = "0xAA7A40", VA = "0x180AA8E40", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012AD6 RID: 76502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012AD6")]
		[Address(RVA = "0xAA8F40", Offset = "0xAA7B40", VA = "0x180AA8F40", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012AD7 RID: 76503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012AD7")]
		[Address(RVA = "0xAA9010", Offset = "0xAA7C10", VA = "0x180AA9010", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012AD8 RID: 76504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012AD8")]
		[Address(RVA = "0xAA8FB0", Offset = "0xAA7BB0", VA = "0x180AA8FB0", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012AD9 RID: 76505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012AD9")]
		[Address(RVA = "0xAA8EE0", Offset = "0xAA7AE0", VA = "0x180AA8EE0", Slot = "43")]
		public override IList<BuffData> GetActiveBuffs()
		{
			return null;
		}

		// Token: 0x06012ADA RID: 76506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012ADA")]
		[Address(RVA = "0xAA9560", Offset = "0xAA8160", VA = "0x180AA9560", Slot = "75")]
		protected override IEnumerator OnWaitForPreDelay()
		{
			return null;
		}

		// Token: 0x06012ADB RID: 76507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012ADB")]
		[Address(RVA = "0xAA94D0", Offset = "0xAA80D0", VA = "0x180AA94D0", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012ADC RID: 76508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ADC")]
		[Address(RVA = "0xAA90A0", Offset = "0xAA7CA0", VA = "0x180AA90A0")]
		protected void OnTrigger()
		{
		}

		// Token: 0x06012ADD RID: 76509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ADD")]
		[Address(RVA = "0xAA95F0", Offset = "0xAA81F0", VA = "0x180AA95F0")]
		protected TriggablePassiveAbility()
		{
		}

		// Token: 0x06012ADE RID: 76510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ADE")]
		[Address(RVA = "0xA1EDE0", Offset = "0xA1D9E0", VA = "0x180A1EDE0")]
		private void <>xLuaBaseProxy_GatherActionNodes(List<ActionNode> P0)
		{
		}

		// Token: 0x06012ADF RID: 76511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ADF")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x040151C2 RID: 86466
		[Token(Token = "0x40151C2")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		protected ActionArray _actions;

		// Token: 0x040151C3 RID: 86467
		[Token(Token = "0x40151C3")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected BuffData[] _buffs;

		// Token: 0x040151C4 RID: 86468
		[Token(Token = "0x40151C4")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _alwaysIncludeSelf;

		// Token: 0x040151C5 RID: 86469
		[Token(Token = "0x40151C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cooldown;

		// Token: 0x040151C6 RID: 86470
		[Token(Token = "0x40151C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x040151C7 RID: 86471
		[Token(Token = "0x40151C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectTargetSource;

		// Token: 0x040151C8 RID: 86472
		[Token(Token = "0x40151C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_alwaysIncludeTarget;

		// Token: 0x040151C9 RID: 86473
		[Token(Token = "0x40151C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x040151CA RID: 86474
		[Token(Token = "0x40151CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040151CB RID: 86475
		[Token(Token = "0x40151CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x040151CC RID: 86476
		[Token(Token = "0x40151CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x040151CD RID: 86477
		[Token(Token = "0x40151CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x040151CE RID: 86478
		[Token(Token = "0x40151CE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetActiveBuffs;

		// Token: 0x040151CF RID: 86479
		[Token(Token = "0x40151CF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWaitForPreDelay;

		// Token: 0x040151D0 RID: 86480
		[Token(Token = "0x40151D0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x040151D1 RID: 86481
		[Token(Token = "0x40151D1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x040151D2 RID: 86482
		[Token(Token = "0x40151D2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
