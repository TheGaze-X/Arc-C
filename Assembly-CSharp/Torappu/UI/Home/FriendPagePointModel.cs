using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B8D RID: 19341
	[Token(Token = "0x2004B8D")]
	public class FriendPagePointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004473 RID: 17523
		// (get) Token: 0x0601D1A0 RID: 119200 RVA: 0x000AA730 File Offset: 0x000A8930
		[Token(Token = "0x17004473")]
		public bool isShow
		{
			[Token(Token = "0x601D1A0")]
			[Address(RVA = "0x169A950", Offset = "0x1699550", VA = "0x18169A950", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1A1 RID: 119201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1A1")]
		[Address(RVA = "0x169A6E0", Offset = "0x16992E0", VA = "0x18169A6E0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1A2 RID: 119202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1A2")]
		[Address(RVA = "0x169A8F0", Offset = "0x16994F0", VA = "0x18169A8F0")]
		public FriendPagePointModel()
		{
		}

		// Token: 0x04026316 RID: 156438
		[Token(Token = "0x4026316")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04026317 RID: 156439
		[Token(Token = "0x4026317")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026318 RID: 156440
		[Token(Token = "0x4026318")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026319 RID: 156441
		[Token(Token = "0x4026319")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
