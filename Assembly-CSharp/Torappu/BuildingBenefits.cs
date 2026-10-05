using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Hire;
using Torappu.Building.UI.Train;

namespace Torappu
{
	// Token: 0x020004AC RID: 1196
	[Token(Token = "0x20004AC")]
	public static class BuildingBenefits
	{
		// Token: 0x06004D03 RID: 19715 RVA: 0x0002D588 File Offset: 0x0002B788
		[Token(Token = "0x6004D03")]
		[Address(RVA = "0x1787E70", Offset = "0x1786A70", VA = "0x181787E70")]
		public static float ReduceRateOnNormalRecruit()
		{
			return 0f;
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D04")]
		[Address(RVA = "0x1787D90", Offset = "0x1786990", VA = "0x181787D90")]
		public static PlayerBuildingRoomSlot GetPlayerBuildingSlotModel(string slotId)
		{
			return null;
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		[Token(Token = "0x6004D05")]
		[Address(RVA = "0x17878B0", Offset = "0x17864B0", VA = "0x1817878B0")]
		public static LevelUpSnapshot CalcTrainingSnapshot()
		{
			return default(LevelUpSnapshot);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		[Token(Token = "0x6004D06")]
		[Address(RVA = "0x1787790", Offset = "0x1786390", VA = "0x181787790")]
		public static HiringSnapshot CalcHiringSnapshot()
		{
			return default(HiringSnapshot);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06004D07 RID: 19719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F9")]
		public static string playerBuildingTrainingSlotId
		{
			[Token(Token = "0x6004D07")]
			[Address(RVA = "0x1788200", Offset = "0x1786E00", VA = "0x181788200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FA")]
		public static PlayerBuildingTraining playerBuildingTraining
		{
			[Token(Token = "0x6004D08")]
			[Address(RVA = "0x17882B0", Offset = "0x1786EB0", VA = "0x1817882B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06004D09 RID: 19721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FB")]
		public static string playerBuildingHiringSlotId
		{
			[Token(Token = "0x6004D09")]
			[Address(RVA = "0x17880A0", Offset = "0x1786CA0", VA = "0x1817880A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FC")]
		public static PlayerBuildingHire playerBuildingHiring
		{
			[Token(Token = "0x6004D0A")]
			[Address(RVA = "0x1788150", Offset = "0x1786D50", VA = "0x181788150")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		[Token(Token = "0x6004D0B")]
		[Address(RVA = "0x17879D0", Offset = "0x17865D0", VA = "0x1817879D0")]
		public static bool CheckIfCanVisitBuilding()
		{
			return default(bool);
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		[Token(Token = "0x6004D0C")]
		[Address(RVA = "0x1787C10", Offset = "0x1786810", VA = "0x181787C10")]
		public static int GetAdditionalFriendSlotCount()
		{
			return 0;
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x0002D600 File Offset: 0x0002B800
		[Token(Token = "0x6004D0D")]
		[Address(RVA = "0x1787A60", Offset = "0x1786660", VA = "0x181787A60")]
		public static BuildingRoomInfoModel FindRoomForNormalRecruitSlot(int slotIndex)
		{
			return default(BuildingRoomInfoModel);
		}
	}
}
