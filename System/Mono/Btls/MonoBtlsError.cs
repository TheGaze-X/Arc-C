using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	internal static class MonoBtlsError
	{
		// Token: 0x060001CF RID: 463
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4F57140", Offset = "0x4F55D40", VA = "0x184F57140")]
		[PreserveSig]
		private static extern void mono_btls_error_clear_error();

		// Token: 0x060001D0 RID: 464
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x4F57560", Offset = "0x4F56160", VA = "0x184F57560")]
		[PreserveSig]
		private static extern int mono_btls_error_get_error_line(out IntPtr file, out int line);

		// Token: 0x060001D1 RID: 465
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4F575F0", Offset = "0x4F561F0", VA = "0x184F575F0")]
		[PreserveSig]
		private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len);

		// Token: 0x060001D2 RID: 466
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x4F571B0", Offset = "0x4F55DB0", VA = "0x184F571B0")]
		[PreserveSig]
		private static extern int mono_btls_error_get_reason(int error);

		// Token: 0x060001D3 RID: 467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x4F57140", Offset = "0x4F55D40", VA = "0x184F57140")]
		public static void ClearError()
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x4F57230", Offset = "0x4F55E30", VA = "0x184F57230")]
		public static string GetErrorString(int error)
		{
			return null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x4F57440", Offset = "0x4F56040", VA = "0x184F57440")]
		public static int GetError(out string file, out int line)
		{
			return 0;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x4F571B0", Offset = "0x4F55DB0", VA = "0x184F571B0")]
		public static int GetErrorReason(int error)
		{
			return 0;
		}
	}
}
