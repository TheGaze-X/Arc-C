using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B9A RID: 19354
	[Token(Token = "0x2004B9A")]
	public class HomeActEntryExpandModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004481 RID: 17537
		// (get) Token: 0x0601D1D5 RID: 119253 RVA: 0x000AA8E0 File Offset: 0x000A8AE0
		[Token(Token = "0x17004481")]
		public bool isShow
		{
			[Token(Token = "0x601D1D5")]
			[Address(RVA = "0x169AE30", Offset = "0x1699A30", VA = "0x18169AE30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1D6 RID: 119254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1D6")]
		[Address(RVA = "0x169AC60", Offset = "0x1699860", VA = "0x18169AC60", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1D7 RID: 119255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1D7")]
		[Address(RVA = "0x169ADD0", Offset = "0x16999D0", VA = "0x18169ADD0")]
		public HomeActEntryExpandModel()
		{
		}

		// Token: 0x04026349 RID: 156489
		[Token(Token = "0x4026349")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasTrackPoint;

		// Token: 0x0402634A RID: 156490
		[Token(Token = "0x402634A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402634B RID: 156491
		[Token(Token = "0x402634B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402634C RID: 156492
		[Token(Token = "0x402634C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
