using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CD1 RID: 23761
	[Token(Token = "0x2005CD1")]
	public class ClimbTowerMenuTaticalBuffItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022666 RID: 140902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022666")]
		[Address(RVA = "0x1CD28E0", Offset = "0x1CD14E0", VA = "0x181CD28E0")]
		public void Render(ClimbTowerInnerBuffModel buffModel)
		{
		}

		// Token: 0x06022667 RID: 140903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022667")]
		[Address(RVA = "0x1CD2AE0", Offset = "0x1CD16E0", VA = "0x181CD2AE0")]
		public ClimbTowerMenuTaticalBuffItem()
		{
		}

		// Token: 0x0402F467 RID: 193639
		[Token(Token = "0x402F467")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textProfession;

		// Token: 0x0402F468 RID: 193640
		[Token(Token = "0x402F468")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402F469 RID: 193641
		[Token(Token = "0x402F469")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402F46A RID: 193642
		[Token(Token = "0x402F46A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgProfession;

		// Token: 0x0402F46B RID: 193643
		[Token(Token = "0x402F46B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _professionAtlas;

		// Token: 0x0402F46C RID: 193644
		[Token(Token = "0x402F46C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F46D RID: 193645
		[Token(Token = "0x402F46D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
