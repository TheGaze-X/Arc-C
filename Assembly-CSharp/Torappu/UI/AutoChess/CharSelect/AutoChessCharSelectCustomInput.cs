using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063CC RID: 25548
	[Token(Token = "0x20063CC")]
	public class AutoChessCharSelectCustomInput : TemplateCharSelectController.TemplateCustomInput
	{
		// Token: 0x06024D63 RID: 150883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D63")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public AutoChessCharSelectCustomInput()
		{
		}

		// Token: 0x04033808 RID: 210952
		[Token(Token = "0x4033808")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessData.ActAutoChessCharShopChessData chessData;
	}
}
