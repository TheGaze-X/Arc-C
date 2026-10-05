using System;
using Il2CppDummyDll;

namespace Microsoft.Win32
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	internal static class Win32Native
	{
		// Token: 0x06000269 RID: 617 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x4C08970", Offset = "0x4C07570", VA = "0x184C08970")]
		public static string GetMessage(int hr)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x4C089C0", Offset = "0x4C075C0", VA = "0x184C089C0")]
		public static int MakeHRFromErrorCode(int errorCode)
		{
			return 0;
		}
	}
}
