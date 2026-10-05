using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public sealed class Base64
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Base64()
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x545A2C0", Offset = "0x5458EC0", VA = "0x18545A2C0")]
		public static string ToBase64String(byte[] data)
		{
			return null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x545A250", Offset = "0x5458E50", VA = "0x18545A250")]
		public static string ToBase64String(byte[] data, int off, int length)
		{
			return null;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x545A1D0", Offset = "0x5458DD0", VA = "0x18545A1D0")]
		public static byte[] Encode(byte[] data)
		{
			return null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x545A150", Offset = "0x5458D50", VA = "0x18545A150")]
		public static byte[] Encode(byte[] data, int off, int length)
		{
			return null;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x5459FB0", Offset = "0x5458BB0", VA = "0x185459FB0")]
		public static int Encode(byte[] data, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x545A080", Offset = "0x5458C80", VA = "0x18545A080")]
		public static int Encode(byte[] data, int off, int length, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x5459F00", Offset = "0x5458B00", VA = "0x185459F00")]
		public static byte[] Decode(byte[] data)
		{
			return null;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x5459F60", Offset = "0x5458B60", VA = "0x185459F60")]
		public static byte[] Decode(string data)
		{
			return null;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x5459E50", Offset = "0x5458A50", VA = "0x185459E50")]
		public static int Decode(string data, Stream outStream)
		{
			return 0;
		}
	}
}
