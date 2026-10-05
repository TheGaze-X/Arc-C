using System;
using Il2CppDummyDll;
using UI.Tables;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public class DatePicker_Button : MonoBehaviour
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public Button Button
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x5C49C10", Offset = "0x5C48810", VA = "0x185C49C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public Text Text
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x5C49EB0", Offset = "0x5C48AB0", VA = "0x185C49EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public TableCell Cell
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x5C49DC0", Offset = "0x5C489C0", VA = "0x185C49DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x5C484C0", Offset = "0x5C470C0", VA = "0x185C484C0")]
		public void Clicked()
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x5C48750", Offset = "0x5C47350", VA = "0x185C48750")]
		public void MouseOver()
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600075F")]
		[Address(RVA = "0xFAD100", Offset = "0xFABD00", VA = "0x180FAD100")]
		public DatePicker_Button()
		{
		}

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button m_Button;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text m_Text;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x28")]
		public bool IsTemplate;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TableCell m_Cell;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x38")]
		internal DateTime Date;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x40")]
		internal int Year;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x48")]
		internal DatePicker DatePicker;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x50")]
		internal DatePickerButtonType Type;
	}
}
