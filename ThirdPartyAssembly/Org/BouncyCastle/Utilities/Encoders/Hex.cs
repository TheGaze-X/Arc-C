using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public sealed class Hex
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Hex()
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x545F730", Offset = "0x545E330", VA = "0x18545F730")]
		public static string ToHexString(byte[] data)
		{
			return null;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x545F6B0", Offset = "0x545E2B0", VA = "0x18545F6B0")]
		public static string ToHexString(byte[] data, int off, int length)
		{
			return null;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x545F5B0", Offset = "0x545E1B0", VA = "0x18545F5B0")]
		public static byte[] Encode(byte[] data)
		{
			return null;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x545F4A0", Offset = "0x545E0A0", VA = "0x18545F4A0")]
		public static byte[] Encode(byte[] data, int off, int length)
		{
			return null;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x545F610", Offset = "0x545E210", VA = "0x18545F610")]
		public static int Encode(byte[] data, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x545F3F0", Offset = "0x545DFF0", VA = "0x18545F3F0")]
		public static int Encode(byte[] data, int off, int length, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x545F250", Offset = "0x545DE50", VA = "0x18545F250")]
		public static byte[] Decode(byte[] data)
		{
			return null;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x545F140", Offset = "0x545DD40", VA = "0x18545F140")]
		public static byte[] Decode(string data)
		{
			return null;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x545F360", Offset = "0x545DF60", VA = "0x18545F360")]
		public static int Decode(string data, Stream outStream)
		{
			return 0;
		}

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IEncoder encoder;
	}
}
