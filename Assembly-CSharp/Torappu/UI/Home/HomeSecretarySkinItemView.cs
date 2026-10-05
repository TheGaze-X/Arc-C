using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C1F RID: 19487
	[Token(Token = "0x2004C1F")]
	public class HomeSecretarySkinItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D442 RID: 119874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D442")]
		[Address(RVA = "0x16D7D60", Offset = "0x16D6960", VA = "0x1816D7D60")]
		public void ApplyData(HomeSecretarySkinItemModel model, bool isSelected, bool isInPreview)
		{
		}

		// Token: 0x0601D443 RID: 119875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D443")]
		[Address(RVA = "0x16D7ED0", Offset = "0x16D6AD0", VA = "0x1816D7ED0")]
		public void OnClick()
		{
		}

		// Token: 0x0601D444 RID: 119876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D444")]
		[Address(RVA = "0x16D7FB0", Offset = "0x16D6BB0", VA = "0x1816D7FB0")]
		public HomeSecretarySkinItemView()
		{
		}

		// Token: 0x040267B6 RID: 157622
		[Token(Token = "0x40267B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _headIcon;

		// Token: 0x040267B7 RID: 157623
		[Token(Token = "0x40267B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objNotSelected;

		// Token: 0x040267B8 RID: 157624
		[Token(Token = "0x40267B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _objListSelected;

		// Token: 0x040267B9 RID: 157625
		[Token(Token = "0x40267B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objInPreview;

		// Token: 0x040267BA RID: 157626
		[Token(Token = "0x40267BA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objSpDynIllust;

		// Token: 0x040267BB RID: 157627
		[Token(Token = "0x40267BB")]
		[FieldOffset(Offset = "0x40")]
		private string m_skinTag;

		// Token: 0x040267BC RID: 157628
		[Token(Token = "0x40267BC")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040267BD RID: 157629
		[Token(Token = "0x40267BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x040267BE RID: 157630
		[Token(Token = "0x40267BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040267BF RID: 157631
		[Token(Token = "0x40267BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
