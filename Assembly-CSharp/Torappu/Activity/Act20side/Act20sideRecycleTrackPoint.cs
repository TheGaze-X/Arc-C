using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x020076A6 RID: 30374
	[Token(Token = "0x20076A6")]
	public class Act20sideRecycleTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602AB4C RID: 174924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB4C")]
		[Address(RVA = "0x267A110", Offset = "0x2678D10", VA = "0x18267A110", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17006458 RID: 25688
		// (get) Token: 0x0602AB4D RID: 174925 RVA: 0x000D97B8 File Offset: 0x000D79B8
		[Token(Token = "0x17006458")]
		public bool isShow
		{
			[Token(Token = "0x602AB4D")]
			[Address(RVA = "0x267A260", Offset = "0x2678E60", VA = "0x18267A260", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB4E RID: 174926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB4E")]
		[Address(RVA = "0x267A200", Offset = "0x2678E00", VA = "0x18267A200")]
		public Act20sideRecycleTrackPoint()
		{
		}

		// Token: 0x0403D8AE RID: 252078
		[Token(Token = "0x403D8AE")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403D8AF RID: 252079
		[Token(Token = "0x403D8AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D8B0 RID: 252080
		[Token(Token = "0x403D8B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D8B1 RID: 252081
		[Token(Token = "0x403D8B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
