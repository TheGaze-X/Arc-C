using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044B3 RID: 17587
	[Token(Token = "0x20044B3")]
	public class RoguelikeTopicChallengeModeInfoView : RoguelikeTopicChallengeModeInfoViewBase
	{
		// Token: 0x0601ADD0 RID: 110032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADD0")]
		[Address(RVA = "0x1405340", Offset = "0x1403F40", VA = "0x181405340", Slot = "4")]
		public override void InitStyle(RoguelikeTopicChallengeModelStyle style)
		{
		}

		// Token: 0x0601ADD1 RID: 110033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADD1")]
		[Address(RVA = "0x1405600", Offset = "0x1404200", VA = "0x181405600", Slot = "5")]
		public override void Render(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601ADD2 RID: 110034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADD2")]
		[Address(RVA = "0x1405B50", Offset = "0x1404750", VA = "0x181405B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ADD3 RID: 110035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADD3")]
		[Address(RVA = "0x1405C00", Offset = "0x1404800", VA = "0x181405C00")]
		private void _LoadRewardItemIcon(int index, List<ItemBundle> items)
		{
		}

		// Token: 0x0601ADD4 RID: 110036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADD4")]
		[Address(RVA = "0x1405F60", Offset = "0x1404B60", VA = "0x181405F60")]
		public RoguelikeTopicChallengeModeInfoView()
		{
		}

		// Token: 0x0402269E RID: 140958
		[Token(Token = "0x402269E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Tasks")]
		private Image _imgTaskTitle;

		// Token: 0x0402269F RID: 140959
		[Token(Token = "0x402269F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Tasks")]
		private Text _textTaskTitle;

		// Token: 0x040226A0 RID: 140960
		[Token(Token = "0x40226A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Tasks")]
		private RoguelikeTopicChallengeModeInfoView.ChallengeTaskInfoPanel[] _challengeTaskInfos;

		// Token: 0x040226A1 RID: 140961
		[Token(Token = "0x40226A1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Rewards")]
		private Image _bkgReward;

		// Token: 0x040226A2 RID: 140962
		[Token(Token = "0x40226A2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Rewards")]
		private Text _textReward;

		// Token: 0x040226A3 RID: 140963
		[Token(Token = "0x40226A3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Rewards")]
		private GameObject _pnlAwardReceived;

		// Token: 0x040226A4 RID: 140964
		[Token(Token = "0x40226A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Rewards")]
		private GameObject _pnlAwardNotReceived;

		// Token: 0x040226A5 RID: 140965
		[Token(Token = "0x40226A5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Rewards")]
		private RectTransform[] _itemIconHolder;

		// Token: 0x040226A6 RID: 140966
		[Token(Token = "0x40226A6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Rewards")]
		private float _rewardItemScale;

		// Token: 0x040226A7 RID: 140967
		[Token(Token = "0x40226A7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Conditions")]
		private Text _textConditionTitle;

		// Token: 0x040226A8 RID: 140968
		[Token(Token = "0x40226A8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Conditions")]
		private RoguelikeTopicChallengeModeInfoView.ChallengeConditionLine[] _challengeDescLines;

		// Token: 0x040226A9 RID: 140969
		[Token(Token = "0x40226A9")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x040226AA RID: 140970
		[Token(Token = "0x40226AA")]
		[FieldOffset(Offset = "0x88")]
		private UIItemCard[] m_itemCardList;

		// Token: 0x040226AB RID: 140971
		[Token(Token = "0x40226AB")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedChallengeId;

		// Token: 0x040226AC RID: 140972
		[Token(Token = "0x40226AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitStyle;

		// Token: 0x040226AD RID: 140973
		[Token(Token = "0x40226AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040226AE RID: 140974
		[Token(Token = "0x40226AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040226AF RID: 140975
		[Token(Token = "0x40226AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadRewardItemIcon;

		// Token: 0x040226B0 RID: 140976
		[Token(Token = "0x40226B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020044B4 RID: 17588
		[Token(Token = "0x20044B4")]
		[Serializable]
		private class ChallengeConditionLine : IHotfixable
		{
			// Token: 0x0601ADD5 RID: 110037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADD5")]
			[Address(RVA = "0x14012B0", Offset = "0x13FFEB0", VA = "0x1814012B0")]
			public void Render(string desc)
			{
			}

			// Token: 0x0601ADD6 RID: 110038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADD6")]
			[Address(RVA = "0x14013B0", Offset = "0x13FFFB0", VA = "0x1814013B0")]
			public ChallengeConditionLine()
			{
			}

			// Token: 0x040226B1 RID: 140977
			[Token(Token = "0x40226B1")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _textDesc;

			// Token: 0x040226B2 RID: 140978
			[Token(Token = "0x40226B2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x040226B3 RID: 140979
			[Token(Token = "0x40226B3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020044B5 RID: 17589
		[Token(Token = "0x20044B5")]
		[Serializable]
		private class ChallengeTaskInfoPanel : IHotfixable
		{
			// Token: 0x0601ADD7 RID: 110039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADD7")]
			[Address(RVA = "0x1401410", Offset = "0x1400010", VA = "0x181401410")]
			public void InitStyle(RoguelikeTopicChallengeModelStyle style)
			{
			}

			// Token: 0x0601ADD8 RID: 110040 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADD8")]
			[Address(RVA = "0x14014D0", Offset = "0x14000D0", VA = "0x1814014D0")]
			public void Render(RoguelikeTopicChallengeModel challengeModel, RoguelikeTopicTaskInfo taskInfo)
			{
			}

			// Token: 0x0601ADD9 RID: 110041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ADD9")]
			[Address(RVA = "0x1401A80", Offset = "0x1400680", VA = "0x181401A80")]
			public ChallengeTaskInfoPanel()
			{
			}

			// Token: 0x040226B4 RID: 140980
			[Token(Token = "0x40226B4")]
			private const int PROGRESS_BAR_TOTAL_WIDTH = 310;

			// Token: 0x040226B5 RID: 140981
			[Token(Token = "0x40226B5")]
			private const int PROGRESS_BAR_HEIGHT = 6;

			// Token: 0x040226B6 RID: 140982
			[Token(Token = "0x40226B6")]
			private const float PROGRESS_BAR_ALPHA_EXPLORING = 1f;

			// Token: 0x040226B7 RID: 140983
			[Token(Token = "0x40226B7")]
			private const float PROGRESS_BAR_ALPHA_COMPLETED = 0.4f;

			// Token: 0x040226B8 RID: 140984
			[Token(Token = "0x40226B8")]
			private const string TASK_PROGRESS_STYLE = "{0} (<color=#{1}>{2}</color>/{3})";

			// Token: 0x040226B9 RID: 140985
			[Token(Token = "0x40226B9")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlProgressBar;

			// Token: 0x040226BA RID: 140986
			[Token(Token = "0x40226BA")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIAtlasImage _imgTotal;

			// Token: 0x040226BB RID: 140987
			[Token(Token = "0x40226BB")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UIAtlasImage _imgCurrent;

			// Token: 0x040226BC RID: 140988
			[Token(Token = "0x40226BC")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textTask;

			// Token: 0x040226BD RID: 140989
			[Token(Token = "0x40226BD")]
			[FieldOffset(Offset = "0x30")]
			private string m_taskCurProgressTxtStyle;

			// Token: 0x040226BE RID: 140990
			[Token(Token = "0x40226BE")]
			[FieldOffset(Offset = "0x38")]
			private Color m_colorTaskTheme;

			// Token: 0x040226BF RID: 140991
			[Token(Token = "0x40226BF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_InitStyle;

			// Token: 0x040226C0 RID: 140992
			[Token(Token = "0x40226C0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x040226C1 RID: 140993
			[Token(Token = "0x40226C1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
