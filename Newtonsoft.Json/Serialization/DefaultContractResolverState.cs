using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	[Preserve]
	internal class DefaultContractResolverState
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x4D9BEA0", Offset = "0x4D9AAA0", VA = "0x184D9BEA0")]
		public DefaultContractResolverState()
		{
		}

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<ResolverContractKey, JsonContract> ContractCache;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x18")]
		public PropertyNameTable NameTable;
	}
}
