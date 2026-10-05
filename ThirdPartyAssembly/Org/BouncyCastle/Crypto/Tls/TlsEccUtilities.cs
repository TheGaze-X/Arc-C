using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000292 RID: 658
	[Token(Token = "0x2000292")]
	public abstract class TlsEccUtilities
	{
		// Token: 0x060015EE RID: 5614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x525BBA0", Offset = "0x525A7A0", VA = "0x18525BBA0")]
		public static void AddSupportedEllipticCurvesExtension(IDictionary extensions, int[] namedCurves)
		{
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x525BCE0", Offset = "0x525A8E0", VA = "0x18525BCE0")]
		public static void AddSupportedPointFormatsExtension(IDictionary extensions, byte[] ecPointFormats)
		{
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x525CE00", Offset = "0x525BA00", VA = "0x18525CE00")]
		public static int[] GetSupportedEllipticCurvesExtension(IDictionary extensions)
		{
			return null;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x525CE90", Offset = "0x525BA90", VA = "0x18525CE90")]
		public static byte[] GetSupportedPointFormatsExtension(IDictionary extensions)
		{
			return null;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x525C080", Offset = "0x525AC80", VA = "0x18525C080")]
		public static byte[] CreateSupportedEllipticCurvesExtension(int[] namedCurves)
		{
			return null;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x525C120", Offset = "0x525AD20", VA = "0x18525C120")]
		public static byte[] CreateSupportedPointFormatsExtension(byte[] ecPointFormats)
		{
			return null;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x525DA70", Offset = "0x525C670", VA = "0x18525DA70")]
		public static int[] ReadSupportedEllipticCurvesExtension(byte[] extensionData)
		{
			return null;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x525DC10", Offset = "0x525C810", VA = "0x18525DC10")]
		public static byte[] ReadSupportedPointFormatsExtension(byte[] extensionData)
		{
			return null;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x525CBA0", Offset = "0x525B7A0", VA = "0x18525CBA0")]
		public static string GetNameOfNamedCurve(int namedCurve)
		{
			return null;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x525CC40", Offset = "0x525B840", VA = "0x18525CC40")]
		public static ECDomainParameters GetParametersForNamedCurve(int namedCurve)
		{
			return null;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x525CF20", Offset = "0x525BB20", VA = "0x18525CF20")]
		public static bool HasAnySupportedNamedCurves()
		{
			return default(bool);
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x0000B208 File Offset: 0x00009408
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x525BFD0", Offset = "0x525ABD0", VA = "0x18525BFD0")]
		public static bool ContainsEccCipherSuites(int[] cipherSuites)
		{
			return default(bool);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x0000B220 File Offset: 0x00009420
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x525CFD0", Offset = "0x525BBD0", VA = "0x18525CFD0")]
		public static bool IsEccCipherSuite(int cipherSuite)
		{
			return default(bool);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x525BE00", Offset = "0x525AA00", VA = "0x18525BE00")]
		public static bool AreOnSameCurve(ECDomainParameters a, ECDomainParameters b)
		{
			return default(bool);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x525D060", Offset = "0x525BC60", VA = "0x18525D060")]
		public static bool IsSupportedNamedCurve(int namedCurve)
		{
			return default(bool);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x60015FD")]
		[Address(RVA = "0x525CF80", Offset = "0x525BB80", VA = "0x18525CF80")]
		public static bool IsCompressionPreferred(byte[] ecPointFormats, byte compressionFormat)
		{
			return default(bool);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FE")]
		[Address(RVA = "0x525DE00", Offset = "0x525CA00", VA = "0x18525DE00")]
		public static byte[] SerializeECFieldElement(int fieldSize, BigInteger x)
		{
			return null;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FF")]
		[Address(RVA = "0x525DE20", Offset = "0x525CA20", VA = "0x18525DE20")]
		public static byte[] SerializeECPoint(byte[] ecPointFormats, ECPoint point)
		{
			return null;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x525DF90", Offset = "0x525CB90", VA = "0x18525DF90")]
		public static byte[] SerializeECPublicKey(byte[] ecPointFormats, ECPublicKeyParameters keyParameters)
		{
			return null;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x525C190", Offset = "0x525AD90", VA = "0x18525C190")]
		public static BigInteger DeserializeECFieldElement(int fieldSize, byte[] encoding)
		{
			return null;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001602")]
		[Address(RVA = "0x525C250", Offset = "0x525AE50", VA = "0x18525C250")]
		public static ECPoint DeserializeECPoint(byte[] ecPointFormats, ECCurve curve, byte[] encoding)
		{
			return null;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001603")]
		[Address(RVA = "0x525C470", Offset = "0x525B070", VA = "0x18525C470")]
		public static ECPublicKeyParameters DeserializeECPublicKey(byte[] ecPointFormats, ECDomainParameters curve_params, byte[] encoding)
		{
			return null;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001604")]
		[Address(RVA = "0x525BE60", Offset = "0x525AA60", VA = "0x18525BE60")]
		public static byte[] CalculateECDHBasicAgreement(ECPublicKeyParameters publicKey, ECPrivateKeyParameters privateKey)
		{
			return null;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x525C5A0", Offset = "0x525B1A0", VA = "0x18525C5A0")]
		public static AsymmetricCipherKeyPair GenerateECKeyPair(SecureRandom random, ECDomainParameters ecParams)
		{
			return null;
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x525C660", Offset = "0x525B260", VA = "0x18525C660")]
		public static ECPrivateKeyParameters GenerateEphemeralClientKeyExchange(SecureRandom random, byte[] ecPointFormats, ECDomainParameters ecParams, Stream output)
		{
			return null;
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x525C8D0", Offset = "0x525B4D0", VA = "0x18525C8D0")]
		internal static ECPrivateKeyParameters GenerateEphemeralServerKeyExchange(SecureRandom random, int[] namedCurves, byte[] ecPointFormats, Stream output)
		{
			return null;
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001608")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		public static ECPublicKeyParameters ValidateECPublicKey(ECPublicKeyParameters key)
		{
			return null;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x525D0D0", Offset = "0x525BCD0", VA = "0x18525D0D0")]
		public static int ReadECExponent(int fieldSize, Stream input)
		{
			return 0;
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x525D1A0", Offset = "0x525BDA0", VA = "0x18525D1A0")]
		public static BigInteger ReadECFieldElement(int fieldSize, Stream input)
		{
			return null;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x525D2D0", Offset = "0x525BED0", VA = "0x18525D2D0")]
		public static BigInteger ReadECParameter(Stream input)
		{
			return null;
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x525D370", Offset = "0x525BF70", VA = "0x18525D370")]
		public static ECDomainParameters ReadECParameters(int[] namedCurves, byte[] ecPointFormats, Stream input)
		{
			return null;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160D")]
		[Address(RVA = "0x525BF60", Offset = "0x525AB60", VA = "0x18525BF60")]
		private static void CheckNamedCurve(int[] namedCurves, int namedCurve)
		{
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160E")]
		[Address(RVA = "0x525E000", Offset = "0x525CC00", VA = "0x18525E000")]
		public static void WriteECExponent(int k, Stream output)
		{
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600160F")]
		[Address(RVA = "0x525E0D0", Offset = "0x525CCD0", VA = "0x18525E0D0")]
		public static void WriteECFieldElement(ECFieldElement x, Stream output)
		{
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x525E160", Offset = "0x525CD60", VA = "0x18525E160")]
		public static void WriteECFieldElement(int fieldSize, BigInteger x, Stream output)
		{
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x525E210", Offset = "0x525CE10", VA = "0x18525E210")]
		public static void WriteECParameter(BigInteger x, Stream output)
		{
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x525E320", Offset = "0x525CF20", VA = "0x18525E320")]
		public static void WriteExplicitECParameters(byte[] ecPointFormats, ECDomainParameters ecParameters, Stream output)
		{
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001613")]
		[Address(RVA = "0x525E280", Offset = "0x525CE80", VA = "0x18525E280")]
		public static void WriteECPoint(byte[] ecPointFormats, ECPoint point, Stream output)
		{
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001614")]
		[Address(RVA = "0x525EA00", Offset = "0x525D600", VA = "0x18525EA00")]
		public static void WriteNamedECParameters(int namedCurve, Stream output)
		{
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001615")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TlsEccUtilities()
		{
		}

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] CurveNames;
	}
}
