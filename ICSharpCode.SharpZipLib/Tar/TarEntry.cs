using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public class TarEntry : ICloneable
	{
		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4A52AA0", Offset = "0x4A516A0", VA = "0x184A52AA0")]
		private TarEntry()
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4A52B10", Offset = "0x4A51710", VA = "0x184A52B10")]
		public TarEntry(byte[] headerBuffer)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4A52BB0", Offset = "0x4A517B0", VA = "0x184A52BB0")]
		public TarEntry(TarHeader header)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4A51A60", Offset = "0x4A50660", VA = "0x184A51A60", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4A51CF0", Offset = "0x4A508F0", VA = "0x184A51CF0")]
		public static TarEntry CreateTarEntry(string name)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x4A51C80", Offset = "0x4A50880", VA = "0x184A51C80")]
		public static TarEntry CreateEntryFromFile(string fileName)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4A51D60", Offset = "0x4A50960", VA = "0x184A51D60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x4A52550", Offset = "0x4A51150", VA = "0x184A52550", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4A52580", Offset = "0x4A51180", VA = "0x184A52580")]
		public bool IsDescendent(TarEntry toTest)
		{
			return default(bool);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x17000053")]
		public TarHeader TarHeader
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		public string Name
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x4A52E10", Offset = "0x4A51A10", VA = "0x184A52E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x4A52F30", Offset = "0x4A51B30", VA = "0x184A52F30")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002B68 File Offset: 0x00000D68
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		public int UserId
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1E934D0", Offset = "0x1E920D0", VA = "0x181E934D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x4A52FE0", Offset = "0x4A51BE0", VA = "0x184A52FE0")]
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002B80 File Offset: 0x00000D80
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000056")]
		public int GroupId
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x4A52D50", Offset = "0x4A51950", VA = "0x184A52D50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x4A52E70", Offset = "0x4A51A70", VA = "0x184A52E70")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public string UserName
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x4A52E50", Offset = "0x4A51A50", VA = "0x184A52E50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x4A53000", Offset = "0x4A51C00", VA = "0x184A53000")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public string GroupName
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x4A52D70", Offset = "0x4A51970", VA = "0x184A52D70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x4A52E90", Offset = "0x4A51A90", VA = "0x184A52E90")]
			set
			{
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4A52920", Offset = "0x4A51520", VA = "0x184A52920")]
		public void SetIds(int userId, int groupId)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x4A52950", Offset = "0x4A51550", VA = "0x184A52950")]
		public void SetNames(string userName, string groupName)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002B98 File Offset: 0x00000D98
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public DateTime ModTime
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x5BA120", Offset = "0x5B8D20", VA = "0x1805BA120")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x4A52F10", Offset = "0x4A51B10", VA = "0x184A52F10")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x1700005A")]
		public string File
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public long Size
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x4A52E30", Offset = "0x4A51A30", VA = "0x184A52E30")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x4A52FC0", Offset = "0x4A51BC0", VA = "0x184A52FC0")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x1700005C")]
		public bool IsDirectory
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x4A52D90", Offset = "0x4A51990", VA = "0x184A52D90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x4A52020", Offset = "0x4A50C20", VA = "0x184A52020")]
		public void GetFileTarHeader(TarHeader header, string file)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x4A51E30", Offset = "0x4A50A30", VA = "0x184A51E30")]
		public TarEntry[] GetDirectoryEntries()
		{
			return null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x4A52A80", Offset = "0x4A51680", VA = "0x184A52A80")]
		public void WriteEntryHeader(byte[] outBuffer)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x4A518D0", Offset = "0x4A504D0", VA = "0x184A518D0")]
		public static void AdjustEntryName(byte[] buffer, string newName)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x4A52620", Offset = "0x4A51220", VA = "0x184A52620")]
		public static void NameTarHeader(TarHeader header, string name)
		{
		}

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x10")]
		private string file;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		private TarHeader header;
	}
}
