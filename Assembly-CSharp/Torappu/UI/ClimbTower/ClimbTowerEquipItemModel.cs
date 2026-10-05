using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D81 RID: 23937
	[Token(Token = "0x2005D81")]
	public class ClimbTowerEquipItemModel : IComparable<ClimbTowerEquipItemModel>
	{
		// Token: 0x06022B1B RID: 142107 RVA: 0x000BE770 File Offset: 0x000BC970
		[Token(Token = "0x6022B1B")]
		[Address(RVA = "0x1D32570", Offset = "0x1D31170", VA = "0x181D32570", Slot = "4")]
		public int CompareTo(ClimbTowerEquipItemModel other)
		{
			return 0;
		}

		// Token: 0x06022B1C RID: 142108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B1C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerEquipItemModel()
		{
		}

		// Token: 0x0402FB21 RID: 195361
		[Token(Token = "0x402FB21")]
		[FieldOffset(Offset = "0x10")]
		public UniEquipData equipData;

		// Token: 0x0402FB22 RID: 195362
		[Token(Token = "0x402FB22")]
		[FieldOffset(Offset = "0x18")]
		public int equipLv;

		// Token: 0x0402FB23 RID: 195363
		[Token(Token = "0x402FB23")]
		[FieldOffset(Offset = "0x1C")]
		public bool isAvail;

		// Token: 0x0402FB24 RID: 195364
		[Token(Token = "0x402FB24")]
		[FieldOffset(Offset = "0x20")]
		public Sprite equipIcon;
	}
}
