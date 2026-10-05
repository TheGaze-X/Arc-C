using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064FE RID: 25854
	[Token(Token = "0x20064FE")]
	public class AutoChessBattleShopCostView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602527C RID: 152188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602527C")]
		[Address(RVA = "0x201A160", Offset = "0x2018D60", VA = "0x18201A160")]
		public void Render(int cost, int total)
		{
		}

		// Token: 0x0602527D RID: 152189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602527D")]
		[Address(RVA = "0x201A220", Offset = "0x2018E20", VA = "0x18201A220")]
		public void SetPriceColor(Color priceClr)
		{
		}

		// Token: 0x0602527E RID: 152190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602527E")]
		[Address(RVA = "0x201A2D0", Offset = "0x2018ED0", VA = "0x18201A2D0")]
		public AutoChessBattleShopCostView()
		{
		}

		// Token: 0x04034197 RID: 213399
		[Token(Token = "0x4034197")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _enoughToggle;

		// Token: 0x04034198 RID: 213400
		[Token(Token = "0x4034198")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _costNums;

		// Token: 0x04034199 RID: 213401
		[Token(Token = "0x4034199")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _enoughNum;

		// Token: 0x0403419A RID: 213402
		[Token(Token = "0x403419A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403419B RID: 213403
		[Token(Token = "0x403419B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetPriceColor;

		// Token: 0x0403419C RID: 213404
		[Token(Token = "0x403419C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
