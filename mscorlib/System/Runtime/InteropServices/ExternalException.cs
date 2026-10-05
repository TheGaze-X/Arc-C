using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000454 RID: 1108
	[Token(Token = "0x2000454")]
	[System.Serializable]
	public class ExternalException : System.SystemException
	{
		// Token: 0x060021F5 RID: 8693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x4BB4900", Offset = "0x4BB3500", VA = "0x184BB4900")]
		public ExternalException()
		{
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x4BB4F30", Offset = "0x4BB3B30", VA = "0x184BB4F30")]
		public ExternalException(string message)
		{
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x4BB4F50", Offset = "0x4BB3B50", VA = "0x184BB4F50")]
		public ExternalException(string message, System.Exception inner)
		{
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x4BB4F70", Offset = "0x4BB3B70", VA = "0x184BB4F70")]
		public ExternalException(string message, int errorCode)
		{
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		protected ExternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021FA")]
		[Address(RVA = "0x4BB4D00", Offset = "0x4BB3900", VA = "0x184BB4D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
