using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003470 RID: 13424
	[Token(Token = "0x2003470")]
	public class ActivityTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x060156B4 RID: 87732 RVA: 0x0008BBF0 File Offset: 0x00089DF0
		[Token(Token = "0x1700329E")]
		public bool isShow
		{
			[Token(Token = "0x60156B4")]
			[Address(RVA = "0xDE0690", Offset = "0xDDF290", VA = "0x180DE0690", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060156B5 RID: 87733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156B5")]
		[Address(RVA = "0xDE0590", Offset = "0xDDF190", VA = "0x180DE0590", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060156B6 RID: 87734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156B6")]
		[Address(RVA = "0xDE0630", Offset = "0xDDF230", VA = "0x180DE0630")]
		public ActivityTrackPointModel()
		{
		}

		// Token: 0x04019A54 RID: 105044
		[Token(Token = "0x4019A54")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasTrackPoint;

		// Token: 0x04019A55 RID: 105045
		[Token(Token = "0x4019A55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04019A56 RID: 105046
		[Token(Token = "0x4019A56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04019A57 RID: 105047
		[Token(Token = "0x4019A57")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
