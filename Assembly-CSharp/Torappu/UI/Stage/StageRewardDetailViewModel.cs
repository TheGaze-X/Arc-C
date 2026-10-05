using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020068D2 RID: 26834
	[Token(Token = "0x20068D2")]
	public class StageRewardDetailViewModel : IComparable<StageRewardDetailViewModel>
	{
		// Token: 0x0602673D RID: 157501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602673D")]
		[Address(RVA = "0x2184BB0", Offset = "0x21837B0", VA = "0x182184BB0")]
		public void LoadData(StageData.DisplayDetailRewards rewardData)
		{
		}

		// Token: 0x0602673E RID: 157502 RVA: 0x000CB358 File Offset: 0x000C9558
		[Token(Token = "0x602673E")]
		[Address(RVA = "0x2184AD0", Offset = "0x21836D0", VA = "0x182184AD0", Slot = "4")]
		public int CompareTo(StageRewardDetailViewModel other)
		{
			return 0;
		}

		// Token: 0x0602673F RID: 157503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602673F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageRewardDetailViewModel()
		{
		}

		// Token: 0x040362D2 RID: 221906
		[Token(Token = "0x40362D2")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel itemModel;

		// Token: 0x040362D3 RID: 221907
		[Token(Token = "0x40362D3")]
		[FieldOffset(Offset = "0x18")]
		public OccPer occPercent;

		// Token: 0x040362D4 RID: 221908
		[Token(Token = "0x40362D4")]
		[FieldOffset(Offset = "0x1C")]
		public StageDropType dropType;
	}
}
