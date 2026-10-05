using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E68 RID: 28264
	[Token(Token = "0x2006E68")]
	public class VecBreakV2OffenseRaidModel : IHotfixable
	{
		// Token: 0x17005F03 RID: 24323
		// (get) Token: 0x0602838F RID: 164751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F03")]
		public VecBreakV2OffenseRaidStageModel currStageModel
		{
			[Token(Token = "0x602838F")]
			[Address(RVA = "0x238ADC0", Offset = "0x23899C0", VA = "0x18238ADC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005F04 RID: 24324
		// (get) Token: 0x06028390 RID: 164752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F04")]
		public string currStageId
		{
			[Token(Token = "0x6028390")]
			[Address(RVA = "0x238AD40", Offset = "0x2389940", VA = "0x18238AD40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028391 RID: 164753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028391")]
		[Address(RVA = "0x238A330", Offset = "0x2388F30", VA = "0x18238A330")]
		public void InitData(string actId, string prevBattleStageId)
		{
		}

		// Token: 0x06028392 RID: 164754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028392")]
		[Address(RVA = "0x238A610", Offset = "0x2389210", VA = "0x18238A610")]
		public void UpdateEnterSeqNum()
		{
		}

		// Token: 0x06028393 RID: 164755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028393")]
		[Address(RVA = "0x238A880", Offset = "0x2389480", VA = "0x18238A880")]
		private void _InitStageList(string actId, ActVecBreakV2Data actData)
		{
		}

		// Token: 0x06028394 RID: 164756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028394")]
		[Address(RVA = "0x238AB50", Offset = "0x2389750", VA = "0x18238AB50")]
		private void _LoadData(string prevBattleStageId)
		{
		}

		// Token: 0x06028395 RID: 164757 RVA: 0x000D0F08 File Offset: 0x000CF108
		[Token(Token = "0x6028395")]
		[Address(RVA = "0x238A670", Offset = "0x2389270", VA = "0x18238A670")]
		private int _CalcSelectStageIdx(string prevBattleStageId)
		{
			return 0;
		}

		// Token: 0x06028396 RID: 164758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028396")]
		[Address(RVA = "0x238A510", Offset = "0x2389110", VA = "0x18238A510")]
		public void SelectStageByOrderId(ActVecBreakV2StageOrderType orderType)
		{
		}

		// Token: 0x06028397 RID: 164759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028397")]
		[Address(RVA = "0x238A740", Offset = "0x2389340", VA = "0x18238A740")]
		private VecBreakV2OffenseRaidStageModel _FindStageModelById(string stageId, out int stageIdx)
		{
			return null;
		}

		// Token: 0x06028398 RID: 164760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028398")]
		[Address(RVA = "0x238AC80", Offset = "0x2389880", VA = "0x18238AC80")]
		public VecBreakV2OffenseRaidModel()
		{
		}

		// Token: 0x040392A0 RID: 234144
		[Token(Token = "0x40392A0")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x040392A1 RID: 234145
		[Token(Token = "0x40392A1")]
		[FieldOffset(Offset = "0x18")]
		public List<VecBreakV2OffenseRaidStageModel> stageList;

		// Token: 0x040392A2 RID: 234146
		[Token(Token = "0x40392A2")]
		[FieldOffset(Offset = "0x20")]
		public int enterSeqNum;

		// Token: 0x040392A3 RID: 234147
		[Token(Token = "0x40392A3")]
		[FieldOffset(Offset = "0x24")]
		public int currStageIdx;

		// Token: 0x040392A4 RID: 234148
		[Token(Token = "0x40392A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currStageModel;

		// Token: 0x040392A5 RID: 234149
		[Token(Token = "0x40392A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currStageId;

		// Token: 0x040392A6 RID: 234150
		[Token(Token = "0x40392A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040392A7 RID: 234151
		[Token(Token = "0x40392A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateEnterSeqNum;

		// Token: 0x040392A8 RID: 234152
		[Token(Token = "0x40392A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitStageList;

		// Token: 0x040392A9 RID: 234153
		[Token(Token = "0x40392A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x040392AA RID: 234154
		[Token(Token = "0x40392AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalcSelectStageIdx;

		// Token: 0x040392AB RID: 234155
		[Token(Token = "0x40392AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SelectStageByOrderId;

		// Token: 0x040392AC RID: 234156
		[Token(Token = "0x40392AC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FindStageModelById;

		// Token: 0x040392AD RID: 234157
		[Token(Token = "0x40392AD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
