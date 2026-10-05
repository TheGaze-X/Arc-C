using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B8B RID: 19339
	[Token(Token = "0x2004B8B")]
	public class FriendListPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004471 RID: 17521
		// (get) Token: 0x0601D19A RID: 119194 RVA: 0x000AA700 File Offset: 0x000A8900
		[Token(Token = "0x17004471")]
		public bool isShow
		{
			[Token(Token = "0x601D19A")]
			[Address(RVA = "0x169A680", Offset = "0x1699280", VA = "0x18169A680", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D19B RID: 119195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D19B")]
		[Address(RVA = "0x169A5B0", Offset = "0x16991B0", VA = "0x18169A5B0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D19C RID: 119196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D19C")]
		[Address(RVA = "0x169A620", Offset = "0x1699220", VA = "0x18169A620")]
		public FriendListPointModel()
		{
		}

		// Token: 0x0402630E RID: 156430
		[Token(Token = "0x402630E")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0402630F RID: 156431
		[Token(Token = "0x402630F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026310 RID: 156432
		[Token(Token = "0x4026310")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026311 RID: 156433
		[Token(Token = "0x4026311")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
