using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000234 RID: 564
	[Token(Token = "0x2000234")]
	public abstract class AbstractTlsClient : AbstractTlsPeer, TlsClient, TlsPeer
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B6")]
		public List<string> HostNames
		{
			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60013A3")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x523EFE0", Offset = "0x523DBE0", VA = "0x18523EFE0")]
		public AbstractTlsClient()
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public AbstractTlsClient(TlsCipherFactory cipherFactory)
		{
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x523E3D0", Offset = "0x523CFD0", VA = "0x18523E3D0", Slot = "38")]
		protected virtual bool AllowUnexpectedServerExtension(int extensionType, byte[] extensionData)
		{
			return default(bool);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x523E440", Offset = "0x523D040", VA = "0x18523E440", Slot = "39")]
		protected virtual void CheckForUnexpectedServerExtension(IDictionary serverExtensions, int extensionType)
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "40")]
		public virtual void Init(TlsClientContext context)
		{
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "41")]
		public virtual TlsSession GetSessionToResume()
		{
			return null;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B7")]
		public virtual ProtocolVersion ClientHelloRecordLayerVersion
		{
			[Token(Token = "0x60013AA")]
			[Address(RVA = "0x523F050", Offset = "0x523DC50", VA = "0x18523F050", Slot = "42")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B8")]
		public virtual ProtocolVersion ClientVersion
		{
			[Token(Token = "0x60013AB")]
			[Address(RVA = "0x523F090", Offset = "0x523DC90", VA = "0x18523F090", Slot = "43")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x170002B9")]
		public virtual bool IsFallback
		{
			[Token(Token = "0x60013AC")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x523E5D0", Offset = "0x523D1D0", VA = "0x18523E5D0", Slot = "45")]
		public virtual IDictionary GetClientExtensions()
		{
			return null;
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BA")]
		public virtual ProtocolVersion MinimumVersion
		{
			[Token(Token = "0x60013AE")]
			[Address(RVA = "0x523F0E0", Offset = "0x523DCE0", VA = "0x18523F0E0", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x523ED30", Offset = "0x523D930", VA = "0x18523ED30", Slot = "47")]
		public virtual void NotifyServerVersion(ProtocolVersion serverVersion)
		{
		}

		// Token: 0x060013B0 RID: 5040
		[Token(Token = "0x60013B0")]
		public abstract int[] GetCipherSuites();

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x523EB30", Offset = "0x523D730", VA = "0x18523EB30", Slot = "49")]
		public virtual byte[] GetCompressionMethods()
		{
			return null;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "50")]
		public virtual void NotifySessionID(byte[] sessionID)
		{
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780", Slot = "51")]
		public virtual void NotifySelectedCipherSuite(int selectedCipherSuite)
		{
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x523ED20", Offset = "0x523D920", VA = "0x18523ED20", Slot = "52")]
		public virtual void NotifySelectedCompressionMethod(byte selectedCompressionMethod)
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x523EE10", Offset = "0x523DA10", VA = "0x18523EE10", Slot = "53")]
		public virtual void ProcessServerExtensions(IDictionary serverExtensions)
		{
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x523EF80", Offset = "0x523DB80", VA = "0x18523EF80", Slot = "54")]
		public virtual void ProcessServerSupplementalData(IList serverSupplementalData)
		{
		}

		// Token: 0x060013B7 RID: 5047
		[Token(Token = "0x60013B7")]
		public abstract TlsKeyExchange GetKeyExchange();

		// Token: 0x060013B8 RID: 5048
		[Token(Token = "0x60013B8")]
		public abstract TlsAuthentication GetAuthentication();

		// Token: 0x060013B9 RID: 5049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "57")]
		public virtual IList GetClientSupplementalData()
		{
			return null;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x523EB70", Offset = "0x523D770", VA = "0x18523EB70", Slot = "13")]
		public override TlsCompression GetCompression()
		{
			return null;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x523E530", Offset = "0x523D130", VA = "0x18523E530", Slot = "14")]
		public override TlsCipher GetCipher()
		{
			return null;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "58")]
		public virtual void NotifyNewSessionTicket(NewSessionTicket newSessionTicket)
		{
		}

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x10")]
		protected TlsCipherFactory mCipherFactory;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x18")]
		protected TlsClientContext mContext;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0x20")]
		protected IList mSupportedSignatureAlgorithms;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x28")]
		protected int[] mNamedCurves;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x30")]
		protected byte[] mClientECPointFormats;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x38")]
		protected byte[] mServerECPointFormats;

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0x40")]
		protected int mSelectedCipherSuite;

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x44")]
		protected short mSelectedCompressionMethod;
	}
}
