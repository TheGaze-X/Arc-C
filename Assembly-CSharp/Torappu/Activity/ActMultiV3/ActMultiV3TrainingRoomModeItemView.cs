using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007013 RID: 28691
	[Token(Token = "0x2007013")]
	public class ActMultiV3TrainingRoomModeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028B90 RID: 166800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B90")]
		[Address(RVA = "0x2415A70", Offset = "0x2414670", VA = "0x182415A70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028B91 RID: 166801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B91")]
		[Address(RVA = "0x24155F0", Offset = "0x24141F0", VA = "0x1824155F0")]
		public void Render(ActMultiV3TrainingRoomModeViewModel viewModel, ActMultiV3TrainingRoomViewModel roomViewModel)
		{
		}

		// Token: 0x06028B92 RID: 166802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B92")]
		[Address(RVA = "0x2415500", Offset = "0x2414100", VA = "0x182415500")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x06028B93 RID: 166803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B93")]
		[Address(RVA = "0x2415B80", Offset = "0x2414780", VA = "0x182415B80")]
		public ActMultiV3TrainingRoomModeItemView()
		{
		}

		// Token: 0x0403A0FB RID: 237819
		[Token(Token = "0x403A0FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x0403A0FC RID: 237820
		[Token(Token = "0x403A0FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgModeIconLocked;

		// Token: 0x0403A0FD RID: 237821
		[Token(Token = "0x403A0FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLockedDesc;

		// Token: 0x0403A0FE RID: 237822
		[Token(Token = "0x403A0FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animSelected;

		// Token: 0x0403A0FF RID: 237823
		[Token(Token = "0x403A0FF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgModeIcon;

		// Token: 0x0403A100 RID: 237824
		[Token(Token = "0x403A100")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textModeName;

		// Token: 0x0403A101 RID: 237825
		[Token(Token = "0x403A101")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgSelected;

		// Token: 0x0403A102 RID: 237826
		[Token(Token = "0x403A102")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imgSelectedGlow;

		// Token: 0x0403A103 RID: 237827
		[Token(Token = "0x403A103")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgModeIconSelected;

		// Token: 0x0403A104 RID: 237828
		[Token(Token = "0x403A104")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403A105 RID: 237829
		[Token(Token = "0x403A105")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0403A106 RID: 237830
		[Token(Token = "0x403A106")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_selectedTween;

		// Token: 0x0403A107 RID: 237831
		[Token(Token = "0x403A107")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedInitSeq;

		// Token: 0x0403A108 RID: 237832
		[Token(Token = "0x403A108")]
		[FieldOffset(Offset = "0x84")]
		private ActMultiV3MapModeType m_cachedModeType;

		// Token: 0x0403A109 RID: 237833
		[Token(Token = "0x403A109")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403A10A RID: 237834
		[Token(Token = "0x403A10A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A10B RID: 237835
		[Token(Token = "0x403A10B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A10C RID: 237836
		[Token(Token = "0x403A10C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0403A10D RID: 237837
		[Token(Token = "0x403A10D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
