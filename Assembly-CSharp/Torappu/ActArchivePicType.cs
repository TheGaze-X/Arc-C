using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013A5 RID: 5029
	[Token(Token = "0x20013A5")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActArchivePicType
	{
		// Token: 0x04006FB1 RID: 28593
		[Token(Token = "0x4006FB1")]
		IMAGE,
		// Token: 0x04006FB2 RID: 28594
		[Token(Token = "0x4006FB2")]
		BACKGROUND,
		// Token: 0x04006FB3 RID: 28595
		[Token(Token = "0x4006FB3")]
		ENDING_IMAGE,
		// Token: 0x04006FB4 RID: 28596
		[Token(Token = "0x4006FB4")]
		ROGUE_IMAGE
	}
}
