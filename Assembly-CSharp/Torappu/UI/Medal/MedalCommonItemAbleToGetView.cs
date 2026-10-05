using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004964 RID: 18788
	[Token(Token = "0x2004964")]
	public class MedalCommonItemAbleToGetView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C521 RID: 116001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C521")]
		[Address(RVA = "0x15C7660", Offset = "0x15C6260", VA = "0x1815C7660")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C522 RID: 116002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C522")]
		[Address(RVA = "0x15C7180", Offset = "0x15C5D80", VA = "0x1815C7180")]
		public void Render(MedalCommonViewModel viewModel, string pageName)
		{
		}

		// Token: 0x0601C523 RID: 116003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C523")]
		[Address(RVA = "0x15C77D0", Offset = "0x15C63D0", VA = "0x1815C77D0")]
		public MedalCommonItemAbleToGetView()
		{
		}

		// Token: 0x040250AB RID: 151723
		[Token(Token = "0x40250AB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x040250AC RID: 151724
		[Token(Token = "0x40250AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x040250AD RID: 151725
		[Token(Token = "0x40250AD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x040250AE RID: 151726
		[Token(Token = "0x40250AE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scaler;

		// Token: 0x040250AF RID: 151727
		[Token(Token = "0x40250AF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _medalName;

		// Token: 0x040250B0 RID: 151728
		[Token(Token = "0x40250B0")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x040250B1 RID: 151729
		[Token(Token = "0x40250B1")]
		[FieldOffset(Offset = "0x48")]
		private UIItemCard m_itemCard;

		// Token: 0x040250B2 RID: 151730
		[Token(Token = "0x40250B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040250B3 RID: 151731
		[Token(Token = "0x40250B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040250B4 RID: 151732
		[Token(Token = "0x40250B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
