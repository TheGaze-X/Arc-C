using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A3E RID: 6718
	[Token(Token = "0x2001A3E")]
	public abstract class VGridPlane : MonoBehaviour
	{
		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x0600A878 RID: 43128 RVA: 0x00041448 File Offset: 0x0003F648
		// (set) Token: 0x0600A879 RID: 43129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700138B")]
		[Inspect]
		[ReadOnly]
		public GridPosition gridSize
		{
			[Token(Token = "0x600A878")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return default(GridPosition);
			}
			[Token(Token = "0x600A879")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600A87A RID: 43130 RVA: 0x00041460 File Offset: 0x0003F660
		// (set) Token: 0x0600A87B RID: 43131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700138C")]
		public Vector2 gridUnit
		{
			[Token(Token = "0x600A87A")]
			[Address(RVA = "0x168B8C0", Offset = "0x168A4C0", VA = "0x18168B8C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600A87B")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600A87C RID: 43132 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A87D RID: 43133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700138D")]
		public GridMap gridMap
		{
			[Token(Token = "0x600A87C")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A87D")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x0600A87E RID: 43134 RVA: 0x00041478 File Offset: 0x0003F678
		// (set) Token: 0x0600A87F RID: 43135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700138E")]
		public Rect bounds
		{
			[Token(Token = "0x600A87E")]
			[Address(RVA = "0x4ED6A0", Offset = "0x4EC2A0", VA = "0x1804ED6A0")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600A87F")]
			[Address(RVA = "0x4EEA20", Offset = "0x4ED620", VA = "0x1804EEA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x0600A880 RID: 43136 RVA: 0x00041490 File Offset: 0x0003F690
		[Token(Token = "0x1700138F")]
		public Vector3 worldCenter
		{
			[Token(Token = "0x600A880")]
			[Address(RVA = "0x3244980", Offset = "0x3243580", VA = "0x183244980")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x0600A881 RID: 43137 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A882 RID: 43138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001390")]
		private protected VRoom room
		{
			[Token(Token = "0x600A881")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600A882")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x0600A883 RID: 43139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001391")]
		protected RoomSlotModel model
		{
			[Token(Token = "0x600A883")]
			[Address(RVA = "0x3244900", Offset = "0x3243500", VA = "0x183244900")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x0600A884 RID: 43140 RVA: 0x000414A8 File Offset: 0x0003F6A8
		// (set) Token: 0x0600A885 RID: 43141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001392")]
		private protected bool inited
		{
			[Token(Token = "0x600A884")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600A885")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600A886 RID: 43142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A886")]
		[Address(RVA = "0x32444E0", Offset = "0x32430E0", VA = "0x1832444E0")]
		public void Init(VRoom room, VGridPlane.Options options)
		{
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A887")]
		[Address(RVA = "0x32446B0", Offset = "0x32432B0", VA = "0x1832446B0")]
		public void SetGridPos(VRoom.Object obj, Vector2 gridPos)
		{
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x000414C0 File Offset: 0x0003F6C0
		[Token(Token = "0x600A888")]
		[Address(RVA = "0x32441E0", Offset = "0x3242DE0", VA = "0x1832441E0")]
		public Vector2 GetGridPos(Transform obj)
		{
			return default(Vector2);
		}

		// Token: 0x0600A889 RID: 43145
		[Token(Token = "0x600A889")]
		public abstract Bounds GetLocalBounds3D(float thickness = 0f);

		// Token: 0x0600A88A RID: 43146
		[Token(Token = "0x600A88A")]
		public abstract Bounds GetLocalBounds3D(GridPosition grid, float thickness = 0f);

		// Token: 0x0600A88B RID: 43147 RVA: 0x000414D8 File Offset: 0x0003F6D8
		[Token(Token = "0x600A88B")]
		[Address(RVA = "0x32442C0", Offset = "0x3242EC0", VA = "0x1832442C0")]
		public Bounds GetWorldBounds3D(float thickness = 0f)
		{
			return default(Bounds);
		}

		// Token: 0x0600A88C RID: 43148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A88C")]
		[Address(RVA = "0x3244140", Offset = "0x3242D40", VA = "0x183244140", Slot = "6")]
		protected virtual GridMap CreateGridMap(VGridPlane.Options options)
		{
			return null;
		}

		// Token: 0x0600A88D RID: 43149
		[Token(Token = "0x600A88D")]
		protected abstract void ResetLocation(float offset, Rect area);

		// Token: 0x0600A88E RID: 43150 RVA: 0x000414F0 File Offset: 0x0003F6F0
		[Token(Token = "0x600A88E")]
		[Address(RVA = "0x3244860", Offset = "0x3243460", VA = "0x183244860")]
		public Vector2 WorldPosToGridPos(Vector3 worldPosition)
		{
			return default(Vector2);
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x00041508 File Offset: 0x0003F708
		[Token(Token = "0x600A88F")]
		[Address(RVA = "0x3244420", Offset = "0x3243020", VA = "0x183244420")]
		public Vector3 GridPosToWorldPos(Vector2 gridPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600A890 RID: 43152
		[Token(Token = "0x600A890")]
		protected abstract Vector2 LocalPosToGridPos(Vector3 localPosition);

		// Token: 0x0600A891 RID: 43153
		[Token(Token = "0x600A891")]
		protected abstract Vector3 GridPosToLocalPos(Vector2 gridPos);

		// Token: 0x0600A892 RID: 43154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A892")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0600A893 RID: 43155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A893")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected VGridPlane()
		{
		}

		// Token: 0x02001A3F RID: 6719
		[Token(Token = "0x2001A3F")]
		public struct Options
		{
			// Token: 0x0400A0B3 RID: 41139
			[Token(Token = "0x400A0B3")]
			[FieldOffset(Offset = "0x0")]
			public Rect area;

			// Token: 0x0400A0B4 RID: 41140
			[Token(Token = "0x400A0B4")]
			[FieldOffset(Offset = "0x10")]
			public float offset;

			// Token: 0x0400A0B5 RID: 41141
			[Token(Token = "0x400A0B5")]
			[FieldOffset(Offset = "0x14")]
			public GridPosition gridSize;

			// Token: 0x0400A0B6 RID: 41142
			[Token(Token = "0x400A0B6")]
			[FieldOffset(Offset = "0x1C")]
			public bool ignoreBuiltInObstacles;

			// Token: 0x0400A0B7 RID: 41143
			[Token(Token = "0x400A0B7")]
			[FieldOffset(Offset = "0x20")]
			public BuildingData.ObstacleRect[] dynamicObstacleRects;
		}
	}
}
