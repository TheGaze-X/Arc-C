using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	public class WillRenderCanvasTask : IWillRenderCanvasTask, IHotfixable
	{
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00007454 File Offset: 0x00005654
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000E8")]
		public bool isPause
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x5563F40", Offset = "0x5562B40", VA = "0x185563F40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x5563FA0", Offset = "0x5562BA0", VA = "0x185563FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x5563EA0", Offset = "0x5562AA0", VA = "0x185563EA0")]
		public WillRenderCanvasTask(WillRenderCanvasManager manager, Action onWillRender)
		{
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x5563CC0", Offset = "0x55628C0", VA = "0x185563CC0")]
		public void Run()
		{
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x5563AC0", Offset = "0x55626C0", VA = "0x185563AC0", Slot = "4")]
		public void Pause()
		{
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x5563C50", Offset = "0x5562850", VA = "0x185563C50", Slot = "5")]
		public void Resume()
		{
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x5563D30", Offset = "0x5562930", VA = "0x185563D30")]
		private void _UpdatePauseStatus(bool needPause)
		{
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x5563B30", Offset = "0x5562730", VA = "0x185563B30", Slot = "6")]
		public void Release()
		{
		}

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		[FieldOffset(Offset = "0x10")]
		private WillRenderCanvasManager m_manager;

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onWillRender;

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isPause;

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_isPause;

		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate5 _c__Hotfix0_ctor;

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Run;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Pause;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Resume;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate6 __Hotfix0__UpdatePauseStatus;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Release;
	}
}
