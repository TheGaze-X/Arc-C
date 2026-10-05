using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035AA RID: 13738
	[Token(Token = "0x20035AA")]
	public struct DefaultSkinInfoClampRule : IInfoClampRule<BasicCharInfoModel, BasicCharInfoModel.DefaultSkinInfoPatchBuilder>, IHotfixable
	{
		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x06015D92 RID: 89490 RVA: 0x0008E578 File Offset: 0x0008C778
		// (set) Token: 0x06015D93 RID: 89491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700343E")]
		public SkinClampRuleForLevel ruleForLevel
		{
			[Token(Token = "0x6015D92")]
			[Address(RVA = "0xE70E80", Offset = "0xE6FA80", VA = "0x180E70E80")]
			[CompilerGenerated]
			readonly get
			{
				return default(SkinClampRuleForLevel);
			}
			[Token(Token = "0x6015D93")]
			[Address(RVA = "0xE70F10", Offset = "0xE6FB10", VA = "0x180E70F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D94 RID: 89492 RVA: 0x0008E590 File Offset: 0x0008C790
		[Token(Token = "0x6015D94")]
		[Address(RVA = "0xE70C00", Offset = "0xE6F800", VA = "0x180E70C00")]
		public static DefaultSkinInfoClampRule CreateRule(CharQuery charQuery, EvolvePhase evolvePhase)
		{
			return default(DefaultSkinInfoClampRule);
		}

		// Token: 0x06015D95 RID: 89493 RVA: 0x0008E5A8 File Offset: 0x0008C7A8
		[Token(Token = "0x6015D95")]
		[Address(RVA = "0xE70D80", Offset = "0xE6F980", VA = "0x180E70D80", Slot = "4")]
		public BasicCharInfoModel.DefaultSkinInfoPatchBuilder DoClamp(BasicCharInfoModel.DefaultSkinInfoPatchBuilder builder)
		{
			return default(BasicCharInfoModel.DefaultSkinInfoPatchBuilder);
		}

		// Token: 0x0401A48B RID: 107659
		[Token(Token = "0x401A48B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ruleForLevel;

		// Token: 0x0401A48C RID: 107660
		[Token(Token = "0x401A48C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ruleForLevel;

		// Token: 0x0401A48D RID: 107661
		[Token(Token = "0x401A48D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateRule;

		// Token: 0x0401A48E RID: 107662
		[Token(Token = "0x401A48E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
