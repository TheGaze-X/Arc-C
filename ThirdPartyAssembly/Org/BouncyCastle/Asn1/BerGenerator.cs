using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	public class BerGenerator : Asn1Generator
	{
		// Token: 0x06001F9E RID: 8094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		protected BerGenerator(Stream outStream)
		{
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9F")]
		[Address(RVA = "0x5316460", Offset = "0x5315060", VA = "0x185316460")]
		public BerGenerator(Stream outStream, int tagNo, bool isExplicit)
		{
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA0")]
		[Address(RVA = "0x53161D0", Offset = "0x5314DD0", VA = "0x1853161D0", Slot = "4")]
		public override void AddObject(Asn1Encodable obj)
		{
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA1")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Stream GetRawOutputStream()
		{
			return null;
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x5316270", Offset = "0x5314E70", VA = "0x185316270", Slot = "6")]
		public override void Close()
		{
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x53163D0", Offset = "0x5314FD0", VA = "0x1853163D0")]
		private void WriteHdr(int tag)
		{
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x5316380", Offset = "0x5314F80", VA = "0x185316380")]
		protected void WriteBerHeader(int tag)
		{
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0x5316360", Offset = "0x5314F60", VA = "0x185316360")]
		protected void WriteBerBody(Stream contentStream)
		{
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x5316270", Offset = "0x5314E70", VA = "0x185316270")]
		protected void WriteBerEnd()
		{
		}

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x18")]
		private bool _tagged;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x19")]
		private bool _isExplicit;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x1C")]
		private int _tagNo;
	}
}
