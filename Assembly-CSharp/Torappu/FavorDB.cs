using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/FavorData")]
	public class FavorDB : ConstTable<FavorTable, FavorDB>
	{
		// Token: 0x06006122 RID: 24866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006122")]
		[Address(RVA = "0x1DEB6C0", Offset = "0x1DEA2C0", VA = "0x181DEB6C0")]
		public FavorData GetFavorData(int favorPoint)
		{
			return null;
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x0002F970 File Offset: 0x0002DB70
		[Token(Token = "0x6006123")]
		[Address(RVA = "0x1DEB5A0", Offset = "0x1DEA1A0", VA = "0x181DEB5A0")]
		public int GetFavorBattlePhase(int favorPoint)
		{
			return 0;
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x0002F988 File Offset: 0x0002DB88
		[Token(Token = "0x6006124")]
		[Address(RVA = "0x1DEB230", Offset = "0x1DE9E30", VA = "0x181DEB230")]
		public int CalculateFavorPointByBattlePhaseRoughly(int favorBattlePhase)
		{
			return 0;
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006125")]
		[Address(RVA = "0x1DEB780", Offset = "0x1DEA380", VA = "0x181DEB780")]
		public FavorDB()
		{
		}

		// Token: 0x04002AB4 RID: 10932
		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFavorData;

		// Token: 0x04002AB5 RID: 10933
		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetFavorBattlePhase;

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalculateFavorPointByBattlePhaseRoughly;

		// Token: 0x04002AB7 RID: 10935
		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
