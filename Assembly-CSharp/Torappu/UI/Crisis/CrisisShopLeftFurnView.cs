using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A14 RID: 23060
	[Token(Token = "0x2005A14")]
	public class CrisisShopLeftFurnView : MonoBehaviour
	{
		// Token: 0x06021980 RID: 137600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021980")]
		[Address(RVA = "0x1C081B0", Offset = "0x1C06DB0", VA = "0x181C081B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021981 RID: 137601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021981")]
		[Address(RVA = "0x1C07CD0", Offset = "0x1C068D0", VA = "0x181C07CD0")]
		public void Render(CrisisShopWrapped shopViewModel)
		{
		}

		// Token: 0x06021982 RID: 137602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021982")]
		[Address(RVA = "0x1C08320", Offset = "0x1C06F20", VA = "0x181C08320")]
		public CrisisShopLeftFurnView()
		{
		}

		// Token: 0x0402DEB7 RID: 188087
		[Token(Token = "0x402DEB7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemDetailName;

		// Token: 0x0402DEB8 RID: 188088
		[Token(Token = "0x402DEB8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _addText;

		// Token: 0x0402DEB9 RID: 188089
		[Token(Token = "0x402DEB9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402DEBA RID: 188090
		[Token(Token = "0x402DEBA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _scaleCount;

		// Token: 0x0402DEBB RID: 188091
		[Token(Token = "0x402DEBB")]
		[FieldOffset(Offset = "0x38")]
		private UIItemCard m_itemCard;

		// Token: 0x0402DEBC RID: 188092
		[Token(Token = "0x402DEBC")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;
	}
}
