using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CB4 RID: 23732
	[Token(Token = "0x2005CB4")]
	public abstract class ClimbTowerTowerLayerBaseGodCardTips : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022599 RID: 140697
		[Token(Token = "0x6022599")]
		public abstract void Render(ClimbTowerTowerLayerStackAdapter adapter);

		// Token: 0x0602259A RID: 140698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602259A")]
		[Address(RVA = "0x1CD7E70", Offset = "0x1CD6A70", VA = "0x181CD7E70")]
		protected ClimbTowerTowerLayerBaseGodCardTips()
		{
		}

		// Token: 0x0402F347 RID: 193351
		[Token(Token = "0x402F347")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
