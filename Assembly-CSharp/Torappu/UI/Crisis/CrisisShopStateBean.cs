using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A04 RID: 23044
	[Token(Token = "0x2005A04")]
	public class CrisisShopStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0602193F RID: 137535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602193F")]
		[Address(RVA = "0x1C0A520", Offset = "0x1C09120", VA = "0x181C0A520")]
		public CrisisShopStateBean()
		{
		}

		// Token: 0x0402DE25 RID: 187941
		[Token(Token = "0x402DE25")]
		[FieldOffset(Offset = "0x18")]
		public CrisisShopInfoProperty shopInfoProperty;

		// Token: 0x0402DE26 RID: 187942
		[Token(Token = "0x402DE26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
