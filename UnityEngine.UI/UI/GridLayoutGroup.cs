using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[AddComponentMenu("Layout/Grid Layout Group", 152)]
	public class GridLayoutGroup : LayoutGroup
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00002FB8 File Offset: 0x000011B8
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B7")]
		public GridLayoutGroup.Corner startCorner
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return GridLayoutGroup.Corner.UpperLeft;
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x5B57610", Offset = "0x5B56210", VA = "0x185B57610")]
			set
			{
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00002FD0 File Offset: 0x000011D0
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B8")]
		public GridLayoutGroup.Axis startAxis
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x32FB190", Offset = "0x32F9D90", VA = "0x1832FB190")]
			get
			{
				return GridLayoutGroup.Axis.Horizontal;
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x5B575C0", Offset = "0x5B561C0", VA = "0x185B575C0")]
			set
			{
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00002FE8 File Offset: 0x000011E8
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B9")]
		public Vector2 cellSize
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x5B57410", Offset = "0x5B56010", VA = "0x185B57410")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x5B57450", Offset = "0x5B56050", VA = "0x185B57450")]
			set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00003000 File Offset: 0x00001200
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BA")]
		public Vector2 spacing
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x5B57430", Offset = "0x5B56030", VA = "0x185B57430")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x5B57560", Offset = "0x5B56160", VA = "0x185B57560")]
			set
			{
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BB")]
		public GridLayoutGroup.Constraint constraint
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x4C2EA10", Offset = "0x4C2D610", VA = "0x184C2EA10")]
			get
			{
				return GridLayoutGroup.Constraint.Flexible;
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x5B57510", Offset = "0x5B56110", VA = "0x185B57510")]
			set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00003030 File Offset: 0x00001230
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BC")]
		public int constraintCount
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x4D7C600", Offset = "0x4D7B200", VA = "0x184D7C600")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x5B574B0", Offset = "0x5B560B0", VA = "0x185B574B0")]
			set
			{
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x5B573A0", Offset = "0x5B55FA0", VA = "0x185B573A0")]
		protected GridLayoutGroup()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x5B56870", Offset = "0x5B55470", VA = "0x185B56870", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x5B56A60", Offset = "0x5B55660", VA = "0x185B56A60", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x5B57380", Offset = "0x5B55F80", VA = "0x185B57380", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x5B57390", Offset = "0x5B55F90", VA = "0x185B57390", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x5B56C70", Offset = "0x5B55870", VA = "0x185B56C70")]
		private void SetCellsAlongAxis(int axis)
		{
		}

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected GridLayoutGroup.Corner m_StartCorner;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected GridLayoutGroup.Axis m_StartAxis;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected Vector2 m_CellSize;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Vector2 m_Spacing;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected GridLayoutGroup.Constraint m_Constraint;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		protected int m_ConstraintCount;

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		public enum Corner
		{
			// Token: 0x0400016A RID: 362
			[Token(Token = "0x400016A")]
			UpperLeft,
			// Token: 0x0400016B RID: 363
			[Token(Token = "0x400016B")]
			UpperRight,
			// Token: 0x0400016C RID: 364
			[Token(Token = "0x400016C")]
			LowerLeft,
			// Token: 0x0400016D RID: 365
			[Token(Token = "0x400016D")]
			LowerRight
		}

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		public enum Axis
		{
			// Token: 0x0400016F RID: 367
			[Token(Token = "0x400016F")]
			Horizontal,
			// Token: 0x04000170 RID: 368
			[Token(Token = "0x4000170")]
			Vertical
		}

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		public enum Constraint
		{
			// Token: 0x04000172 RID: 370
			[Token(Token = "0x4000172")]
			Flexible,
			// Token: 0x04000173 RID: 371
			[Token(Token = "0x4000173")]
			FixedColumnCount,
			// Token: 0x04000174 RID: 372
			[Token(Token = "0x4000174")]
			FixedRowCount
		}
	}
}
