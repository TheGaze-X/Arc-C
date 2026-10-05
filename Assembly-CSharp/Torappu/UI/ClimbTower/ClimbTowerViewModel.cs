using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DD5 RID: 24021
	[Token(Token = "0x2005DD5")]
	public class ClimbTowerViewModel : IHotfixable
	{
		// Token: 0x1700523A RID: 21050
		// (get) Token: 0x06022CBA RID: 142522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700523A")]
		public List<ClimbTowerLevelModel> outerLevels
		{
			[Token(Token = "0x6022CBA")]
			[Address(RVA = "0x1D5DB20", Offset = "0x1D5C720", VA = "0x181D5DB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700523B RID: 21051
		// (get) Token: 0x06022CBB RID: 142523 RVA: 0x000BEE30 File Offset: 0x000BD030
		[Token(Token = "0x1700523B")]
		public bool unlockSweep
		{
			[Token(Token = "0x6022CBB")]
			[Address(RVA = "0x1D5DB90", Offset = "0x1D5C790", VA = "0x181D5DB90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022CBC RID: 142524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CBC")]
		[Address(RVA = "0x1D5C420", Offset = "0x1D5B020", VA = "0x181D5C420")]
		public void LoadData(string tower, bool needReloadTowerMode)
		{
		}

		// Token: 0x06022CBD RID: 142525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022CBD")]
		[Address(RVA = "0x1D5D690", Offset = "0x1D5C290", VA = "0x181D5D690")]
		private List<ClimbTowerLevelModel> _LoadLevelViewModelsWithMode(ClimbTowerSingleTowerData towerData, bool hardMode)
		{
			return null;
		}

		// Token: 0x06022CBE RID: 142526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CBE")]
		[Address(RVA = "0x1D5D470", Offset = "0x1D5C070", VA = "0x181D5D470")]
		private void _GetItemInstIds()
		{
		}

		// Token: 0x06022CBF RID: 142527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CBF")]
		[Address(RVA = "0x1D5D960", Offset = "0x1D5C560", VA = "0x181D5D960")]
		private void _LoadSweepReward()
		{
		}

		// Token: 0x06022CC0 RID: 142528 RVA: 0x000BEE48 File Offset: 0x000BD048
		[Token(Token = "0x6022CC0")]
		[Address(RVA = "0x1D5BFC0", Offset = "0x1D5ABC0", VA = "0x181D5BFC0")]
		public bool CheckRewardStatus(string tower, List<int> layers)
		{
			return default(bool);
		}

		// Token: 0x06022CC1 RID: 142529 RVA: 0x000BEE60 File Offset: 0x000BD060
		[Token(Token = "0x6022CC1")]
		[Address(RVA = "0x1D5BF50", Offset = "0x1D5AB50", VA = "0x181D5BF50")]
		public bool CheckCreateGame()
		{
			return default(bool);
		}

		// Token: 0x06022CC2 RID: 142530 RVA: 0x000BEE78 File Offset: 0x000BD078
		[Token(Token = "0x6022CC2")]
		[Address(RVA = "0x1D5C230", Offset = "0x1D5AE30", VA = "0x181D5C230")]
		public Color GetColorByMode()
		{
			return default(Color);
		}

		// Token: 0x06022CC3 RID: 142531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022CC3")]
		[Address(RVA = "0x1D5C340", Offset = "0x1D5AF40", VA = "0x181D5C340")]
		public string GetNamePostfixByMode()
		{
			return null;
		}

		// Token: 0x06022CC4 RID: 142532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CC4")]
		[Address(RVA = "0x1D5D3A0", Offset = "0x1D5BFA0", VA = "0x181D5D3A0")]
		public void SwitchMode()
		{
		}

		// Token: 0x06022CC5 RID: 142533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CC5")]
		[Address(RVA = "0x1D5D2B0", Offset = "0x1D5BEB0", VA = "0x181D5D2B0")]
		public void SelectUseSweep()
		{
		}

		// Token: 0x06022CC6 RID: 142534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CC6")]
		[Address(RVA = "0x1D5D330", Offset = "0x1D5BF30", VA = "0x181D5D330")]
		public void SwitchConfirmSweep()
		{
		}

		// Token: 0x06022CC7 RID: 142535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CC7")]
		[Address(RVA = "0x1D5D250", Offset = "0x1D5BE50", VA = "0x181D5D250")]
		public void NotifyResetSweepConfirm()
		{
		}

		// Token: 0x06022CC8 RID: 142536 RVA: 0x000BEE90 File Offset: 0x000BD090
		[Token(Token = "0x6022CC8")]
		[Address(RVA = "0x1D5C3A0", Offset = "0x1D5AFA0", VA = "0x181D5C3A0")]
		public bool HaveEnoughCharToStart(out int minCount)
		{
			return default(bool);
		}

		// Token: 0x06022CC9 RID: 142537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022CC9")]
		[Address(RVA = "0x1D5C2B0", Offset = "0x1D5AEB0", VA = "0x181D5C2B0")]
		public List<ClimbTowerLevelModel> GetLevelModels(bool isHardMode)
		{
			return null;
		}

		// Token: 0x06022CCA RID: 142538 RVA: 0x000BEEA8 File Offset: 0x000BD0A8
		[Token(Token = "0x6022CCA")]
		[Address(RVA = "0x1D5C1B0", Offset = "0x1D5ADB0", VA = "0x181D5C1B0")]
		public bool CheckSweepHasNoReward()
		{
			return default(bool);
		}

		// Token: 0x06022CCB RID: 142539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CCB")]
		[Address(RVA = "0x1D5DAC0", Offset = "0x1D5C6C0", VA = "0x181D5DAC0")]
		public ClimbTowerViewModel()
		{
		}

		// Token: 0x0402FDE7 RID: 196071
		[Token(Token = "0x402FDE7")]
		[FieldOffset(Offset = "0x10")]
		public string towerId;

		// Token: 0x0402FDE8 RID: 196072
		[Token(Token = "0x402FDE8")]
		[FieldOffset(Offset = "0x18")]
		public string towerName;

		// Token: 0x0402FDE9 RID: 196073
		[Token(Token = "0x402FDE9")]
		[FieldOffset(Offset = "0x20")]
		public string towerSubName;

		// Token: 0x0402FDEA RID: 196074
		[Token(Token = "0x402FDEA")]
		[FieldOffset(Offset = "0x28")]
		public string towerDesc;

		// Token: 0x0402FDEB RID: 196075
		[Token(Token = "0x402FDEB")]
		[FieldOffset(Offset = "0x30")]
		public ClimbTowerTowerType towerType;

		// Token: 0x0402FDEC RID: 196076
		[Token(Token = "0x402FDEC")]
		[FieldOffset(Offset = "0x34")]
		public int recordLayer;

		// Token: 0x0402FDED RID: 196077
		[Token(Token = "0x402FDED")]
		[FieldOffset(Offset = "0x38")]
		public int maxLayer;

		// Token: 0x0402FDEE RID: 196078
		[Token(Token = "0x402FDEE")]
		[FieldOffset(Offset = "0x3C")]
		public bool hasGetMedal;

		// Token: 0x0402FDEF RID: 196079
		[Token(Token = "0x402FDEF")]
		[FieldOffset(Offset = "0x3D")]
		public bool hasGetHiddenMedal;

		// Token: 0x0402FDF0 RID: 196080
		[Token(Token = "0x402FDF0")]
		[FieldOffset(Offset = "0x40")]
		public string medalId;

		// Token: 0x0402FDF1 RID: 196081
		[Token(Token = "0x402FDF1")]
		[FieldOffset(Offset = "0x48")]
		public string hiddenMedalId;

		// Token: 0x0402FDF2 RID: 196082
		[Token(Token = "0x402FDF2")]
		[FieldOffset(Offset = "0x50")]
		public string bossId;

		// Token: 0x0402FDF3 RID: 196083
		[Token(Token = "0x402FDF3")]
		[FieldOffset(Offset = "0x58")]
		public ListDict<int, ClimbTowerRewardModel> rewards;

		// Token: 0x0402FDF4 RID: 196084
		[Token(Token = "0x402FDF4")]
		[FieldOffset(Offset = "0x60")]
		public List<int> notReceivedRewards;

		// Token: 0x0402FDF5 RID: 196085
		[Token(Token = "0x402FDF5")]
		[FieldOffset(Offset = "0x68")]
		public ItemData lowerItemData;

		// Token: 0x0402FDF6 RID: 196086
		[Token(Token = "0x402FDF6")]
		[FieldOffset(Offset = "0x70")]
		public ItemData higherItemData;

		// Token: 0x0402FDF7 RID: 196087
		[Token(Token = "0x402FDF7")]
		[FieldOffset(Offset = "0x78")]
		public int curLowerItemCount;

		// Token: 0x0402FDF8 RID: 196088
		[Token(Token = "0x402FDF8")]
		[FieldOffset(Offset = "0x7C")]
		public int curHigherItemCount;

		// Token: 0x0402FDF9 RID: 196089
		[Token(Token = "0x402FDF9")]
		[FieldOffset(Offset = "0x80")]
		public int maxLowerItemCount;

		// Token: 0x0402FDFA RID: 196090
		[Token(Token = "0x402FDFA")]
		[FieldOffset(Offset = "0x84")]
		public int maxHigherItemCount;

		// Token: 0x0402FDFB RID: 196091
		[Token(Token = "0x402FDFB")]
		[FieldOffset(Offset = "0x88")]
		public bool isInBattle;

		// Token: 0x0402FDFC RID: 196092
		[Token(Token = "0x402FDFC")]
		[FieldOffset(Offset = "0x89")]
		public bool isValid;

		// Token: 0x0402FDFD RID: 196093
		[Token(Token = "0x402FDFD")]
		[FieldOffset(Offset = "0x8A")]
		public bool hasTowerPass;

		// Token: 0x0402FDFE RID: 196094
		[Token(Token = "0x402FDFE")]
		[FieldOffset(Offset = "0x8B")]
		public bool isHardModeValid;

		// Token: 0x0402FDFF RID: 196095
		[Token(Token = "0x402FDFF")]
		[FieldOffset(Offset = "0x8C")]
		public bool isHardMode;

		// Token: 0x0402FE00 RID: 196096
		[Token(Token = "0x402FE00")]
		[FieldOffset(Offset = "0x90")]
		public int hardModeRecordLayer;

		// Token: 0x0402FE01 RID: 196097
		[Token(Token = "0x402FE01")]
		[FieldOffset(Offset = "0x98")]
		public string hardModeTips;

		// Token: 0x0402FE02 RID: 196098
		[Token(Token = "0x402FE02")]
		[FieldOffset(Offset = "0xA0")]
		public bool hasGetHardModeMedal;

		// Token: 0x0402FE03 RID: 196099
		[Token(Token = "0x402FE03")]
		[FieldOffset(Offset = "0xA8")]
		public string hardModeMedalId;

		// Token: 0x0402FE04 RID: 196100
		[Token(Token = "0x402FE04")]
		[FieldOffset(Offset = "0xB0")]
		public string dangerEffectDesc;

		// Token: 0x0402FE05 RID: 196101
		[Token(Token = "0x402FE05")]
		[FieldOffset(Offset = "0xB8")]
		public int subCardStageSort;

		// Token: 0x0402FE06 RID: 196102
		[Token(Token = "0x402FE06")]
		[FieldOffset(Offset = "0xC0")]
		private List<ClimbTowerLevelModel> m_normalLevels;

		// Token: 0x0402FE07 RID: 196103
		[Token(Token = "0x402FE07")]
		[FieldOffset(Offset = "0xC8")]
		private List<ClimbTowerLevelModel> m_hardLevels;

		// Token: 0x0402FE08 RID: 196104
		[Token(Token = "0x402FE08")]
		[FieldOffset(Offset = "0xD0")]
		private int m_charCount;

		// Token: 0x0402FE09 RID: 196105
		[Token(Token = "0x402FE09")]
		[FieldOffset(Offset = "0xD4")]
		public bool hasEnoughSweepItem;

		// Token: 0x0402FE0A RID: 196106
		[Token(Token = "0x402FE0A")]
		[FieldOffset(Offset = "0xD5")]
		public bool beUseSweep;

		// Token: 0x0402FE0B RID: 196107
		[Token(Token = "0x402FE0B")]
		[FieldOffset(Offset = "0xD8")]
		public int afterSweepLowerItemCount;

		// Token: 0x0402FE0C RID: 196108
		[Token(Token = "0x402FE0C")]
		[FieldOffset(Offset = "0xDC")]
		public int afterSweepHigherItemCount;

		// Token: 0x0402FE0D RID: 196109
		[Token(Token = "0x402FE0D")]
		[FieldOffset(Offset = "0xE0")]
		public int sweepCost;

		// Token: 0x0402FE0E RID: 196110
		[Token(Token = "0x402FE0E")]
		[FieldOffset(Offset = "0xE4")]
		public int unLockSweepNormLayer;

		// Token: 0x0402FE0F RID: 196111
		[Token(Token = "0x402FE0F")]
		[FieldOffset(Offset = "0xE8")]
		public int unlockSweepHardLayer;

		// Token: 0x0402FE10 RID: 196112
		[Token(Token = "0x402FE10")]
		[FieldOffset(Offset = "0xF0")]
		public string sweepItemName;

		// Token: 0x0402FE11 RID: 196113
		[Token(Token = "0x402FE11")]
		[FieldOffset(Offset = "0xF8")]
		public bool isInConfirmSweep;

		// Token: 0x0402FE12 RID: 196114
		[Token(Token = "0x402FE12")]
		[FieldOffset(Offset = "0x100")]
		public List<ItemUtil.ConsumableInfo> tktInfoList;

		// Token: 0x0402FE13 RID: 196115
		[Token(Token = "0x402FE13")]
		[FieldOffset(Offset = "0x108")]
		public List<int> selectTktInstList;

		// Token: 0x0402FE14 RID: 196116
		[Token(Token = "0x402FE14")]
		[FieldOffset(Offset = "0x110")]
		public string tktItemId;

		// Token: 0x0402FE15 RID: 196117
		[Token(Token = "0x402FE15")]
		[FieldOffset(Offset = "0x118")]
		public int switchHardModeSeqNum;

		// Token: 0x0402FE16 RID: 196118
		[Token(Token = "0x402FE16")]
		[FieldOffset(Offset = "0x11C")]
		public int resetSweepConfirmSeqNum;

		// Token: 0x0402FE17 RID: 196119
		[Token(Token = "0x402FE17")]
		[FieldOffset(Offset = "0x120")]
		private bool m_unlockSweepNormal;

		// Token: 0x0402FE18 RID: 196120
		[Token(Token = "0x402FE18")]
		[FieldOffset(Offset = "0x121")]
		private bool m_unlockSweepHard;

		// Token: 0x0402FE19 RID: 196121
		[Token(Token = "0x402FE19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_outerLevels;

		// Token: 0x0402FE1A RID: 196122
		[Token(Token = "0x402FE1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_unlockSweep;

		// Token: 0x0402FE1B RID: 196123
		[Token(Token = "0x402FE1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FE1C RID: 196124
		[Token(Token = "0x402FE1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadLevelViewModelsWithMode;

		// Token: 0x0402FE1D RID: 196125
		[Token(Token = "0x402FE1D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetItemInstIds;

		// Token: 0x0402FE1E RID: 196126
		[Token(Token = "0x402FE1E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadSweepReward;

		// Token: 0x0402FE1F RID: 196127
		[Token(Token = "0x402FE1F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckRewardStatus;

		// Token: 0x0402FE20 RID: 196128
		[Token(Token = "0x402FE20")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckCreateGame;

		// Token: 0x0402FE21 RID: 196129
		[Token(Token = "0x402FE21")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetColorByMode;

		// Token: 0x0402FE22 RID: 196130
		[Token(Token = "0x402FE22")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetNamePostfixByMode;

		// Token: 0x0402FE23 RID: 196131
		[Token(Token = "0x402FE23")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SwitchMode;

		// Token: 0x0402FE24 RID: 196132
		[Token(Token = "0x402FE24")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SelectUseSweep;

		// Token: 0x0402FE25 RID: 196133
		[Token(Token = "0x402FE25")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SwitchConfirmSweep;

		// Token: 0x0402FE26 RID: 196134
		[Token(Token = "0x402FE26")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_NotifyResetSweepConfirm;

		// Token: 0x0402FE27 RID: 196135
		[Token(Token = "0x402FE27")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HaveEnoughCharToStart;

		// Token: 0x0402FE28 RID: 196136
		[Token(Token = "0x402FE28")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetLevelModels;

		// Token: 0x0402FE29 RID: 196137
		[Token(Token = "0x402FE29")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckSweepHasNoReward;

		// Token: 0x0402FE2A RID: 196138
		[Token(Token = "0x402FE2A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
