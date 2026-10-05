using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	public static class Console
	{
		// Token: 0x06000F8B RID: 3979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x4D30520", Offset = "0x4D2F120", VA = "0x184D30520")]
		private static void SetupStreams(System.Text.Encoding inputEncoding, System.Text.Encoding outputEncoding)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000167")]
		public static System.IO.TextWriter Error
		{
			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0x4D30E80", Offset = "0x4D2FA80", VA = "0x184D30E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000168")]
		public static System.IO.TextWriter Out
		{
			[Token(Token = "0x6000F8D")]
			[Address(RVA = "0x4D30F20", Offset = "0x4D2FB20", VA = "0x184D30F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x4D30030", Offset = "0x4D2EC30", VA = "0x184D30030")]
		private static System.IO.Stream Open(System.IntPtr handle, System.IO.FileAccess access, int bufferSize)
		{
			return null;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0x4D2FE80", Offset = "0x4D2EA80", VA = "0x184D2FE80")]
		public static System.IO.Stream OpenStandardError(int bufferSize)
		{
			return null;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x4D2FF10", Offset = "0x4D2EB10", VA = "0x184D2FF10")]
		public static System.IO.Stream OpenStandardInput(int bufferSize)
		{
			return null;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x4D2FFA0", Offset = "0x4D2EBA0", VA = "0x184D2FFA0")]
		public static System.IO.Stream OpenStandardOutput(int bufferSize)
		{
			return null;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x4D30430", Offset = "0x4D2F030", VA = "0x184D30430")]
		public static void SetOut(System.IO.TextWriter newOut)
		{
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x4D30B70", Offset = "0x4D2F770", VA = "0x184D30B70")]
		public static void Write(string value)
		{
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x4D309B0", Offset = "0x4D2F5B0", VA = "0x184D309B0")]
		public static void WriteLine(object value)
		{
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x4D30A40", Offset = "0x4D2F640", VA = "0x184D30A40")]
		public static void WriteLine(string value)
		{
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x4D30AD0", Offset = "0x4D2F6D0", VA = "0x184D30AD0")]
		public static void WriteLine(string format, object arg0)
		{
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000169")]
		public static System.Text.Encoding InputEncoding
		{
			[Token(Token = "0x6000F97")]
			[Address(RVA = "0x4D30ED0", Offset = "0x4D2FAD0", VA = "0x184D30ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700016A")]
		public static System.Text.Encoding OutputEncoding
		{
			[Token(Token = "0x6000F98")]
			[Address(RVA = "0x4D30F70", Offset = "0x4D2FB70", VA = "0x184D30F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x4D302A0", Offset = "0x4D2EEA0", VA = "0x184D302A0")]
		public static System.ConsoleKeyInfo ReadKey()
		{
			return default(System.ConsoleKeyInfo);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0000D110 File Offset: 0x0000B310
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x4D30130", Offset = "0x4D2ED30", VA = "0x184D30130")]
		public static System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			return default(System.ConsoleKeyInfo);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x4D2FCF0", Offset = "0x4D2E8F0", VA = "0x184D2FCF0")]
		private static void DoConsoleCancelEvent()
		{
		}

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static System.IO.TextWriter stdout;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.IO.TextWriter stderr;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.IO.TextReader stdin;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static bool IsRunningOnAndroid;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static System.Text.Encoding inputEncoding;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static System.Text.Encoding outputEncoding;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static System.ConsoleCancelEventHandler cancel_event;

		// Token: 0x0200019F RID: 415
		[Token(Token = "0x200019F")]
		private class WindowsConsole
		{
			// Token: 0x06000F9C RID: 3996
			[Token(Token = "0x6000F9C")]
			[Address(RVA = "0x4D472D0", Offset = "0x4D45ED0", VA = "0x184D472D0")]
			[System.Runtime.InteropServices.PreserveSig]
			private static extern int GetConsoleCP();

			// Token: 0x06000F9D RID: 3997
			[Token(Token = "0x6000F9D")]
			[Address(RVA = "0x4D47340", Offset = "0x4D45F40", VA = "0x184D47340")]
			[System.Runtime.InteropServices.PreserveSig]
			private static extern int GetConsoleOutputCP();

			// Token: 0x06000F9E RID: 3998 RVA: 0x0000D128 File Offset: 0x0000B328
			[Token(Token = "0x6000F9E")]
			[Address(RVA = "0x4D47280", Offset = "0x4D45E80", VA = "0x184D47280")]
			private static bool DoWindowsConsoleCancelEvent(int keyCode)
			{
				return default(bool);
			}

			// Token: 0x06000F9F RID: 3999 RVA: 0x0000D140 File Offset: 0x0000B340
			[Token(Token = "0x6000F9F")]
			[Address(RVA = "0x4D473B0", Offset = "0x4D45FB0", VA = "0x184D473B0")]
			[MethodImpl(8)]
			public static int GetInputCodePage()
			{
				return 0;
			}

			// Token: 0x06000FA0 RID: 4000 RVA: 0x0000D158 File Offset: 0x0000B358
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0x4D47450", Offset = "0x4D46050", VA = "0x184D47450")]
			[MethodImpl(8)]
			public static int GetOutputCodePage()
			{
				return 0;
			}

			// Token: 0x04000742 RID: 1858
			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static bool ctrlHandlerAdded;

			// Token: 0x04000743 RID: 1859
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static System.Console.WindowsConsole.WindowsCancelHandler cancelHandler;

			// Token: 0x020001A0 RID: 416
			// (Invoke) Token: 0x06000FA3 RID: 4003
			[Token(Token = "0x20001A0")]
			private delegate bool WindowsCancelHandler(int keyCode);
		}
	}
}
