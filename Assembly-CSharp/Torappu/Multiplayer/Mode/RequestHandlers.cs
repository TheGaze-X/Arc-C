using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer.Mode
{
	// Token: 0x020015CA RID: 5578
	[Token(Token = "0x20015CA")]
	public class RequestHandlers
	{
		// Token: 0x06007E72 RID: 32370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E72")]
		[Address(RVA = "0x284AFE0", Offset = "0x2849BE0", VA = "0x18284AFE0")]
		public RequestHandlers(int maxcnt)
		{
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E73")]
		[Address(RVA = "0x284AF50", Offset = "0x2849B50", VA = "0x18284AF50")]
		private void _SetHandler(RequestType req, RequestHandlers.RequestHandler handler)
		{
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E74")]
		public void SetHandler<T>(RequestType req, Func<T, bool> handler)
		{
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E75")]
		[Address(RVA = "0x284AD50", Offset = "0x2849950", VA = "0x18284AD50")]
		public void SetHandler(RequestType req, Func<bool> handler)
		{
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x00037B48 File Offset: 0x00035D48
		[Token(Token = "0x6007E76")]
		[Address(RVA = "0x284AC70", Offset = "0x2849870", VA = "0x18284AC70")]
		public bool Do(RequestType req, object param)
		{
			return default(bool);
		}

		// Token: 0x04008020 RID: 32800
		[Token(Token = "0x4008020")]
		[FieldOffset(Offset = "0x10")]
		private readonly RequestHandlers.RequestHandler[] m_handlers;

		// Token: 0x020015CB RID: 5579
		// (Invoke) Token: 0x06007E78 RID: 32376
		[Token(Token = "0x20015CB")]
		private delegate bool RequestHandler(object param);
	}
}
