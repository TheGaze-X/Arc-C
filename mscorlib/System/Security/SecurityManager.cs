using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public static class SecurityManager
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00011220 File Offset: 0x0000F420
		[Token(Token = "0x1700026B")]
		[System.Obsolete("The security manager cannot be turned off on MS runtime")]
		public static bool SecurityEnabled
		{
			[Token(Token = "0x60017D4")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal static void EnsureElevatedPermissions()
		{
		}
	}
}
