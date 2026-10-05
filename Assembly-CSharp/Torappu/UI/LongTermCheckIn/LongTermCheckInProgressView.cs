using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049BD RID: 18877
	[Token(Token = "0x20049BD")]
	public class LongTermCheckInProgressView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C705 RID: 116485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C705")]
		[Address(RVA = "0x15E4FF0", Offset = "0x15E3BF0", VA = "0x1815E4FF0")]
		public void Render(LongTermCheckInProgressViewModel model)
		{
		}

		// Token: 0x0601C706 RID: 116486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C706")]
		[Address(RVA = "0x15E50E0", Offset = "0x15E3CE0", VA = "0x1815E50E0")]
		public LongTermCheckInProgressView()
		{
		}

		// Token: 0x0402542D RID: 152621
		[Token(Token = "0x402542D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0402542E RID: 152622
		[Token(Token = "0x402542E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUncomplete;

		// Token: 0x0402542F RID: 152623
		[Token(Token = "0x402542F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x04025430 RID: 152624
		[Token(Token = "0x4025430")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025431 RID: 152625
		[Token(Token = "0x4025431")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
