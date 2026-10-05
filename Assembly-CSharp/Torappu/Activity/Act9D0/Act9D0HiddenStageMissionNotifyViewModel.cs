using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007180 RID: 29056
	[Token(Token = "0x2007180")]
	public class Act9D0HiddenStageMissionNotifyViewModel : IHotfixable
	{
		// Token: 0x060293EE RID: 168942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293EE")]
		[Address(RVA = "0x2496D90", Offset = "0x2495990", VA = "0x182496D90")]
		public void LoadData(HiddenStageMissionPushMsg payLoad, string funcId)
		{
		}

		// Token: 0x060293EF RID: 168943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60293EF")]
		[Address(RVA = "0x2496FC0", Offset = "0x2495BC0", VA = "0x182496FC0")]
		private string _GenRawActId(string funcId)
		{
			return null;
		}

		// Token: 0x060293F0 RID: 168944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60293F0")]
		[Address(RVA = "0x2497130", Offset = "0x2495D30", VA = "0x182497130")]
		private string _GenToastWithMsg(HiddenStageMissionPushMsg payload, string actId)
		{
			return null;
		}

		// Token: 0x060293F1 RID: 168945 RVA: 0x000D4D30 File Offset: 0x000D2F30
		[Token(Token = "0x60293F1")]
		[Address(RVA = "0x2497410", Offset = "0x2496010", VA = "0x182497410")]
		private Act9D0HiddenStageMissionNotifyViewModel.HiddenStageMissionNotifyState _GetNotifyStage(PlayerHiddenStage playerData, HiddenStageMissionPushMsg payload, ActivityTable.ActivityHiddenStageData hiddenData, out int finishendCnt, out int totalCnt)
		{
			return Act9D0HiddenStageMissionNotifyViewModel.HiddenStageMissionNotifyState.NONE;
		}

		// Token: 0x060293F2 RID: 168946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60293F2")]
		[Address(RVA = "0x2497600", Offset = "0x2496200", VA = "0x182497600")]
		private string _GetToastByState(Act9D0HiddenStageMissionNotifyViewModel.HiddenStageMissionNotifyState state, string actId, int progress = 0, int total = 0)
		{
			return null;
		}

		// Token: 0x060293F3 RID: 168947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293F3")]
		[Address(RVA = "0x24978C0", Offset = "0x24964C0", VA = "0x1824978C0")]
		public Act9D0HiddenStageMissionNotifyViewModel()
		{
		}

		// Token: 0x0403AE87 RID: 241287
		[Token(Token = "0x403AE87")]
		[FieldOffset(Offset = "0x10")]
		public string rawActId;

		// Token: 0x0403AE88 RID: 241288
		[Token(Token = "0x403AE88")]
		[FieldOffset(Offset = "0x18")]
		public Act9D0HiddenStageMissionNotifyViewModel.HiddenStageMissionNotifyState notifyState;

		// Token: 0x0403AE89 RID: 241289
		[Token(Token = "0x403AE89")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x0403AE8A RID: 241290
		[Token(Token = "0x403AE8A")]
		[FieldOffset(Offset = "0x28")]
		public string textContent;

		// Token: 0x0403AE8B RID: 241291
		[Token(Token = "0x403AE8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AE8C RID: 241292
		[Token(Token = "0x403AE8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenRawActId;

		// Token: 0x0403AE8D RID: 241293
		[Token(Token = "0x403AE8D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenToastWithMsg;

		// Token: 0x0403AE8E RID: 241294
		[Token(Token = "0x403AE8E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetNotifyStage;

		// Token: 0x0403AE8F RID: 241295
		[Token(Token = "0x403AE8F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetToastByState;

		// Token: 0x0403AE90 RID: 241296
		[Token(Token = "0x403AE90")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007181 RID: 29057
		[Token(Token = "0x2007181")]
		public enum HiddenStageMissionNotifyState
		{
			// Token: 0x0403AE92 RID: 241298
			[Token(Token = "0x403AE92")]
			NONE,
			// Token: 0x0403AE93 RID: 241299
			[Token(Token = "0x403AE93")]
			HIDDEN_STAGE_UNLOCK,
			// Token: 0x0403AE94 RID: 241300
			[Token(Token = "0x403AE94")]
			HIDDEN_STAGE_UPDATE,
			// Token: 0x0403AE95 RID: 241301
			[Token(Token = "0x403AE95")]
			HIDDEN_MISSION_UPDATE,
			// Token: 0x0403AE96 RID: 241302
			[Token(Token = "0x403AE96")]
			HIDDEN_MISSION_COMPLETE
		}
	}
}
