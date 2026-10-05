using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public class DiskArchiveStorage : BaseArchiveStorage
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x4A5C670", Offset = "0x4A5B270", VA = "0x184A5C670")]
		public DiskArchiveStorage(ZipFile file, FileUpdateMode updateMode)
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x4A5C720", Offset = "0x4A5B320", VA = "0x184A5C720")]
		public DiskArchiveStorage(ZipFile file)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x4A5C400", Offset = "0x4A5B000", VA = "0x184A5C400", Slot = "10")]
		public override Stream GetTemporaryOutput()
		{
			return null;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x4A5C060", Offset = "0x4A5AC60", VA = "0x184A5C060", Slot = "11")]
		public override Stream ConvertTemporaryToFinal()
		{
			return null;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x4A5C4B0", Offset = "0x4A5B0B0", VA = "0x184A5C4B0", Slot = "12")]
		public override Stream MakeTemporaryCopy(Stream stream)
		{
			return null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x4A5C5A0", Offset = "0x4A5B1A0", VA = "0x184A5C5A0", Slot = "13")]
		public override Stream OpenForDirectUpdate(Stream stream)
		{
			return null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x4A5C1D0", Offset = "0x4A5ADD0", VA = "0x184A5C1D0", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x4A5C210", Offset = "0x4A5AE10", VA = "0x184A5C210")]
		private static string GetTempFileName(string original, bool makeTempFile)
		{
			return null;
		}

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x18")]
		private Stream temporaryStream_;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x20")]
		private string fileName_;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x28")]
		private string temporaryName_;
	}
}
