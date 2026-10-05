using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Tables
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[RequireComponent(typeof(RectTransform))]
	public class TableLayout : LayoutGroup, ILayoutSelfController, ILayoutController
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public List<TableRow> Rows
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x5BE6380", Offset = "0x5BE4F80", VA = "0x185BE6380")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5BE4C30", Offset = "0x5BE3830", VA = "0x185BE4C30", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5BE4C90", Offset = "0x5BE3890", VA = "0x185BE4C90", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5BE40A0", Offset = "0x5BE2CA0", VA = "0x185BE40A0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5BE4EE0", Offset = "0x5BE3AE0", VA = "0x185BE4EE0")]
		public void UpdateLayout()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5BE4940", Offset = "0x5BE3540", VA = "0x185BE4940")]
		public TableRow AddRow()
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5BE4A10", Offset = "0x5BE3610", VA = "0x185BE4A10")]
		public TableRow AddRow(int cells)
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5BE4990", Offset = "0x5BE3590", VA = "0x185BE4990")]
		public TableRow AddRow(TableRow row)
		{
			return null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5BE4CB0", Offset = "0x5BE38B0", VA = "0x185BE4CB0")]
		public void ClearRows()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5BE6290", Offset = "0x5BE4E90", VA = "0x185BE6290")]
		public TableLayout()
		{
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x58")]
		public Sprite RowBackgroundImage;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x60")]
		public Color RowBackgroundColor;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x70")]
		public bool UseAlternateRowBackgroundColors;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x74")]
		public Color RowBackgroundColorAlternate;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x88")]
		public Sprite CellBackgroundImage;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x90")]
		public Color CellBackgroundColor;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0xA0")]
		public bool UseAlternateCellBackroundColors;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0xA4")]
		public Color CellBackgroundColorAlternate;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0xB4")]
		[Tooltip("If this is set, then this TableLayout will automatically add columns if there are more cells than columns on any row (this includes ColumnSpan checks)")]
		public bool AutomaticallyAddColumns;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0xB5")]
		[Tooltip("If this is set, then this TableLayout will automatically remove any columns with no cells in them in any row (at the END of the row)")]
		public bool AutomaticallyRemoveEmptyColumns;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0xB8")]
		public List<float> ColumnWidths;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("If this is set, then the cellpadding set here will override any padding settings set on individual cells")]
		public bool UseGlobalCellPadding;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xC8")]
		public RectOffset CellPadding;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xD0")]
		public float CellSpacing;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0xD4")]
		public bool AutoCalculateHeight;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0xD5")]
		private DrivenRectTransformTracker _tracker;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xD8")]
		private LayoutElement _layoutElement;
	}
}
