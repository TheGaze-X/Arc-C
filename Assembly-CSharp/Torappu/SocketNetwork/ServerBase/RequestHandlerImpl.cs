using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014BE RID: 5310
	[Token(Token = "0x20014BE")]
	public abstract class RequestHandlerImpl<Request, Response> : RequestHandler where Request : Protocol, IRRPProtocol, new() where Response : Protocol, IRRPProtocol
	{
		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06007A7F RID: 31359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A7E RID: 31358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E9A")]
		public FillRequest<Request> onFillRequest
		{
			[Token(Token = "0x6007A7F")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6007A7E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06007A81 RID: 31361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007A80 RID: 31360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E9B")]
		public ProcResponse<Response> onResponse
		{
			[Token(Token = "0x6007A81")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6007A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A82")]
		protected virtual void OnProcStatus(Response resp)
		{
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A83")]
		private void _InvokeResponse(RRPRespCode code, Response dnProtocol)
		{
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A84")]
		public sealed override void ProcDnProtocol(RRPRespCode code, Protocol dnProtocol)
		{
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x00036CA8 File Offset: 0x00034EA8
		[Token(Token = "0x6007A85")]
		public sealed override bool FillUpProtocol(Protocol upProtocol)
		{
			return default(bool);
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007A86")]
		public sealed override Protocol GetUpProtocol(INetProtocolSuite protoSuit)
		{
			return null;
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A87")]
		protected RequestHandlerImpl()
		{
		}
	}
}
