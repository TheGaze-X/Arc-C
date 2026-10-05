using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200370E RID: 14094
	[Token(Token = "0x200370E")]
	[RequireComponent(typeof(CanvasGroup))]
	public class UIGuidebookPanel : UIFloatMask
	{
		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x060165E3 RID: 91619 RVA: 0x00090CD8 File Offset: 0x0008EED8
		[Token(Token = "0x170035AF")]
		public int pageCount
		{
			[Token(Token = "0x60165E3")]
			[Address(RVA = "0xED0E20", Offset = "0xECFA20", VA = "0x180ED0E20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x060165E4 RID: 91620 RVA: 0x00090CF0 File Offset: 0x0008EEF0
		// (set) Token: 0x060165E5 RID: 91621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035B0")]
		public int pageIndex
		{
			[Token(Token = "0x60165E4")]
			[Address(RVA = "0xED0E90", Offset = "0xECFA90", VA = "0x180ED0E90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60165E5")]
			[Address(RVA = "0xED0F00", Offset = "0xECFB00", VA = "0x180ED0F00")]
			private set
			{
			}
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x060165E6 RID: 91622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035B1")]
		public AbstractAssetLoader assetLoader
		{
			[Token(Token = "0x60165E6")]
			[Address(RVA = "0xED0CF0", Offset = "0xECF8F0", VA = "0x180ED0CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x060165E7 RID: 91623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035B2")]
		protected CanvasGroup canvasGroup
		{
			[Token(Token = "0x60165E7")]
			[Address(RVA = "0xED0D50", Offset = "0xECF950", VA = "0x180ED0D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060165E8 RID: 91624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165E8")]
		[Address(RVA = "0xED0590", Offset = "0xECF190", VA = "0x180ED0590")]
		public new void Show([Optional] Action callback)
		{
		}

		// Token: 0x060165E9 RID: 91625 RVA: 0x00090D08 File Offset: 0x0008EF08
		[Token(Token = "0x60165E9")]
		[Address(RVA = "0xECFDB0", Offset = "0xECE9B0", VA = "0x180ECFDB0")]
		public bool Open(IList<string> pageIds, int forceRead, Action onFinish)
		{
			return default(bool);
		}

		// Token: 0x060165EA RID: 91626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165EA")]
		[Address(RVA = "0xECFC90", Offset = "0xECE890", VA = "0x180ECFC90")]
		public void OnNextPage(UIGuidebookPage page)
		{
		}

		// Token: 0x060165EB RID: 91627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165EB")]
		[Address(RVA = "0xED09B0", Offset = "0xECF5B0", VA = "0x180ED09B0")]
		private void _ClearAll()
		{
		}

		// Token: 0x060165EC RID: 91628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165EC")]
		[Address(RVA = "0xED08D0", Offset = "0xECF4D0", VA = "0x180ED08D0")]
		private void _BindBackPress()
		{
		}

		// Token: 0x060165ED RID: 91629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60165ED")]
		[Address(RVA = "0xED04E0", Offset = "0xECF0E0", VA = "0x180ED04E0", Slot = "4")]
		protected override IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x060165EE RID: 91630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60165EE")]
		[Address(RVA = "0xECFB10", Offset = "0xECE710", VA = "0x180ECFB10", Slot = "6")]
		protected override IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x060165EF RID: 91631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165EF")]
		[Address(RVA = "0xECFC20", Offset = "0xECE820", VA = "0x180ECFC20", Slot = "7")]
		protected override void OnHide()
		{
		}

		// Token: 0x060165F0 RID: 91632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165F0")]
		[Address(RVA = "0xECFA30", Offset = "0xECE630", VA = "0x180ECFA30")]
		public void EventOnClick()
		{
		}

		// Token: 0x060165F1 RID: 91633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165F1")]
		[Address(RVA = "0xED0630", Offset = "0xECF230", VA = "0x180ED0630")]
		private void Start()
		{
		}

		// Token: 0x060165F2 RID: 91634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165F2")]
		[Address(RVA = "0xECFBC0", Offset = "0xECE7C0", VA = "0x180ECFBC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060165F3 RID: 91635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165F3")]
		[Address(RVA = "0xED0BA0", Offset = "0xECF7A0", VA = "0x180ED0BA0")]
		public UIGuidebookPanel()
		{
		}

		// Token: 0x060165F5 RID: 91637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60165F5")]
		[Address(RVA = "0xED08C0", Offset = "0xECF4C0", VA = "0x180ED08C0")]
		private void <>xLuaBaseProxy_OnHide()
		{
		}

		// Token: 0x0401AE82 RID: 110210
		[Token(Token = "0x401AE82")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x0401AE83 RID: 110211
		[Token(Token = "0x401AE83")]
		private const int PRELOAD_FRAMES = 3;

		// Token: 0x0401AE84 RID: 110212
		[Token(Token = "0x401AE84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollViewPager _pager;

		// Token: 0x0401AE85 RID: 110213
		[Token(Token = "0x401AE85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIRenderTextureImage _blurImg;

		// Token: 0x0401AE86 RID: 110214
		[Token(Token = "0x401AE86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private EasyInstancePool _pagePool;

		// Token: 0x0401AE87 RID: 110215
		[Token(Token = "0x401AE87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private EasyInstancePool _togglePool;

		// Token: 0x0401AE88 RID: 110216
		[Token(Token = "0x401AE88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ToggleGroup _toggleGroup;

		// Token: 0x0401AE89 RID: 110217
		[Token(Token = "0x401AE89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _exitButton;

		// Token: 0x0401AE8A RID: 110218
		[Token(Token = "0x401AE8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0401AE8B RID: 110219
		[Token(Token = "0x401AE8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AbstractAssetLoader m_assetLoader;

		// Token: 0x0401AE8C RID: 110220
		[Token(Token = "0x401AE8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<UIGuidebookPage> m_pages;

		// Token: 0x0401AE8D RID: 110221
		[Token(Token = "0x401AE8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Toggle> m_toggles;

		// Token: 0x0401AE8E RID: 110222
		[Token(Token = "0x401AE8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_lockClick;

		// Token: 0x0401AE8F RID: 110223
		[Token(Token = "0x401AE8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action m_onFinish;

		// Token: 0x0401AE90 RID: 110224
		[Token(Token = "0x401AE90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int m_forceRead;

		// Token: 0x0401AE91 RID: 110225
		[Token(Token = "0x401AE91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageCount;

		// Token: 0x0401AE92 RID: 110226
		[Token(Token = "0x401AE92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pageIndex;

		// Token: 0x0401AE93 RID: 110227
		[Token(Token = "0x401AE93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_pageIndex;

		// Token: 0x0401AE94 RID: 110228
		[Token(Token = "0x401AE94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x0401AE95 RID: 110229
		[Token(Token = "0x401AE95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x0401AE96 RID: 110230
		[Token(Token = "0x401AE96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401AE97 RID: 110231
		[Token(Token = "0x401AE97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Open;

		// Token: 0x0401AE98 RID: 110232
		[Token(Token = "0x401AE98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnNextPage;

		// Token: 0x0401AE99 RID: 110233
		[Token(Token = "0x401AE99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClearAll;

		// Token: 0x0401AE9A RID: 110234
		[Token(Token = "0x401AE9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__BindBackPress;

		// Token: 0x0401AE9B RID: 110235
		[Token(Token = "0x401AE9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401AE9C RID: 110236
		[Token(Token = "0x401AE9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401AE9D RID: 110237
		[Token(Token = "0x401AE9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x0401AE9E RID: 110238
		[Token(Token = "0x401AE9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401AE9F RID: 110239
		[Token(Token = "0x401AE9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401AEA0 RID: 110240
		[Token(Token = "0x401AEA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401AEA1 RID: 110241
		[Token(Token = "0x401AEA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
