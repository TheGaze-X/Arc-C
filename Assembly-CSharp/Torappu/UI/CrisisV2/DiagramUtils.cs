using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005926 RID: 22822
	[Token(Token = "0x2005926")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class DiagramUtils
	{
		// Token: 0x060213F1 RID: 136177 RVA: 0x000B9190 File Offset: 0x000B7390
		[Token(Token = "0x60213F1")]
		[Address(RVA = "0x1B9B860", Offset = "0x1B9A460", VA = "0x181B9B860")]
		public static CrisisV2DiagramInput CreateEntryDiagramModel(List<int> totalScore, List<int> maxScore)
		{
			return default(CrisisV2DiagramInput);
		}

		// Token: 0x060213F2 RID: 136178 RVA: 0x000B91A8 File Offset: 0x000B73A8
		[Token(Token = "0x60213F2")]
		[Address(RVA = "0x1B9BAD0", Offset = "0x1B9A6D0", VA = "0x181B9BAD0")]
		public static CrisisV2DiagramInput CreateMapDiagramModel(List<int> totalScore, List<int> currentScore, List<int> maxScore, bool isFast = false)
		{
			return default(CrisisV2DiagramInput);
		}

		// Token: 0x060213F3 RID: 136179 RVA: 0x000B91C0 File Offset: 0x000B73C0
		[Token(Token = "0x60213F3")]
		[Address(RVA = "0x1B9AF30", Offset = "0x1B99B30", VA = "0x181B9AF30")]
		public static CrisisV2DiagramInput CreateAchieveDiagramModel(List<int> totalScore, List<int> singleScore, List<int> maxScore, List<string> descs, bool isFast = false)
		{
			return default(CrisisV2DiagramInput);
		}

		// Token: 0x060213F4 RID: 136180 RVA: 0x000B91D8 File Offset: 0x000B73D8
		[Token(Token = "0x60213F4")]
		[Address(RVA = "0x1B9B270", Offset = "0x1B99E70", VA = "0x181B9B270")]
		public static CrisisV2DiagramInput CreateBattleSettleBigDiagramModel(List<int> totalScore, List<int> currentScore, List<int> maxScore, List<string> descs, bool isFast = false)
		{
			return default(CrisisV2DiagramInput);
		}

		// Token: 0x060213F5 RID: 136181 RVA: 0x000B91F0 File Offset: 0x000B73F0
		[Token(Token = "0x60213F5")]
		[Address(RVA = "0x1B9B5A0", Offset = "0x1B9A1A0", VA = "0x181B9B5A0")]
		public static CrisisV2DiagramInput CreateBattleSettleSmallDiagramModel(List<int> totalScore, List<int> currentScore, List<int> maxScore, bool isNewRecord)
		{
			return default(CrisisV2DiagramInput);
		}

		// Token: 0x0402D4A3 RID: 185507
		[Token(Token = "0x402D4A3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CrisisV2DiagramInput.TweenInput MAP_TWEEN_PARAM;

		// Token: 0x0402D4A4 RID: 185508
		[Token(Token = "0x402D4A4")]
		[FieldOffset(Offset = "0xC")]
		private static readonly CrisisV2DiagramInput.TweenInput BATTLE_FINISH_AND_ARCHIEVE_TWEEN_PARAM;

		// Token: 0x0402D4A5 RID: 185509
		[Token(Token = "0x402D4A5")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Color DARK_GRAY_COLOR;

		// Token: 0x0402D4A6 RID: 185510
		[Token(Token = "0x402D4A6")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Color GRAY_COLOR;

		// Token: 0x0402D4A7 RID: 185511
		[Token(Token = "0x402D4A7")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Color RED_COLOR;

		// Token: 0x0402D4A8 RID: 185512
		[Token(Token = "0x402D4A8")]
		private const float ARCHIEVE_DIAGRAM_SCALE = 0.72f;

		// Token: 0x0402D4A9 RID: 185513
		[Token(Token = "0x402D4A9")]
		private const float MAP_DIAGRAM_SCALE = 0.24f;

		// Token: 0x0402D4AA RID: 185514
		[Token(Token = "0x402D4AA")]
		private const float ENTRY_DIAGRAM_SCLAE = 0.685f;

		// Token: 0x0402D4AB RID: 185515
		[Token(Token = "0x402D4AB")]
		private const float BATTLE_SETTLE_BIG_DIAGRAM_SCALE = 1.15f;

		// Token: 0x0402D4AC RID: 185516
		[Token(Token = "0x402D4AC")]
		private const float BATTLE_SETTLE_SMALL_DIAGRAM_SCALE = 0.75f;

		// Token: 0x0402D4AD RID: 185517
		[Token(Token = "0x402D4AD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateEntryDiagramModel;

		// Token: 0x0402D4AE RID: 185518
		[Token(Token = "0x402D4AE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CreateMapDiagramModel;

		// Token: 0x0402D4AF RID: 185519
		[Token(Token = "0x402D4AF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CreateAchieveDiagramModel;

		// Token: 0x0402D4B0 RID: 185520
		[Token(Token = "0x402D4B0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CreateBattleSettleBigDiagramModel;

		// Token: 0x0402D4B1 RID: 185521
		[Token(Token = "0x402D4B1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CreateBattleSettleSmallDiagramModel;
	}
}
