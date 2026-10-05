using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public class HexEncoder : IEncoder
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x545EE20", Offset = "0x545DA20", VA = "0x18545EE20")]
		protected void InitialiseDecodingTable()
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x545EF60", Offset = "0x545DB60", VA = "0x18545EF60")]
		public HexEncoder()
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x545ECD0", Offset = "0x545D8D0", VA = "0x18545ECD0", Slot = "4")]
		public int Encode(byte[] data, int off, int length, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x545EE00", Offset = "0x545DA00", VA = "0x18545EE00")]
		private static bool Ignore(char c)
		{
			return default(bool);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x545EAF0", Offset = "0x545D6F0", VA = "0x18545EAF0", Slot = "5")]
		public int Decode(byte[] data, int off, int length, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x545E900", Offset = "0x545D500", VA = "0x18545E900", Slot = "6")]
		public int DecodeString(string data, Stream outStream)
		{
			return 0;
		}

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte[] encodingTable;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x18")]
		protected readonly byte[] decodingTable;
	}
}
