using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ChatBox;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F86 RID: 8070
	[Token(Token = "0x2001F86")]
	public abstract class AVGChatConditionVirtualView<TView> : UIRecycleLayoutAdapter.VirtualView<TView>, IChatItem where TView : Component
	{
		// Token: 0x0600C883 RID: 51331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C883")]
		public sealed override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x0600C884 RID: 51332 RVA: 0x00048EB8 File Offset: 0x000470B8
		[Token(Token = "0x600C884")]
		public sealed override float GetPreferSize()
		{
			return 0f;
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C885")]
		protected sealed override void OnViewAttached()
		{
		}

		// Token: 0x0600C886 RID: 51334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C886")]
		protected sealed override void OnViewDetached()
		{
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x00048ED0 File Offset: 0x000470D0
		[Token(Token = "0x600C887")]
		public virtual PlayConfig BeforePlaying()
		{
			return default(PlayConfig);
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C888")]
		public IEnumerator PlayCoroutine()
		{
			return null;
		}

		// Token: 0x0600C889 RID: 51337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C889")]
		public IEnumerator RemoveCoroutine()
		{
			return null;
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C88A")]
		public void DisplayForLog()
		{
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C88B")]
		public void DisplayForRecord()
		{
		}

		// Token: 0x0600C88C RID: 51340
		[Token(Token = "0x600C88C")]
		protected abstract IEnumerator PlayCondition();

		// Token: 0x0600C88D RID: 51341
		[Token(Token = "0x600C88D")]
		protected abstract void ShowAsLog();

		// Token: 0x0600C88E RID: 51342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C88E")]
		protected virtual void ShowAsRecord()
		{
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C88F")]
		protected virtual IEnumerator RemoveCondition()
		{
			return null;
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C890")]
		protected AVGChatConditionVirtualView()
		{
		}

		// Token: 0x0400CF2E RID: 53038
		[Token(Token = "0x400CF2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x0400CF2F RID: 53039
		[Token(Token = "0x400CF2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x0400CF30 RID: 53040
		[Token(Token = "0x400CF30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x0400CF31 RID: 53041
		[Token(Token = "0x400CF31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x0400CF32 RID: 53042
		[Token(Token = "0x400CF32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BeforePlaying;

		// Token: 0x0400CF33 RID: 53043
		[Token(Token = "0x400CF33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayCoroutine;

		// Token: 0x0400CF34 RID: 53044
		[Token(Token = "0x400CF34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RemoveCoroutine;

		// Token: 0x0400CF35 RID: 53045
		[Token(Token = "0x400CF35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DisplayForLog;

		// Token: 0x0400CF36 RID: 53046
		[Token(Token = "0x400CF36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DisplayForRecord;

		// Token: 0x0400CF37 RID: 53047
		[Token(Token = "0x400CF37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowAsRecord;

		// Token: 0x0400CF38 RID: 53048
		[Token(Token = "0x400CF38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RemoveCondition;

		// Token: 0x0400CF39 RID: 53049
		[Token(Token = "0x400CF39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
