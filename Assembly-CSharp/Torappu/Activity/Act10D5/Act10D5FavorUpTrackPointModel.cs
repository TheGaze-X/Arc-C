using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B38 RID: 31544
	[Token(Token = "0x2007B38")]
	public class Act10D5FavorUpTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006771 RID: 26481
		// (get) Token: 0x0602C291 RID: 180881 RVA: 0x000DE480 File Offset: 0x000DC680
		[Token(Token = "0x17006771")]
		public bool isShow
		{
			[Token(Token = "0x602C291")]
			[Address(RVA = "0x2806440", Offset = "0x2805040", VA = "0x182806440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C292 RID: 180882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C292")]
		[Address(RVA = "0x28062D0", Offset = "0x2804ED0", VA = "0x1828062D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602C293 RID: 180883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C293")]
		[Address(RVA = "0x28063E0", Offset = "0x2804FE0", VA = "0x1828063E0")]
		public Act10D5FavorUpTrackPointModel()
		{
		}

		// Token: 0x04040049 RID: 262217
		[Token(Token = "0x4040049")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasNewUp;

		// Token: 0x0404004A RID: 262218
		[Token(Token = "0x404004A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0404004B RID: 262219
		[Token(Token = "0x404004B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0404004C RID: 262220
		[Token(Token = "0x404004C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
