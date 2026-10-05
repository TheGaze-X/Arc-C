using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078CA RID: 30922
	[Token(Token = "0x20078CA")]
	public class Act1LockNormalDetailModel : Act1LockDetailModelBase
	{
		// Token: 0x1700657B RID: 25979
		// (get) Token: 0x0602B5C8 RID: 177608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700657B")]
		public StageViewModel basicStageModel
		{
			[Token(Token = "0x602B5C8")]
			[Address(RVA = "0x272C050", Offset = "0x272AC50", VA = "0x18272C050")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700657C RID: 25980
		// (get) Token: 0x0602B5C9 RID: 177609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700657C")]
		public ActivityInterlockData.StageAdditionData additionData
		{
			[Token(Token = "0x602B5C9")]
			[Address(RVA = "0x272BFF0", Offset = "0x272ABF0", VA = "0x18272BFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700657D RID: 25981
		// (get) Token: 0x0602B5CA RID: 177610 RVA: 0x000DB870 File Offset: 0x000D9A70
		// (set) Token: 0x0602B5CB RID: 177611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700657D")]
		public bool isExpand
		{
			[Token(Token = "0x602B5CA")]
			[Address(RVA = "0x272C0B0", Offset = "0x272ACB0", VA = "0x18272C0B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B5CB")]
			[Address(RVA = "0x272C170", Offset = "0x272AD70", VA = "0x18272C170")]
			set
			{
			}
		}

		// Token: 0x1700657E RID: 25982
		// (get) Token: 0x0602B5CC RID: 177612 RVA: 0x000DB888 File Offset: 0x000D9A88
		[Token(Token = "0x1700657E")]
		public override ActivityInterlockData.InterlockStageType stageType
		{
			[Token(Token = "0x602B5CC")]
			[Address(RVA = "0x272C110", Offset = "0x272AD10", VA = "0x18272C110", Slot = "4")]
			get
			{
				return ActivityInterlockData.InterlockStageType.NONE;
			}
		}

		// Token: 0x0602B5CD RID: 177613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5CD")]
		[Address(RVA = "0x272BE70", Offset = "0x272AA70", VA = "0x18272BE70", Slot = "5")]
		public override void LoadStageData(string stageId)
		{
		}

		// Token: 0x0602B5CE RID: 177614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5CE")]
		[Address(RVA = "0x272BF00", Offset = "0x272AB00", VA = "0x18272BF00")]
		public Act1LockNormalDetailModel()
		{
		}

		// Token: 0x0403EB49 RID: 256841
		[Token(Token = "0x403EB49")]
		[FieldOffset(Offset = "0x20")]
		private ActivityInterlockData.StageAdditionData m_additionData;

		// Token: 0x0403EB4A RID: 256842
		[Token(Token = "0x403EB4A")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isExpand;

		// Token: 0x0403EB4B RID: 256843
		[Token(Token = "0x403EB4B")]
		[FieldOffset(Offset = "0x30")]
		private StageViewModel m_commonStageModel;

		// Token: 0x0403EB4C RID: 256844
		[Token(Token = "0x403EB4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_basicStageModel;

		// Token: 0x0403EB4D RID: 256845
		[Token(Token = "0x403EB4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_additionData;

		// Token: 0x0403EB4E RID: 256846
		[Token(Token = "0x403EB4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isExpand;

		// Token: 0x0403EB4F RID: 256847
		[Token(Token = "0x403EB4F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isExpand;

		// Token: 0x0403EB50 RID: 256848
		[Token(Token = "0x403EB50")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageType;

		// Token: 0x0403EB51 RID: 256849
		[Token(Token = "0x403EB51")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadStageData;

		// Token: 0x0403EB52 RID: 256850
		[Token(Token = "0x403EB52")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
