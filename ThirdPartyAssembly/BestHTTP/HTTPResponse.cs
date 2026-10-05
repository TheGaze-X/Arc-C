using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using BestHTTP.Caching;
using BestHTTP.Cookies;
using BestHTTP.Decompression.Zlib;
using Il2CppDummyDll;
using UnityEngine;

namespace BestHTTP
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	public class HTTPResponse : IDisposable
	{
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		// (set) Token: 0x06002750 RID: 10064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058C")]
		public int VersionMajor
		{
			[Token(Token = "0x600274F")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002750")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x00010F08 File Offset: 0x0000F108
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058D")]
		public int VersionMinor
		{
			[Token(Token = "0x6002751")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002752")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x00010F20 File Offset: 0x0000F120
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058E")]
		public int StatusCode
		{
			[Token(Token = "0x6002753")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002754")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x00010F38 File Offset: 0x0000F138
		[Token(Token = "0x1700058F")]
		public bool IsSuccess
		{
			[Token(Token = "0x6002755")]
			[Address(RVA = "0x53A9330", Offset = "0x53A7F30", VA = "0x1853A9330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000590")]
		public string Message
		{
			[Token(Token = "0x6002756")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002757")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x00010F50 File Offset: 0x0000F150
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000591")]
		public bool IsStreamed
		{
			[Token(Token = "0x6002758")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002759")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x00010F68 File Offset: 0x0000F168
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000592")]
		public bool IsStreamingFinished
		{
			[Token(Token = "0x600275A")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600275B")]
			[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x00010F80 File Offset: 0x0000F180
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000593")]
		public bool IsFromCache
		{
			[Token(Token = "0x600275C")]
			[Address(RVA = "0x37002B0", Offset = "0x36FEEB0", VA = "0x1837002B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600275D")]
			[Address(RVA = "0x37002D0", Offset = "0x36FEED0", VA = "0x1837002D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000594")]
		public HTTPCacheFileInfo CacheFileInfo
		{
			[Token(Token = "0x600275E")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600275F")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x00010F98 File Offset: 0x0000F198
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000595")]
		public bool IsCacheOnly
		{
			[Token(Token = "0x6002760")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002761")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000596")]
		public Dictionary<string, List<string>> Headers
		{
			[Token(Token = "0x6002762")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002763")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000597")]
		public byte[] Data
		{
			[Token(Token = "0x6002764")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002765")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000598")]
		public bool IsUpgraded
		{
			[Token(Token = "0x6002766")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002767")]
			[Address(RVA = "0x150B0D0", Offset = "0x1509CD0", VA = "0x18150B0D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000599")]
		public List<Cookie> Cookies
		{
			[Token(Token = "0x6002768")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002769")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059A")]
		public string DataAsText
		{
			[Token(Token = "0x600276A")]
			[Address(RVA = "0x53A9180", Offset = "0x53A7D80", VA = "0x1853A9180")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059B")]
		public Texture2D DataAsTexture2D
		{
			[Token(Token = "0x600276B")]
			[Address(RVA = "0x53A9240", Offset = "0x53A7E40", VA = "0x1853A9240")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		// (set) Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059C")]
		public bool IsClosedManually
		{
			[Token(Token = "0x600276C")]
			[Address(RVA = "0x2109C30", Offset = "0x2108830", VA = "0x182109C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600276D")]
			[Address(RVA = "0x4D6B950", Offset = "0x4D6A550", VA = "0x184D6B950")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x53A9090", Offset = "0x53A7C90", VA = "0x1853A9090")]
		internal HTTPResponse(HTTPRequest request, Stream stream, bool isStreamed, bool isFromCache)
		{
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x53A86D0", Offset = "0x53A72D0", VA = "0x1853A86D0", Slot = "5")]
		internal virtual bool Receive(int forceReadRawContentLength = -1, bool readPayloadData = true)
		{
			return default(bool);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x53A7520", Offset = "0x53A6120", VA = "0x1853A7520")]
		protected bool ReadPayload(int forceReadRawContentLength)
		{
			return default(bool);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x53A7300", Offset = "0x53A5F00", VA = "0x1853A7300")]
		protected void ReadHeaders(Stream stream)
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x53A5190", Offset = "0x53A3D90", VA = "0x1853A5190")]
		protected void AddHeader(string name, string value)
		{
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x53A6230", Offset = "0x53A4E30", VA = "0x1853A6230")]
		public List<string> GetHeaderValues(string name)
		{
			return null;
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002774")]
		[Address(RVA = "0x53A6170", Offset = "0x53A4D70", VA = "0x1853A6170")]
		public string GetFirstHeaderValue(string name)
		{
			return null;
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00011010 File Offset: 0x0000F210
		[Token(Token = "0x6002775")]
		[Address(RVA = "0x53A6790", Offset = "0x53A5390", VA = "0x1853A6790")]
		public bool HasHeaderWithValue(string headerName, string value)
		{
			return default(bool);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00011028 File Offset: 0x0000F228
		[Token(Token = "0x6002776")]
		[Address(RVA = "0x53A6850", Offset = "0x53A5450", VA = "0x1853A6850")]
		public bool HasHeader(string headerName)
		{
			return default(bool);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x53A62E0", Offset = "0x53A4EE0", VA = "0x1853A62E0")]
		public HTTPRange GetRange()
		{
			return null;
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002778")]
		[Address(RVA = "0x53A7EE0", Offset = "0x53A6AE0", VA = "0x1853A7EE0")]
		public static string ReadTo(Stream stream, byte blocker)
		{
			return null;
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x53A7CC0", Offset = "0x53A68C0", VA = "0x1853A7CC0")]
		public static string ReadTo(Stream stream, byte blocker1, byte blocker2)
		{
			return null;
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x53A6940", Offset = "0x53A5540", VA = "0x1853A6940")]
		public static string NoTrimReadTo(Stream stream, byte blocker1, byte blocker2)
		{
			return null;
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00011040 File Offset: 0x0000F240
		[Token(Token = "0x600277B")]
		[Address(RVA = "0x53A6B40", Offset = "0x53A5740", VA = "0x1853A6B40")]
		protected int ReadChunkLength(Stream stream)
		{
			return 0;
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277C")]
		[Address(RVA = "0x53A6C20", Offset = "0x53A5820", VA = "0x1853A6C20")]
		protected void ReadChunked(Stream stream)
		{
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x53A7730", Offset = "0x53A6330", VA = "0x1853A7730")]
		internal void ReadRaw(Stream stream, long contentLength)
		{
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x53A80D0", Offset = "0x53A6CD0", VA = "0x1853A80D0")]
		protected void ReadUnknownSize(Stream stream)
		{
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x53A56E0", Offset = "0x53A42E0", VA = "0x1853A56E0")]
		protected byte[] DecodeStream(MemoryStream streamToDecode)
		{
			return null;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x53A5A90", Offset = "0x53A4690", VA = "0x1853A5A90")]
		private byte[] Decompress(byte[] data, int offset, int count)
		{
			return null;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x53A55D0", Offset = "0x53A41D0", VA = "0x1853A55D0")]
		protected void BeginReceiveStreamFragments()
		{
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x53A5E40", Offset = "0x53A4A40", VA = "0x1853A5E40")]
		protected void FeedStreamFragment(byte[] buffer, int pos, int length)
		{
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x53A6060", Offset = "0x53A4C60", VA = "0x1853A6060")]
		protected void FlushRemainingFragmentBuffer()
		{
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x53A5320", Offset = "0x53A3F20", VA = "0x1853A5320")]
		protected void AddStreamedFragment(byte[] buffer)
		{
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x53A9040", Offset = "0x53A7C40", VA = "0x1853A9040")]
		protected void WaitWhileHasFragments()
		{
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x53A64F0", Offset = "0x53A50F0", VA = "0x1853A64F0")]
		public List<byte[]> GetStreamedFragments()
		{
			return null;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00011058 File Offset: 0x0000F258
		[Token(Token = "0x6002787")]
		[Address(RVA = "0x53A6870", Offset = "0x53A5470", VA = "0x1853A6870")]
		internal bool HasStreamedFragments()
		{
			return default(bool);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002788")]
		[Address(RVA = "0x53A5F90", Offset = "0x53A4B90", VA = "0x1853A5F90")]
		internal void FinishStreaming()
		{
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002789")]
		[Address(RVA = "0x53A8F10", Offset = "0x53A7B10", VA = "0x1853A8F10")]
		private void VerboseLogging(string str)
		{
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600278A")]
		[Address(RVA = "0x53A5E00", Offset = "0x53A4A00", VA = "0x1853A5E00", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040015CC RID: 5580
		[Token(Token = "0x40015CC")]
		internal const byte CR = 13;

		// Token: 0x040015CD RID: 5581
		[Token(Token = "0x40015CD")]
		internal const byte LF = 10;

		// Token: 0x040015CE RID: 5582
		[Token(Token = "0x40015CE")]
		public const int MinBufferSize = 4096;

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x60")]
		protected string dataAsText;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x68")]
		protected Texture2D texture;

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0x78")]
		internal HTTPRequest baseRequest;

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0x80")]
		protected Stream Stream;

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0x88")]
		protected List<byte[]> streamedFragments;

		// Token: 0x040015E2 RID: 5602
		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0x90")]
		protected object SyncRoot;

		// Token: 0x040015E3 RID: 5603
		[Token(Token = "0x40015E3")]
		[FieldOffset(Offset = "0x98")]
		protected byte[] fragmentBuffer;

		// Token: 0x040015E4 RID: 5604
		[Token(Token = "0x40015E4")]
		[FieldOffset(Offset = "0xA0")]
		protected int fragmentBufferDataLength;

		// Token: 0x040015E5 RID: 5605
		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0xA8")]
		protected Stream cacheStream;

		// Token: 0x040015E6 RID: 5606
		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0xB0")]
		protected int allFragmentSize;

		// Token: 0x040015E7 RID: 5607
		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0xB8")]
		private MemoryStream decompressorInputStream;

		// Token: 0x040015E8 RID: 5608
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0xC0")]
		private MemoryStream decompressorOutputStream;

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0xC8")]
		private GZipStream decompressorGZipStream;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0xD0")]
		private byte[] copyBuffer;
	}
}
