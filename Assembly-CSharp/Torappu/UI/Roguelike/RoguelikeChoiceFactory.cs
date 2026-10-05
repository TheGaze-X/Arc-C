using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051A7 RID: 20903
	[Token(Token = "0x20051A7")]
	[Hotfix(HotfixFlag.Stateless)]
	public class RoguelikeChoiceFactory
	{
		// Token: 0x0601EE0A RID: 126474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE0A")]
		[Address(RVA = "0x18A0BD0", Offset = "0x189F7D0", VA = "0x1818A0BD0")]
		public IRoguelikeGameChoice CreateChoice(string topicId, RoguelikeGameChoiceData data, bool selectable, PlayerRoguelikePendingEvent.ChoiceAddition additionData, RoguelikeChoiceHintFactory hintFactory)
		{
			return null;
		}

		// Token: 0x0601EE0B RID: 126475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE0B")]
		[Address(RVA = "0x18A0C90", Offset = "0x189F890", VA = "0x1818A0C90")]
		private IRoguelikeGameChoice _CreateBasicChoice(string topicId, RoguelikeGameChoiceData data, bool selectable, PlayerRoguelikePendingEvent.ChoiceAddition additionData, RoguelikeChoiceHintFactory hintFactory)
		{
			return null;
		}

		// Token: 0x0601EE0C RID: 126476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE0C")]
		[Address(RVA = "0x18A11C0", Offset = "0x189FDC0", VA = "0x1818A11C0")]
		private RoguelikeChoiceDisplayData _DealWithAdditionalPlayerData(PlayerRoguelikePendingEvent.ChoiceAddition additionData)
		{
			return null;
		}

		// Token: 0x0601EE0D RID: 126477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE0D")]
		[Address(RVA = "0x18A1340", Offset = "0x189FF40", VA = "0x1818A1340")]
		public RoguelikeChoiceFactory()
		{
		}

		// Token: 0x040296CF RID: 169679
		[Token(Token = "0x40296CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateChoice;

		// Token: 0x040296D0 RID: 169680
		[Token(Token = "0x40296D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateBasicChoice;

		// Token: 0x040296D1 RID: 169681
		[Token(Token = "0x40296D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DealWithAdditionalPlayerData;

		// Token: 0x040296D2 RID: 169682
		[Token(Token = "0x40296D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
