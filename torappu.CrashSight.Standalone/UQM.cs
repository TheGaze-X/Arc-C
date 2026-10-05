using System;
using Il2CppDummyDll;

namespace GCloud.UQM
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class UQM
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x55AB0B0", Offset = "0x55A9CB0", VA = "0x1855AB0B0")]
		public static void Init()
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UQM()
		{
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		public const string LibName = "CrashSight64";

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		private static bool initialized;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x1")]
		public static bool isDebug;
	}
}
