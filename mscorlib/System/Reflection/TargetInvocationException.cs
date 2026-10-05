using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	[System.Serializable]
	public sealed class TargetInvocationException : System.ApplicationException
	{
		// Token: 0x060025A4 RID: 9636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x4BE9690", Offset = "0x4BE8290", VA = "0x184BE9690")]
		public TargetInvocationException(System.Exception inner)
		{
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x4BE96F0", Offset = "0x4BE82F0", VA = "0x184BE96F0")]
		public TargetInvocationException(string message, System.Exception inner)
		{
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0x4A31B10", Offset = "0x4A30710", VA = "0x184A31B10")]
		internal TargetInvocationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
