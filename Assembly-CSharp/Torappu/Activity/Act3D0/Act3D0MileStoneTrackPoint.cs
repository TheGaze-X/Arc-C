using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007427 RID: 29735
	[Token(Token = "0x2007427")]
	public class Act3D0MileStoneTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006317 RID: 25367
		// (get) Token: 0x06029F8E RID: 171918 RVA: 0x000D7178 File Offset: 0x000D5378
		[Token(Token = "0x17006317")]
		public bool isShow
		{
			[Token(Token = "0x6029F8E")]
			[Address(RVA = "0x2590430", Offset = "0x258F030", VA = "0x182590430", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029F8F RID: 171919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F8F")]
		[Address(RVA = "0x2590260", Offset = "0x258EE60", VA = "0x182590260", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06029F90 RID: 171920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F90")]
		[Address(RVA = "0x25903D0", Offset = "0x258EFD0", VA = "0x1825903D0")]
		public Act3D0MileStoneTrackPoint()
		{
		}

		// Token: 0x0403C2D8 RID: 246488
		[Token(Token = "0x403C2D8")]
		[FieldOffset(Offset = "0x10")]
		private int m_finishedList;

		// Token: 0x0403C2D9 RID: 246489
		[Token(Token = "0x403C2D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403C2DA RID: 246490
		[Token(Token = "0x403C2DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403C2DB RID: 246491
		[Token(Token = "0x403C2DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
