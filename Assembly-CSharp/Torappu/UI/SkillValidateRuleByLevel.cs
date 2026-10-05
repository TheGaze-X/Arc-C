using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035A9 RID: 13737
	[Token(Token = "0x20035A9")]
	public struct SkillValidateRuleByLevel : ISingleInfoValidateRule, IHotfixable
	{
		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x06015D8C RID: 89484 RVA: 0x0008E530 File Offset: 0x0008C730
		// (set) Token: 0x06015D8D RID: 89485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700343C")]
		public int level
		{
			[Token(Token = "0x6015D8C")]
			[Address(RVA = "0xE73AD0", Offset = "0xE726D0", VA = "0x180E73AD0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6015D8D")]
			[Address(RVA = "0xE73BA0", Offset = "0xE727A0", VA = "0x180E73BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x06015D8E RID: 89486 RVA: 0x0008E548 File Offset: 0x0008C748
		// (set) Token: 0x06015D8F RID: 89487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700343D")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6015D8E")]
			[Address(RVA = "0xE73A70", Offset = "0xE72670", VA = "0x180E73A70")]
			[CompilerGenerated]
			readonly get
			{
				return EvolvePhase.PHASE_0;
			}
			[Token(Token = "0x6015D8F")]
			[Address(RVA = "0xE73B30", Offset = "0xE72730", VA = "0x180E73B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015D90 RID: 89488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015D90")]
		[Address(RVA = "0xE73970", Offset = "0xE72570", VA = "0x180E73970")]
		public SkillValidateRuleByLevel(int level, EvolvePhase evolvePhase)
		{
		}

		// Token: 0x06015D91 RID: 89489 RVA: 0x0008E560 File Offset: 0x0008C760
		[Token(Token = "0x6015D91")]
		[Address(RVA = "0xE73890", Offset = "0xE72490", VA = "0x180E73890")]
		public bool CheckIfValidate(CharacterData.MainSkill mainSkill, int skillLvlWithSpec)
		{
			return default(bool);
		}

		// Token: 0x0401A484 RID: 107652
		[Token(Token = "0x401A484")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0401A485 RID: 107653
		[Token(Token = "0x401A485")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0401A486 RID: 107654
		[Token(Token = "0x401A486")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401A487 RID: 107655
		[Token(Token = "0x401A487")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_evolvePhase;

		// Token: 0x0401A488 RID: 107656
		[Token(Token = "0x401A488")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401A489 RID: 107657
		[Token(Token = "0x401A489")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfValidate;
	}
}
