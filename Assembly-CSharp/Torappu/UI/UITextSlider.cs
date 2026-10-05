using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003A36 RID: 14902
	[Token(Token = "0x2003A36")]
	public class UITextSlider : MonoBehaviour
	{
		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x06017853 RID: 96339 RVA: 0x00096EA0 File Offset: 0x000950A0
		// (set) Token: 0x06017854 RID: 96340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700385A")]
		public float value
		{
			[Token(Token = "0x6017853")]
			[Address(RVA = "0xFD5EA0", Offset = "0xFD4AA0", VA = "0x180FD5EA0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6017854")]
			[Address(RVA = "0xFD6000", Offset = "0xFD4C00", VA = "0x180FD6000")]
			set
			{
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x06017855 RID: 96341 RVA: 0x00096EB8 File Offset: 0x000950B8
		// (set) Token: 0x06017856 RID: 96342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700385B")]
		public Color color
		{
			[Token(Token = "0x6017855")]
			[Address(RVA = "0xFD5E20", Offset = "0xFD4A20", VA = "0x180FD5E20")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6017856")]
			[Address(RVA = "0xFD5EF0", Offset = "0xFD4AF0", VA = "0x180FD5EF0")]
			set
			{
			}
		}

		// Token: 0x06017857 RID: 96343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017857")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public virtual void SetSliderColorByProgress(float progress)
		{
		}

		// Token: 0x06017858 RID: 96344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017858")]
		[Address(RVA = "0xFD5BE0", Offset = "0xFD47E0", VA = "0x180FD5BE0", Slot = "5")]
		public virtual void SetValue(float current, float maximum)
		{
		}

		// Token: 0x06017859 RID: 96345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017859")]
		[Address(RVA = "0xFD5B00", Offset = "0xFD4700", VA = "0x180FD5B00")]
		public void SetRawText(string text, float value)
		{
		}

		// Token: 0x0601785A RID: 96346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601785A")]
		[Address(RVA = "0xFD5A50", Offset = "0xFD4650", VA = "0x180FD5A50")]
		public void SetFillAreaColor(Color color)
		{
		}

		// Token: 0x0601785B RID: 96347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601785B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UITextSlider()
		{
		}

		// Token: 0x0401C674 RID: 116340
		[Token(Token = "0x401C674")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Slider _slider;

		// Token: 0x0401C675 RID: 116341
		[Token(Token = "0x401C675")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Image _sliderFillImage;

		// Token: 0x0401C676 RID: 116342
		[Token(Token = "0x401C676")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _text;

		// Token: 0x0401C677 RID: 116343
		[Token(Token = "0x401C677")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UITextSlider.TextMode _textMode;

		// Token: 0x02003A37 RID: 14903
		[Token(Token = "0x2003A37")]
		public enum TextMode
		{
			// Token: 0x0401C679 RID: 116345
			[Token(Token = "0x401C679")]
			A_SLASH_B,
			// Token: 0x0401C67A RID: 116346
			[Token(Token = "0x401C67A")]
			ONLY_NUMBER,
			// Token: 0x0401C67B RID: 116347
			[Token(Token = "0x401C67B")]
			PERCENTAGE
		}
	}
}
