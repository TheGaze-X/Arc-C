using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000740 RID: 1856
	[Token(Token = "0x2000740")]
	public class SetCardShowMedalRequest
	{
		// Token: 0x060063AA RID: 25514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063AA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetCardShowMedalRequest()
		{
		}

		// Token: 0x04002FB1 RID: 12209
		[Token(Token = "0x4002FB1")]
		[FieldOffset(Offset = "0x10")]
		[JsonConverter(typeof(StringEnumConverter))]
		public NameCardMedalType type;

		// Token: 0x04002FB2 RID: 12210
		[Token(Token = "0x4002FB2")]
		[FieldOffset(Offset = "0x18")]
		public string customIndex;

		// Token: 0x04002FB3 RID: 12211
		[Token(Token = "0x4002FB3")]
		[FieldOffset(Offset = "0x20")]
		public string templateGroup;
	}
}
