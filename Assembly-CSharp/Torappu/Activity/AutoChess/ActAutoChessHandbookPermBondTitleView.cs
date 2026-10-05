using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200711B RID: 28955
	[Token(Token = "0x200711B")]
	public class ActAutoChessHandbookPermBondTitleView : UISimpleRecycleLayoutItemView<ActAutoChessHandbookPermBondTitleModel>, IHotfixable
	{
		// Token: 0x0602921D RID: 168477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602921D")]
		[Address(RVA = "0x2485AA0", Offset = "0x24846A0", VA = "0x182485AA0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x0602921E RID: 168478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602921E")]
		[Address(RVA = "0x2485B10", Offset = "0x2484710", VA = "0x182485B10")]
		public ActAutoChessHandbookPermBondTitleView()
		{
		}

		// Token: 0x0403ABC9 RID: 240585
		[Token(Token = "0x403ABC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403ABCA RID: 240586
		[Token(Token = "0x403ABCA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
