using System;
using System.Collections;
using System.IO;
using System.Net.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace System.Net
{
	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	public sealed class HttpListener : IDisposable
	{
		// Token: 0x060015A5 RID: 5541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x507B990", Offset = "0x507A590", VA = "0x18507B990")]
		internal X509Certificate LoadCertificateAndKey(IPAddress addr, int port)
		{
			return null;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x507B1A0", Offset = "0x5079DA0", VA = "0x18507B1A0")]
		internal SslStream CreateSslStream(Stream innerStream, bool ownsStream, RemoteCertificateValidationCallback callback)
		{
			return null;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x507C4C0", Offset = "0x507B0C0", VA = "0x18507C4C0")]
		public HttpListener()
		{
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x1700048E")]
		public AuthenticationSchemes AuthenticationSchemes
		{
			[Token(Token = "0x60015A8")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return AuthenticationSchemes.None;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048F")]
		public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
		{
			[Token(Token = "0x60015A9")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x17000490")]
		public bool IgnoreWriteExceptions
		{
			[Token(Token = "0x60015AA")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x17000491")]
		public bool IsListening
		{
			[Token(Token = "0x60015AB")]
			[Address(RVA = "0x2033940", Offset = "0x2032540", VA = "0x182033940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000492")]
		public HttpListenerPrefixCollection Prefixes
		{
			[Token(Token = "0x60015AC")]
			[Address(RVA = "0x507C750", Offset = "0x507B350", VA = "0x18507C750")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000493")]
		public string Realm
		{
			[Token(Token = "0x60015AD")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x507B0F0", Offset = "0x5079CF0", VA = "0x18507B0F0")]
		public void Close()
		{
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015AF")]
		[Address(RVA = "0x507B130", Offset = "0x5079D30", VA = "0x18507B130")]
		private void Close(bool force)
		{
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B0")]
		[Address(RVA = "0x507A690", Offset = "0x5079290", VA = "0x18507A690")]
		private void Cleanup(bool close_existing)
		{
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B1")]
		[Address(RVA = "0x507A280", Offset = "0x5078E80", VA = "0x18507A280")]
		public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B2")]
		[Address(RVA = "0x507B350", Offset = "0x5079F50", VA = "0x18507B350")]
		public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x60015B3")]
		[Address(RVA = "0x507C150", Offset = "0x507AD50", VA = "0x18507C150")]
		internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerContext context)
		{
			return AuthenticationSchemes.None;
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B4")]
		[Address(RVA = "0x507C190", Offset = "0x507AD90", VA = "0x18507C190")]
		public void Start()
		{
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B5")]
		[Address(RVA = "0x507C1F0", Offset = "0x507ADF0", VA = "0x18507C1F0")]
		public void Stop()
		{
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B6")]
		[Address(RVA = "0x507C260", Offset = "0x507AE60", VA = "0x18507C260", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x507B770", Offset = "0x507A370", VA = "0x18507B770")]
		public Task<HttpListenerContext> GetContextAsync()
		{
			return null;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x507A600", Offset = "0x5079200", VA = "0x18507A600")]
		internal void CheckDisposed()
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x507B880", Offset = "0x507A480", VA = "0x18507B880")]
		private HttpListenerContext GetContextFromQueue()
		{
			return null;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x507BD30", Offset = "0x507A930", VA = "0x18507BD30")]
		internal void RegisterContext(HttpListenerContext context)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x507C2D0", Offset = "0x507AED0", VA = "0x18507C2D0")]
		internal void UnregisterContext(HttpListenerContext context)
		{
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x507A220", Offset = "0x5078E20", VA = "0x18507A220")]
		internal void AddConnection(HttpConnection cnc)
		{
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x507C100", Offset = "0x507AD00", VA = "0x18507C100")]
		internal void RemoveConnection(HttpConnection cnc)
		{
		}

		// Token: 0x04000BE9 RID: 3049
		[Token(Token = "0x4000BE9")]
		[FieldOffset(Offset = "0x10")]
		private MonoTlsProvider tlsProvider;

		// Token: 0x04000BEA RID: 3050
		[Token(Token = "0x4000BEA")]
		[FieldOffset(Offset = "0x18")]
		private MonoTlsSettings tlsSettings;

		// Token: 0x04000BEB RID: 3051
		[Token(Token = "0x4000BEB")]
		[FieldOffset(Offset = "0x20")]
		private X509Certificate certificate;

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		[FieldOffset(Offset = "0x28")]
		private AuthenticationSchemes auth_schemes;

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x30")]
		private HttpListenerPrefixCollection prefixes;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x38")]
		private AuthenticationSchemeSelector auth_selector;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x40")]
		private string realm;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x48")]
		private bool ignore_write_exceptions;

		// Token: 0x04000BF1 RID: 3057
		[Token(Token = "0x4000BF1")]
		[FieldOffset(Offset = "0x49")]
		private bool listening;

		// Token: 0x04000BF2 RID: 3058
		[Token(Token = "0x4000BF2")]
		[FieldOffset(Offset = "0x4A")]
		private bool disposed;

		// Token: 0x04000BF3 RID: 3059
		[Token(Token = "0x4000BF3")]
		[FieldOffset(Offset = "0x50")]
		private readonly object _internalLock;

		// Token: 0x04000BF4 RID: 3060
		[Token(Token = "0x4000BF4")]
		[FieldOffset(Offset = "0x58")]
		private Hashtable registry;

		// Token: 0x04000BF5 RID: 3061
		[Token(Token = "0x4000BF5")]
		[FieldOffset(Offset = "0x60")]
		private ArrayList ctx_queue;

		// Token: 0x04000BF6 RID: 3062
		[Token(Token = "0x4000BF6")]
		[FieldOffset(Offset = "0x68")]
		private ArrayList wait_queue;

		// Token: 0x04000BF7 RID: 3063
		[Token(Token = "0x4000BF7")]
		[FieldOffset(Offset = "0x70")]
		private Hashtable connections;

		// Token: 0x04000BF8 RID: 3064
		[Token(Token = "0x4000BF8")]
		[FieldOffset(Offset = "0x78")]
		private ServiceNameStore defaultServiceNames;

		// Token: 0x04000BF9 RID: 3065
		[Token(Token = "0x4000BF9")]
		[FieldOffset(Offset = "0x80")]
		private ExtendedProtectionPolicy extendedProtectionPolicy;
	}
}
