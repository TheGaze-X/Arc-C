using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	public class TestStatus
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public TestStatus(ZipFile file)
		{
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x170000DA")]
		public TestOperation Operation
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return TestOperation.Initialising;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x170000DB")]
		public ZipFile File
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x170000DC")]
		public ZipEntry Entry
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x170000DD")]
		public int ErrorCount
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x170000DE")]
		public long BytesTested
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x170000DF")]
		public bool EntryValid
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x4A5ED10", Offset = "0x4A5D910", VA = "0x184A5ED10")]
		internal void AddError()
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
		internal void SetOperation(TestOperation operation)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4A5ED20", Offset = "0x4A5D920", VA = "0x184A5ED20")]
		internal void SetEntry(ZipEntry entry)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x20339E0", Offset = "0x20325E0", VA = "0x1820339E0")]
		internal void SetBytesTested(long value)
		{
		}

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x10")]
		private ZipFile file_;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x18")]
		private ZipEntry entry_;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x20")]
		private bool entryValid_;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x24")]
		private int errorCount_;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x28")]
		private long bytesTested_;

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x30")]
		private TestOperation operation_;
	}
}
