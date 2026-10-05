using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C21 RID: 19489
	[Token(Token = "0x2004C21")]
	public class HomeThemeItemView : MonoBehaviour, IHotfixable, IMultiFormHandler
	{
		// Token: 0x170044CA RID: 17610
		// (set) Token: 0x0601D448 RID: 119880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044CA")]
		public Action<string> selectChanged
		{
			[Token(Token = "0x601D448")]
			[Address(RVA = "0x16DAB50", Offset = "0x16D9750", VA = "0x1816DAB50")]
			set
			{
			}
		}

		// Token: 0x0601D449 RID: 119881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D449")]
		[Address(RVA = "0x16DA410", Offset = "0x16D9010", VA = "0x1816DA410")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D44A RID: 119882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D44A")]
		[Address(RVA = "0x16DA600", Offset = "0x16D9200", VA = "0x1816DA600")]
		private void _ResetToForm(string formId)
		{
		}

		// Token: 0x0601D44B RID: 119883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D44B")]
		[Address(RVA = "0x16DA790", Offset = "0x16D9390", VA = "0x1816DA790")]
		private void _TransToForm(string formId)
		{
		}

		// Token: 0x0601D44C RID: 119884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D44C")]
		[Address(RVA = "0x16DA530", Offset = "0x16D9130", VA = "0x1816DA530")]
		private void _LoadStateGraph(string bgId)
		{
		}

		// Token: 0x0601D44D RID: 119885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D44D")]
		[Address(RVA = "0x16D9EB0", Offset = "0x16D8AB0", VA = "0x1816D9EB0")]
		public void Flush(HomeThemeItemModel themeModel)
		{
		}

		// Token: 0x0601D44E RID: 119886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D44E")]
		[Address(RVA = "0x16DA2E0", Offset = "0x16D8EE0", VA = "0x1816DA2E0", Slot = "4")]
		public void OnMultiFormChanged(HomeDisplayMultiFormItemModel formModel, bool shouldReset)
		{
		}

		// Token: 0x0601D44F RID: 119887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D44F")]
		[Address(RVA = "0x16D9D80", Offset = "0x16D8980", VA = "0x1816D9D80")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601D450 RID: 119888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D450")]
		[Address(RVA = "0x16DAAA0", Offset = "0x16D96A0", VA = "0x1816DAAA0")]
		public HomeThemeItemView()
		{
		}

		// Token: 0x040267D7 RID: 157655
		[Token(Token = "0x40267D7")]
		private const float DEFAULT_MULTI_FORM_TRANS_DURATION = 3f;

		// Token: 0x040267D8 RID: 157656
		[Token(Token = "0x40267D8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgThemePreview;

		// Token: 0x040267D9 RID: 157657
		[Token(Token = "0x40267D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _prevFormImgThemePreview;

		// Token: 0x040267DA RID: 157658
		[Token(Token = "0x40267DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textThemeName;

		// Token: 0x040267DB RID: 157659
		[Token(Token = "0x40267DB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objPanelLockedNormal;

		// Token: 0x040267DC RID: 157660
		[Token(Token = "0x40267DC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objPanelSelected;

		// Token: 0x040267DD RID: 157661
		[Token(Token = "0x40267DD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objPanelLockSelected;

		// Token: 0x040267DE RID: 157662
		[Token(Token = "0x40267DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objMultiFormIcon;

		// Token: 0x040267DF RID: 157663
		[Token(Token = "0x40267DF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objPanelMultiForm;

		// Token: 0x040267E0 RID: 157664
		[Token(Token = "0x40267E0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _multiFormWaitAnim;

		// Token: 0x040267E1 RID: 157665
		[Token(Token = "0x40267E1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommonTrackPoint _newTrackPoint;

		// Token: 0x040267E2 RID: 157666
		[Token(Token = "0x40267E2")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedId;

		// Token: 0x040267E3 RID: 157667
		[Token(Token = "0x40267E3")]
		[FieldOffset(Offset = "0x78")]
		private HomeThemeItemModel m_dataModel;

		// Token: 0x040267E4 RID: 157668
		[Token(Token = "0x40267E4")]
		[FieldOffset(Offset = "0x80")]
		private TrackPointViewProperty m_homeNewTrackProp;

		// Token: 0x040267E5 RID: 157669
		[Token(Token = "0x40267E5")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x040267E6 RID: 157670
		[Token(Token = "0x40267E6")]
		[FieldOffset(Offset = "0x90")]
		private UIRingStateGraph m_stateGraph;

		// Token: 0x040267E7 RID: 157671
		[Token(Token = "0x40267E7")]
		[FieldOffset(Offset = "0x98")]
		private AnimationSwitchTween m_multiFormWaitTween;

		// Token: 0x040267E8 RID: 157672
		[Token(Token = "0x40267E8")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_previewTransTween;

		// Token: 0x040267E9 RID: 157673
		[Token(Token = "0x40267E9")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedFormId;

		// Token: 0x040267EA RID: 157674
		[Token(Token = "0x40267EA")]
		[FieldOffset(Offset = "0xB0")]
		private Action<string> m_selectChanged;

		// Token: 0x040267EB RID: 157675
		[Token(Token = "0x40267EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_selectChanged;

		// Token: 0x040267EC RID: 157676
		[Token(Token = "0x40267EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040267ED RID: 157677
		[Token(Token = "0x40267ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetToForm;

		// Token: 0x040267EE RID: 157678
		[Token(Token = "0x40267EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TransToForm;

		// Token: 0x040267EF RID: 157679
		[Token(Token = "0x40267EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadStateGraph;

		// Token: 0x040267F0 RID: 157680
		[Token(Token = "0x40267F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x040267F1 RID: 157681
		[Token(Token = "0x40267F1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMultiFormChanged;

		// Token: 0x040267F2 RID: 157682
		[Token(Token = "0x40267F2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x040267F3 RID: 157683
		[Token(Token = "0x40267F3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
