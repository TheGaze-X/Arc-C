using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006150 RID: 24912
	[Token(Token = "0x2006150")]
	public class AutoCampConfigModel : IHotfixable
	{
		// Token: 0x06023F72 RID: 147314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F72")]
		[Address(RVA = "0x1E9E520", Offset = "0x1E9D120", VA = "0x181E9E520")]
		public void ReloadData(string targetStageId)
		{
		}

		// Token: 0x06023F73 RID: 147315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F73")]
		[Address(RVA = "0x1E9EBE0", Offset = "0x1E9D7E0", VA = "0x181E9EBE0")]
		private void _ReloadAutoBattleOnlyModel(bool isFastSysOpen, AutoCampConfigModel.FastBattleLockAlert fastLockType, bool hasBattleLog, StageViewModel.LocalCache stageCache, bool isStageChanged)
		{
		}

		// Token: 0x06023F74 RID: 147316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F74")]
		[Address(RVA = "0x1E9ECE0", Offset = "0x1E9D8E0", VA = "0x181E9ECE0")]
		private void _ReloadEnableFastBattleModel(StageViewModel.LocalCache stageCache, bool isStageChanged)
		{
		}

		// Token: 0x06023F75 RID: 147317 RVA: 0x000C2850 File Offset: 0x000C0A50
		[Token(Token = "0x6023F75")]
		[Address(RVA = "0x1E9E130", Offset = "0x1E9CD30", VA = "0x181E9E130")]
		public bool CheckIfAutoBattle()
		{
			return default(bool);
		}

		// Token: 0x06023F76 RID: 147318 RVA: 0x000C2868 File Offset: 0x000C0A68
		[Token(Token = "0x6023F76")]
		[Address(RVA = "0x1E9E4B0", Offset = "0x1E9D0B0", VA = "0x181E9E4B0")]
		public bool CheckIfFastBattle()
		{
			return default(bool);
		}

		// Token: 0x06023F77 RID: 147319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F77")]
		[Address(RVA = "0x1E9E920", Offset = "0x1E9D520", VA = "0x181E9E920")]
		public void ToggleAutoBattle()
		{
		}

		// Token: 0x06023F78 RID: 147320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F78")]
		[Address(RVA = "0x1E9EA30", Offset = "0x1E9D630", VA = "0x181E9EA30")]
		public void ToggleFastBattle()
		{
		}

		// Token: 0x06023F79 RID: 147321 RVA: 0x000C2880 File Offset: 0x000C0A80
		[Token(Token = "0x6023F79")]
		[Address(RVA = "0x1E9E040", Offset = "0x1E9CC40", VA = "0x181E9E040")]
		public bool CheckIfAutoBattleUnlocked(out string lockAlert)
		{
			return default(bool);
		}

		// Token: 0x06023F7A RID: 147322 RVA: 0x000C2898 File Offset: 0x000C0A98
		[Token(Token = "0x6023F7A")]
		[Address(RVA = "0x1E9E230", Offset = "0x1E9CE30", VA = "0x181E9E230")]
		public bool CheckIfFastBattleUnlocked(out string lockAlert)
		{
			return default(bool);
		}

		// Token: 0x06023F7B RID: 147323 RVA: 0x000C28B0 File Offset: 0x000C0AB0
		[Token(Token = "0x6023F7B")]
		[Address(RVA = "0x1E9E1C0", Offset = "0x1E9CDC0", VA = "0x181E9E1C0")]
		public bool CheckIfFastBattleSysOpen()
		{
			return default(bool);
		}

		// Token: 0x06023F7C RID: 147324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F7C")]
		[Address(RVA = "0x1E9EAA0", Offset = "0x1E9D6A0", VA = "0x181E9EAA0")]
		private static string _GetLockToastByFastCampLockType(AutoCampConfigModel.FastBattleLockAlert type)
		{
			return null;
		}

		// Token: 0x06023F7D RID: 147325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F7D")]
		[Address(RVA = "0x1E9EDB0", Offset = "0x1E9D9B0", VA = "0x181E9EDB0")]
		public AutoCampConfigModel()
		{
		}

		// Token: 0x04031F1E RID: 204574
		[Token(Token = "0x4031F1E")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04031F1F RID: 204575
		[Token(Token = "0x4031F1F")]
		[FieldOffset(Offset = "0x18")]
		public AutoCampConfigModel.Status status;

		// Token: 0x04031F20 RID: 204576
		[Token(Token = "0x4031F20")]
		[FieldOffset(Offset = "0x1C")]
		public AutoCampConfigModel.AutoBattleOnly autoBattleOnly;

		// Token: 0x04031F21 RID: 204577
		[Token(Token = "0x4031F21")]
		[FieldOffset(Offset = "0x24")]
		public AutoCampConfigModel.EnableFastBattle enableFastBattle;

		// Token: 0x04031F22 RID: 204578
		[Token(Token = "0x4031F22")]
		[FieldOffset(Offset = "0x28")]
		public int fastTktCount;

		// Token: 0x04031F23 RID: 204579
		[Token(Token = "0x4031F23")]
		[FieldOffset(Offset = "0x30")]
		public List<ItemUtil.ConsumableInfo> fastTktInfo;

		// Token: 0x04031F24 RID: 204580
		[Token(Token = "0x4031F24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReloadData;

		// Token: 0x04031F25 RID: 204581
		[Token(Token = "0x4031F25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ReloadAutoBattleOnlyModel;

		// Token: 0x04031F26 RID: 204582
		[Token(Token = "0x4031F26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ReloadEnableFastBattleModel;

		// Token: 0x04031F27 RID: 204583
		[Token(Token = "0x4031F27")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfAutoBattle;

		// Token: 0x04031F28 RID: 204584
		[Token(Token = "0x4031F28")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfFastBattle;

		// Token: 0x04031F29 RID: 204585
		[Token(Token = "0x4031F29")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ToggleAutoBattle;

		// Token: 0x04031F2A RID: 204586
		[Token(Token = "0x4031F2A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ToggleFastBattle;

		// Token: 0x04031F2B RID: 204587
		[Token(Token = "0x4031F2B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfAutoBattleUnlocked;

		// Token: 0x04031F2C RID: 204588
		[Token(Token = "0x4031F2C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfFastBattleUnlocked;

		// Token: 0x04031F2D RID: 204589
		[Token(Token = "0x4031F2D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfFastBattleSysOpen;

		// Token: 0x04031F2E RID: 204590
		[Token(Token = "0x4031F2E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetLockToastByFastCampLockType;

		// Token: 0x04031F2F RID: 204591
		[Token(Token = "0x4031F2F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006151 RID: 24913
		[Token(Token = "0x2006151")]
		public enum Status
		{
			// Token: 0x04031F31 RID: 204593
			[Token(Token = "0x4031F31")]
			NONE,
			// Token: 0x04031F32 RID: 204594
			[Token(Token = "0x4031F32")]
			AUTO_BATTLE_ONLY,
			// Token: 0x04031F33 RID: 204595
			[Token(Token = "0x4031F33")]
			ENABLE_FAST_BATTLE
		}

		// Token: 0x02006152 RID: 24914
		[Token(Token = "0x2006152")]
		public enum FastBattleLockAlert
		{
			// Token: 0x04031F35 RID: 204597
			[Token(Token = "0x4031F35")]
			NONE,
			// Token: 0x04031F36 RID: 204598
			[Token(Token = "0x4031F36")]
			NO_RECORD,
			// Token: 0x04031F37 RID: 204599
			[Token(Token = "0x4031F37")]
			NO_TICKET,
			// Token: 0x04031F38 RID: 204600
			[Token(Token = "0x4031F38")]
			IS_TRAIN
		}

		// Token: 0x02006153 RID: 24915
		[Token(Token = "0x2006153")]
		public struct AutoBattleOnly : IHotfixable
		{
			// Token: 0x06023F7E RID: 147326 RVA: 0x000C28C8 File Offset: 0x000C0AC8
			[Token(Token = "0x6023F7E")]
			[Address(RVA = "0x1E9DFE0", Offset = "0x1E9CBE0", VA = "0x181E9DFE0")]
			public bool CanAutoBattle()
			{
				return default(bool);
			}

			// Token: 0x04031F39 RID: 204601
			[Token(Token = "0x4031F39")]
			[FieldOffset(Offset = "0x0")]
			public bool isFastBattleSysOpen;

			// Token: 0x04031F3A RID: 204602
			[Token(Token = "0x4031F3A")]
			[FieldOffset(Offset = "0x1")]
			public bool isUnlocked;

			// Token: 0x04031F3B RID: 204603
			[Token(Token = "0x4031F3B")]
			[FieldOffset(Offset = "0x2")]
			public bool isSelected;

			// Token: 0x04031F3C RID: 204604
			[Token(Token = "0x4031F3C")]
			[FieldOffset(Offset = "0x4")]
			public AutoCampConfigModel.FastBattleLockAlert fastLockType;

			// Token: 0x04031F3D RID: 204605
			[Token(Token = "0x4031F3D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanAutoBattle;
		}

		// Token: 0x02006154 RID: 24916
		[Token(Token = "0x2006154")]
		public struct EnableFastBattle
		{
			// Token: 0x04031F3E RID: 204606
			[Token(Token = "0x4031F3E")]
			[FieldOffset(Offset = "0x0")]
			public AutoCampConfigModel.EnableFastBattle.Selection selection;

			// Token: 0x02006155 RID: 24917
			[Token(Token = "0x2006155")]
			public enum Selection
			{
				// Token: 0x04031F40 RID: 204608
				[Token(Token = "0x4031F40")]
				NONE,
				// Token: 0x04031F41 RID: 204609
				[Token(Token = "0x4031F41")]
				AUTO_BATTLE,
				// Token: 0x04031F42 RID: 204610
				[Token(Token = "0x4031F42")]
				FAST_BATTLE
			}
		}
	}
}
