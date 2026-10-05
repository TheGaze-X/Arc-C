using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B7C RID: 23420
	[Token(Token = "0x2005B7C")]
	public class SocialUnlockUIItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021FE6 RID: 139238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FE6")]
		[Address(RVA = "0x1C83830", Offset = "0x1C82430", VA = "0x181C83830")]
		public void ApplyData(UIItemViewModel uiItemViewModel, bool isGet)
		{
		}

		// Token: 0x06021FE7 RID: 139239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FE7")]
		[Address(RVA = "0x1C83A80", Offset = "0x1C82680", VA = "0x181C83A80")]
		public SocialUnlockUIItemView()
		{
		}

		// Token: 0x0402E994 RID: 190868
		[Token(Token = "0x402E994")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0402E995 RID: 190869
		[Token(Token = "0x402E995")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402E996 RID: 190870
		[Token(Token = "0x402E996")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402E997 RID: 190871
		[Token(Token = "0x402E997")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x0402E998 RID: 190872
		[Token(Token = "0x402E998")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402E999 RID: 190873
		[Token(Token = "0x402E999")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E99A RID: 190874
		[Token(Token = "0x402E99A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
