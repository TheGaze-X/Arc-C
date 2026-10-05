using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	[System.Serializable]
	public class MissingFieldException : System.MissingMemberException, System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x4CF5620", Offset = "0x4CF4220", VA = "0x184CF5620")]
		public MissingFieldException()
		{
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x4CF56F0", Offset = "0x4CF42F0", VA = "0x184CF56F0")]
		public MissingFieldException(string message)
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x4CF5670", Offset = "0x4CF4270", VA = "0x184CF5670")]
		public MissingFieldException(string className, string fieldName)
		{
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x4CDDD90", Offset = "0x4CDC990", VA = "0x184CDDD90")]
		protected MissingFieldException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000114")]
		public override string Message
		{
			[Token(Token = "0x6000CBE")]
			[Address(RVA = "0x4CF5710", Offset = "0x4CF4310", VA = "0x184CF5710", Slot = "5")]
			get
			{
				return null;
			}
		}
	}
}
