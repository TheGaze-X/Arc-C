using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003597 RID: 13719
	[Token(Token = "0x2003597")]
	public struct DefaultDetailInfoClampRule : IInfoClampRule<BasicCharInfoModel, BasicCharInfoModel.DefaultDetailInfoPatchBuilder>, IHotfixable
	{
		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x06015D16 RID: 89366 RVA: 0x0008DF60 File Offset: 0x0008C160
		// (set) Token: 0x06015D17 RID: 89367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700341A")]
		public DetailClampRuleForLevel ruleForLevel
		{
			[Token(Token = "0x6015D16")]
			[Address(RVA = "0xE693A0", Offset = "0xE67FA0", VA = "0x180E693A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(DetailClampRuleForLevel);
			}
			[Token(Token = "0x6015D17")]
			[Address(RVA = "0xE69430", Offset = "0xE68030", VA = "0x180E69430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D18 RID: 89368 RVA: 0x0008DF78 File Offset: 0x0008C178
		[Token(Token = "0x6015D18")]
		[Address(RVA = "0xE69070", Offset = "0xE67C70", VA = "0x180E69070")]
		public static DefaultDetailInfoClampRule CreateRule(CharQuery charQuery, int level, EvolvePhase evolvePhase)
		{
			return default(DefaultDetailInfoClampRule);
		}

		// Token: 0x06015D19 RID: 89369 RVA: 0x0008DF90 File Offset: 0x0008C190
		[Token(Token = "0x6015D19")]
		[Address(RVA = "0xE69210", Offset = "0xE67E10", VA = "0x180E69210", Slot = "4")]
		public BasicCharInfoModel.DefaultDetailInfoPatchBuilder DoClamp(BasicCharInfoModel.DefaultDetailInfoPatchBuilder detailInfoBuilder)
		{
			return default(BasicCharInfoModel.DefaultDetailInfoPatchBuilder);
		}

		// Token: 0x0401A3EC RID: 107500
		[Token(Token = "0x401A3EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ruleForLevel;

		// Token: 0x0401A3ED RID: 107501
		[Token(Token = "0x401A3ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ruleForLevel;

		// Token: 0x0401A3EE RID: 107502
		[Token(Token = "0x401A3EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateRule;

		// Token: 0x0401A3EF RID: 107503
		[Token(Token = "0x401A3EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
