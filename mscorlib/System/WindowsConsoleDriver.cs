using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001DE RID: 478
	[Token(Token = "0x20001DE")]
	internal class WindowsConsoleDriver : IConsoleDriver
	{
		// Token: 0x060010F9 RID: 4345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x4D60CE0", Offset = "0x4D5F8E0", VA = "0x184D60CE0")]
		public WindowsConsoleDriver()
		{
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0x4D60AA0", Offset = "0x4D5F6A0", VA = "0x184D60AA0", Slot = "4")]
		public System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			return default(System.ConsoleKeyInfo);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x4D60940", Offset = "0x4D5F540", VA = "0x184D60940")]
		private static bool IsModifierKey(short virtualKeyCode)
		{
			return default(bool);
		}

		// Token: 0x060010FC RID: 4348
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x4D608B0", Offset = "0x4D5F4B0", VA = "0x184D608B0")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern System.IntPtr GetStdHandle(Handles handle);

		// Token: 0x060010FD RID: 4349
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x4D60810", Offset = "0x4D5F410", VA = "0x184D60810")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool GetConsoleScreenBufferInfo(System.IntPtr handle, out ConsoleScreenBufferInfo info);

		// Token: 0x060010FE RID: 4350
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x4D60970", Offset = "0x4D5F570", VA = "0x184D60970")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern bool ReadConsoleInput(System.IntPtr handle, out InputRecord record, int length, out int nread);

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.IntPtr inputHandle;

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.IntPtr outputHandle;

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private short defaultAttribute;
	}
}
