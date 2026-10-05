using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class FileSystemScanner
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4A3BE40", Offset = "0x4A3AA40", VA = "0x184A3BE40")]
		public FileSystemScanner(string filter)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4A3BD50", Offset = "0x4A3A950", VA = "0x184A3BD50")]
		public FileSystemScanner(string fileFilter, string directoryFilter)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4A3BE10", Offset = "0x4A3AA10", VA = "0x184A3BE10")]
		public FileSystemScanner(IScanFilter fileFilter)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4A3BD00", Offset = "0x4A3A900", VA = "0x184A3BD00")]
		public FileSystemScanner(IScanFilter fileFilter, IScanFilter directoryFilter)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x4A3B5D0", Offset = "0x4A3A1D0", VA = "0x184A3B5D0")]
		private bool OnDirectoryFailure(string directory, Exception e)
		{
			return default(bool);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4A3B680", Offset = "0x4A3A280", VA = "0x184A3B680")]
		private bool OnFileFailure(string file, Exception e)
		{
			return default(bool);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4A3B830", Offset = "0x4A3A430", VA = "0x184A3B830")]
		private void OnProcessFile(string file)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4A3B530", Offset = "0x4A3A130", VA = "0x184A3B530")]
		private void OnCompleteFile(string file)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4A3B740", Offset = "0x4A3A340", VA = "0x184A3B740")]
		private void OnProcessDirectory(string directory, bool hasMatchingFiles)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4A3BCF0", Offset = "0x4A3A8F0", VA = "0x184A3BCF0")]
		public void Scan(string directory, bool recurse)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4A3B8D0", Offset = "0x4A3A4D0", VA = "0x184A3B8D0")]
		private void ScanDir(string directory, bool recurse)
		{
		}

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x10")]
		public ProcessDirectoryHandler ProcessDirectory;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x18")]
		public ProcessFileHandler ProcessFile;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x20")]
		public CompletedFileHandler CompletedFile;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x28")]
		public DirectoryFailureHandler DirectoryFailure;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x30")]
		public FileFailureHandler FileFailure;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x38")]
		private IScanFilter fileFilter_;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x40")]
		private IScanFilter directoryFilter_;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x48")]
		private bool alive_;
	}
}
