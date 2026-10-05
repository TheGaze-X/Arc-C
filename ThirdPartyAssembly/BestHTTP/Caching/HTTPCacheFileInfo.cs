using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.Caching
{
	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	public class HTTPCacheFileInfo : IComparable<HTTPCacheFileInfo>
	{
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A81 RID: 10881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000626")]
		internal Uri Uri
		{
			[Token(Token = "0x6002A80")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A81")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x00012270 File Offset: 0x00010470
		// (set) Token: 0x06002A83 RID: 10883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000627")]
		internal DateTime LastAccess
		{
			[Token(Token = "0x6002A82")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A83")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x00012288 File Offset: 0x00010488
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000628")]
		public int BodyLength
		{
			[Token(Token = "0x6002A84")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002A85")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000629")]
		private string ETag
		{
			[Token(Token = "0x6002A86")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A87")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062A")]
		private string LastModified
		{
			[Token(Token = "0x6002A88")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A89")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x000122A0 File Offset: 0x000104A0
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062B")]
		private DateTime Expires
		{
			[Token(Token = "0x6002A8A")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A8B")]
			[Address(RVA = "0x1796DB0", Offset = "0x17959B0", VA = "0x181796DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x000122B8 File Offset: 0x000104B8
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062C")]
		private long Age
		{
			[Token(Token = "0x6002A8C")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002A8D")]
			[Address(RVA = "0x1692860", Offset = "0x1691460", VA = "0x181692860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x000122D0 File Offset: 0x000104D0
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062D")]
		private long MaxAge
		{
			[Token(Token = "0x6002A8E")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002A8F")]
			[Address(RVA = "0x1692850", Offset = "0x1691450", VA = "0x181692850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x000122E8 File Offset: 0x000104E8
		// (set) Token: 0x06002A91 RID: 10897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062E")]
		private DateTime Date
		{
			[Token(Token = "0x6002A90")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A91")]
			[Address(RVA = "0x35378C0", Offset = "0x35364C0", VA = "0x1835378C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x00012300 File Offset: 0x00010500
		// (set) Token: 0x06002A93 RID: 10899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062F")]
		private bool MustRevalidate
		{
			[Token(Token = "0x6002A92")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A93")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x00012318 File Offset: 0x00010518
		// (set) Token: 0x06002A95 RID: 10901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000630")]
		private DateTime Received
		{
			[Token(Token = "0x6002A94")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6002A95")]
			[Address(RVA = "0x35378D0", Offset = "0x35364D0", VA = "0x1835378D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002A97 RID: 10903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000631")]
		private string ConstructedPath
		{
			[Token(Token = "0x6002A96")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A97")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x00012330 File Offset: 0x00010530
		// (set) Token: 0x06002A99 RID: 10905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000632")]
		internal ulong MappedNameIDX
		{
			[Token(Token = "0x6002A98")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002A99")]
			[Address(RVA = "0x53CF500", Offset = "0x53CE100", VA = "0x1853CF500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0x53CF120", Offset = "0x53CDD20", VA = "0x1853CF120")]
		internal HTTPCacheFileInfo(Uri uri)
		{
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0x53CF460", Offset = "0x53CE060", VA = "0x1853CF460")]
		internal HTTPCacheFileInfo(Uri uri, DateTime lastAcces, int bodyLength)
		{
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x53CF190", Offset = "0x53CDD90", VA = "0x1853CF190")]
		internal HTTPCacheFileInfo(Uri uri, BinaryReader reader, int version)
		{
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x53CE330", Offset = "0x53CCF30", VA = "0x1853CE330")]
		internal void SaveTo(BinaryWriter writer)
		{
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x53CD790", Offset = "0x53CC390", VA = "0x1853CD790")]
		public string GetPath()
		{
			return null;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x53CDF90", Offset = "0x53CCB90", VA = "0x1853CDF90")]
		public bool IsExists()
		{
			return default(bool);
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x53CD570", Offset = "0x53CC170", VA = "0x1853CD570")]
		internal void Delete()
		{
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x53CE260", Offset = "0x53CCE60", VA = "0x1853CE260")]
		private void Reset()
		{
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x53CE5D0", Offset = "0x53CD1D0", VA = "0x1853CE5D0")]
		private void SetUpCachingValues(HTTPResponse response)
		{
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x53CEF50", Offset = "0x53CDB50", VA = "0x1853CEF50")]
		internal bool WillExpireInTheFuture()
		{
			return default(bool);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x53CE840", Offset = "0x53CD440", VA = "0x1853CE840")]
		internal void SetUpRevalidationHeaders(HTTPRequest request)
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x53CD620", Offset = "0x53CC220", VA = "0x1853CD620")]
		public Stream GetBodyStream(out int length)
		{
			return null;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x53CE000", Offset = "0x53CCC00", VA = "0x1853CE000")]
		internal HTTPResponse ReadResponseTo(HTTPRequest request)
		{
			return null;
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x53CE940", Offset = "0x53CD540", VA = "0x1853CE940")]
		internal void Store(HTTPResponse response)
		{
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x53CD8B0", Offset = "0x53CC4B0", VA = "0x1853CD8B0")]
		internal Stream GetSaveStream(HTTPResponse response)
		{
			return null;
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x53CD4F0", Offset = "0x53CC0F0", VA = "0x1853CD4F0", Slot = "4")]
		public int CompareTo(HTTPCacheFileInfo other)
		{
			return 0;
		}
	}
}
