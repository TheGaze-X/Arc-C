using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000392 RID: 914
	[Token(Token = "0x2000392")]
	public abstract class Asn1OctetString : Asn1Object, Asn1OctetStringParser, IAsn1Convertible
	{
		// Token: 0x06001F41 RID: 8001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x5310350", Offset = "0x530EF50", VA = "0x185310350")]
		public static Asn1OctetString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F42")]
		[Address(RVA = "0x5310460", Offset = "0x530F060", VA = "0x185310460")]
		public static Asn1OctetString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0x53107A0", Offset = "0x530F3A0", VA = "0x1853107A0")]
		internal Asn1OctetString(byte[] str)
		{
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F44")]
		[Address(RVA = "0x5310830", Offset = "0x530F430", VA = "0x185310830")]
		internal Asn1OctetString(Asn1Encodable obj)
		{
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x53106C0", Offset = "0x530F2C0", VA = "0x1853106C0", Slot = "9")]
		public Stream GetOctetStream()
		{
			return null;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000419")]
		public Asn1OctetStringParser Parser
		{
			[Token(Token = "0x6001F46")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public virtual byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0x5310310", Offset = "0x530EF10", VA = "0x185310310", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0000EF10 File Offset: 0x0000D110
		[Token(Token = "0x6001F49")]
		[Address(RVA = "0x5310200", Offset = "0x530EE00", VA = "0x185310200", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4A")]
		[Address(RVA = "0x5310730", Offset = "0x530F330", VA = "0x185310730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x10")]
		internal byte[] str;
	}
}
