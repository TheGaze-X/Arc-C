using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	[Preserve]
	public interface IContractResolver
	{
		// Token: 0x06000539 RID: 1337
		[Token(Token = "0x6000539")]
		JsonContract ResolveContract(Type type);
	}
}
