using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using Torappu.UI.Roguelike.RL05;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200536E RID: 21358
	[Token(Token = "0x200536E")]
	public class RoguelikeGildListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F7C1 RID: 128961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7C1")]
		[Address(RVA = "0x1925470", Offset = "0x1924070", VA = "0x181925470")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F7C2 RID: 128962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7C2")]
		[Address(RVA = "0x1925180", Offset = "0x1923D80", VA = "0x181925180")]
		public void Render(RoguelikePlayerCopperItemViewModel model, bool isSelected)
		{
		}

		// Token: 0x0601F7C3 RID: 128963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7C3")]
		[Address(RVA = "0x19250B0", Offset = "0x1923CB0", VA = "0x1819250B0")]
		public void OnClicked()
		{
		}

		// Token: 0x0601F7C4 RID: 128964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7C4")]
		[Address(RVA = "0x1925610", Offset = "0x1924210", VA = "0x181925610")]
		public RoguelikeGildListItem()
		{
		}

		// Token: 0x0402A5BA RID: 173498
		[Token(Token = "0x402A5BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402A5BB RID: 173499
		[Token(Token = "0x402A5BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _itemIconHolder;

		// Token: 0x0402A5BC RID: 173500
		[Token(Token = "0x402A5BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL05CopperItemView _itemIconPrefab;

		// Token: 0x0402A5BD RID: 173501
		[Token(Token = "0x402A5BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemIconScale;

		// Token: 0x0402A5BE RID: 173502
		[Token(Token = "0x402A5BE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402A5BF RID: 173503
		[Token(Token = "0x402A5BF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _drawnPanel;

		// Token: 0x0402A5C0 RID: 173504
		[Token(Token = "0x402A5C0")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInit;

		// Token: 0x0402A5C1 RID: 173505
		[Token(Token = "0x402A5C1")]
		[FieldOffset(Offset = "0x50")]
		private UISwitchTween m_selectedTween;

		// Token: 0x0402A5C2 RID: 173506
		[Token(Token = "0x402A5C2")]
		[FieldOffset(Offset = "0x58")]
		private RL05CopperItemView m_itemIcon;

		// Token: 0x0402A5C3 RID: 173507
		[Token(Token = "0x402A5C3")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedId;

		// Token: 0x0402A5C4 RID: 173508
		[Token(Token = "0x402A5C4")]
		[FieldOffset(Offset = "0x68")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402A5C5 RID: 173509
		[Token(Token = "0x402A5C5")]
		[FieldOffset(Offset = "0x78")]
		private ILoadAsset m_assetLoader;

		// Token: 0x0402A5C6 RID: 173510
		[Token(Token = "0x402A5C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A5C7 RID: 173511
		[Token(Token = "0x402A5C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A5C8 RID: 173512
		[Token(Token = "0x402A5C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0402A5C9 RID: 173513
		[Token(Token = "0x402A5C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
