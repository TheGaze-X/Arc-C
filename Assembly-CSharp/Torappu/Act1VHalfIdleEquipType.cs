using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000CA1 RID: 3233
	[Token(Token = "0x2000CA1")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act1VHalfIdleEquipType
	{
		// Token: 0x04004211 RID: 16913
		[Token(Token = "0x4004211")]
		WEAPON,
		// Token: 0x04004212 RID: 16914
		[Token(Token = "0x4004212")]
		ARMOR,
		// Token: 0x04004213 RID: 16915
		[Token(Token = "0x4004213")]
		ACCESSORY,
		// Token: 0x04004214 RID: 16916
		[Token(Token = "0x4004214")]
		NUM
	}
}
