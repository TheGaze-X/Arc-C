using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x020005A8 RID: 1448
	[Token(Token = "0x20005A8")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class Debugger
	{
		// Token: 0x06002B45 RID: 11077
		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		public static extern bool IsLogging();

		// Token: 0x06002B46 RID: 11078
		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x4AEF1B0", Offset = "0x4AEDDB0", VA = "0x184AEF1B0")]
		[MethodImpl(4096)]
		private static extern void Log_icall(int level, ref string category, ref string message);

		// Token: 0x06002B47 RID: 11079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x4C5D270", Offset = "0x4C5BE70", VA = "0x184C5D270")]
		public static void Log(int level, string category, string message)
		{
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B48")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void NotifyOfCrossThreadDependency()
		{
		}

		// Token: 0x04001935 RID: 6453
		[Token(Token = "0x4001935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string DefaultCategory;
	}
}
