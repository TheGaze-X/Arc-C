using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x020049A0 RID: 18848
	[Token(Token = "0x20049A0")]
	public class MedalGroupDisplayStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601C667 RID: 116327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C667")]
		[Address(RVA = "0x15EA630", Offset = "0x15E9230", VA = "0x1815EA630")]
		public void InitGroup(string groupId)
		{
		}

		// Token: 0x0601C668 RID: 116328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C668")]
		[Address(RVA = "0x15EA790", Offset = "0x15E9390", VA = "0x1815EA790")]
		public MedalGroupDisplayStateBean()
		{
		}

		// Token: 0x04025335 RID: 152373
		[Token(Token = "0x4025335")]
		[FieldOffset(Offset = "0x10")]
		public MedalDisplayViewModel medalDisplayViewModel;

		// Token: 0x04025336 RID: 152374
		[Token(Token = "0x4025336")]
		[FieldOffset(Offset = "0x18")]
		public MedalGroupViewModel medalGroupModel;

		// Token: 0x04025337 RID: 152375
		[Token(Token = "0x4025337")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitGroup;

		// Token: 0x04025338 RID: 152376
		[Token(Token = "0x4025338")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
