using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078CC RID: 30924
	[Token(Token = "0x20078CC")]
	public class Act1LockFinalDetailModel : Act1LockDetailModelBase
	{
		// Token: 0x17006586 RID: 25990
		// (get) Token: 0x0602B5DA RID: 177626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006586")]
		public StageViewModel basicStageModel
		{
			[Token(Token = "0x602B5DA")]
			[Address(RVA = "0x271F900", Offset = "0x271E500", VA = "0x18271F900")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006587 RID: 25991
		// (get) Token: 0x0602B5DB RID: 177627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006587")]
		public ActivityInterlockData.StageAdditionData additionData
		{
			[Token(Token = "0x602B5DB")]
			[Address(RVA = "0x271F8A0", Offset = "0x271E4A0", VA = "0x18271F8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006588 RID: 25992
		// (get) Token: 0x0602B5DC RID: 177628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006588")]
		public List<InterlockSquadModel> interlockList
		{
			[Token(Token = "0x602B5DC")]
			[Address(RVA = "0x271FC20", Offset = "0x271E820", VA = "0x18271FC20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006589 RID: 25993
		// (get) Token: 0x0602B5DD RID: 177629 RVA: 0x000DB8E8 File Offset: 0x000D9AE8
		[Token(Token = "0x17006589")]
		public bool finalStagePass
		{
			[Token(Token = "0x602B5DD")]
			[Address(RVA = "0x271F960", Offset = "0x271E560", VA = "0x18271F960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700658A RID: 25994
		// (get) Token: 0x0602B5DE RID: 177630 RVA: 0x000DB900 File Offset: 0x000D9B00
		[Token(Token = "0x1700658A")]
		public int interlockCount
		{
			[Token(Token = "0x602B5DE")]
			[Address(RVA = "0x271FAB0", Offset = "0x271E6B0", VA = "0x18271FAB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700658B RID: 25995
		// (get) Token: 0x0602B5DF RID: 177631 RVA: 0x000DB918 File Offset: 0x000D9B18
		[Token(Token = "0x1700658B")]
		public override ActivityInterlockData.InterlockStageType stageType
		{
			[Token(Token = "0x602B5DF")]
			[Address(RVA = "0x271FC80", Offset = "0x271E880", VA = "0x18271FC80", Slot = "4")]
			get
			{
				return ActivityInterlockData.InterlockStageType.NONE;
			}
		}

		// Token: 0x0602B5E0 RID: 177632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5E0")]
		[Address(RVA = "0x271F2C0", Offset = "0x271DEC0", VA = "0x18271F2C0")]
		private void _InitInterlockListIfNot()
		{
		}

		// Token: 0x0602B5E1 RID: 177633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5E1")]
		[Address(RVA = "0x271F160", Offset = "0x271DD60", VA = "0x18271F160", Slot = "5")]
		public override void LoadStageData(string stageId)
		{
		}

		// Token: 0x0602B5E2 RID: 177634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5E2")]
		[Address(RVA = "0x271F210", Offset = "0x271DE10", VA = "0x18271F210")]
		public void UpdateStageData()
		{
		}

		// Token: 0x0602B5E3 RID: 177635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5E3")]
		[Address(RVA = "0x271F610", Offset = "0x271E210", VA = "0x18271F610")]
		private void _UpdateInterlockList()
		{
		}

		// Token: 0x0602B5E4 RID: 177636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5E4")]
		[Address(RVA = "0x271F770", Offset = "0x271E370", VA = "0x18271F770")]
		public Act1LockFinalDetailModel()
		{
		}

		// Token: 0x0403EB63 RID: 256867
		[Token(Token = "0x403EB63")]
		[FieldOffset(Offset = "0x20")]
		private ActivityInterlockData.StageAdditionData m_additionData;

		// Token: 0x0403EB64 RID: 256868
		[Token(Token = "0x403EB64")]
		[FieldOffset(Offset = "0x28")]
		private StageViewModel m_commonStageModel;

		// Token: 0x0403EB65 RID: 256869
		[Token(Token = "0x403EB65")]
		[FieldOffset(Offset = "0x30")]
		private List<InterlockSquadModel> m_interlockList;

		// Token: 0x0403EB66 RID: 256870
		[Token(Token = "0x403EB66")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0403EB67 RID: 256871
		[Token(Token = "0x403EB67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_basicStageModel;

		// Token: 0x0403EB68 RID: 256872
		[Token(Token = "0x403EB68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_additionData;

		// Token: 0x0403EB69 RID: 256873
		[Token(Token = "0x403EB69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_interlockList;

		// Token: 0x0403EB6A RID: 256874
		[Token(Token = "0x403EB6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_finalStagePass;

		// Token: 0x0403EB6B RID: 256875
		[Token(Token = "0x403EB6B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_interlockCount;

		// Token: 0x0403EB6C RID: 256876
		[Token(Token = "0x403EB6C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_stageType;

		// Token: 0x0403EB6D RID: 256877
		[Token(Token = "0x403EB6D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitInterlockListIfNot;

		// Token: 0x0403EB6E RID: 256878
		[Token(Token = "0x403EB6E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadStageData;

		// Token: 0x0403EB6F RID: 256879
		[Token(Token = "0x403EB6F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateStageData;

		// Token: 0x0403EB70 RID: 256880
		[Token(Token = "0x403EB70")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateInterlockList;

		// Token: 0x0403EB71 RID: 256881
		[Token(Token = "0x403EB71")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
