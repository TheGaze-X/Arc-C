using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028B8 RID: 10424
	[Token(Token = "0x20028B8")]
	public class SkillSubTalents : BasicSkill.Behaviour
	{
		// Token: 0x06011565 RID: 71013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011565")]
		[Address(RVA = "0x9311A0", Offset = "0x92FDA0", VA = "0x1809311A0", Slot = "8")]
		public override void PostprocessData(Dictionary<string, TalentData> talentMap)
		{
		}

		// Token: 0x06011566 RID: 71014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011566")]
		[Address(RVA = "0x930FB0", Offset = "0x92FBB0", VA = "0x180930FB0", Slot = "9")]
		public override void OnSkillStart()
		{
		}

		// Token: 0x06011567 RID: 71015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011567")]
		[Address(RVA = "0x930E40", Offset = "0x92FA40", VA = "0x180930E40", Slot = "10")]
		public override void OnSkillEnd()
		{
		}

		// Token: 0x06011568 RID: 71016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011568")]
		[Address(RVA = "0x9313E0", Offset = "0x92FFE0", VA = "0x1809313E0")]
		private void _AssignSubTalents(Dictionary<string, TalentData> talentMap)
		{
		}

		// Token: 0x06011569 RID: 71017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011569")]
		[Address(RVA = "0x931230", Offset = "0x92FE30", VA = "0x180931230")]
		private void _ActivateSubTalent()
		{
		}

		// Token: 0x0601156A RID: 71018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601156A")]
		[Address(RVA = "0x931700", Offset = "0x930300", VA = "0x180931700")]
		private void _InactivateSubTalent()
		{
		}

		// Token: 0x0601156B RID: 71019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601156B")]
		[Address(RVA = "0x930DC0", Offset = "0x92F9C0", VA = "0x180930DC0")]
		private void Awake()
		{
		}

		// Token: 0x0601156C RID: 71020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601156C")]
		[Address(RVA = "0x931840", Offset = "0x930440", VA = "0x180931840")]
		public SkillSubTalents()
		{
		}

		// Token: 0x0601156D RID: 71021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601156D")]
		[Address(RVA = "0x931220", Offset = "0x92FE20", VA = "0x180931220")]
		private void <>xLuaBaseProxy_PostprocessData(Dictionary<string, TalentData> P0)
		{
		}

		// Token: 0x0601156E RID: 71022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601156E")]
		[Address(RVA = "0x91D780", Offset = "0x91C380", VA = "0x18091D780")]
		private void <>xLuaBaseProxy_OnSkillStart()
		{
		}

		// Token: 0x0601156F RID: 71023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601156F")]
		[Address(RVA = "0x91D770", Offset = "0x91C370", VA = "0x18091D770")]
		private void <>xLuaBaseProxy_OnSkillEnd()
		{
		}

		// Token: 0x0401360B RID: 79371
		[Token(Token = "0x401360B")]
		[FieldOffset(Offset = "0x20")]
		private ConstrainedTalent[] m_talents;

		// Token: 0x0401360C RID: 79372
		[Token(Token = "0x401360C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PostprocessData;

		// Token: 0x0401360D RID: 79373
		[Token(Token = "0x401360D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSkillStart;

		// Token: 0x0401360E RID: 79374
		[Token(Token = "0x401360E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSkillEnd;

		// Token: 0x0401360F RID: 79375
		[Token(Token = "0x401360F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AssignSubTalents;

		// Token: 0x04013610 RID: 79376
		[Token(Token = "0x4013610")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ActivateSubTalent;

		// Token: 0x04013611 RID: 79377
		[Token(Token = "0x4013611")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InactivateSubTalent;

		// Token: 0x04013612 RID: 79378
		[Token(Token = "0x4013612")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04013613 RID: 79379
		[Token(Token = "0x4013613")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
