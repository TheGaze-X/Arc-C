using System;
using System.Text;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class TarHeader : ICloneable
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4A55680", Offset = "0x4A54280", VA = "0x184A55680")]
		public TarHeader()
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public string Name
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x4A55D60", Offset = "0x4A54960", VA = "0x184A55D60")]
			set
			{
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		[Obsolete("Use the Name property instead", true)]
		public string GetName()
		{
			return null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002BE0 File Offset: 0x00000DE0
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public int Mode
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002BF8 File Offset: 0x00000DF8
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		public int UserId
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002C10 File Offset: 0x00000E10
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public int GroupId
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public long Size
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x4A55DE0", Offset = "0x4A549E0", VA = "0x184A55DE0")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00002C40 File Offset: 0x00000E40
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public DateTime ModTime
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x4A55BB0", Offset = "0x4A547B0", VA = "0x184A55BB0")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x17000063")]
		public int Checksum
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x17000064")]
		public bool IsChecksumValid
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1DBF210", Offset = "0x1DBDE10", VA = "0x181DBF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002C88 File Offset: 0x00000E88
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public byte TypeFlag
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x4A55A10", Offset = "0x4A54610", VA = "0x184A55A10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x4A55E70", Offset = "0x4A54A70", VA = "0x184A55E70")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public string LinkName
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x4A55AB0", Offset = "0x4A546B0", VA = "0x184A55AB0")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public string Magic
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x4A55B30", Offset = "0x4A54730", VA = "0x184A55B30")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public string Version
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x4A55F50", Offset = "0x4A54B50", VA = "0x184A55F50")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		public string UserName
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x4A55E80", Offset = "0x4A54A80", VA = "0x184A55E80")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public string GroupName
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x4A55A40", Offset = "0x4A54640", VA = "0x184A55A40")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00002CA0 File Offset: 0x00000EA0
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public int DevMajor
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x4A559F0", Offset = "0x4A545F0", VA = "0x184A559F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x4A55A20", Offset = "0x4A54620", VA = "0x184A55A20")]
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public int DevMinor
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x4A55A00", Offset = "0x4A54600", VA = "0x184A55A00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x4A55A30", Offset = "0x4A54630", VA = "0x184A55A30")]
			set
			{
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x4A53E90", Offset = "0x4A52A90", VA = "0x184A53E90")]
		public void ParseBuffer(byte[] header)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4A54AB0", Offset = "0x4A536B0", VA = "0x184A54AB0")]
		public void WriteHeader(byte[] outBuffer)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4A53730", Offset = "0x4A52330", VA = "0x184A53730", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4A53130", Offset = "0x4A51D30", VA = "0x184A53130", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4A54950", Offset = "0x4A53550", VA = "0x184A54950")]
		internal static void SetValueDefaults(int userId, string userName, int groupId, string groupName)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x4A54890", Offset = "0x4A53490", VA = "0x184A54890")]
		internal static void RestoreSetValues()
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x4A547D0", Offset = "0x4A533D0", VA = "0x184A547D0")]
		public static long ParseOctal(byte[] header, int offset, int length)
		{
			return 0L;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x4A54570", Offset = "0x4A53170", VA = "0x184A54570")]
		public static StringBuilder ParseName(byte[] header, int offset, int length)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x4A53BD0", Offset = "0x4A527D0", VA = "0x184A53BD0")]
		public static int GetNameBytes(StringBuilder name, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			return 0;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x4A53910", Offset = "0x4A52510", VA = "0x184A53910")]
		public static int GetNameBytes(string name, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			return 0;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4A537D0", Offset = "0x4A523D0", VA = "0x184A537D0")]
		public static int GetNameBytes(StringBuilder name, byte[] buffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4A53A90", Offset = "0x4A52690", VA = "0x184A53A90")]
		public static int GetNameBytes(string name, byte[] buffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4A53300", Offset = "0x4A51F00", VA = "0x184A53300")]
		public static int GetAsciiBytes(string toAdd, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			return 0;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4A53D10", Offset = "0x4A52910", VA = "0x184A53D10")]
		public static int GetOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4A53750", Offset = "0x4A52350", VA = "0x184A53750")]
		public static int GetLongOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4A53500", Offset = "0x4A52100", VA = "0x184A53500")]
		private static int GetCheckSumOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4A530E0", Offset = "0x4A51CE0", VA = "0x184A530E0")]
		private static int ComputeCheckSum(byte[] buffer)
		{
			return 0;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x4A53E10", Offset = "0x4A52A10", VA = "0x184A53E10")]
		private static int MakeCheckSum(byte[] buffer)
		{
			return 0;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4A53440", Offset = "0x4A52040", VA = "0x184A53440")]
		private static int GetCTime(DateTime dateTime)
		{
			return 0;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x4A53640", Offset = "0x4A52240", VA = "0x184A53640")]
		private static DateTime GetDateTimeFromCTime(long ticks)
		{
			return default(DateTime);
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		public const int NAMELEN = 100;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		public const int MODELEN = 8;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		public const int UIDLEN = 8;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		public const int GIDLEN = 8;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		public const int CHKSUMLEN = 8;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		public const int CHKSUMOFS = 148;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		public const int SIZELEN = 12;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		public const int MAGICLEN = 6;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		public const int VERSIONLEN = 2;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		public const int MODTIMELEN = 12;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		public const int UNAMELEN = 32;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		public const int GNAMELEN = 32;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		public const int DEVLEN = 8;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		public const byte LF_OLDNORM = 0;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		public const byte LF_NORMAL = 48;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		public const byte LF_LINK = 49;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		public const byte LF_SYMLINK = 50;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		public const byte LF_CHR = 51;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		public const byte LF_BLK = 52;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		public const byte LF_DIR = 53;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		public const byte LF_FIFO = 54;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		public const byte LF_CONTIG = 55;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		public const byte LF_GHDR = 103;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		public const byte LF_XHDR = 120;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		public const byte LF_ACL = 65;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		public const byte LF_GNU_DUMPDIR = 68;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		public const byte LF_EXTATTR = 69;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		public const byte LF_META = 73;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		public const byte LF_GNU_LONGLINK = 75;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		public const byte LF_GNU_LONGNAME = 76;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		public const byte LF_GNU_MULTIVOL = 77;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		public const byte LF_GNU_NAMES = 78;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		public const byte LF_GNU_SPARSE = 83;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		public const byte LF_GNU_VOLHDR = 86;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		public const string TMAGIC = "ustar ";

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		public const string GNU_TMAGIC = "ustar  ";

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		private const long timeConversionFactor = 10000000L;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime dateTime1970;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x18")]
		private int mode;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x1C")]
		private int userId;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x20")]
		private int groupId;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x28")]
		private long size;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x30")]
		private DateTime modTime;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x38")]
		private int checksum;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x3C")]
		private bool isChecksumValid;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x3D")]
		private byte typeFlag;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x40")]
		private string linkName;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x48")]
		private string magic;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x50")]
		private string version;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x58")]
		private string userName;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x60")]
		private string groupName;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x68")]
		private int devMajor;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x6C")]
		private int devMinor;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x8")]
		internal static int userIdAsSet;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0xC")]
		internal static int groupIdAsSet;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		internal static string userNameAsSet;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		internal static string groupNameAsSet;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		internal static int defaultUserId;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x24")]
		internal static int defaultGroupId;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x28")]
		internal static string defaultGroupName;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x30")]
		internal static string defaultUser;
	}
}
