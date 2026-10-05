using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A3 RID: 13731
	[Token(Token = "0x20035A3")]
	public struct IdentityClampRuleForLevel : ISingleInfoClampRule, IHotfixable
	{
		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x06015D62 RID: 89442 RVA: 0x0008E320 File Offset: 0x0008C520
		// (set) Token: 0x06015D63 RID: 89443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003431")]
		public int level
		{
			[Token(Token = "0x6015D62")]
			[Address(RVA = "0xE72B30", Offset = "0xE71730", VA = "0x180E72B30")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6015D63")]
			[Address(RVA = "0xE72C00", Offset = "0xE71800", VA = "0x180E72C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x06015D64 RID: 89444 RVA: 0x0008E338 File Offset: 0x0008C538
		// (set) Token: 0x06015D65 RID: 89445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003432")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6015D64")]
			[Address(RVA = "0xE72AD0", Offset = "0xE716D0", VA = "0x180E72AD0")]
			[CompilerGenerated]
			readonly get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x6015D65")]
			[Address(RVA = "0xE72B90", Offset = "0xE71790", VA = "0x180E72B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D66 RID: 89446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D66")]
		[Address(RVA = "0xE729D0", Offset = "0xE715D0", VA = "0x180E729D0")]
		public IdentityClampRuleForLevel(int level, EvolvePhase evolvePhase)
		{
		}

		// Token: 0x06015D67 RID: 89447 RVA: 0x0008E350 File Offset: 0x0008C550
		[Token(Token = "0x6015D67")]
		[Address(RVA = "0xE72630", Offset = "0xE71230", VA = "0x180E72630")]
		public BasicCharInfoModel.DefaultIdentityInfoPatchBuilder DoClamp(BasicCharInfoModel.DefaultIdentityInfoPatchBuilder infoPatchBuilder)
		{
			return default(BasicCharInfoModel.DefaultIdentityInfoPatchBuilder);
		}

		// Token: 0x0401A44D RID: 107597
		[Token(Token = "0x401A44D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0401A44E RID: 107598
		[Token(Token = "0x401A44E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0401A44F RID: 107599
		[Token(Token = "0x401A44F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401A450 RID: 107600
		[Token(Token = "0x401A450")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x0401A451 RID: 107601
		[Token(Token = "0x401A451")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A452 RID: 107602
		[Token(Token = "0x401A452")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoClamp;
	}
}
