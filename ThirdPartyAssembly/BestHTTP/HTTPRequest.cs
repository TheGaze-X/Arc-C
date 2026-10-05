using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BestHTTP.Authentication;
using BestHTTP.Cookies;
using BestHTTP.Forms;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Tls;
using UnityEngine;

namespace BestHTTP
{
	// Token: 0x020004A9 RID: 1193
	[Token(Token = "0x20004A9")]
	public sealed class HTTPRequest : IEnumerator, IEnumerator<HTTPRequest>, IDisposable
	{
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055A")]
		public Uri Uri
		{
			[Token(Token = "0x60026B9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026BA")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x00010B78 File Offset: 0x0000ED78
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055B")]
		public HTTPMethods MethodType
		{
			[Token(Token = "0x60026BB")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return HTTPMethods.Get;
			}
			[Token(Token = "0x60026BC")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055C")]
		public byte[] RawData
		{
			[Token(Token = "0x60026BD")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026BE")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055D")]
		public Stream UploadStream
		{
			[Token(Token = "0x60026BF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026C0")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x00010B90 File Offset: 0x0000ED90
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055E")]
		public bool DisposeUploadStream
		{
			[Token(Token = "0x60026C1")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026C2")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055F")]
		public bool UseUploadStreamLength
		{
			[Token(Token = "0x60026C3")]
			[Address(RVA = "0x4E1BBB0", Offset = "0x4E1A7B0", VA = "0x184E1BBB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026C4")]
			[Address(RVA = "0x508CBF0", Offset = "0x508B7F0", VA = "0x18508CBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000560")]
		public bool IsKeepAlive
		{
			[Token(Token = "0x60026C5")]
			[Address(RVA = "0x538F7F0", Offset = "0x538E3F0", VA = "0x18538F7F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026C6")]
			[Address(RVA = "0x538FC30", Offset = "0x538E830", VA = "0x18538FC30")]
			set
			{
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x00010BD8 File Offset: 0x0000EDD8
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000561")]
		public bool DisableCache
		{
			[Token(Token = "0x60026C7")]
			[Address(RVA = "0x538F7B0", Offset = "0x538E3B0", VA = "0x18538F7B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026C8")]
			[Address(RVA = "0x538FB40", Offset = "0x538E740", VA = "0x18538FB40")]
			set
			{
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000562")]
		public bool CacheOnly
		{
			[Token(Token = "0x60026C9")]
			[Address(RVA = "0x538F6F0", Offset = "0x538E2F0", VA = "0x18538F6F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026CA")]
			[Address(RVA = "0x538FAB0", Offset = "0x538E6B0", VA = "0x18538FAB0")]
			set
			{
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x00010C08 File Offset: 0x0000EE08
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000563")]
		public bool UseStreaming
		{
			[Token(Token = "0x60026CB")]
			[Address(RVA = "0x4E7EAB0", Offset = "0x4E7D6B0", VA = "0x184E7EAB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026CC")]
			[Address(RVA = "0x538FDE0", Offset = "0x538E9E0", VA = "0x18538FDE0")]
			set
			{
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x00010C20 File Offset: 0x0000EE20
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000564")]
		public int StreamFragmentSize
		{
			[Token(Token = "0x60026CD")]
			[Address(RVA = "0x5080700", Offset = "0x507F300", VA = "0x185080700")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60026CE")]
			[Address(RVA = "0x538FCD0", Offset = "0x538E8D0", VA = "0x18538FCD0")]
			set
			{
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000565")]
		public OnRequestFinishedDelegate Callback
		{
			[Token(Token = "0x60026CF")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026D0")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x00010C38 File Offset: 0x0000EE38
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000566")]
		public bool DisableRetry
		{
			[Token(Token = "0x60026D1")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026D2")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x00010C50 File Offset: 0x0000EE50
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000567")]
		public bool IsRedirected
		{
			[Token(Token = "0x60026D3")]
			[Address(RVA = "0x2419850", Offset = "0x2418450", VA = "0x182419850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026D4")]
			[Address(RVA = "0x2419880", Offset = "0x2418480", VA = "0x182419880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000568")]
		public Uri RedirectUri
		{
			[Token(Token = "0x60026D5")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026D6")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000569")]
		public Uri CurrentUri
		{
			[Token(Token = "0x60026D7")]
			[Address(RVA = "0x538F7A0", Offset = "0x538E3A0", VA = "0x18538F7A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056A")]
		public HTTPResponse Response
		{
			[Token(Token = "0x60026D8")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026D9")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056B")]
		public HTTPResponse ProxyResponse
		{
			[Token(Token = "0x60026DA")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026DB")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056C")]
		public Exception Exception
		{
			[Token(Token = "0x60026DC")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026DD")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026DF RID: 9951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056D")]
		public object Tag
		{
			[Token(Token = "0x60026DE")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026DF")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056E")]
		public Credentials Credentials
		{
			[Token(Token = "0x60026E0")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026E1")]
			[Address(RVA = "0x168B8E0", Offset = "0x168A4E0", VA = "0x18168B8E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x00010C68 File Offset: 0x0000EE68
		[Token(Token = "0x1700056F")]
		public bool HasProxy
		{
			[Token(Token = "0x60026E2")]
			[Address(RVA = "0x5108460", Offset = "0x5107060", VA = "0x185108460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000570")]
		public HTTPProxy Proxy
		{
			[Token(Token = "0x60026E3")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026E4")]
			[Address(RVA = "0x1FC11F0", Offset = "0x1FBFDF0", VA = "0x181FC11F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x00010C80 File Offset: 0x0000EE80
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000571")]
		public int MaxRedirects
		{
			[Token(Token = "0x60026E5")]
			[Address(RVA = "0x7CEE30", Offset = "0x7CDA30", VA = "0x1807CEE30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60026E6")]
			[Address(RVA = "0x7CEE40", Offset = "0x7CDA40", VA = "0x1807CEE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x00010C98 File Offset: 0x0000EE98
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000572")]
		public bool UseAlternateSSL
		{
			[Token(Token = "0x60026E7")]
			[Address(RVA = "0x371B6B0", Offset = "0x371A2B0", VA = "0x18371B6B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026E8")]
			[Address(RVA = "0x538FDD0", Offset = "0x538E9D0", VA = "0x18538FDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000573")]
		public bool IsCookiesEnabled
		{
			[Token(Token = "0x60026E9")]
			[Address(RVA = "0x371B6A0", Offset = "0x371A2A0", VA = "0x18371B6A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026EA")]
			[Address(RVA = "0x538FC20", Offset = "0x538E820", VA = "0x18538FC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000574")]
		public List<Cookie> Cookies
		{
			[Token(Token = "0x60026EB")]
			[Address(RVA = "0x538F700", Offset = "0x538E300", VA = "0x18538F700")]
			get
			{
				return null;
			}
			[Token(Token = "0x60026EC")]
			[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
			set
			{
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		// (set) Token: 0x060026EE RID: 9966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000575")]
		public HTTPFormUsage FormUsage
		{
			[Token(Token = "0x60026ED")]
			[Address(RVA = "0x538F7E0", Offset = "0x538E3E0", VA = "0x18538F7E0")]
			[CompilerGenerated]
			get
			{
				return HTTPFormUsage.Automatic;
			}
			[Token(Token = "0x60026EE")]
			[Address(RVA = "0x4FAEC40", Offset = "0x4FAD840", VA = "0x184FAEC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000576")]
		public HTTPRequestStates State
		{
			[Token(Token = "0x60026EF")]
			[Address(RVA = "0x32F7200", Offset = "0x32F5E00", VA = "0x1832F7200")]
			[CompilerGenerated]
			get
			{
				return HTTPRequestStates.Initial;
			}
			[Token(Token = "0x60026F0")]
			[Address(RVA = "0x32F7230", Offset = "0x32F5E30", VA = "0x1832F7230")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000577")]
		public int RedirectCount
		{
			[Token(Token = "0x60026F1")]
			[Address(RVA = "0x7893A0", Offset = "0x787FA0", VA = "0x1807893A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60026F2")]
			[Address(RVA = "0x789460", Offset = "0x788060", VA = "0x180789460")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060026F3 RID: 9971 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060026F4 RID: 9972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000004")]
		public event Func<HTTPRequest, X509Certificate, X509Chain, bool> CustomCertificationValidator
		{
			[Token(Token = "0x60026F3")]
			[Address(RVA = "0x538F4E0", Offset = "0x538E0E0", VA = "0x18538F4E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60026F4")]
			[Address(RVA = "0x538F8A0", Offset = "0x538E4A0", VA = "0x18538F8A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x00010D10 File Offset: 0x0000EF10
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000578")]
		public TimeSpan ConnectTimeout
		{
			[Token(Token = "0x60026F5")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x60026F6")]
			[Address(RVA = "0x538FB30", Offset = "0x538E730", VA = "0x18538FB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x00010D28 File Offset: 0x0000EF28
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000579")]
		public TimeSpan Timeout
		{
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x789430", Offset = "0x788030", VA = "0x180789430")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x60026F8")]
			[Address(RVA = "0x538FDA0", Offset = "0x538E9A0", VA = "0x18538FDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00010D40 File Offset: 0x0000EF40
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057A")]
		public bool EnableTimoutForStreaming
		{
			[Token(Token = "0x60026F9")]
			[Address(RVA = "0x4C374F0", Offset = "0x4C360F0", VA = "0x184C374F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026FA")]
			[Address(RVA = "0x538FC00", Offset = "0x538E800", VA = "0x18538FC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x00010D58 File Offset: 0x0000EF58
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057B")]
		public bool EnableSafeReadOnUnknownContentLength
		{
			[Token(Token = "0x60026FB")]
			[Address(RVA = "0x538F7D0", Offset = "0x538E3D0", VA = "0x18538F7D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60026FC")]
			[Address(RVA = "0x538FBF0", Offset = "0x538E7F0", VA = "0x18538FBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x00010D70 File Offset: 0x0000EF70
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057C")]
		public int Priority
		{
			[Token(Token = "0x60026FD")]
			[Address(RVA = "0x538F800", Offset = "0x538E400", VA = "0x18538F800")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60026FE")]
			[Address(RVA = "0x538FCB0", Offset = "0x538E8B0", VA = "0x18538FCB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057D")]
		public ICertificateVerifyer CustomCertificateVerifyer
		{
			[Token(Token = "0x60026FF")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002700")]
			[Address(RVA = "0x4D6CA00", Offset = "0x4D6B600", VA = "0x184D6CA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057E")]
		public IClientCredentialsProvider CustomClientCredentialsProvider
		{
			[Token(Token = "0x6002701")]
			[Address(RVA = "0x371A260", Offset = "0x3718E60", VA = "0x18371A260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002702")]
			[Address(RVA = "0x371A3C0", Offset = "0x3718FC0", VA = "0x18371A3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x00010D88 File Offset: 0x0000EF88
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057F")]
		public SupportedProtocols ProtocolHandler
		{
			[Token(Token = "0x6002703")]
			[Address(RVA = "0x538F810", Offset = "0x538E410", VA = "0x18538F810")]
			[CompilerGenerated]
			get
			{
				return SupportedProtocols.Unknown;
			}
			[Token(Token = "0x6002704")]
			[Address(RVA = "0x538FCC0", Offset = "0x538E8C0", VA = "0x18538FCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06002705 RID: 9989 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002706 RID: 9990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000005")]
		public event OnBeforeRedirectionDelegate OnBeforeRedirection
		{
			[Token(Token = "0x6002705")]
			[Address(RVA = "0x538F640", Offset = "0x538E240", VA = "0x18538F640")]
			add
			{
			}
			[Token(Token = "0x6002706")]
			[Address(RVA = "0x538FA00", Offset = "0x538E600", VA = "0x18538FA00")]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06002707 RID: 9991 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002708 RID: 9992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000006")]
		public event OnBeforeHeaderSendDelegate OnBeforeHeaderSend
		{
			[Token(Token = "0x6002707")]
			[Address(RVA = "0x538F590", Offset = "0x538E190", VA = "0x18538F590")]
			add
			{
			}
			[Token(Token = "0x6002708")]
			[Address(RVA = "0x538F950", Offset = "0x538E550", VA = "0x18538F950")]
			remove
			{
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000580")]
		public bool TryToMinimizeTCPLatency
		{
			[Token(Token = "0x6002709")]
			[Address(RVA = "0x4DA7710", Offset = "0x4DA6310", VA = "0x184DA7710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600270A")]
			[Address(RVA = "0x4DA7730", Offset = "0x4DA6330", VA = "0x184DA7730")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000581")]
		internal long Downloaded
		{
			[Token(Token = "0x600270B")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600270C")]
			[Address(RVA = "0x538FBE0", Offset = "0x538E7E0", VA = "0x18538FBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000582")]
		internal long DownloadLength
		{
			[Token(Token = "0x600270D")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600270E")]
			[Address(RVA = "0x538FBC0", Offset = "0x538E7C0", VA = "0x18538FBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000583")]
		internal bool DownloadProgressChanged
		{
			[Token(Token = "0x600270F")]
			[Address(RVA = "0x538F7C0", Offset = "0x538E3C0", VA = "0x18538F7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002710")]
			[Address(RVA = "0x538FBD0", Offset = "0x538E7D0", VA = "0x18538FBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x00010E00 File Offset: 0x0000F000
		[Token(Token = "0x17000584")]
		internal long UploadStreamLength
		{
			[Token(Token = "0x6002711")]
			[Address(RVA = "0x538F840", Offset = "0x538E440", VA = "0x18538F840")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x00010E18 File Offset: 0x0000F018
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000585")]
		internal long Uploaded
		{
			[Token(Token = "0x6002712")]
			[Address(RVA = "0xF43520", Offset = "0xF42120", VA = "0x180F43520")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002713")]
			[Address(RVA = "0x538FDC0", Offset = "0x538E9C0", VA = "0x18538FDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x00010E30 File Offset: 0x0000F030
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000586")]
		internal long UploadLength
		{
			[Token(Token = "0x6002714")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002715")]
			[Address(RVA = "0x538FDB0", Offset = "0x538E9B0", VA = "0x18538FDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x00010E48 File Offset: 0x0000F048
		// (set) Token: 0x06002717 RID: 10007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000587")]
		internal bool UploadProgressChanged
		{
			[Token(Token = "0x6002716")]
			[Address(RVA = "0x538F830", Offset = "0x538E430", VA = "0x18538F830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002717")]
			[Address(RVA = "0x5080D70", Offset = "0x507F970", VA = "0x185080D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000588")]
		private Dictionary<string, List<string>> Headers
		{
			[Token(Token = "0x6002718")]
			[Address(RVA = "0x5080A80", Offset = "0x507F680", VA = "0x185080A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002719")]
			[Address(RVA = "0x538FC10", Offset = "0x538E810", VA = "0x18538FC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271A")]
		[Address(RVA = "0x538F1B0", Offset = "0x538DDB0", VA = "0x18538F1B0")]
		public HTTPRequest(Uri uri)
		{
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x538F3D0", Offset = "0x538DFD0", VA = "0x18538F3D0")]
		public HTTPRequest(Uri uri, OnRequestFinishedDelegate callback)
		{
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x538EAD0", Offset = "0x538D6D0", VA = "0x18538EAD0")]
		public HTTPRequest(Uri uri, bool isKeepAlive, OnRequestFinishedDelegate callback)
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x538F2B0", Offset = "0x538DEB0", VA = "0x18538F2B0")]
		public HTTPRequest(Uri uri, bool isKeepAlive, bool disableCache, OnRequestFinishedDelegate callback)
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x538E9B0", Offset = "0x538D5B0", VA = "0x18538E9B0")]
		public HTTPRequest(Uri uri, HTTPMethods methodType)
		{
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x538F080", Offset = "0x538DC80", VA = "0x18538F080")]
		public HTTPRequest(Uri uri, HTTPMethods methodType, OnRequestFinishedDelegate callback)
		{
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002720")]
		[Address(RVA = "0x538F2E0", Offset = "0x538DEE0", VA = "0x18538F2E0")]
		public HTTPRequest(Uri uri, HTTPMethods methodType, bool isKeepAlive, OnRequestFinishedDelegate callback)
		{
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002721")]
		[Address(RVA = "0x538EBA0", Offset = "0x538D7A0", VA = "0x18538EBA0")]
		public HTTPRequest(Uri uri, HTTPMethods methodType, bool isKeepAlive, bool disableCache, OnRequestFinishedDelegate callback)
		{
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x538BDB0", Offset = "0x538A9B0", VA = "0x18538BDB0")]
		public void AddField(string fieldName, string value)
		{
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x538BCE0", Offset = "0x538A8E0", VA = "0x18538BCE0")]
		public void AddField(string fieldName, string value, Encoding e)
		{
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x538BBD0", Offset = "0x538A7D0", VA = "0x18538BBD0")]
		public void AddBinaryData(string fieldName, byte[] content)
		{
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x538BCC0", Offset = "0x538A8C0", VA = "0x18538BCC0")]
		public void AddBinaryData(string fieldName, byte[] content, string fileName)
		{
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x538BBF0", Offset = "0x538A7F0", VA = "0x18538BBF0")]
		public void AddBinaryData(string fieldName, byte[] content, string fileName, string mimeType)
		{
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x538E070", Offset = "0x538CC70", VA = "0x18538E070")]
		public void SetFields(WWWForm wwwForm)
		{
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x538E100", Offset = "0x538CD00", VA = "0x18538E100")]
		public void SetForm(HTTPFormBase form)
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x538C140", Offset = "0x538AD40", VA = "0x18538C140")]
		public void ClearForm()
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x538D590", Offset = "0x538C190", VA = "0x18538D590")]
		private HTTPFormBase SelectFormImplementation()
		{
			return null;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x538BE80", Offset = "0x538AA80", VA = "0x18538BE80")]
		public void AddHeader(string name, string value)
		{
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x538E110", Offset = "0x538CD10", VA = "0x18538E110")]
		public void SetHeader(string name, string value)
		{
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00010E60 File Offset: 0x0000F060
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x538D490", Offset = "0x538C090", VA = "0x18538D490")]
		public bool RemoveHeader(string name)
		{
			return default(bool);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00010E78 File Offset: 0x0000F078
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x538D400", Offset = "0x538C000", VA = "0x18538D400")]
		public bool HasHeader(string name)
		{
			return default(bool);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x538D2C0", Offset = "0x538BEC0", VA = "0x18538D2C0")]
		public string GetFirstHeaderValue(string name)
		{
			return null;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x538D370", Offset = "0x538BF70", VA = "0x18538D370")]
		public List<string> GetHeaderValues(string name)
		{
			return null;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x538D4F0", Offset = "0x538C0F0", VA = "0x18538D4F0")]
		public void RemoveHeaders()
		{
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x538E2D0", Offset = "0x538CED0", VA = "0x18538E2D0")]
		public void SetRangeHeader(int firstBytePos)
		{
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x538E360", Offset = "0x538CF60", VA = "0x18538E360")]
		public void SetRangeHeader(int firstBytePos, int lastBytePos)
		{
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002734")]
		[Address(RVA = "0x538D200", Offset = "0x538BE00", VA = "0x18538D200")]
		public void EnumerateHeaders(OnHeaderEnumerationDelegate callback)
		{
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002735")]
		[Address(RVA = "0x538C340", Offset = "0x538AF40", VA = "0x18538C340")]
		public void EnumerateHeaders(OnHeaderEnumerationDelegate callback, bool callBeforeSendCallback)
		{
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002736")]
		[Address(RVA = "0x538D730", Offset = "0x538C330", VA = "0x18538D730")]
		private void SendHeaders(Stream stream)
		{
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002737")]
		[Address(RVA = "0x538C210", Offset = "0x538AE10", VA = "0x18538C210")]
		public string DumpHeaders()
		{
			return null;
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x538D230", Offset = "0x538BE30", VA = "0x18538D230")]
		internal byte[] GetEntityBody()
		{
			return null;
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x538D890", Offset = "0x538C490", VA = "0x18538D890")]
		internal void SendOutTo(Stream stream)
		{
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x538E420", Offset = "0x538D020", VA = "0x18538E420")]
		internal void UpgradeCallback()
		{
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x538C000", Offset = "0x538AC00", VA = "0x18538C000")]
		internal void CallCallback()
		{
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x00010E90 File Offset: 0x0000F090
		[Token(Token = "0x600273C")]
		[Address(RVA = "0x538C100", Offset = "0x538AD00", VA = "0x18538C100")]
		internal bool CallOnBeforeRedirection(Uri redirectUri)
		{
			return default(bool);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273D")]
		[Address(RVA = "0x538D210", Offset = "0x538BE10", VA = "0x18538D210")]
		internal void FinishStreaming()
		{
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273E")]
		[Address(RVA = "0x538D470", Offset = "0x538C070", VA = "0x18538D470")]
		internal void Prepare()
		{
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		[Token(Token = "0x600273F")]
		[Address(RVA = "0x538C0C0", Offset = "0x538ACC0", VA = "0x18538C0C0")]
		internal bool CallCustomCertificationValidator(X509Certificate cert, X509Chain chain)
		{
			return default(bool);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002740")]
		[Address(RVA = "0x538E020", Offset = "0x538CC20", VA = "0x18538E020")]
		public HTTPRequest Send()
		{
			return null;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002741")]
		[Address(RVA = "0x538B810", Offset = "0x538A410", VA = "0x18538B810")]
		public void Abort()
		{
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002742")]
		[Address(RVA = "0x538C180", Offset = "0x538AD80", VA = "0x18538C180")]
		public void Clear()
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000589")]
		public object Current
		{
			[Token(Token = "0x6002743")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x538D460", Offset = "0x538C060", VA = "0x18538D460", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x538D540", Offset = "0x538C140", VA = "0x18538D540", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002746 RID: 10054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700058A")]
		private HTTPRequest Current
		{
			[Token(Token = "0x6002746")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x04001593 RID: 5523
		[Token(Token = "0x4001593")]
		[FieldOffset(Offset = "0x0")]
		public static readonly byte[] EOL;

		// Token: 0x04001594 RID: 5524
		[Token(Token = "0x4001594")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string[] MethodNames;

		// Token: 0x04001595 RID: 5525
		[Token(Token = "0x4001595")]
		[FieldOffset(Offset = "0x10")]
		public static int UploadChunkSize;

		// Token: 0x0400159C RID: 5532
		[Token(Token = "0x400159C")]
		[FieldOffset(Offset = "0x38")]
		public OnUploadProgressDelegate OnUploadProgress;

		// Token: 0x0400159E RID: 5534
		[Token(Token = "0x400159E")]
		[FieldOffset(Offset = "0x48")]
		public OnDownloadProgressDelegate OnProgress;

		// Token: 0x0400159F RID: 5535
		[Token(Token = "0x400159F")]
		[FieldOffset(Offset = "0x50")]
		public OnRequestFinishedDelegate OnUpgraded;

		// Token: 0x040015AC RID: 5548
		[Token(Token = "0x40015AC")]
		[FieldOffset(Offset = "0xA0")]
		private List<Cookie> customCookies;

		// Token: 0x040015B9 RID: 5561
		[Token(Token = "0x40015B9")]
		[FieldOffset(Offset = "0xF0")]
		private OnBeforeRedirectionDelegate onBeforeRedirection;

		// Token: 0x040015BA RID: 5562
		[Token(Token = "0x40015BA")]
		[FieldOffset(Offset = "0xF8")]
		private OnBeforeHeaderSendDelegate _onBeforeHeaderSend;

		// Token: 0x040015C2 RID: 5570
		[Token(Token = "0x40015C2")]
		[FieldOffset(Offset = "0x131")]
		private bool isKeepAlive;

		// Token: 0x040015C3 RID: 5571
		[Token(Token = "0x40015C3")]
		[FieldOffset(Offset = "0x132")]
		private bool disableCache;

		// Token: 0x040015C4 RID: 5572
		[Token(Token = "0x40015C4")]
		[FieldOffset(Offset = "0x133")]
		private bool cacheOnly;

		// Token: 0x040015C5 RID: 5573
		[Token(Token = "0x40015C5")]
		[FieldOffset(Offset = "0x134")]
		private int streamFragmentSize;

		// Token: 0x040015C6 RID: 5574
		[Token(Token = "0x40015C6")]
		[FieldOffset(Offset = "0x138")]
		private bool useStreaming;

		// Token: 0x040015C8 RID: 5576
		[Token(Token = "0x40015C8")]
		[FieldOffset(Offset = "0x148")]
		private HTTPFormBase FieldCollector;

		// Token: 0x040015C9 RID: 5577
		[Token(Token = "0x40015C9")]
		[FieldOffset(Offset = "0x150")]
		private HTTPFormBase FormImpl;
	}
}
