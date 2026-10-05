using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005139 RID: 20793
	[Token(Token = "0x2005139")]
	public class DeepSeaRPZoneMapLoader : PageAssetPool<GameObject>
	{
		// Token: 0x0601EB85 RID: 125829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EB85")]
		[Address(RVA = "0x1877480", Offset = "0x1876080", VA = "0x181877480")]
		public DeepSeaRPZoneMapView LoadZoneMap(string assetPath, Transform parent)
		{
			return null;
		}

		// Token: 0x0601EB86 RID: 125830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB86")]
		[Address(RVA = "0x1877610", Offset = "0x1876210", VA = "0x181877610")]
		public DeepSeaRPZoneMapLoader()
		{
		}

		// Token: 0x04029335 RID: 168757
		[Token(Token = "0x4029335")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadZoneMap;

		// Token: 0x04029336 RID: 168758
		[Token(Token = "0x4029336")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
