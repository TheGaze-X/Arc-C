using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Utilities
{
	// Token: 0x02000422 RID: 1058
	[Token(Token = "0x2000422")]
	public class FilterStream : Stream
	{
		// Token: 0x060022F1 RID: 8945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F1")]
		[Address(RVA = "0x5362E30", Offset = "0x5361A30", VA = "0x185362E30")]
		public FilterStream(Stream s)
		{
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		[Token(Token = "0x1700049F")]
		public override bool CanRead
		{
			[Token(Token = "0x60022F2")]
			[Address(RVA = "0x4A3F730", Offset = "0x4A3E330", VA = "0x184A3F730", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		[Token(Token = "0x170004A0")]
		public override bool CanSeek
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x4FF9140", Offset = "0x4FF7D40", VA = "0x184FF9140", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0000FA08 File Offset: 0x0000DC08
		[Token(Token = "0x170004A1")]
		public override bool CanWrite
		{
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x4A5EE40", Offset = "0x4A5DA40", VA = "0x184A5EE40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0000FA20 File Offset: 0x0000DC20
		[Token(Token = "0x170004A2")]
		public override long Length
		{
			[Token(Token = "0x60022F5")]
			[Address(RVA = "0x4F52370", Offset = "0x4F50F70", VA = "0x184F52370", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x0000FA38 File Offset: 0x0000DC38
		// (set) Token: 0x060022F7 RID: 8951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A3")]
		public override long Position
		{
			[Token(Token = "0x60022F6")]
			[Address(RVA = "0x4A3F790", Offset = "0x4A3E390", VA = "0x184A3F790", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60022F7")]
			[Address(RVA = "0x4FF9190", Offset = "0x4FF7D90", VA = "0x184FF9190", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x5362DD0", Offset = "0x53619D0", VA = "0x185362DD0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x4A3E4A0", Offset = "0x4A3D0A0", VA = "0x184A3E4A0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x4FF8FE0", Offset = "0x4FF7BE0", VA = "0x184FF8FE0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x4F51A80", Offset = "0x4F50680", VA = "0x184F51A80", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0000FA68 File Offset: 0x0000DC68
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x4FF8F60", Offset = "0x4FF7B60", VA = "0x184FF8F60", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0000FA80 File Offset: 0x0000DC80
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x4E63090", Offset = "0x4E61C90", VA = "0x184E63090", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x4A5ED50", Offset = "0x4A5D950", VA = "0x184A5ED50", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x4FF9050", Offset = "0x4FF7C50", VA = "0x184FF9050", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x0400129F RID: 4767
		[Token(Token = "0x400129F")]
		[FieldOffset(Offset = "0x28")]
		protected readonly Stream s;
	}
}
