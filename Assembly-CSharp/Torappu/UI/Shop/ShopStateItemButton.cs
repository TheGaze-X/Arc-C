using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B52 RID: 23378
	[Token(Token = "0x2005B52")]
	public class ShopStateItemButton : MonoBehaviour
	{
		// Token: 0x06021F04 RID: 139012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F04")]
		[Address(RVA = "0x1C78100", Offset = "0x1C76D00", VA = "0x181C78100")]
		public void OnClick()
		{
		}

		// Token: 0x06021F05 RID: 139013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F05")]
		[Address(RVA = "0x1C78190", Offset = "0x1C76D90", VA = "0x181C78190")]
		private void OnEnable()
		{
		}

		// Token: 0x06021F06 RID: 139014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F06")]
		[Address(RVA = "0x1C780A0", Offset = "0x1C76CA0", VA = "0x181C780A0")]
		public void ApplyShopType(ShopType currentShopType)
		{
		}

		// Token: 0x06021F07 RID: 139015 RVA: 0x000BBD88 File Offset: 0x000B9F88
		[Token(Token = "0x6021F07")]
		[Address(RVA = "0x1C781E0", Offset = "0x1C76DE0", VA = "0x181C781E0")]
		public bool isActive()
		{
			return default(bool);
		}

		// Token: 0x06021F08 RID: 139016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F08")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ShopStateItemButton()
		{
		}

		// Token: 0x0402E7E7 RID: 190439
		[Token(Token = "0x402E7E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ShopType _shopType;

		// Token: 0x0402E7E8 RID: 190440
		[Token(Token = "0x402E7E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0402E7E9 RID: 190441
		[Token(Token = "0x402E7E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIShopTypeEvent _clickEvent;

		// Token: 0x0402E7EA RID: 190442
		[Token(Token = "0x402E7EA")]
		private const string ACTIVEFLAG = "active";

		// Token: 0x0402E7EB RID: 190443
		[Token(Token = "0x402E7EB")]
		[FieldOffset(Offset = "0x30")]
		private bool m_activeFlag;
	}
}
