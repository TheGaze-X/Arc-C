using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class TarArchive : IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event ProgressMessageHandler ProgressMessageEvent
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x4A44A00", Offset = "0x4A43600", VA = "0x184A44A00")]
			[MethodImpl(32)]
			add
			{
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x4A44EC0", Offset = "0x4A43AC0", VA = "0x184A44EC0")]
			[MethodImpl(32)]
			remove
			{
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x4A43C90", Offset = "0x4A42890", VA = "0x184A43C90", Slot = "5")]
		protected virtual void OnProgressMessageEvent(TarEntry entry, string message)
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x4A447D0", Offset = "0x4A433D0", VA = "0x184A447D0")]
		protected TarArchive()
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x4A44840", Offset = "0x4A43440", VA = "0x184A44840")]
		protected TarArchive(TarInputStream stream)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x4A44920", Offset = "0x4A43520", VA = "0x184A44920")]
		protected TarArchive(TarOutputStream stream)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x4A42E30", Offset = "0x4A41A30", VA = "0x184A42E30")]
		public static TarArchive CreateInputTarArchive(Stream inputStream)
		{
			return null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x4A42C20", Offset = "0x4A41820", VA = "0x184A42C20")]
		public static TarArchive CreateInputTarArchive(Stream inputStream, int blockFactor)
		{
			return null;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x4A43170", Offset = "0x4A41D70", VA = "0x184A43170")]
		public static TarArchive CreateOutputTarArchive(Stream outputStream)
		{
			return null;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x4A42F60", Offset = "0x4A41B60", VA = "0x184A42F60")]
		public static TarArchive CreateOutputTarArchive(Stream outputStream, int blockFactor)
		{
			return null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x4A43D30", Offset = "0x4A42930", VA = "0x184A43D30")]
		public void SetKeepOldFiles(bool keepExistingFiles)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		public bool AsciiTranslate
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x4A44B10", Offset = "0x4A43710", VA = "0x184A44B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x4A44FD0", Offset = "0x4A43BD0", VA = "0x184A44FD0")]
			set
			{
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4A43CC0", Offset = "0x4A428C0", VA = "0x184A43CC0")]
		[Obsolete("Use the AsciiTranslate property")]
		public void SetAsciiTranslation(bool translateAsciiFiles)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public string PathPrefix
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x4A44C60", Offset = "0x4A43860", VA = "0x184A44C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x4A45080", Offset = "0x4A43C80", VA = "0x184A45080")]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public string RootPath
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x4A44D70", Offset = "0x4A43970", VA = "0x184A44D70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x4A45100", Offset = "0x4A43D00", VA = "0x184A45100")]
			set
			{
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4A43DA0", Offset = "0x4A429A0", VA = "0x184A43DA0")]
		public void SetUserInfo(int userId, string userName, int groupId, string groupName)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public bool ApplyUserInfoOverrides
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x4A44AA0", Offset = "0x4A436A0", VA = "0x184A44AA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x4A44F60", Offset = "0x4A43B60", VA = "0x184A44F60")]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x17000048")]
		public int UserId
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x4A44DE0", Offset = "0x4A439E0", VA = "0x184A44DE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x17000049")]
		public string UserName
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x4A44E50", Offset = "0x4A43A50", VA = "0x184A44E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x1700004A")]
		public int GroupId
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x4A44B80", Offset = "0x4A43780", VA = "0x184A44B80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x1700004B")]
		public string GroupName
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x4A44BF0", Offset = "0x4A437F0", VA = "0x184A44BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x1700004C")]
		public int RecordSize
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x4A44CD0", Offset = "0x4A438D0", VA = "0x184A44CD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004D RID: 77
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x4A45040", Offset = "0x4A43C40", VA = "0x184A45040")]
			set
			{
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x3264D80", Offset = "0x3263980", VA = "0x183264D80")]
		[Obsolete("Use Close instead")]
		public void CloseArchive()
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4A43BC0", Offset = "0x4A427C0", VA = "0x184A43BC0")]
		public void ListContents()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4A434C0", Offset = "0x4A420C0", VA = "0x184A434C0")]
		public void ExtractContents(string destinationDirectory)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x4A43570", Offset = "0x4A42170", VA = "0x184A43570")]
		private void ExtractEntry(string destDir, TarEntry entry)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4A445C0", Offset = "0x4A431C0", VA = "0x184A445C0")]
		public void WriteEntry(TarEntry sourceEntry, bool recurse)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4A43E40", Offset = "0x4A42A40", VA = "0x184A43E40")]
		private void WriteEntryCore(TarEntry sourceEntry, bool recurse)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4A432A0", Offset = "0x4A41EA0", VA = "0x184A432A0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4A43310", Offset = "0x4A41F10", VA = "0x184A43310", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x36E2920", Offset = "0x36E1520", VA = "0x1836E2920", Slot = "7")]
		public virtual void Close()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x36E2960", Offset = "0x36E1560", VA = "0x1836E2960", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4A433D0", Offset = "0x4A41FD0", VA = "0x184A433D0")]
		private static void EnsureDirectoryExists(string directoryName)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4A439E0", Offset = "0x4A425E0", VA = "0x184A439E0")]
		private static bool IsBinary(string filename)
		{
			return default(bool);
		}

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x18")]
		private bool keepOldFiles;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x19")]
		private bool asciiTranslate;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x1C")]
		private int userId;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x20")]
		private string userName;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x28")]
		private int groupId;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x30")]
		private string groupName;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x38")]
		private string rootPath;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x40")]
		private string pathPrefix;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x48")]
		private bool applyUserInfoOverrides;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x50")]
		private TarInputStream tarIn;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x58")]
		private TarOutputStream tarOut;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x60")]
		private bool isDisposed;
	}
}
