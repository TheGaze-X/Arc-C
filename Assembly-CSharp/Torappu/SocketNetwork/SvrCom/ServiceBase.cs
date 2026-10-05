using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014B0 RID: 5296
	[Token(Token = "0x20014B0")]
	public abstract class ServiceBase<TService, TEvent> : ServiceCoreBase<TService> where TService : ServiceBase<TService, TEvent> where TEvent : struct
	{
		// Token: 0x06007A3F RID: 31295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3F")]
		public static void RegisterListener(TEvent evt, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A40")]
		public static void CancelListener(TEvent evt, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A41")]
		protected ServiceBase()
		{
		}

		// Token: 0x04007859 RID: 30809
		[Token(Token = "0x4007859")]
		[FieldOffset(Offset = "0x0")]
		protected EventPool<TEvent> m_eventPool;

		// Token: 0x0400785A RID: 30810
		[Token(Token = "0x400785A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterListener;

		// Token: 0x0400785B RID: 30811
		[Token(Token = "0x400785B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CancelListener;

		// Token: 0x0400785C RID: 30812
		[Token(Token = "0x400785C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
