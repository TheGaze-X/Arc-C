using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	public abstract class AbstractTlsServer : AbstractTlsPeer, TlsServer, TlsPeer
	{
		// Token: 0x060013EA RID: 5098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EA")]
		[Address(RVA = "0x5240E20", Offset = "0x523FA20", VA = "0x185240E20")]
		public AbstractTlsServer()
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public AbstractTlsServer(TlsCipherFactory cipherFactory)
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x170002C5")]
		protected virtual bool AllowEncryptThenMac
		{
			[Token(Token = "0x60013EC")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x170002C6")]
		protected virtual bool AllowTruncatedHMac
		{
			[Token(Token = "0x60013ED")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x523FEE0", Offset = "0x523EAE0", VA = "0x18523FEE0", Slot = "38")]
		protected virtual IDictionary CheckServerExtensions()
		{
			return null;
		}

		// Token: 0x060013EF RID: 5103
		[Token(Token = "0x60013EF")]
		protected abstract int[] GetCipherSuites();

		// Token: 0x060013F0 RID: 5104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x523FFC0", Offset = "0x523EBC0", VA = "0x18523FFC0")]
		protected byte[] GetCompressionMethods()
		{
			return null;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C7")]
		protected virtual ProtocolVersion MaximumVersion
		{
			[Token(Token = "0x60013F1")]
			[Address(RVA = "0x5240E90", Offset = "0x523FA90", VA = "0x185240E90", Slot = "40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C8")]
		protected virtual ProtocolVersion MinimumVersion
		{
			[Token(Token = "0x60013F2")]
			[Address(RVA = "0x5240EE0", Offset = "0x523FAE0", VA = "0x185240EE0", Slot = "41")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x5240CE0", Offset = "0x523F8E0", VA = "0x185240CE0", Slot = "42")]
		protected virtual bool SupportsClientEccCapabilities(int[] namedCurves, byte[] ecPointFormats)
		{
			return default(bool);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "43")]
		public virtual void Init(TlsServerContext context)
		{
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F5")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "44")]
		public virtual void NotifyClientVersion(ProtocolVersion clientVersion)
		{
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x5240870", Offset = "0x523F470", VA = "0x185240870", Slot = "45")]
		public virtual void NotifyFallback(bool isFallback)
		{
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x5240950", Offset = "0x523F550", VA = "0x185240950", Slot = "46")]
		public virtual void NotifyOfferedCipherSuites(int[] offeredCipherSuites)
		{
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30", Slot = "47")]
		public virtual void NotifyOfferedCompressionMethods(byte[] offeredCompressionMethods)
		{
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x5240A40", Offset = "0x523F640", VA = "0x185240A40", Slot = "48")]
		public virtual void ProcessClientExtensions(IDictionary clientExtensions)
		{
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x5240650", Offset = "0x523F250", VA = "0x185240650", Slot = "49")]
		public virtual ProtocolVersion GetServerVersion()
		{
			return null;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x60013FB")]
		[Address(RVA = "0x5240150", Offset = "0x523ED50", VA = "0x185240150", Slot = "50")]
		public virtual int GetSelectedCipherSuite()
		{
			return 0;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x5240300", Offset = "0x523EF00", VA = "0x185240300", Slot = "51")]
		public virtual byte GetSelectedCompressionMethod()
		{
			return 0;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x52403F0", Offset = "0x523EFF0", VA = "0x1852403F0", Slot = "52")]
		public virtual IDictionary GetServerExtensions()
		{
			return null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "53")]
		public virtual IList GetServerSupplementalData()
		{
			return null;
		}

		// Token: 0x060013FF RID: 5119
		[Token(Token = "0x60013FF")]
		public abstract TlsCredentials GetCredentials();

		// Token: 0x06001400 RID: 5120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001400")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "55")]
		public virtual CertificateStatus GetCertificateStatus()
		{
			return null;
		}

		// Token: 0x06001401 RID: 5121
		[Token(Token = "0x6001401")]
		public abstract TlsKeyExchange GetKeyExchange();

		// Token: 0x06001402 RID: 5122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001402")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "57")]
		public virtual CertificateRequest GetCertificateRequest()
		{
			return null;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x5240C80", Offset = "0x523F880", VA = "0x185240C80", Slot = "58")]
		public virtual void ProcessClientSupplementalData(IList clientSupplementalData)
		{
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001404")]
		[Address(RVA = "0x5240820", Offset = "0x523F420", VA = "0x185240820", Slot = "59")]
		public virtual void NotifyClientCertificate(Certificate clientCertificate)
		{
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x5240000", Offset = "0x523EC00", VA = "0x185240000", Slot = "13")]
		public override TlsCompression GetCompression()
		{
			return null;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x523FF20", Offset = "0x523EB20", VA = "0x18523FF20", Slot = "14")]
		public override TlsCipher GetCipher()
		{
			return null;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x52400A0", Offset = "0x523ECA0", VA = "0x1852400A0", Slot = "60")]
		public virtual NewSessionTicket GetNewSessionTicket()
		{
			return null;
		}

		// Token: 0x04000979 RID: 2425
		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x10")]
		protected TlsCipherFactory mCipherFactory;

		// Token: 0x0400097A RID: 2426
		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x18")]
		protected TlsServerContext mContext;

		// Token: 0x0400097B RID: 2427
		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x20")]
		protected ProtocolVersion mClientVersion;

		// Token: 0x0400097C RID: 2428
		[Token(Token = "0x400097C")]
		[FieldOffset(Offset = "0x28")]
		protected int[] mOfferedCipherSuites;

		// Token: 0x0400097D RID: 2429
		[Token(Token = "0x400097D")]
		[FieldOffset(Offset = "0x30")]
		protected byte[] mOfferedCompressionMethods;

		// Token: 0x0400097E RID: 2430
		[Token(Token = "0x400097E")]
		[FieldOffset(Offset = "0x38")]
		protected IDictionary mClientExtensions;

		// Token: 0x0400097F RID: 2431
		[Token(Token = "0x400097F")]
		[FieldOffset(Offset = "0x40")]
		protected bool mEncryptThenMacOffered;

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x42")]
		protected short mMaxFragmentLengthOffered;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x44")]
		protected bool mTruncatedHMacOffered;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x48")]
		protected IList mSupportedSignatureAlgorithms;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x50")]
		protected bool mEccCipherSuitesOffered;

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[FieldOffset(Offset = "0x58")]
		protected int[] mNamedCurves;

		// Token: 0x04000985 RID: 2437
		[Token(Token = "0x4000985")]
		[FieldOffset(Offset = "0x60")]
		protected byte[] mClientECPointFormats;

		// Token: 0x04000986 RID: 2438
		[Token(Token = "0x4000986")]
		[FieldOffset(Offset = "0x68")]
		protected byte[] mServerECPointFormats;

		// Token: 0x04000987 RID: 2439
		[Token(Token = "0x4000987")]
		[FieldOffset(Offset = "0x70")]
		protected ProtocolVersion mServerVersion;

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x78")]
		protected int mSelectedCipherSuite;

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x7C")]
		protected byte mSelectedCompressionMethod;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x80")]
		protected IDictionary mServerExtensions;
	}
}
