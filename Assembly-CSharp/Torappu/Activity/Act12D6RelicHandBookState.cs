using System;
using Il2CppDummyDll;
using Torappu.Activity.Act12D6;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D39 RID: 27961
	[Token(Token = "0x2006D39")]
	public class Act12D6RelicHandBookState : PopupFloatState, IHotfixable
	{
		// Token: 0x06027DBA RID: 163258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DBA")]
		[Address(RVA = "0x22ECAA0", Offset = "0x22EB6A0", VA = "0x1822ECAA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027DBB RID: 163259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DBB")]
		[Address(RVA = "0x22ECB00", Offset = "0x22EB700", VA = "0x1822ECB00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027DBC RID: 163260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DBC")]
		[Address(RVA = "0x22ECCA0", Offset = "0x22EB8A0", VA = "0x1822ECCA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027DBD RID: 163261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DBD")]
		[Address(RVA = "0x22EC6C0", Offset = "0x22EB2C0", VA = "0x1822EC6C0")]
		public void EventOnRelicClicked(string relicId)
		{
		}

		// Token: 0x06027DBE RID: 163262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DBE")]
		[Address(RVA = "0x22EC7A0", Offset = "0x22EB3A0", VA = "0x1822EC7A0")]
		public void EventOnSortRelicAll(Toggle sortToggle)
		{
		}

		// Token: 0x06027DBF RID: 163263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DBF")]
		[Address(RVA = "0x22EC9A0", Offset = "0x22EB5A0", VA = "0x1822EC9A0")]
		public void EventOnSortRelicNew(Toggle sortToggle)
		{
		}

		// Token: 0x06027DC0 RID: 163264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DC0")]
		[Address(RVA = "0x22EC8A0", Offset = "0x22EB4A0", VA = "0x1822EC8A0")]
		public void EventOnSortRelicLocked(Toggle sortToggle)
		{
		}

		// Token: 0x06027DC1 RID: 163265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DC1")]
		[Address(RVA = "0x22ECDF0", Offset = "0x22EB9F0", VA = "0x1822ECDF0")]
		private void _RenderView(bool force = false)
		{
		}

		// Token: 0x06027DC2 RID: 163266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DC2")]
		[Address(RVA = "0x22ECEB0", Offset = "0x22EBAB0", VA = "0x1822ECEB0")]
		public Act12D6RelicHandBookState()
		{
		}

		// Token: 0x06027DC4 RID: 163268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DC4")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040387EF RID: 231407
		[Token(Token = "0x40387EF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act12D6RelicHandBookView _view;

		// Token: 0x040387F0 RID: 231408
		[Token(Token = "0x40387F0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040387F1 RID: 231409
		[Token(Token = "0x40387F1")]
		[FieldOffset(Offset = "0x80")]
		private Act12D6RelicHandBookStateBean m_stateBean;

		// Token: 0x040387F2 RID: 231410
		[Token(Token = "0x40387F2")]
		[FieldOffset(Offset = "0x88")]
		private CommonTopMenu m_topMenu;

		// Token: 0x040387F3 RID: 231411
		[Token(Token = "0x40387F3")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x040387F4 RID: 231412
		[Token(Token = "0x40387F4")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedChosenRelicId;

		// Token: 0x040387F5 RID: 231413
		[Token(Token = "0x40387F5")]
		[FieldOffset(Offset = "0xA0")]
		private eRelicSortType m_cachedSortType;

		// Token: 0x040387F6 RID: 231414
		[Token(Token = "0x40387F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040387F7 RID: 231415
		[Token(Token = "0x40387F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040387F8 RID: 231416
		[Token(Token = "0x40387F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040387F9 RID: 231417
		[Token(Token = "0x40387F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnRelicClicked;

		// Token: 0x040387FA RID: 231418
		[Token(Token = "0x40387FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnSortRelicAll;

		// Token: 0x040387FB RID: 231419
		[Token(Token = "0x40387FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnSortRelicNew;

		// Token: 0x040387FC RID: 231420
		[Token(Token = "0x40387FC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnSortRelicLocked;

		// Token: 0x040387FD RID: 231421
		[Token(Token = "0x40387FD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x040387FE RID: 231422
		[Token(Token = "0x40387FE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
