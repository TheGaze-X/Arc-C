using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	public abstract class TlsDHUtilities
	{
		// Token: 0x060015C9 RID: 5577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x5257840", Offset = "0x5256440", VA = "0x185257840")]
		private static BigInteger FromHex(string hex)
		{
			return null;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x52578E0", Offset = "0x52564E0", VA = "0x1852578E0")]
		private static DHParameters FromSafeP(string hexP)
		{
			return null;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x5257080", Offset = "0x5255C80", VA = "0x185257080")]
		public static void AddNegotiatedDheGroupsClientExtension(IDictionary extensions, byte[] dheGroups)
		{
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x5257200", Offset = "0x5255E00", VA = "0x185257200")]
		public static void AddNegotiatedDheGroupsServerExtension(IDictionary extensions, byte dheGroup)
		{
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x5257FA0", Offset = "0x5256BA0", VA = "0x185257FA0")]
		public static byte[] GetNegotiatedDheGroupsClientExtension(IDictionary extensions)
		{
			return null;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0000B130 File Offset: 0x00009330
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x5258180", Offset = "0x5256D80", VA = "0x185258180")]
		public static short GetNegotiatedDheGroupsServerExtension(IDictionary extensions)
		{
			return 0;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x5257740", Offset = "0x5256340", VA = "0x185257740")]
		public static byte[] CreateNegotiatedDheGroupsClientExtension(byte[] dheGroups)
		{
			return null;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x52577E0", Offset = "0x52563E0", VA = "0x1852577E0")]
		public static byte[] CreateNegotiatedDheGroupsServerExtension(byte dheGroup)
		{
			return null;
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x5258640", Offset = "0x5257240", VA = "0x185258640")]
		public static byte[] ReadNegotiatedDheGroupsClientExtension(byte[] extensionData)
		{
			return null;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x52587D0", Offset = "0x52573D0", VA = "0x1852587D0")]
		public static byte ReadNegotiatedDheGroupsServerExtension(byte[] extensionData)
		{
			return 0;
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x5258290", Offset = "0x5256E90", VA = "0x185258290")]
		public static DHParameters GetParametersForDHEGroup(short dheGroup)
		{
			return null;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0000B160 File Offset: 0x00009360
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x52574E0", Offset = "0x52560E0", VA = "0x1852574E0")]
		public static bool ContainsDheCipherSuites(int[] cipherSuites)
		{
			return default(bool);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0000B178 File Offset: 0x00009378
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x52583D0", Offset = "0x5256FD0", VA = "0x1852583D0")]
		public static bool IsDheCipherSuite(int cipherSuite)
		{
			return default(bool);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0000B190 File Offset: 0x00009390
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x5257330", Offset = "0x5255F30", VA = "0x185257330")]
		public static bool AreCompatibleParameters(DHParameters a, DHParameters b)
		{
			return default(bool);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x5257420", Offset = "0x5256020", VA = "0x185257420")]
		public static byte[] CalculateDHBasicAgreement(DHPublicKeyParameters publicKey, DHPrivateKeyParameters privateKey)
		{
			return null;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x5257A20", Offset = "0x5256620", VA = "0x185257A20")]
		public static AsymmetricCipherKeyPair GenerateDHKeyPair(SecureRandom random, DHParameters dhParams)
		{
			return null;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x5257B20", Offset = "0x5256720", VA = "0x185257B20")]
		public static DHPrivateKeyParameters GenerateEphemeralClientKeyExchange(SecureRandom random, DHParameters dhParams, Stream output)
		{
			return null;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x5257D50", Offset = "0x5256950", VA = "0x185257D50")]
		public static DHPrivateKeyParameters GenerateEphemeralServerKeyExchange(SecureRandom random, DHParameters dhParams, Stream output)
		{
			return null;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x5258880", Offset = "0x5257480", VA = "0x185258880")]
		public static DHParameters ValidateDHParameters(DHParameters parameters)
		{
			return null;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x5258A10", Offset = "0x5257610", VA = "0x185258A10")]
		public static DHPublicKeyParameters ValidateDHPublicKey(DHPublicKeyParameters key)
		{
			return null;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x52585A0", Offset = "0x52571A0", VA = "0x1852585A0")]
		public static BigInteger ReadDHParameter(Stream input)
		{
			return null;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x5258B50", Offset = "0x5257750", VA = "0x185258B50")]
		public static void WriteDHParameter(BigInteger x, Stream output)
		{
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TlsDHUtilities()
		{
		}

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly BigInteger Two;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string draft_ffdhe2432_p;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly DHParameters draft_ffdhe2432;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string draft_ffdhe3072_p;

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly DHParameters draft_ffdhe3072;

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string draft_ffdhe4096_p;

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly DHParameters draft_ffdhe4096;

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x38")]
		private static readonly string draft_ffdhe6144_p;

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x40")]
		internal static readonly DHParameters draft_ffdhe6144;

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0x48")]
		private static readonly string draft_ffdhe8192_p;

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x50")]
		internal static readonly DHParameters draft_ffdhe8192;
	}
}
