using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	internal static class ConsoleDriver
	{
		// Token: 0x06000FA5 RID: 4005 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x4D2F860", Offset = "0x4D2E460", VA = "0x184D2F860")]
		[MethodImpl(8)]
		private static IConsoleDriver CreateNullConsoleDriver()
		{
			return null;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x4D2F900", Offset = "0x4D2E500", VA = "0x184D2F900")]
		[MethodImpl(8)]
		private static IConsoleDriver CreateWindowsConsoleDriver()
		{
			return null;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x4D2F8A0", Offset = "0x4D2E4A0", VA = "0x184D2F8A0")]
		[MethodImpl(8)]
		private static IConsoleDriver CreateTermInfoDriver(string term)
		{
			return null;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0000D170 File Offset: 0x0000B370
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x4D2F960", Offset = "0x4D2E560", VA = "0x184D2F960")]
		public static System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			return default(System.ConsoleKeyInfo);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0000D188 File Offset: 0x0000B388
		[Token(Token = "0x1700016B")]
		public static bool IsConsole
		{
			[Token(Token = "0x6000FA9")]
			[Address(RVA = "0x4D2FB90", Offset = "0x4D2E790", VA = "0x184D2FB90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FAA RID: 4010
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x4D2F950", Offset = "0x4D2E550", VA = "0x184D2F950")]
		[MethodImpl(4096)]
		private static extern bool Isatty(System.IntPtr handle);

		// Token: 0x06000FAB RID: 4011
		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0x4D1E4C0", Offset = "0x4D1D0C0", VA = "0x184D1E4C0")]
		[MethodImpl(4096)]
		internal static extern int InternalKeyAvailable(int ms_timeout);

		// Token: 0x06000FAC RID: 4012
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0x4D2FAA0", Offset = "0x4D2E6A0", VA = "0x184D2FAA0")]
		[MethodImpl(4096)]
		internal unsafe static extern bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address);

		// Token: 0x06000FAD RID: 4013
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x4B63760", Offset = "0x4B62360", VA = "0x184B63760")]
		[MethodImpl(4096)]
		internal static extern bool SetEcho(bool wantEcho);

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x0")]
		internal static IConsoleDriver driver;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x8")]
		private static bool is_console;

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x9")]
		private static bool called_isatty;
	}
}
