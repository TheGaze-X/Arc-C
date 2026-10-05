using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049F7 RID: 18935
	[Token(Token = "0x20049F7")]
	public class InformantCustomerBarItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C81C RID: 116764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C81C")]
		[Address(RVA = "0x15F4E60", Offset = "0x15F3A60", VA = "0x1815F4E60")]
		public void Render(bool isSp, int currIndex, int index)
		{
		}

		// Token: 0x0601C81D RID: 116765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C81D")]
		[Address(RVA = "0x15F5020", Offset = "0x15F3C20", VA = "0x1815F5020")]
		public InformantCustomerBarItemView()
		{
		}

		// Token: 0x0402559F RID: 152991
		[Token(Token = "0x402559F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSp;

		// Token: 0x040255A0 RID: 152992
		[Token(Token = "0x40255A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x040255A1 RID: 152993
		[Token(Token = "0x40255A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _panelCurrent;

		// Token: 0x040255A2 RID: 152994
		[Token(Token = "0x40255A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _panelComplete;

		// Token: 0x040255A3 RID: 152995
		[Token(Token = "0x40255A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _panelUncomplete;

		// Token: 0x040255A4 RID: 152996
		[Token(Token = "0x40255A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040255A5 RID: 152997
		[Token(Token = "0x40255A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
