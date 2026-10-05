using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A13 RID: 23059
	[Token(Token = "0x2005A13")]
	public class CrisisShopLeftCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602197D RID: 137597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602197D")]
		[Address(RVA = "0x1C07AB0", Offset = "0x1C066B0", VA = "0x181C07AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602197E RID: 137598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602197E")]
		[Address(RVA = "0x1C07600", Offset = "0x1C06200", VA = "0x181C07600")]
		public void Render(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x0602197F RID: 137599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602197F")]
		[Address(RVA = "0x1C07C60", Offset = "0x1C06860", VA = "0x181C07C60")]
		public CrisisShopLeftCharView()
		{
		}

		// Token: 0x0402DEAF RID: 188079
		[Token(Token = "0x402DEAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _portraitImg;

		// Token: 0x0402DEB0 RID: 188080
		[Token(Token = "0x402DEB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402DEB1 RID: 188081
		[Token(Token = "0x402DEB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _scaleCount;

		// Token: 0x0402DEB2 RID: 188082
		[Token(Token = "0x402DEB2")]
		[FieldOffset(Offset = "0x30")]
		private UIItemCard m_itemCard;

		// Token: 0x0402DEB3 RID: 188083
		[Token(Token = "0x402DEB3")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0402DEB4 RID: 188084
		[Token(Token = "0x402DEB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DEB5 RID: 188085
		[Token(Token = "0x402DEB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DEB6 RID: 188086
		[Token(Token = "0x402DEB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
