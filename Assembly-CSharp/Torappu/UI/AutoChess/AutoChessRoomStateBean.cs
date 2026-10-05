using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062DD RID: 25309
	[Token(Token = "0x20062DD")]
	public class AutoChessRoomStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060247CB RID: 149451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247CB")]
		[Address(RVA = "0x1F4AA90", Offset = "0x1F49690", VA = "0x181F4AA90")]
		public AutoChessRoomStateBean()
		{
		}

		// Token: 0x04032D39 RID: 208185
		[Token(Token = "0x4032D39")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessRoomProperty roomProp;

		// Token: 0x04032D3A RID: 208186
		[Token(Token = "0x4032D3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
