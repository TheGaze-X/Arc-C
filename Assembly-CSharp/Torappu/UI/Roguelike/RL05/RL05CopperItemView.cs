using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005584 RID: 21892
	[Token(Token = "0x2005584")]
	public class RL05CopperItemView : RoguelikeAbstractCopperItemCard
	{
		// Token: 0x17004B75 RID: 19317
		// (get) Token: 0x0602029F RID: 131743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B75")]
		public override UIColorGraphic graphic
		{
			[Token(Token = "0x602029F")]
			[Address(RVA = "0x1A4A9B0", Offset = "0x1A495B0", VA = "0x181A4A9B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060202A0 RID: 131744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202A0")]
		[Address(RVA = "0x1A4A6C0", Offset = "0x1A492C0", VA = "0x181A4A6C0", Slot = "5")]
		public override void Render(ILoadAsset assetLoader, IRoguelikeCopperItemModel model, float itemScale = 1f, bool showGildIcon = true, bool showLuckyIcon = false)
		{
		}

		// Token: 0x060202A1 RID: 131745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202A1")]
		[Address(RVA = "0x1A4A950", Offset = "0x1A49550", VA = "0x181A4A950")]
		public RL05CopperItemView()
		{
		}

		// Token: 0x0402B73D RID: 177981
		[Token(Token = "0x402B73D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x0402B73E RID: 177982
		[Token(Token = "0x402B73E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402B73F RID: 177983
		[Token(Token = "0x402B73F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _gildIcon;

		// Token: 0x0402B740 RID: 177984
		[Token(Token = "0x402B740")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIColorGraphic _graphic;

		// Token: 0x0402B741 RID: 177985
		[Token(Token = "0x402B741")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageLuckyIcon;

		// Token: 0x0402B742 RID: 177986
		[Token(Token = "0x402B742")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402B743 RID: 177987
		[Token(Token = "0x402B743")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B744 RID: 177988
		[Token(Token = "0x402B744")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
