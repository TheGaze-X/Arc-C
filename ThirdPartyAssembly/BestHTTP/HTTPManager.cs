using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using BestHTTP.Extensions;
using BestHTTP.Logger;
using BestHTTP.Statistics;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Tls;

namespace BestHTTP
{
	// Token: 0x0200049A RID: 1178
	[Token(Token = "0x200049A")]
	public static class HTTPManager
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x000108F0 File Offset: 0x0000EAF0
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053F")]
		public static byte MaxConnectionPerServer
		{
			[Token(Token = "0x6002646")]
			[Address(RVA = "0x538A720", Offset = "0x5389320", VA = "0x18538A720")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002647")]
			[Address(RVA = "0x538AD60", Offset = "0x5389960", VA = "0x18538AD60")]
			set
			{
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x00010908 File Offset: 0x0000EB08
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000540")]
		public static bool KeepAliveDefaultValue
		{
			[Token(Token = "0x6002648")]
			[Address(RVA = "0x538A4C0", Offset = "0x53890C0", VA = "0x18538A4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002649")]
			[Address(RVA = "0x538AC30", Offset = "0x5389830", VA = "0x18538AC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x00010920 File Offset: 0x0000EB20
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000541")]
		public static bool IsCachingDisabled
		{
			[Token(Token = "0x600264A")]
			[Address(RVA = "0x538A420", Offset = "0x5389020", VA = "0x18538A420")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600264B")]
			[Address(RVA = "0x538AB70", Offset = "0x5389770", VA = "0x18538AB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x00010938 File Offset: 0x0000EB38
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000542")]
		public static TimeSpan MaxConnectionIdleTime
		{
			[Token(Token = "0x600264C")]
			[Address(RVA = "0x538A6D0", Offset = "0x53892D0", VA = "0x18538A6D0")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x600264D")]
			[Address(RVA = "0x538AD00", Offset = "0x5389900", VA = "0x18538AD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x00010950 File Offset: 0x0000EB50
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000543")]
		public static bool IsCookiesEnabled
		{
			[Token(Token = "0x600264E")]
			[Address(RVA = "0x538A470", Offset = "0x5389070", VA = "0x18538A470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600264F")]
			[Address(RVA = "0x538ABD0", Offset = "0x53897D0", VA = "0x18538ABD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x00010968 File Offset: 0x0000EB68
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000544")]
		public static uint CookieJarSize
		{
			[Token(Token = "0x6002650")]
			[Address(RVA = "0x538A190", Offset = "0x5388D90", VA = "0x18538A190")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002651")]
			[Address(RVA = "0x538A960", Offset = "0x5389560", VA = "0x18538A960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x00010980 File Offset: 0x0000EB80
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000545")]
		public static bool EnablePrivateBrowsing
		{
			[Token(Token = "0x6002652")]
			[Address(RVA = "0x538A2D0", Offset = "0x5388ED0", VA = "0x18538A2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002653")]
			[Address(RVA = "0x538AB10", Offset = "0x5389710", VA = "0x18538AB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x00010998 File Offset: 0x0000EB98
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000546")]
		public static TimeSpan ConnectTimeout
		{
			[Token(Token = "0x6002654")]
			[Address(RVA = "0x538A140", Offset = "0x5388D40", VA = "0x18538A140")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002655")]
			[Address(RVA = "0x538A900", Offset = "0x5389500", VA = "0x18538A900")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x000109B0 File Offset: 0x0000EBB0
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000547")]
		public static TimeSpan RequestTimeout
		{
			[Token(Token = "0x6002656")]
			[Address(RVA = "0x538A810", Offset = "0x5389410", VA = "0x18538A810")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002657")]
			[Address(RVA = "0x538AEE0", Offset = "0x5389AE0", VA = "0x18538AEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000548")]
		public static Func<string> RootCacheFolderProvider
		{
			[Token(Token = "0x6002658")]
			[Address(RVA = "0x538A860", Offset = "0x5389460", VA = "0x18538A860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002659")]
			[Address(RVA = "0x538AF40", Offset = "0x5389B40", VA = "0x18538AF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000549")]
		public static HTTPProxy Proxy
		{
			[Token(Token = "0x600265A")]
			[Address(RVA = "0x538A7C0", Offset = "0x53893C0", VA = "0x18538A7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600265B")]
			[Address(RVA = "0x538AE70", Offset = "0x5389A70", VA = "0x18538AE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054A")]
		public static HeartbeatManager Heartbeats
		{
			[Token(Token = "0x600265C")]
			[Address(RVA = "0x538A320", Offset = "0x5388F20", VA = "0x18538A320")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054B")]
		public static ILogger Logger
		{
			[Token(Token = "0x600265D")]
			[Address(RVA = "0x538A510", Offset = "0x5389110", VA = "0x18538A510")]
			get
			{
				return null;
			}
			[Token(Token = "0x600265E")]
			[Address(RVA = "0x538AC90", Offset = "0x5389890", VA = "0x18538AC90")]
			set
			{
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054C")]
		public static ICertificateVerifyer DefaultCertificateVerifyer
		{
			[Token(Token = "0x600265F")]
			[Address(RVA = "0x538A1E0", Offset = "0x5388DE0", VA = "0x18538A1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002660")]
			[Address(RVA = "0x538A9C0", Offset = "0x53895C0", VA = "0x18538A9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054D")]
		public static IClientCredentialsProvider DefaultClientCredentialsProvider
		{
			[Token(Token = "0x6002661")]
			[Address(RVA = "0x538A280", Offset = "0x5388E80", VA = "0x18538A280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002662")]
			[Address(RVA = "0x538AAA0", Offset = "0x53896A0", VA = "0x18538AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x000109C8 File Offset: 0x0000EBC8
		// (set) Token: 0x06002664 RID: 9828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054E")]
		public static bool UseAlternateSSLDefaultValue
		{
			[Token(Token = "0x6002663")]
			[Address(RVA = "0x538A8B0", Offset = "0x53894B0", VA = "0x18538A8B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002664")]
			[Address(RVA = "0x538AFB0", Offset = "0x5389BB0", VA = "0x18538AFB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002666 RID: 9830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054F")]
		public static Func<HTTPRequest, X509Certificate, X509Chain, bool> DefaultCertificationValidator
		{
			[Token(Token = "0x6002665")]
			[Address(RVA = "0x538A230", Offset = "0x5388E30", VA = "0x18538A230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002666")]
			[Address(RVA = "0x538AA30", Offset = "0x5389630", VA = "0x18538AA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x000109E0 File Offset: 0x0000EBE0
		// (set) Token: 0x06002668 RID: 9832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000550")]
		internal static int MaxPathLength
		{
			[Token(Token = "0x6002667")]
			[Address(RVA = "0x538A770", Offset = "0x5389370", VA = "0x18538A770")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002668")]
			[Address(RVA = "0x538AE10", Offset = "0x5389A10", VA = "0x18538AE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x5389A30", Offset = "0x5388630", VA = "0x185389A30")]
		public static void Setup()
		{
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266A")]
		[Address(RVA = "0x5389660", Offset = "0x5388260", VA = "0x185389660")]
		public static HTTPRequest SendRequest(string url, OnRequestFinishedDelegate callback)
		{
			return null;
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x5389950", Offset = "0x5388550", VA = "0x185389950")]
		public static HTTPRequest SendRequest(string url, HTTPMethods methodType, OnRequestFinishedDelegate callback)
		{
			return null;
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x53894E0", Offset = "0x53880E0", VA = "0x1853894E0")]
		public static HTTPRequest SendRequest(string url, HTTPMethods methodType, bool isKeepAlive, OnRequestFinishedDelegate callback)
		{
			return null;
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x53893D0", Offset = "0x5387FD0", VA = "0x1853893D0")]
		public static HTTPRequest SendRequest(string url, HTTPMethods methodType, bool isKeepAlive, bool disableCache, OnRequestFinishedDelegate callback)
		{
			return null;
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x5389730", Offset = "0x5388330", VA = "0x185389730")]
		public static HTTPRequest SendRequest(HTTPRequest request)
		{
			return null;
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x5386F00", Offset = "0x5385B00", VA = "0x185386F00")]
		public static GeneralStatistics GetGeneralStatistics(StatisticsQueryFlags queryFlags)
		{
			return default(GeneralStatistics);
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00010A10 File Offset: 0x0000EC10
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x53861E0", Offset = "0x5384DE0", VA = "0x1853861E0")]
		public static int CloseFreeConnectionsForRequestUri(HTTPRequest req)
		{
			return 0;
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x5388FF0", Offset = "0x5387BF0", VA = "0x185388FF0")]
		private static void SendRequestImpl(HTTPRequest request)
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x5387230", Offset = "0x5385E30", VA = "0x185387230")]
		private static string GetKeyForRequest(HTTPRequest request)
		{
			return null;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x5386720", Offset = "0x5385320", VA = "0x185386720")]
		private static ConnectionBase CreateConnection(HTTPRequest request, string serverUrl)
		{
			return null;
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x53867D0", Offset = "0x53853D0", VA = "0x1853867D0")]
		private static ConnectionBase FindOrCreateFreeConnection(HTTPRequest request)
		{
			return null;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00010A28 File Offset: 0x0000EC28
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x5386100", Offset = "0x5384D00", VA = "0x185386100")]
		private static bool CanProcessFromQueue()
		{
			return default(bool);
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x5388DC0", Offset = "0x53879C0", VA = "0x185388DC0")]
		private static void RecycleConnection(ConnectionBase conn)
		{
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x53876A0", Offset = "0x53862A0", VA = "0x1853876A0")]
		private static void OnConnectionRecylced(ConnectionBase conn)
		{
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x5386D10", Offset = "0x5385910", VA = "0x185386D10")]
		internal static ConnectionBase GetConnectionWith(HTTPRequest request)
		{
			return null;
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x00010A40 File Offset: 0x0000EC40
		[Token(Token = "0x6002679")]
		[Address(RVA = "0x5388F70", Offset = "0x5387B70", VA = "0x185388F70")]
		internal static bool RemoveFromQueue(HTTPRequest request)
		{
			return default(bool);
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x53874F0", Offset = "0x53860F0", VA = "0x1853874F0")]
		internal static string GetRootCacheFolder()
		{
			return null;
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x5387D40", Offset = "0x5386940", VA = "0x185387D40")]
		public static void OnUpdate()
		{
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x53877C0", Offset = "0x53863C0", VA = "0x1853877C0")]
		public static void OnQuit()
		{
		}

		// Token: 0x04001556 RID: 5462
		[Token(Token = "0x4001556")]
		[FieldOffset(Offset = "0x0")]
		private static byte maxConnectionPerServer;

		// Token: 0x04001561 RID: 5473
		[Token(Token = "0x4001561")]
		[FieldOffset(Offset = "0x40")]
		private static HeartbeatManager heartbeats;

		// Token: 0x04001562 RID: 5474
		[Token(Token = "0x4001562")]
		[FieldOffset(Offset = "0x48")]
		private static ILogger logger;

		// Token: 0x04001567 RID: 5479
		[Token(Token = "0x4001567")]
		[FieldOffset(Offset = "0x70")]
		public static bool TryToMinimizeTCPLatency;

		// Token: 0x04001569 RID: 5481
		[Token(Token = "0x4001569")]
		[FieldOffset(Offset = "0x78")]
		private static Dictionary<string, List<ConnectionBase>> Connections;

		// Token: 0x0400156A RID: 5482
		[Token(Token = "0x400156A")]
		[FieldOffset(Offset = "0x80")]
		private static List<ConnectionBase> ActiveConnections;

		// Token: 0x0400156B RID: 5483
		[Token(Token = "0x400156B")]
		[FieldOffset(Offset = "0x88")]
		private static List<ConnectionBase> FreeConnections;

		// Token: 0x0400156C RID: 5484
		[Token(Token = "0x400156C")]
		[FieldOffset(Offset = "0x90")]
		private static List<ConnectionBase> RecycledConnections;

		// Token: 0x0400156D RID: 5485
		[Token(Token = "0x400156D")]
		[FieldOffset(Offset = "0x98")]
		private static List<HTTPRequest> RequestQueue;

		// Token: 0x0400156E RID: 5486
		[Token(Token = "0x400156E")]
		[FieldOffset(Offset = "0xA0")]
		private static bool IsCallingCallbacks;

		// Token: 0x0400156F RID: 5487
		[Token(Token = "0x400156F")]
		[FieldOffset(Offset = "0xA8")]
		internal static object Locker;
	}
}
