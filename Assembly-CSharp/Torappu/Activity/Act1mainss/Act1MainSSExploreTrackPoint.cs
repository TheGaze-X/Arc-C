using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007851 RID: 30801
	[Token(Token = "0x2007851")]
	public class Act1MainSSExploreTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006513 RID: 25875
		// (get) Token: 0x0602B312 RID: 176914 RVA: 0x000DB180 File Offset: 0x000D9380
		[Token(Token = "0x17006513")]
		public bool isShow
		{
			[Token(Token = "0x602B312")]
			[Address(RVA = "0x271A690", Offset = "0x2719290", VA = "0x18271A690", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B313 RID: 176915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B313")]
		[Address(RVA = "0x271A520", Offset = "0x2719120", VA = "0x18271A520", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602B314 RID: 176916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B314")]
		[Address(RVA = "0x271A610", Offset = "0x2719210", VA = "0x18271A610")]
		public Act1MainSSExploreTrackPoint()
		{
		}

		// Token: 0x0403E711 RID: 255761
		[Token(Token = "0x403E711")]
		[FieldOffset(Offset = "0x0")]
		public static string TRACK_PARAM;

		// Token: 0x0403E712 RID: 255762
		[Token(Token = "0x403E712")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403E713 RID: 255763
		[Token(Token = "0x403E713")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403E714 RID: 255764
		[Token(Token = "0x403E714")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
