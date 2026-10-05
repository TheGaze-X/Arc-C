using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	[System.Serializable]
	public class ArgumentException : System.SystemException
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x4CA49D0", Offset = "0x4CA35D0", VA = "0x184CA49D0")]
		public ArgumentException()
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x4CA49B0", Offset = "0x4CA35B0", VA = "0x184CA49B0")]
		public ArgumentException(string message)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x4CA4B40", Offset = "0x4CA3740", VA = "0x184CA4B40")]
		public ArgumentException(string message, System.Exception innerException)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x4CA4A20", Offset = "0x4CA3620", VA = "0x184CA4A20")]
		public ArgumentException(string message, string paramName, System.Exception innerException)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x4CA4A70", Offset = "0x4CA3670", VA = "0x184CA4A70")]
		public ArgumentException(string message, string paramName)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x4CA4AB0", Offset = "0x4CA36B0", VA = "0x184CA4AB0")]
		protected ArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x4CA48E0", Offset = "0x4CA34E0", VA = "0x184CA48E0", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700005D")]
		public override string Message
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x4CA4B60", Offset = "0x4CA3760", VA = "0x184CA4B60", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x90")]
		private string _paramName;
	}
}
