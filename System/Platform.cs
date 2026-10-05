using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	internal static class Platform
	{
		// Token: 0x0600045C RID: 1116
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x50ECE80", Offset = "0x50EBA80", VA = "0x1850ECE80")]
		[PreserveSig]
		private static extern int uname(IntPtr buf);

		// Token: 0x0600045D RID: 1117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x50ECBA0", Offset = "0x50EB7A0", VA = "0x1850ECBA0")]
		private static void CheckOS()
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x170000C1")]
		public static bool IsMacOS
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x50ECE10", Offset = "0x50EBA10", VA = "0x1850ECE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool checkedOS;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool isMacOS;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private static bool isAix;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private static bool isIBMi;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool isFreeBSD;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		private static bool isOpenBSD;
	}
}
