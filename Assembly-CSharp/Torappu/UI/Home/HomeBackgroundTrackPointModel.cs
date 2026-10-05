using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B94 RID: 19348
	[Token(Token = "0x2004B94")]
	public class HomeBackgroundTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700447C RID: 17532
		// (get) Token: 0x0601D1BE RID: 119230 RVA: 0x000AA808 File Offset: 0x000A8A08
		[Token(Token = "0x1700447C")]
		public bool isShow
		{
			[Token(Token = "0x601D1BE")]
			[Address(RVA = "0x169B470", Offset = "0x169A070", VA = "0x18169B470", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1BF RID: 119231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1BF")]
		[Address(RVA = "0x169B3A0", Offset = "0x1699FA0", VA = "0x18169B3A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1C0 RID: 119232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1C0")]
		[Address(RVA = "0x169B410", Offset = "0x169A010", VA = "0x18169B410")]
		public HomeBackgroundTrackPointModel()
		{
		}

		// Token: 0x0402633B RID: 156475
		[Token(Token = "0x402633B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0402633C RID: 156476
		[Token(Token = "0x402633C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402633D RID: 156477
		[Token(Token = "0x402633D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402633E RID: 156478
		[Token(Token = "0x402633E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
