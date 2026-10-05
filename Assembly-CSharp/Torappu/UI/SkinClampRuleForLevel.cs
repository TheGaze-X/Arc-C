using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035AB RID: 13739
	[Token(Token = "0x20035AB")]
	public struct SkinClampRuleForLevel : ISingleInfoClampRule, IHotfixable
	{
		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x06015D96 RID: 89494 RVA: 0x0008E5C0 File Offset: 0x0008C7C0
		// (set) Token: 0x06015D97 RID: 89495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700343F")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015D96")]
			[Address(RVA = "0xE741E0", Offset = "0xE72DE0", VA = "0x180E741E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(CharQuery);
			}
			[Token(Token = "0x6015D97")]
			[Address(RVA = "0xE742E0", Offset = "0xE72EE0", VA = "0x180E742E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x06015D98 RID: 89496 RVA: 0x0008E5D8 File Offset: 0x0008C7D8
		// (set) Token: 0x06015D99 RID: 89497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003440")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6015D98")]
			[Address(RVA = "0xE74270", Offset = "0xE72E70", VA = "0x180E74270")]
			[CompilerGenerated]
			readonly get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x6015D99")]
			[Address(RVA = "0xE74380", Offset = "0xE72F80", VA = "0x180E74380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D9A RID: 89498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D9A")]
		[Address(RVA = "0xE740B0", Offset = "0xE72CB0", VA = "0x180E740B0")]
		public SkinClampRuleForLevel(CharQuery charQuery, EvolvePhase evolvePhase)
		{
		}

		// Token: 0x06015D9B RID: 89499 RVA: 0x0008E5F0 File Offset: 0x0008C7F0
		[Token(Token = "0x6015D9B")]
		[Address(RVA = "0xE73C10", Offset = "0xE72810", VA = "0x180E73C10")]
		public BasicCharInfoModel.DefaultSkinInfoPatchBuilder DoClamp(BasicCharInfoModel.DefaultSkinInfoPatchBuilder skinInfoPatchBuilder)
		{
			return default(BasicCharInfoModel.DefaultSkinInfoPatchBuilder);
		}

		// Token: 0x06015D9C RID: 89500 RVA: 0x0008E608 File Offset: 0x0008C808
		[Token(Token = "0x6015D9C")]
		[Address(RVA = "0xE73F40", Offset = "0xE72B40", VA = "0x180E73F40")]
		private BasicCharInfoModel.DefaultSkinInfoPatchBuilder _ClampSkin(BasicCharInfoModel.DefaultSkinInfoPatchBuilder skinInfoPatchBuilder)
		{
			return default(BasicCharInfoModel.DefaultSkinInfoPatchBuilder);
		}

		// Token: 0x0401A491 RID: 107665
		[Token(Token = "0x401A491")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A492 RID: 107666
		[Token(Token = "0x401A492")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charQuery;

		// Token: 0x0401A493 RID: 107667
		[Token(Token = "0x401A493")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401A494 RID: 107668
		[Token(Token = "0x401A494")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x0401A495 RID: 107669
		[Token(Token = "0x401A495")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A496 RID: 107670
		[Token(Token = "0x401A496")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoClamp;

		// Token: 0x0401A497 RID: 107671
		[Token(Token = "0x401A497")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClampSkin;
	}
}
