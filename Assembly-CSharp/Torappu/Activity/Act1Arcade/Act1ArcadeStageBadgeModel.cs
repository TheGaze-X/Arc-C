using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007984 RID: 31108
	[Token(Token = "0x2007984")]
	public class Act1ArcadeStageBadgeModel : IHotfixable
	{
		// Token: 0x0602BA4E RID: 178766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA4E")]
		[Address(RVA = "0x2789DB0", Offset = "0x27889B0", VA = "0x182789DB0")]
		public void LoadData(string actId, string curZoneId)
		{
		}

		// Token: 0x0602BA4F RID: 178767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA4F")]
		[Address(RVA = "0x278A1E0", Offset = "0x2788DE0", VA = "0x18278A1E0")]
		public void SetCurZoneId(string curZoneId)
		{
		}

		// Token: 0x0602BA50 RID: 178768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA50")]
		[Address(RVA = "0x278A260", Offset = "0x2788E60", VA = "0x18278A260")]
		public void UpdateBadgeTier()
		{
		}

		// Token: 0x0602BA51 RID: 178769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA51")]
		[Address(RVA = "0x278A9B0", Offset = "0x27895B0", VA = "0x18278A9B0")]
		private void _RefreshRuneList()
		{
		}

		// Token: 0x0602BA52 RID: 178770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA52")]
		[Address(RVA = "0x2789BC0", Offset = "0x27887C0", VA = "0x182789BC0")]
		public void FillBuffRuneList(List<RuneTable.PackedRuneData> runeList)
		{
		}

		// Token: 0x0602BA53 RID: 178771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA53")]
		[Address(RVA = "0x2789CF0", Offset = "0x27888F0", VA = "0x182789CF0")]
		public Act1ArcadeBadgeBookItemViewModel GetBadgeBookItemViewModelByZoneId(string zoneId)
		{
			return null;
		}

		// Token: 0x0602BA54 RID: 178772 RVA: 0x000DCBF0 File Offset: 0x000DADF0
		[Token(Token = "0x602BA54")]
		[Address(RVA = "0x278A4C0", Offset = "0x27890C0", VA = "0x18278A4C0")]
		private int _GetBadgeMaxTier(Act1ArcadeBadgeBookItemViewModel bookItemViewModel)
		{
			return 0;
		}

		// Token: 0x0602BA55 RID: 178773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA55")]
		[Address(RVA = "0x278A6C0", Offset = "0x27892C0", VA = "0x18278A6C0")]
		private Act1ArcadeBadgeBookItemViewModel _LoadItem(ActArcadeData.ArcadeBadgeData data)
		{
			return null;
		}

		// Token: 0x0602BA56 RID: 178774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA56")]
		[Address(RVA = "0x278AD70", Offset = "0x2789970", VA = "0x18278AD70")]
		public Act1ArcadeStageBadgeModel()
		{
		}

		// Token: 0x0403F222 RID: 258594
		[Token(Token = "0x403F222")]
		[FieldOffset(Offset = "0x10")]
		public Act1ArcadeBadgeBookItemViewModel ultimateBadge;

		// Token: 0x0403F223 RID: 258595
		[Token(Token = "0x403F223")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Act1ArcadeBadgeBookItemViewModel> m_zoneBadgeDict;

		// Token: 0x0403F224 RID: 258596
		[Token(Token = "0x403F224")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, Act1ArcadeBadgeBookItemViewModel> commonBadges;

		// Token: 0x0403F225 RID: 258597
		[Token(Token = "0x403F225")]
		[FieldOffset(Offset = "0x28")]
		private List<RuneTable.PackedRuneData> m_curRuneList;

		// Token: 0x0403F226 RID: 258598
		[Token(Token = "0x403F226")]
		[FieldOffset(Offset = "0x30")]
		private ActArcadeData m_arcadeData;

		// Token: 0x0403F227 RID: 258599
		[Token(Token = "0x403F227")]
		[FieldOffset(Offset = "0x38")]
		private PlayerActivity.PlayerArcadeActivity m_playerData;

		// Token: 0x0403F228 RID: 258600
		[Token(Token = "0x403F228")]
		[FieldOffset(Offset = "0x40")]
		private string m_curZoneId;

		// Token: 0x0403F229 RID: 258601
		[Token(Token = "0x403F229")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F22A RID: 258602
		[Token(Token = "0x403F22A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCurZoneId;

		// Token: 0x0403F22B RID: 258603
		[Token(Token = "0x403F22B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateBadgeTier;

		// Token: 0x0403F22C RID: 258604
		[Token(Token = "0x403F22C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshRuneList;

		// Token: 0x0403F22D RID: 258605
		[Token(Token = "0x403F22D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FillBuffRuneList;

		// Token: 0x0403F22E RID: 258606
		[Token(Token = "0x403F22E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetBadgeBookItemViewModelByZoneId;

		// Token: 0x0403F22F RID: 258607
		[Token(Token = "0x403F22F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetBadgeMaxTier;

		// Token: 0x0403F230 RID: 258608
		[Token(Token = "0x403F230")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadItem;

		// Token: 0x0403F231 RID: 258609
		[Token(Token = "0x403F231")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
