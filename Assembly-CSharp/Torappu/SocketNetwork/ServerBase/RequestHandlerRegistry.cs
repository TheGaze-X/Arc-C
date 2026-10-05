using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014B8 RID: 5304
	[Token(Token = "0x20014B8")]
	public class RequestHandlerRegistry<RequestEnum> where RequestEnum : struct
	{
		// Token: 0x06007A6C RID: 31340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6C")]
		private void _SetHandler(RequestEnum req, RequestHandlerRegistry<RequestEnum>.IHandler handler)
		{
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6D")]
		public void SetHandler<T>(RequestEnum req, Func<T, bool> handler) where T : class
		{
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6E")]
		public void SetHandler(RequestEnum req, Func<bool> handler)
		{
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x00036C60 File Offset: 0x00034E60
		[Token(Token = "0x6007A6F")]
		public bool Do(RequestEnum req, object param)
		{
			return default(bool);
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A70")]
		public RequestHandlerRegistry()
		{
		}

		// Token: 0x04007882 RID: 30850
		[Token(Token = "0x4007882")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, RequestHandlerRegistry<RequestEnum>.IHandler> m_handlers;

		// Token: 0x020014B9 RID: 5305
		[Token(Token = "0x20014B9")]
		private interface IHandler
		{
			// Token: 0x06007A71 RID: 31345
			[Token(Token = "0x6007A71")]
			bool Do(object param);
		}

		// Token: 0x020014BA RID: 5306
		[Token(Token = "0x20014BA")]
		private struct Handler : RequestHandlerRegistry<RequestEnum>.IHandler
		{
			// Token: 0x06007A72 RID: 31346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A72")]
			public Handler(Func<bool> handler)
			{
			}

			// Token: 0x06007A73 RID: 31347 RVA: 0x00036C78 File Offset: 0x00034E78
			[Token(Token = "0x6007A73")]
			public bool Do(object param)
			{
				return default(bool);
			}

			// Token: 0x04007883 RID: 30851
			[Token(Token = "0x4007883")]
			[FieldOffset(Offset = "0x0")]
			private Func<bool> m_handler;
		}

		// Token: 0x020014BB RID: 5307
		[Token(Token = "0x20014BB")]
		private struct HandlerWithParam<T> : RequestHandlerRegistry<RequestEnum>.IHandler where T : class
		{
			// Token: 0x06007A74 RID: 31348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A74")]
			public HandlerWithParam(Func<T, bool> handler)
			{
			}

			// Token: 0x06007A75 RID: 31349 RVA: 0x00036C90 File Offset: 0x00034E90
			[Token(Token = "0x6007A75")]
			public bool Do(object param)
			{
				return default(bool);
			}

			// Token: 0x04007884 RID: 30852
			[Token(Token = "0x4007884")]
			[FieldOffset(Offset = "0x0")]
			private Func<T, bool> m_handler;
		}
	}
}
