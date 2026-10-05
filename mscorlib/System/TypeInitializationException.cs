using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	[System.Serializable]
	public sealed class TypeInitializationException : System.SystemException
	{
		// Token: 0x06000B76 RID: 2934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x4D00E90", Offset = "0x4CFFA90", VA = "0x184D00E90")]
		private TypeInitializationException()
		{
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x4D00F20", Offset = "0x4CFFB20", VA = "0x184D00F20")]
		public TypeInitializationException(string fullTypeName, System.Exception innerException)
		{
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x4D010B0", Offset = "0x4CFFCB0", VA = "0x184D010B0")]
		internal TypeInitializationException(string fullTypeName, string message, System.Exception innerException)
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x4D00FF0", Offset = "0x4CFFBF0", VA = "0x184D00FF0")]
		internal TypeInitializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x4D00D90", Offset = "0x4CFF990", VA = "0x184D00D90", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000FE")]
		public string TypeName
		{
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x4D01150", Offset = "0x4CFFD50", VA = "0x184D01150")]
			get
			{
				return null;
			}
		}

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x90")]
		private string _typeName;
	}
}
