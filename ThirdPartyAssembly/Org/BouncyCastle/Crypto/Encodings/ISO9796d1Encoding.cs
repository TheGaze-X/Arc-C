using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Encodings
{
	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	public class ISO9796d1Encoding : IAsymmetricBlockCipher
	{
		// Token: 0x06001CF0 RID: 7408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public ISO9796d1Encoding(IAsymmetricBlockCipher cipher)
		{
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FA")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001CF1")]
			[Address(RVA = "0x52DDF80", Offset = "0x52DCB80", VA = "0x1852DDF80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public IAsymmetricBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x52DDAA0", Offset = "0x52DC6A0", VA = "0x1852DDAA0", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x52DD9E0", Offset = "0x52DC5E0", VA = "0x1852DD9E0", Slot = "6")]
		public int GetInputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x52DDA40", Offset = "0x52DC640", VA = "0x1852DDA40", Slot = "7")]
		public int GetOutputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x52DDD90", Offset = "0x52DC990", VA = "0x1852DDD90")]
		public void SetPadBits(int padBits)
		{
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
		public int GetPadBits()
		{
			return 0;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x52DDD60", Offset = "0x52DC960", VA = "0x1852DDD60", Slot = "8")]
		public byte[] ProcessBlock(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x52DD700", Offset = "0x52DC300", VA = "0x1852DD700")]
		private byte[] EncodeBlock(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x52DD180", Offset = "0x52DBD80", VA = "0x1852DD180")]
		private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BigInteger Sixteen;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BigInteger Six;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] shadows;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] inverse;

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAsymmetricBlockCipher engine;

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		[FieldOffset(Offset = "0x18")]
		private bool forEncryption;

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		[FieldOffset(Offset = "0x1C")]
		private int bitSize;

		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		[FieldOffset(Offset = "0x20")]
		private int padBits;

		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		[FieldOffset(Offset = "0x28")]
		private BigInteger modulus;
	}
}
