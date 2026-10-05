using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007986 RID: 31110
	[Token(Token = "0x2007986")]
	public class Act1ArcadeStageSelectViewModel : IHotfixable
	{
		// Token: 0x17006664 RID: 26212
		// (get) Token: 0x0602BA5A RID: 178778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006664")]
		public Dictionary<string, Act1ArcadeSingleZoneModel> zoneModelDict
		{
			[Token(Token = "0x602BA5A")]
			[Address(RVA = "0x2791230", Offset = "0x278FE30", VA = "0x182791230")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BA5B RID: 178779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA5B")]
		[Address(RVA = "0x2790680", Offset = "0x278F280", VA = "0x182790680")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x0602BA5C RID: 178780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA5C")]
		[Address(RVA = "0x2790D80", Offset = "0x278F980", VA = "0x182790D80")]
		private void _RefreshCurSelectZoneAndStage(string prefBattleStageId)
		{
		}

		// Token: 0x0602BA5D RID: 178781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA5D")]
		[Address(RVA = "0x27908E0", Offset = "0x278F4E0", VA = "0x1827908E0")]
		public void UpdateData()
		{
		}

		// Token: 0x0602BA5E RID: 178782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA5E")]
		[Address(RVA = "0x2790500", Offset = "0x278F100", VA = "0x182790500")]
		public Act1ArcadeSingleStageModel GetStageModel(string stageId)
		{
			return null;
		}

		// Token: 0x0602BA5F RID: 178783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA5F")]
		[Address(RVA = "0x27905C0", Offset = "0x278F1C0", VA = "0x1827905C0")]
		public Act1ArcadeSingleZoneModel GetZoneModel(string zoneId)
		{
			return null;
		}

		// Token: 0x0602BA60 RID: 178784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA60")]
		[Address(RVA = "0x278FFD0", Offset = "0x278EBD0", VA = "0x18278FFD0")]
		public void FillBuffRuneList(List<RuneTable.PackedRuneData> runeList)
		{
		}

		// Token: 0x0602BA61 RID: 178785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA61")]
		[Address(RVA = "0x2790830", Offset = "0x278F430", VA = "0x182790830")]
		public void SetSelectStage(string prefBattleStageId)
		{
		}

		// Token: 0x0602BA62 RID: 178786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA62")]
		[Address(RVA = "0x2790150", Offset = "0x278ED50", VA = "0x182790150")]
		public string GetDefaultSelectStageIdByZoneId(string selectZoneId)
		{
			return null;
		}

		// Token: 0x0602BA63 RID: 178787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA63")]
		[Address(RVA = "0x2790F80", Offset = "0x278FB80", VA = "0x182790F80")]
		public Act1ArcadeStageSelectViewModel()
		{
		}

		// Token: 0x0403F234 RID: 258612
		[Token(Token = "0x403F234")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403F235 RID: 258613
		[Token(Token = "0x403F235")]
		[FieldOffset(Offset = "0x18")]
		public string curSelectStageId;

		// Token: 0x0403F236 RID: 258614
		[Token(Token = "0x403F236")]
		[FieldOffset(Offset = "0x20")]
		public string curSelectZoneId;

		// Token: 0x0403F237 RID: 258615
		[Token(Token = "0x403F237")]
		[FieldOffset(Offset = "0x28")]
		public ActArcadeData arcadeData;

		// Token: 0x0403F238 RID: 258616
		[Token(Token = "0x403F238")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerArcadeActivity arcadePlayerData;

		// Token: 0x0403F239 RID: 258617
		[Token(Token = "0x403F239")]
		[FieldOffset(Offset = "0x38")]
		public Act1ArcadeStageBadgeModel badgeModel;

		// Token: 0x0403F23A RID: 258618
		[Token(Token = "0x403F23A")]
		[FieldOffset(Offset = "0x40")]
		public Act1ArcadeSingleStageModel curSelectStageModel;

		// Token: 0x0403F23B RID: 258619
		[Token(Token = "0x403F23B")]
		[FieldOffset(Offset = "0x48")]
		public Act1ArcadeSingleZoneModel curSelectZoneModel;

		// Token: 0x0403F23C RID: 258620
		[Token(Token = "0x403F23C")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, Act1ArcadeSingleStageModel> m_stageModelDict;

		// Token: 0x0403F23D RID: 258621
		[Token(Token = "0x403F23D")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, Act1ArcadeSingleZoneModel> m_zoneModelDict;

		// Token: 0x0403F23E RID: 258622
		[Token(Token = "0x403F23E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneModelDict;

		// Token: 0x0403F23F RID: 258623
		[Token(Token = "0x403F23F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F240 RID: 258624
		[Token(Token = "0x403F240")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshCurSelectZoneAndStage;

		// Token: 0x0403F241 RID: 258625
		[Token(Token = "0x403F241")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403F242 RID: 258626
		[Token(Token = "0x403F242")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetStageModel;

		// Token: 0x0403F243 RID: 258627
		[Token(Token = "0x403F243")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetZoneModel;

		// Token: 0x0403F244 RID: 258628
		[Token(Token = "0x403F244")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FillBuffRuneList;

		// Token: 0x0403F245 RID: 258629
		[Token(Token = "0x403F245")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetSelectStage;

		// Token: 0x0403F246 RID: 258630
		[Token(Token = "0x403F246")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetDefaultSelectStageIdByZoneId;

		// Token: 0x0403F247 RID: 258631
		[Token(Token = "0x403F247")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
