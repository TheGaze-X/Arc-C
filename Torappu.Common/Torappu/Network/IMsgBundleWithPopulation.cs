using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Torappu.Network
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	public interface IMsgBundleWithPopulation
	{
		// Token: 0x06000C46 RID: 3142
		[Token(Token = "0x6000C46")]
		string Serialize(JObject population, JsonSerializerSettings setting);
	}
}
