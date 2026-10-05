using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001173 RID: 4467
	[Token(Token = "0x2001173")]
	public class RoguelikeItemTable
	{
		// Token: 0x06006F61 RID: 28513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F61")]
		[Address(RVA = "0x2111F50", Offset = "0x2110B50", VA = "0x182111F50")]
		public RoguelikeItemTable()
		{
		}

		// Token: 0x04005FBA RID: 24506
		[Token(Token = "0x4005FBA")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeItemData> items;

		// Token: 0x04005FBB RID: 24507
		[Token(Token = "0x4005FBB")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeRecruitTicketFeature> recruitTickets;

		// Token: 0x04005FBC RID: 24508
		[Token(Token = "0x4005FBC")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, RoguelikeUpgradeTicketFeature> upgradeTickets;

		// Token: 0x04005FBD RID: 24509
		[Token(Token = "0x4005FBD")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, RoguelikeRelicFeature> relics;
	}
}
