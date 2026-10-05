using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CB5 RID: 23733
	[Token(Token = "0x2005CB5")]
	public abstract class ClimbTowerTowerLayerBaseSelectArrow : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602259B RID: 140699
		[Token(Token = "0x602259B")]
		public abstract void Render(ClimbTowerTowerLayerStackAdapter adapter);

		// Token: 0x0602259C RID: 140700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602259C")]
		[Address(RVA = "0x1CD7ED0", Offset = "0x1CD6AD0", VA = "0x181CD7ED0")]
		protected ClimbTowerTowerLayerBaseSelectArrow()
		{
		}

		// Token: 0x0402F348 RID: 193352
		[Token(Token = "0x402F348")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
