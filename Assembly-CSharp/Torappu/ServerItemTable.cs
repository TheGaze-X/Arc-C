using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010AB RID: 4267
	[Token(Token = "0x20010AB")]
	[Serializable]
	public class ServerItemTable
	{
		// Token: 0x06006E35 RID: 28213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E35")]
		[Address(RVA = "0x2114FC0", Offset = "0x2113BC0", VA = "0x182114FC0")]
		public ServerItemTable()
		{
		}

		// Token: 0x04005B69 RID: 23401
		[Token(Token = "0x4005B69")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ItemData> items;

		// Token: 0x04005B6A RID: 23402
		[Token(Token = "0x4005B6A")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ExpItemFeature> expItems;

		// Token: 0x04005B6B RID: 23403
		[Token(Token = "0x4005B6B")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, Dictionary<string, string>> potentialItems;

		// Token: 0x04005B6C RID: 23404
		[Token(Token = "0x4005B6C")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ApSupplyFeature> apSupplies;

		// Token: 0x04005B6D RID: 23405
		[Token(Token = "0x4005B6D")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, int> uniqueInfo;

		// Token: 0x04005B6E RID: 23406
		[Token(Token = "0x4005B6E")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, int> itemTimeLimit;

		// Token: 0x04005B6F RID: 23407
		[Token(Token = "0x4005B6F")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, UniCollectionInfo> uniCollectionInfo;

		// Token: 0x04005B70 RID: 23408
		[Token(Token = "0x4005B70")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, ItemPackInfo> itemPackInfos;

		// Token: 0x04005B71 RID: 23409
		[Token(Token = "0x4005B71")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, FullPotentialCharacterInfo> fullPotentialCharacters;

		// Token: 0x04005B72 RID: 23410
		[Token(Token = "0x4005B72")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, ActivityPotentialCharacterInfo> activityPotentialCharacters;

		// Token: 0x04005B73 RID: 23411
		[Token(Token = "0x4005B73")]
		[FieldOffset(Offset = "0x60")]
		public ServerItemReminderInfo reminderInfo;

		// Token: 0x04005B74 RID: 23412
		[Token(Token = "0x4005B74")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, FavorCharacterInfo> favorCharacters;
	}
}
