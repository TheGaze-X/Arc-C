using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	internal class CommandStream : NetworkStreamWrapper
	{
		// Token: 0x06001256 RID: 4694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001256")]
		[Address(RVA = "0x519B3E0", Offset = "0x5199FE0", VA = "0x18519B3E0")]
		internal CommandStream(TcpClient client)
		{
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x5199610", Offset = "0x5198210", VA = "0x185199610", Slot = "38")]
		internal virtual void Abort(Exception e)
		{
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x5199D70", Offset = "0x5198970", VA = "0x185199D70", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x519A050", Offset = "0x5198C50", VA = "0x18519A050")]
		protected void InvokeRequestCallback(object obj)
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x170003BD")]
		internal bool RecoverableFailure
		{
			[Token(Token = "0x600125A")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x519A0E0", Offset = "0x5198CE0", VA = "0x18519A0E0")]
		protected void MarkAsRecoverableFailure()
		{
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125C")]
		[Address(RVA = "0x519B070", Offset = "0x5199C70", VA = "0x18519B070")]
		internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect)
		{
			return null;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600125D")]
		[Address(RVA = "0x5199870", Offset = "0x5198470", VA = "0x185199870", Slot = "39")]
		protected virtual void ClearState()
		{
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "40")]
		protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request)
		{
			return null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x5199F00", Offset = "0x5198B00", VA = "0x185199F00")]
		protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException)
		{
			return null;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x5199E50", Offset = "0x5198A50", VA = "0x185199E50")]
		protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException)
		{
			return null;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x5199F90", Offset = "0x5198B90", VA = "0x185199F90")]
		protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync)
		{
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x5199830", Offset = "0x5198430", VA = "0x185199830")]
		internal void CheckContinuePipeline()
		{
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x5199890", Offset = "0x5198490", VA = "0x185199890")]
		protected Stream ContinueCommandPipeline()
		{
			return null;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x6001264")]
		[Address(RVA = "0x519A330", Offset = "0x5198F30", VA = "0x18519A330")]
		private bool PostSendCommandProcessing(ref Stream stream)
		{
			return default(bool);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x519A0F0", Offset = "0x5198CF0", VA = "0x18519A0F0")]
		private bool PostReadCommandProcessing(ref Stream stream)
		{
			return default(bool);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "41")]
		protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
		{
			return CommandStream.PipelineInstruction.Abort;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x519A430", Offset = "0x5199030", VA = "0x18519A430")]
		private static void ReadCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x519B130", Offset = "0x5199D30", VA = "0x18519B130")]
		private static void WriteCallback(IAsyncResult asyncResult)
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BE")]
		protected Encoding Encoding
		{
			[Token(Token = "0x6001269")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x519B510", Offset = "0x519A110", VA = "0x18519B510")]
			set
			{
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "42")]
		protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
		{
			return default(bool);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x519AD50", Offset = "0x5199950", VA = "0x18519AD50")]
		private ResponseDescription ReceiveCommandResponse()
		{
			return null;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x519A660", Offset = "0x5199260", VA = "0x18519A660")]
		private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead)
		{
		}

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x0")]
		private static readonly AsyncCallback s_writeCallbackDelegate;

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x8")]
		private static readonly AsyncCallback s_readCallbackDelegate;

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x38")]
		private bool _recoverableFailure;

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x40")]
		protected WebRequest _request;

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x48")]
		protected bool _isAsync;

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x49")]
		private bool _aborted;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x50")]
		protected CommandStream.PipelineEntry[] _commands;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0x58")]
		protected int _index;

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x5C")]
		private bool _doRead;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x5D")]
		private bool _doSend;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x60")]
		private ResponseDescription _currentResponseDescription;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x68")]
		protected string _abortReason;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x70")]
		private string _buffer;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x78")]
		private Encoding _encoding;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x80")]
		private Decoder _decoder;

		// Token: 0x0200028C RID: 652
		[Token(Token = "0x200028C")]
		internal enum PipelineInstruction
		{
			// Token: 0x04000943 RID: 2371
			[Token(Token = "0x4000943")]
			Abort,
			// Token: 0x04000944 RID: 2372
			[Token(Token = "0x4000944")]
			Advance,
			// Token: 0x04000945 RID: 2373
			[Token(Token = "0x4000945")]
			Pause,
			// Token: 0x04000946 RID: 2374
			[Token(Token = "0x4000946")]
			Reread,
			// Token: 0x04000947 RID: 2375
			[Token(Token = "0x4000947")]
			GiveStream
		}

		// Token: 0x0200028D RID: 653
		[Token(Token = "0x200028D")]
		[Flags]
		internal enum PipelineEntryFlags
		{
			// Token: 0x04000949 RID: 2377
			[Token(Token = "0x4000949")]
			UserCommand = 1,
			// Token: 0x0400094A RID: 2378
			[Token(Token = "0x400094A")]
			GiveDataStream = 2,
			// Token: 0x0400094B RID: 2379
			[Token(Token = "0x400094B")]
			CreateDataConnection = 4,
			// Token: 0x0400094C RID: 2380
			[Token(Token = "0x400094C")]
			DontLogParameter = 8
		}

		// Token: 0x0200028E RID: 654
		[Token(Token = "0x200028E")]
		internal class PipelineEntry
		{
			// Token: 0x0600126F RID: 4719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600126F")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal PipelineEntry(string command)
			{
			}

			// Token: 0x06001270 RID: 4720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001270")]
			[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
			internal PipelineEntry(string command, CommandStream.PipelineEntryFlags flags)
			{
			}

			// Token: 0x06001271 RID: 4721 RVA: 0x00008F28 File Offset: 0x00007128
			[Token(Token = "0x6001271")]
			[Address(RVA = "0x51B4950", Offset = "0x51B3550", VA = "0x1851B4950")]
			internal bool HasFlag(CommandStream.PipelineEntryFlags flags)
			{
				return default(bool);
			}

			// Token: 0x0400094D RID: 2381
			[Token(Token = "0x400094D")]
			[FieldOffset(Offset = "0x10")]
			internal string Command;

			// Token: 0x0400094E RID: 2382
			[Token(Token = "0x400094E")]
			[FieldOffset(Offset = "0x18")]
			internal CommandStream.PipelineEntryFlags Flags;
		}
	}
}
