using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013AE RID: 5038
	[Token(Token = "0x20013AE")]
	[Serializable]
	public class TipTable
	{
		// Token: 0x0600739A RID: 29594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TipTable()
		{
		}

		// Token: 0x04006FFB RID: 28667
		[Token(Token = "0x4006FFB")]
		[FieldOffset(Offset = "0x10")]
		public TipData[] tips;

		// Token: 0x04006FFC RID: 28668
		[Token(Token = "0x4006FFC")]
		[FieldOffset(Offset = "0x18")]
		public WorldViewTip[] worldViewTips;
	}
}
