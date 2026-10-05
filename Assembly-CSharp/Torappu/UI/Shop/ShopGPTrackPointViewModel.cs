using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE0 RID: 23264
	[Token(Token = "0x2005AE0")]
	public class ShopGPTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004F25 RID: 20261
		// (get) Token: 0x06021D17 RID: 138519 RVA: 0x000BB500 File Offset: 0x000B9700
		[Token(Token = "0x17004F25")]
		public bool isShow
		{
			[Token(Token = "0x6021D17")]
			[Address(RVA = "0x1C557F0", Offset = "0x1C543F0", VA = "0x181C557F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06021D18 RID: 138520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D18")]
		[Address(RVA = "0x1C556E0", Offset = "0x1C542E0", VA = "0x181C556E0", Slot = "4")]
		public void UpdateState(object permitShowBool)
		{
		}

		// Token: 0x06021D19 RID: 138521 RVA: 0x000BB518 File Offset: 0x000B9718
		[Token(Token = "0x6021D19")]
		[Address(RVA = "0x1C55650", Offset = "0x1C54250", VA = "0x181C55650")]
		public static bool CheckIfShowTrackPoint()
		{
			return default(bool);
		}

		// Token: 0x06021D1A RID: 138522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D1A")]
		[Address(RVA = "0x1C55790", Offset = "0x1C54390", VA = "0x181C55790")]
		public ShopGPTrackPointViewModel()
		{
		}

		// Token: 0x0402E4D0 RID: 189648
		[Token(Token = "0x402E4D0")]
		[FieldOffset(Offset = "0x10")]
		private bool m_permitShow;

		// Token: 0x0402E4D1 RID: 189649
		[Token(Token = "0x402E4D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402E4D2 RID: 189650
		[Token(Token = "0x402E4D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402E4D3 RID: 189651
		[Token(Token = "0x402E4D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIfShowTrackPoint;

		// Token: 0x0402E4D4 RID: 189652
		[Token(Token = "0x402E4D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
