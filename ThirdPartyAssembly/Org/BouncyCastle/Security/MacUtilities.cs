using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Security
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	public sealed class MacUtilities
	{
		// Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private MacUtilities()
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x5466180", Offset = "0x5464D80", VA = "0x185466180")]
		public static IMac GetMac(DerObjectIdentifier id)
		{
			return null;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x5465480", Offset = "0x5464080", VA = "0x185465480")]
		public static IMac GetMac(string algorithm)
		{
			return null;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x54653C0", Offset = "0x5463FC0", VA = "0x1854653C0")]
		public static string GetAlgorithmName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x54650E0", Offset = "0x5463CE0", VA = "0x1854650E0")]
		public static byte[] CalculateMac(string algorithm, ICipherParameters cp, byte[] input)
		{
			return null;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x5465320", Offset = "0x5463F20", VA = "0x185465320")]
		public static byte[] DoFinal(IMac mac)
		{
			return null;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x5465210", Offset = "0x5463E10", VA = "0x185465210")]
		public static byte[] DoFinal(IMac mac, byte[] input)
		{
			return null;
		}

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary algorithms;
	}
}
