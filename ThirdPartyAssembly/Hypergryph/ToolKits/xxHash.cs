using System;
using Il2CppDummyDll;

namespace Hypergryph.ToolKits
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	public class xxHash
	{
		// Token: 0x06000483 RID: 1155 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x54587F0", Offset = "0x54573F0", VA = "0x1854587F0")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return 0U;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public xxHash()
		{
		}

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		private const uint PRIME32_1 = 2654435761U;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		private const uint PRIME32_2 = 2246822519U;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		private const uint PRIME32_3 = 3266489917U;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		private const uint PRIME32_4 = 668265263U;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		private const uint PRIME32_5 = 374761393U;
	}
}
