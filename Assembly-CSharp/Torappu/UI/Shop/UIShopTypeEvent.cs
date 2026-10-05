using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B53 RID: 23379
	[Token(Token = "0x2005B53")]
	[Serializable]
	public class UIShopTypeEvent : UnityEvent<ShopType>
	{
		// Token: 0x06021F09 RID: 139017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F09")]
		[Address(RVA = "0x1C850E0", Offset = "0x1C83CE0", VA = "0x181C850E0")]
		public void Callback(ShopType param)
		{
		}

		// Token: 0x06021F0A RID: 139018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F0A")]
		[Address(RVA = "0x1C85130", Offset = "0x1C83D30", VA = "0x181C85130")]
		public UIShopTypeEvent()
		{
		}
	}
}
