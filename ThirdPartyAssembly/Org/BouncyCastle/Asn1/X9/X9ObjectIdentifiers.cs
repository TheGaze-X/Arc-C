using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	public abstract class X9ObjectIdentifiers
	{
		// Token: 0x060021D2 RID: 8658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X9ObjectIdentifiers()
		{
		}

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		internal const string AnsiX962 = "1.2.840.10045";

		// Token: 0x0400118E RID: 4494
		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerObjectIdentifier ansi_X9_62;

		// Token: 0x0400118F RID: 4495
		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DerObjectIdentifier IdFieldType;

		// Token: 0x04001190 RID: 4496
		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DerObjectIdentifier PrimeField;

		// Token: 0x04001191 RID: 4497
		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DerObjectIdentifier CharacteristicTwoField;

		// Token: 0x04001192 RID: 4498
		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x20")]
		public static readonly DerObjectIdentifier GNBasis;

		// Token: 0x04001193 RID: 4499
		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x28")]
		public static readonly DerObjectIdentifier TPBasis;

		// Token: 0x04001194 RID: 4500
		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x30")]
		public static readonly DerObjectIdentifier PPBasis;

		// Token: 0x04001195 RID: 4501
		[Token(Token = "0x4001195")]
		[Obsolete("Use 'id_ecSigType' instead")]
		public const string IdECSigType = "1.2.840.10045.4";

		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x38")]
		public static readonly DerObjectIdentifier id_ecSigType;

		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x40")]
		public static readonly DerObjectIdentifier ECDsaWithSha1;

		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001198")]
		[Obsolete("Use 'id_publicKeyType' instead")]
		public const string IdPublicKeyType = "1.2.840.10045.2";

		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001199")]
		[FieldOffset(Offset = "0x48")]
		public static readonly DerObjectIdentifier id_publicKeyType;

		// Token: 0x0400119A RID: 4506
		[Token(Token = "0x400119A")]
		[FieldOffset(Offset = "0x50")]
		public static readonly DerObjectIdentifier IdECPublicKey;

		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		[FieldOffset(Offset = "0x58")]
		public static readonly DerObjectIdentifier ECDsaWithSha2;

		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		[FieldOffset(Offset = "0x60")]
		public static readonly DerObjectIdentifier ECDsaWithSha224;

		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		[FieldOffset(Offset = "0x68")]
		public static readonly DerObjectIdentifier ECDsaWithSha256;

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x70")]
		public static readonly DerObjectIdentifier ECDsaWithSha384;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x78")]
		public static readonly DerObjectIdentifier ECDsaWithSha512;

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x80")]
		public static readonly DerObjectIdentifier EllipticCurve;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		[FieldOffset(Offset = "0x88")]
		public static readonly DerObjectIdentifier CTwoCurve;

		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		[FieldOffset(Offset = "0x90")]
		public static readonly DerObjectIdentifier C2Pnb163v1;

		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		[FieldOffset(Offset = "0x98")]
		public static readonly DerObjectIdentifier C2Pnb163v2;

		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x40011A4")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly DerObjectIdentifier C2Pnb163v3;

		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x40011A5")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly DerObjectIdentifier C2Pnb176w1;

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly DerObjectIdentifier C2Tnb191v1;

		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x40011A7")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly DerObjectIdentifier C2Tnb191v2;

		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x40011A8")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly DerObjectIdentifier C2Tnb191v3;

		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x40011A9")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly DerObjectIdentifier C2Onb191v4;

		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x40011AA")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly DerObjectIdentifier C2Onb191v5;

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly DerObjectIdentifier C2Pnb208w1;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly DerObjectIdentifier C2Tnb239v1;

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly DerObjectIdentifier C2Tnb239v2;

		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x40011AE")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly DerObjectIdentifier C2Tnb239v3;

		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x40011AF")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly DerObjectIdentifier C2Onb239v4;

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x100")]
		public static readonly DerObjectIdentifier C2Onb239v5;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x108")]
		public static readonly DerObjectIdentifier C2Pnb272w1;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x110")]
		public static readonly DerObjectIdentifier C2Pnb304w1;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0x118")]
		public static readonly DerObjectIdentifier C2Tnb359v1;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x120")]
		public static readonly DerObjectIdentifier C2Pnb368w1;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x128")]
		public static readonly DerObjectIdentifier C2Tnb431r1;

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		[FieldOffset(Offset = "0x130")]
		public static readonly DerObjectIdentifier PrimeCurve;

		// Token: 0x040011B7 RID: 4535
		[Token(Token = "0x40011B7")]
		[FieldOffset(Offset = "0x138")]
		public static readonly DerObjectIdentifier Prime192v1;

		// Token: 0x040011B8 RID: 4536
		[Token(Token = "0x40011B8")]
		[FieldOffset(Offset = "0x140")]
		public static readonly DerObjectIdentifier Prime192v2;

		// Token: 0x040011B9 RID: 4537
		[Token(Token = "0x40011B9")]
		[FieldOffset(Offset = "0x148")]
		public static readonly DerObjectIdentifier Prime192v3;

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x40011BA")]
		[FieldOffset(Offset = "0x150")]
		public static readonly DerObjectIdentifier Prime239v1;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x40011BB")]
		[FieldOffset(Offset = "0x158")]
		public static readonly DerObjectIdentifier Prime239v2;

		// Token: 0x040011BC RID: 4540
		[Token(Token = "0x40011BC")]
		[FieldOffset(Offset = "0x160")]
		public static readonly DerObjectIdentifier Prime239v3;

		// Token: 0x040011BD RID: 4541
		[Token(Token = "0x40011BD")]
		[FieldOffset(Offset = "0x168")]
		public static readonly DerObjectIdentifier Prime256v1;

		// Token: 0x040011BE RID: 4542
		[Token(Token = "0x40011BE")]
		[FieldOffset(Offset = "0x170")]
		public static readonly DerObjectIdentifier IdDsa;

		// Token: 0x040011BF RID: 4543
		[Token(Token = "0x40011BF")]
		[FieldOffset(Offset = "0x178")]
		public static readonly DerObjectIdentifier IdDsaWithSha1;

		// Token: 0x040011C0 RID: 4544
		[Token(Token = "0x40011C0")]
		[FieldOffset(Offset = "0x180")]
		public static readonly DerObjectIdentifier X9x63Scheme;

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x188")]
		public static readonly DerObjectIdentifier DHSinglePassStdDHSha1KdfScheme;

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x190")]
		public static readonly DerObjectIdentifier DHSinglePassCofactorDHSha1KdfScheme;

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x198")]
		public static readonly DerObjectIdentifier MqvSinglePassSha1KdfScheme;

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x1A0")]
		public static readonly DerObjectIdentifier ansi_x9_42;

		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x1A8")]
		public static readonly DerObjectIdentifier DHPublicNumber;

		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x1B0")]
		public static readonly DerObjectIdentifier X9x42Schemes;

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x1B8")]
		public static readonly DerObjectIdentifier DHStatic;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x1C0")]
		public static readonly DerObjectIdentifier DHEphem;

		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x1C8")]
		public static readonly DerObjectIdentifier DHOneFlow;

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x1D0")]
		public static readonly DerObjectIdentifier DHHybrid1;

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x1D8")]
		public static readonly DerObjectIdentifier DHHybrid2;

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x1E0")]
		public static readonly DerObjectIdentifier DHHybridOneFlow;

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x1E8")]
		public static readonly DerObjectIdentifier Mqv2;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x1F0")]
		public static readonly DerObjectIdentifier Mqv1;
	}
}
