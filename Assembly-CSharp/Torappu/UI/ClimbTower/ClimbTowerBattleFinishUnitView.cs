using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DD8 RID: 24024
	[Token(Token = "0x2005DD8")]
	public class ClimbTowerBattleFinishUnitView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022CD2 RID: 142546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CD2")]
		[Address(RVA = "0x1D4FAD0", Offset = "0x1D4E6D0", VA = "0x181D4FAD0")]
		public void Render(string unitId)
		{
		}

		// Token: 0x06022CD3 RID: 142547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CD3")]
		[Address(RVA = "0x1D4FB90", Offset = "0x1D4E790", VA = "0x181D4FB90")]
		public ClimbTowerBattleFinishUnitView()
		{
		}

		// Token: 0x0402FE2F RID: 196143
		[Token(Token = "0x402FE2F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgUnit;

		// Token: 0x0402FE30 RID: 196144
		[Token(Token = "0x402FE30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FE31 RID: 196145
		[Token(Token = "0x402FE31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
