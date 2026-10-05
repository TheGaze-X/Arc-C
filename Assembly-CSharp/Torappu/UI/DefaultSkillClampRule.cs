using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A4 RID: 13732
	[Token(Token = "0x20035A4")]
	public struct DefaultSkillClampRule : IInfoClampRule<CommonCharCardSkillInfo, CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder>, IHotfixable
	{
		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x06015D68 RID: 89448 RVA: 0x0008E368 File Offset: 0x0008C568
		// (set) Token: 0x06015D69 RID: 89449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003433")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015D68")]
			[Address(RVA = "0xE6E340", Offset = "0xE6CF40", VA = "0x180E6E340")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015D69")]
			[Address(RVA = "0xE6E440", Offset = "0xE6D040", VA = "0x180E6E440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x06015D6A RID: 89450 RVA: 0x0008E380 File Offset: 0x0008C580
		// (set) Token: 0x06015D6B RID: 89451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003434")]
		public SkillSpecLvClampRuleForLegal ruleForLegal
		{
			[Token(Token = "0x6015D6A")]
			[Address(RVA = "0xE6E3D0", Offset = "0xE6CFD0", VA = "0x180E6E3D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(SkillSpecLvClampRuleForLegal);
			}
			[Token(Token = "0x6015D6B")]
			[Address(RVA = "0xE6E4E0", Offset = "0xE6D0E0", VA = "0x180E6E4E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D6C RID: 89452 RVA: 0x0008E398 File Offset: 0x0008C598
		[Token(Token = "0x6015D6C")]
		[Address(RVA = "0xE6DE20", Offset = "0xE6CA20", VA = "0x180E6DE20")]
		public static DefaultSkillClampRule CreateRule(CharQuery charQuery)
		{
			return default(DefaultSkillClampRule);
		}

		// Token: 0x06015D6D RID: 89453 RVA: 0x0008E3B0 File Offset: 0x0008C5B0
		[Token(Token = "0x6015D6D")]
		[Address(RVA = "0xE6DFB0", Offset = "0xE6CBB0", VA = "0x180E6DFB0", Slot = "4")]
		public CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder DoClamp(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder builder)
		{
			return default(CommonCharCardSkillInfo.DefaultSkillInfoPatchBuilder);
		}

		// Token: 0x0401A455 RID: 107605
		[Token(Token = "0x401A455")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A456 RID: 107606
		[Token(Token = "0x401A456")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A457 RID: 107607
		[Token(Token = "0x401A457")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ruleForLegal;

		// Token: 0x0401A458 RID: 107608
		[Token(Token = "0x401A458")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_ruleForLegal;

		// Token: 0x0401A459 RID: 107609
		[Token(Token = "0x401A459")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateRule;

		// Token: 0x0401A45A RID: 107610
		[Token(Token = "0x401A45A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
