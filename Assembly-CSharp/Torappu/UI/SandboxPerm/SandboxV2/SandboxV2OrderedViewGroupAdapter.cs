using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200412B RID: 16683
	[Token(Token = "0x200412B")]
	public abstract class SandboxV2OrderedViewGroupAdapter<TView> : IHotfixable where TView : Component, ISandboxV2OrderedView
	{
		// Token: 0x06019C4C RID: 105548
		[Token(Token = "0x6019C4C")]
		protected abstract int GetCount();

		// Token: 0x06019C4D RID: 105549
		[Token(Token = "0x6019C4D")]
		protected abstract TView Instantiate(int index);

		// Token: 0x06019C4E RID: 105550
		[Token(Token = "0x6019C4E")]
		protected abstract void Render(TView view, int index);

		// Token: 0x06019C4F RID: 105551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C4F")]
		public void OnDataChanged()
		{
		}

		// Token: 0x06019C50 RID: 105552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C50")]
		public void ForceRecycleAll()
		{
		}

		// Token: 0x06019C51 RID: 105553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C51")]
		private void _UpdateViews(int viewCount)
		{
		}

		// Token: 0x06019C52 RID: 105554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C52")]
		protected SandboxV2OrderedViewGroupAdapter()
		{
		}

		// Token: 0x040204FD RID: 132349
		[Token(Token = "0x40204FD")]
		[FieldOffset(Offset = "0x0")]
		private List<TView> m_views;

		// Token: 0x040204FE RID: 132350
		[Token(Token = "0x40204FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataChanged;

		// Token: 0x040204FF RID: 132351
		[Token(Token = "0x40204FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ForceRecycleAll;

		// Token: 0x04020500 RID: 132352
		[Token(Token = "0x4020500")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateViews;

		// Token: 0x04020501 RID: 132353
		[Token(Token = "0x4020501")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
