using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D31 RID: 27953
	[Token(Token = "0x2006D31")]
	public class ActivityShopData
	{
		// Token: 0x06027D9C RID: 163228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D9C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityShopData()
		{
		}

		// Token: 0x040387C7 RID: 231367
		[Token(Token = "0x40387C7")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x040387C8 RID: 231368
		[Token(Token = "0x40387C8")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x040387C9 RID: 231369
		[Token(Token = "0x40387C9")]
		[FieldOffset(Offset = "0x1C")]
		public int price;

		// Token: 0x040387CA RID: 231370
		[Token(Token = "0x40387CA")]
		[FieldOffset(Offset = "0x20")]
		public int availCount;

		// Token: 0x040387CB RID: 231371
		[Token(Token = "0x40387CB")]
		[FieldOffset(Offset = "0x28")]
		public string overrideName;

		// Token: 0x040387CC RID: 231372
		[Token(Token = "0x40387CC")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle item;
	}
}
