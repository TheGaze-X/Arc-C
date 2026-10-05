using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class MemoryArchiveStorage : BaseArchiveStorage
	{
		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x4A31A30", Offset = "0x4A30630", VA = "0x184A31A30")]
		public MemoryArchiveStorage()
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		public MemoryArchiveStorage(FileUpdateMode updateMode)
		{
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x17000107")]
		public MemoryStream FinalStream
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x4A5D7F0", Offset = "0x4A5C3F0", VA = "0x184A5D7F0", Slot = "10")]
		public override Stream GetTemporaryOutput()
		{
			return null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x4A5D6E0", Offset = "0x4A5C2E0", VA = "0x184A5D6E0", Slot = "11")]
		public override Stream ConvertTemporaryToFinal()
		{
			return null;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x4A5D860", Offset = "0x4A5C460", VA = "0x184A5D860", Slot = "12")]
		public override Stream MakeTemporaryCopy(Stream stream)
		{
			return null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x4A5D940", Offset = "0x4A5C540", VA = "0x184A5D940", Slot = "13")]
		public override Stream OpenForDirectUpdate(Stream stream)
		{
			return null;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x4A5C1D0", Offset = "0x4A5ADD0", VA = "0x184A5C1D0", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x18")]
		private MemoryStream temporaryStream_;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x20")]
		private MemoryStream finalStream_;
	}
}
