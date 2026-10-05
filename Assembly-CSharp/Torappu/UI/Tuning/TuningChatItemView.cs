using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C72 RID: 15474
	[Token(Token = "0x2003C72")]
	public class TuningChatItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060182B3 RID: 98995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182B3")]
		[Address(RVA = "0x10A8C30", Offset = "0x10A7830", VA = "0x1810A8C30")]
		public void Render(TuningChatItemViewModel viewModel, string selectedInvestId)
		{
		}

		// Token: 0x060182B4 RID: 98996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182B4")]
		[Address(RVA = "0x10A9270", Offset = "0x10A7E70", VA = "0x1810A9270")]
		private void _InitIfNot(string investId, string selectedId)
		{
		}

		// Token: 0x060182B5 RID: 98997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182B5")]
		[Address(RVA = "0x10A9400", Offset = "0x10A8000", VA = "0x1810A9400")]
		private void _LoadAvatar(string avatarId)
		{
		}

		// Token: 0x060182B6 RID: 98998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182B6")]
		[Address(RVA = "0x10A8B10", Offset = "0x10A7710", VA = "0x1810A8B10")]
		public void OnClick()
		{
		}

		// Token: 0x060182B7 RID: 98999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182B7")]
		[Address(RVA = "0x10A94F0", Offset = "0x10A80F0", VA = "0x1810A94F0")]
		public TuningChatItemView()
		{
		}

		// Token: 0x0401D659 RID: 120409
		[Token(Token = "0x401D659")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x0401D65A RID: 120410
		[Token(Token = "0x401D65A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bgNormal;

		// Token: 0x0401D65B RID: 120411
		[Token(Token = "0x401D65B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _bgMajor;

		// Token: 0x0401D65C RID: 120412
		[Token(Token = "0x401D65C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bgHidden;

		// Token: 0x0401D65D RID: 120413
		[Token(Token = "0x401D65D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelFault;

		// Token: 0x0401D65E RID: 120414
		[Token(Token = "0x401D65E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _panelSelected;

		// Token: 0x0401D65F RID: 120415
		[Token(Token = "0x401D65F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _panelUnselected;

		// Token: 0x0401D660 RID: 120416
		[Token(Token = "0x401D660")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401D661 RID: 120417
		[Token(Token = "0x401D661")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedId;

		// Token: 0x0401D662 RID: 120418
		[Token(Token = "0x401D662")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedSelectedId;

		// Token: 0x0401D663 RID: 120419
		[Token(Token = "0x401D663")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D664 RID: 120420
		[Token(Token = "0x401D664")]
		[FieldOffset(Offset = "0x78")]
		private FadeSwitchTween m_selectTween;

		// Token: 0x0401D665 RID: 120421
		[Token(Token = "0x401D665")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_unselectTween;

		// Token: 0x0401D666 RID: 120422
		[Token(Token = "0x401D666")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D667 RID: 120423
		[Token(Token = "0x401D667")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D668 RID: 120424
		[Token(Token = "0x401D668")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadAvatar;

		// Token: 0x0401D669 RID: 120425
		[Token(Token = "0x401D669")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401D66A RID: 120426
		[Token(Token = "0x401D66A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
