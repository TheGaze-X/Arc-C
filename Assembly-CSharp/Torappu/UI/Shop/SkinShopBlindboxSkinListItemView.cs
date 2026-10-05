using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A6A RID: 23146
	[Token(Token = "0x2005A6A")]
	public class SkinShopBlindboxSkinListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021ADF RID: 137951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ADF")]
		[Address(RVA = "0x1C29500", Offset = "0x1C28100", VA = "0x181C29500")]
		public void Render(SkinShopBlindboxSkinListItemViewModel itemViewModel)
		{
		}

		// Token: 0x06021AE0 RID: 137952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AE0")]
		[Address(RVA = "0x1C297F0", Offset = "0x1C283F0", VA = "0x181C297F0")]
		private void _LoadObtainPart(SkinShopBlindboxSkinListItemViewModel item)
		{
		}

		// Token: 0x06021AE1 RID: 137953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AE1")]
		[Address(RVA = "0x1C29420", Offset = "0x1C28020", VA = "0x181C29420")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06021AE2 RID: 137954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AE2")]
		[Address(RVA = "0x1C298D0", Offset = "0x1C284D0", VA = "0x181C298D0")]
		public SkinShopBlindboxSkinListItemView()
		{
		}

		// Token: 0x0402E0C2 RID: 188610
		[Token(Token = "0x402E0C2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _checkObj;

		// Token: 0x0402E0C3 RID: 188611
		[Token(Token = "0x402E0C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgPortrait;

		// Token: 0x0402E0C4 RID: 188612
		[Token(Token = "0x402E0C4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _skinName;

		// Token: 0x0402E0C5 RID: 188613
		[Token(Token = "0x402E0C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0402E0C6 RID: 188614
		[Token(Token = "0x402E0C6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _obtainByShop;

		// Token: 0x0402E0C7 RID: 188615
		[Token(Token = "0x402E0C7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _obtainByActivity;

		// Token: 0x0402E0C8 RID: 188616
		[Token(Token = "0x402E0C8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0402E0C9 RID: 188617
		[Token(Token = "0x402E0C9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _achievedObj;

		// Token: 0x0402E0CA RID: 188618
		[Token(Token = "0x402E0CA")]
		[FieldOffset(Offset = "0x58")]
		private string m_currentSkinId;

		// Token: 0x0402E0CB RID: 188619
		[Token(Token = "0x402E0CB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isButtonEnabled;

		// Token: 0x0402E0CC RID: 188620
		[Token(Token = "0x402E0CC")]
		[FieldOffset(Offset = "0x68")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402E0CD RID: 188621
		[Token(Token = "0x402E0CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E0CE RID: 188622
		[Token(Token = "0x402E0CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadObtainPart;

		// Token: 0x0402E0CF RID: 188623
		[Token(Token = "0x402E0CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0402E0D0 RID: 188624
		[Token(Token = "0x402E0D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
