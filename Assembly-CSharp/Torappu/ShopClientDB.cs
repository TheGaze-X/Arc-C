using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005D5 RID: 1493
	[Token(Token = "0x20005D5")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/ShopClientTable")]
	[Serializable]
	public class ShopClientDB : ConstTable<ShopClientData, ShopClientDB>
	{
		// Token: 0x0600617F RID: 24959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617F")]
		[Address(RVA = "0x1DF42E0", Offset = "0x1DF2EE0", VA = "0x181DF42E0")]
		public ShopClientDB()
		{
		}

		// Token: 0x04002B25 RID: 11045
		[Token(Token = "0x4002B25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
