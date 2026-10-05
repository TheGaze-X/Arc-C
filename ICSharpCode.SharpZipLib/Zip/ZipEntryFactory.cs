using System;
using ICSharpCode.SharpZipLib.Core;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class ZipEntryFactory : IEntryFactory
	{
		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x4A5F590", Offset = "0x4A5E190", VA = "0x184A5F590")]
		public ZipEntryFactory()
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x4A5F7B0", Offset = "0x4A5E3B0", VA = "0x184A5F7B0")]
		public ZipEntryFactory(ZipEntryFactory.TimeSetting timeSetting)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x4A5F640", Offset = "0x4A5E240", VA = "0x184A5F640")]
		public ZipEntryFactory(DateTime time)
		{
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C2")]
		public INameTransform NameTransform
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x4A5F930", Offset = "0x4A5E530", VA = "0x184A5F930", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00003AE0 File Offset: 0x00001CE0
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		public ZipEntryFactory.TimeSetting Setting
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return ZipEntryFactory.TimeSetting.LastWriteTime;
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			set
			{
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00003AF8 File Offset: 0x00001CF8
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C4")]
		public DateTime FixedDateTime
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x4A5F860", Offset = "0x4A5E460", VA = "0x184A5F860")]
			set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00003B10 File Offset: 0x00001D10
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		public int GetAttributes
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00003B28 File Offset: 0x00001D28
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		public int SetAttributes
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
			set
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00003B40 File Offset: 0x00001D40
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public bool IsUnicodeText
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x4EA840", Offset = "0x4E9440", VA = "0x1804EA840")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			set
			{
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x4A5F580", Offset = "0x4A5E180", VA = "0x184A5F580", Slot = "4")]
		public ZipEntry MakeFileEntry(string fileName)
		{
			return null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x4A5F300", Offset = "0x4A5DF00", VA = "0x184A5F300", Slot = "5")]
		public ZipEntry MakeFileEntry(string fileName, bool useFileSystem)
		{
			return null;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x4A5F080", Offset = "0x4A5DC80", VA = "0x184A5F080", Slot = "6")]
		public ZipEntry MakeDirectoryEntry(string directoryName)
		{
			return null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x4A5F090", Offset = "0x4A5DC90", VA = "0x184A5F090", Slot = "7")]
		public ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem)
		{
			return null;
		}

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x10")]
		private INameTransform nameTransform_;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x18")]
		private DateTime fixedDateTime_;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x20")]
		private ZipEntryFactory.TimeSetting timeSetting_;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x24")]
		private bool isUnicodeText_;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x28")]
		private int getAttributes_;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x2C")]
		private int setAttributes_;

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		public enum TimeSetting
		{
			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			LastWriteTime,
			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			LastWriteTimeUtc,
			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			CreateTime,
			// Token: 0x04000294 RID: 660
			[Token(Token = "0x4000294")]
			CreateTimeUtc,
			// Token: 0x04000295 RID: 661
			[Token(Token = "0x4000295")]
			LastAccessTime,
			// Token: 0x04000296 RID: 662
			[Token(Token = "0x4000296")]
			LastAccessTimeUtc,
			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			Fixed
		}
	}
}
