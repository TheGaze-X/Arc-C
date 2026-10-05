using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058CF RID: 22735
	[Token(Token = "0x20058CF")]
	public abstract class CrossAppShareComponentBaseModel : IHotfixable, ILuaCallCSharp
	{
		// Token: 0x0602129C RID: 135836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602129C")]
		[Address(RVA = "0x1B71BB0", Offset = "0x1B707B0", VA = "0x181B71BB0")]
		protected CrossAppShareComponentBaseModel()
		{
		}

		// Token: 0x0402D2BA RID: 185018
		[Token(Token = "0x402D2BA")]
		[FieldOffset(Offset = "0x10")]
		public bool isActive;

		// Token: 0x0402D2BB RID: 185019
		[Token(Token = "0x402D2BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
