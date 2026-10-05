using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	[System.Serializable]
	public class MissingMemberException : System.MemberAccessException
	{
		// Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x4CF5AE0", Offset = "0x4CF46E0", VA = "0x184CF5AE0")]
		public MissingMemberException()
		{
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x4CF5B30", Offset = "0x4CF4730", VA = "0x184CF5B30")]
		public MissingMemberException(string message)
		{
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x4CF5B50", Offset = "0x4CF4750", VA = "0x184CF5B50")]
		protected MissingMemberException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x4CF5970", Offset = "0x4CF4570", VA = "0x184CF5970", Slot = "12")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000115")]
		public override string Message
		{
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x4CF5CF0", Offset = "0x4CF48F0", VA = "0x184CF5CF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x4CF5930", Offset = "0x4CF4530", VA = "0x184CF5930")]
		internal static string FormatSignature(byte[] signature)
		{
			return null;
		}

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x90")]
		protected string ClassName;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x98")]
		protected string MemberName;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0xA0")]
		protected byte[] Signature;
	}
}
