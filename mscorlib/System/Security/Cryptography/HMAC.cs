using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class HMAC : KeyedHashAlgorithm
	{
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00011B80 File Offset: 0x0000FD80
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AA")]
		protected int BlockSizeValue
		{
			[Token(Token = "0x600193F")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001940")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			set
			{
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x4B2CEA0", Offset = "0x4B2BAA0", VA = "0x184B2CEA0")]
		private void UpdateIOPadBuffers()
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x4B2CB60", Offset = "0x4B2B760", VA = "0x184B2CB60")]
		internal void InitializeKey(byte[] key)
		{
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AB")]
		public override byte[] Key
		{
			[Token(Token = "0x6001943")]
			[Address(RVA = "0x4B2D010", Offset = "0x4B2BC10", VA = "0x184B2D010", Slot = "23")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001944")]
			[Address(RVA = "0x4B2D150", Offset = "0x4B2BD50", VA = "0x184B2D150", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AC")]
		public string HashName
		{
			[Token(Token = "0x6001945")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001946")]
			[Address(RVA = "0x4B2D090", Offset = "0x4B2BC90", VA = "0x184B2D090")]
			set
			{
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x4B2C590", Offset = "0x4B2B190", VA = "0x184B2C590")]
		public new static HMAC Create()
		{
			return null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x4B2C4B0", Offset = "0x4B2B0B0", VA = "0x184B2C4B0")]
		public new static HMAC Create(string algorithmName)
		{
			return null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x4B2CE20", Offset = "0x4B2BA20", VA = "0x184B2CE20", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600194A")]
		[Address(RVA = "0x4B2C7E0", Offset = "0x4B2B3E0", VA = "0x184B2C7E0", Slot = "18")]
		protected override void HashCore(byte[] rgb, int ib, int cb)
		{
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x4B2C910", Offset = "0x4B2B510", VA = "0x184B2C910", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x4B2C5E0", Offset = "0x4B2B1E0", VA = "0x184B2C5E0", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600194D")]
		[Address(RVA = "0x4B2C6B0", Offset = "0x4B2B2B0", VA = "0x184B2C6B0")]
		internal static HashAlgorithm GetHashAlgorithmWithFipsFallback(System.Func<HashAlgorithm> createStandardHashAlgorithmCallback, System.Func<HashAlgorithm> createFipsHashAlgorithmCallback)
		{
			return null;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x4B2D000", Offset = "0x4B2BC00", VA = "0x184B2D000")]
		protected HMAC()
		{
		}

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int blockSizeValue;

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal string m_hashName;

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal HashAlgorithm m_hash1;

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal HashAlgorithm m_hash2;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private byte[] m_inner;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private byte[] m_outer;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_hashing;
	}
}
