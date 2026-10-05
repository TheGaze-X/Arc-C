using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BD4 RID: 19412
	[Token(Token = "0x2004BD4")]
	public class HomeAPItemRemainTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x0601D2D9 RID: 119513 RVA: 0x000AAD18 File Offset: 0x000A8F18
		[Token(Token = "0x170044A4")]
		public bool isShow
		{
			[Token(Token = "0x601D2D9")]
			[Address(RVA = "0x16BA290", Offset = "0x16B8E90", VA = "0x1816BA290", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D2DA RID: 119514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2DA")]
		[Address(RVA = "0x16BA1D0", Offset = "0x16B8DD0", VA = "0x1816BA1D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D2DB RID: 119515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2DB")]
		[Address(RVA = "0x16BA230", Offset = "0x16B8E30", VA = "0x1816BA230")]
		public HomeAPItemRemainTrackPoint()
		{
		}

		// Token: 0x040264AA RID: 156842
		[Token(Token = "0x40264AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040264AB RID: 156843
		[Token(Token = "0x40264AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040264AC RID: 156844
		[Token(Token = "0x40264AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
