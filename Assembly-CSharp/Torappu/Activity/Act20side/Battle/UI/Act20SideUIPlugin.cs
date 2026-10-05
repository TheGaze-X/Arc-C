using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side.Battle.UI
{
	// Token: 0x020076AA RID: 30378
	[Token(Token = "0x20076AA")]
	public class Act20SideUIPlugin : UIController.Plugin
	{
		// Token: 0x0602AB64 RID: 174948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB64")]
		[Address(RVA = "0x26678C0", Offset = "0x26664C0", VA = "0x1826678C0", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0602AB65 RID: 174949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB65")]
		[Address(RVA = "0x2667B80", Offset = "0x2666780", VA = "0x182667B80")]
		private void _InitLayout()
		{
		}

		// Token: 0x0602AB66 RID: 174950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB66")]
		[Address(RVA = "0x2667540", Offset = "0x2666140", VA = "0x182667540", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x0602AB67 RID: 174951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB67")]
		[Address(RVA = "0x26676C0", Offset = "0x26662C0", VA = "0x1826676C0", Slot = "16")]
		public override void OnGameReady()
		{
		}

		// Token: 0x0602AB68 RID: 174952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB68")]
		[Address(RVA = "0x2667A50", Offset = "0x2666650", VA = "0x182667A50", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x0602AB69 RID: 174953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB69")]
		[Address(RVA = "0x2667AE0", Offset = "0x26666E0", VA = "0x182667AE0")]
		public void UpdateScore(int value)
		{
		}

		// Token: 0x0602AB6A RID: 174954 RVA: 0x000D98D8 File Offset: 0x000D7AD8
		[Token(Token = "0x602AB6A")]
		[Address(RVA = "0x26673F0", Offset = "0x2665FF0", VA = "0x1826673F0", Slot = "24")]
		public override bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
		{
			return default(bool);
		}

		// Token: 0x0602AB6B RID: 174955 RVA: 0x000D98F0 File Offset: 0x000D7AF0
		[Token(Token = "0x602AB6B")]
		[Address(RVA = "0x2667220", Offset = "0x2665E20", VA = "0x182667220", Slot = "25")]
		public override bool HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602AB6C RID: 174956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB6C")]
		[Address(RVA = "0x2667300", Offset = "0x2665F00", VA = "0x182667300", Slot = "36")]
		public override void HookBattleData(CommonFinishBattleRequest.BattleData battleData)
		{
		}

		// Token: 0x0602AB6D RID: 174957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB6D")]
		[Address(RVA = "0x2667C70", Offset = "0x2666870", VA = "0x182667C70")]
		public Act20SideUIPlugin()
		{
		}

		// Token: 0x0602AB6F RID: 174959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB6F")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x0602AB70 RID: 174960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB70")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x0602AB71 RID: 174961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB71")]
		[Address(RVA = "0x9CCDF0", Offset = "0x9CB9F0", VA = "0x1809CCDF0")]
		private void <>xLuaBaseProxy_OnGameReady()
		{
		}

		// Token: 0x0602AB72 RID: 174962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB72")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0602AB73 RID: 174963 RVA: 0x000D9908 File Offset: 0x000D7B08
		[Token(Token = "0x602AB73")]
		[Address(RVA = "0x960A10", Offset = "0x95F610", VA = "0x180960A10")]
		private bool <>xLuaBaseProxy_HookBattleFailedStateSwitch(BattleFailedStateParam P0)
		{
			return default(bool);
		}

		// Token: 0x0602AB74 RID: 174964 RVA: 0x000D9920 File Offset: 0x000D7B20
		[Token(Token = "0x602AB74")]
		[Address(RVA = "0x960A00", Offset = "0x95F600", VA = "0x180960A00")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602AB75 RID: 174965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB75")]
		[Address(RVA = "0xDC6490", Offset = "0xDC5090", VA = "0x180DC6490")]
		private void <>xLuaBaseProxy_HookBattleData(CommonFinishBattleRequest.BattleData P0)
		{
		}

		// Token: 0x0403D8C5 RID: 252101
		[Token(Token = "0x403D8C5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_BATTLE_ACCOMPLISHED;

		// Token: 0x0403D8C6 RID: 252102
		[Token(Token = "0x403D8C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<UIStateNode> _states;

		// Token: 0x0403D8C7 RID: 252103
		[Token(Token = "0x403D8C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _battleAccomplishedPanel;

		// Token: 0x0403D8C8 RID: 252104
		[Token(Token = "0x403D8C8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act20SideUIPlugin.TopBarStatus _topBar;

		// Token: 0x0403D8C9 RID: 252105
		[Token(Token = "0x403D8C9")]
		[FieldOffset(Offset = "0x40")]
		private BattleController m_battleController;

		// Token: 0x0403D8CA RID: 252106
		[Token(Token = "0x403D8CA")]
		[FieldOffset(Offset = "0x48")]
		private UIController m_uiController;

		// Token: 0x0403D8CB RID: 252107
		[Token(Token = "0x403D8CB")]
		[FieldOffset(Offset = "0x50")]
		private GameModeFactory.Act20SideGameMode m_gameMode;

		// Token: 0x0403D8CC RID: 252108
		[Token(Token = "0x403D8CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0403D8CD RID: 252109
		[Token(Token = "0x403D8CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitLayout;

		// Token: 0x0403D8CE RID: 252110
		[Token(Token = "0x403D8CE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403D8CF RID: 252111
		[Token(Token = "0x403D8CF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0403D8D0 RID: 252112
		[Token(Token = "0x403D8D0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403D8D1 RID: 252113
		[Token(Token = "0x403D8D1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateScore;

		// Token: 0x0403D8D2 RID: 252114
		[Token(Token = "0x403D8D2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

		// Token: 0x0403D8D3 RID: 252115
		[Token(Token = "0x403D8D3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

		// Token: 0x0403D8D4 RID: 252116
		[Token(Token = "0x403D8D4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HookBattleData;

		// Token: 0x0403D8D5 RID: 252117
		[Token(Token = "0x403D8D5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076AB RID: 30379
		[Token(Token = "0x20076AB")]
		[Serializable]
		private class TopBarStatus
		{
			// Token: 0x0602AB76 RID: 174966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB76")]
			[Address(RVA = "0x267D000", Offset = "0x267BC00", VA = "0x18267D000")]
			public void Init(GameModeFactory.Act20SideGameMode gameMode)
			{
			}

			// Token: 0x0602AB77 RID: 174967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB77")]
			[Address(RVA = "0x267D220", Offset = "0x267BE20", VA = "0x18267D220")]
			public void UpdateData(BattleController controller)
			{
			}

			// Token: 0x0602AB78 RID: 174968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB78")]
			[Address(RVA = "0x267D820", Offset = "0x267C420", VA = "0x18267D820")]
			private void _UpdateBattleTimeInfo(BattleController controller)
			{
			}

			// Token: 0x0602AB79 RID: 174969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB79")]
			[Address(RVA = "0x267D580", Offset = "0x267C180", VA = "0x18267D580")]
			private void _TweenTimeText()
			{
			}

			// Token: 0x0602AB7A RID: 174970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB7A")]
			[Address(RVA = "0x267D230", Offset = "0x267BE30", VA = "0x18267D230")]
			public void UpdateScore(int value)
			{
			}

			// Token: 0x0602AB7B RID: 174971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB7B")]
			[Address(RVA = "0x267DAF0", Offset = "0x267C6F0", VA = "0x18267DAF0")]
			public TopBarStatus()
			{
			}

			// Token: 0x0403D8D6 RID: 252118
			[Token(Token = "0x403D8D6")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _timerText;

			// Token: 0x0403D8D7 RID: 252119
			[Token(Token = "0x403D8D7")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Color _timerTextDefaultColor;

			// Token: 0x0403D8D8 RID: 252120
			[Token(Token = "0x403D8D8")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Color _timerTextFinalColor;

			// Token: 0x0403D8D9 RID: 252121
			[Token(Token = "0x403D8D9")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Color _timerTextBlinkColor;

			// Token: 0x0403D8DA RID: 252122
			[Token(Token = "0x403D8DA")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Vector3 _timerTextTweenScale;

			// Token: 0x0403D8DB RID: 252123
			[Token(Token = "0x403D8DB")]
			[FieldOffset(Offset = "0x54")]
			[SerializeField]
			private int _timerBeginTweenTime;

			// Token: 0x0403D8DC RID: 252124
			[Token(Token = "0x403D8DC")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private float _timerTweenDuration;

			// Token: 0x0403D8DD RID: 252125
			[Token(Token = "0x403D8DD")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			private Text _scoreText;

			// Token: 0x0403D8DE RID: 252126
			[Token(Token = "0x403D8DE")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			private Transform _scoreSuffix;

			// Token: 0x0403D8DF RID: 252127
			[Token(Token = "0x403D8DF")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			private Slider _scoreSliderRight;

			// Token: 0x0403D8E0 RID: 252128
			[Token(Token = "0x403D8E0")]
			[FieldOffset(Offset = "0x78")]
			[SerializeField]
			private Slider _scoreSliderLeft;

			// Token: 0x0403D8E1 RID: 252129
			[Token(Token = "0x403D8E1")]
			[FieldOffset(Offset = "0x80")]
			[SerializeField]
			private Vector3 _scoreTextTweenScale;

			// Token: 0x0403D8E2 RID: 252130
			[Token(Token = "0x403D8E2")]
			[FieldOffset(Offset = "0x8C")]
			[SerializeField]
			private Vector3 _scoreSuffixTweenScale;

			// Token: 0x0403D8E3 RID: 252131
			[Token(Token = "0x403D8E3")]
			[FieldOffset(Offset = "0x98")]
			[SerializeField]
			private float _scoreTweenDuration;

			// Token: 0x0403D8E4 RID: 252132
			[Token(Token = "0x403D8E4")]
			[FieldOffset(Offset = "0x9C")]
			private int m_maxPlayTime;

			// Token: 0x0403D8E5 RID: 252133
			[Token(Token = "0x403D8E5")]
			[FieldOffset(Offset = "0xA0")]
			private int m_playTime;

			// Token: 0x0403D8E6 RID: 252134
			[Token(Token = "0x403D8E6")]
			[FieldOffset(Offset = "0xA4")]
			private int m_score;

			// Token: 0x0403D8E7 RID: 252135
			[Token(Token = "0x403D8E7")]
			[FieldOffset(Offset = "0xA8")]
			private Sequence m_scoreTweenSequence;

			// Token: 0x0403D8E8 RID: 252136
			[Token(Token = "0x403D8E8")]
			[FieldOffset(Offset = "0xB0")]
			private Vector3 m_scoreTextDefaultScale;

			// Token: 0x0403D8E9 RID: 252137
			[Token(Token = "0x403D8E9")]
			[FieldOffset(Offset = "0xBC")]
			private Vector3 m_scoreSuffixDefaultScale;

			// Token: 0x0403D8EA RID: 252138
			[Token(Token = "0x403D8EA")]
			[FieldOffset(Offset = "0xC8")]
			private Sequence m_timerTweenSequence;

			// Token: 0x0403D8EB RID: 252139
			[Token(Token = "0x403D8EB")]
			[FieldOffset(Offset = "0xD0")]
			private Vector3 m_timerTextDefaultScale;

			// Token: 0x0403D8EC RID: 252140
			[Token(Token = "0x403D8EC")]
			[FieldOffset(Offset = "0xDC")]
			private Color m_timerTextDefaultColor;
		}
	}
}
