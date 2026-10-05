using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005634 RID: 22068
	[Token(Token = "0x2005634")]
	public class RL05SquadBattleStartHandler : DefaultRoguelikeSquadBattleStartHandler
	{
		// Token: 0x06020625 RID: 132645 RVA: 0x000B5AE8 File Offset: 0x000B3CE8
		[Token(Token = "0x6020625")]
		[Address(RVA = "0x1A87630", Offset = "0x1A86230", VA = "0x181A87630", Slot = "6")]
		protected override bool NeedCustomCheck(RoguelikeSquadStateBean bean)
		{
			return default(bool);
		}

		// Token: 0x06020626 RID: 132646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020626")]
		[Address(RVA = "0x1A87590", Offset = "0x1A86190", VA = "0x181A87590", Slot = "7")]
		protected override void HandleCustomCheck(RoguelikeSquadStateBean bean, List<RequestSquadSlot> filterdSlots, Action<List<RequestSquadSlot>> battleStarter)
		{
		}

		// Token: 0x06020627 RID: 132647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020627")]
		[Address(RVA = "0x1A873B0", Offset = "0x1A85FB0", VA = "0x181A873B0", Slot = "8")]
		protected override List<RequestSquadSlot> GenerateFilteredSlots(RoguelikeSquadStateBean bean)
		{
			return null;
		}

		// Token: 0x06020628 RID: 132648 RVA: 0x000B5B00 File Offset: 0x000B3D00
		[Token(Token = "0x6020628")]
		[Address(RVA = "0x1A87A60", Offset = "0x1A86660", VA = "0x181A87A60")]
		private bool _IsSlotPassFilter(PlayerRoguelikeZoneType curZoneType, string candleHolderBuffId, int instId)
		{
			return default(bool);
		}

		// Token: 0x06020629 RID: 132649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020629")]
		[Address(RVA = "0x1A87B00", Offset = "0x1A86700", VA = "0x181A87B00")]
		private void _ShowSpZoneJudgeDialog(RoguelikeSquadStateBean bean, List<RequestSquadSlot> filteredSlots, Action<List<RequestSquadSlot>> battleStarter)
		{
		}

		// Token: 0x0602062A RID: 132650 RVA: 0x000B5B18 File Offset: 0x000B3D18
		[Token(Token = "0x602062A")]
		[Address(RVA = "0x1A87880", Offset = "0x1A86480", VA = "0x181A87880")]
		private bool _CheckExitNoCopperSlot(RoguelikeSquadStateBean bean)
		{
			return default(bool);
		}

		// Token: 0x0602062B RID: 132651 RVA: 0x000B5B30 File Offset: 0x000B3D30
		[Token(Token = "0x602062B")]
		[Address(RVA = "0x1A879B0", Offset = "0x1A865B0", VA = "0x181A879B0")]
		private bool _CheckIfDialogDisabledThisGame(RoguelikeSquadStateBean bean)
		{
			return default(bool);
		}

		// Token: 0x0602062C RID: 132652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602062C")]
		[Address(RVA = "0x1A87CD0", Offset = "0x1A868D0", VA = "0x181A87CD0")]
		public RL05SquadBattleStartHandler()
		{
		}

		// Token: 0x0602062D RID: 132653 RVA: 0x000B5B48 File Offset: 0x000B3D48
		[Token(Token = "0x602062D")]
		[Address(RVA = "0x1A87870", Offset = "0x1A86470", VA = "0x181A87870")]
		private bool <>xLuaBaseProxy_NeedCustomCheck(RoguelikeSquadStateBean P0)
		{
			return default(bool);
		}

		// Token: 0x0602062E RID: 132654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602062E")]
		[Address(RVA = "0x1A87860", Offset = "0x1A86460", VA = "0x181A87860")]
		private void <>xLuaBaseProxy_HandleCustomCheck(RoguelikeSquadStateBean P0, List<RequestSquadSlot> P1, Action<List<RequestSquadSlot>> P2)
		{
		}

		// Token: 0x0602062F RID: 132655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602062F")]
		[Address(RVA = "0x1A87850", Offset = "0x1A86450", VA = "0x181A87850")]
		private List<RequestSquadSlot> <>xLuaBaseProxy_GenerateFilteredSlots(RoguelikeSquadStateBean P0)
		{
			return null;
		}

		// Token: 0x0402BD75 RID: 179573
		[Token(Token = "0x402BD75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NeedCustomCheck;

		// Token: 0x0402BD76 RID: 179574
		[Token(Token = "0x402BD76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleCustomCheck;

		// Token: 0x0402BD77 RID: 179575
		[Token(Token = "0x402BD77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateFilteredSlots;

		// Token: 0x0402BD78 RID: 179576
		[Token(Token = "0x402BD78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__IsSlotPassFilter;

		// Token: 0x0402BD79 RID: 179577
		[Token(Token = "0x402BD79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowSpZoneJudgeDialog;

		// Token: 0x0402BD7A RID: 179578
		[Token(Token = "0x402BD7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckExitNoCopperSlot;

		// Token: 0x0402BD7B RID: 179579
		[Token(Token = "0x402BD7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckIfDialogDisabledThisGame;

		// Token: 0x0402BD7C RID: 179580
		[Token(Token = "0x402BD7C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
