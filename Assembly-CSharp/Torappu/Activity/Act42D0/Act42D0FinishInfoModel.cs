using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007359 RID: 29529
	[Token(Token = "0x2007359")]
	public abstract class Act42D0FinishInfoModel : IHotfixable
	{
		// Token: 0x17006297 RID: 25239
		// (get) Token: 0x06029C28 RID: 171048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006297")]
		public string stageId
		{
			[Token(Token = "0x6029C28")]
			[Address(RVA = "0x2560B60", Offset = "0x255F760", VA = "0x182560B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006298 RID: 25240
		// (get) Token: 0x06029C29 RID: 171049 RVA: 0x000D6770 File Offset: 0x000D4970
		[Token(Token = "0x17006298")]
		public int milestoneGot
		{
			[Token(Token = "0x6029C29")]
			[Address(RVA = "0x2560B00", Offset = "0x255F700", VA = "0x182560B00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006299 RID: 25241
		// (get) Token: 0x06029C2A RID: 171050 RVA: 0x000D6788 File Offset: 0x000D4988
		[Token(Token = "0x17006299")]
		public int totalMilestone
		{
			[Token(Token = "0x6029C2A")]
			[Address(RVA = "0x2560BC0", Offset = "0x255F7C0", VA = "0x182560BC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700629A RID: 25242
		// (get) Token: 0x06029C2B RID: 171051 RVA: 0x000D67A0 File Offset: 0x000D49A0
		[Token(Token = "0x1700629A")]
		public long finishTs
		{
			[Token(Token = "0x6029C2B")]
			[Address(RVA = "0x2560AA0", Offset = "0x255F6A0", VA = "0x182560AA0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06029C2C RID: 171052
		[Token(Token = "0x6029C2C")]
		public abstract void LoadData(Act42D0Data actData, CommonFinishBattleResponse response);

		// Token: 0x06029C2D RID: 171053
		[Token(Token = "0x6029C2D")]
		public abstract Act42D0FinishInfoModel.ViewType GetViewType();

		// Token: 0x06029C2E RID: 171054
		[Token(Token = "0x6029C2E")]
		public abstract string GetStageName();

		// Token: 0x06029C2F RID: 171055
		[Token(Token = "0x6029C2F")]
		public abstract string GetDisplayIconId();

		// Token: 0x06029C30 RID: 171056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C30")]
		[Address(RVA = "0x2560A40", Offset = "0x255F640", VA = "0x182560A40")]
		protected Act42D0FinishInfoModel()
		{
		}

		// Token: 0x0403BC5F RID: 244831
		[Token(Token = "0x403BC5F")]
		[FieldOffset(Offset = "0x10")]
		protected string m_stageId;

		// Token: 0x0403BC60 RID: 244832
		[Token(Token = "0x403BC60")]
		[FieldOffset(Offset = "0x18")]
		protected int m_milestoneGot;

		// Token: 0x0403BC61 RID: 244833
		[Token(Token = "0x403BC61")]
		[FieldOffset(Offset = "0x1C")]
		protected int m_milestoneAfter;

		// Token: 0x0403BC62 RID: 244834
		[Token(Token = "0x403BC62")]
		[FieldOffset(Offset = "0x20")]
		protected long m_finishTs;

		// Token: 0x0403BC63 RID: 244835
		[Token(Token = "0x403BC63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403BC64 RID: 244836
		[Token(Token = "0x403BC64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_milestoneGot;

		// Token: 0x0403BC65 RID: 244837
		[Token(Token = "0x403BC65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_totalMilestone;

		// Token: 0x0403BC66 RID: 244838
		[Token(Token = "0x403BC66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_finishTs;

		// Token: 0x0403BC67 RID: 244839
		[Token(Token = "0x403BC67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200735A RID: 29530
		[Token(Token = "0x200735A")]
		public enum ViewType
		{
			// Token: 0x0403BC69 RID: 244841
			[Token(Token = "0x403BC69")]
			NONE,
			// Token: 0x0403BC6A RID: 244842
			[Token(Token = "0x403BC6A")]
			NORMAL,
			// Token: 0x0403BC6B RID: 244843
			[Token(Token = "0x403BC6B")]
			CHALLENGE
		}
	}
}
