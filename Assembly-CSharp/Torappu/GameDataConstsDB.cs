using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/GameDataConsts")]
	public class GameDataConstsDB : ConstTable<GameDataConsts, GameDataConstsDB>
	{
		// Token: 0x0600613E RID: 24894 RVA: 0x0002F9E8 File Offset: 0x0002DBE8
		[Token(Token = "0x600613E")]
		[Address(RVA = "0x1DEC9A0", Offset = "0x1DEB5A0", VA = "0x181DEC9A0")]
		public bool TryGetSubProfessionAttackType(string subProfessionId, out SubProfessionAttackType attackType)
		{
			return default(bool);
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600613F")]
		[Address(RVA = "0x1DECA70", Offset = "0x1DEB670", VA = "0x181DECA70")]
		public GameDataConstsDB()
		{
		}

		// Token: 0x04002AD5 RID: 10965
		[Token(Token = "0x4002AD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetSubProfessionAttackType;

		// Token: 0x04002AD6 RID: 10966
		[Token(Token = "0x4002AD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
