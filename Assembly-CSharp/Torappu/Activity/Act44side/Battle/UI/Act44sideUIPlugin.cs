using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act44side.Battle.UI
{
	// Token: 0x020072F0 RID: 29424
	[Token(Token = "0x20072F0")]
	public class Act44sideUIPlugin : UIController.Plugin
	{
		// Token: 0x1700626E RID: 25198
		// (get) Token: 0x06029A23 RID: 170531 RVA: 0x000D61B8 File Offset: 0x000D43B8
		[Token(Token = "0x1700626E")]
		private bool isExtraGameType
		{
			[Token(Token = "0x6029A23")]
			[Address(RVA = "0x24F0230", Offset = "0x24EEE30", VA = "0x1824F0230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029A24 RID: 170532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A24")]
		[Address(RVA = "0x24EF7F0", Offset = "0x24EE3F0", VA = "0x1824EF7F0", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06029A25 RID: 170533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A25")]
		[Address(RVA = "0x24EF9E0", Offset = "0x24EE5E0", VA = "0x1824EF9E0", Slot = "17")]
		public override void OnGameStart()
		{
		}

		// Token: 0x06029A26 RID: 170534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A26")]
		[Address(RVA = "0x24EFA50", Offset = "0x24EE650", VA = "0x1824EFA50", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06029A27 RID: 170535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A27")]
		[Address(RVA = "0x24EF950", Offset = "0x24EE550", VA = "0x1824EF950", Slot = "19")]
		public override void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x06029A28 RID: 170536 RVA: 0x000D61D0 File Offset: 0x000D43D0
		[Token(Token = "0x6029A28")]
		[Address(RVA = "0x24EFE70", Offset = "0x24EEA70", VA = "0x1824EFE70")]
		private bool _InitAllMembers()
		{
			return default(bool);
		}

		// Token: 0x06029A29 RID: 170537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A29")]
		[Address(RVA = "0x24EFD90", Offset = "0x24EE990", VA = "0x1824EFD90")]
		private void _HideOriUIPanel()
		{
		}

		// Token: 0x06029A2A RID: 170538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A2A")]
		[Address(RVA = "0x24F0010", Offset = "0x24EEC10", VA = "0x1824F0010")]
		private void _SetGameTypeUIPanel()
		{
		}

		// Token: 0x06029A2B RID: 170539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A2B")]
		[Address(RVA = "0x24EFAC0", Offset = "0x24EE6C0", VA = "0x1824EFAC0")]
		private void _DoUpdateGameTypeUIPanel()
		{
		}

		// Token: 0x06029A2C RID: 170540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A2C")]
		[Address(RVA = "0x24F01A0", Offset = "0x24EEDA0", VA = "0x1824F01A0")]
		public Act44sideUIPlugin()
		{
		}

		// Token: 0x06029A2D RID: 170541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A2D")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06029A2E RID: 170542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A2E")]
		[Address(RVA = "0x960A30", Offset = "0x95F630", VA = "0x180960A30")]
		private void <>xLuaBaseProxy_OnGameStart()
		{
		}

		// Token: 0x06029A2F RID: 170543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A2F")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06029A30 RID: 170544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A30")]
		[Address(RVA = "0x7D24A0", Offset = "0x7D10A0", VA = "0x1807D24A0")]
		private void <>xLuaBaseProxy_OnGameOver(BattleController.GameResult P0)
		{
		}

		// Token: 0x0403B8EB RID: 243947
		[Token(Token = "0x403B8EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _envSystemKey;

		// Token: 0x0403B8EC RID: 243948
		[Token(Token = "0x403B8EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalGameUIPanel;

		// Token: 0x0403B8ED RID: 243949
		[Token(Token = "0x403B8ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _extraGameUIPanel;

		// Token: 0x0403B8EE RID: 243950
		[Token(Token = "0x403B8EE")]
		[FieldOffset(Offset = "0x40")]
		private Act44SideBattleManager m_envManager;

		// Token: 0x0403B8EF RID: 243951
		[Token(Token = "0x403B8EF")]
		[FieldOffset(Offset = "0x48")]
		private Act44sideNormalUIPanel m_envNormalUIPanel;

		// Token: 0x0403B8F0 RID: 243952
		[Token(Token = "0x403B8F0")]
		[FieldOffset(Offset = "0x50")]
		private Act44sideExtraUIPanel m_extraGameUIPanel;

		// Token: 0x0403B8F1 RID: 243953
		[Token(Token = "0x403B8F1")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasGameStarted;

		// Token: 0x0403B8F2 RID: 243954
		[Token(Token = "0x403B8F2")]
		[FieldOffset(Offset = "0x59")]
		private bool m_isValid;

		// Token: 0x0403B8F3 RID: 243955
		[Token(Token = "0x403B8F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isExtraGameType;

		// Token: 0x0403B8F4 RID: 243956
		[Token(Token = "0x403B8F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0403B8F5 RID: 243957
		[Token(Token = "0x403B8F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0403B8F6 RID: 243958
		[Token(Token = "0x403B8F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403B8F7 RID: 243959
		[Token(Token = "0x403B8F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0403B8F8 RID: 243960
		[Token(Token = "0x403B8F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitAllMembers;

		// Token: 0x0403B8F9 RID: 243961
		[Token(Token = "0x403B8F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HideOriUIPanel;

		// Token: 0x0403B8FA RID: 243962
		[Token(Token = "0x403B8FA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetGameTypeUIPanel;

		// Token: 0x0403B8FB RID: 243963
		[Token(Token = "0x403B8FB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoUpdateGameTypeUIPanel;

		// Token: 0x0403B8FC RID: 243964
		[Token(Token = "0x403B8FC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
