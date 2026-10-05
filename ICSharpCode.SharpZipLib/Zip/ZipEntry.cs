using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public class ZipEntry : ICloneable
	{
		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x4A5B300", Offset = "0x4A59F00", VA = "0x184A5B300")]
		public ZipEntry(string name)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x4A5B2D0", Offset = "0x4A59ED0", VA = "0x184A5B2D0")]
		internal ZipEntry(string name, int versionRequiredToExtract)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x4A5B330", Offset = "0x4A59F30", VA = "0x184A5B330")]
		internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, CompressionMethod method)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x4A5B510", Offset = "0x4A5A110", VA = "0x184A5B510")]
		[Obsolete("Use Clone instead")]
		public ZipEntry(ZipEntry entry)
		{
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x170000A5")]
		public bool HasCrc
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x4A5B980", Offset = "0x4A5A580", VA = "0x184A5B980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000323 RID: 803 RVA: 0x00003828 File Offset: 0x00001A28
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A6")]
		public bool IsCrypted
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x4A5B990", Offset = "0x4A5A590", VA = "0x184A5B990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x4A5BFA0", Offset = "0x4A5ABA0", VA = "0x184A5BFA0")]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public bool IsUnicodeText
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x4A5BAA0", Offset = "0x4A5A6A0", VA = "0x184A5BAA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x4A5BFC0", Offset = "0x4A5ABC0", VA = "0x184A5BFC0")]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00003858 File Offset: 0x00001A58
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		internal byte CryptoCheckValue
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x37002A0", Offset = "0x36FEEA0", VA = "0x1837002A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x37002C0", Offset = "0x36FEEC0", VA = "0x1837002C0")]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00003870 File Offset: 0x00001A70
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A9")]
		public int Flags
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x4A5BF80", Offset = "0x4A5AB80", VA = "0x184A5BF80")]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AA")]
		public long ZipFileIndex
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x35378D0", Offset = "0x35364D0", VA = "0x1835378D0")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600032D RID: 813 RVA: 0x000038A0 File Offset: 0x00001AA0
		// (set) Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public long Offset
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x4A5BFE0", Offset = "0x4A5ABE0", VA = "0x184A5BFE0")]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600032F RID: 815 RVA: 0x000038B8 File Offset: 0x00001AB8
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		public int ExternalFileAttributes
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x4A5B970", Offset = "0x4A5A570", VA = "0x184A5B970")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x4A5BE70", Offset = "0x4A5AA70", VA = "0x184A5BE70")]
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000331 RID: 817 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x170000AD")]
		public int VersionMadeBy
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x4A5BB20", Offset = "0x4A5A720", VA = "0x184A5BB20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000332 RID: 818 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x170000AE")]
		public bool IsDOSEntry
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x4A5B9A0", Offset = "0x4A5A5A0", VA = "0x184A5B9A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x4A5AE20", Offset = "0x4A59A20", VA = "0x184A5AE20")]
		private bool HasDosAttributes(int attributes)
		{
			return default(bool);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		public int HostSystem
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1241200", Offset = "0x123FE00", VA = "0x181241200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x4A5BF90", Offset = "0x4A5AB90", VA = "0x184A5BF90")]
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x170000B0")]
		public int Version
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x4A5BB30", Offset = "0x4A5A730", VA = "0x184A5BB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x170000B1")]
		public bool CanDecompress
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x4A5B6C0", Offset = "0x4A5A2C0", VA = "0x184A5B6C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x4A5AE10", Offset = "0x4A59A10", VA = "0x184A5AE10")]
		public void ForceZip64()
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2109C30", Offset = "0x2108830", VA = "0x182109C30")]
		public bool IsZip64Forced()
		{
			return default(bool);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x170000B2")]
		public bool LocalHeaderRequiresZip64
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x4A5BAB0", Offset = "0x4A5A6B0", VA = "0x184A5BAB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x170000B3")]
		public bool CentralHeaderRequiresZip64
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x4A5B750", Offset = "0x4A5A350", VA = "0x184A5B750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B4")]
		public long DosTime
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x4A5B960", Offset = "0x4A5A560", VA = "0x184A5B960")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x4A5BE60", Offset = "0x4A5AA60", VA = "0x184A5BE60")]
			set
			{
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600033E RID: 830 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B5")]
		public DateTime DateTime
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x4A5B800", Offset = "0x4A5A400", VA = "0x184A5B800")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x4A5BD30", Offset = "0x4A5A930", VA = "0x184A5BD30")]
			set
			{
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x170000B6")]
		public string Name
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B7")]
		public long Size
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x4A5BB00", Offset = "0x4A5A700", VA = "0x184A5BB00")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x4A5BFF0", Offset = "0x4A5ABF0", VA = "0x184A5BFF0")]
			set
			{
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000343 RID: 835 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B8")]
		public long CompressedSize
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x4A5B7B0", Offset = "0x4A5A3B0", VA = "0x184A5B7B0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x4A5BCA0", Offset = "0x4A5A8A0", VA = "0x184A5BCA0")]
			set
			{
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00003A08 File Offset: 0x00001C08
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B9")]
		public long Crc
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x4A5B7E0", Offset = "0x4A5A3E0", VA = "0x184A5B7E0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x4A5BD20", Offset = "0x4A5A920", VA = "0x184A5BD20")]
			set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00003A20 File Offset: 0x00001C20
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BA")]
		public CompressionMethod CompressionMethod
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			get
			{
				return CompressionMethod.Stored;
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x4A5BCB0", Offset = "0x4A5A8B0", VA = "0x184A5BCB0")]
			set
			{
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x170000BB")]
		internal CompressionMethod CompressionMethodForHeader
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x4A5B7D0", Offset = "0x4A5A3D0", VA = "0x184A5B7D0")]
			get
			{
				return CompressionMethod.Stored;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		public byte[] ExtraData
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x4A5BE80", Offset = "0x4A5AA80", VA = "0x184A5BE80")]
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x170000BD")]
		internal int AESSaltLen
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x4A5B6B0", Offset = "0x4A5A2B0", VA = "0x184A5B6B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x170000BE")]
		internal int AESOverheadSize
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x4A5B6A0", Offset = "0x4A5A2A0", VA = "0x184A5B6A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x4A5AEE0", Offset = "0x4A59AE0", VA = "0x184A5AEE0")]
		internal void ProcessExtraData(bool localHeader)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x4A5AE80", Offset = "0x4A59A80", VA = "0x184A5AE80")]
		private void ProcessAESExtraData(ZipExtraData extraData)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BF")]
		public string Comment
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x4A5BC00", Offset = "0x4A5A800", VA = "0x184A5BC00")]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x170000C0")]
		public bool IsDirectory
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x4A5B9C0", Offset = "0x4A5A5C0", VA = "0x184A5B9C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x170000C1")]
		public bool IsFile
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x4A5BA50", Offset = "0x4A5A650", VA = "0x184A5BA50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x4A5AE60", Offset = "0x4A59A60", VA = "0x184A5AE60")]
		public bool IsCompressionMethodSupported()
		{
			return default(bool);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x4A5ACE0", Offset = "0x4A598E0", VA = "0x184A5ACE0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x4A5AE50", Offset = "0x4A59A50", VA = "0x184A5AE50")]
		public static bool IsCompressionMethodSupported(CompressionMethod method)
		{
			return default(bool);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x4A5ABB0", Offset = "0x4A597B0", VA = "0x184A5ABB0")]
		public static string CleanName(string name)
		{
			return null;
		}

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x10")]
		internal int AESKeySize;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x14")]
		private ZipEntry.Known known;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x18")]
		private int externalFileAttributes;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x1C")]
		private ushort versionMadeBy;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x28")]
		private ulong size;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x30")]
		private ulong compressedSize;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x38")]
		private ushort versionToExtract;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x3C")]
		private uint crc;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x40")]
		private uint dosTime;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x44")]
		private CompressionMethod method;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x48")]
		private byte[] extra;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x50")]
		private string comment;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x58")]
		private int flags;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x60")]
		private long zipFileIndex;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x68")]
		private long offset;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x70")]
		private bool forceZip64_;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x71")]
		private byte cryptoCheckValue_;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		[Flags]
		private enum Known : byte
		{
			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000284")]
			None = 0,
			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			Size = 1,
			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			CompressedSize = 2,
			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			Crc = 4,
			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			Time = 8,
			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			ExternalAttributes = 16
		}
	}
}
