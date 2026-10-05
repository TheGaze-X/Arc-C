using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007852 RID: 30802
	[Token(Token = "0x2007852")]
	public class Act1MainSSAllExploreTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006514 RID: 25876
		// (get) Token: 0x0602B316 RID: 176918 RVA: 0x000DB198 File Offset: 0x000D9398
		[Token(Token = "0x17006514")]
		public bool isShow
		{
			[Token(Token = "0x602B316")]
			[Address(RVA = "0x27195B0", Offset = "0x27181B0", VA = "0x1827195B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B317 RID: 176919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B317")]
		[Address(RVA = "0x27194F0", Offset = "0x27180F0", VA = "0x1827194F0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602B318 RID: 176920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B318")]
		[Address(RVA = "0x2719550", Offset = "0x2718150", VA = "0x182719550")]
		public Act1MainSSAllExploreTrackPoint()
		{
		}

		// Token: 0x0403E715 RID: 255765
		[Token(Token = "0x403E715")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403E716 RID: 255766
		[Token(Token = "0x403E716")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403E717 RID: 255767
		[Token(Token = "0x403E717")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
