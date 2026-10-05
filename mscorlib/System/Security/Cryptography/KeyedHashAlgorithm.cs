using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class KeyedHashAlgorithm : HashAlgorithm
	{
		// Token: 0x06001968 RID: 6504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected KeyedHashAlgorithm()
		{
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x4B2E840", Offset = "0x4B2D440", VA = "0x184B2E840", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B5")]
		public virtual byte[] Key
		{
			[Token(Token = "0x600196A")]
			[Address(RVA = "0x4B2E890", Offset = "0x4B2D490", VA = "0x184B2E890", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x600196B")]
			[Address(RVA = "0x4B2E910", Offset = "0x4B2D510", VA = "0x184B2E910", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x4B2E7F0", Offset = "0x4B2D3F0", VA = "0x184B2E7F0")]
		public new static KeyedHashAlgorithm Create()
		{
			return null;
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x4B2E710", Offset = "0x4B2D310", VA = "0x184B2E710")]
		public new static KeyedHashAlgorithm Create(string algName)
		{
			return null;
		}

		// Token: 0x04000DDE RID: 3550
		[Token(Token = "0x4000DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected byte[] KeyValue;
	}
}
