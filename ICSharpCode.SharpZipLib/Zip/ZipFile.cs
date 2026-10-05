using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Core;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public class ZipFile : IEnumerable, IDisposable
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x4A65F70", Offset = "0x4A64B70", VA = "0x184A65F70")]
		private void OnKeysRequired(string fileName)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E0")]
		private byte[] Key
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			set
			{
			}
		}

		// Token: 0x170000E1 RID: 225
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E1")]
		public string Password
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x4A6CEE0", Offset = "0x4A6BAE0", VA = "0x184A6CEE0")]
			set
			{
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x170000E2")]
		private bool HaveKeys
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x4A6CC20", Offset = "0x4A6B820", VA = "0x184A6CC20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x4A6C7A0", Offset = "0x4A6B3A0", VA = "0x184A6C7A0")]
		public ZipFile(string name)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x4A6C910", Offset = "0x4A6B510", VA = "0x184A6C910")]
		public ZipFile(FileStream file)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x4A6C4A0", Offset = "0x4A6B0A0", VA = "0x184A6C4A0")]
		public ZipFile(Stream stream)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x4A6C6E0", Offset = "0x4A6B2E0", VA = "0x184A6C6E0")]
		internal ZipFile()
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x36E2960", Offset = "0x36E1560", VA = "0x1836E2960", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x4A62E40", Offset = "0x4A61A40", VA = "0x184A62E40")]
		public void Close()
		{
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x4A644D0", Offset = "0x4A630D0", VA = "0x184A644D0")]
		public static ZipFile Create(string fileName)
		{
			return null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x4A645C0", Offset = "0x4A631C0", VA = "0x184A645C0")]
		public static ZipFile Create(Stream outStream)
		{
			return null;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00003DF8 File Offset: 0x00001FF8
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E3")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x170000E4")]
		public bool IsEmbeddedArchive
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x4A6CC30", Offset = "0x4A6B830", VA = "0x184A6CC30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x170000E5")]
		public bool IsNewArchive
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x170000E6")]
		public string ZipFileComment
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x170000E7")]
		public string Name
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x170000E8")]
		[Obsolete("Use the Count property instead")]
		public int Size
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x4A6CCA0", Offset = "0x4A6B8A0", VA = "0x184A6CCA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x170000E9")]
		public long Count
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x4A6CB20", Offset = "0x4A6B720", VA = "0x184A6CB20")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000EA RID: 234
		[Token(Token = "0x170000EA")]
		[IndexerName("EntryByIndex")]
		public ZipEntry this[int index]
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x4A6CB40", Offset = "0x4A6B740", VA = "0x184A6CB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x4A651D0", Offset = "0x4A63DD0", VA = "0x184A651D0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x4A64C30", Offset = "0x4A63830", VA = "0x184A64C30")]
		public int FindEntry(string name, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x4A65060", Offset = "0x4A63C60", VA = "0x184A65060")]
		public ZipEntry GetEntry(string name)
		{
			return null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x4A652A0", Offset = "0x4A63EA0", VA = "0x184A652A0")]
		public Stream GetInputStream(ZipEntry entry)
		{
			return null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x4A65470", Offset = "0x4A64070", VA = "0x184A65470")]
		public Stream GetInputStream(long entryIndex)
		{
			return null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x4A69CA0", Offset = "0x4A688A0", VA = "0x184A69CA0")]
		public bool TestArchive(bool testData)
		{
			return default(bool);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x4A69510", Offset = "0x4A68110", VA = "0x184A69510")]
		public bool TestArchive(bool testData, TestStrategy strategy, ZipTestResultHandler resultHandler)
		{
			return default(bool);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x4A69CC0", Offset = "0x4A688C0", VA = "0x184A69CC0")]
		private long TestLocalHeader(ZipEntry entry, ZipFile.HeaderTest tests)
		{
			return 0L;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EB")]
		public INameTransform NameTransform
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x4A6CC50", Offset = "0x4A6B850", VA = "0x184A6CC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x4A6CDF0", Offset = "0x4A6B9F0", VA = "0x184A6CDF0")]
			set
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000230A File Offset: 0x0000050A
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EC")]
		public IEntryFactory EntryFactory
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x4A6CD70", Offset = "0x4A6B970", VA = "0x184A6CD70")]
			set
			{
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00003ED0 File Offset: 0x000020D0
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000ED")]
		public int BufferSize
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x42BAD30", Offset = "0x42B9930", VA = "0x1842BAD30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x4A6CCC0", Offset = "0x4A6B8C0", VA = "0x184A6CCC0")]
			set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x170000EE")]
		public bool IsUpdating
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x4A6CC40", Offset = "0x4A6B840", VA = "0x184A6CC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00003F00 File Offset: 0x00002100
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EF")]
		public UseZip64 UseZip64
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x12905C0", Offset = "0x128F1C0", VA = "0x1812905C0")]
			get
			{
				return UseZip64.Off;
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x4A6CF70", Offset = "0x4A6BB70", VA = "0x184A6CF70")]
			set
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x4A62430", Offset = "0x4A61030", VA = "0x184A62430")]
		public void BeginUpdate(IArchiveStorage archiveStorage, IDynamicDataSource dataSource)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x4A62C70", Offset = "0x4A61870", VA = "0x184A62C70")]
		public void BeginUpdate(IArchiveStorage archiveStorage)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x4A62B20", Offset = "0x4A61720", VA = "0x184A62B20")]
		public void BeginUpdate()
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x4A62EA0", Offset = "0x4A61AA0", VA = "0x184A62EA0")]
		public void CommitUpdate()
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x4A60F60", Offset = "0x4A5FB60", VA = "0x184A60F60")]
		public void AbortUpdate()
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x4A69370", Offset = "0x4A67F70", VA = "0x184A69370")]
		public void SetComment(string comment)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x4A615B0", Offset = "0x4A601B0", VA = "0x184A615B0")]
		private void AddUpdate(ZipFile.ZipUpdate update)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x4A62210", Offset = "0x4A60E10", VA = "0x184A62210")]
		public void Add(string fileName, CompressionMethod compressionMethod, bool useUnicodeText)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x4A61BC0", Offset = "0x4A607C0", VA = "0x184A61BC0")]
		public void Add(string fileName, CompressionMethod compressionMethod)
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x4A61A60", Offset = "0x4A60660", VA = "0x184A61A60")]
		public void Add(string fileName)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x4A62090", Offset = "0x4A60C90", VA = "0x184A62090")]
		public void Add(string fileName, string entryName)
		{
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x4A61F10", Offset = "0x4A60B10", VA = "0x184A61F10")]
		public void Add(IStaticDataSource dataSource, string entryName)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x4A61D60", Offset = "0x4A60960", VA = "0x184A61D60")]
		public void Add(IStaticDataSource dataSource, string entryName, CompressionMethod compressionMethod)
		{
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x4A618B0", Offset = "0x4A604B0", VA = "0x184A618B0")]
		public void Add(IStaticDataSource dataSource, string entryName, CompressionMethod compressionMethod, bool useUnicodeText)
		{
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x4A61750", Offset = "0x4A60350", VA = "0x184A61750")]
		public void Add(ZipEntry entry)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x4A60F70", Offset = "0x4A5FB70", VA = "0x184A60F70")]
		public void AddDirectory(string directoryName)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x4A647B0", Offset = "0x4A633B0", VA = "0x184A647B0")]
		public bool Delete(string fileName)
		{
			return default(bool);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x4A64910", Offset = "0x4A63510", VA = "0x184A64910")]
		public void Delete(ZipEntry entry)
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x4A6BC80", Offset = "0x4A6A880", VA = "0x184A6BC80")]
		private void WriteLEShort(int value)
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x4A6BDB0", Offset = "0x4A6A9B0", VA = "0x184A6BDB0")]
		private void WriteLEUshort(ushort value)
		{
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x4A6BC40", Offset = "0x4A6A840", VA = "0x184A6BC40")]
		private void WriteLEInt(int value)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x4A6BD10", Offset = "0x4A6A910", VA = "0x184A6BD10")]
		private void WriteLEUint(uint value)
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x4A6BE50", Offset = "0x4A6AA50", VA = "0x184A6BE50")]
		private void WriteLeLong(long value)
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x4A6BD50", Offset = "0x4A6A950", VA = "0x184A6BD50")]
		private void WriteLEUlong(ulong value)
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x4A6BEB0", Offset = "0x4A6AAB0", VA = "0x184A6BEB0")]
		private void WriteLocalEntryHeader(ZipFile.ZipUpdate update)
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x4A6B470", Offset = "0x4A6A070", VA = "0x184A6B470")]
		private int WriteCentralDirectoryHeader(ZipEntry entry)
		{
			return 0;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x4A66080", Offset = "0x4A64C80", VA = "0x184A66080")]
		private void PostUpdateCleanup()
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x4A65AA0", Offset = "0x4A646A0", VA = "0x184A65AA0")]
		private string GetTransformedFileName(string name)
		{
			return null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x4A65A00", Offset = "0x4A64600", VA = "0x184A65A00")]
		private string GetTransformedDirectoryName(string name)
		{
			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x4A64FB0", Offset = "0x4A63BB0", VA = "0x184A64FB0")]
		private byte[] GetBuffer()
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x4A63640", Offset = "0x4A62240", VA = "0x184A63640")]
		private void CopyDescriptorBytes(ZipFile.ZipUpdate update, Stream dest, Stream source)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x4A63170", Offset = "0x4A61D70", VA = "0x184A63170")]
		private void CopyBytes(ZipFile.ZipUpdate update, Stream destination, Stream source, long bytesToCopy, bool updateCrc)
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x4A65020", Offset = "0x4A63C20", VA = "0x184A65020")]
		private int GetDescriptorSize(ZipFile.ZipUpdate update)
		{
			return 0;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x4A63460", Offset = "0x4A62060", VA = "0x184A63460")]
		private void CopyDescriptorBytesDirect(ZipFile.ZipUpdate update, Stream stream, ref long destinationPosition, long sourcePosition)
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x4A637E0", Offset = "0x4A623E0", VA = "0x184A637E0")]
		private void CopyEntryDataDirect(ZipFile.ZipUpdate update, Stream stream, bool updateCrc, ref long destinationPosition, ref long sourcePosition)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x4A64EA0", Offset = "0x4A63AA0", VA = "0x184A64EA0")]
		private int FindExistingUpdate(ZipEntry entry)
		{
			return 0;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x4A64D90", Offset = "0x4A63990", VA = "0x184A64D90")]
		private int FindExistingUpdate(string fileName)
		{
			return 0;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x4A65800", Offset = "0x4A64400", VA = "0x184A65800")]
		private Stream GetOutputStream(ZipEntry entry)
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x4A61090", Offset = "0x4A5FC90", VA = "0x184A61090")]
		private void AddEntry(ZipFile workFile, ZipFile.ZipUpdate update)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x4A65CD0", Offset = "0x4A648D0", VA = "0x184A65CD0")]
		private void ModifyEntry(ZipFile workFile, ZipFile.ZipUpdate update)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x4A63B30", Offset = "0x4A62730", VA = "0x184A63B30")]
		private void CopyEntryDirect(ZipFile workFile, ZipFile.ZipUpdate update, ref long destinationPosition)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x4A63DB0", Offset = "0x4A629B0", VA = "0x184A63DB0")]
		private void CopyEntry(ZipFile workFile, ZipFile.ZipUpdate update)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x4A66DA0", Offset = "0x4A659A0", VA = "0x184A66DA0")]
		private void Reopen(Stream source)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x4A66E20", Offset = "0x4A65A20", VA = "0x184A66E20")]
		private void Reopen()
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x4A6AE90", Offset = "0x4A69A90", VA = "0x184A6AE90")]
		private void UpdateCommentOnly()
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x4A66F20", Offset = "0x4A65B20", VA = "0x184A66F20")]
		private void RunUpdates()
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x4A62DD0", Offset = "0x4A619D0", VA = "0x184A62DD0")]
		private void CheckUpdating()
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x4A62E40", Offset = "0x4A61A40", VA = "0x184A62E40", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x4A64B10", Offset = "0x4A63710", VA = "0x184A64B10")]
		private void DisposeInternal(bool disposing)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x4A64C20", Offset = "0x4A63820", VA = "0x184A64C20", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x4A66C60", Offset = "0x4A65860", VA = "0x184A66C60")]
		private ushort ReadLEUshort()
		{
			return 0;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x4A66BA0", Offset = "0x4A657A0", VA = "0x184A66BA0")]
		private uint ReadLEUint()
		{
			return 0U;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x4A66BE0", Offset = "0x4A657E0", VA = "0x184A66BE0")]
		private ulong ReadLEUlong()
		{
			return 0UL;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x4A65B40", Offset = "0x4A64740", VA = "0x184A65B40")]
		private long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
		{
			return 0L;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x4A66120", Offset = "0x4A64D20", VA = "0x184A66120")]
		private void ReadEntries()
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x4A65CC0", Offset = "0x4A648C0", VA = "0x184A65CC0")]
		private long LocateEntry(ZipEntry entry)
		{
			return 0L;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x4A64070", Offset = "0x4A62C70", VA = "0x184A64070")]
		private Stream CreateAndInitDecryptionStream(Stream baseStream, ZipEntry entry)
		{
			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x4A642E0", Offset = "0x4A62EE0", VA = "0x184A642E0")]
		private Stream CreateAndInitEncryptionStream(Stream baseStream, ZipEntry entry)
		{
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x4A62CF0", Offset = "0x4A618F0", VA = "0x184A62CF0")]
		private static void CheckClassicPassword(CryptoStream classicCryptoStream, ZipEntry entry)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x4A6BB20", Offset = "0x4A6A720", VA = "0x184A6BB20")]
		private static void WriteEncryptionHeader(Stream stream, long crcValue)
		{
		}

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		private const int DefaultBufferSize = 4096;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x10")]
		public ZipFile.KeysRequiredEventHandler KeysRequired;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x18")]
		private bool isDisposed_;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x20")]
		private string name_;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x28")]
		private string comment_;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x30")]
		private string rawPassword_;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x38")]
		private Stream baseStream_;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x40")]
		private bool isStreamOwner;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x48")]
		private long offsetOfFirstEntry;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x50")]
		private ZipEntry[] entries_;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x58")]
		private byte[] key;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x60")]
		private bool isNewArchive_;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x64")]
		private UseZip64 useZip64_;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x68")]
		private ArrayList updates_;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x70")]
		private long updateCount_;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x78")]
		private Hashtable updateIndex_;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x80")]
		private IArchiveStorage archiveStorage_;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x88")]
		private IDynamicDataSource updateDataSource_;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x90")]
		private bool contentsEdited_;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x94")]
		private int bufferSize_;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x98")]
		private byte[] copyBuffer_;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0xA0")]
		private ZipFile.ZipString newComment_;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0xA8")]
		private bool commentEdited_;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0xB0")]
		private IEntryFactory updateEntryFactory_;

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x0600042A RID: 1066
		[Token(Token = "0x2000066")]
		public delegate void KeysRequiredEventHandler(object sender, KeysRequiredEventArgs e);

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		[Flags]
		private enum HeaderTest
		{
			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x40002D8")]
			Extract = 1,
			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x40002D9")]
			Header = 2
		}

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		private enum UpdateCommand
		{
			// Token: 0x040002DB RID: 731
			[Token(Token = "0x40002DB")]
			Copy,
			// Token: 0x040002DC RID: 732
			[Token(Token = "0x40002DC")]
			Modify,
			// Token: 0x040002DD RID: 733
			[Token(Token = "0x40002DD")]
			Add
		}

		// Token: 0x02000069 RID: 105
		[Token(Token = "0x2000069")]
		private class UpdateComparer : IComparer
		{
			// Token: 0x0600042D RID: 1069 RVA: 0x00004008 File Offset: 0x00002208
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x4A5EE90", Offset = "0x4A5DA90", VA = "0x184A5EE90", Slot = "4")]
			public int Compare(object x, object y)
			{
				return 0;
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UpdateComparer()
			{
			}
		}

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		private class ZipUpdate
		{
			// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x4A73B50", Offset = "0x4A72750", VA = "0x184A73B50")]
			public ZipUpdate(string fileName, ZipEntry entry)
			{
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x4A73C50", Offset = "0x4A72850", VA = "0x184A73C50")]
			[Obsolete]
			public ZipUpdate(string fileName, string entryName, CompressionMethod compressionMethod)
			{
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x4A73A70", Offset = "0x4A72670", VA = "0x184A73A70")]
			[Obsolete]
			public ZipUpdate(string fileName, string entryName)
			{
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x4A73990", Offset = "0x4A72590", VA = "0x184A73990")]
			[Obsolete]
			public ZipUpdate(IStaticDataSource dataSource, string entryName, CompressionMethod compressionMethod)
			{
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x4A73D30", Offset = "0x4A72930", VA = "0x184A73D30")]
			public ZipUpdate(IStaticDataSource dataSource, ZipEntry entry)
			{
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x4A73BD0", Offset = "0x4A727D0", VA = "0x184A73BD0")]
			public ZipUpdate(ZipEntry original, ZipEntry updated)
			{
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x4A73820", Offset = "0x4A72420", VA = "0x184A73820")]
			public ZipUpdate(ZipFile.UpdateCommand command, ZipEntry entry)
			{
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x4A73BC0", Offset = "0x4A727C0", VA = "0x184A73BC0")]
			public ZipUpdate(ZipEntry entry)
			{
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x170000F0")]
			public ZipEntry Entry
			{
				[Token(Token = "0x6000437")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x170000F1")]
			public ZipEntry OutEntry
			{
				[Token(Token = "0x6000438")]
				[Address(RVA = "0x4A73DA0", Offset = "0x4A729A0", VA = "0x184A73DA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x00004020 File Offset: 0x00002220
			[Token(Token = "0x170000F2")]
			public ZipFile.UpdateCommand Command
			{
				[Token(Token = "0x6000439")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return ZipFile.UpdateCommand.Copy;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x170000F3")]
			public string Filename
			{
				[Token(Token = "0x600043A")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x0600043B RID: 1083 RVA: 0x00004038 File Offset: 0x00002238
			// (set) Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F4")]
			public long SizePatchOffset
			{
				[Token(Token = "0x600043B")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x600043C")]
				[Address(RVA = "0x1796DB0", Offset = "0x17959B0", VA = "0x181796DB0")]
				set
				{
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x0600043D RID: 1085 RVA: 0x00004050 File Offset: 0x00002250
			// (set) Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F5")]
			public long CrcPatchOffset
			{
				[Token(Token = "0x600043D")]
				[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x1692860", Offset = "0x1691460", VA = "0x181692860")]
				set
				{
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x0600043F RID: 1087 RVA: 0x00004068 File Offset: 0x00002268
			// (set) Token: 0x06000440 RID: 1088 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F6")]
			public long OffsetBasedSize
			{
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6000440")]
				[Address(RVA = "0x1692850", Offset = "0x1691450", VA = "0x181692850")]
				set
				{
				}
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x4A737D0", Offset = "0x4A723D0", VA = "0x184A737D0")]
			public Stream GetSource()
			{
				return null;
			}

			// Token: 0x040002DE RID: 734
			[Token(Token = "0x40002DE")]
			[FieldOffset(Offset = "0x10")]
			private ZipEntry entry_;

			// Token: 0x040002DF RID: 735
			[Token(Token = "0x40002DF")]
			[FieldOffset(Offset = "0x18")]
			private ZipEntry outEntry_;

			// Token: 0x040002E0 RID: 736
			[Token(Token = "0x40002E0")]
			[FieldOffset(Offset = "0x20")]
			private ZipFile.UpdateCommand command_;

			// Token: 0x040002E1 RID: 737
			[Token(Token = "0x40002E1")]
			[FieldOffset(Offset = "0x28")]
			private IStaticDataSource dataSource_;

			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x40002E2")]
			[FieldOffset(Offset = "0x30")]
			private string filename_;

			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			[FieldOffset(Offset = "0x38")]
			private long sizePatchOffset_;

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x40")]
			private long crcPatchOffset_;

			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x48")]
			private long _offsetBasedSize;
		}

		// Token: 0x0200006B RID: 107
		[Token(Token = "0x200006B")]
		private class ZipString
		{
			// Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x4A73650", Offset = "0x4A72250", VA = "0x184A73650")]
			public ZipString(string comment)
			{
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
			public ZipString(byte[] rawString)
			{
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x00004080 File Offset: 0x00002280
			[Token(Token = "0x170000F7")]
			public bool IsSourceString
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x00004098 File Offset: 0x00002298
			[Token(Token = "0x170000F8")]
			public int RawLength
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x4A73720", Offset = "0x4A72320", VA = "0x184A73720")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x06000446 RID: 1094 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x170000F9")]
			public byte[] RawComment
			{
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x4A73690", Offset = "0x4A72290", VA = "0x184A73690")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x4A73610", Offset = "0x4A72210", VA = "0x184A73610")]
			public void Reset()
			{
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x4A735A0", Offset = "0x4A721A0", VA = "0x184A735A0")]
			private void MakeTextAvailable()
			{
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x4A73530", Offset = "0x4A72130", VA = "0x184A73530")]
			private void MakeBytesAvailable()
			{
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x4A73750", Offset = "0x4A72350", VA = "0x184A73750")]
			public static implicit operator string(ZipFile.ZipString zipString)
			{
				return null;
			}

			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x10")]
			private string comment_;

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x18")]
			private byte[] rawComment_;

			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x20")]
			private bool isSourceString_;
		}

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		private class ZipEntryEnumerator : IEnumerator
		{
			// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x4A5F040", Offset = "0x4A5DC40", VA = "0x184A5F040")]
			public ZipEntryEnumerator(ZipEntry[] entries)
			{
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000230A File Offset: 0x0000050A
			[Token(Token = "0x170000FA")]
			public object Current
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x488E260", Offset = "0x488CE60", VA = "0x18488E260", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "6")]
			public void Reset()
			{
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x000040B0 File Offset: 0x000022B0
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x4A5F010", Offset = "0x4A5DC10", VA = "0x184A5F010", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x10")]
			private ZipEntry[] array;

			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			[FieldOffset(Offset = "0x18")]
			private int index;
		}

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		private class UncompressedStream : Stream
		{
			// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x4A5EDD0", Offset = "0x4A5D9D0", VA = "0x184A5EDD0")]
			public UncompressedStream(Stream baseStream)
			{
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
			public override void Close()
			{
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x000040C8 File Offset: 0x000022C8
			[Token(Token = "0x170000FB")]
			public override bool CanRead
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x4A3E4A0", Offset = "0x4A3D0A0", VA = "0x184A3E4A0", Slot = "20")]
			public override void Flush()
			{
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000453 RID: 1107 RVA: 0x000040E0 File Offset: 0x000022E0
			[Token(Token = "0x170000FC")]
			public override bool CanWrite
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x4A5EE40", Offset = "0x4A5DA40", VA = "0x184A5EE40", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x000040F8 File Offset: 0x000022F8
			[Token(Token = "0x170000FD")]
			public override bool CanSeek
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000455 RID: 1109 RVA: 0x00004110 File Offset: 0x00002310
			[Token(Token = "0x170000FE")]
			public override long Length
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x00004128 File Offset: 0x00002328
			// (set) Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000FF")]
			public override long Position
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x4A3F790", Offset = "0x4A3E390", VA = "0x184A3F790", Slot = "12")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
				set
				{
				}
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x00004140 File Offset: 0x00002340
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "32")]
			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00004158 File Offset: 0x00002358
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "30")]
			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
			public override void SetLength(long value)
			{
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x4A5ED50", Offset = "0x4A5D950", VA = "0x184A5ED50", Slot = "35")]
			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0x28")]
			private Stream baseStream_;
		}

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		private class PartialInputStream : Stream
		{
			// Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x4A5E890", Offset = "0x4A5D490", VA = "0x184A5E890")]
			public PartialInputStream(ZipFile zipFile, long start, long length)
			{
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x00004170 File Offset: 0x00002370
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x4A5E460", Offset = "0x4A5D060", VA = "0x184A5E460", Slot = "34")]
			public override int ReadByte()
			{
				return 0;
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
			public override void Close()
			{
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x00004188 File Offset: 0x00002388
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x4A5E590", Offset = "0x4A5D190", VA = "0x184A5E590", Slot = "32")]
			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x4A5E840", Offset = "0x4A5D440", VA = "0x184A5E840", Slot = "35")]
			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x4A5E7F0", Offset = "0x4A5D3F0", VA = "0x184A5E7F0", Slot = "31")]
			public override void SetLength(long value)
			{
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x000041A0 File Offset: 0x000023A0
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x4A5E700", Offset = "0x4A5D300", VA = "0x184A5E700", Slot = "30")]
			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
			public override void Flush()
			{
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000464 RID: 1124 RVA: 0x000041B8 File Offset: 0x000023B8
			// (set) Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000100")]
			public override long Position
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x4A5E950", Offset = "0x4A5D550", VA = "0x184A5E950", Slot = "12")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x4A5E960", Offset = "0x4A5D560", VA = "0x184A5E960", Slot = "13")]
				set
				{
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000466 RID: 1126 RVA: 0x000041D0 File Offset: 0x000023D0
			[Token(Token = "0x17000101")]
			public override long Length
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "11")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000467 RID: 1127 RVA: 0x000041E8 File Offset: 0x000023E8
			[Token(Token = "0x17000102")]
			public override bool CanWrite
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000468 RID: 1128 RVA: 0x00004200 File Offset: 0x00002400
			[Token(Token = "0x17000103")]
			public override bool CanSeek
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000469 RID: 1129 RVA: 0x00004218 File Offset: 0x00002418
			[Token(Token = "0x17000104")]
			public override bool CanRead
			{
				[Token(Token = "0x6000469")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x28")]
			private ZipFile zipFile_;

			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x30")]
			private Stream baseStream_;

			// Token: 0x040002EE RID: 750
			[Token(Token = "0x40002EE")]
			[FieldOffset(Offset = "0x38")]
			private long start_;

			// Token: 0x040002EF RID: 751
			[Token(Token = "0x40002EF")]
			[FieldOffset(Offset = "0x40")]
			private long length_;

			// Token: 0x040002F0 RID: 752
			[Token(Token = "0x40002F0")]
			[FieldOffset(Offset = "0x48")]
			private long readPos_;

			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x40002F1")]
			[FieldOffset(Offset = "0x50")]
			private long end_;
		}
	}
}
