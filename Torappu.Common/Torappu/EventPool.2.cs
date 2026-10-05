using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.EventPoolInternal;

namespace Torappu
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	public class EventPool<TEnum> : EventPoolBase where TEnum : struct
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000453")]
		public void On(TEnum enumEv, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000454")]
		public void Once(TEnum enumEv, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000455")]
		public void Emit(TEnum enumEv, [Optional] object arg)
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000456")]
		public void EmitWithArgs(TEnum ev, params object[] args)
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000457")]
		public void Remove(TEnum enumEv, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000458")]
		public EventPool()
		{
		}
	}
}
