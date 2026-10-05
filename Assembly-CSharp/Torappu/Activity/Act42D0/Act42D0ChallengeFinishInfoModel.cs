using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200735C RID: 29532
	[Token(Token = "0x200735C")]
	public class Act42D0ChallengeFinishInfoModel : Act42D0FinishInfoModel
	{
		// Token: 0x170062A2 RID: 25250
		// (get) Token: 0x06029C3E RID: 171070 RVA: 0x000D6800 File Offset: 0x000D4A00
		[Token(Token = "0x170062A2")]
		public int progress
		{
			[Token(Token = "0x6029C3E")]
			[Address(RVA = "0x2554F60", Offset = "0x2553B60", VA = "0x182554F60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062A3 RID: 25251
		// (get) Token: 0x06029C3F RID: 171071 RVA: 0x000D6818 File Offset: 0x000D4A18
		[Token(Token = "0x170062A3")]
		public int totalMissionCount
		{
			[Token(Token = "0x6029C3F")]
			[Address(RVA = "0x2554FC0", Offset = "0x2553BC0", VA = "0x182554FC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170062A4 RID: 25252
		// (get) Token: 0x06029C40 RID: 171072 RVA: 0x000D6830 File Offset: 0x000D4A30
		[Token(Token = "0x170062A4")]
		public bool isProgressNew
		{
			[Token(Token = "0x6029C40")]
			[Address(RVA = "0x2554F00", Offset = "0x2553B00", VA = "0x182554F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029C41 RID: 171073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029C41")]
		[Address(RVA = "0x2554BF0", Offset = "0x25537F0", VA = "0x182554BF0", Slot = "6")]
		public override string GetStageName()
		{
			return null;
		}

		// Token: 0x06029C42 RID: 171074 RVA: 0x000D6848 File Offset: 0x000D4A48
		[Token(Token = "0x6029C42")]
		[Address(RVA = "0x2554C80", Offset = "0x2553880", VA = "0x182554C80", Slot = "5")]
		public override Act42D0FinishInfoModel.ViewType GetViewType()
		{
			return Act42D0FinishInfoModel.ViewType.NONE;
		}

		// Token: 0x06029C43 RID: 171075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C43")]
		[Address(RVA = "0x2554CE0", Offset = "0x25538E0", VA = "0x182554CE0", Slot = "4")]
		public override void LoadData(Act42D0Data actData, CommonFinishBattleResponse response)
		{
		}

		// Token: 0x06029C44 RID: 171076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029C44")]
		[Address(RVA = "0x2554B80", Offset = "0x2553780", VA = "0x182554B80", Slot = "7")]
		public override string GetDisplayIconId()
		{
			return null;
		}

		// Token: 0x06029C45 RID: 171077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C45")]
		[Address(RVA = "0x2554E60", Offset = "0x2553A60", VA = "0x182554E60")]
		public Act42D0ChallengeFinishInfoModel()
		{
		}

		// Token: 0x0403BC81 RID: 244865
		[Token(Token = "0x403BC81")]
		[FieldOffset(Offset = "0x28")]
		private int m_progress;

		// Token: 0x0403BC82 RID: 244866
		[Token(Token = "0x403BC82")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isProgressNew;

		// Token: 0x0403BC83 RID: 244867
		[Token(Token = "0x403BC83")]
		[FieldOffset(Offset = "0x30")]
		private Act42D0Data.Act42D0ChallengeInfoData m_stageInfo;

		// Token: 0x0403BC84 RID: 244868
		[Token(Token = "0x403BC84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0403BC85 RID: 244869
		[Token(Token = "0x403BC85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalMissionCount;

		// Token: 0x0403BC86 RID: 244870
		[Token(Token = "0x403BC86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isProgressNew;

		// Token: 0x0403BC87 RID: 244871
		[Token(Token = "0x403BC87")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStageName;

		// Token: 0x0403BC88 RID: 244872
		[Token(Token = "0x403BC88")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403BC89 RID: 244873
		[Token(Token = "0x403BC89")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BC8A RID: 244874
		[Token(Token = "0x403BC8A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDisplayIconId;

		// Token: 0x0403BC8B RID: 244875
		[Token(Token = "0x403BC8B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
