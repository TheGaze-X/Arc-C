using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E2B RID: 20011
	[Token(Token = "0x2004E2B")]
	public class FireworkPlateGroupModel : IHotfixable
	{
		// Token: 0x0601DE49 RID: 122441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE49")]
		[Address(RVA = "0x176C4B0", Offset = "0x176B0B0", VA = "0x18176C4B0")]
		public void LoadData(FireworkPlateGroupModel.LoadParam loadParam)
		{
		}

		// Token: 0x0601DE4A RID: 122442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE4A")]
		[Address(RVA = "0x176D280", Offset = "0x176BE80", VA = "0x18176D280")]
		public void UpdateHintList(List<FireworkData.PlateSlotData> hintPieceList)
		{
		}

		// Token: 0x0601DE4B RID: 122443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE4B")]
		[Address(RVA = "0x176D300", Offset = "0x176BF00", VA = "0x18176D300")]
		private void _UpdateHintList(List<FireworkData.PlateSlotData> hintPieceList)
		{
		}

		// Token: 0x0601DE4C RID: 122444 RVA: 0x000ACA88 File Offset: 0x000AAC88
		[Token(Token = "0x601DE4C")]
		[Address(RVA = "0x176BE30", Offset = "0x176AA30", VA = "0x18176BE30")]
		public int GetGroupHintCount(string groupId)
		{
			return 0;
		}

		// Token: 0x0601DE4D RID: 122445 RVA: 0x000ACAA0 File Offset: 0x000AACA0
		[Token(Token = "0x601DE4D")]
		[Address(RVA = "0x176C3A0", Offset = "0x176AFA0", VA = "0x18176C3A0")]
		public bool IsPieceHinted(FireworkData.PlateSlotData platePiece)
		{
			return default(bool);
		}

		// Token: 0x0601DE4E RID: 122446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE4E")]
		[Address(RVA = "0x176D0B0", Offset = "0x176BCB0", VA = "0x18176D0B0")]
		public void SetSelection(FireworkData.PlateSlotData platePiece)
		{
		}

		// Token: 0x0601DE4F RID: 122447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE4F")]
		[Address(RVA = "0x176B850", Offset = "0x176A450", VA = "0x18176B850")]
		public void ClearSelection()
		{
		}

		// Token: 0x0601DE50 RID: 122448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE50")]
		[Address(RVA = "0x176CF60", Offset = "0x176BB60", VA = "0x18176CF60")]
		public void SetPreviewingPlateGroup(string plateGroupId)
		{
		}

		// Token: 0x0601DE51 RID: 122449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE51")]
		[Address(RVA = "0x176B7E0", Offset = "0x176A3E0", VA = "0x18176B7E0")]
		public void ClearPreviewingPlateGroup()
		{
		}

		// Token: 0x0601DE52 RID: 122450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE52")]
		[Address(RVA = "0x176B960", Offset = "0x176A560", VA = "0x18176B960")]
		public void FillPlatePiece(FireworkData.PlateSlotData platePiece)
		{
		}

		// Token: 0x0601DE53 RID: 122451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE53")]
		[Address(RVA = "0x176B6E0", Offset = "0x176A2E0", VA = "0x18176B6E0")]
		public void ClearFilledPlatePiece()
		{
		}

		// Token: 0x0601DE54 RID: 122452 RVA: 0x000ACAB8 File Offset: 0x000AACB8
		[Token(Token = "0x601DE54")]
		[Address(RVA = "0x176C070", Offset = "0x176AC70", VA = "0x18176C070")]
		public int GetPlateSlotFilledIndex(FireworkData.PlateSlotData plateSlot)
		{
			return 0;
		}

		// Token: 0x0601DE55 RID: 122453 RVA: 0x000ACAD0 File Offset: 0x000AACD0
		[Token(Token = "0x601DE55")]
		[Address(RVA = "0x176BD60", Offset = "0x176A960", VA = "0x18176BD60")]
		public int GetFirstEmptyPlateSlotIndex()
		{
			return 0;
		}

		// Token: 0x0601DE56 RID: 122454 RVA: 0x000ACAE8 File Offset: 0x000AACE8
		[Token(Token = "0x601DE56")]
		[Address(RVA = "0x176BF30", Offset = "0x176AB30", VA = "0x18176BF30")]
		public int GetPlateGroupFilledCount(string groupId)
		{
			return 0;
		}

		// Token: 0x0601DE57 RID: 122455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE57")]
		[Address(RVA = "0x176BB60", Offset = "0x176A760", VA = "0x18176BB60")]
		public void GenNotNullFilledPlateList(List<FireworkData.PlateSlotData> outputList)
		{
		}

		// Token: 0x0601DE58 RID: 122456 RVA: 0x000ACB00 File Offset: 0x000AAD00
		[Token(Token = "0x601DE58")]
		[Address(RVA = "0x176BC90", Offset = "0x176A890", VA = "0x18176BC90")]
		public int GetFilledCount()
		{
			return 0;
		}

		// Token: 0x0601DE59 RID: 122457 RVA: 0x000ACB18 File Offset: 0x000AAD18
		[Token(Token = "0x601DE59")]
		[Address(RVA = "0x176C290", Offset = "0x176AE90", VA = "0x18176C290")]
		public bool IsLastPlateValid()
		{
			return default(bool);
		}

		// Token: 0x0601DE5A RID: 122458 RVA: 0x000ACB30 File Offset: 0x000AAD30
		[Token(Token = "0x601DE5A")]
		[Address(RVA = "0x176C1A0", Offset = "0x176ADA0", VA = "0x18176C1A0")]
		public bool IsAllEquipPlateValid()
		{
			return default(bool);
		}

		// Token: 0x0601DE5B RID: 122459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE5B")]
		[Address(RVA = "0x176D380", Offset = "0x176BF80", VA = "0x18176D380")]
		public FireworkPlateGroupModel()
		{
		}

		// Token: 0x04027A5E RID: 162398
		[Token(Token = "0x4027A5E")]
		[FieldOffset(Offset = "0x10")]
		private List<FireworkData.PlateSlotData> m_hintPlatePieceList;

		// Token: 0x04027A5F RID: 162399
		[Token(Token = "0x4027A5F")]
		[FieldOffset(Offset = "0x18")]
		public FireworkPlateModel plateModel;

		// Token: 0x04027A60 RID: 162400
		[Token(Token = "0x4027A60")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, FireworkPieceGroupModel> platePieceList;

		// Token: 0x04027A61 RID: 162401
		[Token(Token = "0x4027A61")]
		[FieldOffset(Offset = "0x28")]
		public FireworkData.PlateSlotData[] filledPlatePieceList;

		// Token: 0x04027A62 RID: 162402
		[Token(Token = "0x4027A62")]
		[FieldOffset(Offset = "0x30")]
		public int maxFilledPlatePieceCount;

		// Token: 0x04027A63 RID: 162403
		[Token(Token = "0x4027A63")]
		[FieldOffset(Offset = "0x38")]
		public FireworkData.PlateSlotData selectedPlatePiece;

		// Token: 0x04027A64 RID: 162404
		[Token(Token = "0x4027A64")]
		[FieldOffset(Offset = "0x40")]
		public PlateContentModel selectedPlateContentModel;

		// Token: 0x04027A65 RID: 162405
		[Token(Token = "0x4027A65")]
		[FieldOffset(Offset = "0x48")]
		public FireworkData.PlateSlotData lastFilledPlatePiece;

		// Token: 0x04027A66 RID: 162406
		[Token(Token = "0x4027A66")]
		[FieldOffset(Offset = "0x50")]
		public PlateContentModel lastFilledPlateContentModel;

		// Token: 0x04027A67 RID: 162407
		[Token(Token = "0x4027A67")]
		[FieldOffset(Offset = "0x58")]
		public bool hasLockedPlate;

		// Token: 0x04027A68 RID: 162408
		[Token(Token = "0x4027A68")]
		[FieldOffset(Offset = "0x59")]
		public bool showNewMark;

		// Token: 0x04027A69 RID: 162409
		[Token(Token = "0x4027A69")]
		[FieldOffset(Offset = "0x60")]
		public string previewingPlateGroupId;

		// Token: 0x04027A6A RID: 162410
		[Token(Token = "0x4027A6A")]
		[FieldOffset(Offset = "0x68")]
		public bool isClearAllExpand;

		// Token: 0x04027A6B RID: 162411
		[Token(Token = "0x4027A6B")]
		[FieldOffset(Offset = "0x6C")]
		public int loadSequenceNum;

		// Token: 0x04027A6C RID: 162412
		[Token(Token = "0x4027A6C")]
		[FieldOffset(Offset = "0x70")]
		public int addPieceSeqNum;

		// Token: 0x04027A6D RID: 162413
		[Token(Token = "0x4027A6D")]
		[FieldOffset(Offset = "0x74")]
		public int removePieceSeqNum;

		// Token: 0x04027A6E RID: 162414
		[Token(Token = "0x4027A6E")]
		[FieldOffset(Offset = "0x78")]
		public int hintUpdateSeqNum;

		// Token: 0x04027A6F RID: 162415
		[Token(Token = "0x4027A6F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027A70 RID: 162416
		[Token(Token = "0x4027A70")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateHintList;

		// Token: 0x04027A71 RID: 162417
		[Token(Token = "0x4027A71")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateHintList;

		// Token: 0x04027A72 RID: 162418
		[Token(Token = "0x4027A72")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetGroupHintCount;

		// Token: 0x04027A73 RID: 162419
		[Token(Token = "0x4027A73")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsPieceHinted;

		// Token: 0x04027A74 RID: 162420
		[Token(Token = "0x4027A74")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetSelection;

		// Token: 0x04027A75 RID: 162421
		[Token(Token = "0x4027A75")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearSelection;

		// Token: 0x04027A76 RID: 162422
		[Token(Token = "0x4027A76")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetPreviewingPlateGroup;

		// Token: 0x04027A77 RID: 162423
		[Token(Token = "0x4027A77")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ClearPreviewingPlateGroup;

		// Token: 0x04027A78 RID: 162424
		[Token(Token = "0x4027A78")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FillPlatePiece;

		// Token: 0x04027A79 RID: 162425
		[Token(Token = "0x4027A79")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ClearFilledPlatePiece;

		// Token: 0x04027A7A RID: 162426
		[Token(Token = "0x4027A7A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetPlateSlotFilledIndex;

		// Token: 0x04027A7B RID: 162427
		[Token(Token = "0x4027A7B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetFirstEmptyPlateSlotIndex;

		// Token: 0x04027A7C RID: 162428
		[Token(Token = "0x4027A7C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetPlateGroupFilledCount;

		// Token: 0x04027A7D RID: 162429
		[Token(Token = "0x4027A7D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GenNotNullFilledPlateList;

		// Token: 0x04027A7E RID: 162430
		[Token(Token = "0x4027A7E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetFilledCount;

		// Token: 0x04027A7F RID: 162431
		[Token(Token = "0x4027A7F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsLastPlateValid;

		// Token: 0x04027A80 RID: 162432
		[Token(Token = "0x4027A80")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_IsAllEquipPlateValid;

		// Token: 0x04027A81 RID: 162433
		[Token(Token = "0x4027A81")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E2C RID: 20012
		[Token(Token = "0x2004E2C")]
		public struct LoadParam
		{
			// Token: 0x04027A82 RID: 162434
			[Token(Token = "0x4027A82")]
			[FieldOffset(Offset = "0x0")]
			public PlateContentModel availablePlateContentModel;

			// Token: 0x04027A83 RID: 162435
			[Token(Token = "0x4027A83")]
			[FieldOffset(Offset = "0x8")]
			public IList<string> platePieceList;

			// Token: 0x04027A84 RID: 162436
			[Token(Token = "0x4027A84")]
			[FieldOffset(Offset = "0x10")]
			public IList<FireworkData.PlateSlotData> filledPlatePieceList;

			// Token: 0x04027A85 RID: 162437
			[Token(Token = "0x4027A85")]
			[FieldOffset(Offset = "0x18")]
			public List<FireworkData.PlateSlotData> hintPlatePieceList;

			// Token: 0x04027A86 RID: 162438
			[Token(Token = "0x4027A86")]
			[FieldOffset(Offset = "0x20")]
			public int maxFilledPlatePieceCount;

			// Token: 0x04027A87 RID: 162439
			[Token(Token = "0x4027A87")]
			[FieldOffset(Offset = "0x24")]
			public bool hasLockedPlate;

			// Token: 0x04027A88 RID: 162440
			[Token(Token = "0x4027A88")]
			[FieldOffset(Offset = "0x25")]
			public bool showNewMark;

			// Token: 0x04027A89 RID: 162441
			[Token(Token = "0x4027A89")]
			[FieldOffset(Offset = "0x26")]
			public bool judgeSucceed;
		}
	}
}
