using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002277 RID: 8823
	[Token(Token = "0x2002277")]
	public class RandomTileWithCertainKeyGlobalBuff : RandomTileGlobalBuff
	{
		// Token: 0x0600DDE7 RID: 56807 RVA: 0x00050E80 File Offset: 0x0004F080
		[Token(Token = "0x600DDE7")]
		[Address(RVA = "0x363DAB0", Offset = "0x363C6B0", VA = "0x18363DAB0", Slot = "20")]
		protected override bool FilterTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600DDE8 RID: 56808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDE8")]
		[Address(RVA = "0x363DBF0", Offset = "0x363C7F0", VA = "0x18363DBF0")]
		public RandomTileWithCertainKeyGlobalBuff()
		{
		}

		// Token: 0x0600DDE9 RID: 56809 RVA: 0x00050E98 File Offset: 0x0004F098
		[Token(Token = "0x600DDE9")]
		[Address(RVA = "0x363CC00", Offset = "0x363B800", VA = "0x18363CC00")]
		private bool <>xLuaBaseProxy_FilterTile(Tile P0)
		{
			return default(bool);
		}

		// Token: 0x0400F0AA RID: 61610
		[Token(Token = "0x400F0AA")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private string[] tileKeys;

		// Token: 0x0400F0AB RID: 61611
		[Token(Token = "0x400F0AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FilterTile;

		// Token: 0x0400F0AC RID: 61612
		[Token(Token = "0x400F0AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
