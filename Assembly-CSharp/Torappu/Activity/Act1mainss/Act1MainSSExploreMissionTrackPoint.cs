using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007850 RID: 30800
	[Token(Token = "0x2007850")]
	public class Act1MainSSExploreMissionTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006512 RID: 25874
		// (get) Token: 0x0602B30F RID: 176911 RVA: 0x000DB168 File Offset: 0x000D9368
		[Token(Token = "0x17006512")]
		public bool isShow
		{
			[Token(Token = "0x602B30F")]
			[Address(RVA = "0x271A4C0", Offset = "0x27190C0", VA = "0x18271A4C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B310 RID: 176912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B310")]
		[Address(RVA = "0x271A400", Offset = "0x2719000", VA = "0x18271A400", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602B311 RID: 176913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B311")]
		[Address(RVA = "0x271A460", Offset = "0x2719060", VA = "0x18271A460")]
		public Act1MainSSExploreMissionTrackPoint()
		{
		}

		// Token: 0x0403E70E RID: 255758
		[Token(Token = "0x403E70E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403E70F RID: 255759
		[Token(Token = "0x403E70F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403E710 RID: 255760
		[Token(Token = "0x403E710")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
