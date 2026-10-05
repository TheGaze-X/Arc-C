using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C45 RID: 7237
	[Token(Token = "0x2001C45")]
	public class BuildingTradingRequireItemView : MonoBehaviour
	{
		// Token: 0x0600B430 RID: 46128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B430")]
		[Address(RVA = "0x32F74B0", Offset = "0x32F60B0", VA = "0x1832F74B0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B431 RID: 46129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B431")]
		[Address(RVA = "0x32F7500", Offset = "0x32F6100", VA = "0x1832F7500")]
		public void Render(TradingOrderRequireStruct requireStruct, bool isOrderComplete)
		{
		}

		// Token: 0x0600B432 RID: 46130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B432")]
		[Address(RVA = "0x32F7810", Offset = "0x32F6410", VA = "0x1832F7810")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B433 RID: 46131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B433")]
		[Address(RVA = "0x32F79A0", Offset = "0x32F65A0", VA = "0x1832F79A0")]
		public BuildingTradingRequireItemView()
		{
		}

		// Token: 0x0400AFBF RID: 44991
		[Token(Token = "0x400AFBF")]
		private const string ANIM_COMPLETE_KEY = "IS_COMPLETE";

		// Token: 0x0400AFC0 RID: 44992
		[Token(Token = "0x400AFC0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingTradingRequireItemInfo _completeInfo;

		// Token: 0x0400AFC1 RID: 44993
		[Token(Token = "0x400AFC1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingTradingRequireItemInfo _uncompleteInfo;

		// Token: 0x0400AFC2 RID: 44994
		[Token(Token = "0x400AFC2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIItemCard _itemPrefab;

		// Token: 0x0400AFC3 RID: 44995
		[Token(Token = "0x400AFC3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400AFC4 RID: 44996
		[Token(Token = "0x400AFC4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x0400AFC5 RID: 44997
		[Token(Token = "0x400AFC5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400AFC6 RID: 44998
		[Token(Token = "0x400AFC6")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0400AFC7 RID: 44999
		[Token(Token = "0x400AFC7")]
		[FieldOffset(Offset = "0x50")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0400AFC8 RID: 45000
		[Token(Token = "0x400AFC8")]
		[FieldOffset(Offset = "0x58")]
		private UIItemCard m_itemCard;

		// Token: 0x0400AFC9 RID: 45001
		[Token(Token = "0x400AFC9")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isOrderComplete;
	}
}
