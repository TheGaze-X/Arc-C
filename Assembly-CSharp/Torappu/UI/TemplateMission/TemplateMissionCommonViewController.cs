using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Skin;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D84 RID: 15748
	[Token(Token = "0x2003D84")]
	public class TemplateMissionCommonViewController : AbstractTemplateMissionViewController
	{
		// Token: 0x060187EF RID: 100335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187EF")]
		[Address(RVA = "0x110FD50", Offset = "0x110E950", VA = "0x18110FD50", Slot = "4")]
		public override void OnInit(TemplateMissionInputParam inputParam)
		{
		}

		// Token: 0x060187F0 RID: 100336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F0")]
		[Address(RVA = "0x11100F0", Offset = "0x110ECF0", VA = "0x1811100F0", Slot = "5")]
		public override void OnStateResume()
		{
		}

		// Token: 0x060187F1 RID: 100337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F1")]
		[Address(RVA = "0x110FDF0", Offset = "0x110E9F0", VA = "0x18110FDF0", Slot = "6")]
		public override void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060187F2 RID: 100338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F2")]
		[Address(RVA = "0x110FCD0", Offset = "0x110E8D0", VA = "0x18110FCD0", Slot = "7")]
		public override void BindState(TemplateMissionState state)
		{
		}

		// Token: 0x060187F3 RID: 100339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F3")]
		[Address(RVA = "0x1110200", Offset = "0x110EE00", VA = "0x181110200", Slot = "8")]
		public override void ResetEntryTween()
		{
		}

		// Token: 0x060187F4 RID: 100340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60187F4")]
		[Address(RVA = "0x1110150", Offset = "0x110ED50", VA = "0x181110150", Slot = "9")]
		public override IEnumerator PlayEntryTween()
		{
			return null;
		}

		// Token: 0x060187F5 RID: 100341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F5")]
		[Address(RVA = "0x1111630", Offset = "0x1110230", VA = "0x181111630")]
		private void _InitIfNot(TemplateMissionInputParam inputParam)
		{
		}

		// Token: 0x060187F6 RID: 100342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F6")]
		[Address(RVA = "0x1111960", Offset = "0x1110560", VA = "0x181111960")]
		private void _InitTopMenuPart()
		{
		}

		// Token: 0x060187F7 RID: 100343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F7")]
		[Address(RVA = "0x1111A30", Offset = "0x1110630", VA = "0x181111A30")]
		private void _InstViews(TemplateMissionInputParam inputParam)
		{
		}

		// Token: 0x060187F8 RID: 100344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F8")]
		[Address(RVA = "0x1111200", Offset = "0x110FE00", VA = "0x181111200")]
		private void _InitCustomResHolder(TemplateMissionInputParam inputParam)
		{
		}

		// Token: 0x060187F9 RID: 100345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187F9")]
		[Address(RVA = "0x1111360", Offset = "0x110FF60", VA = "0x181111360")]
		private void _InitCustomViewHolder(TemplateMissionInputParam inputParam)
		{
		}

		// Token: 0x060187FA RID: 100346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60187FA")]
		private T _InstView<T>(T prefab, Transform container) where T : TemplateMissionBaseView
		{
			return null;
		}

		// Token: 0x060187FB RID: 100347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187FB")]
		[Address(RVA = "0x1111430", Offset = "0x1110030", VA = "0x181111430")]
		private void _InitData(TemplateMissionInputParam inputParam)
		{
		}

		// Token: 0x060187FC RID: 100348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187FC")]
		[Address(RVA = "0x1110450", Offset = "0x110F050", VA = "0x181110450")]
		private void _BindPropToViews()
		{
		}

		// Token: 0x060187FD RID: 100349 RVA: 0x0009A9B0 File Offset: 0x00098BB0
		[Token(Token = "0x60187FD")]
		[Address(RVA = "0x1110690", Offset = "0x110F290", VA = "0x181110690")]
		private bool _CheckIfCanReact()
		{
			return default(bool);
		}

		// Token: 0x060187FE RID: 100350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187FE")]
		[Address(RVA = "0x1110850", Offset = "0x110F450", VA = "0x181110850")]
		private void _EventOnBackClick()
		{
		}

		// Token: 0x060187FF RID: 100351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187FF")]
		[Address(RVA = "0x1110A40", Offset = "0x110F640", VA = "0x181110A40")]
		private void _EventOnCharDetailClick(string charId)
		{
		}

		// Token: 0x06018800 RID: 100352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018800")]
		[Address(RVA = "0x1110B80", Offset = "0x110F780", VA = "0x181110B80")]
		private void _EventOnClaimAllClick()
		{
		}

		// Token: 0x06018801 RID: 100353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018801")]
		[Address(RVA = "0x1110DA0", Offset = "0x110F9A0", VA = "0x181110DA0")]
		private void _EventOnMissionItemClick(TemplateMissionListNormalItemViewModel missionModel)
		{
		}

		// Token: 0x06018802 RID: 100354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018802")]
		[Address(RVA = "0x1110FB0", Offset = "0x110FBB0", VA = "0x181110FB0")]
		private void _EventOnSkinDetailBtnClicked(CharUISkinStruct skinStruct)
		{
		}

		// Token: 0x06018803 RID: 100355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018803")]
		[Address(RVA = "0x1111F20", Offset = "0x1110B20", VA = "0x181111F20")]
		private void _OnConfirmCallBack(List<RewardItemModel> rewardList)
		{
		}

		// Token: 0x06018804 RID: 100356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018804")]
		[Address(RVA = "0x1111E00", Offset = "0x1110A00", VA = "0x181111E00")]
		private void _OnActConfirmAllMissionServiceSuccess(TemplateMissionCommonConfirmResponse response)
		{
		}

		// Token: 0x06018805 RID: 100357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018805")]
		[Address(RVA = "0x1111E90", Offset = "0x1110A90", VA = "0x181111E90")]
		private void _OnActConfirmMissionServiceSuccess(TemplateMissionCommonConfirmResponse response)
		{
		}

		// Token: 0x06018806 RID: 100358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018806")]
		[Address(RVA = "0x11121F0", Offset = "0x1110DF0", VA = "0x1811121F0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x06018807 RID: 100359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018807")]
		[Address(RVA = "0x11122B0", Offset = "0x1110EB0", VA = "0x1811122B0")]
		public TemplateMissionCommonViewController()
		{
		}

		// Token: 0x0401E035 RID: 122933
		[Token(Token = "0x401E035")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401E036 RID: 122934
		[Token(Token = "0x401E036")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _bigRewardViewContainer;

		// Token: 0x0401E037 RID: 122935
		[Token(Token = "0x401E037")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _missionTitleViewContainer;

		// Token: 0x0401E038 RID: 122936
		[Token(Token = "0x401E038")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _coinInfoViewContainer;

		// Token: 0x0401E039 RID: 122937
		[Token(Token = "0x401E039")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _missionListViewContainer;

		// Token: 0x0401E03A RID: 122938
		[Token(Token = "0x401E03A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _bgViewContainer;

		// Token: 0x0401E03B RID: 122939
		[Token(Token = "0x401E03B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SkinPreviewPanel _previewPanelPrefab;

		// Token: 0x0401E03C RID: 122940
		[Token(Token = "0x401E03C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _previewPanelContainer;

		// Token: 0x0401E03D RID: 122941
		[Token(Token = "0x401E03D")]
		[FieldOffset(Offset = "0x58")]
		private TemplateMissionBigRewardView m_bigRewardView;

		// Token: 0x0401E03E RID: 122942
		[Token(Token = "0x401E03E")]
		[FieldOffset(Offset = "0x60")]
		private TemplateMissionTitleView m_titleView;

		// Token: 0x0401E03F RID: 122943
		[Token(Token = "0x401E03F")]
		[FieldOffset(Offset = "0x68")]
		private TemplateMissionCoinInfoView m_coinInfoView;

		// Token: 0x0401E040 RID: 122944
		[Token(Token = "0x401E040")]
		[FieldOffset(Offset = "0x70")]
		private TemplateMissionListView m_listView;

		// Token: 0x0401E041 RID: 122945
		[Token(Token = "0x401E041")]
		[FieldOffset(Offset = "0x78")]
		private TemplateMissionBgView m_bgView;

		// Token: 0x0401E042 RID: 122946
		[Token(Token = "0x401E042")]
		[FieldOffset(Offset = "0x80")]
		private TemplateMissionCustomResHolder m_customResHolder;

		// Token: 0x0401E043 RID: 122947
		[Token(Token = "0x401E043")]
		[FieldOffset(Offset = "0x88")]
		private TemplateMissionCustomViewHolder m_customViewHolder;

		// Token: 0x0401E044 RID: 122948
		[Token(Token = "0x401E044")]
		[FieldOffset(Offset = "0x90")]
		private SkinPreviewPanel m_previewPanel;

		// Token: 0x0401E045 RID: 122949
		[Token(Token = "0x401E045")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0401E046 RID: 122950
		[Token(Token = "0x401E046")]
		[FieldOffset(Offset = "0xA0")]
		private List<TemplateMissionBaseView> m_views;

		// Token: 0x0401E047 RID: 122951
		[Token(Token = "0x401E047")]
		[FieldOffset(Offset = "0xA8")]
		private TemplateMissionState m_bindState;

		// Token: 0x0401E048 RID: 122952
		[Token(Token = "0x401E048")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401E049 RID: 122953
		[Token(Token = "0x401E049")]
		[FieldOffset(Offset = "0xC0")]
		private Sequence m_viewTweenSequence;

		// Token: 0x0401E04A RID: 122954
		[Token(Token = "0x401E04A")]
		[FieldOffset(Offset = "0xC8")]
		private TemplateMissionInputParam m_inputParam;

		// Token: 0x0401E04B RID: 122955
		[Token(Token = "0x401E04B")]
		[NonSerialized]
		public const int MSG_CHAR_DETAIL_CLICKED = 0;

		// Token: 0x0401E04C RID: 122956
		[Token(Token = "0x401E04C")]
		[NonSerialized]
		public const int MSG_CLAIM_ALL_BTN_CLICKED = 1;

		// Token: 0x0401E04D RID: 122957
		[Token(Token = "0x401E04D")]
		[NonSerialized]
		public const int MSG_MISSION_ITEM_CLICKED = 2;

		// Token: 0x0401E04E RID: 122958
		[Token(Token = "0x401E04E")]
		[NonSerialized]
		public const int MSG_SKIN_DETAIL_BTN_CLICKED = 3;

		// Token: 0x0401E04F RID: 122959
		[Token(Token = "0x401E04F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401E050 RID: 122960
		[Token(Token = "0x401E050")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateResume;

		// Token: 0x0401E051 RID: 122961
		[Token(Token = "0x401E051")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401E052 RID: 122962
		[Token(Token = "0x401E052")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BindState;

		// Token: 0x0401E053 RID: 122963
		[Token(Token = "0x401E053")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetEntryTween;

		// Token: 0x0401E054 RID: 122964
		[Token(Token = "0x401E054")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayEntryTween;

		// Token: 0x0401E055 RID: 122965
		[Token(Token = "0x401E055")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E056 RID: 122966
		[Token(Token = "0x401E056")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitTopMenuPart;

		// Token: 0x0401E057 RID: 122967
		[Token(Token = "0x401E057")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InstViews;

		// Token: 0x0401E058 RID: 122968
		[Token(Token = "0x401E058")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitCustomResHolder;

		// Token: 0x0401E059 RID: 122969
		[Token(Token = "0x401E059")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitCustomViewHolder;

		// Token: 0x0401E05A RID: 122970
		[Token(Token = "0x401E05A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InstView;

		// Token: 0x0401E05B RID: 122971
		[Token(Token = "0x401E05B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0401E05C RID: 122972
		[Token(Token = "0x401E05C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__BindPropToViews;

		// Token: 0x0401E05D RID: 122973
		[Token(Token = "0x401E05D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIfCanReact;

		// Token: 0x0401E05E RID: 122974
		[Token(Token = "0x401E05E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnBackClick;

		// Token: 0x0401E05F RID: 122975
		[Token(Token = "0x401E05F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnCharDetailClick;

		// Token: 0x0401E060 RID: 122976
		[Token(Token = "0x401E060")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnClaimAllClick;

		// Token: 0x0401E061 RID: 122977
		[Token(Token = "0x401E061")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnMissionItemClick;

		// Token: 0x0401E062 RID: 122978
		[Token(Token = "0x401E062")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EventOnSkinDetailBtnClicked;

		// Token: 0x0401E063 RID: 122979
		[Token(Token = "0x401E063")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnConfirmCallBack;

		// Token: 0x0401E064 RID: 122980
		[Token(Token = "0x401E064")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnActConfirmAllMissionServiceSuccess;

		// Token: 0x0401E065 RID: 122981
		[Token(Token = "0x401E065")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnActConfirmMissionServiceSuccess;

		// Token: 0x0401E066 RID: 122982
		[Token(Token = "0x401E066")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0401E067 RID: 122983
		[Token(Token = "0x401E067")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
