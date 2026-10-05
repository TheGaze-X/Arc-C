using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Medal
{
	// Token: 0x0200492A RID: 18730
	[Token(Token = "0x200492A")]
	[ExecuteInEditMode]
	public class UIMedalDIYFrameAnchor : MonoBehaviour
	{
		// Token: 0x0601C3C6 RID: 115654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3C6")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIMedalDIYFrameAnchor()
		{
		}

		// Token: 0x04024EE9 RID: 151273
		[Token(Token = "0x4024EE9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HexPoint _curPos;

		// Token: 0x04024EEA RID: 151274
		[Token(Token = "0x4024EEA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIMedalDIYFrame _frame;
	}
}
