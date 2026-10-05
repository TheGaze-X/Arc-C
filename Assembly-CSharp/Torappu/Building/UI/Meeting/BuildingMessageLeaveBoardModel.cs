using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D17 RID: 7447
	[Token(Token = "0x2001D17")]
	public class BuildingMessageLeaveBoardModel
	{
		// Token: 0x0600B7D8 RID: 47064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7D8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingMessageLeaveBoardModel()
		{
		}

		// Token: 0x0400B5B9 RID: 46521
		[Token(Token = "0x400B5B9")]
		[FieldOffset(Offset = "0x10")]
		public BuildingMessageLeavePage.MessageBoardType messageBoardType;

		// Token: 0x0400B5BA RID: 46522
		[Token(Token = "0x400B5BA")]
		[FieldOffset(Offset = "0x18")]
		public BuildingPayloadGetMessageBoardContentResponse playerBoardContentResponse;

		// Token: 0x0400B5BB RID: 46523
		[Token(Token = "0x400B5BB")]
		[FieldOffset(Offset = "0x20")]
		public BuildingPayloadGetOthersMessageBoardContentResponse visitorBoardContentResponse;
	}
}
