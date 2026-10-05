using System;
using Il2CppDummyDll;
using UI.Tables;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	public class DatePicker_Header : MonoBehaviour
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public Text HeaderText
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x5C4A2F0", Offset = "0x5C48EF0", VA = "0x185C4A2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x5C4A220", Offset = "0x5C48E20", VA = "0x185C4A220")]
		public void Apply()
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DatePicker_Header()
		{
		}

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("HeaderText")]
		[SerializeField]
		private Text m_HeaderText;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x20")]
		public DatePicker_Button PreviousYearButton;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x28")]
		public DatePicker_Button NextYearButton;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x30")]
		private TableRow Row;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x38")]
		public TableLayout TableLayout;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x40")]
		public TableCell Ref_Year_TableContainer;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x48")]
		public TableCell Ref_Month_TableContainer;
	}
}
