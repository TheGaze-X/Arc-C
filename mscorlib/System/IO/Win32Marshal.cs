using System;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000663 RID: 1635
	[Token(Token = "0x2000663")]
	internal static class Win32Marshal
	{
		// Token: 0x06003150 RID: 12624 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003150")]
		[Address(RVA = "0x4C913D0", Offset = "0x4C8FFD0", VA = "0x184C913D0")]
		internal static System.Exception GetExceptionForLastWin32Error(string path = "")
		{
			return null;
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003151")]
		[Address(RVA = "0x4C91430", Offset = "0x4C90030", VA = "0x184C91430")]
		internal static System.Exception GetExceptionForWin32Error(int errorCode, string path = "")
		{
			return null;
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		[Token(Token = "0x6003152")]
		[Address(RVA = "0x4C91900", Offset = "0x4C90500", VA = "0x184C91900")]
		internal static int MakeHRFromErrorCode(int errorCode)
		{
			return 0;
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0001A910 File Offset: 0x00018B10
		[Token(Token = "0x6003153")]
		[Address(RVA = "0x4C91920", Offset = "0x4C90520", VA = "0x184C91920")]
		internal static int TryMakeWin32ErrorCodeFromHR(int hr)
		{
			return 0;
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6003154")]
		[Address(RVA = "0x4C918F0", Offset = "0x4C904F0", VA = "0x184C918F0")]
		internal static string GetMessage(int errorCode)
		{
			return null;
		}
	}
}
