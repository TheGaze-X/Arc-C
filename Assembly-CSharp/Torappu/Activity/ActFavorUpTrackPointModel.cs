using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D80 RID: 28032
	[Token(Token = "0x2006D80")]
	public class ActFavorUpTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005E66 RID: 24166
		// (get) Token: 0x06027EF4 RID: 163572 RVA: 0x000D0200 File Offset: 0x000CE400
		[Token(Token = "0x17005E66")]
		public bool isShow
		{
			[Token(Token = "0x6027EF4")]
			[Address(RVA = "0x23335B0", Offset = "0x23321B0", VA = "0x1823335B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027EF5 RID: 163573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EF5")]
		[Address(RVA = "0x23333F0", Offset = "0x2331FF0", VA = "0x1823333F0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06027EF6 RID: 163574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EF6")]
		[Address(RVA = "0x2333550", Offset = "0x2332150", VA = "0x182333550")]
		public ActFavorUpTrackPointModel()
		{
		}

		// Token: 0x040389A4 RID: 231844
		[Token(Token = "0x40389A4")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x040389A5 RID: 231845
		[Token(Token = "0x40389A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040389A6 RID: 231846
		[Token(Token = "0x40389A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040389A7 RID: 231847
		[Token(Token = "0x40389A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
