using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C4A RID: 19530
	[Token(Token = "0x2004C4A")]
	public abstract class HomeMainWidgetHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D50A RID: 120074
		[Token(Token = "0x601D50A")]
		public abstract void ChangeWidget(GameObject widgetGO);

		// Token: 0x0601D50B RID: 120075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D50B")]
		[Address(RVA = "0x16E20E0", Offset = "0x16E0CE0", VA = "0x1816E20E0")]
		protected HomeMainWidgetHolder()
		{
		}

		// Token: 0x0402691E RID: 157982
		[Token(Token = "0x402691E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
