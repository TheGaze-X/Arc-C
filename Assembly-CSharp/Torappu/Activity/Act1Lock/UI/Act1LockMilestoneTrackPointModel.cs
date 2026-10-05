using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078D0 RID: 30928
	[Token(Token = "0x20078D0")]
	public class Act1LockMilestoneTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602B5EC RID: 177644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5EC")]
		[Address(RVA = "0x272AEC0", Offset = "0x2729AC0", VA = "0x18272AEC0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x1700658C RID: 25996
		// (get) Token: 0x0602B5ED RID: 177645 RVA: 0x000DB948 File Offset: 0x000D9B48
		[Token(Token = "0x1700658C")]
		public bool isShow
		{
			[Token(Token = "0x602B5ED")]
			[Address(RVA = "0x272B080", Offset = "0x2729C80", VA = "0x18272B080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B5EE RID: 177646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5EE")]
		[Address(RVA = "0x272B020", Offset = "0x2729C20", VA = "0x18272B020")]
		public Act1LockMilestoneTrackPointModel()
		{
		}

		// Token: 0x0403EB7C RID: 256892
		[Token(Token = "0x403EB7C")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasCanGetMilestone;

		// Token: 0x0403EB7D RID: 256893
		[Token(Token = "0x403EB7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403EB7E RID: 256894
		[Token(Token = "0x403EB7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403EB7F RID: 256895
		[Token(Token = "0x403EB7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
