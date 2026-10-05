using System;
using System.Collections;
using System.Text;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	public class X509Name : Asn1Encodable
	{
		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x0000F948 File Offset: 0x0000DB48
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049E")]
		public static bool DefaultReverse
		{
			[Token(Token = "0x60022BF")]
			[Address(RVA = "0x5350AD0", Offset = "0x534F6D0", VA = "0x185350AD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022C0")]
			[Address(RVA = "0x5350B40", Offset = "0x534F740", VA = "0x185350B40")]
			set
			{
			}
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x534AC90", Offset = "0x5349890", VA = "0x18534AC90")]
		public static X509Name GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x534AD00", Offset = "0x5349900", VA = "0x18534AD00")]
		public static X509Name GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C4")]
		[Address(RVA = "0x53506C0", Offset = "0x534F2C0", VA = "0x1853506C0")]
		protected X509Name()
		{
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C5")]
		[Address(RVA = "0x534F520", Offset = "0x534E120", VA = "0x18534F520")]
		protected X509Name(Asn1Sequence seq)
		{
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x534EA90", Offset = "0x534D690", VA = "0x18534EA90")]
		public X509Name(IList ordering, IDictionary attributes)
		{
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C7")]
		[Address(RVA = "0x534FC80", Offset = "0x534E880", VA = "0x18534FC80")]
		public X509Name(IList ordering, IDictionary attributes, X509NameEntryConverter converter)
		{
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C8")]
		[Address(RVA = "0x5350630", Offset = "0x534F230", VA = "0x185350630")]
		public X509Name(IList oids, IList values)
		{
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x53500A0", Offset = "0x534ECA0", VA = "0x1853500A0")]
		public X509Name(IList oids, IList values, X509NameEntryConverter converter)
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x534EC50", Offset = "0x534D850", VA = "0x18534EC50")]
		public X509Name(string dirName)
		{
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x534EB20", Offset = "0x534D720", VA = "0x18534EB20")]
		public X509Name(string dirName, X509NameEntryConverter converter)
		{
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x534EBC0", Offset = "0x534D7C0", VA = "0x18534EBC0")]
		public X509Name(bool reverse, string dirName)
		{
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x534FBE0", Offset = "0x534E7E0", VA = "0x18534FBE0")]
		public X509Name(bool reverse, string dirName, X509NameEntryConverter converter)
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x534F470", Offset = "0x534E070", VA = "0x18534F470")]
		public X509Name(bool reverse, IDictionary lookUp, string dirName)
		{
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x534A330", Offset = "0x5348F30", VA = "0x18534A330")]
		private DerObjectIdentifier DecodeOid(string name, IDictionary lookUp)
		{
			return null;
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x534ECD0", Offset = "0x534D8D0", VA = "0x18534ECD0")]
		public X509Name(bool reverse, IDictionary lookUp, string dirName, X509NameEntryConverter converter)
		{
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x534AE40", Offset = "0x5349A40", VA = "0x18534AE40")]
		public IList GetOidList()
		{
			return null;
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x534AE90", Offset = "0x5349A90", VA = "0x18534AE90")]
		public IList GetValueList()
		{
			return null;
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x534AEA0", Offset = "0x5349AA0", VA = "0x18534AEA0")]
		public IList GetValueList(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x534B100", Offset = "0x5349D00", VA = "0x18534B100", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0000F960 File Offset: 0x0000DB60
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x534A8F0", Offset = "0x53494F0", VA = "0x18534A8F0")]
		public bool Equivalent(X509Name other, bool inOrder)
		{
			return default(bool);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0000F978 File Offset: 0x0000DB78
		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x534A560", Offset = "0x5349160", VA = "0x18534A560")]
		public bool Equivalent(X509Name other)
		{
			return default(bool);
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x53509F0", Offset = "0x534F5F0", VA = "0x1853509F0")]
		private static bool equivalentStrings(string s1, string s2)
		{
			return default(bool);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x5350750", Offset = "0x534F350", VA = "0x185350750")]
		private static string canonicalize(string s)
		{
			return null;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x53508D0", Offset = "0x534F4D0", VA = "0x1853508D0")]
		private static Asn1Object decodeObject(string v)
		{
			return null;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DA")]
		[Address(RVA = "0x5350BC0", Offset = "0x534F7C0", VA = "0x185350BC0")]
		private static string stripInternalSpaces(string str)
		{
			return null;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x534A110", Offset = "0x5348D10", VA = "0x18534A110")]
		private void AppendValue(StringBuilder buf, IDictionary oidSymbols, DerObjectIdentifier oid, string val)
		{
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x534B880", Offset = "0x534A480", VA = "0x18534B880")]
		public string ToString(bool reverse, IDictionary oidSymbols)
		{
			return null;
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x534BE60", Offset = "0x534AA60", VA = "0x18534BE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001258 RID: 4696
		[Token(Token = "0x4001258")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerObjectIdentifier C;

		// Token: 0x04001259 RID: 4697
		[Token(Token = "0x4001259")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DerObjectIdentifier O;

		// Token: 0x0400125A RID: 4698
		[Token(Token = "0x400125A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DerObjectIdentifier OU;

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DerObjectIdentifier T;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		[FieldOffset(Offset = "0x20")]
		public static readonly DerObjectIdentifier CN;

		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		[FieldOffset(Offset = "0x28")]
		public static readonly DerObjectIdentifier Street;

		// Token: 0x0400125E RID: 4702
		[Token(Token = "0x400125E")]
		[FieldOffset(Offset = "0x30")]
		public static readonly DerObjectIdentifier SerialNumber;

		// Token: 0x0400125F RID: 4703
		[Token(Token = "0x400125F")]
		[FieldOffset(Offset = "0x38")]
		public static readonly DerObjectIdentifier L;

		// Token: 0x04001260 RID: 4704
		[Token(Token = "0x4001260")]
		[FieldOffset(Offset = "0x40")]
		public static readonly DerObjectIdentifier ST;

		// Token: 0x04001261 RID: 4705
		[Token(Token = "0x4001261")]
		[FieldOffset(Offset = "0x48")]
		public static readonly DerObjectIdentifier Surname;

		// Token: 0x04001262 RID: 4706
		[Token(Token = "0x4001262")]
		[FieldOffset(Offset = "0x50")]
		public static readonly DerObjectIdentifier GivenName;

		// Token: 0x04001263 RID: 4707
		[Token(Token = "0x4001263")]
		[FieldOffset(Offset = "0x58")]
		public static readonly DerObjectIdentifier Initials;

		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4001264")]
		[FieldOffset(Offset = "0x60")]
		public static readonly DerObjectIdentifier Generation;

		// Token: 0x04001265 RID: 4709
		[Token(Token = "0x4001265")]
		[FieldOffset(Offset = "0x68")]
		public static readonly DerObjectIdentifier UniqueIdentifier;

		// Token: 0x04001266 RID: 4710
		[Token(Token = "0x4001266")]
		[FieldOffset(Offset = "0x70")]
		public static readonly DerObjectIdentifier BusinessCategory;

		// Token: 0x04001267 RID: 4711
		[Token(Token = "0x4001267")]
		[FieldOffset(Offset = "0x78")]
		public static readonly DerObjectIdentifier PostalCode;

		// Token: 0x04001268 RID: 4712
		[Token(Token = "0x4001268")]
		[FieldOffset(Offset = "0x80")]
		public static readonly DerObjectIdentifier DnQualifier;

		// Token: 0x04001269 RID: 4713
		[Token(Token = "0x4001269")]
		[FieldOffset(Offset = "0x88")]
		public static readonly DerObjectIdentifier Pseudonym;

		// Token: 0x0400126A RID: 4714
		[Token(Token = "0x400126A")]
		[FieldOffset(Offset = "0x90")]
		public static readonly DerObjectIdentifier DateOfBirth;

		// Token: 0x0400126B RID: 4715
		[Token(Token = "0x400126B")]
		[FieldOffset(Offset = "0x98")]
		public static readonly DerObjectIdentifier PlaceOfBirth;

		// Token: 0x0400126C RID: 4716
		[Token(Token = "0x400126C")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly DerObjectIdentifier Gender;

		// Token: 0x0400126D RID: 4717
		[Token(Token = "0x400126D")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly DerObjectIdentifier CountryOfCitizenship;

		// Token: 0x0400126E RID: 4718
		[Token(Token = "0x400126E")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly DerObjectIdentifier CountryOfResidence;

		// Token: 0x0400126F RID: 4719
		[Token(Token = "0x400126F")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly DerObjectIdentifier NameAtBirth;

		// Token: 0x04001270 RID: 4720
		[Token(Token = "0x4001270")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly DerObjectIdentifier PostalAddress;

		// Token: 0x04001271 RID: 4721
		[Token(Token = "0x4001271")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly DerObjectIdentifier DmdName;

		// Token: 0x04001272 RID: 4722
		[Token(Token = "0x4001272")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly DerObjectIdentifier TelephoneNumber;

		// Token: 0x04001273 RID: 4723
		[Token(Token = "0x4001273")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly DerObjectIdentifier Name;

		// Token: 0x04001274 RID: 4724
		[Token(Token = "0x4001274")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly DerObjectIdentifier EmailAddress;

		// Token: 0x04001275 RID: 4725
		[Token(Token = "0x4001275")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly DerObjectIdentifier UnstructuredName;

		// Token: 0x04001276 RID: 4726
		[Token(Token = "0x4001276")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly DerObjectIdentifier UnstructuredAddress;

		// Token: 0x04001277 RID: 4727
		[Token(Token = "0x4001277")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly DerObjectIdentifier E;

		// Token: 0x04001278 RID: 4728
		[Token(Token = "0x4001278")]
		[FieldOffset(Offset = "0x100")]
		public static readonly DerObjectIdentifier DC;

		// Token: 0x04001279 RID: 4729
		[Token(Token = "0x4001279")]
		[FieldOffset(Offset = "0x108")]
		public static readonly DerObjectIdentifier UID;

		// Token: 0x0400127A RID: 4730
		[Token(Token = "0x400127A")]
		[FieldOffset(Offset = "0x110")]
		private static readonly bool[] defaultReverse;

		// Token: 0x0400127B RID: 4731
		[Token(Token = "0x400127B")]
		[FieldOffset(Offset = "0x118")]
		public static readonly Hashtable DefaultSymbols;

		// Token: 0x0400127C RID: 4732
		[Token(Token = "0x400127C")]
		[FieldOffset(Offset = "0x120")]
		public static readonly Hashtable RFC2253Symbols;

		// Token: 0x0400127D RID: 4733
		[Token(Token = "0x400127D")]
		[FieldOffset(Offset = "0x128")]
		public static readonly Hashtable RFC1779Symbols;

		// Token: 0x0400127E RID: 4734
		[Token(Token = "0x400127E")]
		[FieldOffset(Offset = "0x130")]
		public static readonly Hashtable DefaultLookup;

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList ordering;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x18")]
		private readonly X509NameEntryConverter converter;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x20")]
		private IList values;

		// Token: 0x04001282 RID: 4738
		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x28")]
		private IList added;

		// Token: 0x04001283 RID: 4739
		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x30")]
		private Asn1Sequence seq;
	}
}
