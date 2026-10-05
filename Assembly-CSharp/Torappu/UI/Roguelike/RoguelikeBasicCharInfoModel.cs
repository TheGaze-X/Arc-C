using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005521 RID: 21793
	[Token(Token = "0x2005521")]
	public class RoguelikeBasicCharInfoModel : BasicCharInfoModel, IHotfixable
	{
		// Token: 0x060200C5 RID: 131269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200C5")]
		[Address(RVA = "0x1A167B0", Offset = "0x1A153B0", VA = "0x181A167B0")]
		public RoguelikeBasicCharInfoModel(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x0402B461 RID: 177249
		[Token(Token = "0x402B461")]
		[FieldOffset(Offset = "0xA8")]
		public int mainSkillLvl;

		// Token: 0x0402B462 RID: 177250
		[Token(Token = "0x402B462")]
		[FieldOffset(Offset = "0xAC")]
		public int defaultSkillIndex;

		// Token: 0x0402B463 RID: 177251
		[Token(Token = "0x402B463")]
		[FieldOffset(Offset = "0xB0")]
		public PlayerCharSkill[] skills;

		// Token: 0x0402B464 RID: 177252
		[Token(Token = "0x402B464")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
