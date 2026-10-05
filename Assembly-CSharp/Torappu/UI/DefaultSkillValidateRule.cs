using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A8 RID: 13736
	[Token(Token = "0x20035A8")]
	public struct DefaultSkillValidateRule : IInfoValidateRule<CommonCharCardSkillInfo, CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder>, IHotfixable
	{
		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x06015D86 RID: 89478 RVA: 0x0008E4D0 File Offset: 0x0008C6D0
		// (set) Token: 0x06015D87 RID: 89479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700343A")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015D86")]
			[Address(RVA = "0xE709E0", Offset = "0xE6F5E0", VA = "0x180E709E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015D87")]
			[Address(RVA = "0xE70AE0", Offset = "0xE6F6E0", VA = "0x180E70AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x06015D88 RID: 89480 RVA: 0x0008E4E8 File Offset: 0x0008C6E8
		// (set) Token: 0x06015D89 RID: 89481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700343B")]
		public SkillValidateRuleByLevel ruleByLevel
		{
			[Token(Token = "0x6015D88")]
			[Address(RVA = "0xE70A70", Offset = "0xE6F670", VA = "0x180E70A70")]
			[CompilerGenerated]
			readonly get
			{
				return default(SkillValidateRuleByLevel);
			}
			[Token(Token = "0x6015D89")]
			[Address(RVA = "0xE70B80", Offset = "0xE6F780", VA = "0x180E70B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D8A RID: 89482 RVA: 0x0008E500 File Offset: 0x0008C700
		[Token(Token = "0x6015D8A")]
		[Address(RVA = "0xE704F0", Offset = "0xE6F0F0", VA = "0x180E704F0")]
		public static DefaultSkillValidateRule CreateRule(CharQuery charQuery, int level, EvolvePhase evolvePhase)
		{
			return default(DefaultSkillValidateRule);
		}

		// Token: 0x06015D8B RID: 89483 RVA: 0x0008E518 File Offset: 0x0008C718
		[Token(Token = "0x6015D8B")]
		[Address(RVA = "0xE706C0", Offset = "0xE6F2C0", VA = "0x180E706C0", Slot = "4")]
		public CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder DoValidate(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder skillInfoBuilder)
		{
			return default(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder);
		}

		// Token: 0x0401A47C RID: 107644
		[Token(Token = "0x401A47C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A47D RID: 107645
		[Token(Token = "0x401A47D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A47E RID: 107646
		[Token(Token = "0x401A47E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ruleByLevel;

		// Token: 0x0401A47F RID: 107647
		[Token(Token = "0x401A47F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_ruleByLevel;

		// Token: 0x0401A480 RID: 107648
		[Token(Token = "0x401A480")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateRule;

		// Token: 0x0401A481 RID: 107649
		[Token(Token = "0x401A481")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoValidate;
	}
}
