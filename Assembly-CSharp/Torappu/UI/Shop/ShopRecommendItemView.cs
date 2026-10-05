using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B26 RID: 23334
	[Token(Token = "0x2005B26")]
	[RequireComponent(typeof(Image))]
	public class ShopRecommendItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021E1C RID: 138780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E1C")]
		[Address(RVA = "0x1C64F80", Offset = "0x1C63B80", VA = "0x181C64F80")]
		public void Render(Sprite imageSprite, bool isLocked)
		{
		}

		// Token: 0x06021E1D RID: 138781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E1D")]
		[Address(RVA = "0x1C65210", Offset = "0x1C63E10", VA = "0x181C65210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021E1E RID: 138782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E1E")]
		[Address(RVA = "0x1C65310", Offset = "0x1C63F10", VA = "0x181C65310")]
		public ShopRecommendItemView()
		{
		}

		// Token: 0x0402E6BF RID: 190143
		[Token(Token = "0x402E6BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x0402E6C0 RID: 190144
		[Token(Token = "0x402E6C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _lockMaskAlpha;

		// Token: 0x0402E6C1 RID: 190145
		[Token(Token = "0x402E6C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedObj;

		// Token: 0x0402E6C2 RID: 190146
		[Token(Token = "0x402E6C2")]
		[FieldOffset(Offset = "0x30")]
		private Image m_image;

		// Token: 0x0402E6C3 RID: 190147
		[Token(Token = "0x402E6C3")]
		[FieldOffset(Offset = "0x38")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0402E6C4 RID: 190148
		[Token(Token = "0x402E6C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E6C5 RID: 190149
		[Token(Token = "0x402E6C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E6C6 RID: 190150
		[Token(Token = "0x402E6C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
