using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001281 RID: 4737
	[Token(Token = "0x2001281")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2RareAnimalType
	{
		// Token: 0x0400687E RID: 26750
		[Token(Token = "0x400687E")]
		RARE_DEAR,
		// Token: 0x0400687F RID: 26751
		[Token(Token = "0x400687F")]
		RARE_TURTLE,
		// Token: 0x04006880 RID: 26752
		[Token(Token = "0x4006880")]
		MESSENGER,
		// Token: 0x04006881 RID: 26753
		[Token(Token = "0x4006881")]
		PREY
	}
}
