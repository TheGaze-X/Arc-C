using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class ZipOutputStream : DeflaterOutputStream
	{
		// Token: 0x060004D8 RID: 1240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x4A73250", Offset = "0x4A71E50", VA = "0x184A73250")]
		public ZipOutputStream(Stream baseOutputStream)
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x4A733B0", Offset = "0x4A71FB0", VA = "0x184A733B0")]
		public ZipOutputStream(Stream baseOutputStream, int bufferSize)
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x17000118")]
		public bool IsFinished
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x4A73520", Offset = "0x4A72120", VA = "0x184A73520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x4A72B70", Offset = "0x4A71770", VA = "0x184A72B70")]
		public void SetComment(string comment)
		{
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x4A72C40", Offset = "0x4A71840", VA = "0x184A72C40")]
		public void SetLevel(int level)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x4A3D0F0", Offset = "0x4A3BCF0", VA = "0x184A3D0F0")]
		public int GetLevel()
		{
			return 0;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00004530 File Offset: 0x00002730
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000119")]
		public UseZip64 UseZip64
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x7893A0", Offset = "0x787FA0", VA = "0x1807893A0")]
			get
			{
				return UseZip64.Off;
			}
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x789460", Offset = "0x788060", VA = "0x180789460")]
			set
			{
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x4A72E70", Offset = "0x4A71A70", VA = "0x184A72E70")]
		private void WriteLeShort(int value)
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x4A72DD0", Offset = "0x4A719D0", VA = "0x184A72DD0")]
		private void WriteLeInt(int value)
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x4A72E10", Offset = "0x4A71A10", VA = "0x184A72E10")]
		private void WriteLeLong(long value)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x4A722A0", Offset = "0x4A70EA0", VA = "0x184A722A0")]
		public void PutNextEntry(ZipEntry entry)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x4A70DC0", Offset = "0x4A6F9C0", VA = "0x184A70DC0")]
		public void CloseEntry()
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x4A72C80", Offset = "0x4A71880", VA = "0x184A72C80")]
		private void WriteEncryptionHeader(long crcValue)
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x4A72F00", Offset = "0x4A71B00", VA = "0x184A72F00", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x4A71860", Offset = "0x4A70460", VA = "0x184A71860")]
		private void CopyAndEncrypt(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x4A71950", Offset = "0x4A70550", VA = "0x184A71950", Slot = "38")]
		public override void Finish()
		{
		}

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x60")]
		private ArrayList entries;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x68")]
		private Crc32 crc;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x70")]
		private ZipEntry curEntry;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x78")]
		private int defaultCompressionLevel;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x7C")]
		private CompressionMethod curMethod;

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x80")]
		private long size;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x88")]
		private long offset;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x90")]
		private byte[] zipComment;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x98")]
		private bool patchEntryHeader;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0xA0")]
		private long crcPatchPos;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0xA8")]
		private long sizePatchPos;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0xB0")]
		private UseZip64 useZip64_;
	}
}
