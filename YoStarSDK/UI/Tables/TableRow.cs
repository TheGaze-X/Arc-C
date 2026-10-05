using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Tables
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[RequireComponent(typeof(RectTransform))]
	public class TableRow : MonoBehaviour
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public List<TableCell> Cells
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x5BE6DB0", Offset = "0x5BE59B0", VA = "0x185BE6DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x17000006")]
		public int CellCount
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x5BE6D60", Offset = "0x5BE5960", VA = "0x185BE6D60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public Image image
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x5BE6E80", Offset = "0x5BE5A80", VA = "0x185BE6E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
		internal void Initialise(TableLayout tableLayout)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5BE6A00", Offset = "0x5BE5600", VA = "0x185BE6A00")]
		public void UpdateLayout()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x5BE6450", Offset = "0x5BE5050", VA = "0x185BE6450")]
		public TableCell AddCell([Optional] RectTransform cellContent)
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5BE6640", Offset = "0x5BE5240", VA = "0x185BE6640")]
		public TableCell AddCell(TableCell cell)
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5BE68B0", Offset = "0x5BE54B0", VA = "0x185BE68B0")]
		public void NotifyTableRowPropertiesChanged()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
		public TableLayout GetTable()
		{
			return null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5BE6740", Offset = "0x5BE5340", VA = "0x185BE6740")]
		public void ClearCells()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public TableRow()
		{
		}

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float preferredHeight;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		internal float actualHeight;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool dontUseTableRowBackground;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Image _image;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DrivenRectTransformTracker _tracker;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TableLayout m_tableLayout;
	}
}
