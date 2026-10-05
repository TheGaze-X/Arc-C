using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	internal class CADMethodReturnMessage : CADMessageBase
	{
		// Token: 0x06001E80 RID: 7808 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E80")]
		[Address(RVA = "0x4B71C20", Offset = "0x4B70820", VA = "0x184B71C20")]
		internal static CADMethodReturnMessage Create(IMessage callMsg)
		{
			return null;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x4B71F10", Offset = "0x4B70B10", VA = "0x184B71F10")]
		internal CADMethodReturnMessage(IMethodReturnMessage retMsg)
		{
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x4B71CB0", Offset = "0x4B708B0", VA = "0x184B71CB0")]
		internal System.Collections.ArrayList GetArguments()
		{
			return null;
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x4B70C90", Offset = "0x4B6F890", VA = "0x184B70C90")]
		internal object[] GetArgs(System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0x4B71F00", Offset = "0x4B70B00", VA = "0x184B71F00")]
		internal object GetReturnValue(System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0x4B71E00", Offset = "0x4B70A00", VA = "0x184B71E00")]
		internal System.Exception GetException(System.Collections.ArrayList args)
		{
			return null;
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00012EE8 File Offset: 0x000110E8
		[Token(Token = "0x170003B4")]
		internal int PropertiesCount
		{
			[Token(Token = "0x6001E86")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04001038 RID: 4152
		[Token(Token = "0x4001038")]
		[FieldOffset(Offset = "0x38")]
		private object _returnValue;

		// Token: 0x04001039 RID: 4153
		[Token(Token = "0x4001039")]
		[FieldOffset(Offset = "0x40")]
		private CADArgHolder _exception;

		// Token: 0x0400103A RID: 4154
		[Token(Token = "0x400103A")]
		[FieldOffset(Offset = "0x48")]
		private System.Type[] _sig;
	}
}
