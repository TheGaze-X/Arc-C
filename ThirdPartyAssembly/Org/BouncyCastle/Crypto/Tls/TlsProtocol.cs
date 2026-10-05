using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	public abstract class TlsProtocol
	{
		// Token: 0x06001683 RID: 5763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x52726A0", Offset = "0x52712A0", VA = "0x1852726A0")]
		public TlsProtocol(Stream stream, SecureRandom secureRandom)
		{
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x5272800", Offset = "0x5271400", VA = "0x185272800")]
		public TlsProtocol(Stream input, Stream output, SecureRandom secureRandom)
		{
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x52724A0", Offset = "0x52710A0", VA = "0x1852724A0")]
		public TlsProtocol(SecureRandom secureRandom)
		{
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001686 RID: 5766
		[Token(Token = "0x17000322")]
		protected abstract TlsContext Context { [Token(Token = "0x6001686")] get; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001687 RID: 5767
		[Token(Token = "0x17000323")]
		internal abstract AbstractTlsContext ContextAdmin { [Token(Token = "0x6001687")] get; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001688 RID: 5768
		[Token(Token = "0x17000324")]
		protected abstract TlsPeer Peer { [Token(Token = "0x6001688")] get; }

		// Token: 0x06001689 RID: 5769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void HandleChangeCipherSpecMessage()
		{
		}

		// Token: 0x0600168A RID: 5770
		[Token(Token = "0x600168A")]
		protected abstract void HandleHandshakeMessage(byte type, byte[] buf);

		// Token: 0x0600168B RID: 5771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected virtual void HandleWarningMessage(byte description)
		{
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x526D560", Offset = "0x526C160", VA = "0x18526D560", Slot = "10")]
		protected virtual void ApplyMaxFragmentLengthExtension()
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x526D760", Offset = "0x526C360", VA = "0x18526D760", Slot = "11")]
		protected virtual void CheckReceivedChangeCipherSpec(bool expected)
		{
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x526D7C0", Offset = "0x526C3C0", VA = "0x18526D7C0", Slot = "12")]
		protected virtual void CleanupHandshake()
		{
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x526D700", Offset = "0x526C300", VA = "0x18526D700", Slot = "13")]
		protected virtual void BlockForHandshake()
		{
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001690")]
		[Address(RVA = "0x526D8E0", Offset = "0x526C4E0", VA = "0x18526D8E0", Slot = "14")]
		protected virtual void CompleteHandshake()
		{
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001691")]
		[Address(RVA = "0x526FCF0", Offset = "0x526E8F0", VA = "0x18526FCF0")]
		protected internal void ProcessRecord(byte protocol, byte[] buf, int offset, int len)
		{
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001692")]
		[Address(RVA = "0x526F8F0", Offset = "0x526E4F0", VA = "0x18526F8F0")]
		private void ProcessHandshake()
		{
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001693")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void ProcessApplicationData()
		{
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x526F390", Offset = "0x526DF90", VA = "0x18526F390")]
		private void ProcessAlert()
		{
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001695")]
		[Address(RVA = "0x526F610", Offset = "0x526E210", VA = "0x18526F610")]
		private void ProcessChangeCipherSpec(byte[] buf, int off, int len)
		{
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x2704800", Offset = "0x2703400", VA = "0x182704800", Slot = "15")]
		protected internal virtual int ApplicationDataAvailable()
		{
			return 0;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x5270230", Offset = "0x526EE30", VA = "0x185270230", Slot = "16")]
		protected internal virtual int ReadApplicationData(byte[] buf, int offset, int len)
		{
			return 0;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001698")]
		[Address(RVA = "0x5270CF0", Offset = "0x526F8F0", VA = "0x185270CF0", Slot = "17")]
		protected virtual void SafeReadRecord()
		{
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001699")]
		[Address(RVA = "0x5270E70", Offset = "0x526FA70", VA = "0x185270E70", Slot = "18")]
		protected virtual void SafeWriteRecord(byte type, byte[] buf, int offset, int len)
		{
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169A")]
		[Address(RVA = "0x5271590", Offset = "0x5270190", VA = "0x185271590", Slot = "19")]
		protected internal virtual void WriteData(byte[] buf, int offset, int len)
		{
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169B")]
		[Address(RVA = "0x52714E0", Offset = "0x52700E0", VA = "0x1852714E0", Slot = "20")]
		protected virtual void SetAppDataSplitMode(int appDataSplitMode)
		{
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169C")]
		[Address(RVA = "0x5271920", Offset = "0x5270520", VA = "0x185271920", Slot = "21")]
		protected virtual void WriteHandshakeMessage(byte[] buf, int off, int len)
		{
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000325")]
		public virtual Stream Stream
		{
			[Token(Token = "0x600169D")]
			[Address(RVA = "0x5272990", Offset = "0x5271590", VA = "0x185272990", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600169E")]
		[Address(RVA = "0x526F000", Offset = "0x526DC00", VA = "0x18526F000", Slot = "23")]
		public virtual void OfferInput(byte[] input)
		{
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x600169F")]
		[Address(RVA = "0x526E980", Offset = "0x526D580", VA = "0x18526E980", Slot = "24")]
		public virtual int GetAvailableInputBytes()
		{
			return 0;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x60016A0")]
		[Address(RVA = "0x5270690", Offset = "0x526F290", VA = "0x185270690", Slot = "25")]
		public virtual int ReadInput(byte[] buffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A1")]
		[Address(RVA = "0x526F270", Offset = "0x526DE70", VA = "0x18526F270", Slot = "26")]
		public virtual void OfferOutput(byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x526EA10", Offset = "0x526D610", VA = "0x18526EA10", Slot = "27")]
		public virtual int GetAvailableOutputBytes()
		{
			return 0;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x52707B0", Offset = "0x526F3B0", VA = "0x1852707B0", Slot = "28")]
		public virtual int ReadOutput(byte[] buffer, int offset, int length)
		{
			return 0;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x526E730", Offset = "0x526D330", VA = "0x18526E730", Slot = "29")]
		protected virtual void FailWithError(byte alertLevel, byte alertDescription, string message, Exception cause)
		{
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x526EF70", Offset = "0x526DB70", VA = "0x18526EF70", Slot = "30")]
		protected virtual void InvalidateSession()
		{
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x526F7B0", Offset = "0x526E3B0", VA = "0x18526F7B0", Slot = "31")]
		protected virtual void ProcessFinishedMessage(MemoryStream buf)
		{
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x526FFF0", Offset = "0x526EBF0", VA = "0x18526FFF0", Slot = "32")]
		protected virtual void RaiseAlert(byte alertLevel, byte alertDescription, string message, Exception cause)
		{
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A8")]
		[Address(RVA = "0x52701C0", Offset = "0x526EDC0", VA = "0x1852701C0", Slot = "33")]
		protected virtual void RaiseWarning(byte alertDescription, string message)
		{
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x5270FE0", Offset = "0x526FBE0", VA = "0x185270FE0", Slot = "34")]
		protected virtual void SendCertificateMessage(Certificate certificate)
		{
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x5271200", Offset = "0x526FE00", VA = "0x185271200", Slot = "35")]
		protected virtual void SendChangeCipherSpecMessage()
		{
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x52712E0", Offset = "0x526FEE0", VA = "0x1852712E0", Slot = "36")]
		protected virtual void SendFinishedMessage()
		{
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AC")]
		[Address(RVA = "0x5271430", Offset = "0x5270030", VA = "0x185271430", Slot = "37")]
		protected virtual void SendSupplementalDataMessage(IList supplementalData)
		{
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AD")]
		[Address(RVA = "0x526E220", Offset = "0x526CE20", VA = "0x18526E220", Slot = "38")]
		protected virtual byte[] CreateVerifyData(bool isServer)
		{
			return null;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x526D8A0", Offset = "0x526C4A0", VA = "0x18526D8A0", Slot = "39")]
		public virtual void Close()
		{
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x526EEA0", Offset = "0x526DAA0", VA = "0x18526EEA0", Slot = "40")]
		protected virtual void HandleClose(bool user_canceled)
		{
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x526E940", Offset = "0x526D540", VA = "0x18526E940", Slot = "41")]
		protected internal virtual void Flush()
		{
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x17000326")]
		public virtual bool IsClosed
		{
			[Token(Token = "0x60016B1")]
			[Address(RVA = "0x5272970", Offset = "0x5271570", VA = "0x185272970", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x526FC30", Offset = "0x526E830", VA = "0x18526FC30", Slot = "43")]
		protected virtual short ProcessMaxFragmentLengthExtension(IDictionary clientExtensions, IDictionary serverExtensions, byte alertDescription)
		{
			return 0;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x5270BB0", Offset = "0x526F7B0", VA = "0x185270BB0", Slot = "44")]
		protected virtual void RefuseRenegotiation()
		{
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x526D630", Offset = "0x526C230", VA = "0x18526D630")]
		protected internal static void AssertEmpty(MemoryStream buf)
		{
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x526DFA0", Offset = "0x526CBA0", VA = "0x18526DFA0")]
		protected internal static byte[] CreateRandomBlock(bool useGmtUnixTime, IRandomGenerator randomGenerator)
		{
			return null;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x526E180", Offset = "0x526CD80", VA = "0x18526E180")]
		protected internal static byte[] CreateRenegotiationInfo(byte[] renegotiated_connection)
		{
			return null;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x526E5F0", Offset = "0x526D1F0", VA = "0x18526E5F0")]
		protected internal static void EstablishMasterSecret(TlsContext context, TlsKeyExchange keyExchange)
		{
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x526EAB0", Offset = "0x526D6B0", VA = "0x18526EAB0")]
		protected internal static byte[] GetCurrentPrfHash(TlsContext context, TlsHandshakeHash handshakeHash, byte[] sslSender)
		{
			return null;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x52703C0", Offset = "0x526EFC0", VA = "0x1852703C0")]
		protected internal static IDictionary ReadExtensions(MemoryStream input)
		{
			return null;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x5270850", Offset = "0x526F450", VA = "0x185270850")]
		protected internal static IList ReadSupplementalDataMessage(MemoryStream input)
		{
			return null;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x5271810", Offset = "0x5270410", VA = "0x185271810")]
		protected internal static void WriteExtensions(Stream output, IDictionary extensions)
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x5271A30", Offset = "0x5270630", VA = "0x185271A30")]
		protected internal static void WriteSelectedExtensions(Stream output, IDictionary extensions, bool selectEmpty)
		{
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x5271EC0", Offset = "0x5270AC0", VA = "0x185271EC0")]
		protected internal static void WriteSupplementalData(Stream output, IList supplementalData)
		{
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x526EC00", Offset = "0x526D800", VA = "0x18526EC00")]
		protected internal static int GetPrfAlgorithm(TlsContext context, int ciphersuite)
		{
			return 0;
		}

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string TLS_ERROR_MESSAGE;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		protected const short CS_START = 0;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		protected const short CS_CLIENT_HELLO = 1;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		protected const short CS_SERVER_HELLO = 2;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		protected const short CS_SERVER_SUPPLEMENTAL_DATA = 3;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		protected const short CS_SERVER_CERTIFICATE = 4;

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		protected const short CS_CERTIFICATE_STATUS = 5;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		protected const short CS_SERVER_KEY_EXCHANGE = 6;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		protected const short CS_CERTIFICATE_REQUEST = 7;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		protected const short CS_SERVER_HELLO_DONE = 8;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		protected const short CS_CLIENT_SUPPLEMENTAL_DATA = 9;

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		protected const short CS_CLIENT_CERTIFICATE = 10;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		protected const short CS_CLIENT_KEY_EXCHANGE = 11;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		protected const short CS_CERTIFICATE_VERIFY = 12;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		protected const short CS_CLIENT_FINISHED = 13;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		protected const short CS_SERVER_SESSION_TICKET = 14;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		protected const short CS_SERVER_FINISHED = 15;

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		protected const short CS_END = 16;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		protected const short ADS_MODE_1_Nsub1 = 0;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		protected const short ADS_MODE_0_N = 1;

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		protected const short ADS_MODE_0_N_FIRSTONLY = 2;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x10")]
		private ByteQueue mApplicationDataQueue;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x18")]
		private ByteQueue mAlertQueue;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x20")]
		private ByteQueue mHandshakeQueue;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x28")]
		internal RecordStream mRecordStream;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x30")]
		protected SecureRandom mSecureRandom;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x38")]
		private TlsStream mTlsStream;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x40")]
		private bool mClosed;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x41")]
		private bool mFailedWithError;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x42")]
		private bool mAppDataReady;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x43")]
		private bool mAppDataSplitEnabled;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x44")]
		private int mAppDataSplitMode;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x48")]
		private byte[] mExpectedVerifyData;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x50")]
		protected TlsSession mTlsSession;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x58")]
		protected SessionParameters mSessionParameters;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x60")]
		protected SecurityParameters mSecurityParameters;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x68")]
		protected Certificate mPeerCertificate;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x70")]
		protected int[] mOfferedCipherSuites;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x78")]
		protected byte[] mOfferedCompressionMethods;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x80")]
		protected IDictionary mClientExtensions;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x88")]
		protected IDictionary mServerExtensions;

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x90")]
		protected short mConnectionState;

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x92")]
		protected bool mResumedSession;

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0x93")]
		protected bool mReceivedChangeCipherSpec;

		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		[FieldOffset(Offset = "0x94")]
		protected bool mSecureRenegotiation;

		// Token: 0x04000C6E RID: 3182
		[Token(Token = "0x4000C6E")]
		[FieldOffset(Offset = "0x95")]
		protected bool mAllowCertificateStatus;

		// Token: 0x04000C6F RID: 3183
		[Token(Token = "0x4000C6F")]
		[FieldOffset(Offset = "0x96")]
		protected bool mExpectSessionTicket;

		// Token: 0x04000C70 RID: 3184
		[Token(Token = "0x4000C70")]
		[FieldOffset(Offset = "0x97")]
		protected bool mBlocking;

		// Token: 0x04000C71 RID: 3185
		[Token(Token = "0x4000C71")]
		[FieldOffset(Offset = "0x98")]
		protected ByteQueueStream mInputBuffers;

		// Token: 0x04000C72 RID: 3186
		[Token(Token = "0x4000C72")]
		[FieldOffset(Offset = "0xA0")]
		protected ByteQueueStream mOutputBuffer;

		// Token: 0x020002A0 RID: 672
		[Token(Token = "0x20002A0")]
		internal class HandshakeMessage : MemoryStream
		{
			// Token: 0x060016C0 RID: 5824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016C0")]
			[Address(RVA = "0x52671E0", Offset = "0x5265DE0", VA = "0x1852671E0")]
			internal HandshakeMessage(byte handshakeType)
			{
			}

			// Token: 0x060016C1 RID: 5825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016C1")]
			[Address(RVA = "0x52671F0", Offset = "0x5265DF0", VA = "0x1852671F0")]
			internal HandshakeMessage(byte handshakeType, int length)
			{
			}

			// Token: 0x060016C2 RID: 5826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016C2")]
			[Address(RVA = "0x5267170", Offset = "0x5265D70", VA = "0x185267170")]
			internal void Write(byte[] data)
			{
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60016C3")]
			[Address(RVA = "0x5266EF0", Offset = "0x5265AF0", VA = "0x185266EF0")]
			internal void WriteToRecordStream(TlsProtocol protocol)
			{
			}
		}
	}
}
