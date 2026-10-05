using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BF8 RID: 19448
	[Token(Token = "0x2004BF8")]
	public class HomeBackgroundItemView : MonoBehaviour, IHotfixable, IMultiFormHandler
	{
		// Token: 0x170044B8 RID: 17592
		// (set) Token: 0x0601D383 RID: 119683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044B8")]
		public Action<string> selectChanged
		{
			[Token(Token = "0x601D383")]
			[Address(RVA = "0x16BF9D0", Offset = "0x16BE5D0", VA = "0x1816BF9D0")]
			set
			{
			}
		}

		// Token: 0x0601D384 RID: 119684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D384")]
		[Address(RVA = "0x16BF2C0", Offset = "0x16BDEC0", VA = "0x1816BF2C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D385 RID: 119685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D385")]
		[Address(RVA = "0x16BF4B0", Offset = "0x16BE0B0", VA = "0x1816BF4B0")]
		private void _ResetToForm(string formId)
		{
		}

		// Token: 0x0601D386 RID: 119686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D386")]
		[Address(RVA = "0x16BF610", Offset = "0x16BE210", VA = "0x1816BF610")]
		private void _TransToForm(string formId)
		{
		}

		// Token: 0x0601D387 RID: 119687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D387")]
		[Address(RVA = "0x16BF3E0", Offset = "0x16BDFE0", VA = "0x1816BF3E0")]
		private void _LoadStateGraph(string bgId)
		{
		}

		// Token: 0x0601D388 RID: 119688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D388")]
		[Address(RVA = "0x16BED40", Offset = "0x16BD940", VA = "0x1816BED40")]
		public void Flush(HomeBackgroundItemModel backgroundModel)
		{
		}

		// Token: 0x0601D389 RID: 119689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D389")]
		[Address(RVA = "0x16BF190", Offset = "0x16BDD90", VA = "0x1816BF190", Slot = "4")]
		public void OnMultiFormChanged(HomeDisplayMultiFormItemModel formModel, bool shouldReset)
		{
		}

		// Token: 0x0601D38A RID: 119690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D38A")]
		[Address(RVA = "0x16BEC50", Offset = "0x16BD850", VA = "0x1816BEC50")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601D38B RID: 119691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D38B")]
		[Address(RVA = "0x16BF920", Offset = "0x16BE520", VA = "0x1816BF920")]
		public HomeBackgroundItemView()
		{
		}

		// Token: 0x0402662E RID: 157230
		[Token(Token = "0x402662E")]
		private const float DEFAULT_MULTI_FORM_TRANS_DURATION = 3f;

		// Token: 0x0402662F RID: 157231
		[Token(Token = "0x402662F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBgPreview;

		// Token: 0x04026630 RID: 157232
		[Token(Token = "0x4026630")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _prevFormImgBgPreview;

		// Token: 0x04026631 RID: 157233
		[Token(Token = "0x4026631")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objImgMusic;

		// Token: 0x04026632 RID: 157234
		[Token(Token = "0x4026632")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBgName;

		// Token: 0x04026633 RID: 157235
		[Token(Token = "0x4026633")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objPanelLockedNormal;

		// Token: 0x04026634 RID: 157236
		[Token(Token = "0x4026634")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objPanelSelected;

		// Token: 0x04026635 RID: 157237
		[Token(Token = "0x4026635")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objPanelLockSelected;

		// Token: 0x04026636 RID: 157238
		[Token(Token = "0x4026636")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objMultiFormIcon;

		// Token: 0x04026637 RID: 157239
		[Token(Token = "0x4026637")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objPanelMultiForm;

		// Token: 0x04026638 RID: 157240
		[Token(Token = "0x4026638")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _multiFormWaitAnim;

		// Token: 0x04026639 RID: 157241
		[Token(Token = "0x4026639")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UICommonTrackPoint _newTrackPoint;

		// Token: 0x0402663A RID: 157242
		[Token(Token = "0x402663A")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedId;

		// Token: 0x0402663B RID: 157243
		[Token(Token = "0x402663B")]
		[FieldOffset(Offset = "0x80")]
		private HomeBackgroundItemModel m_dataModel;

		// Token: 0x0402663C RID: 157244
		[Token(Token = "0x402663C")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0402663D RID: 157245
		[Token(Token = "0x402663D")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_backgroundNewTrackProp;

		// Token: 0x0402663E RID: 157246
		[Token(Token = "0x402663E")]
		[FieldOffset(Offset = "0x98")]
		private UIRingStateGraph m_stateGraph;

		// Token: 0x0402663F RID: 157247
		[Token(Token = "0x402663F")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_multiFormWaitTween;

		// Token: 0x04026640 RID: 157248
		[Token(Token = "0x4026640")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_previewTransTween;

		// Token: 0x04026641 RID: 157249
		[Token(Token = "0x4026641")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedFormId;

		// Token: 0x04026642 RID: 157250
		[Token(Token = "0x4026642")]
		[FieldOffset(Offset = "0xB8")]
		private Action<string> m_selectChanged;

		// Token: 0x04026643 RID: 157251
		[Token(Token = "0x4026643")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_selectChanged;

		// Token: 0x04026644 RID: 157252
		[Token(Token = "0x4026644")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026645 RID: 157253
		[Token(Token = "0x4026645")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetToForm;

		// Token: 0x04026646 RID: 157254
		[Token(Token = "0x4026646")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TransToForm;

		// Token: 0x04026647 RID: 157255
		[Token(Token = "0x4026647")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadStateGraph;

		// Token: 0x04026648 RID: 157256
		[Token(Token = "0x4026648")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x04026649 RID: 157257
		[Token(Token = "0x4026649")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMultiFormChanged;

		// Token: 0x0402664A RID: 157258
		[Token(Token = "0x402664A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0402664B RID: 157259
		[Token(Token = "0x402664B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
