using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B05 RID: 31493
	[Token(Token = "0x2007B05")]
	public class Act12D6MileStoneAvailTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700674E RID: 26446
		// (get) Token: 0x0602C189 RID: 180617 RVA: 0x000DE180 File Offset: 0x000DC380
		[Token(Token = "0x1700674E")]
		public bool isShow
		{
			[Token(Token = "0x602C189")]
			[Address(RVA = "0x27F2920", Offset = "0x27F1520", VA = "0x1827F2920", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C18A RID: 180618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C18A")]
		[Address(RVA = "0x27F25C0", Offset = "0x27F11C0", VA = "0x1827F25C0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602C18B RID: 180619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C18B")]
		[Address(RVA = "0x27F28C0", Offset = "0x27F14C0", VA = "0x1827F28C0")]
		public Act12D6MileStoneAvailTrackPointModel()
		{
		}

		// Token: 0x0403FEBE RID: 261822
		[Token(Token = "0x403FEBE")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasNew;

		// Token: 0x0403FEBF RID: 261823
		[Token(Token = "0x403FEBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403FEC0 RID: 261824
		[Token(Token = "0x403FEC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403FEC1 RID: 261825
		[Token(Token = "0x403FEC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
