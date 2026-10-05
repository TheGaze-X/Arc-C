using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	public class GZipOutputStream : DeflaterOutputStream
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4A3D430", Offset = "0x4A3C030", VA = "0x184A3D430")]
		public GZipOutputStream(Stream baseOutputStream)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x4A3D500", Offset = "0x4A3C100", VA = "0x184A3D500")]
		public GZipOutputStream(Stream baseOutputStream, int size)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4A3D110", Offset = "0x4A3BD10", VA = "0x184A3D110")]
		public void SetLevel(int level)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4A3D0F0", Offset = "0x4A3BCF0", VA = "0x184A3D0F0")]
		public int GetLevel()
		{
			return 0;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4A3D340", Offset = "0x4A3BF40", VA = "0x184A3D340", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4A3CEF0", Offset = "0x4A3BAF0", VA = "0x184A3CEF0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4A3CF70", Offset = "0x4A3BB70", VA = "0x184A3CF70", Slot = "38")]
		public override void Finish()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4A3D190", Offset = "0x4A3BD90", VA = "0x184A3D190")]
		private void WriteHeader()
		{
		}

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x60")]
		protected Crc32 crc;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x68")]
		private GZipOutputStream.OutputState state_;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		private enum OutputState
		{
			// Token: 0x040000A4 RID: 164
			[Token(Token = "0x40000A4")]
			Header,
			// Token: 0x040000A5 RID: 165
			[Token(Token = "0x40000A5")]
			Footer,
			// Token: 0x040000A6 RID: 166
			[Token(Token = "0x40000A6")]
			Finished,
			// Token: 0x040000A7 RID: 167
			[Token(Token = "0x40000A7")]
			Closed
		}
	}
}
