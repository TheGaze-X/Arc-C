using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F3F RID: 16191
	[Token(Token = "0x2003F3F")]
	public class SiracusaOperaRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019250 RID: 102992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019250")]
		[Address(RVA = "0x11DD550", Offset = "0x11DC150", VA = "0x1811DD550")]
		public void Render(SiracusaOperaRewardViewModel itemData, UIPage page)
		{
		}

		// Token: 0x06019251 RID: 102993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019251")]
		[Address(RVA = "0x11DD7C0", Offset = "0x11DC3C0", VA = "0x1811DD7C0")]
		private void _LoadIconSprite(string itemIconId, string charCardId, UIPage page)
		{
		}

		// Token: 0x06019252 RID: 102994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019252")]
		[Address(RVA = "0x11DD8A0", Offset = "0x11DC4A0", VA = "0x1811DD8A0")]
		public SiracusaOperaRewardView()
		{
		}

		// Token: 0x0401F263 RID: 127587
		[Token(Token = "0x401F263")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0401F264 RID: 127588
		[Token(Token = "0x401F264")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0401F265 RID: 127589
		[Token(Token = "0x401F265")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _itemImage;

		// Token: 0x0401F266 RID: 127590
		[Token(Token = "0x401F266")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _charImage;

		// Token: 0x0401F267 RID: 127591
		[Token(Token = "0x401F267")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _closeText;

		// Token: 0x0401F268 RID: 127592
		[Token(Token = "0x401F268")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F269 RID: 127593
		[Token(Token = "0x401F269")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadIconSprite;

		// Token: 0x0401F26A RID: 127594
		[Token(Token = "0x401F26A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
