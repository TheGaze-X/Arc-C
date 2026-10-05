using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003841 RID: 14401
	[Token(Token = "0x2003841")]
	[RequireComponent(typeof(Toggle))]
	public class UIToggleSwitch : MonoBehaviour
	{
		// Token: 0x06016D2B RID: 93483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D2B")]
		[Address(RVA = "0xF52BF0", Offset = "0xF517F0", VA = "0x180F52BF0")]
		public void OnToggled(bool isOn)
		{
		}

		// Token: 0x06016D2C RID: 93484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D2C")]
		[Address(RVA = "0xF52B10", Offset = "0xF51710", VA = "0x180F52B10")]
		private void Awake()
		{
		}

		// Token: 0x06016D2D RID: 93485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D2D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIToggleSwitch()
		{
		}

		// Token: 0x0401B85A RID: 112730
		[Token(Token = "0x401B85A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _toggleOn;

		// Token: 0x0401B85B RID: 112731
		[Token(Token = "0x401B85B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _toggleOff;

		// Token: 0x0401B85C RID: 112732
		[Token(Token = "0x401B85C")]
		[FieldOffset(Offset = "0x28")]
		private Toggle m_toggle;
	}
}
