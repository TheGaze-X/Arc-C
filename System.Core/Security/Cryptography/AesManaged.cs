using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public sealed class AesManaged : Aes
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4F1BA40", Offset = "0x4F1A640", VA = "0x184F1BA40")]
		public AesManaged()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000001")]
		public override int FeedbackSize
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x4F1BC40", Offset = "0x4F1A840", VA = "0x184F1BC40", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x4F1BE20", Offset = "0x4F1AA20", VA = "0x184F1BE20", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000002")]
		public override byte[] IV
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4F1BC90", Offset = "0x4F1A890", VA = "0x184F1BC90", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x4F1BE70", Offset = "0x4F1AA70", VA = "0x184F1BE70", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000003")]
		public override byte[] Key
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x4F1BD30", Offset = "0x4F1A930", VA = "0x184F1BD30", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x4F1BF10", Offset = "0x4F1AB10", VA = "0x184F1BF10", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000004")]
		public override int KeySize
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x4F1BCE0", Offset = "0x4F1A8E0", VA = "0x184F1BCE0", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4F1BEC0", Offset = "0x4F1AAC0", VA = "0x184F1BEC0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000005")]
		public override CipherMode Mode
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x4F1BD80", Offset = "0x4F1A980", VA = "0x184F1BD80", Slot = "18")]
			get
			{
				return (CipherMode)0;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x4F1BF60", Offset = "0x4F1AB60", VA = "0x184F1BF60", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000006")]
		public override PaddingMode Padding
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x4F1BDD0", Offset = "0x4F1A9D0", VA = "0x184F1BDD0", Slot = "20")]
			get
			{
				return (PaddingMode)0;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4F1C020", Offset = "0x4F1AC20", VA = "0x184F1C020", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4F1B6D0", Offset = "0x4F1A2D0", VA = "0x184F1B6D0", Slot = "24")]
		public override ICryptoTransform CreateDecryptor()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4F1B530", Offset = "0x4F1A130", VA = "0x184F1B530", Slot = "25")]
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4F1B8C0", Offset = "0x4F1A4C0", VA = "0x184F1B8C0", Slot = "22")]
		public override ICryptoTransform CreateEncryptor()
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4F1B720", Offset = "0x4F1A320", VA = "0x184F1B720", Slot = "23")]
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4F1B910", Offset = "0x4F1A510", VA = "0x184F1B910", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4F1B9C0", Offset = "0x4F1A5C0", VA = "0x184F1B9C0", Slot = "27")]
		public override void GenerateIV()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4F1BA00", Offset = "0x4F1A600", VA = "0x184F1BA00", Slot = "26")]
		public override void GenerateKey()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x48")]
		private RijndaelManaged m_rijndael;
	}
}
