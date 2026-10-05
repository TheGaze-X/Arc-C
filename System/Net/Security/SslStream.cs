using System;
using System.IO;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net.Security
{
	// Token: 0x020003D7 RID: 983
	[Token(Token = "0x20003D7")]
	public class SslStream : AuthenticatedStream
	{
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C5")]
		internal MobileAuthenticatedStream Impl
		{
			[Token(Token = "0x6001A50")]
			[Address(RVA = "0x50C3380", Offset = "0x50C1F80", VA = "0x1850C3380")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C6")]
		internal string InternalTargetHost
		{
			[Token(Token = "0x6001A51")]
			[Address(RVA = "0x50C33F0", Offset = "0x50C1FF0", VA = "0x1850C33F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x50C2700", Offset = "0x50C1300", VA = "0x1850C2700")]
		private static MobileTlsProvider GetProvider()
		{
			return null;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x50C3080", Offset = "0x50C1C80", VA = "0x1850C3080")]
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback)
		{
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x50C30A0", Offset = "0x50C1CA0", VA = "0x1850C30A0")]
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback)
		{
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A55")]
		[Address(RVA = "0x50C2EC0", Offset = "0x50C1AC0", VA = "0x1850C2EC0")]
		internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings)
		{
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A56")]
		[Address(RVA = "0x50C2B90", Offset = "0x50C1790", VA = "0x1850C2B90")]
		private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback)
		{
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A57")]
		[Address(RVA = "0x50C29C0", Offset = "0x50C15C0", VA = "0x1850C29C0")]
		private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback)
		{
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x50C2250", Offset = "0x50C0E50", VA = "0x1850C2250", Slot = "39")]
		public virtual void AuthenticateAsClient(string targetHost)
		{
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x50C21C0", Offset = "0x50C0DC0", VA = "0x1850C21C0", Slot = "40")]
		public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x50C2380", Offset = "0x50C0F80", VA = "0x1850C2380", Slot = "41")]
		public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x4B24600", Offset = "0x4B23200", VA = "0x184B24600", Slot = "42")]
		public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x50C22F0", Offset = "0x50C0EF0", VA = "0x1850C22F0", Slot = "43")]
		public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x50C2130", Offset = "0x50C0D30", VA = "0x1850C2130", Slot = "44")]
		public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			return null;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x170005C7")]
		public override bool IsAuthenticated
		{
			[Token(Token = "0x6001A5E")]
			[Address(RVA = "0x50C3470", Offset = "0x50C2070", VA = "0x1850C3470", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C8")]
		public virtual X509Certificate LocalCertificate
		{
			[Token(Token = "0x6001A5F")]
			[Address(RVA = "0x50C3590", Offset = "0x50C2190", VA = "0x1850C3590", Slot = "45")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x170005C9")]
		public override bool CanSeek
		{
			[Token(Token = "0x6001A60")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x170005CA")]
		public override bool CanRead
		{
			[Token(Token = "0x6001A61")]
			[Address(RVA = "0x50C32E0", Offset = "0x50C1EE0", VA = "0x1850C32E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x170005CB")]
		public override bool CanTimeout
		{
			[Token(Token = "0x6001A62")]
			[Address(RVA = "0x4F520B0", Offset = "0x4F50CB0", VA = "0x184F520B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x170005CC")]
		public override bool CanWrite
		{
			[Token(Token = "0x6001A63")]
			[Address(RVA = "0x50C3330", Offset = "0x50C1F30", VA = "0x1850C3330", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		// (set) Token: 0x06001A65 RID: 6757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CD")]
		public override int ReadTimeout
		{
			[Token(Token = "0x6001A64")]
			[Address(RVA = "0x50C36A0", Offset = "0x50C22A0", VA = "0x1850C36A0", Slot = "14")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A65")]
			[Address(RVA = "0x50C3830", Offset = "0x50C2430", VA = "0x1850C3830", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		// (set) Token: 0x06001A67 RID: 6759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CE")]
		public override int WriteTimeout
		{
			[Token(Token = "0x6001A66")]
			[Address(RVA = "0x50C3730", Offset = "0x50C2330", VA = "0x1850C3730", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A67")]
			[Address(RVA = "0x50C38D0", Offset = "0x50C24D0", VA = "0x1850C38D0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x170005CF")]
		public override long Length
		{
			[Token(Token = "0x6001A68")]
			[Address(RVA = "0x50C3500", Offset = "0x50C2100", VA = "0x1850C3500", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0000BC10 File Offset: 0x00009E10
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D0")]
		public override long Position
		{
			[Token(Token = "0x6001A69")]
			[Address(RVA = "0x50C3610", Offset = "0x50C2210", VA = "0x1850C3610", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001A6A")]
			[Address(RVA = "0x50C37C0", Offset = "0x50C23C0", VA = "0x1850C37C0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6B")]
		[Address(RVA = "0x50C2C90", Offset = "0x50C1890", VA = "0x1850C2C90", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x6001A6C")]
		[Address(RVA = "0x50C2950", Offset = "0x50C1550", VA = "0x1850C2950", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A6D")]
		[Address(RVA = "0x50C26A0", Offset = "0x50C12A0", VA = "0x1850C26A0", Slot = "21")]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6E")]
		[Address(RVA = "0x4A3E4A0", Offset = "0x4A3D0A0", VA = "0x184A3E4A0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A6F")]
		[Address(RVA = "0x50C2540", Offset = "0x50C1140", VA = "0x1850C2540")]
		private void CheckDisposed()
		{
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A70")]
		[Address(RVA = "0x50C25B0", Offset = "0x50C11B0", VA = "0x1850C25B0", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x6001A71")]
		[Address(RVA = "0x50C2880", Offset = "0x50C1480", VA = "0x1850C2880", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A72")]
		[Address(RVA = "0x50C2E00", Offset = "0x50C1A00", VA = "0x1850C2E00", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A73")]
		[Address(RVA = "0x50C27B0", Offset = "0x50C13B0", VA = "0x1850C27B0", Slot = "24")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A74")]
		[Address(RVA = "0x50C2D30", Offset = "0x50C1930", VA = "0x1850C2D30", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A75")]
		[Address(RVA = "0x50C2420", Offset = "0x50C1020", VA = "0x1850C2420", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x6001A76")]
		[Address(RVA = "0x50C2660", Offset = "0x50C1260", VA = "0x1850C2660", Slot = "23")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A77")]
		[Address(RVA = "0x50C24B0", Offset = "0x50C10B0", VA = "0x1850C24B0", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A78")]
		[Address(RVA = "0x4B24600", Offset = "0x4B23200", VA = "0x184B24600", Slot = "27")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x38")]
		private MobileTlsProvider provider;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x40")]
		private MonoTlsSettings settings;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x48")]
		private RemoteCertificateValidationCallback validationCallback;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x50")]
		private LocalCertificateSelectionCallback selectionCallback;

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x58")]
		private MobileAuthenticatedStream impl;

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x60")]
		private bool explicitSettings;
	}
}
