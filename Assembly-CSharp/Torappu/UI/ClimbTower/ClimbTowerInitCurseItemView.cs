using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D42 RID: 23874
	[Token(Token = "0x2005D42")]
	public class ClimbTowerInitCurseItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022925 RID: 141605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022925")]
		[Address(RVA = "0x1D19020", Offset = "0x1D17C20", VA = "0x181D19020")]
		public void Render(ClimbTowerCurseCardModel curseCardModel)
		{
		}

		// Token: 0x06022926 RID: 141606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022926")]
		[Address(RVA = "0x1D19280", Offset = "0x1D17E80", VA = "0x181D19280")]
		public ClimbTowerInitCurseItemView()
		{
		}

		// Token: 0x0402F849 RID: 194633
		[Token(Token = "0x402F849")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402F84A RID: 194634
		[Token(Token = "0x402F84A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402F84B RID: 194635
		[Token(Token = "0x402F84B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F84C RID: 194636
		[Token(Token = "0x402F84C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F84D RID: 194637
		[Token(Token = "0x402F84D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
