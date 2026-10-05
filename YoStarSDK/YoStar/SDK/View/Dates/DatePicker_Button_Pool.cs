using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public class DatePicker_Button_Pool : MonoBehaviour
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		private DatePicker datePicker
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x5C49930", Offset = "0x5C48530", VA = "0x185C49930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		private RectTransform poolRect
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x5C499D0", Offset = "0x5C485D0", VA = "0x185C499D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x5C487A0", Offset = "0x5C473A0", VA = "0x185C487A0")]
		public void AddExistingButton(DatePicker_Button button)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x5C48AF0", Offset = "0x5C476F0", VA = "0x185C48AF0")]
		public DatePicker_Button GetButton(DatePickerButtonType type)
		{
			return null;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x5C48CA0", Offset = "0x5C478A0", VA = "0x185C48CA0")]
		private DatePicker_Button_Pool_List GetPoolList(DatePickerButtonType type)
		{
			return null;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x5C48910", Offset = "0x5C47510", VA = "0x185C48910")]
		public void FreeAll()
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x5C48E90", Offset = "0x5C47A90", VA = "0x185C48E90")]
		public void InvalidateAll()
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x5C48FB0", Offset = "0x5C47BB0", VA = "0x185C48FB0")]
		public void InvalidateType(DatePickerButtonType type)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x5C48E50", Offset = "0x5C47A50", VA = "0x185C48E50")]
		private DatePicker_Button GetTemplate(DatePickerButtonType type)
		{
			return null;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x5C498A0", Offset = "0x5C484A0", VA = "0x185C498A0")]
		public DatePicker_Button_Pool()
		{
		}

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x18")]
		private DatePicker _datePicker;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _poolRect;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<DatePickerButtonType, DatePicker_Button_Pool_List> pool;
	}
}
