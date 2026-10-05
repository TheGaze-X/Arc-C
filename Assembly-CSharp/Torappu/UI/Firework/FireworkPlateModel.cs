using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E34 RID: 20020
	[Token(Token = "0x2004E34")]
	public class FireworkPlateModel : IHotfixable
	{
		// Token: 0x0601DE82 RID: 122498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE82")]
		[Address(RVA = "0x176F1B0", Offset = "0x176DDB0", VA = "0x18176F1B0")]
		public void LoadData(FireworkPlateModel.LoadParam loadParam)
		{
		}

		// Token: 0x0601DE83 RID: 122499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE83")]
		[Address(RVA = "0x176F870", Offset = "0x176E470", VA = "0x18176F870")]
		public void ReloadSlots(IList<FireworkData.PlateSlotData> filledPlatePieceList)
		{
		}

		// Token: 0x0601DE84 RID: 122500 RVA: 0x000ACCF8 File Offset: 0x000AAEF8
		[Token(Token = "0x601DE84")]
		[Address(RVA = "0x176EEA0", Offset = "0x176DAA0", VA = "0x18176EEA0")]
		public FireworkPlateSlotType GetSlotType(GridPosition slotPos)
		{
			return FireworkPlateSlotType.NONE;
		}

		// Token: 0x0601DE85 RID: 122501 RVA: 0x000ACD10 File Offset: 0x000AAF10
		[Token(Token = "0x601DE85")]
		[Address(RVA = "0x176EFB0", Offset = "0x176DBB0", VA = "0x18176EFB0")]
		public bool IsAllEquipPlateValid()
		{
			return default(bool);
		}

		// Token: 0x0601DE86 RID: 122502 RVA: 0x000ACD28 File Offset: 0x000AAF28
		[Token(Token = "0x601DE86")]
		[Address(RVA = "0x176F050", Offset = "0x176DC50", VA = "0x18176F050")]
		public bool IsLastPlateValid(PlateContentModel lastFilledPlate)
		{
			return default(bool);
		}

		// Token: 0x0601DE87 RID: 122503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DE87")]
		[Address(RVA = "0x176F100", Offset = "0x176DD00", VA = "0x18176F100")]
		public IEnumerable<GridPosition> IterAllGrids()
		{
			return null;
		}

		// Token: 0x0601DE88 RID: 122504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE88")]
		[Address(RVA = "0x176FAB0", Offset = "0x176E6B0", VA = "0x18176FAB0")]
		public FireworkPlateModel()
		{
		}

		// Token: 0x04027AE3 RID: 162531
		[Token(Token = "0x4027AE3")]
		[FieldOffset(Offset = "0x10")]
		public PlateContentModel availablePlateContentModel;

		// Token: 0x04027AE4 RID: 162532
		[Token(Token = "0x4027AE4")]
		[FieldOffset(Offset = "0x18")]
		public PlateContentModel filledPlateContentModel;

		// Token: 0x04027AE5 RID: 162533
		[Token(Token = "0x4027AE5")]
		[FieldOffset(Offset = "0x20")]
		public int filledPlateRank;

		// Token: 0x04027AE6 RID: 162534
		[Token(Token = "0x4027AE6")]
		[FieldOffset(Offset = "0x24")]
		public int plateRowCount;

		// Token: 0x04027AE7 RID: 162535
		[Token(Token = "0x4027AE7")]
		[FieldOffset(Offset = "0x28")]
		public bool judgeSucceed;

		// Token: 0x04027AE8 RID: 162536
		[Token(Token = "0x4027AE8")]
		[FieldOffset(Offset = "0x29")]
		public bool isSucceed;

		// Token: 0x04027AE9 RID: 162537
		[Token(Token = "0x4027AE9")]
		[FieldOffset(Offset = "0x2C")]
		public int loadSequenceNum;

		// Token: 0x04027AEA RID: 162538
		[Token(Token = "0x4027AEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027AEB RID: 162539
		[Token(Token = "0x4027AEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReloadSlots;

		// Token: 0x04027AEC RID: 162540
		[Token(Token = "0x4027AEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSlotType;

		// Token: 0x04027AED RID: 162541
		[Token(Token = "0x4027AED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsAllEquipPlateValid;

		// Token: 0x04027AEE RID: 162542
		[Token(Token = "0x4027AEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsLastPlateValid;

		// Token: 0x04027AEF RID: 162543
		[Token(Token = "0x4027AEF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IterAllGrids;

		// Token: 0x04027AF0 RID: 162544
		[Token(Token = "0x4027AF0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E35 RID: 20021
		[Token(Token = "0x2004E35")]
		public struct LoadParam
		{
			// Token: 0x04027AF1 RID: 162545
			[Token(Token = "0x4027AF1")]
			[FieldOffset(Offset = "0x0")]
			public PlateContentModel availablePlateContentModel;

			// Token: 0x04027AF2 RID: 162546
			[Token(Token = "0x4027AF2")]
			[FieldOffset(Offset = "0x8")]
			public IList<FireworkData.PlateSlotData> filledPlatePieceList;

			// Token: 0x04027AF3 RID: 162547
			[Token(Token = "0x4027AF3")]
			[FieldOffset(Offset = "0x10")]
			public bool judgeSucceed;
		}
	}
}
