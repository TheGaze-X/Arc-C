using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063A7 RID: 25511
	[Token(Token = "0x20063A7")]
	public class AutoChessStageInfoBondGroupModel : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x06024C76 RID: 150646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C76")]
		[Address(RVA = "0x1FA4FC0", Offset = "0x1FA3BC0", VA = "0x181FA4FC0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C77 RID: 150647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C77")]
		[Address(RVA = "0x1FA5030", Offset = "0x1FA3C30", VA = "0x181FA5030")]
		public AutoChessStageInfoBondGroupModel()
		{
		}

		// Token: 0x04033666 RID: 210534
		[Token(Token = "0x4033666")]
		public const string VIEW_TYPE = "BOND";

		// Token: 0x04033667 RID: 210535
		[Token(Token = "0x4033667")]
		[FieldOffset(Offset = "0x10")]
		public bool isFirst;

		// Token: 0x04033668 RID: 210536
		[Token(Token = "0x4033668")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessStageInfoBondViewModel> bondList;

		// Token: 0x04033669 RID: 210537
		[Token(Token = "0x4033669")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403366A RID: 210538
		[Token(Token = "0x403366A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
