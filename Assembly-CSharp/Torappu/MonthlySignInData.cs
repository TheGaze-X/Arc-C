using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F8A RID: 3978
	[Token(Token = "0x2000F8A")]
	public class MonthlySignInData
	{
		// Token: 0x06006CCC RID: 27852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MonthlySignInData()
		{
		}

		// Token: 0x04005482 RID: 21634
		[Token(Token = "0x4005482")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04005483 RID: 21635
		[Token(Token = "0x4005483")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType itemType;

		// Token: 0x04005484 RID: 21636
		[Token(Token = "0x4005484")]
		[FieldOffset(Offset = "0x1C")]
		public int count;
	}
}
