using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	[System.Serializable]
	public class ArgumentOutOfRangeException : System.ArgumentException
	{
		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x4CA5000", Offset = "0x4CA3C00", VA = "0x184CA5000")]
		public ArgumentOutOfRangeException()
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x4CA5050", Offset = "0x4CA3C50", VA = "0x184CA5050")]
		public ArgumentOutOfRangeException(string paramName)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x4CA50C0", Offset = "0x4CA3CC0", VA = "0x184CA50C0")]
		public ArgumentOutOfRangeException(string paramName, string message)
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x4CA4E70", Offset = "0x4CA3A70", VA = "0x184CA4E70")]
		public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x4CA4EE0", Offset = "0x4CA3AE0", VA = "0x184CA4EE0")]
		protected ArgumentOutOfRangeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x4CA4D10", Offset = "0x4CA3910", VA = "0x184CA4D10", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700005E")]
		public override string Message
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x4CA5110", Offset = "0x4CA3D10", VA = "0x184CA5110", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x98")]
		private object _actualValue;
	}
}
