using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	internal static class RuntimeMarshal
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4AB13D0", Offset = "0x4AAFFD0", VA = "0x184AB13D0")]
		internal static string PtrToUtf8String(System.IntPtr ptr)
		{
			return null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4AB1360", Offset = "0x4AAFF60", VA = "0x184AB1360")]
		internal static SafeStringMarshal MarshalString(string str)
		{
			return default(SafeStringMarshal);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4AB12D0", Offset = "0x4AAFED0", VA = "0x184AB12D0")]
		private static int DecodeBlobSize(System.IntPtr in_ptr, out System.IntPtr out_ptr)
		{
			return 0;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4AB11E0", Offset = "0x4AAFDE0", VA = "0x184AB11E0")]
		internal static byte[] DecodeBlobArray(System.IntPtr ptr)
		{
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4AB11C0", Offset = "0x4AAFDC0", VA = "0x184AB11C0")]
		internal static int AsciHexDigitValue(int c)
		{
			return 0;
		}

		// Token: 0x0600007A RID: 122
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4AB1350", Offset = "0x4AAFF50", VA = "0x184AB1350")]
		[MethodImpl(4096)]
		internal static extern void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct);
	}
}
