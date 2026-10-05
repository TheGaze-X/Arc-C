using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public static class EventPool
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600044E")]
		public static void NullableEmit<TEnum>(this EventPool<TEnum> pool, TEnum enumEv, [Optional] object arg) where TEnum : struct
		{
		}

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x06000450 RID: 1104
		[Token(Token = "0x20000B0")]
		public delegate void EventCallbackDelegate(object arg);
	}
}
