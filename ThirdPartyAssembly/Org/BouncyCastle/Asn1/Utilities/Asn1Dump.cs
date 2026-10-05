using System;
using System.Text;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Utilities
{
	// Token: 0x02000421 RID: 1057
	[Token(Token = "0x2000421")]
	public sealed class Asn1Dump
	{
		// Token: 0x060022E8 RID: 8936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Asn1Dump()
		{
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E9")]
		[Address(RVA = "0x53587C0", Offset = "0x53573C0", VA = "0x1853587C0")]
		private static void AsString(string indent, bool verbose, Asn1Object obj, StringBuilder buf)
		{
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x535CAE0", Offset = "0x535B6E0", VA = "0x18535CAE0")]
		private static string outputApplicationSpecific(string type, string indent, bool verbose, DerApplicationSpecific app)
		{
			return null;
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EB")]
		[Address(RVA = "0x535C210", Offset = "0x535AE10", VA = "0x18535C210")]
		[Obsolete("Use version accepting Asn1Encodable")]
		public static string DumpAsString(object obj)
		{
			return null;
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EC")]
		[Address(RVA = "0x535C4A0", Offset = "0x535B0A0", VA = "0x18535C4A0")]
		public static string DumpAsString(Asn1Encodable obj)
		{
			return null;
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022ED")]
		[Address(RVA = "0x535C5E0", Offset = "0x535B1E0", VA = "0x18535C5E0")]
		public static string DumpAsString(Asn1Encodable obj, bool verbose)
		{
			return null;
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x535C850", Offset = "0x535B450", VA = "0x18535C850")]
		private static string dumpBinaryDataAsString(string indent, byte[] bytes)
		{
			return null;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x535C770", Offset = "0x535B370", VA = "0x18535C770")]
		private static string calculateAscString(byte[] bytes, int off, int len)
		{
			return null;
		}

		// Token: 0x0400129C RID: 4764
		[Token(Token = "0x400129C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string NewLine;

		// Token: 0x0400129D RID: 4765
		[Token(Token = "0x400129D")]
		private const string Tab = "    ";

		// Token: 0x0400129E RID: 4766
		[Token(Token = "0x400129E")]
		private const int SampleSize = 32;
	}
}
