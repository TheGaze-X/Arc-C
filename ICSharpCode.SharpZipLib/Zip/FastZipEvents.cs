using System;
using ICSharpCode.SharpZipLib.Core;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class FastZipEvents
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x4A49E60", Offset = "0x4A48A60", VA = "0x184A49E60")]
		public bool OnDirectoryFailure(string directory, Exception e)
		{
			return default(bool);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4A49F10", Offset = "0x4A48B10", VA = "0x184A49F10")]
		public bool OnFileFailure(string file, Exception e)
		{
			return default(bool);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x4A4A070", Offset = "0x4A48C70", VA = "0x184A4A070")]
		public bool OnProcessFile(string file)
		{
			return default(bool);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x4A49DC0", Offset = "0x4A489C0", VA = "0x184A49DC0")]
		public bool OnCompletedFile(string file)
		{
			return default(bool);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x4A49FC0", Offset = "0x4A48BC0", VA = "0x184A49FC0")]
		public bool OnProcessDirectory(string directory, bool hasMatchingFiles)
		{
			return default(bool);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00003708 File Offset: 0x00001908
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000098")]
		public TimeSpan ProgressInterval
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x1692860", Offset = "0x1691460", VA = "0x181692860")]
			set
			{
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x4A4A110", Offset = "0x4A48D10", VA = "0x184A4A110")]
		public FastZipEvents()
		{
		}

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x10")]
		public ProcessDirectoryHandler ProcessDirectory;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x18")]
		public ProcessFileHandler ProcessFile;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x20")]
		public ProgressHandler Progress;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x28")]
		public CompletedFileHandler CompletedFile;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x30")]
		public DirectoryFailureHandler DirectoryFailure;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x38")]
		public FileFailureHandler FileFailure;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x40")]
		private TimeSpan progressInterval_;
	}
}
