using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E6B RID: 20075
	[Token(Token = "0x2004E6B")]
	public class FireworkPuzzleDetailView : DataBinder<FireworkPuzzleDetailProp>
	{
		// Token: 0x0601DF67 RID: 122727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF67")]
		[Address(RVA = "0x17A6B30", Offset = "0x17A5730", VA = "0x1817A6B30", Slot = "7")]
		public override void OnValueChanged(FireworkPuzzleDetailProp property)
		{
		}

		// Token: 0x0601DF68 RID: 122728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF68")]
		[Address(RVA = "0x17A82C0", Offset = "0x17A6EC0", VA = "0x1817A82C0")]
		private void _UpdateHintPin(FireworkPuzzleDetailModel detailModel)
		{
		}

		// Token: 0x0601DF69 RID: 122729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF69")]
		[Address(RVA = "0x17A7F80", Offset = "0x17A6B80", VA = "0x1817A7F80")]
		private void _PlayEnterAnimIfNeed(FireworkPuzzleDetailModel detailModel)
		{
		}

		// Token: 0x0601DF6A RID: 122730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF6A")]
		[Address(RVA = "0x17A7330", Offset = "0x17A5F30", VA = "0x1817A7330")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DF6B RID: 122731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF6B")]
		[Address(RVA = "0x17A80F0", Offset = "0x17A6CF0", VA = "0x1817A80F0")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x0601DF6C RID: 122732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF6C")]
		[Address(RVA = "0x17A8490", Offset = "0x17A7090", VA = "0x1817A8490")]
		public FireworkPuzzleDetailView()
		{
		}

		// Token: 0x04027C7E RID: 162942
		[Token(Token = "0x4027C7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _plateContainer;

		// Token: 0x04027C7F RID: 162943
		[Token(Token = "0x4027C7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _selectionContainer;

		// Token: 0x04027C80 RID: 162944
		[Token(Token = "0x4027C80")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _plateListContainer;

		// Token: 0x04027C81 RID: 162945
		[Token(Token = "0x4027C81")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _plateFillContainer;

		// Token: 0x04027C82 RID: 162946
		[Token(Token = "0x4027C82")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _bgContainer;

		// Token: 0x04027C83 RID: 162947
		[Token(Token = "0x4027C83")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _bgParticleEffectContainer;

		// Token: 0x04027C84 RID: 162948
		[Token(Token = "0x4027C84")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x04027C85 RID: 162949
		[Token(Token = "0x4027C85")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FireworkGroupListRaycastLayer _pnlRaycastLayer;

		// Token: 0x04027C86 RID: 162950
		[Token(Token = "0x4027C86")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private FireworkPuzzleNpcView _npcView;

		// Token: 0x04027C87 RID: 162951
		[Token(Token = "0x4027C87")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04027C88 RID: 162952
		[Token(Token = "0x4027C88")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color _colorItemGot;

		// Token: 0x04027C89 RID: 162953
		[Token(Token = "0x4027C89")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _itemGotPartGo;

		// Token: 0x04027C8A RID: 162954
		[Token(Token = "0x4027C8A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _btnHintGo;

		// Token: 0x04027C8B RID: 162955
		[Token(Token = "0x4027C8B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textHintCount;

		// Token: 0x04027C8C RID: 162956
		[Token(Token = "0x4027C8C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _puzzleCompleteGo;

		// Token: 0x04027C8D RID: 162957
		[Token(Token = "0x4027C8D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04027C8E RID: 162958
		[Token(Token = "0x4027C8E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _animBtnConfirm;

		// Token: 0x04027C8F RID: 162959
		[Token(Token = "0x4027C8F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation[] _hintPinAnimList;

		// Token: 0x04027C90 RID: 162960
		[Token(Token = "0x4027C90")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIColorGraphic _btnHintGraphic;

		// Token: 0x04027C91 RID: 162961
		[Token(Token = "0x4027C91")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Color _colorBtnHintGrey;

		// Token: 0x04027C92 RID: 162962
		[Token(Token = "0x4027C92")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _puzzlePlateGo;

		// Token: 0x04027C93 RID: 162963
		[Token(Token = "0x4027C93")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _btnConfirmGo;

		// Token: 0x04027C94 RID: 162964
		[Token(Token = "0x4027C94")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _plateListGo;

		// Token: 0x04027C95 RID: 162965
		[Token(Token = "0x4027C95")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _plateFillGo;

		// Token: 0x04027C96 RID: 162966
		[Token(Token = "0x4027C96")]
		[FieldOffset(Offset = "0x100")]
		private bool m_hasInited;

		// Token: 0x04027C97 RID: 162967
		[Token(Token = "0x4027C97")]
		[FieldOffset(Offset = "0x108")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04027C98 RID: 162968
		[Token(Token = "0x4027C98")]
		[FieldOffset(Offset = "0x118")]
		private FireworkPlateViewStyle m_plateStyle;

		// Token: 0x04027C99 RID: 162969
		[Token(Token = "0x4027C99")]
		[FieldOffset(Offset = "0x120")]
		private FireworkPlateGroupViewStyle m_plateGroupStyle;

		// Token: 0x04027C9A RID: 162970
		[Token(Token = "0x4027C9A")]
		[FieldOffset(Offset = "0x128")]
		private FireworkPlateView m_plateView;

		// Token: 0x04027C9B RID: 162971
		[Token(Token = "0x4027C9B")]
		[FieldOffset(Offset = "0x130")]
		private FireworkPlateSelectionView m_selectionView;

		// Token: 0x04027C9C RID: 162972
		[Token(Token = "0x4027C9C")]
		[FieldOffset(Offset = "0x138")]
		private FireworkPlateListView m_plateListView;

		// Token: 0x04027C9D RID: 162973
		[Token(Token = "0x4027C9D")]
		[FieldOffset(Offset = "0x140")]
		private FireworkPlateFilledListView m_plateFillView;

		// Token: 0x04027C9E RID: 162974
		[Token(Token = "0x4027C9E")]
		[FieldOffset(Offset = "0x148")]
		private UIItemCard m_rewardItem;

		// Token: 0x04027C9F RID: 162975
		[Token(Token = "0x4027C9F")]
		[FieldOffset(Offset = "0x150")]
		private int m_cacheEnterSeqNum;

		// Token: 0x04027CA0 RID: 162976
		[Token(Token = "0x4027CA0")]
		[FieldOffset(Offset = "0x158")]
		private Tween m_enterTween;

		// Token: 0x04027CA1 RID: 162977
		[Token(Token = "0x4027CA1")]
		[FieldOffset(Offset = "0x160")]
		private AnimationSwitchTween m_btnConfirmTween;

		// Token: 0x04027CA2 RID: 162978
		[Token(Token = "0x4027CA2")]
		[FieldOffset(Offset = "0x168")]
		private List<AnimationSwitchTween> m_hintPinTweenList;

		// Token: 0x04027CA3 RID: 162979
		[Token(Token = "0x4027CA3")]
		[FieldOffset(Offset = "0x170")]
		private int m_cacheHintSeqNum;

		// Token: 0x04027CA4 RID: 162980
		[Token(Token = "0x4027CA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027CA5 RID: 162981
		[Token(Token = "0x4027CA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateHintPin;

		// Token: 0x04027CA6 RID: 162982
		[Token(Token = "0x4027CA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayEnterAnimIfNeed;

		// Token: 0x04027CA7 RID: 162983
		[Token(Token = "0x4027CA7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027CA8 RID: 162984
		[Token(Token = "0x4027CA8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x04027CA9 RID: 162985
		[Token(Token = "0x4027CA9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
