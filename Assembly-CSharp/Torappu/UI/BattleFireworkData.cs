using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036B8 RID: 14008
	[Token(Token = "0x20036B8")]
	[Serializable]
	public class BattleFireworkData
	{
		// Token: 0x06016417 RID: 91159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016417")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleFireworkData()
		{
		}

		// Token: 0x0401AC38 RID: 109624
		[Token(Token = "0x401AC38")]
		[FieldOffset(Offset = "0x10")]
		public string animalId;

		// Token: 0x0401AC39 RID: 109625
		[Token(Token = "0x401AC39")]
		[FieldOffset(Offset = "0x18")]
		public List<FireworkData.PlateSlotData> slotDataList;
	}
}
