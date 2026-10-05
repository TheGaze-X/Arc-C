using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	public class FastZip
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x4A4BD00", Offset = "0x4A4A900", VA = "0x184A4BD00")]
		public FastZip()
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x4A4BC60", Offset = "0x4A4A860", VA = "0x184A4BC60")]
		public FastZip(FastZipEvents events)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00003720 File Offset: 0x00001920
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000099")]
		public bool CreateEmptyDirectories
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x4A4BD80", Offset = "0x4A4A980", VA = "0x184A4BD80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x4A4BDE0", Offset = "0x4A4A9E0", VA = "0x184A4BDE0")]
			set
			{
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009A")]
		public string Password
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			set
			{
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009B")]
		public INameTransform NameTransform
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x4A4BD90", Offset = "0x4A4A990", VA = "0x184A4BD90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x4A4BE60", Offset = "0x4A4AA60", VA = "0x184A4BE60")]
			set
			{
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009C")]
		public IEntryFactory EntryFactory
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x4A4BDF0", Offset = "0x4A4A9F0", VA = "0x184A4BDF0")]
			set
			{
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00003738 File Offset: 0x00001938
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		public UseZip64 UseZip64
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x1820C10", Offset = "0x181F810", VA = "0x181820C10")]
			get
			{
				return UseZip64.Off;
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x2B0B050", Offset = "0x2B09C50", VA = "0x182B0B050")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00003750 File Offset: 0x00001950
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public bool RestoreDateTimeOnExtract
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00003768 File Offset: 0x00001968
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		public bool RestoreAttributesOnExtract
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x2419880", Offset = "0x2418480", VA = "0x182419880")]
			set
			{
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x4A4A2B0", Offset = "0x4A48EB0", VA = "0x184A4A2B0")]
		public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4A4A310", Offset = "0x4A48F10", VA = "0x184A4A310")]
		public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4A4A370", Offset = "0x4A48F70", VA = "0x184A4A370")]
		public void CreateZip(Stream outputStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4A4B660", Offset = "0x4A4A260", VA = "0x184A4B660")]
		public void ExtractZip(string zipFileName, string targetDirectory, string fileFilter)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x4A4B700", Offset = "0x4A4A300", VA = "0x184A4B700")]
		public void ExtractZip(string zipFileName, string targetDirectory, FastZip.Overwrite overwrite, FastZip.ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter, bool restoreDateTime)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x4A4B010", Offset = "0x4A49C10", VA = "0x184A4B010")]
		public void ExtractZip(Stream inputStream, string targetDirectory, FastZip.Overwrite overwrite, FastZip.ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter, bool restoreDateTime, bool isStreamOwner)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x4A4B840", Offset = "0x4A4A440", VA = "0x184A4B840")]
		private void ProcessDirectory(object sender, DirectoryEventArgs e)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x4A4B980", Offset = "0x4A4A580", VA = "0x184A4B980")]
		private void ProcessFile(object sender, ScanEventArgs e)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x4A4A170", Offset = "0x4A48D70", VA = "0x184A4A170")]
		private void AddFileContents(string name, Stream stream)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x4A4AB20", Offset = "0x4A49720", VA = "0x184A4AB20")]
		private void ExtractFileEntry(ZipEntry entry, string targetName)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x4A4A8D0", Offset = "0x4A494D0", VA = "0x184A4A8D0")]
		private void ExtractEntry(ZipEntry entry)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x4A4B7A0", Offset = "0x4A4A3A0", VA = "0x184A4B7A0")]
		private static int MakeExternalAttributes(FileInfo info)
		{
			return 0;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4A4B7C0", Offset = "0x4A4A3C0", VA = "0x184A4B7C0")]
		private static bool NameIsValid(string name)
		{
			return default(bool);
		}

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x10")]
		private bool continueRunning_;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x18")]
		private byte[] buffer_;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x20")]
		private ZipOutputStream outputStream_;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x28")]
		private ZipFile zipFile_;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x30")]
		private string sourceDirectory_;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x38")]
		private NameFilter fileFilter_;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x40")]
		private NameFilter directoryFilter_;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x48")]
		private FastZip.Overwrite overwrite_;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x50")]
		private FastZip.ConfirmOverwriteDelegate confirmDelegate_;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x58")]
		private bool restoreDateTimeOnExtract_;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x59")]
		private bool restoreAttributesOnExtract_;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x5A")]
		private bool createEmptyDirectories_;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x60")]
		private FastZipEvents events_;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x68")]
		private IEntryFactory entryFactory_;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x70")]
		private INameTransform extractNameTransform_;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x78")]
		private UseZip64 useZip64_;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x80")]
		private string password_;

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000049")]
		public enum Overwrite
		{
			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			Prompt,
			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			Never,
			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			Always
		}

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060002FE RID: 766
		[Token(Token = "0x200004A")]
		public delegate bool ConfirmOverwriteDelegate(string fileName);
	}
}
