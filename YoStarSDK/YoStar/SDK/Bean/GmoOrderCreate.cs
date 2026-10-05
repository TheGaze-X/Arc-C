using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Bean
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	public class GmoOrderCreate
	{
		// Token: 0x06000FBC RID: 4028 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GmoOrderCreate()
		{
		}

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x10")]
		public GmoOrderCreate.ORDER Order;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x18")]
		public GmoOrderCreate.GMO Gmo;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x20")]
		public GmoOrderCreate.PCPlatform PC;

		// Token: 0x020002A3 RID: 675
		[Token(Token = "0x20002A3")]
		[Serializable]
		public class GMO
		{
			// Token: 0x06000FBD RID: 4029 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000FBD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GMO()
			{
			}

			// Token: 0x04000CFE RID: 3326
			[Token(Token = "0x4000CFE")]
			[FieldOffset(Offset = "0x10")]
			public string RedirectURL;
		}

		// Token: 0x020002A4 RID: 676
		[Token(Token = "0x20002A4")]
		[Serializable]
		public class PCPlatform
		{
			// Token: 0x06000FBE RID: 4030 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000FBE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PCPlatform()
			{
			}

			// Token: 0x04000CFF RID: 3327
			[Token(Token = "0x4000CFF")]
			[FieldOffset(Offset = "0x10")]
			public string RedirectURL;
		}

		// Token: 0x020002A5 RID: 677
		[Token(Token = "0x20002A5")]
		[Serializable]
		public class ORDER
		{
			// Token: 0x06000FBF RID: 4031 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000FBF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ORDER()
			{
			}

			// Token: 0x04000D00 RID: 3328
			[Token(Token = "0x4000D00")]
			[FieldOffset(Offset = "0x10")]
			public int CreatedAt;

			// Token: 0x04000D01 RID: 3329
			[Token(Token = "0x4000D01")]
			[FieldOffset(Offset = "0x18")]
			public string GameExtraData;

			// Token: 0x04000D02 RID: 3330
			[Token(Token = "0x4000D02")]
			[FieldOffset(Offset = "0x20")]
			public string ID;

			// Token: 0x04000D03 RID: 3331
			[Token(Token = "0x4000D03")]
			[FieldOffset(Offset = "0x28")]
			public string StoreName;

			// Token: 0x04000D04 RID: 3332
			[Token(Token = "0x4000D04")]
			[FieldOffset(Offset = "0x30")]
			public string StoreProductID;
		}
	}
}
