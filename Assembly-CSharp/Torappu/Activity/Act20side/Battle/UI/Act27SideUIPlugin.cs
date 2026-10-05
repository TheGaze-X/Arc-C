using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side.Battle.UI
{
	// Token: 0x020076AC RID: 30380
	[Token(Token = "0x20076AC")]
	public class Act27SideUIPlugin : UIController.Plugin
	{
		// Token: 0x0602AB7C RID: 174972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB7C")]
		[Address(RVA = "0x2693470", Offset = "0x2692070", VA = "0x182693470", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0602AB7D RID: 174973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB7D")]
		[Address(RVA = "0x2693760", Offset = "0x2692360", VA = "0x182693760", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0602AB7E RID: 174974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB7E")]
		[Address(RVA = "0x2693510", Offset = "0x2692110", VA = "0x182693510", Slot = "16")]
		public override void OnGameReady()
		{
		}

		// Token: 0x0602AB7F RID: 174975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB7F")]
		[Address(RVA = "0x26938F0", Offset = "0x26924F0", VA = "0x1826938F0", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x0602AB80 RID: 174976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB80")]
		[Address(RVA = "0x2693C10", Offset = "0x2692810", VA = "0x182693C10")]
		private void _UpdateTimeInfo()
		{
		}

		// Token: 0x0602AB81 RID: 174977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB81")]
		[Address(RVA = "0x2693980", Offset = "0x2692580", VA = "0x182693980")]
		private void _UpdateCountInfo()
		{
		}

		// Token: 0x0602AB82 RID: 174978 RVA: 0x000D9938 File Offset: 0x000D7B38
		[Token(Token = "0x602AB82")]
		[Address(RVA = "0x2693310", Offset = "0x2691F10", VA = "0x182693310", Slot = "24")]
		public override bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
		{
			return default(bool);
		}

		// Token: 0x0602AB83 RID: 174979 RVA: 0x000D9950 File Offset: 0x000D7B50
		[Token(Token = "0x602AB83")]
		[Address(RVA = "0x2693230", Offset = "0x2691E30", VA = "0x182693230", Slot = "25")]
		public override bool HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602AB84 RID: 174980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB84")]
		[Address(RVA = "0x2693E40", Offset = "0x2692A40", VA = "0x182693E40")]
		public Act27SideUIPlugin()
		{
		}

		// Token: 0x0602AB86 RID: 174982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB86")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x0602AB87 RID: 174983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB87")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x0602AB88 RID: 174984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB88")]
		[Address(RVA = "0x9CCDF0", Offset = "0x9CB9F0", VA = "0x1809CCDF0")]
		private void <>xLuaBaseProxy_OnGameReady()
		{
		}

		// Token: 0x0602AB89 RID: 174985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB89")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x0602AB8A RID: 174986 RVA: 0x000D9968 File Offset: 0x000D7B68
		[Token(Token = "0x602AB8A")]
		[Address(RVA = "0x960A10", Offset = "0x95F610", VA = "0x180960A10")]
		private bool <>xLuaBaseProxy_HookBattleFailedStateSwitch(BattleFailedStateParam P0)
		{
			return default(bool);
		}

		// Token: 0x0602AB8B RID: 174987 RVA: 0x000D9980 File Offset: 0x000D7B80
		[Token(Token = "0x602AB8B")]
		[Address(RVA = "0x960A00", Offset = "0x95F600", VA = "0x180960A00")]
		private bool <>xLuaBaseProxy_HookBattleAccomplishedStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0403D8ED RID: 252141
		[Token(Token = "0x403D8ED")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_BATTLE_ACCOMPLISHED;

		// Token: 0x0403D8EE RID: 252142
		[Token(Token = "0x403D8EE")]
		[FieldOffset(Offset = "0x4")]
		public static readonly UIStateEnum UI_STATE_BATTLE_FAILED;

		// Token: 0x0403D8EF RID: 252143
		[Token(Token = "0x403D8EF")]
		[FieldOffset(Offset = "0x28")]
		private int m_maxPlayTime;

		// Token: 0x0403D8F0 RID: 252144
		[Token(Token = "0x403D8F0")]
		[FieldOffset(Offset = "0x2C")]
		private int m_playTime;

		// Token: 0x0403D8F1 RID: 252145
		[Token(Token = "0x403D8F1")]
		[FieldOffset(Offset = "0x30")]
		private GameModeFactory.Act27SideGameMode m_gameMode;

		// Token: 0x0403D8F2 RID: 252146
		[Token(Token = "0x403D8F2")]
		[FieldOffset(Offset = "0x38")]
		private int m_nervousCount;

		// Token: 0x0403D8F3 RID: 252147
		[Token(Token = "0x403D8F3")]
		[FieldOffset(Offset = "0x3C")]
		private int m_angryCount;

		// Token: 0x0403D8F4 RID: 252148
		[Token(Token = "0x403D8F4")]
		[FieldOffset(Offset = "0x40")]
		private int m_highlightSeconds;

		// Token: 0x0403D8F5 RID: 252149
		[Token(Token = "0x403D8F5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _timerText;

		// Token: 0x0403D8F6 RID: 252150
		[Token(Token = "0x403D8F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403D8F7 RID: 252151
		[Token(Token = "0x403D8F7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<UIStateNode> _states;

		// Token: 0x0403D8F8 RID: 252152
		[Token(Token = "0x403D8F8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _countDownHighlight;

		// Token: 0x0403D8F9 RID: 252153
		[Token(Token = "0x403D8F9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _normalSheep;

		// Token: 0x0403D8FA RID: 252154
		[Token(Token = "0x403D8FA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _nervousSheep;

		// Token: 0x0403D8FB RID: 252155
		[Token(Token = "0x403D8FB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _angrySheep;

		// Token: 0x0403D8FC RID: 252156
		[Token(Token = "0x403D8FC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x0403D8FD RID: 252157
		[Token(Token = "0x403D8FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0403D8FE RID: 252158
		[Token(Token = "0x403D8FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0403D8FF RID: 252159
		[Token(Token = "0x403D8FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0403D900 RID: 252160
		[Token(Token = "0x403D900")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403D901 RID: 252161
		[Token(Token = "0x403D901")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateTimeInfo;

		// Token: 0x0403D902 RID: 252162
		[Token(Token = "0x403D902")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateCountInfo;

		// Token: 0x0403D903 RID: 252163
		[Token(Token = "0x403D903")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

		// Token: 0x0403D904 RID: 252164
		[Token(Token = "0x403D904")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

		// Token: 0x0403D905 RID: 252165
		[Token(Token = "0x403D905")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
