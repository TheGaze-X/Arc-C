using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	public class GeneralName : Asn1Encodable, IAsn1Choice
	{
		// Token: 0x06002226 RID: 8742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002226")]
		[Address(RVA = "0x533D290", Offset = "0x533BE90", VA = "0x18533D290")]
		public GeneralName(X509Name directoryName)
		{
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002227")]
		[Address(RVA = "0x37442C0", Offset = "0x3742EC0", VA = "0x1837442C0")]
		public GeneralName(Asn1Object name, int tag)
		{
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002228")]
		[Address(RVA = "0x533D2D0", Offset = "0x533BED0", VA = "0x18533D2D0")]
		public GeneralName(int tag, Asn1Encodable name)
		{
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002229")]
		[Address(RVA = "0x533D310", Offset = "0x533BF10", VA = "0x18533D310")]
		public GeneralName(int tag, string name)
		{
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222A")]
		[Address(RVA = "0x533CA30", Offset = "0x533B630", VA = "0x18533CA30")]
		public static GeneralName GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222B")]
		[Address(RVA = "0x533D040", Offset = "0x533BC40", VA = "0x18533D040")]
		public static GeneralName GetInstance(Asn1TaggedObject tagObj, bool explicitly)
		{
			return null;
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[Token(Token = "0x1700046E")]
		public int TagNo
		{
			[Token(Token = "0x600222C")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046F")]
		public Asn1Encodable Name
		{
			[Token(Token = "0x600222D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x533D0E0", Offset = "0x533BCE0", VA = "0x18533D0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x533DD50", Offset = "0x533C950", VA = "0x18533DD50")]
		private byte[] toGeneralNameEncoding(string ip)
		{
			return null;
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x533D6B0", Offset = "0x533C2B0", VA = "0x18533D6B0")]
		private void parseIPv4Mask(string mask, byte[] addr, int offset)
		{
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002231")]
		[Address(RVA = "0x533D730", Offset = "0x533C330", VA = "0x18533D730")]
		private void parseIPv4(string ip, byte[] addr, int offset)
		{
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002232")]
		[Address(RVA = "0x533DCA0", Offset = "0x533C8A0", VA = "0x18533DCA0")]
		private int[] parseMask(string mask)
		{
			return null;
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002233")]
		[Address(RVA = "0x533D630", Offset = "0x533C230", VA = "0x18533D630")]
		private void copyInts(int[] parsedIp, byte[] addr, int offSet)
		{
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002234")]
		[Address(RVA = "0x533D830", Offset = "0x533C430", VA = "0x18533D830")]
		private int[] parseIPv6(string ip)
		{
			return null;
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002235")]
		[Address(RVA = "0x533D060", Offset = "0x533BC60", VA = "0x18533D060", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		public const int OtherName = 0;

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		public const int Rfc822Name = 1;

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		public const int DnsName = 2;

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x40011F1")]
		public const int X400Address = 3;

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		public const int DirectoryName = 4;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		public const int EdiPartyName = 5;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		public const int UniformResourceIdentifier = 6;

		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x40011F5")]
		public const int IPAddress = 7;

		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x40011F6")]
		public const int RegisteredID = 8;

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Asn1Encodable obj;

		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		[FieldOffset(Offset = "0x18")]
		internal readonly int tag;
	}
}
