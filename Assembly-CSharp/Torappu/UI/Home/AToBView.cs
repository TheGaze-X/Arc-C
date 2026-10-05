using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004BDA RID: 19418
	[Token(Token = "0x2004BDA")]
	public class AToBView : MonoBehaviour
	{
		// Token: 0x0601D2F4 RID: 119540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F4")]
		[Address(RVA = "0x16B0880", Offset = "0x16AF480", VA = "0x1816B0880")]
		public void SetData(int current, int maxCapacity)
		{
		}

		// Token: 0x0601D2F5 RID: 119541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2F5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AToBView()
		{
		}

		// Token: 0x040264EE RID: 156910
		[Token(Token = "0x40264EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _curLabel;

		// Token: 0x040264EF RID: 156911
		[Token(Token = "0x40264EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _maxLabel;
	}
}
