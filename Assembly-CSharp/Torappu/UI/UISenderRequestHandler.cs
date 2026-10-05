using System;
using Il2CppDummyDll;
using Torappu.Network;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003968 RID: 14696
	[Token(Token = "0x2003968")]
	public class UISenderRequestHandler<TResponse> : LoopRequestSender.IRequestSendHandler, IHotfixable where TResponse : class, new()
	{
		// Token: 0x06017376 RID: 95094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017376")]
		private UISenderRequestHandler()
		{
		}

		// Token: 0x06017377 RID: 95095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017377")]
		public static UISenderRequestHandler<TResponse> CreateSendHandler(UISenderRequestHandler<TResponse>.HandlerParam handlerParam)
		{
			return null;
		}

		// Token: 0x06017378 RID: 95096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017378")]
		public LoopRequestSender.RequestResult SendRequest()
		{
			return null;
		}

		// Token: 0x0401C061 RID: 114785
		[Token(Token = "0x401C061")]
		[FieldOffset(Offset = "0x0")]
		private UISenderRequestHandler<TResponse>.CreateRequestAction m_onCreateRequest;

		// Token: 0x0401C062 RID: 114786
		[Token(Token = "0x401C062")]
		[FieldOffset(Offset = "0x0")]
		private Func<TResponse, bool> m_onResponse;

		// Token: 0x0401C063 RID: 114787
		[Token(Token = "0x401C063")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C064 RID: 114788
		[Token(Token = "0x401C064")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateSendHandler;

		// Token: 0x0401C065 RID: 114789
		[Token(Token = "0x401C065")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x02003969 RID: 14697
		[Token(Token = "0x2003969")]
		public class HandlerParam
		{
			// Token: 0x06017379 RID: 95097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017379")]
			public HandlerParam()
			{
			}

			// Token: 0x0401C066 RID: 114790
			[Token(Token = "0x401C066")]
			[FieldOffset(Offset = "0x0")]
			public UISenderRequestHandler<TResponse>.CreateRequestAction onCreateRequest;

			// Token: 0x0401C067 RID: 114791
			[Token(Token = "0x401C067")]
			[FieldOffset(Offset = "0x0")]
			public Func<TResponse, bool> onResponse;
		}

		// Token: 0x0200396A RID: 14698
		// (Invoke) Token: 0x0601737B RID: 95099
		[Token(Token = "0x200396A")]
		public delegate bool CreateRequestAction(out Request request, out UISenderRequestParam requestParam);
	}
}
