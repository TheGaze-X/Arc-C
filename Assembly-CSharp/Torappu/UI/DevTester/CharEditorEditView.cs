using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050E8 RID: 20712
	[Token(Token = "0x20050E8")]
	public class CharEditorEditView : MonoBehaviour
	{
		// Token: 0x0601E9E8 RID: 125416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9E8")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharEditorEditView()
		{
		}

		// Token: 0x040290A5 RID: 168101
		[Token(Token = "0x40290A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _labelName;

		// Token: 0x040290A6 RID: 168102
		[Token(Token = "0x40290A6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textEvolvePhase;

		// Token: 0x040290A7 RID: 168103
		[Token(Token = "0x40290A7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField _levelInput;

		// Token: 0x040290A8 RID: 168104
		[Token(Token = "0x40290A8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _levelSlider;

		// Token: 0x040290A9 RID: 168105
		[Token(Token = "0x40290A9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _maxLevel;
	}
}
