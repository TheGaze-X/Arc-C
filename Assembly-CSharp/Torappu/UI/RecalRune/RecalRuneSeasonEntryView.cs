using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047AA RID: 18346
	[Token(Token = "0x20047AA")]
	public class RecalRuneSeasonEntryView : DataBinder<RecalRuneSeasonEntryProperty>
	{
		// Token: 0x0601BC7E RID: 113790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC7E")]
		[Address(RVA = "0x152D9D0", Offset = "0x152C5D0", VA = "0x18152D9D0", Slot = "7")]
		public override void OnValueChanged(RecalRuneSeasonEntryProperty property)
		{
		}

		// Token: 0x0601BC7F RID: 113791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC7F")]
		[Address(RVA = "0x152DD10", Offset = "0x152C910", VA = "0x18152DD10")]
		private void _InitIfNot(int juniorMedalCnt, int seniorMedalCnt)
		{
		}

		// Token: 0x0601BC80 RID: 113792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC80")]
		[Address(RVA = "0x152E0D0", Offset = "0x152CCD0", VA = "0x18152E0D0")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x0601BC81 RID: 113793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC81")]
		[Address(RVA = "0x152E260", Offset = "0x152CE60", VA = "0x18152E260")]
		public RecalRuneSeasonEntryView()
		{
		}

		// Token: 0x040241EF RID: 147951
		[Token(Token = "0x40241EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _medal;

		// Token: 0x040241F0 RID: 147952
		[Token(Token = "0x40241F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _medalToggle;

		// Token: 0x040241F1 RID: 147953
		[Token(Token = "0x40241F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _seasonCode;

		// Token: 0x040241F2 RID: 147954
		[Token(Token = "0x40241F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _trackToggle;

		// Token: 0x040241F3 RID: 147955
		[Token(Token = "0x40241F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RecalRuneSeasonEntryRewardView _juniorReward;

		// Token: 0x040241F4 RID: 147956
		[Token(Token = "0x40241F4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RecalRuneSeasonEntryRewardView _seniorReward;

		// Token: 0x040241F5 RID: 147957
		[Token(Token = "0x40241F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _juniorMedalCnt;

		// Token: 0x040241F6 RID: 147958
		[Token(Token = "0x40241F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _seniorMedalCnt;

		// Token: 0x040241F7 RID: 147959
		[Token(Token = "0x40241F7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform[] _stageHolders;

		// Token: 0x040241F8 RID: 147960
		[Token(Token = "0x40241F8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RecalRuneSeasonEntryStageItemView _stageItem;

		// Token: 0x040241F9 RID: 147961
		[Token(Token = "0x40241F9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _stagePanel;

		// Token: 0x040241FA RID: 147962
		[Token(Token = "0x40241FA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _rewardPanel;

		// Token: 0x040241FB RID: 147963
		[Token(Token = "0x40241FB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _btnChangeSeason;

		// Token: 0x040241FC RID: 147964
		[Token(Token = "0x40241FC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _btnStage;

		// Token: 0x040241FD RID: 147965
		[Token(Token = "0x40241FD")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040241FE RID: 147966
		[Token(Token = "0x40241FE")]
		[FieldOffset(Offset = "0xA0")]
		private ILoadAsset m_assetLoader;

		// Token: 0x040241FF RID: 147967
		[Token(Token = "0x40241FF")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x04024200 RID: 147968
		[Token(Token = "0x4024200")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedSeasonId;

		// Token: 0x04024201 RID: 147969
		[Token(Token = "0x4024201")]
		[FieldOffset(Offset = "0xB8")]
		private List<RecalRuneSeasonEntryStageItemView> m_stageViews;

		// Token: 0x04024202 RID: 147970
		[Token(Token = "0x4024202")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024203 RID: 147971
		[Token(Token = "0x4024203")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024204 RID: 147972
		[Token(Token = "0x4024204")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x04024205 RID: 147973
		[Token(Token = "0x4024205")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
