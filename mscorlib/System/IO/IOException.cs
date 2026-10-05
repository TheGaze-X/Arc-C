using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200064E RID: 1614
	[Token(Token = "0x200064E")]
	[System.Serializable]
	public class IOException : System.SystemException
	{
		// Token: 0x0600304A RID: 12362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304A")]
		[Address(RVA = "0x4C7C510", Offset = "0x4C7B110", VA = "0x184C7C510")]
		public IOException()
		{
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304B")]
		[Address(RVA = "0x4C7C4F0", Offset = "0x4C7B0F0", VA = "0x184C7C4F0")]
		public IOException(string message)
		{
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304C")]
		[Address(RVA = "0x4BB4F70", Offset = "0x4BB3B70", VA = "0x184BB4F70")]
		public IOException(string message, int hresult)
		{
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304D")]
		[Address(RVA = "0x4C7C560", Offset = "0x4C7B160", VA = "0x184C7C560")]
		public IOException(string message, System.Exception innerException)
		{
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304E")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		protected IOException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
