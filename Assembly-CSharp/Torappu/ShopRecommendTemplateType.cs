using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200131B RID: 4891
	[Token(Token = "0x200131B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShopRecommendTemplateType
	{
		// Token: 0x04006C5C RID: 27740
		[Token(Token = "0x4006C5C")]
		DEFAULT,
		// Token: 0x04006C5D RID: 27741
		[Token(Token = "0x4006C5D")]
		NORSKIN,
		// Token: 0x04006C5E RID: 27742
		[Token(Token = "0x4006C5E")]
		RETURNSKIN,
		// Token: 0x04006C5F RID: 27743
		[Token(Token = "0x4006C5F")]
		NORFURN,
		// Token: 0x04006C60 RID: 27744
		[Token(Token = "0x4006C60")]
		NORGIFT
	}
}
