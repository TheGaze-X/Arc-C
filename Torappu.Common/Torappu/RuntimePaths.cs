using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	public static class RuntimePaths
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5526420", Offset = "0x5525020", VA = "0x185526420")]
		public static string PersistentDataPath()
		{
			return null;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x5526660", Offset = "0x5525260", VA = "0x185526660")]
		public static string StreamingAssetsPath()
		{
			return null;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x55264F0", Offset = "0x55250F0", VA = "0x1855264F0")]
		public static string PersistentRootPath()
		{
			return null;
		}

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x0")]
		private static string s_persistentDataPath;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x8")]
		private static string s_streamingAssetsPath;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x10")]
		private static string s_persistentRootPath;
	}
}
