using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B96 RID: 19350
	[Token(Token = "0x2004B96")]
	public class HomeIllustTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700447E RID: 17534
		// (get) Token: 0x0601D1C4 RID: 119236 RVA: 0x000AA838 File Offset: 0x000A8A38
		[Token(Token = "0x1700447E")]
		public bool isShow
		{
			[Token(Token = "0x601D1C4")]
			[Address(RVA = "0x169C650", Offset = "0x169B250", VA = "0x18169C650", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1C5 RID: 119237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1C5")]
		[Address(RVA = "0x169C520", Offset = "0x169B120", VA = "0x18169C520", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1C6 RID: 119238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1C6")]
		[Address(RVA = "0x169C5F0", Offset = "0x169B1F0", VA = "0x18169C5F0")]
		public HomeIllustTrackPointModel()
		{
		}

		// Token: 0x04026343 RID: 156483
		[Token(Token = "0x4026343")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04026344 RID: 156484
		[Token(Token = "0x4026344")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026345 RID: 156485
		[Token(Token = "0x4026345")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026346 RID: 156486
		[Token(Token = "0x4026346")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
