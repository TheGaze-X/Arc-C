using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200536B RID: 21355
	[Token(Token = "0x200536B")]
	public class RoguelikeGildItemSelectedView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F7B7 RID: 128951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7B7")]
		[Address(RVA = "0x1924A60", Offset = "0x1923660", VA = "0x181924A60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F7B8 RID: 128952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7B8")]
		[Address(RVA = "0x1924650", Offset = "0x1923250", VA = "0x181924650")]
		public void Render(ILoadAsset assetLoader, string topicId, string itemId, string gildId, string emptyIconId, RoguelikeCopperLuckyLevel luckyLevel)
		{
		}

		// Token: 0x0601F7B9 RID: 128953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7B9")]
		[Address(RVA = "0x1924BB0", Offset = "0x19237B0", VA = "0x181924BB0")]
		private Sprite _LoadGildIcon(ILoadAsset assetLoader, string topicId, string gildId)
		{
			return null;
		}

		// Token: 0x0601F7BA RID: 128954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7BA")]
		[Address(RVA = "0x1924CC0", Offset = "0x19238C0", VA = "0x181924CC0")]
		public RoguelikeGildItemSelectedView()
		{
		}

		// Token: 0x0402A5A2 RID: 173474
		[Token(Token = "0x402A5A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402A5A3 RID: 173475
		[Token(Token = "0x402A5A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasUnSelected;

		// Token: 0x0402A5A4 RID: 173476
		[Token(Token = "0x402A5A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgEmpty;

		// Token: 0x0402A5A5 RID: 173477
		[Token(Token = "0x402A5A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgItem;

		// Token: 0x0402A5A6 RID: 173478
		[Token(Token = "0x402A5A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgGild;

		// Token: 0x0402A5A7 RID: 173479
		[Token(Token = "0x402A5A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelGild;

		// Token: 0x0402A5A8 RID: 173480
		[Token(Token = "0x402A5A8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgLucky;

		// Token: 0x0402A5A9 RID: 173481
		[Token(Token = "0x402A5A9")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402A5AA RID: 173482
		[Token(Token = "0x402A5AA")]
		[FieldOffset(Offset = "0x58")]
		private UISwitchTween m_showTweenUnSelected;

		// Token: 0x0402A5AB RID: 173483
		[Token(Token = "0x402A5AB")]
		[FieldOffset(Offset = "0x60")]
		private UISwitchTween m_showTweenSelected;

		// Token: 0x0402A5AC RID: 173484
		[Token(Token = "0x402A5AC")]
		[FieldOffset(Offset = "0x68")]
		private string m_itemId;

		// Token: 0x0402A5AD RID: 173485
		[Token(Token = "0x402A5AD")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402A5AE RID: 173486
		[Token(Token = "0x402A5AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A5AF RID: 173487
		[Token(Token = "0x402A5AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A5B0 RID: 173488
		[Token(Token = "0x402A5B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadGildIcon;

		// Token: 0x0402A5B1 RID: 173489
		[Token(Token = "0x402A5B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
