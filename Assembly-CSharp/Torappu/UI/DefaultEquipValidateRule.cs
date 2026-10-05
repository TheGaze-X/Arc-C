using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200359B RID: 13723
	[Token(Token = "0x200359B")]
	public struct DefaultEquipValidateRule : IInfoValidateRule<CommonCharCardEquipInfo, CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder>, IHotfixable
	{
		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x06015D35 RID: 89397 RVA: 0x0008E110 File Offset: 0x0008C310
		// (set) Token: 0x06015D36 RID: 89398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003422")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015D35")]
			[Address(RVA = "0xE6B6D0", Offset = "0xE6A2D0", VA = "0x180E6B6D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015D36")]
			[Address(RVA = "0xE6BA70", Offset = "0xE6A670", VA = "0x180E6BA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x06015D37 RID: 89399 RVA: 0x0008E128 File Offset: 0x0008C328
		// (set) Token: 0x06015D38 RID: 89400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003423")]
		public bool checkPlayerRepo
		{
			[Token(Token = "0x6015D37")]
			[Address(RVA = "0xE6B790", Offset = "0xE6A390", VA = "0x180E6B790")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6015D38")]
			[Address(RVA = "0xE6BB50", Offset = "0xE6A750", VA = "0x180E6BB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x06015D39 RID: 89401 RVA: 0x0008E140 File Offset: 0x0008C340
		// (set) Token: 0x06015D3A RID: 89402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003424")]
		public EquipValidateRuleByTmplMatch ruleByTmplMatch
		{
			[Token(Token = "0x6015D39")]
			[Address(RVA = "0xE6B9A0", Offset = "0xE6A5A0", VA = "0x180E6B9A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(EquipValidateRuleByTmplMatch);
			}
			[Token(Token = "0x6015D3A")]
			[Address(RVA = "0xE6BDB0", Offset = "0xE6A9B0", VA = "0x180E6BDB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x06015D3B RID: 89403 RVA: 0x0008E158 File Offset: 0x0008C358
		// (set) Token: 0x06015D3C RID: 89404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003425")]
		public EquipValidateRuleByLevel ruleByLevel
		{
			[Token(Token = "0x6015D3B")]
			[Address(RVA = "0xE6B830", Offset = "0xE6A430", VA = "0x180E6B830")]
			[CompilerGenerated]
			readonly get
			{
				return default(EquipValidateRuleByLevel);
			}
			[Token(Token = "0x6015D3C")]
			[Address(RVA = "0xE6BC10", Offset = "0xE6A810", VA = "0x180E6BC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x06015D3D RID: 89405 RVA: 0x0008E170 File Offset: 0x0008C370
		// (set) Token: 0x06015D3E RID: 89406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003426")]
		public EquipValidateRuleByPlayerRepo ruleByPlayerRepo
		{
			[Token(Token = "0x6015D3D")]
			[Address(RVA = "0xE6B8D0", Offset = "0xE6A4D0", VA = "0x180E6B8D0")]
			[CompilerGenerated]
			readonly get
			{
				return default(EquipValidateRuleByPlayerRepo);
			}
			[Token(Token = "0x6015D3E")]
			[Address(RVA = "0xE6BCD0", Offset = "0xE6A8D0", VA = "0x180E6BCD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D3F RID: 89407 RVA: 0x0008E188 File Offset: 0x0008C388
		[Token(Token = "0x6015D3F")]
		[Address(RVA = "0xE6AA30", Offset = "0xE69630", VA = "0x180E6AA30")]
		public static DefaultEquipValidateRule CreateRule(CharQuery charQuery, int level, EvolvePhase evolvePhase, bool checkPlayerRepo = true)
		{
			return default(DefaultEquipValidateRule);
		}

		// Token: 0x06015D40 RID: 89408 RVA: 0x0008E1A0 File Offset: 0x0008C3A0
		[Token(Token = "0x6015D40")]
		[Address(RVA = "0xE6AE40", Offset = "0xE69A40", VA = "0x180E6AE40", Slot = "4")]
		public CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder DoValidate(CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder equipInfoBuilder)
		{
			return default(CommonCharCardEquipInfo.DefaultEquipInfoPatchBuilder);
		}

		// Token: 0x0401A416 RID: 107542
		[Token(Token = "0x401A416")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A417 RID: 107543
		[Token(Token = "0x401A417")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A418 RID: 107544
		[Token(Token = "0x401A418")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_checkPlayerRepo;

		// Token: 0x0401A419 RID: 107545
		[Token(Token = "0x401A419")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_checkPlayerRepo;

		// Token: 0x0401A41A RID: 107546
		[Token(Token = "0x401A41A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ruleByTmplMatch;

		// Token: 0x0401A41B RID: 107547
		[Token(Token = "0x401A41B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_ruleByTmplMatch;

		// Token: 0x0401A41C RID: 107548
		[Token(Token = "0x401A41C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_ruleByLevel;

		// Token: 0x0401A41D RID: 107549
		[Token(Token = "0x401A41D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_ruleByLevel;

		// Token: 0x0401A41E RID: 107550
		[Token(Token = "0x401A41E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_ruleByPlayerRepo;

		// Token: 0x0401A41F RID: 107551
		[Token(Token = "0x401A41F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_ruleByPlayerRepo;

		// Token: 0x0401A420 RID: 107552
		[Token(Token = "0x401A420")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CreateRule;

		// Token: 0x0401A421 RID: 107553
		[Token(Token = "0x401A421")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoValidate;
	}
}
