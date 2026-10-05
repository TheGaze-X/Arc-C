using System;
using System.Collections.Concurrent;
using System.Net.Security;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000333 RID: 819
	[Token(Token = "0x2000333")]
	public class ServicePointManager
	{
		// Token: 0x060016FA RID: 5882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x508A3F0", Offset = "0x5088FF0", VA = "0x18508A3F0")]
		internal static ICertificatePolicy GetLegacyCertificatePolicy()
		{
			return null;
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x17000505")]
		[MonoTODO("CRL checks not implemented")]
		public static bool CheckCertificateRevocationList
		{
			[Token(Token = "0x60016FB")]
			[Address(RVA = "0x508A5F0", Offset = "0x50891F0", VA = "0x18508A5F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000506")]
		public static int DefaultConnectionLimit
		{
			[Token(Token = "0x60016FC")]
			[Address(RVA = "0x508A7C0", Offset = "0x50893C0", VA = "0x18508A7C0")]
			set
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x17000507")]
		public static int DnsRefreshTimeout
		{
			[Token(Token = "0x60016FD")]
			[Address(RVA = "0x508A640", Offset = "0x5089240", VA = "0x18508A640")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x17000508")]
		public static SecurityProtocolType SecurityProtocol
		{
			[Token(Token = "0x60016FE")]
			[Address(RVA = "0x508A690", Offset = "0x5089290", VA = "0x18508A690")]
			get
			{
				return SecurityProtocolType.SystemDefault;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000509")]
		internal static ServerCertValidationCallback ServerCertValidationCallback
		{
			[Token(Token = "0x60016FF")]
			[Address(RVA = "0x508A6E0", Offset = "0x50892E0", VA = "0x18508A6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050A")]
		public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			[Token(Token = "0x6001700")]
			[Address(RVA = "0x508A730", Offset = "0x5089330", VA = "0x18508A730")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001701")]
			[Address(RVA = "0x508A870", Offset = "0x5089470", VA = "0x18508A870")]
			set
			{
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001702")]
		[Address(RVA = "0x5089B00", Offset = "0x5088700", VA = "0x185089B00")]
		public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
		{
			return null;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001703")]
		[Address(RVA = "0x508A440", Offset = "0x5089040", VA = "0x18508A440")]
		internal static void RemoveServicePoint(ServicePoint sp)
		{
		}

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x0")]
		private static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints;

		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x8")]
		private static ICertificatePolicy policy;

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x10")]
		private static int defaultConnectionLimit;

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x14")]
		private static int maxServicePointIdleTime;

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x18")]
		private static int maxServicePoints;

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x1C")]
		private static int dnsRefreshTimeout;

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x20")]
		private static bool _checkCRL;

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x24")]
		private static SecurityProtocolType _securityProtocol;

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x28")]
		private static bool expectContinue;

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x29")]
		private static bool useNagle;

		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		[FieldOffset(Offset = "0x30")]
		private static ServerCertValidationCallback server_cert_cb;

		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x38")]
		private static bool tcp_keepalive;

		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		[FieldOffset(Offset = "0x3C")]
		private static int tcp_keepalive_time;

		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x40")]
		private static int tcp_keepalive_interval;

		// Token: 0x02000334 RID: 820
		[Token(Token = "0x2000334")]
		internal class SPKey
		{
			// Token: 0x06001704 RID: 5892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001704")]
			[Address(RVA = "0x4AE4B20", Offset = "0x4AE3720", VA = "0x184AE4B20")]
			public SPKey(Uri uri, Uri proxy, bool use_connect)
			{
			}

			// Token: 0x1700050B RID: 1291
			// (get) Token: 0x06001705 RID: 5893 RVA: 0x0000A878 File Offset: 0x00008A78
			[Token(Token = "0x1700050B")]
			public bool UsesProxy
			{
				[Token(Token = "0x6001705")]
				[Address(RVA = "0x5089AB0", Offset = "0x50886B0", VA = "0x185089AB0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001706 RID: 5894 RVA: 0x0000A890 File Offset: 0x00008A90
			[Token(Token = "0x6001706")]
			[Address(RVA = "0x50899B0", Offset = "0x50885B0", VA = "0x1850899B0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06001707 RID: 5895 RVA: 0x0000A8A8 File Offset: 0x00008AA8
			[Token(Token = "0x6001707")]
			[Address(RVA = "0x5089860", Offset = "0x5088460", VA = "0x185089860", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x04000D13 RID: 3347
			[Token(Token = "0x4000D13")]
			[FieldOffset(Offset = "0x10")]
			private Uri uri;

			// Token: 0x04000D14 RID: 3348
			[Token(Token = "0x4000D14")]
			[FieldOffset(Offset = "0x18")]
			private Uri proxy;

			// Token: 0x04000D15 RID: 3349
			[Token(Token = "0x4000D15")]
			[FieldOffset(Offset = "0x20")]
			private bool use_connect;
		}
	}
}
