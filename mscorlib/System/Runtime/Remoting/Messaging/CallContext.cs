using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public sealed class CallContext
	{
		// Token: 0x06001E2F RID: 7727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private CallContext()
		{
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
		internal static object SetCurrentCallContext(LogicalCallContext ctx)
		{
			return null;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x4B72900", Offset = "0x4B71500", VA = "0x184B72900")]
		internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
		{
			return null;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x4B72720", Offset = "0x4B71320", VA = "0x184B72720")]
		public static object LogicalGetData(string name)
		{
			return null;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x4B727C0", Offset = "0x4B713C0", VA = "0x184B727C0")]
		public static void LogicalSetData(string name, object data)
		{
		}
	}
}
