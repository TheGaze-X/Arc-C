using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069E0 RID: 27104
	[Token(Token = "0x20069E0")]
	public class ZoneRecordGroupViewModel : IHotfixable
	{
		// Token: 0x17005B7E RID: 23422
		// (get) Token: 0x06026C4D RID: 158797 RVA: 0x000CC378 File Offset: 0x000CA578
		// (set) Token: 0x06026C4E RID: 158798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B7E")]
		public int currentRecordIdx
		{
			[Token(Token = "0x6026C4D")]
			[Address(RVA = "0x21DF660", Offset = "0x21DE260", VA = "0x1821DF660")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6026C4E")]
			[Address(RVA = "0x21DF6C0", Offset = "0x21DE2C0", VA = "0x1821DF6C0")]
			set
			{
			}
		}

		// Token: 0x06026C4F RID: 158799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C4F")]
		[Address(RVA = "0x21DE810", Offset = "0x21DD410", VA = "0x1821DE810", Slot = "4")]
		public virtual void LoadData(ZoneRecordGroupData groupData)
		{
		}

		// Token: 0x06026C50 RID: 158800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C50")]
		[Address(RVA = "0x21DE560", Offset = "0x21DD160", VA = "0x1821DE560")]
		public ZoneRecordViewModel GetCurrentRecordViewModel()
		{
			return null;
		}

		// Token: 0x06026C51 RID: 158801 RVA: 0x000CC390 File Offset: 0x000CA590
		[Token(Token = "0x6026C51")]
		[Address(RVA = "0x21DE4D0", Offset = "0x21DD0D0", VA = "0x1821DE4D0")]
		public bool CheckAvailableReward(ref string[] stageIds)
		{
			return default(bool);
		}

		// Token: 0x06026C52 RID: 158802 RVA: 0x000CC3A8 File Offset: 0x000CA5A8
		[Token(Token = "0x6026C52")]
		[Address(RVA = "0x21DE620", Offset = "0x21DD220", VA = "0x1821DE620")]
		public ZoneRecordGroupViewModel.DiffRewardStatus GetRewardStatus(StageDiffGroup stageDiff)
		{
			return default(ZoneRecordGroupViewModel.DiffRewardStatus);
		}

		// Token: 0x06026C53 RID: 158803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C53")]
		[Address(RVA = "0x21DE6F0", Offset = "0x21DD2F0", VA = "0x1821DE6F0")]
		public ZoneRecordViewModel GetZoneRecordById(string recordId, out int index)
		{
			return null;
		}

		// Token: 0x06026C54 RID: 158804 RVA: 0x000CC3C0 File Offset: 0x000CA5C0
		[Token(Token = "0x6026C54")]
		[Address(RVA = "0x21DF090", Offset = "0x21DDC90", VA = "0x1821DF090")]
		protected bool _CheckRecordRewardNeedComplete(string prevRecordId)
		{
			return default(bool);
		}

		// Token: 0x06026C55 RID: 158805 RVA: 0x000CC3D8 File Offset: 0x000CA5D8
		[Token(Token = "0x6026C55")]
		[Address(RVA = "0x21DEFC0", Offset = "0x21DDBC0", VA = "0x1821DEFC0")]
		protected bool _CheckRecordAvailable(string recordId)
		{
			return default(bool);
		}

		// Token: 0x06026C56 RID: 158806 RVA: 0x000CC3F0 File Offset: 0x000CA5F0
		[Token(Token = "0x6026C56")]
		[Address(RVA = "0x21DF260", Offset = "0x21DDE60", VA = "0x1821DF260")]
		protected bool _CheckUnlock(ZoneRecordUnlockData unlockData)
		{
			return default(bool);
		}

		// Token: 0x06026C57 RID: 158807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C57")]
		[Address(RVA = "0x21DF310", Offset = "0x21DDF10", VA = "0x1821DF310")]
		protected void _TryUpdateRewardStatus(ZoneRecordViewModel recordViewModel)
		{
		}

		// Token: 0x06026C58 RID: 158808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C58")]
		[Address(RVA = "0x21DF500", Offset = "0x21DE100", VA = "0x1821DF500")]
		public ZoneRecordGroupViewModel()
		{
		}

		// Token: 0x04036C2B RID: 224299
		[Token(Token = "0x4036C2B")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x04036C2C RID: 224300
		[Token(Token = "0x4036C2C")]
		[FieldOffset(Offset = "0x18")]
		protected int m_currentIdx;

		// Token: 0x04036C2D RID: 224301
		[Token(Token = "0x4036C2D")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, int> recordAvaiDict;

		// Token: 0x04036C2E RID: 224302
		[Token(Token = "0x4036C2E")]
		[FieldOffset(Offset = "0x28")]
		public List<ZoneRecordViewModel> recordList;

		// Token: 0x04036C2F RID: 224303
		[Token(Token = "0x4036C2F")]
		[FieldOffset(Offset = "0x30")]
		public ZoneRecordUnlockData unlockData;

		// Token: 0x04036C30 RID: 224304
		[Token(Token = "0x4036C30")]
		[FieldOffset(Offset = "0x38")]
		public bool unlocked;

		// Token: 0x04036C31 RID: 224305
		[Token(Token = "0x4036C31")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<StageDiffGroup, ZoneRecordGroupViewModel.DiffRewardStatus> rewardStatusDict;

		// Token: 0x04036C32 RID: 224306
		[Token(Token = "0x4036C32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentRecordIdx;

		// Token: 0x04036C33 RID: 224307
		[Token(Token = "0x4036C33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_currentRecordIdx;

		// Token: 0x04036C34 RID: 224308
		[Token(Token = "0x4036C34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04036C35 RID: 224309
		[Token(Token = "0x4036C35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurrentRecordViewModel;

		// Token: 0x04036C36 RID: 224310
		[Token(Token = "0x4036C36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckAvailableReward;

		// Token: 0x04036C37 RID: 224311
		[Token(Token = "0x4036C37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRewardStatus;

		// Token: 0x04036C38 RID: 224312
		[Token(Token = "0x4036C38")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetZoneRecordById;

		// Token: 0x04036C39 RID: 224313
		[Token(Token = "0x4036C39")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckRecordRewardNeedComplete;

		// Token: 0x04036C3A RID: 224314
		[Token(Token = "0x4036C3A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckRecordAvailable;

		// Token: 0x04036C3B RID: 224315
		[Token(Token = "0x4036C3B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckUnlock;

		// Token: 0x04036C3C RID: 224316
		[Token(Token = "0x4036C3C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryUpdateRewardStatus;

		// Token: 0x04036C3D RID: 224317
		[Token(Token = "0x4036C3D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069E1 RID: 27105
		[Token(Token = "0x20069E1")]
		public struct DiffRewardStatus
		{
			// Token: 0x04036C3E RID: 224318
			[Token(Token = "0x4036C3E")]
			[FieldOffset(Offset = "0x0")]
			public StageDiffGroup stageDiff;

			// Token: 0x04036C3F RID: 224319
			[Token(Token = "0x4036C3F")]
			[FieldOffset(Offset = "0x4")]
			public int rewardCount;

			// Token: 0x04036C40 RID: 224320
			[Token(Token = "0x4036C40")]
			[FieldOffset(Offset = "0x8")]
			public int rewardComplete;
		}
	}
}
