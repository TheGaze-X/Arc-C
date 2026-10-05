using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02001315 RID: 4885
	[Token(Token = "0x2001315")]
	public class ShopRecommendData
	{
		// Token: 0x06007292 RID: 29330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007292")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopRecommendData()
		{
		}

		// Token: 0x04006C43 RID: 27715
		[Token(Token = "0x4006C43")]
		[FieldOffset(Offset = "0x10")]
		public string imgId;

		// Token: 0x04006C44 RID: 27716
		[Token(Token = "0x4006C44")]
		[FieldOffset(Offset = "0x18")]
		public int slotIndex;

		// Token: 0x04006C45 RID: 27717
		[Token(Token = "0x4006C45")]
		[FieldOffset(Offset = "0x1C")]
		public ShopRouteTarget cmd;

		// Token: 0x04006C46 RID: 27718
		[Token(Token = "0x4006C46")]
		[FieldOffset(Offset = "0x20")]
		public string param1;

		// Token: 0x04006C47 RID: 27719
		[Token(Token = "0x4006C47")]
		[FieldOffset(Offset = "0x28")]
		public string param2;

		// Token: 0x04006C48 RID: 27720
		[Token(Token = "0x4006C48")]
		[FieldOffset(Offset = "0x30")]
		public string skinId;

		// Token: 0x04006C49 RID: 27721
		[Token(Token = "0x4006C49")]
		[FieldOffset(Offset = "0x38")]
		[JsonIgnore]
		public bool islocked;
	}
}
