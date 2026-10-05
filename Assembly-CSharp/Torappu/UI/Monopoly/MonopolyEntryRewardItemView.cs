using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047E6 RID: 18406
	[Token(Token = "0x20047E6")]
	public class MonopolyEntryRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BD7B RID: 114043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD7B")]
		[Address(RVA = "0x1524940", Offset = "0x1523540", VA = "0x181524940")]
		public void Render(UIItemViewModel itemModel, bool isCompleted)
		{
		}

		// Token: 0x0601BD7C RID: 114044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD7C")]
		[Address(RVA = "0x1524C20", Offset = "0x1523820", VA = "0x181524C20")]
		private void _OnClickItem(int _)
		{
		}

		// Token: 0x0601BD7D RID: 114045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD7D")]
		[Address(RVA = "0x1524D30", Offset = "0x1523930", VA = "0x181524D30")]
		public MonopolyEntryRewardItemView()
		{
		}

		// Token: 0x040243B7 RID: 148407
		[Token(Token = "0x40243B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _itemContent;

		// Token: 0x040243B8 RID: 148408
		[Token(Token = "0x40243B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _rewardCnt;

		// Token: 0x040243B9 RID: 148409
		[Token(Token = "0x40243B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _isCompleted;

		// Token: 0x040243BA RID: 148410
		[Token(Token = "0x40243BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemCardScaleFactor;

		// Token: 0x040243BB RID: 148411
		[Token(Token = "0x40243BB")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x040243BC RID: 148412
		[Token(Token = "0x40243BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040243BD RID: 148413
		[Token(Token = "0x40243BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnClickItem;

		// Token: 0x040243BE RID: 148414
		[Token(Token = "0x40243BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
