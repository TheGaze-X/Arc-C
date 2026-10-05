using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007391 RID: 29585
	[Token(Token = "0x2007391")]
	public class Act42d0AreaMapViewModel : IHotfixable
	{
		// Token: 0x06029D2D RID: 171309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D2D")]
		[Address(RVA = "0x25787D0", Offset = "0x25773D0", VA = "0x1825787D0")]
		public void LoadData(string activityId, string areaId, string stageId)
		{
		}

		// Token: 0x06029D2E RID: 171310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D2E")]
		[Address(RVA = "0x2578F60", Offset = "0x2577B60", VA = "0x182578F60")]
		private void _InitSelection(string areaId, string stageId)
		{
		}

		// Token: 0x06029D2F RID: 171311 RVA: 0x000D6B78 File Offset: 0x000D4D78
		[Token(Token = "0x6029D2F")]
		[Address(RVA = "0x2578E00", Offset = "0x2577A00", VA = "0x182578E00")]
		private Act42D0Data.Act42D0AreaDifficulty _FindUnlockHardestAreaDiff()
		{
			return Act42D0Data.Act42D0AreaDifficulty.NONE;
		}

		// Token: 0x06029D30 RID: 171312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D30")]
		[Address(RVA = "0x2578B90", Offset = "0x2577790", VA = "0x182578B90")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06029D31 RID: 171313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029D31")]
		[Address(RVA = "0x25786B0", Offset = "0x25772B0", VA = "0x1825786B0")]
		public Act42d0AreaViewModel GetAreaViewModel(string areaId)
		{
			return null;
		}

		// Token: 0x06029D32 RID: 171314 RVA: 0x000D6B90 File Offset: 0x000D4D90
		[Token(Token = "0x6029D32")]
		[Address(RVA = "0x25784E0", Offset = "0x25770E0", VA = "0x1825784E0")]
		public bool AreaIdValid(string areaId)
		{
			return default(bool);
		}

		// Token: 0x06029D33 RID: 171315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D33")]
		[Address(RVA = "0x2578590", Offset = "0x2577190", VA = "0x182578590")]
		public void ClearSelect()
		{
		}

		// Token: 0x06029D34 RID: 171316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D34")]
		[Address(RVA = "0x25792B0", Offset = "0x2577EB0", VA = "0x1825792B0")]
		public Act42d0AreaMapViewModel()
		{
		}

		// Token: 0x0403BE5F RID: 245343
		[Token(Token = "0x403BE5F")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403BE60 RID: 245344
		[Token(Token = "0x403BE60")]
		[FieldOffset(Offset = "0x18")]
		public Act42D0Data.Act42D0AreaDifficulty currentDiff;

		// Token: 0x0403BE61 RID: 245345
		[Token(Token = "0x403BE61")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act42d0AreaViewModel> areaViewModelDict;

		// Token: 0x0403BE62 RID: 245346
		[Token(Token = "0x403BE62")]
		[FieldOffset(Offset = "0x28")]
		public string areaSelectedId;

		// Token: 0x0403BE63 RID: 245347
		[Token(Token = "0x403BE63")]
		[FieldOffset(Offset = "0x30")]
		public bool hardUnlocked;

		// Token: 0x0403BE64 RID: 245348
		[Token(Token = "0x403BE64")]
		[FieldOffset(Offset = "0x38")]
		public NewestProgress lastProgressInfo;

		// Token: 0x0403BE65 RID: 245349
		[Token(Token = "0x403BE65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BE66 RID: 245350
		[Token(Token = "0x403BE66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitSelection;

		// Token: 0x0403BE67 RID: 245351
		[Token(Token = "0x403BE67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FindUnlockHardestAreaDiff;

		// Token: 0x0403BE68 RID: 245352
		[Token(Token = "0x403BE68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0403BE69 RID: 245353
		[Token(Token = "0x403BE69")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetAreaViewModel;

		// Token: 0x0403BE6A RID: 245354
		[Token(Token = "0x403BE6A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AreaIdValid;

		// Token: 0x0403BE6B RID: 245355
		[Token(Token = "0x403BE6B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClearSelect;

		// Token: 0x0403BE6C RID: 245356
		[Token(Token = "0x403BE6C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
