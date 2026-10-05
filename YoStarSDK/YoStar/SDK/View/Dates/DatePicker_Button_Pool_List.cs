using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	public class DatePicker_Button_Pool_List
	{
		// Token: 0x0600076A RID: 1898 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x5C49800", Offset = "0x5C48400", VA = "0x185C49800")]
		public DatePicker_Button_Pool_List(DatePickerButtonType type, RectTransform poolRect)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
		public void SetTemplate(DatePicker_Button template)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x5C49040", Offset = "0x5C47C40", VA = "0x185C49040")]
		public void AddExistingButtonToPool(DatePicker_Button button)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x5C49260", Offset = "0x5C47E60", VA = "0x185C49260")]
		public DatePicker_Button GetButton()
		{
			return null;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x5C491A0", Offset = "0x5C47DA0", VA = "0x185C491A0")]
		public void FreeAll()
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x5C49400", Offset = "0x5C48000", VA = "0x185C49400")]
		public void Invalidate()
		{
		}

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x10")]
		private DatePicker_Button template;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform poolRect;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x20")]
		private List<DatePicker_Button_Pool_List_Item> pool;
	}
}
