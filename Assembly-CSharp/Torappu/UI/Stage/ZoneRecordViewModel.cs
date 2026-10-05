using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069E2 RID: 27106
	[Token(Token = "0x20069E2")]
	public class ZoneRecordViewModel : IHotfixable
	{
		// Token: 0x17005B7F RID: 23423
		// (get) Token: 0x06026C59 RID: 158809 RVA: 0x000CC408 File Offset: 0x000CA608
		[Token(Token = "0x17005B7F")]
		public bool isAllComplete
		{
			[Token(Token = "0x6026C59")]
			[Address(RVA = "0x21E6DF0", Offset = "0x21E59F0", VA = "0x1821E6DF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B80 RID: 23424
		// (get) Token: 0x06026C5A RID: 158810 RVA: 0x000CC420 File Offset: 0x000CA620
		[Token(Token = "0x17005B80")]
		public bool hasUncomplete
		{
			[Token(Token = "0x6026C5A")]
			[Address(RVA = "0x21E6D70", Offset = "0x21E5970", VA = "0x1821E6D70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005B81 RID: 23425
		// (get) Token: 0x06026C5B RID: 158811 RVA: 0x000CC438 File Offset: 0x000CA638
		[Token(Token = "0x17005B81")]
		public bool isUnlock
		{
			[Token(Token = "0x6026C5B")]
			[Address(RVA = "0x21E6E70", Offset = "0x21E5A70", VA = "0x1821E6E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026C5C RID: 158812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C5C")]
		[Address(RVA = "0x21E5CD0", Offset = "0x21E48D0", VA = "0x1821E5CD0")]
		public void LoadData(ZoneRecordData zoneRecord, [Optional] ZoneRecordViewModel.IPlugin plugin)
		{
		}

		// Token: 0x06026C5D RID: 158813 RVA: 0x000CC450 File Offset: 0x000CA650
		[Token(Token = "0x6026C5D")]
		[Address(RVA = "0x21E5AF0", Offset = "0x21E46F0", VA = "0x1821E5AF0")]
		public bool CheckAvailableReward(ref string[] stageIds)
		{
			return default(bool);
		}

		// Token: 0x06026C5E RID: 158814 RVA: 0x000CC468 File Offset: 0x000CA668
		[Token(Token = "0x6026C5E")]
		[Address(RVA = "0x21E69A0", Offset = "0x21E55A0", VA = "0x1821E69A0")]
		private bool _IsPredefineOrHardRecord(RecordRewardStageDiff stageDiff)
		{
			return default(bool);
		}

		// Token: 0x06026C5F RID: 158815 RVA: 0x000CC480 File Offset: 0x000CA680
		[Token(Token = "0x6026C5F")]
		[Address(RVA = "0x21E6760", Offset = "0x21E5360", VA = "0x1821E6760")]
		private ZoneRecordViewModel.RecordDiffIconType _GenDiffIconType(ZoneRecordViewModel.ZoneRecordDiffStatus diffStatus)
		{
			return ZoneRecordViewModel.RecordDiffIconType.NONE;
		}

		// Token: 0x06026C60 RID: 158816 RVA: 0x000CC498 File Offset: 0x000CA698
		[Token(Token = "0x6026C60")]
		[Address(RVA = "0x21E6850", Offset = "0x21E5450", VA = "0x1821E6850")]
		private ZoneRecordViewModel.ZoneRecordDiffStatus _GenDiffStatus(RecordRewardStageDiff stageDiff, bool isUnlock)
		{
			return ZoneRecordViewModel.ZoneRecordDiffStatus.NONE;
		}

		// Token: 0x06026C61 RID: 158817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C61")]
		[Address(RVA = "0x21E6190", Offset = "0x21E4D90", VA = "0x1821E6190")]
		public ZoneRecordRewardViewModel TryGetRewardViewModelByStageDiff(StageDiffGroup diffType)
		{
			return null;
		}

		// Token: 0x06026C62 RID: 158818 RVA: 0x000CC4B0 File Offset: 0x000CA6B0
		[Token(Token = "0x6026C62")]
		[Address(RVA = "0x21E6420", Offset = "0x21E5020", VA = "0x1821E6420")]
		private bool _CheckRecordStageValid(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06026C63 RID: 158819 RVA: 0x000CC4C8 File Offset: 0x000CA6C8
		[Token(Token = "0x6026C63")]
		[Address(RVA = "0x21E64D0", Offset = "0x21E50D0", VA = "0x1821E64D0")]
		private bool _CheckRewardAvailable(string stageId, bool haveMission)
		{
			return default(bool);
		}

		// Token: 0x06026C64 RID: 158820 RVA: 0x000CC4E0 File Offset: 0x000CA6E0
		[Token(Token = "0x6026C64")]
		[Address(RVA = "0x21E6640", Offset = "0x21E5240", VA = "0x1821E6640")]
		private bool _CheckRewardGained(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06026C65 RID: 158821 RVA: 0x000CC4F8 File Offset: 0x000CA6F8
		[Token(Token = "0x6026C65")]
		[Address(RVA = "0x21E62B0", Offset = "0x21E4EB0", VA = "0x1821E62B0")]
		private bool _CheckHaveMission(string stageId, out string desc)
		{
			return default(bool);
		}

		// Token: 0x06026C66 RID: 158822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C66")]
		[Address(RVA = "0x21E6A20", Offset = "0x21E5620", VA = "0x1821E6A20")]
		private RecordRewardInfo _ProcessRewardItem(RecordRewardInfo prevReward, ZoneRecordViewModel.IPlugin plugin)
		{
			return null;
		}

		// Token: 0x06026C67 RID: 158823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C67")]
		[Address(RVA = "0x21E6D10", Offset = "0x21E5910", VA = "0x1821E6D10")]
		public ZoneRecordViewModel()
		{
		}

		// Token: 0x04036C41 RID: 224321
		[Token(Token = "0x4036C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string recordId;

		// Token: 0x04036C42 RID: 224322
		[Token(Token = "0x4036C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string recordName;

		// Token: 0x04036C43 RID: 224323
		[Token(Token = "0x4036C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string prevRecordId;

		// Token: 0x04036C44 RID: 224324
		[Token(Token = "0x4036C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int availableCount;

		// Token: 0x04036C45 RID: 224325
		[Token(Token = "0x4036C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int gainedCount;

		// Token: 0x04036C46 RID: 224326
		[Token(Token = "0x4036C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool pageNoteUnlock;

		// Token: 0x04036C47 RID: 224327
		[Token(Token = "0x4036C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool prevRecordNeedComplete;

		// Token: 0x04036C48 RID: 224328
		[Token(Token = "0x4036C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool stageBanned;

		// Token: 0x04036C49 RID: 224329
		[Token(Token = "0x4036C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool prevRecordAvialable;

		// Token: 0x04036C4A RID: 224330
		[Token(Token = "0x4036C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string recordTitle1;

		// Token: 0x04036C4B RID: 224331
		[Token(Token = "0x4036C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string recordTitle2;

		// Token: 0x04036C4C RID: 224332
		[Token(Token = "0x4036C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ZoneRecordViewModel.ZoneRecordDiffStatus diffStatus;

		// Token: 0x04036C4D RID: 224333
		[Token(Token = "0x4036C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool hasRewardCanClaim;

		// Token: 0x04036C4E RID: 224334
		[Token(Token = "0x4036C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ZoneRecordGroupViewModel.DiffRewardStatus> rewardStatus;

		// Token: 0x04036C4F RID: 224335
		[Token(Token = "0x4036C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<ZoneRecordRewardViewModel> rewardViewModels;

		// Token: 0x04036C50 RID: 224336
		[Token(Token = "0x4036C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ZoneRecordViewModel.RecordDiffIconType btnDiffIconType;

		// Token: 0x04036C51 RID: 224337
		[Token(Token = "0x4036C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAllComplete;

		// Token: 0x04036C52 RID: 224338
		[Token(Token = "0x4036C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasUncomplete;

		// Token: 0x04036C53 RID: 224339
		[Token(Token = "0x4036C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isUnlock;

		// Token: 0x04036C54 RID: 224340
		[Token(Token = "0x4036C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04036C55 RID: 224341
		[Token(Token = "0x4036C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckAvailableReward;

		// Token: 0x04036C56 RID: 224342
		[Token(Token = "0x4036C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsPredefineOrHardRecord;

		// Token: 0x04036C57 RID: 224343
		[Token(Token = "0x4036C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenDiffIconType;

		// Token: 0x04036C58 RID: 224344
		[Token(Token = "0x4036C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenDiffStatus;

		// Token: 0x04036C59 RID: 224345
		[Token(Token = "0x4036C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetRewardViewModelByStageDiff;

		// Token: 0x04036C5A RID: 224346
		[Token(Token = "0x4036C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckRecordStageValid;

		// Token: 0x04036C5B RID: 224347
		[Token(Token = "0x4036C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckRewardAvailable;

		// Token: 0x04036C5C RID: 224348
		[Token(Token = "0x4036C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckRewardGained;

		// Token: 0x04036C5D RID: 224349
		[Token(Token = "0x4036C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckHaveMission;

		// Token: 0x04036C5E RID: 224350
		[Token(Token = "0x4036C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ProcessRewardItem;

		// Token: 0x04036C5F RID: 224351
		[Token(Token = "0x4036C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069E3 RID: 27107
		[Token(Token = "0x20069E3")]
		public interface IPlugin
		{
			// Token: 0x06026C68 RID: 158824
			[Token(Token = "0x6026C68")]
			List<string> GetOutdateItemIdList();
		}

		// Token: 0x020069E4 RID: 27108
		[Token(Token = "0x20069E4")]
		[Serializable]
		public enum ZoneRecordDiffStatus
		{
			// Token: 0x04036C61 RID: 224353
			[Token(Token = "0x4036C61")]
			NONE,
			// Token: 0x04036C62 RID: 224354
			[Token(Token = "0x4036C62")]
			COMMON_LOCK,
			// Token: 0x04036C63 RID: 224355
			[Token(Token = "0x4036C63")]
			EASY_UNLOCK,
			// Token: 0x04036C64 RID: 224356
			[Token(Token = "0x4036C64")]
			NORMAL_UNLOCK,
			// Token: 0x04036C65 RID: 224357
			[Token(Token = "0x4036C65")]
			TOUGH_UNLOCK,
			// Token: 0x04036C66 RID: 224358
			[Token(Token = "0x4036C66")]
			PREDEFINED_LOCK,
			// Token: 0x04036C67 RID: 224359
			[Token(Token = "0x4036C67")]
			PREDEFINED_UNLOCK,
			// Token: 0x04036C68 RID: 224360
			[Token(Token = "0x4036C68")]
			HARD_LOCK,
			// Token: 0x04036C69 RID: 224361
			[Token(Token = "0x4036C69")]
			HARD_UNLOCK
		}

		// Token: 0x020069E5 RID: 27109
		[Token(Token = "0x20069E5")]
		[Serializable]
		public enum RecordDiffIconType
		{
			// Token: 0x04036C6B RID: 224363
			[Token(Token = "0x4036C6B")]
			NONE,
			// Token: 0x04036C6C RID: 224364
			[Token(Token = "0x4036C6C")]
			EASY,
			// Token: 0x04036C6D RID: 224365
			[Token(Token = "0x4036C6D")]
			NORMAL,
			// Token: 0x04036C6E RID: 224366
			[Token(Token = "0x4036C6E")]
			TOUGH,
			// Token: 0x04036C6F RID: 224367
			[Token(Token = "0x4036C6F")]
			PREDEFINED
		}
	}
}
