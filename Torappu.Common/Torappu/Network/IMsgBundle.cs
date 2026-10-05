using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Network
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x200020E")]
	public interface IMsgBundle
	{
		// Token: 0x06000C44 RID: 3140
		[Token(Token = "0x6000C44")]
		string Serialize(JsonSerializerSettings setting);

		// Token: 0x06000C45 RID: 3141
		[Token(Token = "0x6000C45")]
		void Deserialize(string data, JsonSerializerSettings setting);
	}
}
