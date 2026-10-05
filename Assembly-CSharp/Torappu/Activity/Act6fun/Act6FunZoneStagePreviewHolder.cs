using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071CD RID: 29133
	[Token(Token = "0x20071CD")]
	public class Act6FunZoneStagePreviewHolder : ActivityCustomZoneStagePreviewHolderBase
	{
		// Token: 0x0602956E RID: 169326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602956E")]
		[Address(RVA = "0x24B7C90", Offset = "0x24B6890", VA = "0x1824B7C90", Slot = "8")]
		protected override void StartBattle()
		{
		}

		// Token: 0x0602956F RID: 169327 RVA: 0x000D5648 File Offset: 0x000D3848
		[Token(Token = "0x602956F")]
		[Address(RVA = "0x24B7F30", Offset = "0x24B6B30", VA = "0x1824B7F30")]
		private BattleStartController.Param _CreateParamToStartBattle(string actId, string stageId)
		{
			return default(BattleStartController.Param);
		}

		// Token: 0x06029570 RID: 169328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029570")]
		[Address(RVA = "0x24B8530", Offset = "0x24B7130", VA = "0x1824B8530")]
		public Act6FunZoneStagePreviewHolder()
		{
		}

		// Token: 0x06029571 RID: 169329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029571")]
		[Address(RVA = "0x24B7F20", Offset = "0x24B6B20", VA = "0x1824B7F20")]
		private void <>xLuaBaseProxy_StartBattle()
		{
		}

		// Token: 0x0403B0AB RID: 241835
		[Token(Token = "0x403B0AB")]
		private const string BUNDLE_KEY_LUA_ACTFUN_TOPIC = "init_dlg";

		// Token: 0x0403B0AC RID: 241836
		[Token(Token = "0x403B0AC")]
		private const string BUNDLE_VALUE_LUA_ACT6FUN = "fun6";

		// Token: 0x0403B0AD RID: 241837
		[Token(Token = "0x403B0AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x0403B0AE RID: 241838
		[Token(Token = "0x403B0AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateParamToStartBattle;

		// Token: 0x0403B0AF RID: 241839
		[Token(Token = "0x403B0AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
