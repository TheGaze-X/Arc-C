using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DE7 RID: 28135
	[Token(Token = "0x2006DE7")]
	public class ActVecBreakV2DefenseBattleFinishViewModel : IHotfixable
	{
		// Token: 0x060280F9 RID: 164089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280F9")]
		[Address(RVA = "0x234CFE0", Offset = "0x234BBE0", VA = "0x18234CFE0")]
		public void LoadData()
		{
		}

		// Token: 0x060280FA RID: 164090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280FA")]
		[Address(RVA = "0x234DAD0", Offset = "0x234C6D0", VA = "0x18234DAD0")]
		public ActVecBreakV2DefenseBattleFinishViewModel()
		{
		}

		// Token: 0x04038D17 RID: 232727
		[Token(Token = "0x4038D17")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04038D18 RID: 232728
		[Token(Token = "0x4038D18")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04038D19 RID: 232729
		[Token(Token = "0x4038D19")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<int, ActVecBreakV2DefenseCharSlotModel> prevCharSlotList;

		// Token: 0x04038D1A RID: 232730
		[Token(Token = "0x4038D1A")]
		[FieldOffset(Offset = "0x28")]
		public List<ActVecBreakV2BattleFinishCharModel> newCharSlotList;

		// Token: 0x04038D1B RID: 232731
		[Token(Token = "0x4038D1B")]
		[FieldOffset(Offset = "0x30")]
		public bool showSavePanel;

		// Token: 0x04038D1C RID: 232732
		[Token(Token = "0x4038D1C")]
		[FieldOffset(Offset = "0x38")]
		public string buffEquipedToast;

		// Token: 0x04038D1D RID: 232733
		[Token(Token = "0x4038D1D")]
		[FieldOffset(Offset = "0x40")]
		public string stageCompleteToast;

		// Token: 0x04038D1E RID: 232734
		[Token(Token = "0x4038D1E")]
		[FieldOffset(Offset = "0x48")]
		public bool isBuffActivated;

		// Token: 0x04038D1F RID: 232735
		[Token(Token = "0x4038D1F")]
		[FieldOffset(Offset = "0x50")]
		public string squadReplaceToast;

		// Token: 0x04038D20 RID: 232736
		[Token(Token = "0x4038D20")]
		[FieldOffset(Offset = "0x58")]
		public string stageCompleteTimeStr;

		// Token: 0x04038D21 RID: 232737
		[Token(Token = "0x4038D21")]
		[FieldOffset(Offset = "0x60")]
		public string stageCode;

		// Token: 0x04038D22 RID: 232738
		[Token(Token = "0x4038D22")]
		[FieldOffset(Offset = "0x68")]
		public string stageName;

		// Token: 0x04038D23 RID: 232739
		[Token(Token = "0x4038D23")]
		[FieldOffset(Offset = "0x70")]
		public int defenseSquadCharLimitCount;

		// Token: 0x04038D24 RID: 232740
		[Token(Token = "0x4038D24")]
		[FieldOffset(Offset = "0x78")]
		public string playerNameWithNumber;

		// Token: 0x04038D25 RID: 232741
		[Token(Token = "0x4038D25")]
		[FieldOffset(Offset = "0x80")]
		public int milestoneBefore;

		// Token: 0x04038D26 RID: 232742
		[Token(Token = "0x4038D26")]
		[FieldOffset(Offset = "0x84")]
		public int milestoneAfter;

		// Token: 0x04038D27 RID: 232743
		[Token(Token = "0x4038D27")]
		[FieldOffset(Offset = "0x88")]
		public string buffIconId;

		// Token: 0x04038D28 RID: 232744
		[Token(Token = "0x4038D28")]
		[FieldOffset(Offset = "0x90")]
		public string buffName;

		// Token: 0x04038D29 RID: 232745
		[Token(Token = "0x4038D29")]
		[FieldOffset(Offset = "0x98")]
		public long finishTs;

		// Token: 0x04038D2A RID: 232746
		[Token(Token = "0x4038D2A")]
		[FieldOffset(Offset = "0xA0")]
		public string milestoneItemId;

		// Token: 0x04038D2B RID: 232747
		[Token(Token = "0x4038D2B")]
		[FieldOffset(Offset = "0xA8")]
		public string milestoneItemIconId;

		// Token: 0x04038D2C RID: 232748
		[Token(Token = "0x4038D2C")]
		[FieldOffset(Offset = "0xB0")]
		public CharUISkinStruct randomSkin;

		// Token: 0x04038D2D RID: 232749
		[Token(Token = "0x4038D2D")]
		[FieldOffset(Offset = "0xC8")]
		public bool battlePassed;

		// Token: 0x04038D2E RID: 232750
		[Token(Token = "0x4038D2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038D2F RID: 232751
		[Token(Token = "0x4038D2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
