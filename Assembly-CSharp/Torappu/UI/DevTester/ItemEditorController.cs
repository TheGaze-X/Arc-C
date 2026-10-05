using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050F0 RID: 20720
	[Token(Token = "0x20050F0")]
	public class ItemEditorController : MonoBehaviour
	{
		// Token: 0x0601E9FE RID: 125438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9FE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ItemEditorController()
		{
		}

		// Token: 0x040290BF RID: 168127
		[Token(Token = "0x40290BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _moneyText;

		// Token: 0x040290C0 RID: 168128
		[Token(Token = "0x40290C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InputField _itemIdIput;
	}
}
