using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	public class WillRenderCanvasManager : Singleton<WillRenderCanvasManager>
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x55639F0", Offset = "0x55625F0", VA = "0x1855639F0")]
		private WillRenderCanvasManager()
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x5563440", Offset = "0x5562040", VA = "0x185563440")]
		public IWillRenderCanvasTask CreateTask(Action onWillRender)
		{
			return null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x55635F0", Offset = "0x55621F0", VA = "0x1855635F0")]
		public void RemoveTask(WillRenderCanvasTask task)
		{
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x5563590", Offset = "0x5562190", VA = "0x185563590")]
		public void RefreshStatus()
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x5563870", Offset = "0x5562470", VA = "0x185563870")]
		private void _RefreshStatus()
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x55636A0", Offset = "0x55622A0", VA = "0x1855636A0")]
		private void _DoTasks()
		{
		}

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0x10")]
		private List<WillRenderCanvasTask> m_taskList;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isActive;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x20")]
		private ulong m_frameCnt;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate206 __Hotfix0_CreateTask;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate0 __Hotfix0_RemoveTask;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_RefreshStatus;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0__RefreshStatus;

		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0__DoTasks;
	}
}
