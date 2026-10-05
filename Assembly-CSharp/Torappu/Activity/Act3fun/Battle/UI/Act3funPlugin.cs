using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3fun.Battle.UI
{
	// Token: 0x020073BF RID: 29631
	[Token(Token = "0x20073BF")]
	public class Act3funPlugin : UIController.Plugin
	{
		// Token: 0x06029DC8 RID: 171464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DC8")]
		[Address(RVA = "0x256ED40", Offset = "0x256D940", VA = "0x18256ED40", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x06029DC9 RID: 171465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DC9")]
		[Address(RVA = "0x256EE00", Offset = "0x256DA00", VA = "0x18256EE00", Slot = "16")]
		public override void OnGameReady()
		{
		}

		// Token: 0x06029DCA RID: 171466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DCA")]
		[Address(RVA = "0x256F0A0", Offset = "0x256DCA0", VA = "0x18256F0A0", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06029DCB RID: 171467 RVA: 0x000D6D28 File Offset: 0x000D4F28
		[Token(Token = "0x6029DCB")]
		[Address(RVA = "0x256EC40", Offset = "0x256D840", VA = "0x18256EC40", Slot = "24")]
		public override bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
		{
			return default(bool);
		}

		// Token: 0x06029DCC RID: 171468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DCC")]
		[Address(RVA = "0x256EB70", Offset = "0x256D770", VA = "0x18256EB70", Slot = "36")]
		public override void HookBattleData(CommonFinishBattleRequest.BattleData battleData)
		{
		}

		// Token: 0x06029DCD RID: 171469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DCD")]
		[Address(RVA = "0x256F120", Offset = "0x256DD20", VA = "0x18256F120")]
		public Act3funPlugin()
		{
		}

		// Token: 0x06029DCE RID: 171470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DCE")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06029DCF RID: 171471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DCF")]
		[Address(RVA = "0x9CCDF0", Offset = "0x9CB9F0", VA = "0x1809CCDF0")]
		private void <>xLuaBaseProxy_OnGameReady()
		{
		}

		// Token: 0x06029DD0 RID: 171472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD0")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06029DD1 RID: 171473 RVA: 0x000D6D40 File Offset: 0x000D4F40
		[Token(Token = "0x6029DD1")]
		[Address(RVA = "0x960A10", Offset = "0x95F610", VA = "0x180960A10")]
		private bool <>xLuaBaseProxy_HookBattleFailedStateSwitch(BattleFailedStateParam P0)
		{
			return default(bool);
		}

		// Token: 0x06029DD2 RID: 171474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DD2")]
		[Address(RVA = "0xDC6490", Offset = "0xDC5090", VA = "0x180DC6490")]
		private void <>xLuaBaseProxy_HookBattleData(CommonFinishBattleRequest.BattleData P0)
		{
		}

		// Token: 0x0403BFE0 RID: 245728
		[Token(Token = "0x403BFE0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act3funTopbarStatus _topbarStatus;

		// Token: 0x0403BFE1 RID: 245729
		[Token(Token = "0x403BFE1")]
		[FieldOffset(Offset = "0x30")]
		private BattleController m_battleController;

		// Token: 0x0403BFE2 RID: 245730
		[Token(Token = "0x403BFE2")]
		[FieldOffset(Offset = "0x38")]
		private UIController m_uiController;

		// Token: 0x0403BFE3 RID: 245731
		[Token(Token = "0x403BFE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403BFE4 RID: 245732
		[Token(Token = "0x403BFE4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0403BFE5 RID: 245733
		[Token(Token = "0x403BFE5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0403BFE6 RID: 245734
		[Token(Token = "0x403BFE6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

		// Token: 0x0403BFE7 RID: 245735
		[Token(Token = "0x403BFE7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HookBattleData;

		// Token: 0x0403BFE8 RID: 245736
		[Token(Token = "0x403BFE8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
