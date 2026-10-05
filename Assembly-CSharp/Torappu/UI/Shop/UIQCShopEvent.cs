using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AFB RID: 23291
	[Token(Token = "0x2005AFB")]
	[Serializable]
	public class UIQCShopEvent : UnityEvent<QCShopDetailShopEnum>
	{
		// Token: 0x06021D8E RID: 138638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D8E")]
		[Address(RVA = "0x1C575B0", Offset = "0x1C561B0", VA = "0x181C575B0")]
		public void Callback(QCShopDetailShopEnum param)
		{
		}

		// Token: 0x06021D8F RID: 138639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D8F")]
		[Address(RVA = "0x1C57600", Offset = "0x1C56200", VA = "0x181C57600")]
		public UIQCShopEvent()
		{
		}
	}
}
