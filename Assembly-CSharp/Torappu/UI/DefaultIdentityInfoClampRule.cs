using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A2 RID: 13730
	[Token(Token = "0x20035A2")]
	public struct DefaultIdentityInfoClampRule : IInfoClampRule<BasicCharInfoModel, BasicCharInfoModel.DefaultIdentityInfoPatchBuilder>, IHotfixable
	{
		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x06015D5C RID: 89436 RVA: 0x0008E2C0 File Offset: 0x0008C4C0
		// (set) Token: 0x06015D5D RID: 89437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700342F")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015D5C")]
			[Address(RVA = "0xE6C1C0", Offset = "0xE6ADC0", VA = "0x180E6C1C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015D5D")]
			[Address(RVA = "0xE6C2C0", Offset = "0xE6AEC0", VA = "0x180E6C2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x06015D5E RID: 89438 RVA: 0x0008E2D8 File Offset: 0x0008C4D8
		// (set) Token: 0x06015D5F RID: 89439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003430")]
		public IdentityClampRuleForLevel ruleForLevel
		{
			[Token(Token = "0x6015D5E")]
			[Address(RVA = "0xE6C250", Offset = "0xE6AE50", VA = "0x180E6C250")]
			[CompilerGenerated]
			readonly get
			{
				return default(IdentityClampRuleForLevel);
			}
			[Token(Token = "0x6015D5F")]
			[Address(RVA = "0xE6C360", Offset = "0xE6AF60", VA = "0x180E6C360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D60 RID: 89440 RVA: 0x0008E2F0 File Offset: 0x0008C4F0
		[Token(Token = "0x6015D60")]
		[Address(RVA = "0xE6BE90", Offset = "0xE6AA90", VA = "0x180E6BE90")]
		public static DefaultIdentityInfoClampRule CreateRule(CharQuery charQuery, int level, EvolvePhase evolvePhase)
		{
			return default(DefaultIdentityInfoClampRule);
		}

		// Token: 0x06015D61 RID: 89441 RVA: 0x0008E308 File Offset: 0x0008C508
		[Token(Token = "0x6015D61")]
		[Address(RVA = "0xE6C060", Offset = "0xE6AC60", VA = "0x180E6C060", Slot = "4")]
		public BasicCharInfoModel.DefaultIdentityInfoPatchBuilder DoClamp(BasicCharInfoModel.DefaultIdentityInfoPatchBuilder identityInfoBuilder)
		{
			return default(BasicCharInfoModel.DefaultIdentityInfoPatchBuilder);
		}

		// Token: 0x0401A445 RID: 107589
		[Token(Token = "0x401A445")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A446 RID: 107590
		[Token(Token = "0x401A446")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A447 RID: 107591
		[Token(Token = "0x401A447")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ruleForLevel;

		// Token: 0x0401A448 RID: 107592
		[Token(Token = "0x401A448")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_ruleForLevel;

		// Token: 0x0401A449 RID: 107593
		[Token(Token = "0x401A449")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateRule;

		// Token: 0x0401A44A RID: 107594
		[Token(Token = "0x401A44A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
