using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075D6 RID: 30166
	[Token(Token = "0x20075D6")]
	public class Act24sideMissionDetailView : DataBinder<Act24sideMissionDetailProp>
	{
		// Token: 0x0602A792 RID: 173970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A792")]
		[Address(RVA = "0x2625D90", Offset = "0x2624990", VA = "0x182625D90", Slot = "7")]
		public override void OnValueChanged(Act24sideMissionDetailProp property)
		{
		}

		// Token: 0x0602A793 RID: 173971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A793")]
		[Address(RVA = "0x2626410", Offset = "0x2625010", VA = "0x182626410")]
		private void _Render()
		{
		}

		// Token: 0x0602A794 RID: 173972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A794")]
		[Address(RVA = "0x2626890", Offset = "0x2625490", VA = "0x182626890")]
		private void _UpdateArrowDisplay()
		{
		}

		// Token: 0x0602A795 RID: 173973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A795")]
		[Address(RVA = "0x2625F10", Offset = "0x2624B10", VA = "0x182625F10")]
		private void _MoveLeft()
		{
		}

		// Token: 0x0602A796 RID: 173974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A796")]
		[Address(RVA = "0x2626190", Offset = "0x2624D90", VA = "0x182626190")]
		private void _MoveRight()
		{
		}

		// Token: 0x0602A797 RID: 173975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A797")]
		[Address(RVA = "0x26267B0", Offset = "0x26253B0", VA = "0x1826267B0")]
		private void _SetBtnStateEnable()
		{
		}

		// Token: 0x0602A798 RID: 173976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A798")]
		[Address(RVA = "0x2626820", Offset = "0x2625420", VA = "0x182626820")]
		private void _SetBtnStateUnable()
		{
		}

		// Token: 0x0602A799 RID: 173977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A799")]
		[Address(RVA = "0x2625C90", Offset = "0x2624890", VA = "0x182625C90")]
		public void OnClickLeftArrow()
		{
		}

		// Token: 0x0602A79A RID: 173978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A79A")]
		[Address(RVA = "0x2625D10", Offset = "0x2624910", VA = "0x182625D10")]
		public void OnClickRightArrow()
		{
		}

		// Token: 0x0602A79B RID: 173979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A79B")]
		[Address(RVA = "0x2625BF0", Offset = "0x26247F0", VA = "0x182625BF0")]
		public void OnClickCompleteBtn()
		{
		}

		// Token: 0x0602A79C RID: 173980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A79C")]
		[Address(RVA = "0x2626920", Offset = "0x2625520", VA = "0x182626920")]
		public Act24sideMissionDetailView()
		{
		}

		// Token: 0x0403D1FD RID: 250365
		[Token(Token = "0x403D1FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bigLogoHunter;

		// Token: 0x0403D1FE RID: 250366
		[Token(Token = "0x403D1FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _bigLogoCollection;

		// Token: 0x0403D1FF RID: 250367
		[Token(Token = "0x403D1FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bigLogoExploration;

		// Token: 0x0403D200 RID: 250368
		[Token(Token = "0x403D200")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _completeBtn;

		// Token: 0x0403D201 RID: 250369
		[Token(Token = "0x403D201")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _missionContent;

		// Token: 0x0403D202 RID: 250370
		[Token(Token = "0x403D202")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _missionTitle;

		// Token: 0x0403D203 RID: 250371
		[Token(Token = "0x403D203")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _missionDesc;

		// Token: 0x0403D204 RID: 250372
		[Token(Token = "0x403D204")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _missionClient;

		// Token: 0x0403D205 RID: 250373
		[Token(Token = "0x403D205")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _missionClientDesc;

		// Token: 0x0403D206 RID: 250374
		[Token(Token = "0x403D206")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act24sideMissionStampView _stampView;

		// Token: 0x0403D207 RID: 250375
		[Token(Token = "0x403D207")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act24sideMissionAbstractDelegateTileView _titleView;

		// Token: 0x0403D208 RID: 250376
		[Token(Token = "0x403D208")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act24sideMissionRewardListView _rewardListView;

		// Token: 0x0403D209 RID: 250377
		[Token(Token = "0x403D209")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _leftAnimationLocation;

		// Token: 0x0403D20A RID: 250378
		[Token(Token = "0x403D20A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _rightAnimationLocation;

		// Token: 0x0403D20B RID: 250379
		[Token(Token = "0x403D20B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _renderDelay;

		// Token: 0x0403D20C RID: 250380
		[Token(Token = "0x403D20C")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Color _missionHunterContentColor;

		// Token: 0x0403D20D RID: 250381
		[Token(Token = "0x403D20D")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Color _missionCollectionContentColor;

		// Token: 0x0403D20E RID: 250382
		[Token(Token = "0x403D20E")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private Color _missionExplorationContentColor;

		// Token: 0x0403D20F RID: 250383
		[Token(Token = "0x403D20F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _leftArrow;

		// Token: 0x0403D210 RID: 250384
		[Token(Token = "0x403D210")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _rightArrow;

		// Token: 0x0403D211 RID: 250385
		[Token(Token = "0x403D211")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Button _leftBtn;

		// Token: 0x0403D212 RID: 250386
		[Token(Token = "0x403D212")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Button _rightBtn;

		// Token: 0x0403D213 RID: 250387
		[Token(Token = "0x403D213")]
		[FieldOffset(Offset = "0xF8")]
		private string m_missionId;

		// Token: 0x0403D214 RID: 250388
		[Token(Token = "0x403D214")]
		[FieldOffset(Offset = "0x100")]
		private int m_cachePos;

		// Token: 0x0403D215 RID: 250389
		[Token(Token = "0x403D215")]
		[FieldOffset(Offset = "0x104")]
		private int m_missionTotalCnt;

		// Token: 0x0403D216 RID: 250390
		[Token(Token = "0x403D216")]
		[FieldOffset(Offset = "0x108")]
		private int m_sequenceNum;

		// Token: 0x0403D217 RID: 250391
		[Token(Token = "0x403D217")]
		[FieldOffset(Offset = "0x110")]
		private Sequence m_moveSequence;

		// Token: 0x0403D218 RID: 250392
		[Token(Token = "0x403D218")]
		[FieldOffset(Offset = "0x118")]
		private Act24sideMissionViewModel m_cacheModel;

		// Token: 0x0403D219 RID: 250393
		[Token(Token = "0x403D219")]
		[FieldOffset(Offset = "0x120")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403D21A RID: 250394
		[Token(Token = "0x403D21A")]
		[FieldOffset(Offset = "0x130")]
		[NonSerialized]
		public Action<string> onClickCompleteBtn;

		// Token: 0x0403D21B RID: 250395
		[Token(Token = "0x403D21B")]
		[FieldOffset(Offset = "0x138")]
		[NonSerialized]
		public Action onClickLeftArrowBtn;

		// Token: 0x0403D21C RID: 250396
		[Token(Token = "0x403D21C")]
		[FieldOffset(Offset = "0x140")]
		[NonSerialized]
		public Action onClickRightArrowBtn;

		// Token: 0x0403D21D RID: 250397
		[Token(Token = "0x403D21D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403D21E RID: 250398
		[Token(Token = "0x403D21E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403D21F RID: 250399
		[Token(Token = "0x403D21F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateArrowDisplay;

		// Token: 0x0403D220 RID: 250400
		[Token(Token = "0x403D220")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__MoveLeft;

		// Token: 0x0403D221 RID: 250401
		[Token(Token = "0x403D221")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__MoveRight;

		// Token: 0x0403D222 RID: 250402
		[Token(Token = "0x403D222")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetBtnStateEnable;

		// Token: 0x0403D223 RID: 250403
		[Token(Token = "0x403D223")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetBtnStateUnable;

		// Token: 0x0403D224 RID: 250404
		[Token(Token = "0x403D224")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickLeftArrow;

		// Token: 0x0403D225 RID: 250405
		[Token(Token = "0x403D225")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClickRightArrow;

		// Token: 0x0403D226 RID: 250406
		[Token(Token = "0x403D226")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClickCompleteBtn;

		// Token: 0x0403D227 RID: 250407
		[Token(Token = "0x403D227")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
