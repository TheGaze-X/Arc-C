using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	[System.Serializable]
	public class MissingMethodException : System.MissingMemberException
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x4CDDDB0", Offset = "0x4CDC9B0", VA = "0x184CDDDB0")]
		public MissingMethodException()
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x4CDDE00", Offset = "0x4CDCA00", VA = "0x184CDDE00")]
		public MissingMethodException(string message)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x4CDDD30", Offset = "0x4CDC930", VA = "0x184CDDD30")]
		public MissingMethodException(string className, string methodName)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x4CDDD90", Offset = "0x4CDC990", VA = "0x184CDDD90")]
		protected MissingMethodException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700009E")]
		public override string Message
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x4CDDE20", Offset = "0x4CDCA20", VA = "0x184CDDE20", Slot = "5")]
			get
			{
				return null;
			}
		}
	}
}
