using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050F7 RID: 20727
	[Token(Token = "0x20050F7")]
	public class UIDebugLocalTimePanel : MonoBehaviour
	{
		// Token: 0x0601EA0A RID: 125450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA0A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void EventOnResetClicked()
		{
		}

		// Token: 0x0601EA0B RID: 125451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA0B")]
		[Address(RVA = "0x1865390", Offset = "0x1863F90", VA = "0x181865390")]
		private void Start()
		{
		}

		// Token: 0x0601EA0C RID: 125452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA0C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIDebugLocalTimePanel()
		{
		}

		// Token: 0x040290E1 RID: 168161
		[Token(Token = "0x40290E1")]
		private const float CENTER_NORM_VAL = 0.5f;

		// Token: 0x040290E2 RID: 168162
		[Token(Token = "0x40290E2")]
		private const float SEC_SLIDER_UNIT = 0.02f;

		// Token: 0x040290E3 RID: 168163
		[Token(Token = "0x40290E3")]
		private const float HOUR_SLIDER_UNIT = 0.05f;

		// Token: 0x040290E4 RID: 168164
		[Token(Token = "0x40290E4")]
		private const float SLIDER_CHANGE_THRESHOLD = 0.01f;

		// Token: 0x040290E5 RID: 168165
		[Token(Token = "0x40290E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x040290E6 RID: 168166
		[Token(Token = "0x40290E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTs;

		// Token: 0x040290E7 RID: 168167
		[Token(Token = "0x40290E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _sliderSec;

		// Token: 0x040290E8 RID: 168168
		[Token(Token = "0x40290E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _sliderHour;

		// Token: 0x040290E9 RID: 168169
		[Token(Token = "0x40290E9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Toggle _preMainOnlyToggle;

		// Token: 0x040290EA RID: 168170
		[Token(Token = "0x40290EA")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x040290EB RID: 168171
		[Token(Token = "0x40290EB")]
		[FieldOffset(Offset = "0x48")]
		private long m_localPremainTime;
	}
}
