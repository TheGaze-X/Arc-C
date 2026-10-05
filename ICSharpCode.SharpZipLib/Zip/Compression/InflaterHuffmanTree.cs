using System;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class InflaterHuffmanTree
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x4A4CEB0", Offset = "0x4A4BAB0", VA = "0x184A4CEB0")]
		public InflaterHuffmanTree(byte[] codeLengths)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x4A4C6D0", Offset = "0x4A4B2D0", VA = "0x184A4C6D0")]
		private void BuildTree(byte[] codeLengths)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x4A4CAC0", Offset = "0x4A4B6C0", VA = "0x184A4CAC0")]
		public int GetSymbol(StreamManipulator input)
		{
			return 0;
		}

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		private const int MAX_BITLEN = 15;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x10")]
		private short[] tree;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x0")]
		public static InflaterHuffmanTree defLitLenTree;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x8")]
		public static InflaterHuffmanTree defDistTree;
	}
}
