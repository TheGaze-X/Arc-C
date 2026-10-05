using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Steamworks
{
	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	public class InteropHelp
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void TestIfPlatformSupported()
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x4EE1B70", Offset = "0x4EE0770", VA = "0x184EE1B70")]
		public static void TestIfAvailableClient()
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x4EE1C50", Offset = "0x4EE0850", VA = "0x184EE1C50")]
		public static void TestIfAvailableGameServer()
		{
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x4EE1910", Offset = "0x4EE0510", VA = "0x184EE1910")]
		public static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			return null;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x4EE1870", Offset = "0x4EE0470", VA = "0x184EE1870")]
		public static string ByteArrayToStringUTF8(byte[] buffer)
		{
			return null;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x4EE1A90", Offset = "0x4EE0690", VA = "0x184EE1A90")]
		public static void StringToByteArrayUTF8(string str, byte[] outArrayBuffer, int outArrayBufferSize)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InteropHelp()
		{
		}

		// Token: 0x0200018A RID: 394
		[Token(Token = "0x200018A")]
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x060008F8 RID: 2296 RVA: 0x00002142 File Offset: 0x00000342
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x4F19240", Offset = "0x4F17E40", VA = "0x184F19240")]
			public UTF8StringHandle(string str)
			{
			}

			// Token: 0x060008F9 RID: 2297 RVA: 0x00007E14 File Offset: 0x00006014
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x4F191C0", Offset = "0x4F17DC0", VA = "0x184F191C0", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}

		// Token: 0x0200018B RID: 395
		[Token(Token = "0x200018B")]
		public class SteamParamStringArray
		{
			// Token: 0x060008FA RID: 2298 RVA: 0x00002142 File Offset: 0x00000342
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x4F0FB10", Offset = "0x4F0E710", VA = "0x184F0FB10")]
			public SteamParamStringArray(IList<string> strings)
			{
			}

			// Token: 0x060008FB RID: 2299 RVA: 0x00002142 File Offset: 0x00000342
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x4F0F980", Offset = "0x4F0E580", VA = "0x184F0F980", Slot = "1")]
			protected override void Finalize()
			{
			}

			// Token: 0x060008FC RID: 2300 RVA: 0x00007E2C File Offset: 0x0000602C
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x4F100F0", Offset = "0x4F0ECF0", VA = "0x184F100F0")]
			public static implicit operator IntPtr(InteropHelp.SteamParamStringArray that)
			{
				return 0;
			}

			// Token: 0x04000A57 RID: 2647
			[Token(Token = "0x4000A57")]
			[FieldOffset(Offset = "0x10")]
			private IntPtr[] m_Strings;

			// Token: 0x04000A58 RID: 2648
			[Token(Token = "0x4000A58")]
			[FieldOffset(Offset = "0x18")]
			private IntPtr m_ptrStrings;

			// Token: 0x04000A59 RID: 2649
			[Token(Token = "0x4000A59")]
			[FieldOffset(Offset = "0x20")]
			private IntPtr m_pSteamParamStringArray;
		}
	}
}
