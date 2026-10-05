using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200735E RID: 29534
	[Token(Token = "0x200735E")]
	public class Act42D0ChallengeStageDetailView : DataBinder<Act42D0ChallengeStageGroupProperty>
	{
		// Token: 0x06029C48 RID: 171080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C48")]
		[Address(RVA = "0x2555C90", Offset = "0x2554890", VA = "0x182555C90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029C49 RID: 171081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C49")]
		[Address(RVA = "0x25556F0", Offset = "0x25542F0", VA = "0x1825556F0", Slot = "7")]
		public override void OnValueChanged(Act42D0ChallengeStageGroupProperty property)
		{
		}

		// Token: 0x06029C4A RID: 171082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C4A")]
		[Address(RVA = "0x25555F0", Offset = "0x25541F0", VA = "0x1825555F0")]
		public void OnClickMap()
		{
		}

		// Token: 0x06029C4B RID: 171083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C4B")]
		[Address(RVA = "0x25554F0", Offset = "0x25540F0", VA = "0x1825554F0")]
		public void OnClickEnemy()
		{
		}

		// Token: 0x06029C4C RID: 171084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C4C")]
		[Address(RVA = "0x2555450", Offset = "0x2554050", VA = "0x182555450")]
		public void OnClickBattleStart()
		{
		}

		// Token: 0x06029C4D RID: 171085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C4D")]
		[Address(RVA = "0x2556010", Offset = "0x2554C10", VA = "0x182556010")]
		public Act42D0ChallengeStageDetailView()
		{
		}

		// Token: 0x0403BC94 RID: 244884
		[Token(Token = "0x403BC94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x0403BC95 RID: 244885
		[Token(Token = "0x403BC95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMissionCompletedCount;

		// Token: 0x0403BC96 RID: 244886
		[Token(Token = "0x403BC96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textMissionTotalCount;

		// Token: 0x0403BC97 RID: 244887
		[Token(Token = "0x403BC97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStageDescription;

		// Token: 0x0403BC98 RID: 244888
		[Token(Token = "0x403BC98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTipsSelectStage;

		// Token: 0x0403BC99 RID: 244889
		[Token(Token = "0x403BC99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textChallengeDesc;

		// Token: 0x0403BC9A RID: 244890
		[Token(Token = "0x403BC9A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textChallengeName;

		// Token: 0x0403BC9B RID: 244891
		[Token(Token = "0x403BC9B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403BC9C RID: 244892
		[Token(Token = "0x403BC9C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animDetailEnter;

		// Token: 0x0403BC9D RID: 244893
		[Token(Token = "0x403BC9D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasBottomMenuNotEmpty;

		// Token: 0x0403BC9E RID: 244894
		[Token(Token = "0x403BC9E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasBottomMenuEmpty;

		// Token: 0x0403BC9F RID: 244895
		[Token(Token = "0x403BC9F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasDetailEmpty;

		// Token: 0x0403BCA0 RID: 244896
		[Token(Token = "0x403BCA0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _fadeDurationDetail;

		// Token: 0x0403BCA1 RID: 244897
		[Token(Token = "0x403BCA1")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _fadeDurationBottomMenu;

		// Token: 0x0403BCA2 RID: 244898
		[Token(Token = "0x403BCA2")]
		private const int MISSION_SLOT_COUNT = 5;

		// Token: 0x0403BCA3 RID: 244899
		[Token(Token = "0x403BCA3")]
		private const string MISSION_SLOT_TOTAL_COUNT = "/{0}";

		// Token: 0x0403BCA4 RID: 244900
		[Token(Token = "0x403BCA4")]
		[FieldOffset(Offset = "0x90")]
		private List<Act42D0ChallengeMissionItemViewModel> m_missionItemDataList;

		// Token: 0x0403BCA5 RID: 244901
		[Token(Token = "0x403BCA5")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0403BCA6 RID: 244902
		[Token(Token = "0x403BCA6")]
		[FieldOffset(Offset = "0xA0")]
		private Act42D0ChallengeStageDetailView.Adapter m_adapter;

		// Token: 0x0403BCA7 RID: 244903
		[Token(Token = "0x403BCA7")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BCA8 RID: 244904
		[Token(Token = "0x403BCA8")]
		[FieldOffset(Offset = "0xB8")]
		private Act42D0ChallengeStageViewModel m_stageViewModel;

		// Token: 0x0403BCA9 RID: 244905
		[Token(Token = "0x403BCA9")]
		[FieldOffset(Offset = "0xC0")]
		private AnimationSwitchTween m_animDetailEnter;

		// Token: 0x0403BCAA RID: 244906
		[Token(Token = "0x403BCAA")]
		[FieldOffset(Offset = "0xC8")]
		private FadeSwitchTween m_fadeBottomMenuNotEmpty;

		// Token: 0x0403BCAB RID: 244907
		[Token(Token = "0x403BCAB")]
		[FieldOffset(Offset = "0xD0")]
		private FadeSwitchTween m_fadeBottomMenuEmpty;

		// Token: 0x0403BCAC RID: 244908
		[Token(Token = "0x403BCAC")]
		[FieldOffset(Offset = "0xD8")]
		private FadeSwitchTween m_fadeDetailEmpty;

		// Token: 0x0403BCAD RID: 244909
		[Token(Token = "0x403BCAD")]
		[FieldOffset(Offset = "0xE0")]
		private string m_stageSelected;

		// Token: 0x0403BCAE RID: 244910
		[Token(Token = "0x403BCAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BCAF RID: 244911
		[Token(Token = "0x403BCAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BCB0 RID: 244912
		[Token(Token = "0x403BCB0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickMap;

		// Token: 0x0403BCB1 RID: 244913
		[Token(Token = "0x403BCB1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickEnemy;

		// Token: 0x0403BCB2 RID: 244914
		[Token(Token = "0x403BCB2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickBattleStart;

		// Token: 0x0403BCB3 RID: 244915
		[Token(Token = "0x403BCB3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200735F RID: 29535
		[Token(Token = "0x200735F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170062A5 RID: 25253
			// (get) Token: 0x06029C4E RID: 171086 RVA: 0x000D6860 File Offset: 0x000D4A60
			[Token(Token = "0x170062A5")]
			public override int count
			{
				[Token(Token = "0x6029C4E")]
				[Address(RVA = "0x2564460", Offset = "0x2563060", VA = "0x182564460", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029C4F RID: 171087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C4F")]
			[Address(RVA = "0x2564260", Offset = "0x2562E60", VA = "0x182564260")]
			public Adapter(Act42D0ChallengeStageDetailView closure)
			{
			}

			// Token: 0x06029C50 RID: 171088 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029C50")]
			[Address(RVA = "0x25640B0", Offset = "0x2562CB0", VA = "0x1825640B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BCB4 RID: 244916
			[Token(Token = "0x403BCB4")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0ChallengeStageDetailView m_closure;

			// Token: 0x0403BCB5 RID: 244917
			[Token(Token = "0x403BCB5")]
			[FieldOffset(Offset = "0x28")]
			public int missionCount;

			// Token: 0x0403BCB6 RID: 244918
			[Token(Token = "0x403BCB6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BCB7 RID: 244919
			[Token(Token = "0x403BCB7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BCB8 RID: 244920
			[Token(Token = "0x403BCB8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
