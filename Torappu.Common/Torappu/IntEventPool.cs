using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.EventPoolInternal;

namespace Torappu
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	public class IntEventPool : EventPoolBase
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x54FE210", Offset = "0x54FCE10", VA = "0x1854FE210")]
		public void On(int ev, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x54FE250", Offset = "0x54FCE50", VA = "0x1854FE250")]
		public void Once(int ev, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x54FE180", Offset = "0x54FCD80", VA = "0x1854FE180")]
		public void Emit(int ev, [Optional] object arg)
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x54FE180", Offset = "0x54FCD80", VA = "0x1854FE180")]
		public void EmitWithArgs(int ev, params object[] args)
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x54FE290", Offset = "0x54FCE90", VA = "0x1854FE290")]
		public void Remove(int ev, EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x54FE310", Offset = "0x54FCF10", VA = "0x1854FE310")]
		public IntEventPool()
		{
		}
	}
}
