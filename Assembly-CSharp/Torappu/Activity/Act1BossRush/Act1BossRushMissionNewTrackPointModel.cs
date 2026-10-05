using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070B6 RID: 28854
	[Token(Token = "0x20070B6")]
	public class Act1BossRushMissionNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700613A RID: 24890
		// (get) Token: 0x0602903E RID: 167998 RVA: 0x000D4178 File Offset: 0x000D2378
		[Token(Token = "0x1700613A")]
		public bool isShow
		{
			[Token(Token = "0x602903E")]
			[Address(RVA = "0x246AF30", Offset = "0x2469B30", VA = "0x18246AF30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602903F RID: 167999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602903F")]
		[Address(RVA = "0x246AE00", Offset = "0x2469A00", VA = "0x18246AE00", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06029040 RID: 168000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029040")]
		[Address(RVA = "0x246AED0", Offset = "0x2469AD0", VA = "0x18246AED0")]
		public Act1BossRushMissionNewTrackPointModel()
		{
		}

		// Token: 0x0403A8B7 RID: 239799
		[Token(Token = "0x403A8B7")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403A8B8 RID: 239800
		[Token(Token = "0x403A8B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403A8B9 RID: 239801
		[Token(Token = "0x403A8B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403A8BA RID: 239802
		[Token(Token = "0x403A8BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070B7 RID: 28855
		[Token(Token = "0x20070B7")]
		public class Input
		{
			// Token: 0x06029041 RID: 168001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029041")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403A8BB RID: 239803
			[Token(Token = "0x403A8BB")]
			[FieldOffset(Offset = "0x10")]
			public bool haveAbleToGetMission;
		}
	}
}
