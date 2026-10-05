using System;
using System.IO;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	public sealed class FtpWebRequest : WebRequest
	{
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D7")]
		internal FtpMethodInfo MethodInfo
		{
			[Token(Token = "0x60012C0")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D8")]
		public override string Method
		{
			[Token(Token = "0x60012C1")]
			[Address(RVA = "0x4DE3920", Offset = "0x4DE2520", VA = "0x184DE3920", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012C2")]
			[Address(RVA = "0x51AAF40", Offset = "0x51A9B40", VA = "0x1851AAF40", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D9")]
		public string RenameTo
		{
			[Token(Token = "0x60012C3")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DA")]
		public override ICredentials Credentials
		{
			[Token(Token = "0x60012C4")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012C5")]
			[Address(RVA = "0x51AADB0", Offset = "0x51A99B0", VA = "0x1851AADB0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DB")]
		public override Uri RequestUri
		{
			[Token(Token = "0x60012C6")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00009240 File Offset: 0x00007440
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DC")]
		public override int Timeout
		{
			[Token(Token = "0x60012C7")]
			[Address(RVA = "0x4C2EA10", Offset = "0x4C2D610", VA = "0x184C2EA10", Slot = "21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60012C8")]
			[Address(RVA = "0x51AB160", Offset = "0x51A9D60", VA = "0x1851AB160", Slot = "22")]
			set
			{
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x170003DD")]
		internal int RemainingTimeout
		{
			[Token(Token = "0x60012C9")]
			[Address(RVA = "0x4D7C600", Offset = "0x4D7B200", VA = "0x184D7C600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x170003DE")]
		public int ReadWriteTimeout
		{
			[Token(Token = "0x60012CA")]
			[Address(RVA = "0x51AAC30", Offset = "0x51A9830", VA = "0x1851AAC30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x170003DF")]
		public long ContentOffset
		{
			[Token(Token = "0x60012CB")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x000092A0 File Offset: 0x000074A0
		// (set) Token: 0x060012CD RID: 4813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E0")]
		public override long ContentLength
		{
			[Token(Token = "0x60012CC")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80", Slot = "13")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60012CD")]
			[Address(RVA = "0x51AAD70", Offset = "0x51A9970", VA = "0x1851AAD70", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E1")]
		public override IWebProxy Proxy
		{
			[Token(Token = "0x60012CE")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012CF")]
			[Address(RVA = "0x51AB0F0", Offset = "0x51A9CF0", VA = "0x1851AB0F0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x170003E2")]
		internal bool Aborted
		{
			[Token(Token = "0x60012D0")]
			[Address(RVA = "0x4FAE4A0", Offset = "0x4FAD0A0", VA = "0x184FAE4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x51AA5F0", Offset = "0x51A91F0", VA = "0x1851AA5F0")]
		internal FtpWebRequest(Uri uri)
		{
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x51A8760", Offset = "0x51A7360", VA = "0x1851A8760", Slot = "24")]
		public override WebResponse GetResponse()
		{
			return null;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x51A6580", Offset = "0x51A5180", VA = "0x1851A6580", Slot = "25")]
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x51A7230", Offset = "0x51A5E30", VA = "0x1851A7230", Slot = "26")]
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x51A81D0", Offset = "0x51A6DD0", VA = "0x1851A81D0", Slot = "23")]
		public override Stream GetRequestStream()
		{
			return null;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x51A60A0", Offset = "0x51A4CA0", VA = "0x1851A60A0", Slot = "27")]
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x51A6E60", Offset = "0x51A5A60", VA = "0x1851A6E60", Slot = "28")]
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x51A9390", Offset = "0x51A7F90", VA = "0x1851A9390")]
		private void SubmitRequest(bool isAsync)
		{
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x51AA3A0", Offset = "0x51A8FA0", VA = "0x1851AA3A0")]
		private Exception TranslateConnectException(Exception e)
		{
			return null;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x51A6BC0", Offset = "0x51A57C0", VA = "0x1851A6BC0")]
		private void CreateConnectionAsync()
		{
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x51A6C80", Offset = "0x51A5880", VA = "0x1851A6C80")]
		private FtpControlStream CreateConnection()
		{
			return null;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x51A9DE0", Offset = "0x51A89E0", VA = "0x1851A9DE0")]
		private Stream TimedSubmitRequestHelper(bool isAsync)
		{
			return null;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x51AA200", Offset = "0x51A8E00", VA = "0x1851AA200")]
		private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context)
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E3")]
		private TimerThread.Queue TimerQueue
		{
			[Token(Token = "0x60012DE")]
			[Address(RVA = "0x51AAC40", Offset = "0x51A9840", VA = "0x1851AAC40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x51A5DE0", Offset = "0x51A49E0", VA = "0x1851A5DE0")]
		private bool AttemptedRecovery(Exception e)
		{
			return default(bool);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x51A8F60", Offset = "0x51A7B60", VA = "0x1851A8F60")]
		private void SetException(Exception exception)
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x51A6BA0", Offset = "0x51A57A0", VA = "0x1851A6BA0")]
		private void CheckError()
		{
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x51A8F40", Offset = "0x51A7B40", VA = "0x1851A8F40")]
		internal void RequestCallback(object obj)
		{
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x51A9930", Offset = "0x51A8530", VA = "0x1851A9930")]
		private void SyncRequestCallback(object obj)
		{
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x51A51E0", Offset = "0x51A3DE0", VA = "0x1851A51E0")]
		private void AsyncRequestCallback(object obj)
		{
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x51A7CA0", Offset = "0x51A68A0", VA = "0x1851A7CA0")]
		private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage)
		{
			return FtpWebRequest.RequestStage.CheckForError;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x51A4E10", Offset = "0x51A3A10", VA = "0x1851A4E10", Slot = "31")]
		public override void Abort()
		{
		}

		// Token: 0x170003E4 RID: 996
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E4")]
		public override RequestCachePolicy CachePolicy
		{
			[Token(Token = "0x60012E7")]
			[Address(RVA = "0x51AAD00", Offset = "0x51A9900", VA = "0x1851AAD00", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x170003E5")]
		public bool UseBinary
		{
			[Token(Token = "0x60012E8")]
			[Address(RVA = "0x51AACC0", Offset = "0x51A98C0", VA = "0x1851AACC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x170003E6")]
		public bool UsePassive
		{
			[Token(Token = "0x60012E9")]
			[Address(RVA = "0x22032F0", Offset = "0x2201EF0", VA = "0x1822032F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E7")]
		public X509CertificateCollection ClientCertificates
		{
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x51AAA60", Offset = "0x51A9660", VA = "0x1851AAA60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x170003E8")]
		public bool EnableSsl
		{
			[Token(Token = "0x60012EB")]
			[Address(RVA = "0x51CBE0", Offset = "0x51B7E0", VA = "0x18051CBE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E9")]
		public override WebHeaderCollection Headers
		{
			[Token(Token = "0x60012EC")]
			[Address(RVA = "0x51AAB90", Offset = "0x51A9790", VA = "0x1851AAB90", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EA")]
		public override string ContentType
		{
			[Token(Token = "0x60012ED")]
			[Address(RVA = "0x51AAD80", Offset = "0x51A9980", VA = "0x1851AAD80", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x170003EB")]
		public override bool UseDefaultCredentials
		{
			[Token(Token = "0x60012EE")]
			[Address(RVA = "0x51AACD0", Offset = "0x51A98D0", VA = "0x1851AACD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x170003EC")]
		private bool InUse
		{
			[Token(Token = "0x60012EF")]
			[Address(RVA = "0x51AAC10", Offset = "0x51A9810", VA = "0x1851AAC10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x51A7580", Offset = "0x51A6180", VA = "0x1851A7580")]
		private void EnsureFtpWebResponse(Exception exception)
		{
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x51A6DA0", Offset = "0x51A59A0", VA = "0x1851A6DA0")]
		internal void DataStreamClosed(CloseExState closeState)
		{
		}

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x38")]
		private object _syncObject;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x40")]
		private ICredentials _authInfo;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x48")]
		private readonly Uri _uri;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x50")]
		private FtpMethodInfo _methodInfo;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x58")]
		private string _renameTo;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x60")]
		private bool _getRequestStreamStarted;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x61")]
		private bool _getResponseStarted;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x68")]
		private DateTime _startTime;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x70")]
		private int _timeout;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x74")]
		private int _remainingTimeout;

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		[FieldOffset(Offset = "0x78")]
		private long _contentLength;

		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		[FieldOffset(Offset = "0x80")]
		private long _contentOffset;

		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0x88")]
		private X509CertificateCollection _clientCertificates;

		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		[FieldOffset(Offset = "0x90")]
		private bool _passive;

		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		[FieldOffset(Offset = "0x91")]
		private bool _binary;

		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		[FieldOffset(Offset = "0x92")]
		private bool _async;

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x93")]
		private bool _aborted;

		// Token: 0x040009AE RID: 2478
		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x94")]
		private bool _timedOut;

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x98")]
		private Exception _exception;

		// Token: 0x040009B0 RID: 2480
		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0xA0")]
		private TimerThread.Queue _timerQueue;

		// Token: 0x040009B1 RID: 2481
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0xA8")]
		private TimerThread.Callback _timerCallback;

		// Token: 0x040009B2 RID: 2482
		[Token(Token = "0x40009B2")]
		[FieldOffset(Offset = "0xB0")]
		private bool _enableSsl;

		// Token: 0x040009B3 RID: 2483
		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0xB8")]
		private FtpControlStream _connection;

		// Token: 0x040009B4 RID: 2484
		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0xC0")]
		private Stream _stream;

		// Token: 0x040009B5 RID: 2485
		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0xC8")]
		private FtpWebRequest.RequestStage _requestStage;

		// Token: 0x040009B6 RID: 2486
		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0xCC")]
		private bool _onceFailed;

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0xD0")]
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0xD8")]
		private FtpWebResponse _ftpWebResponse;

		// Token: 0x040009B9 RID: 2489
		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0xE0")]
		private int _readWriteTimeout;

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0xE8")]
		private ContextAwareResult _writeAsyncResult;

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0xF0")]
		private LazyAsyncResult _readAsyncResult;

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0xF8")]
		private LazyAsyncResult _requestCompleteAsyncResult;

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly NetworkCredential s_defaultFtpNetworkCredential;

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TimerThread.Queue s_DefaultTimerQueue;

		// Token: 0x0200029A RID: 666
		[Token(Token = "0x200029A")]
		private enum RequestStage
		{
			// Token: 0x040009C0 RID: 2496
			[Token(Token = "0x40009C0")]
			CheckForError,
			// Token: 0x040009C1 RID: 2497
			[Token(Token = "0x40009C1")]
			RequestStarted,
			// Token: 0x040009C2 RID: 2498
			[Token(Token = "0x40009C2")]
			WriteReady,
			// Token: 0x040009C3 RID: 2499
			[Token(Token = "0x40009C3")]
			ReadReady,
			// Token: 0x040009C4 RID: 2500
			[Token(Token = "0x40009C4")]
			ReleaseConnection
		}
	}
}
