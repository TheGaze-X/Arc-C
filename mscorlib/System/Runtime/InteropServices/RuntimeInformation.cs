using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000475 RID: 1141
	[Token(Token = "0x2000475")]
	public static class RuntimeInformation
	{
		// Token: 0x06002245 RID: 8773
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x4BC4430", Offset = "0x4BC3030", VA = "0x184BC4430")]
		[MethodImpl(4096)]
		private static extern string GetRuntimeArchitecture();

		// Token: 0x06002246 RID: 8774
		[Token(Token = "0x6002246")]
		[Address(RVA = "0x4BC4420", Offset = "0x4BC3020", VA = "0x184BC4420")]
		[MethodImpl(4096)]
		private static extern string GetOSName();

		// Token: 0x06002247 RID: 8775 RVA: 0x00013C08 File Offset: 0x00011E08
		[Token(Token = "0x6002247")]
		[Address(RVA = "0x4BC4440", Offset = "0x4BC3040", VA = "0x184BC4440")]
		public static bool IsOSPlatform(OSPlatform osPlatform)
		{
			return default(bool);
		}

		// Token: 0x040013B0 RID: 5040
		[Token(Token = "0x40013B0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Architecture _osArchitecture;

		// Token: 0x040013B1 RID: 5041
		[Token(Token = "0x40013B1")]
		[FieldOffset(Offset = "0x4")]
		private static readonly Architecture _processArchitecture;

		// Token: 0x040013B2 RID: 5042
		[Token(Token = "0x40013B2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly OSPlatform _osPlatform;
	}
}
