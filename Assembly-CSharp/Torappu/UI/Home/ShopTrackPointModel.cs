using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B93 RID: 19347
	[Token(Token = "0x2004B93")]
	public class ShopTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700447B RID: 17531
		// (get) Token: 0x0601D1BB RID: 119227 RVA: 0x000AA7F0 File Offset: 0x000A89F0
		[Token(Token = "0x1700447B")]
		public bool isShow
		{
			[Token(Token = "0x601D1BB")]
			[Address(RVA = "0x16AFC50", Offset = "0x16AE850", VA = "0x1816AFC50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1BC RID: 119228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1BC")]
		[Address(RVA = "0x16AFB30", Offset = "0x16AE730", VA = "0x1816AFB30", Slot = "4")]
		public void UpdateState(object _)
		{
		}

		// Token: 0x0601D1BD RID: 119229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1BD")]
		[Address(RVA = "0x16AFBF0", Offset = "0x16AE7F0", VA = "0x1816AFBF0")]
		public ShopTrackPointModel()
		{
		}

		// Token: 0x04026337 RID: 156471
		[Token(Token = "0x4026337")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04026338 RID: 156472
		[Token(Token = "0x4026338")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026339 RID: 156473
		[Token(Token = "0x4026339")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402633A RID: 156474
		[Token(Token = "0x402633A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
