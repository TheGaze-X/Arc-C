using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B6F RID: 11119
	[Token(Token = "0x2002B6F")]
	public class AutoTriggerSkillAbility : PassiveBuffAbility
	{
		// Token: 0x06012ABF RID: 76479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012ABF")]
		[Address(RVA = "0xA9D030", Offset = "0xA9BC30", VA = "0x180A9D030", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012AC0 RID: 76480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AC0")]
		[Address(RVA = "0xA9D430", Offset = "0xA9C030", VA = "0x180A9D430", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012AC1 RID: 76481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AC1")]
		[Address(RVA = "0xA9D2D0", Offset = "0xA9BED0", VA = "0x180A9D2D0", Slot = "96")]
		protected virtual void DoTriggerSkill(FP deltaTime)
		{
		}

		// Token: 0x06012AC2 RID: 76482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AC2")]
		[Address(RVA = "0xA9D520", Offset = "0xA9C120", VA = "0x180A9D520")]
		public AutoTriggerSkillAbility()
		{
		}

		// Token: 0x06012AC3 RID: 76483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AC3")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012AC4 RID: 76484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012AC4")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040151B1 RID: 86449
		[Token(Token = "0x40151B1")]
		[FieldOffset(Offset = "0x118")]
		protected ObjectPtr<Character> m_character;

		// Token: 0x040151B2 RID: 86450
		[Token(Token = "0x40151B2")]
		[FieldOffset(Offset = "0x128")]
		protected BasicSkill m_skill;

		// Token: 0x040151B3 RID: 86451
		[Token(Token = "0x40151B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040151B4 RID: 86452
		[Token(Token = "0x40151B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040151B5 RID: 86453
		[Token(Token = "0x40151B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoTriggerSkill;

		// Token: 0x040151B6 RID: 86454
		[Token(Token = "0x40151B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
