using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x0200289D RID: 10397
	[Token(Token = "0x200289D")]
	public class ColorTemplate : MonoBehaviour
	{
		// Token: 0x060114CC RID: 70860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114CC")]
		[Address(RVA = "0x9210B0", Offset = "0x91FCB0", VA = "0x1809210B0")]
		public void OnInit(Action<Color> callback, Color initColor)
		{
		}

		// Token: 0x060114CD RID: 70861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114CD")]
		[Address(RVA = "0x9211F0", Offset = "0x91FDF0", VA = "0x1809211F0")]
		private void Start()
		{
		}

		// Token: 0x060114CE RID: 70862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114CE")]
		[Address(RVA = "0x921350", Offset = "0x91FF50", VA = "0x180921350")]
		private void _EventOnSliderValueChanged(float value)
		{
		}

		// Token: 0x060114CF RID: 70863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114CF")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ColorTemplate()
		{
		}

		// Token: 0x0401352D RID: 79149
		[Token(Token = "0x401352D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider _rSlider;

		// Token: 0x0401352E RID: 79150
		[Token(Token = "0x401352E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider _gSlider;

		// Token: 0x0401352F RID: 79151
		[Token(Token = "0x401352F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _bSlider;

		// Token: 0x04013530 RID: 79152
		[Token(Token = "0x4013530")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _colorShow;

		// Token: 0x04013531 RID: 79153
		[Token(Token = "0x4013531")]
		[FieldOffset(Offset = "0x38")]
		private Action<Color> m_callback;
	}
}
