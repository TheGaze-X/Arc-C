using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Mono.Net.Security;

namespace System.Net
{
	// Token: 0x02000341 RID: 833
	[Token(Token = "0x2000341")]
	internal class WebConnection : IDisposable
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000515")]
		public ServicePoint ServicePoint
		{
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001744")]
		[Address(RVA = "0x50987B0", Offset = "0x50973B0", VA = "0x1850987B0")]
		public WebConnection(ServicePoint sPoint)
		{
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x5097720", Offset = "0x5096320", VA = "0x185097720")]
		private bool CanReuse()
		{
			return default(bool);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x5097750", Offset = "0x5096350", VA = "0x185097750")]
		private bool CheckReusable()
		{
			return default(bool);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x50979A0", Offset = "0x50965A0", VA = "0x1850979A0")]
		private Task Connect(WebOperation operation, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x5097C20", Offset = "0x5096820", VA = "0x185097C20")]
		private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x5097F90", Offset = "0x5096B90", VA = "0x185097F90")]
		internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600174A")]
		[Address(RVA = "0x5097DB0", Offset = "0x50969B0", VA = "0x185097DB0")]
		internal static WebException GetException(WebExceptionStatus status, Exception error)
		{
			return null;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x600174B")]
		[Address(RVA = "0x5098310", Offset = "0x5096F10", VA = "0x185098310")]
		internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output)
		{
			return default(bool);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x600174C")]
		[Address(RVA = "0x5097410", Offset = "0x5096010", VA = "0x185097410")]
		internal bool CanReuseConnection(WebOperation operation)
		{
			return default(bool);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x600174D")]
		[Address(RVA = "0x50980E0", Offset = "0x5096CE0", VA = "0x1850980E0")]
		private bool PrepareSharingNtlm(WebOperation operation)
		{
			return default(bool);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600174E")]
		[Address(RVA = "0x5098520", Offset = "0x5097120", VA = "0x185098520")]
		private void Reset()
		{
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600174F")]
		[Address(RVA = "0x5097900", Offset = "0x5096500", VA = "0x185097900")]
		private void Close(bool reset)
		{
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001750")]
		[Address(RVA = "0x50977A0", Offset = "0x50963A0", VA = "0x1850977A0")]
		private void CloseSocket()
		{
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x0000AA70 File Offset: 0x00008C70
		[Token(Token = "0x17000516")]
		public bool Closed
		{
			[Token(Token = "0x6001751")]
			[Address(RVA = "0x30FF580", Offset = "0x30FE180", VA = "0x1830FF580")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0000AA88 File Offset: 0x00008C88
		[Token(Token = "0x17000517")]
		public DateTime IdleSince
		{
			[Token(Token = "0x6001752")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x6001753")]
		[Address(RVA = "0x50985D0", Offset = "0x50971D0", VA = "0x1850985D0")]
		public bool StartOperation(WebOperation operation, bool reused)
		{
			return default(bool);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x6001754")]
		[Address(RVA = "0x5097AC0", Offset = "0x50966C0", VA = "0x185097AC0")]
		public bool Continue(WebOperation next)
		{
			return default(bool);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001755")]
		[Address(RVA = "0x5097D70", Offset = "0x5096970", VA = "0x185097D70")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001756")]
		[Address(RVA = "0x5097D70", Offset = "0x5096970", VA = "0x185097D70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x50984F0", Offset = "0x50970F0", VA = "0x1850984F0")]
		private void ResetNtlm()
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000518")]
		internal bool NtlmAuthenticated
		{
			[Token(Token = "0x6001758")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001759")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000519")]
		internal NetworkCredential NtlmCredential
		{
			[Token(Token = "0x600175A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600175B")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051A")]
		internal bool UnsafeAuthenticatedConnectionSharing
		{
			[Token(Token = "0x600175C")]
			[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600175D")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			set
			{
			}
		}

		// Token: 0x04000D50 RID: 3408
		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x10")]
		private NetworkCredential ntlm_credentials;

		// Token: 0x04000D51 RID: 3409
		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x18")]
		private bool ntlm_authenticated;

		// Token: 0x04000D52 RID: 3410
		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x19")]
		private bool unsafe_sharing;

		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x20")]
		private Stream networkStream;

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x28")]
		private Socket socket;

		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x30")]
		private MonoTlsStream monoTlsStream;

		// Token: 0x04000D56 RID: 3414
		[Token(Token = "0x4000D56")]
		[FieldOffset(Offset = "0x38")]
		private WebConnectionTunnel tunnel;

		// Token: 0x04000D57 RID: 3415
		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x40")]
		private int disposed;

		// Token: 0x04000D59 RID: 3417
		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x50")]
		private DateTime idleSince;

		// Token: 0x04000D5A RID: 3418
		[Token(Token = "0x4000D5A")]
		[FieldOffset(Offset = "0x58")]
		private WebOperation currentOperation;
	}
}
