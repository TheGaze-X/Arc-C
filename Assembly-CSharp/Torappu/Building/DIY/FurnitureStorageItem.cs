using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018C1 RID: 6337
	[Token(Token = "0x20018C1")]
	public struct FurnitureStorageItem
	{
		// Token: 0x06009FFF RID: 40959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FFF")]
		[Address(RVA = "0x21178B0", Offset = "0x21164B0", VA = "0x1821178B0")]
		public FurnitureStorageItem(string furnitureId, int totalCount)
		{
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x0003E688 File Offset: 0x0003C888
		[Token(Token = "0x600A000")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x04009660 RID: 38496
		[Token(Token = "0x4009660")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FurnitureStorageItem EMPTY;

		// Token: 0x04009661 RID: 38497
		[Token(Token = "0x4009661")]
		[FieldOffset(Offset = "0x0")]
		public string furnitureId;

		// Token: 0x04009662 RID: 38498
		[Token(Token = "0x4009662")]
		[FieldOffset(Offset = "0x8")]
		public int totalCount;
	}
}
