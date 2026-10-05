using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200798E RID: 31118
	[Token(Token = "0x200798E")]
	public class Act1ArcadeStageDetailView : DataBinder<Act1ArcadeStageSelectProperty>
	{
		// Token: 0x0602BA95 RID: 178837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA95")]
		[Address(RVA = "0x278B0E0", Offset = "0x2789CE0", VA = "0x18278B0E0", Slot = "7")]
		public override void OnValueChanged(Act1ArcadeStageSelectProperty property)
		{
		}

		// Token: 0x0602BA96 RID: 178838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA96")]
		[Address(RVA = "0x278B720", Offset = "0x278A320", VA = "0x18278B720")]
		private void _RenderStageBasicInfo(Act1ArcadeSingleStageModel stageModel)
		{
		}

		// Token: 0x0602BA97 RID: 178839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA97")]
		[Address(RVA = "0x278BAA0", Offset = "0x278A6A0", VA = "0x18278BAA0")]
		private void _ShowStageInfoPrefab(string actId, Act1ArcadeSingleZoneModel zoneModel)
		{
		}

		// Token: 0x0602BA98 RID: 178840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA98")]
		[Address(RVA = "0x278B390", Offset = "0x2789F90", VA = "0x18278B390")]
		private void _RenderScoreInfo(Act1ArcadeSingleStageModel stageModel)
		{
		}

		// Token: 0x0602BA99 RID: 178841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA99")]
		[Address(RVA = "0x278AF00", Offset = "0x2789B00", VA = "0x18278AF00")]
		public void EventOnClickEnemyHandBook()
		{
		}

		// Token: 0x0602BA9A RID: 178842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA9A")]
		[Address(RVA = "0x278AFA0", Offset = "0x2789BA0", VA = "0x18278AFA0")]
		public void EventOnClickMap()
		{
		}

		// Token: 0x0602BA9B RID: 178843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA9B")]
		[Address(RVA = "0x278B040", Offset = "0x2789C40", VA = "0x18278B040")]
		public void EventOnClickScoreInfo()
		{
		}

		// Token: 0x0602BA9C RID: 178844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA9C")]
		[Address(RVA = "0x278BD20", Offset = "0x278A920", VA = "0x18278BD20")]
		public Act1ArcadeStageDetailView()
		{
		}

		// Token: 0x0403F28B RID: 258699
		[Token(Token = "0x403F28B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _stageInfoPrefabHolder;

		// Token: 0x0403F28C RID: 258700
		[Token(Token = "0x403F28C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("StageBasicInfo")]
		private Text _textRecommendLevel;

		// Token: 0x0403F28D RID: 258701
		[Token(Token = "0x403F28D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("StageBasicInfo")]
		private Text _textStageName;

		// Token: 0x0403F28E RID: 258702
		[Token(Token = "0x403F28E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("StageBasicInfo")]
		private Text _textStageSubName;

		// Token: 0x0403F28F RID: 258703
		[Token(Token = "0x403F28F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("StageBasicInfo")]
		private Text _textStageDesc;

		// Token: 0x0403F290 RID: 258704
		[Token(Token = "0x403F290")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("StageBasicInfo")]
		private Text _textStageMechDesc;

		// Token: 0x0403F291 RID: 258705
		[Token(Token = "0x403F291")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("StageBasicInfo")]
		private ScrollRect _scrollStageDesc;

		// Token: 0x0403F292 RID: 258706
		[Token(Token = "0x403F292")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("StageBasicInfo")]
		private Act1ArcadeGameObjectSwitchComp _stageIndexSwitch;

		// Token: 0x0403F293 RID: 258707
		[Token(Token = "0x403F293")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Score")]
		private Image _imgMaxRank;

		// Token: 0x0403F294 RID: 258708
		[Token(Token = "0x403F294")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Score")]
		private Text _textMaxScore;

		// Token: 0x0403F295 RID: 258709
		[Token(Token = "0x403F295")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Score")]
		private Button _btnScoreDetail;

		// Token: 0x0403F296 RID: 258710
		[Token(Token = "0x403F296")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Score")]
		private TwoStateToggle _scoreStateToggle;

		// Token: 0x0403F297 RID: 258711
		[Token(Token = "0x403F297")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Score")]
		private UIAnimationLocation _stageChangeAnim;

		// Token: 0x0403F298 RID: 258712
		[Token(Token = "0x403F298")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _btnEnemyHandBook;

		// Token: 0x0403F299 RID: 258713
		[Token(Token = "0x403F299")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button _btnMap;

		// Token: 0x0403F29A RID: 258714
		[Token(Token = "0x403F29A")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403F29B RID: 258715
		[Token(Token = "0x403F29B")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403F29C RID: 258716
		[Token(Token = "0x403F29C")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<string, GameObject> m_catchedZoneInfoDict;

		// Token: 0x0403F29D RID: 258717
		[Token(Token = "0x403F29D")]
		[FieldOffset(Offset = "0xC8")]
		private string m_curShowZoneInfoZoneId;

		// Token: 0x0403F29E RID: 258718
		[Token(Token = "0x403F29E")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isZoneIdChange;

		// Token: 0x0403F29F RID: 258719
		[Token(Token = "0x403F29F")]
		[FieldOffset(Offset = "0xD8")]
		private string m_curShowStageId;

		// Token: 0x0403F2A0 RID: 258720
		[Token(Token = "0x403F2A0")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isStageIdChange;

		// Token: 0x0403F2A1 RID: 258721
		[Token(Token = "0x403F2A1")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_stageChangeAnimTween;

		// Token: 0x0403F2A2 RID: 258722
		[Token(Token = "0x403F2A2")]
		[FieldOffset(Offset = "0xF0")]
		private GameObject m_curShowZoneInfoGO;

		// Token: 0x0403F2A3 RID: 258723
		[Token(Token = "0x403F2A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F2A4 RID: 258724
		[Token(Token = "0x403F2A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderStageBasicInfo;

		// Token: 0x0403F2A5 RID: 258725
		[Token(Token = "0x403F2A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowStageInfoPrefab;

		// Token: 0x0403F2A6 RID: 258726
		[Token(Token = "0x403F2A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderScoreInfo;

		// Token: 0x0403F2A7 RID: 258727
		[Token(Token = "0x403F2A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClickEnemyHandBook;

		// Token: 0x0403F2A8 RID: 258728
		[Token(Token = "0x403F2A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClickMap;

		// Token: 0x0403F2A9 RID: 258729
		[Token(Token = "0x403F2A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClickScoreInfo;

		// Token: 0x0403F2AA RID: 258730
		[Token(Token = "0x403F2AA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
