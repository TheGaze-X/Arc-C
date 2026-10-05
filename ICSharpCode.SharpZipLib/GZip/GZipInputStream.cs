using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public class GZipInputStream : InflaterInputStream
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x4A3CD80", Offset = "0x4A3B980", VA = "0x184A3CD80")]
		public GZipInputStream(Stream baseInputStream)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x4A3CCF0", Offset = "0x4A3B8F0", VA = "0x184A3CCF0")]
		public GZipInputStream(Stream baseInputStream, int size)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4A3CC30", Offset = "0x4A3B830", VA = "0x184A3CC30", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x4A3C290", Offset = "0x4A3AE90", VA = "0x184A3C290")]
		private bool ReadHeader()
		{
			return default(bool);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x4A3BED0", Offset = "0x4A3AAD0", VA = "0x184A3BED0")]
		private void ReadFooter()
		{
		}

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x50")]
		protected Crc32 crc;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x58")]
		private bool readGZIPHeader;
	}
}
