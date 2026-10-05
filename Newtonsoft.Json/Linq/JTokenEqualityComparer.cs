using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[Preserve]
	public class JTokenEqualityComparer : IEqualityComparer<JToken>
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x4DC3620", Offset = "0x4DC2220", VA = "0x184DC3620", Slot = "4")]
		public bool Equals(JToken x, JToken y)
		{
			return default(bool);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x4DC36B0", Offset = "0x4DC22B0", VA = "0x184DC36B0", Slot = "5")]
		public int GetHashCode(JToken obj)
		{
			return 0;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public JTokenEqualityComparer()
		{
		}
	}
}
