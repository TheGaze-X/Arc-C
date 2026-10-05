using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	public class DatePicker_ContentLayout : MonoBehaviour
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		protected RectTransform rectTransform
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x5C4A180", Offset = "0x5C48D80", VA = "0x185C4A180")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x5C4A010", Offset = "0x5C48C10", VA = "0x185C4A010")]
		public void SetBorderSize(RectOffset borderSize)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x5C4A0F0", Offset = "0x5C48CF0", VA = "0x185C4A0F0")]
		public void SetBorderSize(int borderSize)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x5C49FF0", Offset = "0x5C48BF0", VA = "0x185C49FF0")]
		private void OnRectTransformDimensionsChanged()
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DatePicker_ContentLayout()
		{
		}

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x18")]
		public DatePicker DatePicker;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_rectTransform;
	}
}
