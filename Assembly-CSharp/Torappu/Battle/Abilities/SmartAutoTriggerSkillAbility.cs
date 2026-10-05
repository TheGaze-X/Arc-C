using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B70 RID: 11120
	[Token(Token = "0x2002B70")]
	public class SmartAutoTriggerSkillAbility : AutoTriggerSkillAbility
	{
		// Token: 0x06012AC5 RID: 76485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AC5")]
		[Address(RVA = "0xAA5CF0", Offset = "0xAA48F0", VA = "0x180AA5CF0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012AC6 RID: 76486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AC6")]
		[Address(RVA = "0xAA5E00", Offset = "0xAA4A00", VA = "0x180AA5E00", Slot = "96")]
		protected override void DoTriggerSkill(FP deltaTime)
		{
		}

		// Token: 0x06012AC7 RID: 76487 RVA: 0x000726A8 File Offset: 0x000708A8
		[Token(Token = "0x6012AC7")]
		[Address(RVA = "0xAA6530", Offset = "0xAA5130", VA = "0x180AA6530")]
		private bool _DoDefaultCheck(Character character)
		{
			return default(bool);
		}

		// Token: 0x06012AC8 RID: 76488 RVA: 0x000726C0 File Offset: 0x000708C0
		[Token(Token = "0x6012AC8")]
		[Address(RVA = "0xAA5F80", Offset = "0xAA4B80", VA = "0x180AA5F80")]
		private bool _CheckToggleSkill(BasicSkill skill)
		{
			return default(bool);
		}

		// Token: 0x06012AC9 RID: 76489 RVA: 0x000726D8 File Offset: 0x000708D8
		[Token(Token = "0x6012AC9")]
		[Address(RVA = "0xAA6150", Offset = "0xAA4D50", VA = "0x180AA6150")]
		private bool _DefaultTriggerSkill(Character character)
		{
			return default(bool);
		}

		// Token: 0x06012ACA RID: 76490 RVA: 0x000726F0 File Offset: 0x000708F0
		[Token(Token = "0x6012ACA")]
		[Address(RVA = "0xAA6650", Offset = "0xAA5250", VA = "0x180AA6650")]
		private bool _TryTriggerSkill()
		{
			return default(bool);
		}

		// Token: 0x06012ACB RID: 76491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ACB")]
		[Address(RVA = "0xAA6890", Offset = "0xAA5490", VA = "0x180AA6890")]
		public SmartAutoTriggerSkillAbility()
		{
		}

		// Token: 0x06012ACC RID: 76492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ACC")]
		[Address(RVA = "0xAA5F50", Offset = "0xAA4B50", VA = "0x180AA5F50")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012ACD RID: 76493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ACD")]
		[Address(RVA = "0xA9D2D0", Offset = "0xA9BED0", VA = "0x180A9D2D0")]
		private void <>xLuaBaseProxy_DoTriggerSkill(FP P0)
		{
		}

		// Token: 0x040151B7 RID: 86455
		[Token(Token = "0x40151B7")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private float _checkInterval;

		// Token: 0x040151B8 RID: 86456
		[Token(Token = "0x40151B8")]
		[FieldOffset(Offset = "0x138")]
		private PeriodicTimer m_checkTimer;

		// Token: 0x040151B9 RID: 86457
		[Token(Token = "0x40151B9")]
		[FieldOffset(Offset = "0x140")]
		private TargetOptions m_findEnemyTargetOptions;

		// Token: 0x040151BA RID: 86458
		[Token(Token = "0x40151BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040151BB RID: 86459
		[Token(Token = "0x40151BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoTriggerSkill;

		// Token: 0x040151BC RID: 86460
		[Token(Token = "0x40151BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoDefaultCheck;

		// Token: 0x040151BD RID: 86461
		[Token(Token = "0x40151BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckToggleSkill;

		// Token: 0x040151BE RID: 86462
		[Token(Token = "0x40151BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DefaultTriggerSkill;

		// Token: 0x040151BF RID: 86463
		[Token(Token = "0x40151BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTriggerSkill;

		// Token: 0x040151C0 RID: 86464
		[Token(Token = "0x40151C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
