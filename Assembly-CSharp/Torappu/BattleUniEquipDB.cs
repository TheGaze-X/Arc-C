using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005AC RID: 1452
	[Token(Token = "0x20005AC")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/BattleUniEquipTable")]
	[Serializable]
	public class BattleUniEquipDB : SimpleKVTable<BattleEquipPack, BattleUniEquipDB>
	{
		// Token: 0x0600609D RID: 24733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609D")]
		[Address(RVA = "0x1CE48C0", Offset = "0x1CE34C0", VA = "0x181CE48C0")]
		public BattleUniEquipDB()
		{
		}

		// Token: 0x04002A19 RID: 10777
		[Token(Token = "0x4002A19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
