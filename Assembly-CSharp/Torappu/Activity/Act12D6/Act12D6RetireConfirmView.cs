using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AFC RID: 31484
	[Token(Token = "0x2007AFC")]
	public class Act12D6RetireConfirmView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C15B RID: 180571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C15B")]
		[Address(RVA = "0x27F8530", Offset = "0x27F7130", VA = "0x1827F8530")]
		public void Initialize(Action OnConfirm)
		{
		}

		// Token: 0x0602C15C RID: 180572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C15C")]
		[Address(RVA = "0x27F8920", Offset = "0x27F7520", VA = "0x1827F8920")]
		private void _Init()
		{
		}

		// Token: 0x0602C15D RID: 180573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C15D")]
		[Address(RVA = "0x27F86A0", Offset = "0x27F72A0", VA = "0x1827F86A0")]
		public void OnClick()
		{
		}

		// Token: 0x0602C15E RID: 180574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C15E")]
		[Address(RVA = "0x27F8380", Offset = "0x27F6F80", VA = "0x1827F8380")]
		public void ClosePage()
		{
		}

		// Token: 0x0602C15F RID: 180575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C15F")]
		[Address(RVA = "0x27F87F0", Offset = "0x27F73F0", VA = "0x1827F87F0")]
		private void OnDisable()
		{
		}

		// Token: 0x0602C160 RID: 180576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C160")]
		[Address(RVA = "0x27F8980", Offset = "0x27F7580", VA = "0x1827F8980")]
		private void _RenderBackImage()
		{
		}

		// Token: 0x0602C161 RID: 180577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C161")]
		[Address(RVA = "0x27F8870", Offset = "0x27F7470", VA = "0x1827F8870")]
		private IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602C162 RID: 180578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C162")]
		[Address(RVA = "0x27F8480", Offset = "0x27F7080", VA = "0x1827F8480")]
		private IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x0602C163 RID: 180579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C163")]
		[Address(RVA = "0x27F8B40", Offset = "0x27F7740", VA = "0x1827F8B40")]
		public Act12D6RetireConfirmView()
		{
		}

		// Token: 0x0403FE3F RID: 261695
		[Token(Token = "0x403FE3F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFullScreenImage _fullScreenImage;

		// Token: 0x0403FE40 RID: 261696
		[Token(Token = "0x403FE40")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _container;

		// Token: 0x0403FE41 RID: 261697
		[Token(Token = "0x403FE41")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x0403FE42 RID: 261698
		[Token(Token = "0x403FE42")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0403FE43 RID: 261699
		[Token(Token = "0x403FE43")]
		[FieldOffset(Offset = "0x38")]
		private UIPopupWindow.UIBlocker m_blocker;

		// Token: 0x0403FE44 RID: 261700
		[Token(Token = "0x403FE44")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403FE45 RID: 261701
		[Token(Token = "0x403FE45")]
		[FieldOffset(Offset = "0x48")]
		private Action m_onClick;

		// Token: 0x0403FE46 RID: 261702
		[Token(Token = "0x403FE46")]
		protected const float FADE_DURATION = 0.23f;

		// Token: 0x0403FE47 RID: 261703
		[Token(Token = "0x403FE47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Initialize;

		// Token: 0x0403FE48 RID: 261704
		[Token(Token = "0x403FE48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0403FE49 RID: 261705
		[Token(Token = "0x403FE49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403FE4A RID: 261706
		[Token(Token = "0x403FE4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x0403FE4B RID: 261707
		[Token(Token = "0x403FE4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403FE4C RID: 261708
		[Token(Token = "0x403FE4C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderBackImage;

		// Token: 0x0403FE4D RID: 261709
		[Token(Token = "0x403FE4D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403FE4E RID: 261710
		[Token(Token = "0x403FE4E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403FE4F RID: 261711
		[Token(Token = "0x403FE4F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
