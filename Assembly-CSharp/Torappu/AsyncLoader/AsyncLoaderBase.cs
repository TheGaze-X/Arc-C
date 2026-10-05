using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AsyncLoader
{
	// Token: 0x020016D2 RID: 5842
	[Token(Token = "0x20016D2")]
	public abstract class AsyncLoaderBase : IHotfixable, IAsyncTickable
	{
		// Token: 0x060093FB RID: 37883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FB")]
		[Address(RVA = "0x2B26990", Offset = "0x2B25590", VA = "0x182B26990")]
		public AsyncLoaderBase()
		{
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x00039C18 File Offset: 0x00037E18
		[Token(Token = "0x60093FC")]
		[Address(RVA = "0x2B260F0", Offset = "0x2B24CF0", VA = "0x182B260F0")]
		protected bool AddTask(AsyncTaskBase task)
		{
			return default(bool);
		}

		// Token: 0x060093FD RID: 37885 RVA: 0x00039C30 File Offset: 0x00037E30
		[Token(Token = "0x60093FD")]
		[Address(RVA = "0x2B261F0", Offset = "0x2B24DF0", VA = "0x182B261F0")]
		protected bool RebuildLoadingOrder()
		{
			return default(bool);
		}

		// Token: 0x060093FE RID: 37886
		[Token(Token = "0x60093FE")]
		protected abstract void OnTaskLoaded(AsyncTaskBase task);

		// Token: 0x060093FF RID: 37887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FF")]
		[Address(RVA = "0x2B26790", Offset = "0x2B25390", VA = "0x182B26790")]
		private void _WorkPerTick()
		{
		}

		// Token: 0x06009400 RID: 37888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009400")]
		[Address(RVA = "0x2B266E0", Offset = "0x2B252E0", VA = "0x182B266E0", Slot = "4")]
		public void Tick()
		{
		}

		// Token: 0x040089D2 RID: 35282
		[Token(Token = "0x40089D2")]
		[FieldOffset(Offset = "0x10")]
		private Heap<AsyncTaskBase> m_loadingHeap;

		// Token: 0x040089D3 RID: 35283
		[Token(Token = "0x40089D3")]
		[FieldOffset(Offset = "0x18")]
		private List<AsyncTaskBase> m_sharedList;

		// Token: 0x040089D4 RID: 35284
		[Token(Token = "0x40089D4")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isFrameWorking;

		// Token: 0x040089D5 RID: 35285
		[Token(Token = "0x40089D5")]
		[FieldOffset(Offset = "0x28")]
		private AsyncTicker m_taskTicker;

		// Token: 0x040089D6 RID: 35286
		[Token(Token = "0x40089D6")]
		[FieldOffset(Offset = "0x30")]
		public uint costPerFrame;

		// Token: 0x040089D7 RID: 35287
		[Token(Token = "0x40089D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040089D8 RID: 35288
		[Token(Token = "0x40089D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddTask;

		// Token: 0x040089D9 RID: 35289
		[Token(Token = "0x40089D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RebuildLoadingOrder;

		// Token: 0x040089DA RID: 35290
		[Token(Token = "0x40089DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__WorkPerTick;

		// Token: 0x040089DB RID: 35291
		[Token(Token = "0x40089DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Tick;
	}
}
