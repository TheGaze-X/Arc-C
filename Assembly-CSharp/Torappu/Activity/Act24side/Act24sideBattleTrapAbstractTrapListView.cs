using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007577 RID: 30071
	[Token(Token = "0x2007577")]
	public abstract class Act24sideBattleTrapAbstractTrapListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A562 RID: 173410
		[Token(Token = "0x602A562")]
		public abstract void Render(List<Act24sideBattleTrapItemViewModel> modelList);

		// Token: 0x0602A563 RID: 173411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A563")]
		[Address(RVA = "0x25F6230", Offset = "0x25F4E30", VA = "0x1825F6230")]
		protected Act24sideBattleTrapAbstractTrapListView()
		{
		}

		// Token: 0x0403CE2A RID: 249386
		[Token(Token = "0x403CE2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
