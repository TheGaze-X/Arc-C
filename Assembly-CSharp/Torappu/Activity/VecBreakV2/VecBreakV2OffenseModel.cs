using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E61 RID: 28257
	[Token(Token = "0x2006E61")]
	public class VecBreakV2OffenseModel : IHotfixable
	{
		// Token: 0x17005EFC RID: 24316
		// (get) Token: 0x0602836F RID: 164719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EFC")]
		public VecBreakV2OffenseStageModel currStageModel
		{
			[Token(Token = "0x602836F")]
			[Address(RVA = "0x238A1E0", Offset = "0x2388DE0", VA = "0x18238A1E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EFD RID: 24317
		// (get) Token: 0x06028370 RID: 164720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EFD")]
		public VecBreakV2OffenseStageModel nextStageModel
		{
			[Token(Token = "0x6028370")]
			[Address(RVA = "0x238A2B0", Offset = "0x2388EB0", VA = "0x18238A2B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005EFE RID: 24318
		// (get) Token: 0x06028371 RID: 164721 RVA: 0x000D0E48 File Offset: 0x000CF048
		[Token(Token = "0x17005EFE")]
		public bool hasPrevStage
		{
			[Token(Token = "0x6028371")]
			[Address(RVA = "0x238A250", Offset = "0x2388E50", VA = "0x18238A250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005EFF RID: 24319
		// (get) Token: 0x06028372 RID: 164722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EFF")]
		public string currStageId
		{
			[Token(Token = "0x6028372")]
			[Address(RVA = "0x238A160", Offset = "0x2388D60", VA = "0x18238A160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028373 RID: 164723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028373")]
		[Address(RVA = "0x2389390", Offset = "0x2387F90", VA = "0x182389390")]
		public void InitData(string actId, string prevBattleStageId, bool isStageCompletedBeforeBattle)
		{
		}

		// Token: 0x06028374 RID: 164724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028374")]
		[Address(RVA = "0x2389500", Offset = "0x2388100", VA = "0x182389500")]
		public void LoadData([Optional] string prevBattleStageId, bool isStageCompletedBeforeBattle = false)
		{
		}

		// Token: 0x06028375 RID: 164725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028375")]
		[Address(RVA = "0x2389C00", Offset = "0x2388800", VA = "0x182389C00")]
		private void _InitStageList(string actId, ActVecBreakV2Data actData)
		{
		}

		// Token: 0x06028376 RID: 164726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028376")]
		[Address(RVA = "0x23897F0", Offset = "0x23883F0", VA = "0x1823897F0")]
		public void NavPrev()
		{
		}

		// Token: 0x06028377 RID: 164727 RVA: 0x000D0E60 File Offset: 0x000CF060
		[Token(Token = "0x6028377")]
		[Address(RVA = "0x2389850", Offset = "0x2388450", VA = "0x182389850")]
		public bool TryNavNext()
		{
			return default(bool);
		}

		// Token: 0x06028378 RID: 164728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028378")]
		[Address(RVA = "0x2389990", Offset = "0x2388590", VA = "0x182389990")]
		public void UpdateEnterSeqNum()
		{
		}

		// Token: 0x06028379 RID: 164729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028379")]
		[Address(RVA = "0x23898D0", Offset = "0x23884D0", VA = "0x1823898D0")]
		public void UpdateBtnSeqNum()
		{
		}

		// Token: 0x0602837A RID: 164730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602837A")]
		[Address(RVA = "0x2389930", Offset = "0x2388530", VA = "0x182389930")]
		public void UpdateDecoSeqNum()
		{
		}

		// Token: 0x0602837B RID: 164731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602837B")]
		[Address(RVA = "0x2389A60", Offset = "0x2388660", VA = "0x182389A60")]
		public void UpdateTowerSeqNum()
		{
		}

		// Token: 0x0602837C RID: 164732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602837C")]
		[Address(RVA = "0x23899F0", Offset = "0x23885F0", VA = "0x1823899F0")]
		public void UpdateTowerAnimStatus(bool beforeCollapse)
		{
		}

		// Token: 0x0602837D RID: 164733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602837D")]
		[Address(RVA = "0x2389AC0", Offset = "0x23886C0", VA = "0x182389AC0")]
		private VecBreakV2OffenseStageModel _FindStageModelById(string stageId, out int stageIdx)
		{
			return null;
		}

		// Token: 0x0602837E RID: 164734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602837E")]
		[Address(RVA = "0x238A0B0", Offset = "0x2388CB0", VA = "0x18238A0B0")]
		public VecBreakV2OffenseModel()
		{
		}

		// Token: 0x04039258 RID: 234072
		[Token(Token = "0x4039258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04039259 RID: 234073
		[Token(Token = "0x4039259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxLevel;

		// Token: 0x0403925A RID: 234074
		[Token(Token = "0x403925A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<VecBreakV2OffenseStageModel> stageList;

		// Token: 0x0403925B RID: 234075
		[Token(Token = "0x403925B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string offenseNavLockToastStr;

		// Token: 0x0403925C RID: 234076
		[Token(Token = "0x403925C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string offenseNavLockToastStageId;

		// Token: 0x0403925D RID: 234077
		[Token(Token = "0x403925D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int currStageIdx;

		// Token: 0x0403925E RID: 234078
		[Token(Token = "0x403925E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int enterSeqNum;

		// Token: 0x0403925F RID: 234079
		[Token(Token = "0x403925F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int btnSeqNum;

		// Token: 0x04039260 RID: 234080
		[Token(Token = "0x4039260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int decoSeqNum;

		// Token: 0x04039261 RID: 234081
		[Token(Token = "0x4039261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int towerSeqNum;

		// Token: 0x04039262 RID: 234082
		[Token(Token = "0x4039262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool beforeCollapse;

		// Token: 0x04039263 RID: 234083
		[Token(Token = "0x4039263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool fromBattle;

		// Token: 0x04039264 RID: 234084
		[Token(Token = "0x4039264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool needNavNext;

		// Token: 0x04039265 RID: 234085
		[Token(Token = "0x4039265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ActVecBreakV2ZoneViewModel hardZoneModel;

		// Token: 0x04039266 RID: 234086
		[Token(Token = "0x4039266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currStageModel;

		// Token: 0x04039267 RID: 234087
		[Token(Token = "0x4039267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nextStageModel;

		// Token: 0x04039268 RID: 234088
		[Token(Token = "0x4039268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasPrevStage;

		// Token: 0x04039269 RID: 234089
		[Token(Token = "0x4039269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currStageId;

		// Token: 0x0403926A RID: 234090
		[Token(Token = "0x403926A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403926B RID: 234091
		[Token(Token = "0x403926B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403926C RID: 234092
		[Token(Token = "0x403926C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitStageList;

		// Token: 0x0403926D RID: 234093
		[Token(Token = "0x403926D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NavPrev;

		// Token: 0x0403926E RID: 234094
		[Token(Token = "0x403926E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryNavNext;

		// Token: 0x0403926F RID: 234095
		[Token(Token = "0x403926F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateEnterSeqNum;

		// Token: 0x04039270 RID: 234096
		[Token(Token = "0x4039270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateBtnSeqNum;

		// Token: 0x04039271 RID: 234097
		[Token(Token = "0x4039271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateDecoSeqNum;

		// Token: 0x04039272 RID: 234098
		[Token(Token = "0x4039272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateTowerSeqNum;

		// Token: 0x04039273 RID: 234099
		[Token(Token = "0x4039273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateTowerAnimStatus;

		// Token: 0x04039274 RID: 234100
		[Token(Token = "0x4039274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__FindStageModelById;

		// Token: 0x04039275 RID: 234101
		[Token(Token = "0x4039275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
