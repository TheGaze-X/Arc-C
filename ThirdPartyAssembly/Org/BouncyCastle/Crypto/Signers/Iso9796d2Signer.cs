using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	public class Iso9796d2Signer : ISignerWithRecovery, ISigner
	{
		// Token: 0x060017DD RID: 6109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "5")]
		public byte[] GetRecoveredMessage()
		{
			return null;
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x5268650", Offset = "0x5267250", VA = "0x185268650")]
		public Iso9796d2Signer(IAsymmetricBlockCipher cipher, IDigest digest, bool isImplicit)
		{
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x5268780", Offset = "0x5267380", VA = "0x185268780")]
		public Iso9796d2Signer(IAsymmetricBlockCipher cipher, IDigest digest)
		{
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033C")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017E0")]
			[Address(RVA = "0x52688A0", Offset = "0x52674A0", VA = "0x1852688A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x52676F0", Offset = "0x52662F0", VA = "0x1852676F0", Slot = "15")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x5267900", Offset = "0x5266500", VA = "0x185267900")]
		private bool IsSameAs(byte[] a, byte[] b)
		{
			return default(bool);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x5267400", Offset = "0x5266000", VA = "0x185267400")]
		private void ClearBlock(byte[] block)
		{
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x5267AF0", Offset = "0x52666F0", VA = "0x185267AF0", Slot = "16")]
		public virtual void UpdateWithRecoveredMessage(byte[] signature)
		{
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x5267F70", Offset = "0x5266B70", VA = "0x185267F70", Slot = "17")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x5267300", Offset = "0x5265F00", VA = "0x185267300", Slot = "18")]
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x52679B0", Offset = "0x52665B0", VA = "0x1852679B0", Slot = "19")]
		public virtual void Reset()
		{
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E8")]
		[Address(RVA = "0x5267430", Offset = "0x5266030", VA = "0x185267430", Slot = "20")]
		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x5267FF0", Offset = "0x5266BF0", VA = "0x185267FF0", Slot = "21")]
		public virtual bool VerifySignature(byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0000BB08 File Offset: 0x00009D08
		[Token(Token = "0x60017EA")]
		[Address(RVA = "0x5267AA0", Offset = "0x52666A0", VA = "0x185267AA0")]
		private bool ReturnFalse(byte[] block)
		{
			return default(bool);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0000BB20 File Offset: 0x00009D20
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x1DBF210", Offset = "0x1DBDE10", VA = "0x181DBF210", Slot = "22")]
		public virtual bool HasFullMessage()
		{
			return default(bool);
		}

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerImplicit = 188;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerRipeMD160 = 12748;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerRipeMD128 = 13004;

		// Token: 0x04000CA5 RID: 3237
		[Token(Token = "0x4000CA5")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha1 = 13260;

		// Token: 0x04000CA6 RID: 3238
		[Token(Token = "0x4000CA6")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha256 = 13516;

		// Token: 0x04000CA7 RID: 3239
		[Token(Token = "0x4000CA7")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha512 = 13772;

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerSha384 = 14028;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[Obsolete("Use 'IsoTrailers' instead")]
		public const int TrailerWhirlpool = 14284;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x10")]
		private IDigest digest;

		// Token: 0x04000CAB RID: 3243
		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x18")]
		private IAsymmetricBlockCipher cipher;

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x20")]
		private int trailer;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x24")]
		private int keyBits;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x28")]
		private byte[] block;

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		[FieldOffset(Offset = "0x30")]
		private byte[] mBuf;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x38")]
		private int messageLength;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x3C")]
		private bool fullMessage;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x40")]
		private byte[] recoveredMessage;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x48")]
		private byte[] preSig;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x50")]
		private byte[] preBlock;
	}
}
