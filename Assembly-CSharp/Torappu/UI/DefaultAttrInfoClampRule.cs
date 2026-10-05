using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003588 RID: 13704
	[Token(Token = "0x2003588")]
	public struct DefaultAttrInfoClampRule : IInfoClampRule<BasicCharInfoModel, BasicCharInfoModel.DefaultAttrInfoPatchBuilder>, IHotfixable
	{
		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x06015CDD RID: 89309 RVA: 0x0008DE88 File Offset: 0x0008C088
		// (set) Token: 0x06015CDE RID: 89310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033F2")]
		public AttrClampRuleForLevel ruleForLevel
		{
			[Token(Token = "0x6015CDD")]
			[Address(RVA = "0xE66DB0", Offset = "0xE659B0", VA = "0x180E66DB0")]
			[CompilerGenerated]
			readonly get
			{
				return default(AttrClampRuleForLevel);
			}
			[Token(Token = "0x6015CDE")]
			[Address(RVA = "0xE66E60", Offset = "0xE65A60", VA = "0x180E66E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015CDF RID: 89311 RVA: 0x0008DEA0 File Offset: 0x0008C0A0
		[Token(Token = "0x6015CDF")]
		[Address(RVA = "0xE66A80", Offset = "0xE65680", VA = "0x180E66A80")]
		public static DefaultAttrInfoClampRule CreateRule(CharQuery charQuery, int level, EvolvePhase evolvePhase, int potentialRank, int favorPoint, List<CharacterData.UniqueEquipPair> uniEquipQueries)
		{
			return default(DefaultAttrInfoClampRule);
		}

		// Token: 0x06015CE0 RID: 89312 RVA: 0x0008DEB8 File Offset: 0x0008C0B8
		[Token(Token = "0x6015CE0")]
		[Address(RVA = "0xE66C80", Offset = "0xE65880", VA = "0x180E66C80", Slot = "4")]
		public BasicCharInfoModel.DefaultAttrInfoPatchBuilder DoClamp(BasicCharInfoModel.DefaultAttrInfoPatchBuilder identityInfoBuilder)
		{
			return default(BasicCharInfoModel.DefaultAttrInfoPatchBuilder);
		}

		// Token: 0x0401A3CB RID: 107467
		[Token(Token = "0x401A3CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ruleForLevel;

		// Token: 0x0401A3CC RID: 107468
		[Token(Token = "0x401A3CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ruleForLevel;

		// Token: 0x0401A3CD RID: 107469
		[Token(Token = "0x401A3CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateRule;

		// Token: 0x0401A3CE RID: 107470
		[Token(Token = "0x401A3CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
