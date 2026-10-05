using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000292 RID: 658
	[Token(Token = "0x2000292")]
	internal class FtpControlStream : CommandStream
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C4")]
		internal NetworkCredential Credentials
		{
			[Token(Token = "0x6001279")]
			[Address(RVA = "0x51A2D40", Offset = "0x51A1940", VA = "0x1851A2D40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600127A")]
			[Address(RVA = "0x51A2F20", Offset = "0x51A1B20", VA = "0x1851A2F20")]
			set
			{
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600127B")]
		[Address(RVA = "0x51A2B60", Offset = "0x51A1760", VA = "0x1851A2B60")]
		internal FtpControlStream(TcpClient client)
		{
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x519D560", Offset = "0x519C160", VA = "0x18519D560")]
		internal void AbortConnect()
		{
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x519D580", Offset = "0x519C180", VA = "0x18519D580")]
		private static void AcceptCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x519F1C0", Offset = "0x519DDC0", VA = "0x18519F1C0")]
		private static void ConnectCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x51A23D0", Offset = "0x51A0FD0", VA = "0x1851A23D0")]
		private static void SSLHandshakeCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x51A20A0", Offset = "0x51A0CA0", VA = "0x1851A20A0")]
		private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream)
		{
			return CommandStream.PipelineInstruction.Abort;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x519F0D0", Offset = "0x519DCD0", VA = "0x18519F0D0", Slot = "39")]
		protected override void ClearState()
		{
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x51A0970", Offset = "0x519F570", VA = "0x1851A0970", Slot = "41")]
		protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
		{
			return CommandStream.PipelineInstruction.Abort;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x519D920", Offset = "0x519C520", VA = "0x18519D920", Slot = "40")]
		protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req)
		{
			return null;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x51A1990", Offset = "0x51A0590", VA = "0x1851A1990")]
		private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady)
		{
			return CommandStream.PipelineInstruction.Abort;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x51A0030", Offset = "0x519EC30", VA = "0x1851A0030")]
		private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename)
		{
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x519F7A0", Offset = "0x519E3A0", VA = "0x18519F7A0")]
		private string FormatAddress(IPAddress address, int Port)
		{
			return null;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x519F660", Offset = "0x519E260", VA = "0x18519F660")]
		private string FormatAddressV6(IPAddress address, int port)
		{
			return null;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x170003C5")]
		internal long ContentLength
		{
			[Token(Token = "0x6001288")]
			[Address(RVA = "0x789430", Offset = "0x788030", VA = "0x180789430")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x170003C6")]
		internal DateTime LastModified
		{
			[Token(Token = "0x6001289")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C7")]
		internal Uri ResponseUri
		{
			[Token(Token = "0x600128A")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C8")]
		internal string BannerMessage
		{
			[Token(Token = "0x600128B")]
			[Address(RVA = "0x51A2CF0", Offset = "0x51A18F0", VA = "0x1851A2CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C9")]
		internal string WelcomeMessage
		{
			[Token(Token = "0x600128C")]
			[Address(RVA = "0x51A2ED0", Offset = "0x51A1AD0", VA = "0x1851A2ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CA")]
		internal string ExitMessage
		{
			[Token(Token = "0x600128D")]
			[Address(RVA = "0x51A2E80", Offset = "0x51A1A80", VA = "0x1851A2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x519FB50", Offset = "0x519E750", VA = "0x18519FB50")]
		private long GetContentLengthFrom213Response(string responseString)
		{
			return 0L;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x519FC90", Offset = "0x519E890", VA = "0x18519FC90")]
		private DateTime GetLastModifiedFrom213Response(string str)
		{
			return default(DateTime);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x51A2630", Offset = "0x51A1230", VA = "0x1851A2630")]
		private void TryUpdateResponseUri(string str, FtpWebRequest request)
		{
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001291")]
		[Address(RVA = "0x51A2540", Offset = "0x51A1140", VA = "0x1851A2540")]
		private void TryUpdateContentLength(string str)
		{
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001292")]
		[Address(RVA = "0x519FF90", Offset = "0x519EB90", VA = "0x18519FF90")]
		private string GetLoginDirectory(string str)
		{
			return null;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x51A0500", Offset = "0x519F100", VA = "0x1851A0500")]
		private int GetPortV4(string responseString)
		{
			return 0;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x51A06E0", Offset = "0x519F2E0", VA = "0x1851A06E0")]
		private int GetPortV6(string responseString)
		{
			return 0;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x519F380", Offset = "0x519DF80", VA = "0x18519F380")]
		private void CreateFtpListenerSocket(FtpWebRequest request)
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x51A0200", Offset = "0x519EE00", VA = "0x1851A0200")]
		private string GetPortCommandLine(FtpWebRequest request)
		{
			return null;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x519FA30", Offset = "0x519E630", VA = "0x18519FA30")]
		private string FormatFtpCommand(string command, string parameter)
		{
			return null;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x519F2F0", Offset = "0x519DEF0", VA = "0x18519F2F0")]
		protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket)
		{
			return null;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x519ECC0", Offset = "0x519D8C0", VA = "0x18519ECC0", Slot = "42")]
		protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
		{
			return default(bool);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x51A08F0", Offset = "0x519F4F0", VA = "0x1851A08F0")]
		private TriState IsFtpDataStreamWriteable()
		{
			return TriState.False;
		}

		// Token: 0x0400095D RID: 2397
		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x88")]
		private Socket _dataSocket;

		// Token: 0x0400095E RID: 2398
		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0x90")]
		private IPEndPoint _passiveEndPoint;

		// Token: 0x0400095F RID: 2399
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x98")]
		private TlsStream _tlsStream;

		// Token: 0x04000960 RID: 2400
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0xA0")]
		private StringBuilder _bannerMessage;

		// Token: 0x04000961 RID: 2401
		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0xA8")]
		private StringBuilder _welcomeMessage;

		// Token: 0x04000962 RID: 2402
		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0xB0")]
		private StringBuilder _exitMessage;

		// Token: 0x04000963 RID: 2403
		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0xB8")]
		private WeakReference _credentials;

		// Token: 0x04000964 RID: 2404
		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0xC0")]
		private string _currentTypeSetting;

		// Token: 0x04000965 RID: 2405
		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0xC8")]
		private long _contentLength;

		// Token: 0x04000966 RID: 2406
		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0xD0")]
		private DateTime _lastModified;

		// Token: 0x04000967 RID: 2407
		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0xD8")]
		private bool _dataHandshakeStarted;

		// Token: 0x04000968 RID: 2408
		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0xE0")]
		private string _loginDirectory;

		// Token: 0x04000969 RID: 2409
		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0xE8")]
		private string _establishedServerDirectory;

		// Token: 0x0400096A RID: 2410
		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0xF0")]
		private string _requestedServerDirectory;

		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0xF8")]
		private Uri _responseUri;

		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x100")]
		private FtpLoginState _loginState;

		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x104")]
		internal FtpStatusCode StatusCode;

		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x108")]
		internal string StatusLine;

		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AsyncCallback s_acceptCallbackDelegate;

		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x8")]
		private static readonly AsyncCallback s_connectCallbackDelegate;

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x10")]
		private static readonly AsyncCallback s_SSLHandshakeCallback;

		// Token: 0x02000293 RID: 659
		[Token(Token = "0x2000293")]
		private enum GetPathOption
		{
			// Token: 0x04000973 RID: 2419
			[Token(Token = "0x4000973")]
			Normal,
			// Token: 0x04000974 RID: 2420
			[Token(Token = "0x4000974")]
			AssumeFilename,
			// Token: 0x04000975 RID: 2421
			[Token(Token = "0x4000975")]
			AssumeNoFilename
		}
	}
}
