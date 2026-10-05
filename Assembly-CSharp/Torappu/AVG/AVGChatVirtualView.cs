using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ChatBox;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F8A RID: 8074
	[Token(Token = "0x2001F8A")]
	public abstract class AVGChatVirtualView<TView> : UIRecycleLayoutAdapter.VirtualView<TView>, IChatItem where TView : Component
	{
		// Token: 0x0600C8A3 RID: 51363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8A3")]
		protected sealed override void OnViewAttached()
		{
		}

		// Token: 0x0600C8A4 RID: 51364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8A4")]
		protected sealed override void OnViewDetached()
		{
		}

		// Token: 0x0600C8A5 RID: 51365 RVA: 0x00048F30 File Offset: 0x00047130
		[Token(Token = "0x600C8A5")]
		public virtual PlayConfig BeforePlaying()
		{
			return default(PlayConfig);
		}

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C8A6")]
		public IEnumerator PlayCoroutine()
		{
			return null;
		}

		// Token: 0x0600C8A7 RID: 51367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C8A7")]
		public IEnumerator RemoveCoroutine()
		{
			return null;
		}

		// Token: 0x0600C8A8 RID: 51368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8A8")]
		public void DisplayForLog()
		{
		}

		// Token: 0x0600C8A9 RID: 51369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8A9")]
		public void DisplayForRecord()
		{
		}

		// Token: 0x0600C8AA RID: 51370
		[Token(Token = "0x600C8AA")]
		protected abstract void HideViewContent(TView view);

		// Token: 0x0600C8AB RID: 51371
		[Token(Token = "0x600C8AB")]
		protected abstract IEnumerator PlayViewContent(TView view);

		// Token: 0x0600C8AC RID: 51372
		[Token(Token = "0x600C8AC")]
		protected abstract void OnUpdateView(TView view);

		// Token: 0x0600C8AD RID: 51373
		[Token(Token = "0x600C8AD")]
		protected abstract void ShowAsLog(TView view);

		// Token: 0x0600C8AE RID: 51374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8AE")]
		protected virtual void ShowAsRecord(TView view)
		{
		}

		// Token: 0x0600C8AF RID: 51375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C8AF")]
		protected virtual IEnumerator RemoveViewContent(TView view)
		{
			return null;
		}

		// Token: 0x0600C8B0 RID: 51376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8B0")]
		protected AVGChatVirtualView()
		{
		}

		// Token: 0x0400CF42 RID: 53058
		[Token(Token = "0x400CF42")]
		private const int PLAY_FRAMEOUT = 5;

		// Token: 0x0400CF43 RID: 53059
		[Token(Token = "0x400CF43")]
		[FieldOffset(Offset = "0x0")]
		private bool m_showView;

		// Token: 0x0400CF44 RID: 53060
		[Token(Token = "0x400CF44")]
		[FieldOffset(Offset = "0x0")]
		private bool m_pendingShowAsLog;

		// Token: 0x0400CF45 RID: 53061
		[Token(Token = "0x400CF45")]
		[FieldOffset(Offset = "0x0")]
		private bool m_pendingShowAsRecord;

		// Token: 0x0400CF46 RID: 53062
		[Token(Token = "0x400CF46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x0400CF47 RID: 53063
		[Token(Token = "0x400CF47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x0400CF48 RID: 53064
		[Token(Token = "0x400CF48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BeforePlaying;

		// Token: 0x0400CF49 RID: 53065
		[Token(Token = "0x400CF49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayCoroutine;

		// Token: 0x0400CF4A RID: 53066
		[Token(Token = "0x400CF4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RemoveCoroutine;

		// Token: 0x0400CF4B RID: 53067
		[Token(Token = "0x400CF4B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DisplayForLog;

		// Token: 0x0400CF4C RID: 53068
		[Token(Token = "0x400CF4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DisplayForRecord;

		// Token: 0x0400CF4D RID: 53069
		[Token(Token = "0x400CF4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowAsRecord;

		// Token: 0x0400CF4E RID: 53070
		[Token(Token = "0x400CF4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RemoveViewContent;

		// Token: 0x0400CF4F RID: 53071
		[Token(Token = "0x400CF4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
