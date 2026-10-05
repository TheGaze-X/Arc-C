using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	internal class ZipHelperStream : Stream
	{
		// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x4A6E3B0", Offset = "0x4A6CFB0", VA = "0x184A6E3B0")]
		public ZipHelperStream(string name)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x4A6E340", Offset = "0x4A6CF40", VA = "0x184A6E340")]
		public ZipHelperStream(Stream stream)
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000042C0 File Offset: 0x000024C0
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010D")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x1700010E")]
		public override bool CanRead
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x4A6E470", Offset = "0x4A6D070", VA = "0x184A6E470", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x1700010F")]
		public override bool CanSeek
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x4A6E4C0", Offset = "0x4A6D0C0", VA = "0x184A6E4C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x17000110")]
		public override long Length
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x4A6E560", Offset = "0x4A6D160", VA = "0x184A6E560", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00004320 File Offset: 0x00002520
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000111")]
		public override long Position
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x4A6E5B0", Offset = "0x4A6D1B0", VA = "0x184A6E5B0", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x4A6E600", Offset = "0x4A6D200", VA = "0x184A6E600", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x17000112")]
		public override bool CanWrite
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x4A6E510", Offset = "0x4A6D110", VA = "0x184A6E510", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x4A6CFF0", Offset = "0x4A6BBF0", VA = "0x184A6CFF0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4A6D4D0", Offset = "0x4A6C0D0", VA = "0x184A6D4D0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4A6D540", Offset = "0x4A6C140", VA = "0x184A6D540", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4A6D450", Offset = "0x4A6C050", VA = "0x184A6D450", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4A6E2C0", Offset = "0x4A6CEC0", VA = "0x184A6E2C0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x4A6CF80", Offset = "0x4A6BB80", VA = "0x184A6CF80", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x4A6DBC0", Offset = "0x4A6C7C0", VA = "0x184A6DBC0")]
		private void WriteLocalHeader(ZipEntry entry, EntryPatchData patchData)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x4A6D030", Offset = "0x4A6BC30", VA = "0x184A6D030")]
		public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
		{
			return 0L;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x4A6DFF0", Offset = "0x4A6CBF0", VA = "0x184A6DFF0")]
		public void WriteZip64EndOfCentralDirectory(long noOfEntries, long sizeEntries, long centralDirOffset)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4A6D710", Offset = "0x4A6C310", VA = "0x184A6D710")]
		public void WriteEndOfCentralDirectory(long noOfEntries, long sizeEntries, long startOfCentralDirectory, byte[] comment)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x4A6D330", Offset = "0x4A6BF30", VA = "0x184A6D330")]
		public int ReadLEShort()
		{
			return 0;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x4A6D290", Offset = "0x4A6BE90", VA = "0x184A6D290")]
		public int ReadLEInt()
		{
			return 0;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x4A6D2C0", Offset = "0x4A6BEC0", VA = "0x184A6D2C0")]
		public long ReadLELong()
		{
			return 0L;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x4A6D9F0", Offset = "0x4A6C5F0", VA = "0x184A6D9F0")]
		public void WriteLEShort(int value)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4A6DB20", Offset = "0x4A6C720", VA = "0x184A6DB20")]
		public void WriteLEUshort(ushort value)
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x4A6D950", Offset = "0x4A6C550", VA = "0x184A6D950")]
		public void WriteLEInt(int value)
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x4A6DA80", Offset = "0x4A6C680", VA = "0x184A6DA80")]
		public void WriteLEUint(uint value)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x4A6D990", Offset = "0x4A6C590", VA = "0x184A6D990")]
		public void WriteLELong(long value)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x4A6DAC0", Offset = "0x4A6C6C0", VA = "0x184A6DAC0")]
		public void WriteLEUlong(ulong value)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x4A6D590", Offset = "0x4A6C190", VA = "0x184A6D590")]
		public int WriteDataDescriptor(ZipEntry entry)
		{
			return 0;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x4A6D150", Offset = "0x4A6BD50", VA = "0x184A6D150")]
		public void ReadDataDescriptor(bool zip64, DescriptorData data)
		{
		}

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x28")]
		private bool isOwner_;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x30")]
		private Stream stream_;
	}
}
