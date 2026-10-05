using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E26 RID: 28198
	[Token(Token = "0x2006E26")]
	public class ActVecBreakV2DefenseStageSelectViewModel : IHotfixable
	{
		// Token: 0x0602822F RID: 164399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602822F")]
		[Address(RVA = "0x236E060", Offset = "0x236CC60", VA = "0x18236E060")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028230 RID: 164400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028230")]
		[Address(RVA = "0x236E1B0", Offset = "0x236CDB0", VA = "0x18236E1B0")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x06028231 RID: 164401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028231")]
		[Address(RVA = "0x236E340", Offset = "0x236CF40", VA = "0x18236E340")]
		public void SelectStage(string stageId)
		{
		}

		// Token: 0x06028232 RID: 164402 RVA: 0x000D0C68 File Offset: 0x000CEE68
		[Token(Token = "0x6028232")]
		[Address(RVA = "0x236E3C0", Offset = "0x236CFC0", VA = "0x18236E3C0")]
		public bool TrySelectBuffByStageId(string stageId, out List<string> ret, out bool replaceSelectedBuff)
		{
			return default(bool);
		}

		// Token: 0x06028233 RID: 164403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028233")]
		[Address(RVA = "0x236E890", Offset = "0x236D490", VA = "0x18236E890")]
		public List<string> UnselectBuff(string unselectBuffId)
		{
			return null;
		}

		// Token: 0x06028234 RID: 164404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028234")]
		[Address(RVA = "0x236DFA0", Offset = "0x236CBA0", VA = "0x18236DFA0")]
		public string GetRemoveSquadNotifyToast(string stageId)
		{
			return null;
		}

		// Token: 0x06028235 RID: 164405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028235")]
		[Address(RVA = "0x236EA70", Offset = "0x236D670", VA = "0x18236EA70")]
		public ActVecBreakV2DefenseStageSelectViewModel()
		{
		}

		// Token: 0x04038FE8 RID: 233448
		[Token(Token = "0x4038FE8")]
		[FieldOffset(Offset = "0x10")]
		public ActVecBreakV2DefenseStageDetailViewModel stageDetailModel;

		// Token: 0x04038FE9 RID: 233449
		[Token(Token = "0x4038FE9")]
		[FieldOffset(Offset = "0x18")]
		public ActVecBreakV2DefenseBuffListViewModel buffListModel;

		// Token: 0x04038FEA RID: 233450
		[Token(Token = "0x4038FEA")]
		[FieldOffset(Offset = "0x20")]
		public string selectedStageId;

		// Token: 0x04038FEB RID: 233451
		[Token(Token = "0x4038FEB")]
		[FieldOffset(Offset = "0x28")]
		public List<string> selectedBuffIdList;

		// Token: 0x04038FEC RID: 233452
		[Token(Token = "0x4038FEC")]
		[FieldOffset(Offset = "0x30")]
		public int maxSelectBuffCount;

		// Token: 0x04038FED RID: 233453
		[Token(Token = "0x4038FED")]
		[FieldOffset(Offset = "0x34")]
		public int selectStageSeqNum;

		// Token: 0x04038FEE RID: 233454
		[Token(Token = "0x4038FEE")]
		[FieldOffset(Offset = "0x38")]
		public int enterStateSeqNum;

		// Token: 0x04038FEF RID: 233455
		[Token(Token = "0x4038FEF")]
		[FieldOffset(Offset = "0x40")]
		public string defenseAddBuffToast;

		// Token: 0x04038FF0 RID: 233456
		[Token(Token = "0x4038FF0")]
		[FieldOffset(Offset = "0x48")]
		public string defenseRemoveBuffToast;

		// Token: 0x04038FF1 RID: 233457
		[Token(Token = "0x4038FF1")]
		[FieldOffset(Offset = "0x50")]
		public string defenseReplaceBuffToast;

		// Token: 0x04038FF2 RID: 233458
		[Token(Token = "0x4038FF2")]
		[FieldOffset(Offset = "0x58")]
		public string defenseBuffExceedToast;

		// Token: 0x04038FF3 RID: 233459
		[Token(Token = "0x4038FF3")]
		[FieldOffset(Offset = "0x60")]
		public string defenseRemoveSquadSingleText;

		// Token: 0x04038FF4 RID: 233460
		[Token(Token = "0x4038FF4")]
		[FieldOffset(Offset = "0x68")]
		public string defenseRemoveSquadGroupText;

		// Token: 0x04038FF5 RID: 233461
		[Token(Token = "0x4038FF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038FF6 RID: 233462
		[Token(Token = "0x4038FF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04038FF7 RID: 233463
		[Token(Token = "0x4038FF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectStage;

		// Token: 0x04038FF8 RID: 233464
		[Token(Token = "0x4038FF8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TrySelectBuffByStageId;

		// Token: 0x04038FF9 RID: 233465
		[Token(Token = "0x4038FF9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnselectBuff;

		// Token: 0x04038FFA RID: 233466
		[Token(Token = "0x4038FFA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRemoveSquadNotifyToast;

		// Token: 0x04038FFB RID: 233467
		[Token(Token = "0x4038FFB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
