using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002483 RID: 9347
	[Token(Token = "0x2002483")]
	[RequireComponent(typeof(Ability))]
	public class DeckTalentToModifyCardData : DeckTalent
	{
		// Token: 0x0600F083 RID: 61571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F083")]
		[Address(RVA = "0x672B00", Offset = "0x671700", VA = "0x180672B00", Slot = "33")]
		public override DeckModifier CreateDeckModifier(Deck.Card sourceCard)
		{
			return null;
		}

		// Token: 0x0600F084 RID: 61572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F084")]
		[Address(RVA = "0x672D20", Offset = "0x671920", VA = "0x180672D20")]
		public DeckTalentToModifyCardData()
		{
		}

		// Token: 0x040109F5 RID: 68085
		[Token(Token = "0x40109F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _overrideAvatarIdViaLevel;

		// Token: 0x040109F6 RID: 68086
		[Token(Token = "0x40109F6")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _overrideAvatarIdViaSkillLevel;

		// Token: 0x040109F7 RID: 68087
		[Token(Token = "0x40109F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateDeckModifier;

		// Token: 0x040109F8 RID: 68088
		[Token(Token = "0x40109F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002484 RID: 9348
		[Token(Token = "0x2002484")]
		private class DeckModifierModifyCardData : DeckModifier
		{
			// Token: 0x0600F085 RID: 61573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F085")]
			[Address(RVA = "0x671820", Offset = "0x670420", VA = "0x180671820")]
			public DeckModifierModifyCardData(Deck.Card sourceCard)
			{
			}
		}
	}
}
