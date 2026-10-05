using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	[System.Serializable]
	public class FileLoadException : IOException
	{
		// Token: 0x06003037 RID: 12343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x4C5E0A0", Offset = "0x4C5CCA0", VA = "0x184C5E0A0")]
		public FileLoadException()
		{
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003038")]
		[Address(RVA = "0x4C5E080", Offset = "0x4C5CC80", VA = "0x184C5E080")]
		public FileLoadException(string message)
		{
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007C0")]
		public override string Message
		{
			[Token(Token = "0x6003039")]
			[Address(RVA = "0x4C5E0F0", Offset = "0x4C5CCF0", VA = "0x184C5E0F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007C1")]
		public string FileName
		{
			[Token(Token = "0x600303A")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007C2")]
		public string FusionLog
		{
			[Token(Token = "0x600303B")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600303C")]
		[Address(RVA = "0x4C5DD70", Offset = "0x4C5C970", VA = "0x184C5DD70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303D")]
		[Address(RVA = "0x4C5DFC0", Offset = "0x4C5CBC0", VA = "0x184C5DFC0")]
		protected FileLoadException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303E")]
		[Address(RVA = "0x4C5DC50", Offset = "0x4C5C850", VA = "0x184C5DC50", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x4C5DBF0", Offset = "0x4C5C7F0", VA = "0x184C5DBF0")]
		internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
		{
			return null;
		}
	}
}
