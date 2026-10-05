using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B57 RID: 23383
	[Token(Token = "0x2005B57")]
	public class ShopStateObject : MonoBehaviour
	{
		// Token: 0x06021F25 RID: 139045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F25")]
		[Address(RVA = "0x1C79940", Offset = "0x1C78540", VA = "0x181C79940")]
		public void ApplyType(ShopType type)
		{
		}

		// Token: 0x06021F26 RID: 139046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F26")]
		[Address(RVA = "0x1C79960", Offset = "0x1C78560", VA = "0x181C79960")]
		public void OnClick()
		{
		}

		// Token: 0x06021F27 RID: 139047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F27")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ShopStateObject()
		{
		}

		// Token: 0x0402E812 RID: 190482
		[Token(Token = "0x402E812")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ShopType _type;

		// Token: 0x0402E813 RID: 190483
		[Token(Token = "0x402E813")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIIntEvent _onClick;

		// Token: 0x0402E814 RID: 190484
		[Token(Token = "0x402E814")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _twoStateToggle;
	}
}
