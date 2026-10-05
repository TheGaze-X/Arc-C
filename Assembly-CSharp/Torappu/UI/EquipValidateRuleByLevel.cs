using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200359C RID: 13724
	[Token(Token = "0x200359C")]
	public struct EquipValidateRuleByLevel : ISingleInfoValidateRule, IHotfixable
	{
		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x06015D41 RID: 89409 RVA: 0x0008E1B8 File Offset: 0x0008C3B8
		// (set) Token: 0x06015D42 RID: 89410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003427")]
		public int level
		{
			[Token(Token = "0x6015D41")]
			[Address(RVA = "0xE71AE0", Offset = "0xE706E0", VA = "0x180E71AE0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6015D42")]
			[Address(RVA = "0xE71BB0", Offset = "0xE707B0", VA = "0x180E71BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x06015D43 RID: 89411 RVA: 0x0008E1D0 File Offset: 0x0008C3D0
		// (set) Token: 0x06015D44 RID: 89412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003428")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6015D43")]
			[Address(RVA = "0xE71A80", Offset = "0xE70680", VA = "0x180E71A80")]
			[CompilerGenerated]
			readonly get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x6015D44")]
			[Address(RVA = "0xE71B40", Offset = "0xE70740", VA = "0x180E71B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D45 RID: 89413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D45")]
		[Address(RVA = "0xE71980", Offset = "0xE70580", VA = "0x180E71980")]
		public EquipValidateRuleByLevel(int level, EvolvePhase evolvePhase)
		{
		}

		// Token: 0x06015D46 RID: 89414 RVA: 0x0008E1E8 File Offset: 0x0008C3E8
		[Token(Token = "0x6015D46")]
		[Address(RVA = "0xE71790", Offset = "0xE70390", VA = "0x180E71790")]
		public bool CheckIfValidate(UniEquipData equipData)
		{
			return default(bool);
		}

		// Token: 0x0401A424 RID: 107556
		[Token(Token = "0x401A424")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0401A425 RID: 107557
		[Token(Token = "0x401A425")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0401A426 RID: 107558
		[Token(Token = "0x401A426")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401A427 RID: 107559
		[Token(Token = "0x401A427")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x0401A428 RID: 107560
		[Token(Token = "0x401A428")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A429 RID: 107561
		[Token(Token = "0x401A429")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfValidate;
	}
}
