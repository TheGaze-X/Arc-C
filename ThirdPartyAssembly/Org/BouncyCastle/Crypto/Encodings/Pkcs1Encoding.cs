using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Encodings
{
	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	public class Pkcs1Encoding : IAsymmetricBlockCipher
	{
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x0000E208 File Offset: 0x0000C408
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FC")]
		public static bool StrictLengthEnabled
		{
			[Token(Token = "0x6001D0A")]
			[Address(RVA = "0x52E72E0", Offset = "0x52E5EE0", VA = "0x1852E72E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0x52E7350", Offset = "0x52E5F50", VA = "0x1852E7350")]
			set
			{
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x52E71F0", Offset = "0x52E5DF0", VA = "0x1852E71F0")]
		public Pkcs1Encoding(IAsymmetricBlockCipher cipher)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x52E7160", Offset = "0x52E5D60", VA = "0x1852E7160")]
		public Pkcs1Encoding(IAsymmetricBlockCipher cipher, int pLen)
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x52E70B0", Offset = "0x52E5CB0", VA = "0x1852E70B0")]
		public Pkcs1Encoding(IAsymmetricBlockCipher cipher, byte[] fallback)
		{
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public IAsymmetricBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FD")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001D11")]
			[Address(RVA = "0x52E7270", Offset = "0x52E5E70", VA = "0x1852E7270", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x52E6CF0", Offset = "0x52E58F0", VA = "0x1852E6CF0", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0000E220 File Offset: 0x0000C420
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x52E6C30", Offset = "0x52E5830", VA = "0x1852E6C30", Slot = "6")]
		public int GetInputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0000E238 File Offset: 0x0000C438
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x52E6C90", Offset = "0x52E5890", VA = "0x1852E6C90", Slot = "7")]
		public int GetOutputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x52E6F80", Offset = "0x52E5B80", VA = "0x1852E6F80", Slot = "8")]
		public byte[] ProcessBlock(byte[] input, int inOff, int length)
		{
			return null;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x52E6980", Offset = "0x52E5580", VA = "0x1852E6980")]
		private byte[] EncodeBlock(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0000E250 File Offset: 0x0000C450
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x52E6190", Offset = "0x52E4D90", VA = "0x1852E6190")]
		private static int CheckPkcs1Encoding(byte[] encoded, int pLen)
		{
			return 0;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x52E6250", Offset = "0x52E4E50", VA = "0x1852E6250")]
		private byte[] DecodeBlockOrRandom(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x52E6610", Offset = "0x52E5210", VA = "0x1852E6610")]
		private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		public const string StrictLengthEnabledProperty = "Org.BouncyCastle.Pkcs1.Strict";

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		private const int HeaderLength = 10;

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool[] strictLengthEnabled;

		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		[FieldOffset(Offset = "0x10")]
		private SecureRandom random;

		// Token: 0x04000FC9 RID: 4041
		[Token(Token = "0x4000FC9")]
		[FieldOffset(Offset = "0x18")]
		private IAsymmetricBlockCipher engine;

		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		[FieldOffset(Offset = "0x20")]
		private bool forEncryption;

		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x21")]
		private bool forPrivateKey;

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x22")]
		private bool useStrictLength;

		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x24")]
		private int pLen;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0x28")]
		private byte[] fallback;
	}
}
