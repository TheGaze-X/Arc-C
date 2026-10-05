using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003598 RID: 13720
	[Token(Token = "0x2003598")]
	public struct DetailClampRuleForLevel : ISingleInfoClampRule, IHotfixable
	{
		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x06015D1A RID: 89370 RVA: 0x0008DFA8 File Offset: 0x0008C1A8
		// (set) Token: 0x06015D1B RID: 89371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700341B")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015D1A")]
			[Address(RVA = "0xE71480", Offset = "0xE70080", VA = "0x180E71480")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015D1B")]
			[Address(RVA = "0xE715F0", Offset = "0xE701F0", VA = "0x180E715F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x06015D1C RID: 89372 RVA: 0x0008DFC0 File Offset: 0x0008C1C0
		// (set) Token: 0x06015D1D RID: 89373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700341C")]
		public int level
		{
			[Token(Token = "0x6015D1C")]
			[Address(RVA = "0xE71580", Offset = "0xE70180", VA = "0x180E71580")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6015D1D")]
			[Address(RVA = "0xE71710", Offset = "0xE70310", VA = "0x180E71710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x06015D1E RID: 89374 RVA: 0x0008DFD8 File Offset: 0x0008C1D8
		// (set) Token: 0x06015D1F RID: 89375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700341D")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6015D1E")]
			[Address(RVA = "0xE71510", Offset = "0xE70110", VA = "0x180E71510")]
			[CompilerGenerated]
			readonly get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x6015D1F")]
			[Address(RVA = "0xE71690", Offset = "0xE70290", VA = "0x180E71690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D20 RID: 89376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D20")]
		[Address(RVA = "0xE71330", Offset = "0xE6FF30", VA = "0x180E71330")]
		public DetailClampRuleForLevel(CharQuery charQuery, int level, EvolvePhase evolvePhase)
		{
		}

		// Token: 0x06015D21 RID: 89377 RVA: 0x0008DFF0 File Offset: 0x0008C1F0
		[Token(Token = "0x6015D21")]
		[Address(RVA = "0xE71010", Offset = "0xE6FC10", VA = "0x180E71010")]
		public BasicCharInfoModel.DefaultDetailInfoPatchBuilder DoClamp(BasicCharInfoModel.DefaultDetailInfoPatchBuilder infoPatchBuilder)
		{
			return default(BasicCharInfoModel.DefaultDetailInfoPatchBuilder);
		}

		// Token: 0x0401A3F3 RID: 107507
		[Token(Token = "0x401A3F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A3F4 RID: 107508
		[Token(Token = "0x401A3F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A3F5 RID: 107509
		[Token(Token = "0x401A3F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0401A3F6 RID: 107510
		[Token(Token = "0x401A3F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0401A3F7 RID: 107511
		[Token(Token = "0x401A3F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401A3F8 RID: 107512
		[Token(Token = "0x401A3F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x0401A3F9 RID: 107513
		[Token(Token = "0x401A3F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A3FA RID: 107514
		[Token(Token = "0x401A3FA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
