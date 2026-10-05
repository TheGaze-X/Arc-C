using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ABB RID: 27323
	[Token(Token = "0x2006ABB")]
	public abstract class ActArchiveCompProxy<TController> : ActArchiveProxy where TController : ActArchiveController
	{
		// Token: 0x17005C5D RID: 23645
		// (get) Token: 0x06027158 RID: 160088
		[Token(Token = "0x17005C5D")]
		protected abstract string compType { [Token(Token = "0x6027158")] get; }

		// Token: 0x06027159 RID: 160089
		[Token(Token = "0x6027159")]
		protected abstract void InitComp();

		// Token: 0x0602715A RID: 160090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602715A")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602715B RID: 160091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602715B")]
		protected virtual string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x0602715C RID: 160092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602715C")]
		public override void OnEnter()
		{
		}

		// Token: 0x0602715D RID: 160093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602715D")]
		public override void OnExit()
		{
		}

		// Token: 0x0602715E RID: 160094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602715E")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x0602715F RID: 160095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602715F")]
		public override void BeforePageExit()
		{
		}

		// Token: 0x06027160 RID: 160096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027160")]
		protected ActArchiveCompProxy()
		{
		}

		// Token: 0x040374C8 RID: 226504
		[Token(Token = "0x40374C8")]
		[FieldOffset(Offset = "0x0")]
		protected TController m_controller;

		// Token: 0x040374C9 RID: 226505
		[Token(Token = "0x40374C9")]
		[FieldOffset(Offset = "0x0")]
		private bool m_hasInited;

		// Token: 0x040374CA RID: 226506
		[Token(Token = "0x40374CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040374CB RID: 226507
		[Token(Token = "0x40374CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x040374CC RID: 226508
		[Token(Token = "0x40374CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040374CD RID: 226509
		[Token(Token = "0x40374CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040374CE RID: 226510
		[Token(Token = "0x40374CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040374CF RID: 226511
		[Token(Token = "0x40374CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BeforePageExit;

		// Token: 0x040374D0 RID: 226512
		[Token(Token = "0x40374D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
