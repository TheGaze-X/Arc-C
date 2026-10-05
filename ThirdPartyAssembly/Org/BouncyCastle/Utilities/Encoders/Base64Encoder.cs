using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public class Base64Encoder : IEncoder
	{
		// Token: 0x060007A7 RID: 1959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x5459890", Offset = "0x5458490", VA = "0x185459890")]
		protected void InitialiseDecodingTable()
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x5459910", Offset = "0x5458510", VA = "0x185459910")]
		public Base64Encoder()
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x5459420", Offset = "0x5458020", VA = "0x185459420", Slot = "4")]
		public int Encode(byte[] data, int off, int length, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x5459D70", Offset = "0x5458970", VA = "0x185459D70")]
		private bool ignore(char c)
		{
			return default(bool);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x5459070", Offset = "0x5457C70", VA = "0x185459070", Slot = "5")]
		public int Decode(byte[] data, int off, int length, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x5459E00", Offset = "0x5458A00", VA = "0x185459E00")]
		private int nextI(byte[] data, int i, int finish)
		{
			return 0;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x5458C60", Offset = "0x5457860", VA = "0x185458C60", Slot = "6")]
		public int DecodeString(string data, Stream outStream)
		{
			return 0;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x5459A30", Offset = "0x5458630", VA = "0x185459A30")]
		private int decodeLastBlock(Stream outStream, char c1, char c2, char c3, char c4)
		{
			return 0;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x5459D90", Offset = "0x5458990", VA = "0x185459D90")]
		private int nextI(string data, int i, int finish)
		{
			return 0;
		}

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x10")]
		protected readonly byte[] encodingTable;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x18")]
		protected byte padding;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x20")]
		protected readonly byte[] decodingTable;
	}
}
