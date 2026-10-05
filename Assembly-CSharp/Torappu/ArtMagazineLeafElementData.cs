using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001022 RID: 4130
	[Token(Token = "0x2001022")]
	public class ArtMagazineLeafElementData
	{
		// Token: 0x06006D74 RID: 28020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D74")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineLeafElementData()
		{
		}

		// Token: 0x040057B1 RID: 22449
		[Token(Token = "0x40057B1")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040057B2 RID: 22450
		[Token(Token = "0x40057B2")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType type;

		// Token: 0x040057B3 RID: 22451
		[Token(Token = "0x40057B3")]
		[FieldOffset(Offset = "0x1C")]
		public int sub;

		// Token: 0x040057B4 RID: 22452
		[Token(Token = "0x40057B4")]
		[FieldOffset(Offset = "0x20")]
		public List<float> pos;

		// Token: 0x040057B5 RID: 22453
		[Token(Token = "0x40057B5")]
		[FieldOffset(Offset = "0x28")]
		public float scale;
	}
}
