using System;
using System.Collections;
using System.Text;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000329 RID: 809
	[Token(Token = "0x2000329")]
	internal class MonoChunkParser
	{
		// Token: 0x06001698 RID: 5784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001698")]
		[Address(RVA = "0x5087060", Offset = "0x5085C60", VA = "0x185087060")]
		public MonoChunkParser(WebHeaderCollection headers)
		{
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x5086F60", Offset = "0x5085B60", VA = "0x185086F60")]
		public int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x5086930", Offset = "0x5085530", VA = "0x185086930")]
		private int ReadFromChunks(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x5087030", Offset = "0x5085C30", VA = "0x185087030")]
		public void Write(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x5086430", Offset = "0x5085030", VA = "0x185086430")]
		private void InternalWrite(byte[] buffer, ref int offset, int size)
		{
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x170004EA")]
		public bool WantMore
		{
			[Token(Token = "0x600169D")]
			[Address(RVA = "0x50872B0", Offset = "0x5085EB0", VA = "0x1850872B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x170004EB")]
		public bool DataAvailable
		{
			[Token(Token = "0x600169E")]
			[Address(RVA = "0x5087140", Offset = "0x5085D40", VA = "0x185087140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x170004EC")]
		public int ChunkLeft
		{
			[Token(Token = "0x600169F")]
			[Address(RVA = "0x5087130", Offset = "0x5085D30", VA = "0x185087130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x5086700", Offset = "0x5085300", VA = "0x185086700")]
		private MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size)
		{
			return MonoChunkParser.State.None;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x5086170", Offset = "0x5084D70", VA = "0x185086170")]
		private MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size)
		{
			return MonoChunkParser.State.None;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x5086F70", Offset = "0x5085B70", VA = "0x185086F70")]
		private static string RemoveChunkExtension(string input)
		{
			return null;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x5086850", Offset = "0x5085450", VA = "0x185086850")]
		private MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size)
		{
			return MonoChunkParser.State.None;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x5086CD0", Offset = "0x50858D0", VA = "0x185086CD0")]
		private MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size)
		{
			return MonoChunkParser.State.None;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x5086FC0", Offset = "0x5085BC0", VA = "0x185086FC0")]
		private static void ThrowProtocolViolation(string message)
		{
		}

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x10")]
		private WebHeaderCollection headers;

		// Token: 0x04000CBF RID: 3263
		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x18")]
		private int chunkSize;

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x1C")]
		private int chunkRead;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x20")]
		private int totalWritten;

		// Token: 0x04000CC2 RID: 3266
		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x24")]
		private MonoChunkParser.State state;

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x28")]
		private StringBuilder saved;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x30")]
		private bool sawCR;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x31")]
		private bool gotit;

		// Token: 0x04000CC6 RID: 3270
		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x34")]
		private int trailerState;

		// Token: 0x04000CC7 RID: 3271
		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x38")]
		private ArrayList chunks;

		// Token: 0x0200032A RID: 810
		[Token(Token = "0x200032A")]
		private enum State
		{
			// Token: 0x04000CC9 RID: 3273
			[Token(Token = "0x4000CC9")]
			None,
			// Token: 0x04000CCA RID: 3274
			[Token(Token = "0x4000CCA")]
			PartialSize,
			// Token: 0x04000CCB RID: 3275
			[Token(Token = "0x4000CCB")]
			Body,
			// Token: 0x04000CCC RID: 3276
			[Token(Token = "0x4000CCC")]
			BodyFinished,
			// Token: 0x04000CCD RID: 3277
			[Token(Token = "0x4000CCD")]
			Trailer
		}

		// Token: 0x0200032B RID: 811
		[Token(Token = "0x200032B")]
		private class Chunk
		{
			// Token: 0x060016A6 RID: 5798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016A6")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public Chunk(byte[] chunk)
			{
			}

			// Token: 0x060016A7 RID: 5799 RVA: 0x0000A5D8 File Offset: 0x000087D8
			[Token(Token = "0x60016A7")]
			[Address(RVA = "0x5083600", Offset = "0x5082200", VA = "0x185083600")]
			public int Read(byte[] buffer, int offset, int size)
			{
				return 0;
			}

			// Token: 0x04000CCE RID: 3278
			[Token(Token = "0x4000CCE")]
			[FieldOffset(Offset = "0x10")]
			public byte[] Bytes;

			// Token: 0x04000CCF RID: 3279
			[Token(Token = "0x4000CCF")]
			[FieldOffset(Offset = "0x18")]
			public int Offset;
		}
	}
}
