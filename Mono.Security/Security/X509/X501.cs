using System;
using System.Text;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public sealed class X501
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x4A87AB0", Offset = "0x4A866B0", VA = "0x184A87AB0")]
		public static string ToString(ASN1 seq)
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4A87870", Offset = "0x4A86470", VA = "0x184A87870")]
		public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes)
		{
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x4A854A0", Offset = "0x4A840A0", VA = "0x184A854A0")]
		private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4A86170", Offset = "0x4A84D70", VA = "0x184A86170")]
		private static X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4A86D70", Offset = "0x4A85970", VA = "0x184A86D70")]
		private static bool IsOid(string oid)
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4A86E60", Offset = "0x4A85A60", VA = "0x184A86E60")]
		private static X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos)
		{
			return null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4A86CA0", Offset = "0x4A858A0", VA = "0x184A86CA0")]
		private static bool IsHex(char c)
		{
			return default(bool);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4A871C0", Offset = "0x4A85DC0", VA = "0x184A871C0")]
		private static string ReadHex(string value, ref int pos)
		{
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4A87000", Offset = "0x4A85C00", VA = "0x184A87000")]
		private static int ReadEscaped(StringBuilder sb, string value, int pos)
		{
			return 0;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4A87430", Offset = "0x4A86030", VA = "0x184A87430")]
		private static int ReadQuoted(StringBuilder sb, string value, int pos)
		{
			return 0;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4A87590", Offset = "0x4A86190", VA = "0x184A87590")]
		private static string ReadValue(string value, ref int pos)
		{
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4A85DE0", Offset = "0x4A849E0", VA = "0x184A85DE0")]
		public static ASN1 FromString(string rdn)
		{
			return null;
		}

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] countryName;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] organizationName;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] organizationalUnitName;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x18")]
		private static byte[] commonName;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		private static byte[] localityName;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		private static byte[] stateOrProvinceName;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x30")]
		private static byte[] streetAddress;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x38")]
		private static byte[] serialNumber;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x40")]
		private static byte[] domainComponent;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x48")]
		private static byte[] userid;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x50")]
		private static byte[] email;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x58")]
		private static byte[] dnQualifier;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x60")]
		private static byte[] title;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x68")]
		private static byte[] surname;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x70")]
		private static byte[] givenName;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x78")]
		private static byte[] initial;
	}
}
