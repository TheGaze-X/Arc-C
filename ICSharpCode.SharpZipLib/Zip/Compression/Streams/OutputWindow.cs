using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public class OutputWindow
	{
		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x4A4FBA0", Offset = "0x4A4E7A0", VA = "0x184A4FBA0")]
		public void Write(int value)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x4A4FB20", Offset = "0x4A4E720", VA = "0x184A4FB20")]
		private void SlowRepeat(int repStart, int length, int distance)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x4A4F970", Offset = "0x4A4E570", VA = "0x184A4F970")]
		public void Repeat(int length, int distance)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x4A4F850", Offset = "0x4A4E450", VA = "0x184A4F850")]
		public int CopyStored(StreamManipulator input, int length)
		{
			return 0;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x4A4F650", Offset = "0x4A4E250", VA = "0x184A4F650")]
		public void CopyDict(byte[] dictionary, int offset, int length)
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x4A4F960", Offset = "0x4A4E560", VA = "0x184A4F960")]
		public int GetFreeSpace()
		{
			return 0;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
		public int GetAvailable()
		{
			return 0;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x4A4F750", Offset = "0x4A4E350", VA = "0x184A4F750")]
		public int CopyOutput(byte[] output, int offset, int len)
		{
			return 0;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x4A4FB10", Offset = "0x4A4E710", VA = "0x184A4FB10")]
		public void Reset()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x4A4FC50", Offset = "0x4A4E850", VA = "0x184A4FC50")]
		public OutputWindow()
		{
		}

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		private const int WindowSize = 32768;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		private const int WindowMask = 32767;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x10")]
		private byte[] window;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x18")]
		private int windowEnd;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x1C")]
		private int windowFilled;
	}
}
