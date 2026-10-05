using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005820 RID: 22560
	[Token(Token = "0x2005820")]
	public class RL03TotemItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004D5E RID: 19806
		// (get) Token: 0x06020F76 RID: 135030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D5E")]
		public UIColorGraphic graphic
		{
			[Token(Token = "0x6020F76")]
			[Address(RVA = "0x1B56F20", Offset = "0x1B55B20", VA = "0x181B56F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020F77 RID: 135031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F77")]
		[Address(RVA = "0x1B56D80", Offset = "0x1B55980", VA = "0x181B56D80")]
		public void Render(ILoadAsset assetLoader, RL03TotemViewModel totemViewModel, float itemScale = 1f)
		{
		}

		// Token: 0x06020F78 RID: 135032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F78")]
		[Address(RVA = "0x1B56EC0", Offset = "0x1B55AC0", VA = "0x181B56EC0")]
		public RL03TotemItemView()
		{
		}

		// Token: 0x0402CD38 RID: 183608
		[Token(Token = "0x402CD38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x0402CD39 RID: 183609
		[Token(Token = "0x402CD39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402CD3A RID: 183610
		[Token(Token = "0x402CD3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _locationTag;

		// Token: 0x0402CD3B RID: 183611
		[Token(Token = "0x402CD3B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _effectTag;

		// Token: 0x0402CD3C RID: 183612
		[Token(Token = "0x402CD3C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0402CD3D RID: 183613
		[Token(Token = "0x402CD3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402CD3E RID: 183614
		[Token(Token = "0x402CD3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CD3F RID: 183615
		[Token(Token = "0x402CD3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
