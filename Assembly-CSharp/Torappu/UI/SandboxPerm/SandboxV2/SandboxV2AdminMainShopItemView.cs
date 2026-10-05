using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040E0 RID: 16608
	[Token(Token = "0x20040E0")]
	public class SandboxV2AdminMainShopItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x06019B03 RID: 105219 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019B04 RID: 105220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D47")]
		public UIPage page
		{
			[Token(Token = "0x6019B03")]
			[Address(RVA = "0x1284560", Offset = "0x1283160", VA = "0x181284560")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019B04")]
			[Address(RVA = "0x1284640", Offset = "0x1283240", VA = "0x181284640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x06019B05 RID: 105221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019B06 RID: 105222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D48")]
		public Action<int> onItemClicked
		{
			[Token(Token = "0x6019B05")]
			[Address(RVA = "0x1284500", Offset = "0x1283100", VA = "0x181284500")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019B06")]
			[Address(RVA = "0x12845C0", Offset = "0x12831C0", VA = "0x1812845C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019B07 RID: 105223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B07")]
		[Address(RVA = "0x1283E80", Offset = "0x1282A80", VA = "0x181283E80")]
		public void Render(SandboxV2AdminMainShopItemViewModel model)
		{
		}

		// Token: 0x06019B08 RID: 105224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B08")]
		[Address(RVA = "0x1283D70", Offset = "0x1282970", VA = "0x181283D70")]
		public void OnItemClicked()
		{
		}

		// Token: 0x06019B09 RID: 105225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B09")]
		[Address(RVA = "0x12844A0", Offset = "0x12830A0", VA = "0x1812844A0")]
		public SandboxV2AdminMainShopItemView()
		{
		}

		// Token: 0x0402020A RID: 131594
		[Token(Token = "0x402020A")]
		private const float ALPHA_SOLD_OUT = 0.3f;

		// Token: 0x0402020B RID: 131595
		[Token(Token = "0x402020B")]
		private const float ALPHA_NORMAL = 1f;

		// Token: 0x0402020C RID: 131596
		[Token(Token = "0x402020C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _panelSoldout;

		// Token: 0x0402020D RID: 131597
		[Token(Token = "0x402020D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _panelNormal;

		// Token: 0x0402020E RID: 131598
		[Token(Token = "0x402020E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402020F RID: 131599
		[Token(Token = "0x402020F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelCount;

		// Token: 0x04020210 RID: 131600
		[Token(Token = "0x4020210")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04020211 RID: 131601
		[Token(Token = "0x4020211")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04020212 RID: 131602
		[Token(Token = "0x4020212")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasItemIcon;

		// Token: 0x04020213 RID: 131603
		[Token(Token = "0x4020213")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textStock;

		// Token: 0x04020214 RID: 131604
		[Token(Token = "0x4020214")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelGold;

		// Token: 0x04020215 RID: 131605
		[Token(Token = "0x4020215")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelDimensionCoin;

		// Token: 0x04020216 RID: 131606
		[Token(Token = "0x4020216")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textCurrentPrice;

		// Token: 0x04020217 RID: 131607
		[Token(Token = "0x4020217")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textOriginPrice;

		// Token: 0x04020218 RID: 131608
		[Token(Token = "0x4020218")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelDiscount;

		// Token: 0x04020219 RID: 131609
		[Token(Token = "0x4020219")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgGold;

		// Token: 0x0402021A RID: 131610
		[Token(Token = "0x402021A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgDimensionCoin;

		// Token: 0x0402021B RID: 131611
		[Token(Token = "0x402021B")]
		[FieldOffset(Offset = "0x90")]
		private int m_cachedIndex;

		// Token: 0x0402021E RID: 131614
		[Token(Token = "0x402021E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402021F RID: 131615
		[Token(Token = "0x402021F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04020220 RID: 131616
		[Token(Token = "0x4020220")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x04020221 RID: 131617
		[Token(Token = "0x4020221")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x04020222 RID: 131618
		[Token(Token = "0x4020222")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020223 RID: 131619
		[Token(Token = "0x4020223")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnItemClicked;

		// Token: 0x04020224 RID: 131620
		[Token(Token = "0x4020224")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
