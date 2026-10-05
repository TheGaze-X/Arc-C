using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D21 RID: 15649
	[Token(Token = "0x2003D21")]
	public class TrainingCampStageSelectView : DataBinder<TrainingCampStageSelectProperty>
	{
		// Token: 0x06018641 RID: 99905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018641")]
		[Address(RVA = "0x10D7000", Offset = "0x10D5C00", VA = "0x1810D7000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018642 RID: 99906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018642")]
		[Address(RVA = "0x10D6700", Offset = "0x10D5300", VA = "0x1810D6700", Slot = "7")]
		public override void OnValueChanged(TrainingCampStageSelectProperty property)
		{
		}

		// Token: 0x06018643 RID: 99907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018643")]
		[Address(RVA = "0x10D6BB0", Offset = "0x10D57B0", VA = "0x1810D6BB0")]
		public void OpenMapTips()
		{
		}

		// Token: 0x06018644 RID: 99908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018644")]
		[Address(RVA = "0x10D6690", Offset = "0x10D5290", VA = "0x1810D6690")]
		public void CloseMapTips()
		{
		}

		// Token: 0x06018645 RID: 99909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018645")]
		[Address(RVA = "0x10D6E60", Offset = "0x10D5A60", VA = "0x1810D6E60")]
		private void _FoucsIfNeeded()
		{
		}

		// Token: 0x06018646 RID: 99910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018646")]
		[Address(RVA = "0x10D7280", Offset = "0x10D5E80", VA = "0x1810D7280")]
		private void _RenderReward(bool isGained)
		{
		}

		// Token: 0x06018647 RID: 99911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018647")]
		[Address(RVA = "0x10D6D60", Offset = "0x10D5960", VA = "0x1810D6D60")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x06018648 RID: 99912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018648")]
		[Address(RVA = "0x10D7610", Offset = "0x10D6210", VA = "0x1810D7610")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x06018649 RID: 99913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018649")]
		[Address(RVA = "0x10D7680", Offset = "0x10D6280", VA = "0x1810D7680")]
		public TrainingCampStageSelectView()
		{
		}

		// Token: 0x0401DD3C RID: 122172
		[Token(Token = "0x401DD3C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TrainingCampStageListAdapter _adapter;

		// Token: 0x0401DD3D RID: 122173
		[Token(Token = "0x401DD3D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _stageIconImg;

		// Token: 0x0401DD3E RID: 122174
		[Token(Token = "0x401DD3E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _stageBigIconImg;

		// Token: 0x0401DD3F RID: 122175
		[Token(Token = "0x401DD3F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stageDescText;

		// Token: 0x0401DD40 RID: 122176
		[Token(Token = "0x401DD40")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _stageNameText;

		// Token: 0x0401DD41 RID: 122177
		[Token(Token = "0x401DD41")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIDynImage _stageMapPreviewImg;

		// Token: 0x0401DD42 RID: 122178
		[Token(Token = "0x401DD42")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _stageProgressText;

		// Token: 0x0401DD43 RID: 122179
		[Token(Token = "0x401DD43")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _rewardContainer;

		// Token: 0x0401DD44 RID: 122180
		[Token(Token = "0x401DD44")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _rewardScale;

		// Token: 0x0401DD45 RID: 122181
		[Token(Token = "0x401DD45")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _mapTipsObj;

		// Token: 0x0401DD46 RID: 122182
		[Token(Token = "0x401DD46")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _mapTipsBlur;

		// Token: 0x0401DD47 RID: 122183
		[Token(Token = "0x401DD47")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIDynImage _mapTipsImg;

		// Token: 0x0401DD48 RID: 122184
		[Token(Token = "0x401DD48")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _rewardCanvasGroup;

		// Token: 0x0401DD49 RID: 122185
		[Token(Token = "0x401DD49")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _gainedRewardAlpha;

		// Token: 0x0401DD4A RID: 122186
		[Token(Token = "0x401DD4A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _gainedRewardObj;

		// Token: 0x0401DD4B RID: 122187
		[Token(Token = "0x401DD4B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UILayoutDimensionListener _layoutListener;

		// Token: 0x0401DD4C RID: 122188
		[Token(Token = "0x401DD4C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _listViewRect;

		// Token: 0x0401DD4D RID: 122189
		[Token(Token = "0x401DD4D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GridLayoutGroup _listGridLayout;

		// Token: 0x0401DD4E RID: 122190
		[Token(Token = "0x401DD4E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0401DD4F RID: 122191
		[Token(Token = "0x401DD4F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0401DD50 RID: 122192
		[Token(Token = "0x401DD50")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x0401DD51 RID: 122193
		[Token(Token = "0x401DD51")]
		[FieldOffset(Offset = "0xD8")]
		private TrainingCampStageSelectViewModel m_cachedViewModel;

		// Token: 0x0401DD52 RID: 122194
		[Token(Token = "0x401DD52")]
		[FieldOffset(Offset = "0xE0")]
		private TrainingCampStageListItemViewModel m_cachedStageViewModel;

		// Token: 0x0401DD53 RID: 122195
		[Token(Token = "0x401DD53")]
		[FieldOffset(Offset = "0xE8")]
		private UIItemCard m_rewardItemCard;

		// Token: 0x0401DD54 RID: 122196
		[Token(Token = "0x401DD54")]
		[FieldOffset(Offset = "0xF0")]
		private UIItemViewModel m_rewardItemModel;

		// Token: 0x0401DD55 RID: 122197
		[Token(Token = "0x401DD55")]
		[FieldOffset(Offset = "0xF8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401DD56 RID: 122198
		[Token(Token = "0x401DD56")]
		[FieldOffset(Offset = "0x108")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0401DD57 RID: 122199
		[Token(Token = "0x401DD57")]
		[FieldOffset(Offset = "0x110")]
		private int m_cachedFocusSeqNum;

		// Token: 0x0401DD58 RID: 122200
		[Token(Token = "0x401DD58")]
		[FieldOffset(Offset = "0x118")]
		private AnimationSwitchTween m_enterTween;

		// Token: 0x0401DD59 RID: 122201
		[Token(Token = "0x401DD59")]
		[FieldOffset(Offset = "0x120")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x0401DD5A RID: 122202
		[Token(Token = "0x401DD5A")]
		[FieldOffset(Offset = "0x128")]
		private int m_cachedSelectIdx;

		// Token: 0x0401DD5B RID: 122203
		[Token(Token = "0x401DD5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DD5C RID: 122204
		[Token(Token = "0x401DD5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401DD5D RID: 122205
		[Token(Token = "0x401DD5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenMapTips;

		// Token: 0x0401DD5E RID: 122206
		[Token(Token = "0x401DD5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CloseMapTips;

		// Token: 0x0401DD5F RID: 122207
		[Token(Token = "0x401DD5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FoucsIfNeeded;

		// Token: 0x0401DD60 RID: 122208
		[Token(Token = "0x401DD60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderReward;

		// Token: 0x0401DD61 RID: 122209
		[Token(Token = "0x401DD61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x0401DD62 RID: 122210
		[Token(Token = "0x401DD62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x0401DD63 RID: 122211
		[Token(Token = "0x401DD63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
