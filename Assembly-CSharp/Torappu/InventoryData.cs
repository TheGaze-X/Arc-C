using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010AA RID: 4266
	[Token(Token = "0x20010AA")]
	[Serializable]
	public class InventoryData
	{
		// Token: 0x06006E33 RID: 28211 RVA: 0x00031FC8 File Offset: 0x000301C8
		[Token(Token = "0x6006E33")]
		[Address(RVA = "0x2105EB0", Offset = "0x2104AB0", VA = "0x182105EB0", Slot = "4")]
		public virtual bool ShouldSerializefavorCharacters()
		{
			return default(bool);
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E34")]
		[Address(RVA = "0x2105EF0", Offset = "0x2104AF0", VA = "0x182105EF0")]
		public InventoryData()
		{
		}

		// Token: 0x04005B5C RID: 23388
		[Token(Token = "0x4005B5C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ItemData> items;

		// Token: 0x04005B5D RID: 23389
		[Token(Token = "0x4005B5D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ExpItemFeature> expItems;

		// Token: 0x04005B5E RID: 23390
		[Token(Token = "0x4005B5E")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, Dictionary<string, string>> potentialItems;

		// Token: 0x04005B5F RID: 23391
		[Token(Token = "0x4005B5F")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ApSupplyFeature> apSupplies;

		// Token: 0x04005B60 RID: 23392
		[Token(Token = "0x4005B60")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, CharVoucherItemFeature> charVoucherItems;

		// Token: 0x04005B61 RID: 23393
		[Token(Token = "0x4005B61")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, int> uniqueInfo;

		// Token: 0x04005B62 RID: 23394
		[Token(Token = "0x4005B62")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, int> itemTimeLimit;

		// Token: 0x04005B63 RID: 23395
		[Token(Token = "0x4005B63")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, UniCollectionInfo> uniCollectionInfo;

		// Token: 0x04005B64 RID: 23396
		[Token(Token = "0x4005B64")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, ItemPackInfo> itemPackInfos;

		// Token: 0x04005B65 RID: 23397
		[Token(Token = "0x4005B65")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, FullPotentialCharacterInfo> fullPotentialCharacters;

		// Token: 0x04005B66 RID: 23398
		[Token(Token = "0x4005B66")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, ActivityPotentialCharacterInfo> activityPotentialCharacters;

		// Token: 0x04005B67 RID: 23399
		[Token(Token = "0x4005B67")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, FavorCharacterInfo> favorCharacters;

		// Token: 0x04005B68 RID: 23400
		[Token(Token = "0x4005B68")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, string> itemShopNameDict;
	}
}
