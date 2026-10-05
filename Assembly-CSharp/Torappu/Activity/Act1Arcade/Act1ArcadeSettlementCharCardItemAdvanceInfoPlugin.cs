using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007969 RID: 31081
	[Token(Token = "0x2007969")]
	public abstract class Act1ArcadeSettlementCharCardItemAdvanceInfoPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B9A1 RID: 178593
		[Token(Token = "0x602B9A1")]
		public abstract void OnRender(bool isAssist, CharacterCardViewModel cardViewModel);

		// Token: 0x0602B9A2 RID: 178594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A2")]
		[Address(RVA = "0x277EE90", Offset = "0x277DA90", VA = "0x18277EE90")]
		protected Act1ArcadeSettlementCharCardItemAdvanceInfoPlugin()
		{
		}

		// Token: 0x0403F12B RID: 258347
		[Token(Token = "0x403F12B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
