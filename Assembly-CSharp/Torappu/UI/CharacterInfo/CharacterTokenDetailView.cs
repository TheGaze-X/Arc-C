using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F3B RID: 24379
	[Token(Token = "0x2005F3B")]
	public class CharacterTokenDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700537C RID: 21372
		// (get) Token: 0x060234E0 RID: 144608 RVA: 0x000C0858 File Offset: 0x000BEA58
		[Token(Token = "0x1700537C")]
		public bool isShow
		{
			[Token(Token = "0x60234E0")]
			[Address(RVA = "0x1DDFFD0", Offset = "0x1DDEBD0", VA = "0x181DDFFD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060234E1 RID: 144609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E1")]
		[Address(RVA = "0x1DDFB70", Offset = "0x1DDE770", VA = "0x181DDFB70")]
		public void Render(CharTokenViewModel tokenData)
		{
		}

		// Token: 0x060234E2 RID: 144610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E2")]
		[Address(RVA = "0x1DDFDB0", Offset = "0x1DDE9B0", VA = "0x181DDFDB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060234E3 RID: 144611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E3")]
		[Address(RVA = "0x1DDFEC0", Offset = "0x1DDEAC0", VA = "0x181DDFEC0")]
		private void _ShowPanelView()
		{
		}

		// Token: 0x060234E4 RID: 144612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E4")]
		[Address(RVA = "0x1DDFB00", Offset = "0x1DDE700", VA = "0x181DDFB00")]
		public void EventOnHideView()
		{
		}

		// Token: 0x060234E5 RID: 144613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E5")]
		[Address(RVA = "0x1DDFF70", Offset = "0x1DDEB70", VA = "0x181DDFF70")]
		public CharacterTokenDetailView()
		{
		}

		// Token: 0x04030B3C RID: 199484
		[Token(Token = "0x4030B3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFadeFloatPanel _floatPanel;

		// Token: 0x04030B3D RID: 199485
		[Token(Token = "0x4030B3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04030B3E RID: 199486
		[Token(Token = "0x4030B3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _closeBtn;

		// Token: 0x04030B3F RID: 199487
		[Token(Token = "0x4030B3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterTokenDetailShowView _showView;

		// Token: 0x04030B40 RID: 199488
		[Token(Token = "0x4030B40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _noInfoObj;

		// Token: 0x04030B41 RID: 199489
		[Token(Token = "0x4030B41")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04030B42 RID: 199490
		[Token(Token = "0x4030B42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04030B43 RID: 199491
		[Token(Token = "0x4030B43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030B44 RID: 199492
		[Token(Token = "0x4030B44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030B45 RID: 199493
		[Token(Token = "0x4030B45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowPanelView;

		// Token: 0x04030B46 RID: 199494
		[Token(Token = "0x4030B46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnHideView;

		// Token: 0x04030B47 RID: 199495
		[Token(Token = "0x4030B47")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
