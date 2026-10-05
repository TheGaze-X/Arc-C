using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F6A RID: 28522
	[Token(Token = "0x2006F6A")]
	public class ActMultiV3PhotoSelectView : DataBinder<ActMultiV3ManualPhotoSelectProperty>, IHotfixable
	{
		// Token: 0x060287E8 RID: 165864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E8")]
		[Address(RVA = "0x23CF070", Offset = "0x23CDC70", VA = "0x1823CF070", Slot = "7")]
		public override void OnValueChanged(ActMultiV3ManualPhotoSelectProperty property)
		{
		}

		// Token: 0x060287E9 RID: 165865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287E9")]
		[Address(RVA = "0x23CEF50", Offset = "0x23CDB50", VA = "0x1823CEF50")]
		public void OnClickShowHideDetail()
		{
		}

		// Token: 0x060287EA RID: 165866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287EA")]
		[Address(RVA = "0x23CEFE0", Offset = "0x23CDBE0", VA = "0x1823CEFE0")]
		public void OnSubmitPhoto()
		{
		}

		// Token: 0x060287EB RID: 165867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287EB")]
		[Address(RVA = "0x23CEEC0", Offset = "0x23CDAC0", VA = "0x1823CEEC0")]
		public void OnClickComittedPhoto()
		{
		}

		// Token: 0x060287EC RID: 165868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287EC")]
		[Address(RVA = "0x23CFB20", Offset = "0x23CE720", VA = "0x1823CFB20")]
		private void _SwitchPhoto(ActMultiV3ManualPhotoSelectViewModel model, bool fastMode)
		{
		}

		// Token: 0x060287ED RID: 165869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287ED")]
		[Address(RVA = "0x23CF750", Offset = "0x23CE350", VA = "0x1823CF750")]
		private void _RenderPhoto(ActMultiV3ManualPhotoSelectViewModel model)
		{
		}

		// Token: 0x060287EE RID: 165870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287EE")]
		[Address(RVA = "0x23CF5D0", Offset = "0x23CE1D0", VA = "0x1823CF5D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287EF RID: 165871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287EF")]
		[Address(RVA = "0x23CFDB0", Offset = "0x23CE9B0", VA = "0x1823CFDB0")]
		public ActMultiV3PhotoSelectView()
		{
		}

		// Token: 0x04039A14 RID: 236052
		[Token(Token = "0x4039A14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x04039A15 RID: 236053
		[Token(Token = "0x4039A15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _photoLimitText;

		// Token: 0x04039A16 RID: 236054
		[Token(Token = "0x4039A16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3PhotoAvatarListAdapter _adapter;

		// Token: 0x04039A17 RID: 236055
		[Token(Token = "0x4039A17")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActMultiV3PhotoSelectNameCardView _nameCardView;

		// Token: 0x04039A18 RID: 236056
		[Token(Token = "0x4039A18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Content")]
		private ActMultiV3PhotoView _contentView;

		// Token: 0x04039A19 RID: 236057
		[Token(Token = "0x4039A19")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Content")]
		private CanvasGroup _contentCanvasGroup;

		// Token: 0x04039A1A RID: 236058
		[Token(Token = "0x4039A1A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Content")]
		private float _contentFadeDuration;

		// Token: 0x04039A1B RID: 236059
		[Token(Token = "0x4039A1B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Detail")]
		private TwoStateToggle _detailToggle;

		// Token: 0x04039A1C RID: 236060
		[Token(Token = "0x4039A1C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Detail")]
		private Text _photoDescText;

		// Token: 0x04039A1D RID: 236061
		[Token(Token = "0x4039A1D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Detail")]
		private Text _photoTimeText;

		// Token: 0x04039A1E RID: 236062
		[Token(Token = "0x4039A1E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Detail")]
		private CanvasGroup _detailCanvasGroup;

		// Token: 0x04039A1F RID: 236063
		[Token(Token = "0x4039A1F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Detail")]
		private RectTransform _detailTransform;

		// Token: 0x04039A20 RID: 236064
		[Token(Token = "0x4039A20")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Detail")]
		private Vector2 _detailHidePos;

		// Token: 0x04039A21 RID: 236065
		[Token(Token = "0x4039A21")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Detail")]
		private Vector2 _detailShowPos;

		// Token: 0x04039A22 RID: 236066
		[Token(Token = "0x4039A22")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _numberText;

		// Token: 0x04039A23 RID: 236067
		[Token(Token = "0x4039A23")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _photoTypeNameText;

		// Token: 0x04039A24 RID: 236068
		[Token(Token = "0x4039A24")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _submitPhotoPart;

		// Token: 0x04039A25 RID: 236069
		[Token(Token = "0x4039A25")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _committedPhotoPart;

		// Token: 0x04039A26 RID: 236070
		[Token(Token = "0x4039A26")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x04039A27 RID: 236071
		[Token(Token = "0x4039A27")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039A28 RID: 236072
		[Token(Token = "0x4039A28")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedInstId;

		// Token: 0x04039A29 RID: 236073
		[Token(Token = "0x4039A29")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedTemplateId;

		// Token: 0x04039A2A RID: 236074
		[Token(Token = "0x4039A2A")]
		[FieldOffset(Offset = "0xD8")]
		private int m_cachedInitSeqNum;

		// Token: 0x04039A2B RID: 236075
		[Token(Token = "0x4039A2B")]
		[FieldOffset(Offset = "0xE0")]
		private Sequence m_switchPhotoTween;

		// Token: 0x04039A2C RID: 236076
		[Token(Token = "0x4039A2C")]
		[FieldOffset(Offset = "0xE8")]
		private FadeTranslationSwitchTween m_detailTween;

		// Token: 0x04039A2D RID: 236077
		[Token(Token = "0x4039A2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039A2E RID: 236078
		[Token(Token = "0x4039A2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickShowHideDetail;

		// Token: 0x04039A2F RID: 236079
		[Token(Token = "0x4039A2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSubmitPhoto;

		// Token: 0x04039A30 RID: 236080
		[Token(Token = "0x4039A30")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickComittedPhoto;

		// Token: 0x04039A31 RID: 236081
		[Token(Token = "0x4039A31")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SwitchPhoto;

		// Token: 0x04039A32 RID: 236082
		[Token(Token = "0x4039A32")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderPhoto;

		// Token: 0x04039A33 RID: 236083
		[Token(Token = "0x4039A33")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039A34 RID: 236084
		[Token(Token = "0x4039A34")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
