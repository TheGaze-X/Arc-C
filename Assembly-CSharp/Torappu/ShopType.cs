using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001305 RID: 4869
	[Token(Token = "0x2001305")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShopType
	{
		// Token: 0x04006BD8 RID: 27608
		[Token(Token = "0x4006BD8")]
		RECOMMENDSHOP,
		// Token: 0x04006BD9 RID: 27609
		[Token(Token = "0x4006BD9")]
		CASHSHOP,
		// Token: 0x04006BDA RID: 27610
		[Token(Token = "0x4006BDA")]
		GIFTPACKAGE,
		// Token: 0x04006BDB RID: 27611
		[Token(Token = "0x4006BDB")]
		SKINSHOP,
		// Token: 0x04006BDC RID: 27612
		[Token(Token = "0x4006BDC")]
		QCSHOP,
		// Token: 0x04006BDD RID: 27613
		[Token(Token = "0x4006BDD")]
		SOCAILSHOP,
		// Token: 0x04006BDE RID: 27614
		[Token(Token = "0x4006BDE")]
		FURNSHOP,
		// Token: 0x04006BDF RID: 27615
		[Token(Token = "0x4006BDF")]
		NONE
	}
}
