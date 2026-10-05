using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Encodings
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	public class OaepEncoding : IAsymmetricBlockCipher
	{
		// Token: 0x06001CFC RID: 7420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x52E5B50", Offset = "0x52E4750", VA = "0x1852E5B50")]
		public OaepEncoding(IAsymmetricBlockCipher cipher)
		{
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x52E5B30", Offset = "0x52E4730", VA = "0x1852E5B30")]
		public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash)
		{
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x52E5A10", Offset = "0x52E4610", VA = "0x1852E5A10")]
		public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash, byte[] encodingParams)
		{
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x52E58F0", Offset = "0x52E44F0", VA = "0x1852E58F0")]
		public OaepEncoding(IAsymmetricBlockCipher cipher, IDigest hash, IDigest mgf1Hash, byte[] encodingParams)
		{
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
		public IAsymmetricBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FB")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001D01")]
			[Address(RVA = "0x52E5BD0", Offset = "0x52E47D0", VA = "0x1852E5BD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x52E5730", Offset = "0x52E4330", VA = "0x1852E5730", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters param)
		{
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x52E5650", Offset = "0x52E4250", VA = "0x1852E5650", Slot = "6")]
		public int GetInputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x52E56C0", Offset = "0x52E42C0", VA = "0x1852E56C0", Slot = "7")]
		public int GetOutputBlockSize()
		{
			return 0;
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x52E58C0", Offset = "0x52E44C0", VA = "0x1852E58C0", Slot = "8")]
		public byte[] ProcessBlock(byte[] inBytes, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x52E5350", Offset = "0x52E3F50", VA = "0x1852E5350")]
		private byte[] EncodeBlock(byte[] inBytes, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x52E4F00", Offset = "0x52E3B00", VA = "0x1852E4F00")]
		private byte[] DecodeBlock(byte[] inBytes, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x52697D0", Offset = "0x52683D0", VA = "0x1852697D0")]
		private void ItoOSP(int i, byte[] sp)
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x52E5C40", Offset = "0x52E4840", VA = "0x1852E5C40")]
		private byte[] maskGeneratorFunction1(byte[] Z, int zOff, int zLen, int length)
		{
			return null;
		}

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x10")]
		private byte[] defHash;

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x18")]
		private IDigest hash;

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x20")]
		private IDigest mgf1Hash;

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x28")]
		private IAsymmetricBlockCipher engine;

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x30")]
		private SecureRandom random;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x38")]
		private bool forEncryption;
	}
}
