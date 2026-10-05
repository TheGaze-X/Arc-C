using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	internal class Win32NetworkInterface
	{
		// Token: 0x0600189B RID: 6299
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x50B93B0", Offset = "0x50B7FB0", VA = "0x1850B93B0")]
		[PreserveSig]
		private static extern int GetNetworkParams(IntPtr ptr, ref int size);

		// Token: 0x0600189C RID: 6300
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x50B9440", Offset = "0x50B8040", VA = "0x1850B9440")]
		[PreserveSig]
		private unsafe static extern int MultiByteToWideChar(uint CodePage, uint dwFlags, byte* lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar);

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x1700056A")]
		public static Win32_FIXED_INFO FixedInfo
		{
			[Token(Token = "0x600189D")]
			[Address(RVA = "0x50B9600", Offset = "0x50B8200", VA = "0x1850B9600")]
			get
			{
				return default(Win32_FIXED_INFO);
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x50B9510", Offset = "0x50B8110", VA = "0x1850B9510")]
		[CompilerGenerated]
		internal unsafe static string <get_FixedInfo>g__GetStringFromMultiByte|5_0(byte* bytes)
		{
			return null;
		}

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Win32_FIXED_INFO fixedInfo;

		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static bool initialized;
	}
}
