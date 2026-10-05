using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200046B")]
	public class Gost3410ParamSetParameters : Asn1Encodable
	{
		// Token: 0x0600240A RID: 9226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x5363C10", Offset = "0x5362810", VA = "0x185363C10")]
		public static Gost3410ParamSetParameters GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x5363C30", Offset = "0x5362830", VA = "0x185363C30")]
		public static Gost3410ParamSetParameters GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x5364250", Offset = "0x5362E50", VA = "0x185364250")]
		public Gost3410ParamSetParameters(int keySize, BigInteger p, BigInteger q, BigInteger a)
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x5364060", Offset = "0x5362C60", VA = "0x185364060")]
		private Gost3410ParamSetParameters(Asn1Sequence seq)
		{
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x170004BF")]
		public int KeySize
		{
			[Token(Token = "0x600240E")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C0")]
		public BigInteger P
		{
			[Token(Token = "0x600240F")]
			[Address(RVA = "0x53615A0", Offset = "0x53601A0", VA = "0x1853615A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C1")]
		public BigInteger Q
		{
			[Token(Token = "0x6002410")]
			[Address(RVA = "0x5364370", Offset = "0x5362F70", VA = "0x185364370")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C2")]
		public BigInteger A
		{
			[Token(Token = "0x6002411")]
			[Address(RVA = "0x5364350", Offset = "0x5362F50", VA = "0x185364350")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x5363E60", Offset = "0x5362A60", VA = "0x185363E60", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001474 RID: 5236
		[Token(Token = "0x4001474")]
		[FieldOffset(Offset = "0x10")]
		private readonly int keySize;

		// Token: 0x04001475 RID: 5237
		[Token(Token = "0x4001475")]
		[FieldOffset(Offset = "0x18")]
		private readonly DerInteger p;

		// Token: 0x04001476 RID: 5238
		[Token(Token = "0x4001476")]
		[FieldOffset(Offset = "0x20")]
		private readonly DerInteger q;

		// Token: 0x04001477 RID: 5239
		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0x28")]
		private readonly DerInteger a;
	}
}
