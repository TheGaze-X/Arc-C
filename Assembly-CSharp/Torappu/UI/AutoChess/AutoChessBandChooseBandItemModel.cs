using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200629A RID: 25242
	[Token(Token = "0x200629A")]
	public class AutoChessBandChooseBandItemModel : IComparable, IHotfixable
	{
		// Token: 0x06024652 RID: 149074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024652")]
		[Address(RVA = "0x1F23220", Offset = "0x1F21E20", VA = "0x181F23220")]
		public static AutoChessBandChooseBandItemModel Create(AutoChessData.AutoChessBandData bandInfo, ActAutoChessData.ActAutoChessBandData actBandInfo, PlayerActivity.PlayerActAutoChessActivity.BandElem playerBand)
		{
			return null;
		}

		// Token: 0x06024653 RID: 149075 RVA: 0x000C4158 File Offset: 0x000C2358
		[Token(Token = "0x6024653")]
		[Address(RVA = "0x1F23120", Offset = "0x1F21D20", VA = "0x181F23120", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06024654 RID: 149076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024654")]
		[Address(RVA = "0x1F233E0", Offset = "0x1F21FE0", VA = "0x181F233E0")]
		public AutoChessBandChooseBandItemModel()
		{
		}

		// Token: 0x04032A27 RID: 207399
		[Token(Token = "0x4032A27")]
		[FieldOffset(Offset = "0x10")]
		public string bandId;

		// Token: 0x04032A28 RID: 207400
		[Token(Token = "0x4032A28")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04032A29 RID: 207401
		[Token(Token = "0x4032A29")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04032A2A RID: 207402
		[Token(Token = "0x4032A2A")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x04032A2B RID: 207403
		[Token(Token = "0x4032A2B")]
		[FieldOffset(Offset = "0x30")]
		public int totalHp;

		// Token: 0x04032A2C RID: 207404
		[Token(Token = "0x4032A2C")]
		[FieldOffset(Offset = "0x34")]
		public bool isNew;

		// Token: 0x04032A2D RID: 207405
		[Token(Token = "0x4032A2D")]
		[FieldOffset(Offset = "0x35")]
		public bool isFirst;

		// Token: 0x04032A2E RID: 207406
		[Token(Token = "0x4032A2E")]
		[FieldOffset(Offset = "0x36")]
		public bool isOtherSelected;

		// Token: 0x04032A2F RID: 207407
		[Token(Token = "0x4032A2F")]
		[FieldOffset(Offset = "0x38")]
		public int completeTimes;

		// Token: 0x04032A30 RID: 207408
		[Token(Token = "0x4032A30")]
		[FieldOffset(Offset = "0x3C")]
		public bool showVictorIcon;

		// Token: 0x04032A31 RID: 207409
		[Token(Token = "0x4032A31")]
		[FieldOffset(Offset = "0x40")]
		private int m_sortId;

		// Token: 0x04032A32 RID: 207410
		[Token(Token = "0x4032A32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04032A33 RID: 207411
		[Token(Token = "0x4032A33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04032A34 RID: 207412
		[Token(Token = "0x4032A34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
