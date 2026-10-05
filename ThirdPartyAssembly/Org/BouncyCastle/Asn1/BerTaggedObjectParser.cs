using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003AF RID: 943
	[Token(Token = "0x20003AF")]
	public class BerTaggedObjectParser : Asn1TaggedObjectParser, IAsn1Convertible
	{
		// Token: 0x06001FD4 RID: 8148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x5318D80", Offset = "0x5317980", VA = "0x185318D80")]
		[Obsolete]
		internal BerTaggedObjectParser(int baseTag, int tagNumber, Stream contentStream)
		{
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD5")]
		[Address(RVA = "0x5318E40", Offset = "0x5317A40", VA = "0x185318E40")]
		internal BerTaggedObjectParser(bool constructed, int tagNumber, Asn1StreamParser parser)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[Token(Token = "0x17000424")]
		public bool IsConstructed
		{
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		[Token(Token = "0x17000425")]
		public int TagNo
		{
			[Token(Token = "0x6001FD7")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0x5318C00", Offset = "0x5317800", VA = "0x185318C00", Slot = "5")]
		public IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x5318CD0", Offset = "0x53178D0", VA = "0x185318CD0", Slot = "6")]
		public Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400111A RID: 4378
		[Token(Token = "0x400111A")]
		[FieldOffset(Offset = "0x10")]
		private bool _constructed;

		// Token: 0x0400111B RID: 4379
		[Token(Token = "0x400111B")]
		[FieldOffset(Offset = "0x14")]
		private int _tagNumber;

		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400111C")]
		[FieldOffset(Offset = "0x18")]
		private Asn1StreamParser _parser;
	}
}
