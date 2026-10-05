using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078D1 RID: 30929
	[Token(Token = "0x20078D1")]
	public class Act1LockMissionTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602B5EF RID: 177647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5EF")]
		[Address(RVA = "0x272BAB0", Offset = "0x272A6B0", VA = "0x18272BAB0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x1700658D RID: 25997
		// (get) Token: 0x0602B5F0 RID: 177648 RVA: 0x000DB960 File Offset: 0x000D9B60
		[Token(Token = "0x1700658D")]
		public bool isShow
		{
			[Token(Token = "0x602B5F0")]
			[Address(RVA = "0x272BE10", Offset = "0x272AA10", VA = "0x18272BE10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B5F1 RID: 177649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5F1")]
		[Address(RVA = "0x272BDB0", Offset = "0x272A9B0", VA = "0x18272BDB0")]
		public Act1LockMissionTrackPointModel()
		{
		}

		// Token: 0x0403EB80 RID: 256896
		[Token(Token = "0x403EB80")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasCanGetRewardMission;

		// Token: 0x0403EB81 RID: 256897
		[Token(Token = "0x403EB81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403EB82 RID: 256898
		[Token(Token = "0x403EB82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403EB83 RID: 256899
		[Token(Token = "0x403EB83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
