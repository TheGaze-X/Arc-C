using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x02000458 RID: 1112
	[Token(Token = "0x2000458")]
	public abstract class PkcsObjectIdentifiers
	{
		// Token: 0x060023B2 RID: 9138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PkcsObjectIdentifiers()
		{
		}

		// Token: 0x0400134E RID: 4942
		[Token(Token = "0x400134E")]
		public const string Pkcs1 = "1.2.840.113549.1.1";

		// Token: 0x0400134F RID: 4943
		[Token(Token = "0x400134F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerObjectIdentifier RsaEncryption;

		// Token: 0x04001350 RID: 4944
		[Token(Token = "0x4001350")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DerObjectIdentifier MD2WithRsaEncryption;

		// Token: 0x04001351 RID: 4945
		[Token(Token = "0x4001351")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DerObjectIdentifier MD4WithRsaEncryption;

		// Token: 0x04001352 RID: 4946
		[Token(Token = "0x4001352")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DerObjectIdentifier MD5WithRsaEncryption;

		// Token: 0x04001353 RID: 4947
		[Token(Token = "0x4001353")]
		[FieldOffset(Offset = "0x20")]
		public static readonly DerObjectIdentifier Sha1WithRsaEncryption;

		// Token: 0x04001354 RID: 4948
		[Token(Token = "0x4001354")]
		[FieldOffset(Offset = "0x28")]
		public static readonly DerObjectIdentifier SrsaOaepEncryptionSet;

		// Token: 0x04001355 RID: 4949
		[Token(Token = "0x4001355")]
		[FieldOffset(Offset = "0x30")]
		public static readonly DerObjectIdentifier IdRsaesOaep;

		// Token: 0x04001356 RID: 4950
		[Token(Token = "0x4001356")]
		[FieldOffset(Offset = "0x38")]
		public static readonly DerObjectIdentifier IdMgf1;

		// Token: 0x04001357 RID: 4951
		[Token(Token = "0x4001357")]
		[FieldOffset(Offset = "0x40")]
		public static readonly DerObjectIdentifier IdPSpecified;

		// Token: 0x04001358 RID: 4952
		[Token(Token = "0x4001358")]
		[FieldOffset(Offset = "0x48")]
		public static readonly DerObjectIdentifier IdRsassaPss;

		// Token: 0x04001359 RID: 4953
		[Token(Token = "0x4001359")]
		[FieldOffset(Offset = "0x50")]
		public static readonly DerObjectIdentifier Sha256WithRsaEncryption;

		// Token: 0x0400135A RID: 4954
		[Token(Token = "0x400135A")]
		[FieldOffset(Offset = "0x58")]
		public static readonly DerObjectIdentifier Sha384WithRsaEncryption;

		// Token: 0x0400135B RID: 4955
		[Token(Token = "0x400135B")]
		[FieldOffset(Offset = "0x60")]
		public static readonly DerObjectIdentifier Sha512WithRsaEncryption;

		// Token: 0x0400135C RID: 4956
		[Token(Token = "0x400135C")]
		[FieldOffset(Offset = "0x68")]
		public static readonly DerObjectIdentifier Sha224WithRsaEncryption;

		// Token: 0x0400135D RID: 4957
		[Token(Token = "0x400135D")]
		public const string Pkcs3 = "1.2.840.113549.1.3";

		// Token: 0x0400135E RID: 4958
		[Token(Token = "0x400135E")]
		[FieldOffset(Offset = "0x70")]
		public static readonly DerObjectIdentifier DhKeyAgreement;

		// Token: 0x0400135F RID: 4959
		[Token(Token = "0x400135F")]
		public const string Pkcs5 = "1.2.840.113549.1.5";

		// Token: 0x04001360 RID: 4960
		[Token(Token = "0x4001360")]
		[FieldOffset(Offset = "0x78")]
		public static readonly DerObjectIdentifier PbeWithMD2AndDesCbc;

		// Token: 0x04001361 RID: 4961
		[Token(Token = "0x4001361")]
		[FieldOffset(Offset = "0x80")]
		public static readonly DerObjectIdentifier PbeWithMD2AndRC2Cbc;

		// Token: 0x04001362 RID: 4962
		[Token(Token = "0x4001362")]
		[FieldOffset(Offset = "0x88")]
		public static readonly DerObjectIdentifier PbeWithMD5AndDesCbc;

		// Token: 0x04001363 RID: 4963
		[Token(Token = "0x4001363")]
		[FieldOffset(Offset = "0x90")]
		public static readonly DerObjectIdentifier PbeWithMD5AndRC2Cbc;

		// Token: 0x04001364 RID: 4964
		[Token(Token = "0x4001364")]
		[FieldOffset(Offset = "0x98")]
		public static readonly DerObjectIdentifier PbeWithSha1AndDesCbc;

		// Token: 0x04001365 RID: 4965
		[Token(Token = "0x4001365")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly DerObjectIdentifier PbeWithSha1AndRC2Cbc;

		// Token: 0x04001366 RID: 4966
		[Token(Token = "0x4001366")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly DerObjectIdentifier IdPbeS2;

		// Token: 0x04001367 RID: 4967
		[Token(Token = "0x4001367")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly DerObjectIdentifier IdPbkdf2;

		// Token: 0x04001368 RID: 4968
		[Token(Token = "0x4001368")]
		public const string EncryptionAlgorithm = "1.2.840.113549.3";

		// Token: 0x04001369 RID: 4969
		[Token(Token = "0x4001369")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly DerObjectIdentifier DesEde3Cbc;

		// Token: 0x0400136A RID: 4970
		[Token(Token = "0x400136A")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly DerObjectIdentifier RC2Cbc;

		// Token: 0x0400136B RID: 4971
		[Token(Token = "0x400136B")]
		public const string DigestAlgorithm = "1.2.840.113549.2";

		// Token: 0x0400136C RID: 4972
		[Token(Token = "0x400136C")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly DerObjectIdentifier MD2;

		// Token: 0x0400136D RID: 4973
		[Token(Token = "0x400136D")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly DerObjectIdentifier MD4;

		// Token: 0x0400136E RID: 4974
		[Token(Token = "0x400136E")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly DerObjectIdentifier MD5;

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly DerObjectIdentifier IdHmacWithSha1;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly DerObjectIdentifier IdHmacWithSha224;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly DerObjectIdentifier IdHmacWithSha256;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4001372")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly DerObjectIdentifier IdHmacWithSha384;

		// Token: 0x04001373 RID: 4979
		[Token(Token = "0x4001373")]
		[FieldOffset(Offset = "0x100")]
		public static readonly DerObjectIdentifier IdHmacWithSha512;

		// Token: 0x04001374 RID: 4980
		[Token(Token = "0x4001374")]
		public const string Pkcs7 = "1.2.840.113549.1.7";

		// Token: 0x04001375 RID: 4981
		[Token(Token = "0x4001375")]
		[FieldOffset(Offset = "0x108")]
		public static readonly DerObjectIdentifier Data;

		// Token: 0x04001376 RID: 4982
		[Token(Token = "0x4001376")]
		[FieldOffset(Offset = "0x110")]
		public static readonly DerObjectIdentifier SignedData;

		// Token: 0x04001377 RID: 4983
		[Token(Token = "0x4001377")]
		[FieldOffset(Offset = "0x118")]
		public static readonly DerObjectIdentifier EnvelopedData;

		// Token: 0x04001378 RID: 4984
		[Token(Token = "0x4001378")]
		[FieldOffset(Offset = "0x120")]
		public static readonly DerObjectIdentifier SignedAndEnvelopedData;

		// Token: 0x04001379 RID: 4985
		[Token(Token = "0x4001379")]
		[FieldOffset(Offset = "0x128")]
		public static readonly DerObjectIdentifier DigestedData;

		// Token: 0x0400137A RID: 4986
		[Token(Token = "0x400137A")]
		[FieldOffset(Offset = "0x130")]
		public static readonly DerObjectIdentifier EncryptedData;

		// Token: 0x0400137B RID: 4987
		[Token(Token = "0x400137B")]
		public const string Pkcs9 = "1.2.840.113549.1.9";

		// Token: 0x0400137C RID: 4988
		[Token(Token = "0x400137C")]
		[FieldOffset(Offset = "0x138")]
		public static readonly DerObjectIdentifier Pkcs9AtEmailAddress;

		// Token: 0x0400137D RID: 4989
		[Token(Token = "0x400137D")]
		[FieldOffset(Offset = "0x140")]
		public static readonly DerObjectIdentifier Pkcs9AtUnstructuredName;

		// Token: 0x0400137E RID: 4990
		[Token(Token = "0x400137E")]
		[FieldOffset(Offset = "0x148")]
		public static readonly DerObjectIdentifier Pkcs9AtContentType;

		// Token: 0x0400137F RID: 4991
		[Token(Token = "0x400137F")]
		[FieldOffset(Offset = "0x150")]
		public static readonly DerObjectIdentifier Pkcs9AtMessageDigest;

		// Token: 0x04001380 RID: 4992
		[Token(Token = "0x4001380")]
		[FieldOffset(Offset = "0x158")]
		public static readonly DerObjectIdentifier Pkcs9AtSigningTime;

		// Token: 0x04001381 RID: 4993
		[Token(Token = "0x4001381")]
		[FieldOffset(Offset = "0x160")]
		public static readonly DerObjectIdentifier Pkcs9AtCounterSignature;

		// Token: 0x04001382 RID: 4994
		[Token(Token = "0x4001382")]
		[FieldOffset(Offset = "0x168")]
		public static readonly DerObjectIdentifier Pkcs9AtChallengePassword;

		// Token: 0x04001383 RID: 4995
		[Token(Token = "0x4001383")]
		[FieldOffset(Offset = "0x170")]
		public static readonly DerObjectIdentifier Pkcs9AtUnstructuredAddress;

		// Token: 0x04001384 RID: 4996
		[Token(Token = "0x4001384")]
		[FieldOffset(Offset = "0x178")]
		public static readonly DerObjectIdentifier Pkcs9AtExtendedCertificateAttributes;

		// Token: 0x04001385 RID: 4997
		[Token(Token = "0x4001385")]
		[FieldOffset(Offset = "0x180")]
		public static readonly DerObjectIdentifier Pkcs9AtSigningDescription;

		// Token: 0x04001386 RID: 4998
		[Token(Token = "0x4001386")]
		[FieldOffset(Offset = "0x188")]
		public static readonly DerObjectIdentifier Pkcs9AtExtensionRequest;

		// Token: 0x04001387 RID: 4999
		[Token(Token = "0x4001387")]
		[FieldOffset(Offset = "0x190")]
		public static readonly DerObjectIdentifier Pkcs9AtSmimeCapabilities;

		// Token: 0x04001388 RID: 5000
		[Token(Token = "0x4001388")]
		[FieldOffset(Offset = "0x198")]
		public static readonly DerObjectIdentifier IdSmime;

		// Token: 0x04001389 RID: 5001
		[Token(Token = "0x4001389")]
		[FieldOffset(Offset = "0x1A0")]
		public static readonly DerObjectIdentifier Pkcs9AtFriendlyName;

		// Token: 0x0400138A RID: 5002
		[Token(Token = "0x400138A")]
		[FieldOffset(Offset = "0x1A8")]
		public static readonly DerObjectIdentifier Pkcs9AtLocalKeyID;

		// Token: 0x0400138B RID: 5003
		[Token(Token = "0x400138B")]
		[FieldOffset(Offset = "0x1B0")]
		[Obsolete("Use X509Certificate instead")]
		public static readonly DerObjectIdentifier X509CertType;

		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		public const string CertTypes = "1.2.840.113549.1.9.22";

		// Token: 0x0400138D RID: 5005
		[Token(Token = "0x400138D")]
		[FieldOffset(Offset = "0x1B8")]
		public static readonly DerObjectIdentifier X509Certificate;

		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		[FieldOffset(Offset = "0x1C0")]
		public static readonly DerObjectIdentifier SdsiCertificate;

		// Token: 0x0400138F RID: 5007
		[Token(Token = "0x400138F")]
		public const string CrlTypes = "1.2.840.113549.1.9.23";

		// Token: 0x04001390 RID: 5008
		[Token(Token = "0x4001390")]
		[FieldOffset(Offset = "0x1C8")]
		public static readonly DerObjectIdentifier X509Crl;

		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4001391")]
		[FieldOffset(Offset = "0x1D0")]
		public static readonly DerObjectIdentifier IdAlg;

		// Token: 0x04001392 RID: 5010
		[Token(Token = "0x4001392")]
		[FieldOffset(Offset = "0x1D8")]
		public static readonly DerObjectIdentifier IdAlgEsdh;

		// Token: 0x04001393 RID: 5011
		[Token(Token = "0x4001393")]
		[FieldOffset(Offset = "0x1E0")]
		public static readonly DerObjectIdentifier IdAlgCms3DesWrap;

		// Token: 0x04001394 RID: 5012
		[Token(Token = "0x4001394")]
		[FieldOffset(Offset = "0x1E8")]
		public static readonly DerObjectIdentifier IdAlgCmsRC2Wrap;

		// Token: 0x04001395 RID: 5013
		[Token(Token = "0x4001395")]
		[FieldOffset(Offset = "0x1F0")]
		public static readonly DerObjectIdentifier IdAlgPwriKek;

		// Token: 0x04001396 RID: 5014
		[Token(Token = "0x4001396")]
		[FieldOffset(Offset = "0x1F8")]
		public static readonly DerObjectIdentifier IdAlgSsdh;

		// Token: 0x04001397 RID: 5015
		[Token(Token = "0x4001397")]
		[FieldOffset(Offset = "0x200")]
		public static readonly DerObjectIdentifier IdRsaKem;

		// Token: 0x04001398 RID: 5016
		[Token(Token = "0x4001398")]
		[FieldOffset(Offset = "0x208")]
		public static readonly DerObjectIdentifier PreferSignedData;

		// Token: 0x04001399 RID: 5017
		[Token(Token = "0x4001399")]
		[FieldOffset(Offset = "0x210")]
		public static readonly DerObjectIdentifier CannotDecryptAny;

		// Token: 0x0400139A RID: 5018
		[Token(Token = "0x400139A")]
		[FieldOffset(Offset = "0x218")]
		public static readonly DerObjectIdentifier SmimeCapabilitiesVersions;

		// Token: 0x0400139B RID: 5019
		[Token(Token = "0x400139B")]
		[FieldOffset(Offset = "0x220")]
		public static readonly DerObjectIdentifier IdAAReceiptRequest;

		// Token: 0x0400139C RID: 5020
		[Token(Token = "0x400139C")]
		public const string IdCT = "1.2.840.113549.1.9.16.1";

		// Token: 0x0400139D RID: 5021
		[Token(Token = "0x400139D")]
		[FieldOffset(Offset = "0x228")]
		public static readonly DerObjectIdentifier IdCTAuthData;

		// Token: 0x0400139E RID: 5022
		[Token(Token = "0x400139E")]
		[FieldOffset(Offset = "0x230")]
		public static readonly DerObjectIdentifier IdCTTstInfo;

		// Token: 0x0400139F RID: 5023
		[Token(Token = "0x400139F")]
		[FieldOffset(Offset = "0x238")]
		public static readonly DerObjectIdentifier IdCTCompressedData;

		// Token: 0x040013A0 RID: 5024
		[Token(Token = "0x40013A0")]
		[FieldOffset(Offset = "0x240")]
		public static readonly DerObjectIdentifier IdCTAuthEnvelopedData;

		// Token: 0x040013A1 RID: 5025
		[Token(Token = "0x40013A1")]
		[FieldOffset(Offset = "0x248")]
		public static readonly DerObjectIdentifier IdCTTimestampedData;

		// Token: 0x040013A2 RID: 5026
		[Token(Token = "0x40013A2")]
		public const string IdCti = "1.2.840.113549.1.9.16.6";

		// Token: 0x040013A3 RID: 5027
		[Token(Token = "0x40013A3")]
		[FieldOffset(Offset = "0x250")]
		public static readonly DerObjectIdentifier IdCtiEtsProofOfOrigin;

		// Token: 0x040013A4 RID: 5028
		[Token(Token = "0x40013A4")]
		[FieldOffset(Offset = "0x258")]
		public static readonly DerObjectIdentifier IdCtiEtsProofOfReceipt;

		// Token: 0x040013A5 RID: 5029
		[Token(Token = "0x40013A5")]
		[FieldOffset(Offset = "0x260")]
		public static readonly DerObjectIdentifier IdCtiEtsProofOfDelivery;

		// Token: 0x040013A6 RID: 5030
		[Token(Token = "0x40013A6")]
		[FieldOffset(Offset = "0x268")]
		public static readonly DerObjectIdentifier IdCtiEtsProofOfSender;

		// Token: 0x040013A7 RID: 5031
		[Token(Token = "0x40013A7")]
		[FieldOffset(Offset = "0x270")]
		public static readonly DerObjectIdentifier IdCtiEtsProofOfApproval;

		// Token: 0x040013A8 RID: 5032
		[Token(Token = "0x40013A8")]
		[FieldOffset(Offset = "0x278")]
		public static readonly DerObjectIdentifier IdCtiEtsProofOfCreation;

		// Token: 0x040013A9 RID: 5033
		[Token(Token = "0x40013A9")]
		public const string IdAA = "1.2.840.113549.1.9.16.2";

		// Token: 0x040013AA RID: 5034
		[Token(Token = "0x40013AA")]
		[FieldOffset(Offset = "0x280")]
		public static readonly DerObjectIdentifier IdAAContentHint;

		// Token: 0x040013AB RID: 5035
		[Token(Token = "0x40013AB")]
		[FieldOffset(Offset = "0x288")]
		public static readonly DerObjectIdentifier IdAAMsgSigDigest;

		// Token: 0x040013AC RID: 5036
		[Token(Token = "0x40013AC")]
		[FieldOffset(Offset = "0x290")]
		public static readonly DerObjectIdentifier IdAAContentReference;

		// Token: 0x040013AD RID: 5037
		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0x298")]
		public static readonly DerObjectIdentifier IdAAEncrypKeyPref;

		// Token: 0x040013AE RID: 5038
		[Token(Token = "0x40013AE")]
		[FieldOffset(Offset = "0x2A0")]
		public static readonly DerObjectIdentifier IdAASigningCertificate;

		// Token: 0x040013AF RID: 5039
		[Token(Token = "0x40013AF")]
		[FieldOffset(Offset = "0x2A8")]
		public static readonly DerObjectIdentifier IdAASigningCertificateV2;

		// Token: 0x040013B0 RID: 5040
		[Token(Token = "0x40013B0")]
		[FieldOffset(Offset = "0x2B0")]
		public static readonly DerObjectIdentifier IdAAContentIdentifier;

		// Token: 0x040013B1 RID: 5041
		[Token(Token = "0x40013B1")]
		[FieldOffset(Offset = "0x2B8")]
		public static readonly DerObjectIdentifier IdAASignatureTimeStampToken;

		// Token: 0x040013B2 RID: 5042
		[Token(Token = "0x40013B2")]
		[FieldOffset(Offset = "0x2C0")]
		public static readonly DerObjectIdentifier IdAAEtsSigPolicyID;

		// Token: 0x040013B3 RID: 5043
		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0x2C8")]
		public static readonly DerObjectIdentifier IdAAEtsCommitmentType;

		// Token: 0x040013B4 RID: 5044
		[Token(Token = "0x40013B4")]
		[FieldOffset(Offset = "0x2D0")]
		public static readonly DerObjectIdentifier IdAAEtsSignerLocation;

		// Token: 0x040013B5 RID: 5045
		[Token(Token = "0x40013B5")]
		[FieldOffset(Offset = "0x2D8")]
		public static readonly DerObjectIdentifier IdAAEtsSignerAttr;

		// Token: 0x040013B6 RID: 5046
		[Token(Token = "0x40013B6")]
		[FieldOffset(Offset = "0x2E0")]
		public static readonly DerObjectIdentifier IdAAEtsOtherSigCert;

		// Token: 0x040013B7 RID: 5047
		[Token(Token = "0x40013B7")]
		[FieldOffset(Offset = "0x2E8")]
		public static readonly DerObjectIdentifier IdAAEtsContentTimestamp;

		// Token: 0x040013B8 RID: 5048
		[Token(Token = "0x40013B8")]
		[FieldOffset(Offset = "0x2F0")]
		public static readonly DerObjectIdentifier IdAAEtsCertificateRefs;

		// Token: 0x040013B9 RID: 5049
		[Token(Token = "0x40013B9")]
		[FieldOffset(Offset = "0x2F8")]
		public static readonly DerObjectIdentifier IdAAEtsRevocationRefs;

		// Token: 0x040013BA RID: 5050
		[Token(Token = "0x40013BA")]
		[FieldOffset(Offset = "0x300")]
		public static readonly DerObjectIdentifier IdAAEtsCertValues;

		// Token: 0x040013BB RID: 5051
		[Token(Token = "0x40013BB")]
		[FieldOffset(Offset = "0x308")]
		public static readonly DerObjectIdentifier IdAAEtsRevocationValues;

		// Token: 0x040013BC RID: 5052
		[Token(Token = "0x40013BC")]
		[FieldOffset(Offset = "0x310")]
		public static readonly DerObjectIdentifier IdAAEtsEscTimeStamp;

		// Token: 0x040013BD RID: 5053
		[Token(Token = "0x40013BD")]
		[FieldOffset(Offset = "0x318")]
		public static readonly DerObjectIdentifier IdAAEtsCertCrlTimestamp;

		// Token: 0x040013BE RID: 5054
		[Token(Token = "0x40013BE")]
		[FieldOffset(Offset = "0x320")]
		public static readonly DerObjectIdentifier IdAAEtsArchiveTimestamp;

		// Token: 0x040013BF RID: 5055
		[Token(Token = "0x40013BF")]
		[FieldOffset(Offset = "0x328")]
		[Obsolete("Use 'IdAAEtsSigPolicyID' instead")]
		public static readonly DerObjectIdentifier IdAASigPolicyID;

		// Token: 0x040013C0 RID: 5056
		[Token(Token = "0x40013C0")]
		[FieldOffset(Offset = "0x330")]
		[Obsolete("Use 'IdAAEtsCommitmentType' instead")]
		public static readonly DerObjectIdentifier IdAACommitmentType;

		// Token: 0x040013C1 RID: 5057
		[Token(Token = "0x40013C1")]
		[FieldOffset(Offset = "0x338")]
		[Obsolete("Use 'IdAAEtsSignerLocation' instead")]
		public static readonly DerObjectIdentifier IdAASignerLocation;

		// Token: 0x040013C2 RID: 5058
		[Token(Token = "0x40013C2")]
		[FieldOffset(Offset = "0x340")]
		[Obsolete("Use 'IdAAEtsOtherSigCert' instead")]
		public static readonly DerObjectIdentifier IdAAOtherSigCert;

		// Token: 0x040013C3 RID: 5059
		[Token(Token = "0x40013C3")]
		public const string IdSpq = "1.2.840.113549.1.9.16.5";

		// Token: 0x040013C4 RID: 5060
		[Token(Token = "0x40013C4")]
		[FieldOffset(Offset = "0x348")]
		public static readonly DerObjectIdentifier IdSpqEtsUri;

		// Token: 0x040013C5 RID: 5061
		[Token(Token = "0x40013C5")]
		[FieldOffset(Offset = "0x350")]
		public static readonly DerObjectIdentifier IdSpqEtsUNotice;

		// Token: 0x040013C6 RID: 5062
		[Token(Token = "0x40013C6")]
		public const string Pkcs12 = "1.2.840.113549.1.12";

		// Token: 0x040013C7 RID: 5063
		[Token(Token = "0x40013C7")]
		public const string BagTypes = "1.2.840.113549.1.12.10.1";

		// Token: 0x040013C8 RID: 5064
		[Token(Token = "0x40013C8")]
		[FieldOffset(Offset = "0x358")]
		public static readonly DerObjectIdentifier KeyBag;

		// Token: 0x040013C9 RID: 5065
		[Token(Token = "0x40013C9")]
		[FieldOffset(Offset = "0x360")]
		public static readonly DerObjectIdentifier Pkcs8ShroudedKeyBag;

		// Token: 0x040013CA RID: 5066
		[Token(Token = "0x40013CA")]
		[FieldOffset(Offset = "0x368")]
		public static readonly DerObjectIdentifier CertBag;

		// Token: 0x040013CB RID: 5067
		[Token(Token = "0x40013CB")]
		[FieldOffset(Offset = "0x370")]
		public static readonly DerObjectIdentifier CrlBag;

		// Token: 0x040013CC RID: 5068
		[Token(Token = "0x40013CC")]
		[FieldOffset(Offset = "0x378")]
		public static readonly DerObjectIdentifier SecretBag;

		// Token: 0x040013CD RID: 5069
		[Token(Token = "0x40013CD")]
		[FieldOffset(Offset = "0x380")]
		public static readonly DerObjectIdentifier SafeContentsBag;

		// Token: 0x040013CE RID: 5070
		[Token(Token = "0x40013CE")]
		public const string Pkcs12PbeIds = "1.2.840.113549.1.12.1";

		// Token: 0x040013CF RID: 5071
		[Token(Token = "0x40013CF")]
		[FieldOffset(Offset = "0x388")]
		public static readonly DerObjectIdentifier PbeWithShaAnd128BitRC4;

		// Token: 0x040013D0 RID: 5072
		[Token(Token = "0x40013D0")]
		[FieldOffset(Offset = "0x390")]
		public static readonly DerObjectIdentifier PbeWithShaAnd40BitRC4;

		// Token: 0x040013D1 RID: 5073
		[Token(Token = "0x40013D1")]
		[FieldOffset(Offset = "0x398")]
		public static readonly DerObjectIdentifier PbeWithShaAnd3KeyTripleDesCbc;

		// Token: 0x040013D2 RID: 5074
		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x3A0")]
		public static readonly DerObjectIdentifier PbeWithShaAnd2KeyTripleDesCbc;

		// Token: 0x040013D3 RID: 5075
		[Token(Token = "0x40013D3")]
		[FieldOffset(Offset = "0x3A8")]
		public static readonly DerObjectIdentifier PbeWithShaAnd128BitRC2Cbc;

		// Token: 0x040013D4 RID: 5076
		[Token(Token = "0x40013D4")]
		[FieldOffset(Offset = "0x3B0")]
		public static readonly DerObjectIdentifier PbewithShaAnd40BitRC2Cbc;
	}
}
