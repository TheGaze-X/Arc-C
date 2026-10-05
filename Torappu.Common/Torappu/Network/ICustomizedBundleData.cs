using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.Network
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	public interface ICustomizedBundleData
	{
		// Token: 0x06000C4A RID: 3146
		[Token(Token = "0x6000C4A")]
		string Serialize(JsonSerializerSettings setting);

		// Token: 0x06000C4B RID: 3147
		[Token(Token = "0x6000C4B")]
		void Deserialize(string data, JsonSerializerSettings setting);
	}
}
