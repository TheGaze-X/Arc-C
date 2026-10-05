using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	internal class UIRAtlasAllocator : IDisposable
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x17000320")]
		public int maxAtlasSize
		{
			[Token(Token = "0x6000DA1")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x17000321")]
		public int maxImageWidth
		{
			[Token(Token = "0x6000DA2")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x17000322")]
		public int maxImageHeight
		{
			[Token(Token = "0x6000DA3")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00006C00 File Offset: 0x00004E00
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000323")]
		public int virtualWidth
		{
			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00006C18 File Offset: 0x00004E18
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000324")]
		public int virtualHeight
		{
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000DA7")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00006C30 File Offset: 0x00004E30
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000325")]
		public int physicalWidth
		{
			[Token(Token = "0x6000DA8")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000DA9")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00006C48 File Offset: 0x00004E48
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000326")]
		public int physicalHeight
		{
			[Token(Token = "0x6000DAA")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000DAB")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00006C60 File Offset: 0x00004E60
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000327")]
		private protected bool disposed
		{
			[Token(Token = "0x6000DAC")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DAD")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x5B16B30", Offset = "0x5B15730", VA = "0x185B16B30", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x5B169E0", Offset = "0x5B155E0", VA = "0x185B169E0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00006C78 File Offset: 0x00004E78
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x5B16BA0", Offset = "0x5B157A0", VA = "0x185B16BA0")]
		private static int GetLog2OfNextPower(int n)
		{
			return 0;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x5B17290", Offset = "0x5B15E90", VA = "0x185B17290")]
		public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x5B16C10", Offset = "0x5B15810", VA = "0x185B16C10")]
		public bool TryAllocate(int width, int height, out RectInt location)
		{
			return default(bool);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x5B16F70", Offset = "0x5B15B70", VA = "0x185B16F70")]
		private bool TryPartitionArea(UIRAtlasAllocator.AreaNode areaNode, int rowIndex, int rowHeight, int minWidth)
		{
			return default(bool);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x5B168D0", Offset = "0x5B154D0", VA = "0x185B168D0")]
		private void BuildAreas()
		{
		}

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x30")]
		private UIRAtlasAllocator.AreaNode m_FirstUnpartitionedArea;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x38")]
		private UIRAtlasAllocator.Row[] m_OpenRows;

		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x40")]
		private int m_1SidePadding;

		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0x44")]
		private int m_2SidePadding;

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker s_MarkerTryAllocate;

		// Token: 0x02000204 RID: 516
		[Token(Token = "0x2000204")]
		private class Row
		{
			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00006CC0 File Offset: 0x00004EC0
			// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000328")]
			public int offsetX
			{
				[Token(Token = "0x6000DB6")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000DB7")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00006CD8 File Offset: 0x00004ED8
			// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000329")]
			public int offsetY
			{
				[Token(Token = "0x6000DB8")]
				[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000DB9")]
				[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00006CF0 File Offset: 0x00004EF0
			// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700032A")]
			public int width
			{
				[Token(Token = "0x6000DBA")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000DBB")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700032B RID: 811
			// (set) Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700032B")]
			private int height
			{
				[Token(Token = "0x6000DBC")]
				[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000DBD RID: 3517 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x5B11EC0", Offset = "0x5B10AC0", VA = "0x185B11EC0")]
			public static UIRAtlasAllocator.Row Acquire(int offsetX, int offsetY, int width, int height)
			{
				return null;
			}

			// Token: 0x06000DBE RID: 3518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DBE")]
			[Address(RVA = "0x5B11F80", Offset = "0x5B10B80", VA = "0x185B11F80")]
			public void Release()
			{
			}

			// Token: 0x06000DBF RID: 3519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DBF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Row()
			{
			}

			// Token: 0x04000716 RID: 1814
			[Token(Token = "0x4000716")]
			[FieldOffset(Offset = "0x0")]
			private static ObjectPool<UIRAtlasAllocator.Row> s_Pool;

			// Token: 0x0400071B RID: 1819
			[Token(Token = "0x400071B")]
			[FieldOffset(Offset = "0x20")]
			public int Cursor;
		}

		// Token: 0x02000205 RID: 517
		[Token(Token = "0x2000205")]
		private class AreaNode
		{
			// Token: 0x06000DC1 RID: 3521 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6000DC1")]
			[Address(RVA = "0x5B02390", Offset = "0x5B00F90", VA = "0x185B02390")]
			public static UIRAtlasAllocator.AreaNode Acquire(RectInt rect)
			{
				return null;
			}

			// Token: 0x06000DC2 RID: 3522 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DC2")]
			[Address(RVA = "0x5B02530", Offset = "0x5B01130", VA = "0x185B02530")]
			public void Release()
			{
			}

			// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DC3")]
			[Address(RVA = "0x5B025B0", Offset = "0x5B011B0", VA = "0x185B025B0")]
			public void RemoveFromChain()
			{
			}

			// Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DC4")]
			[Address(RVA = "0x5B02450", Offset = "0x5B01050", VA = "0x185B02450")]
			public void AddAfter(UIRAtlasAllocator.AreaNode previous)
			{
			}

			// Token: 0x06000DC5 RID: 3525 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DC5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AreaNode()
			{
			}

			// Token: 0x0400071C RID: 1820
			[Token(Token = "0x400071C")]
			[FieldOffset(Offset = "0x0")]
			private static ObjectPool<UIRAtlasAllocator.AreaNode> s_Pool;

			// Token: 0x0400071D RID: 1821
			[Token(Token = "0x400071D")]
			[FieldOffset(Offset = "0x10")]
			public RectInt rect;

			// Token: 0x0400071E RID: 1822
			[Token(Token = "0x400071E")]
			[FieldOffset(Offset = "0x20")]
			public UIRAtlasAllocator.AreaNode previous;

			// Token: 0x0400071F RID: 1823
			[Token(Token = "0x400071F")]
			[FieldOffset(Offset = "0x28")]
			public UIRAtlasAllocator.AreaNode next;
		}
	}
}
