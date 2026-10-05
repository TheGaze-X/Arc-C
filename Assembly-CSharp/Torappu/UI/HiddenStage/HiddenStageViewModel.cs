using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CA9 RID: 19625
	[Token(Token = "0x2004CA9")]
	public class HiddenStageViewModel : IHotfixable
	{
		// Token: 0x0601D6AE RID: 120494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6AE")]
		[Address(RVA = "0x170B660", Offset = "0x170A260", VA = "0x18170B660")]
		public void LoadData(string stageId)
		{
		}

		// Token: 0x0601D6AF RID: 120495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D6AF")]
		[Address(RVA = "0x170BEC0", Offset = "0x170AAC0", VA = "0x18170BEC0")]
		private PlayerHiddenStage _LoadPlayerHiddenData(string stageId)
		{
			return null;
		}

		// Token: 0x0601D6B0 RID: 120496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6B0")]
		[Address(RVA = "0x170BC70", Offset = "0x170A870", VA = "0x18170BC70")]
		private void _LoadHiddenMission(string stageId, PlayerHiddenStage playerData)
		{
		}

		// Token: 0x0601D6B1 RID: 120497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6B1")]
		[Address(RVA = "0x170BF60", Offset = "0x170AB60", VA = "0x18170BF60")]
		private void _LoadStageViewModel(string stageId)
		{
		}

		// Token: 0x0601D6B2 RID: 120498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6B2")]
		[Address(RVA = "0x170BBA0", Offset = "0x170A7A0", VA = "0x18170BBA0")]
		private void _LoadActRitroInfo(string stageId)
		{
		}

		// Token: 0x0601D6B3 RID: 120499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D6B3")]
		[Address(RVA = "0x170BA10", Offset = "0x170A610", VA = "0x18170BA10")]
		private HiddenStageMissionViewModel _GenMissionViewModel(MissionCalcState state, ActivityTable.ActivityHiddenStageUnlockConditionData missionData)
		{
			return null;
		}

		// Token: 0x0601D6B4 RID: 120500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6B4")]
		[Address(RVA = "0x170C140", Offset = "0x170AD40", VA = "0x18170C140")]
		public HiddenStageViewModel()
		{
		}

		// Token: 0x04026BDE RID: 158686
		[Token(Token = "0x4026BDE")]
		[FieldOffset(Offset = "0x10")]
		public string hiddenStageId;

		// Token: 0x04026BDF RID: 158687
		[Token(Token = "0x4026BDF")]
		[FieldOffset(Offset = "0x18")]
		public string encodedName;

		// Token: 0x04026BE0 RID: 158688
		[Token(Token = "0x4026BE0")]
		[FieldOffset(Offset = "0x20")]
		public bool complete;

		// Token: 0x04026BE1 RID: 158689
		[Token(Token = "0x4026BE1")]
		[FieldOffset(Offset = "0x21")]
		public bool unlocked;

		// Token: 0x04026BE2 RID: 158690
		[Token(Token = "0x4026BE2")]
		[FieldOffset(Offset = "0x22")]
		public bool isDecodePanel;

		// Token: 0x04026BE3 RID: 158691
		[Token(Token = "0x4026BE3")]
		[FieldOffset(Offset = "0x23")]
		public bool playDecodeAnim;

		// Token: 0x04026BE4 RID: 158692
		[Token(Token = "0x4026BE4")]
		[FieldOffset(Offset = "0x24")]
		public bool isRetro;

		// Token: 0x04026BE5 RID: 158693
		[Token(Token = "0x4026BE5")]
		[FieldOffset(Offset = "0x28")]
		public string actId;

		// Token: 0x04026BE6 RID: 158694
		[Token(Token = "0x4026BE6")]
		[FieldOffset(Offset = "0x30")]
		public List<HiddenStageMissionViewModel> missionViewModels;

		// Token: 0x04026BE7 RID: 158695
		[Token(Token = "0x4026BE7")]
		[FieldOffset(Offset = "0x38")]
		public StageViewModel stageViewModel;

		// Token: 0x04026BE8 RID: 158696
		[Token(Token = "0x4026BE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026BE9 RID: 158697
		[Token(Token = "0x4026BE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadPlayerHiddenData;

		// Token: 0x04026BEA RID: 158698
		[Token(Token = "0x4026BEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadHiddenMission;

		// Token: 0x04026BEB RID: 158699
		[Token(Token = "0x4026BEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadStageViewModel;

		// Token: 0x04026BEC RID: 158700
		[Token(Token = "0x4026BEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadActRitroInfo;

		// Token: 0x04026BED RID: 158701
		[Token(Token = "0x4026BED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenMissionViewModel;

		// Token: 0x04026BEE RID: 158702
		[Token(Token = "0x4026BEE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
