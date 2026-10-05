using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B0 RID: 944
	[Token(Token = "0x20003B0")]
	internal class ConstructedOctetStream : BaseInputStream
	{
		// Token: 0x06001FDA RID: 8154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0x5319A00", Offset = "0x5318600", VA = "0x185319A00")]
		internal ConstructedOctetStream(Asn1StreamParser parser)
		{
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x5319760", Offset = "0x5318360", VA = "0x185319760", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x5319500", Offset = "0x5318100", VA = "0x185319500", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x30")]
		private readonly Asn1StreamParser _parser;

		// Token: 0x0400111E RID: 4382
		[Token(Token = "0x400111E")]
		[FieldOffset(Offset = "0x38")]
		private bool _first;

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x40")]
		private Stream _currentStream;
	}
}
