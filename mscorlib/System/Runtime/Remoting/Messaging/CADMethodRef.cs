using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	[System.Serializable]
	internal class CADMethodRef
	{
		// Token: 0x06001E6B RID: 7787 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x4B710E0", Offset = "0x4B6FCE0", VA = "0x184B710E0")]
		private System.Type[] GetTypes(string[] typeArray)
		{
			return null;
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x4B71220", Offset = "0x4B6FE20", VA = "0x184B71220")]
		public System.Reflection.MethodBase Resolve()
		{
			return null;
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x4B71830", Offset = "0x4B70430", VA = "0x184B71830")]
		public CADMethodRef(IMethodMessage msg)
		{
		}

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x10")]
		private bool ctor;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x18")]
		private string typeName;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x20")]
		private string methodName;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x28")]
		private string[] param_names;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x30")]
		private string[] generic_arg_names;
	}
}
