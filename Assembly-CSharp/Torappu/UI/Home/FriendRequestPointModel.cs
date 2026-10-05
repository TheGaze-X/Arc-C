using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B8A RID: 19338
	[Token(Token = "0x2004B8A")]
	public class FriendRequestPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004470 RID: 17520
		// (get) Token: 0x0601D197 RID: 119191 RVA: 0x000AA6E8 File Offset: 0x000A88E8
		[Token(Token = "0x17004470")]
		public bool isShow
		{
			[Token(Token = "0x601D197")]
			[Address(RVA = "0x169AAD0", Offset = "0x16996D0", VA = "0x18169AAD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D198 RID: 119192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D198")]
		[Address(RVA = "0x169A9B0", Offset = "0x16995B0", VA = "0x18169A9B0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D199 RID: 119193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D199")]
		[Address(RVA = "0x169AA70", Offset = "0x1699670", VA = "0x18169AA70")]
		public FriendRequestPointModel()
		{
		}

		// Token: 0x0402630A RID: 156426
		[Token(Token = "0x402630A")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0402630B RID: 156427
		[Token(Token = "0x402630B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402630C RID: 156428
		[Token(Token = "0x402630C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402630D RID: 156429
		[Token(Token = "0x402630D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
