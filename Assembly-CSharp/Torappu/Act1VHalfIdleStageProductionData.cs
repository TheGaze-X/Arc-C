using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C93 RID: 3219
	[Token(Token = "0x2000C93")]
	public class Act1VHalfIdleStageProductionData
	{
		// Token: 0x0600696F RID: 26991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600696F")]
		[Address(RVA = "0x1FF3FC0", Offset = "0x1FF2BC0", VA = "0x181FF3FC0")]
		public Act1VHalfIdleStageProductionData()
		{
		}

		// Token: 0x040041BB RID: 16827
		[Token(Token = "0x40041BB")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x040041BC RID: 16828
		[Token(Token = "0x40041BC")]
		[FieldOffset(Offset = "0x18")]
		public List<string> fixedProduction;

		// Token: 0x040041BD RID: 16829
		[Token(Token = "0x40041BD")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act1VHalfIdleStageProductionData.ItemProductionData> productionData;

		// Token: 0x02000C94 RID: 3220
		[Token(Token = "0x2000C94")]
		public class ItemProductionData
		{
			// Token: 0x06006970 RID: 26992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006970")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemProductionData()
			{
			}

			// Token: 0x040041BE RID: 16830
			[Token(Token = "0x40041BE")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x040041BF RID: 16831
			[Token(Token = "0x40041BF")]
			[FieldOffset(Offset = "0x18")]
			public int efficiencyMax;

			// Token: 0x040041C0 RID: 16832
			[Token(Token = "0x40041C0")]
			[FieldOffset(Offset = "0x1C")]
			public bool isFixed;

			// Token: 0x040041C1 RID: 16833
			[Token(Token = "0x40041C1")]
			[FieldOffset(Offset = "0x20")]
			public int maxDropValue;
		}
	}
}
