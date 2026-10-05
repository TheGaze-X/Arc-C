using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064F7 RID: 25847
	[Token(Token = "0x20064F7")]
	public class AutoChessBattleShopBondView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602523B RID: 152123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602523B")]
		[Address(RVA = "0x2015950", Offset = "0x2014550", VA = "0x182015950")]
		public void RenderView(ILoadAsset assetLoader, AutoChessBattleShopBondViewModel model)
		{
		}

		// Token: 0x0602523C RID: 152124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602523C")]
		[Address(RVA = "0x2015A90", Offset = "0x2014690", VA = "0x182015A90")]
		public AutoChessBattleShopBondView()
		{
		}

		// Token: 0x0403411F RID: 213279
		[Token(Token = "0x403411F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04034120 RID: 213280
		[Token(Token = "0x4034120")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x04034121 RID: 213281
		[Token(Token = "0x4034121")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04034122 RID: 213282
		[Token(Token = "0x4034122")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
