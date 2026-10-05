using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Tables
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[RequireComponent(typeof(RectTransform))]
	public class TableCell : HorizontalLayoutGroup
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public Image image
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x5BE4110", Offset = "0x5BE2D10", VA = "0x185BE4110")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5BE3EF0", Offset = "0x5BE2AF0", VA = "0x185BE3EF0")]
		internal void Initialise(TableLayout tableLayout, TableRow row)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5BE3EA0", Offset = "0x5BE2AA0", VA = "0x185BE3EA0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5BE3ED0", Offset = "0x5BE2AD0", VA = "0x185BE3ED0", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5BE3EE0", Offset = "0x5BE2AE0", VA = "0x185BE3EE0", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5BE40A0", Offset = "0x5BE2CA0", VA = "0x185BE40A0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5BE40E0", Offset = "0x5BE2CE0", VA = "0x185BE40E0", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5BE40F0", Offset = "0x5BE2CF0", VA = "0x185BE40F0", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5BE3FE0", Offset = "0x5BE2BE0", VA = "0x185BE3FE0")]
		public void NotifyTableCellPropertiesChanged()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5BE40B0", Offset = "0x5BE2CB0", VA = "0x185BE40B0")]
		public void SetCellPaddingFromTableLayout()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
		public TableRow GetRow()
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5BE4100", Offset = "0x5BE2D00", VA = "0x185BE4100")]
		public TableCell()
		{
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("How many columns should this cell span?")]
		public int columnSpan;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("If this property is set, then this cell will ignore the TableLayout CellBackgroundColor/CellBackgroundImage values - allowing you to set specific values for this cell.")]
		public bool dontUseTableCellBackground;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x6D")]
		[Tooltip("If this property is set, then this cell will ignore the TableLayout Global Cell Padding values - allowing you to set specific values for this cell.")]
		public bool overrideGlobalPadding;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		internal float actualWidth;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x74")]
		[NonSerialized]
		internal float actualHeight;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		internal float actualX;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x7C")]
		[NonSerialized]
		internal float actualY;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x80")]
		protected Image _image;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TableLayout m_tableLayout;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TableRow m_tableRow;
	}
}
