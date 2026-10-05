using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200111D RID: 4381
	[Token(Token = "0x200111D")]
	public class OpenServerItemData
	{
		// Token: 0x06006EDE RID: 28382 RVA: 0x00032340 File Offset: 0x00030540
		[Token(Token = "0x6006EDE")]
		[Address(RVA = "0x1FF8AF0", Offset = "0x1FF76F0", VA = "0x181FF8AF0")]
		public bool ShouldSerializename()
		{
			return default(bool);
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EDF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OpenServerItemData()
		{
		}

		// Token: 0x04005DE7 RID: 24039
		[Token(Token = "0x4005DE7")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04005DE8 RID: 24040
		[Token(Token = "0x4005DE8")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType itemType;

		// Token: 0x04005DE9 RID: 24041
		[Token(Token = "0x4005DE9")]
		[FieldOffset(Offset = "0x1C")]
		public int count;

		// Token: 0x04005DEA RID: 24042
		[Token(Token = "0x4005DEA")]
		[FieldOffset(Offset = "0x20")]
		public string name;
	}
}
