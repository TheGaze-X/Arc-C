using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A43 RID: 6723
	[Token(Token = "0x2001A43")]
	public abstract class VRoomGraphic : MonoBehaviour
	{
		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600A8A6 RID: 43174
		[Token(Token = "0x17001396")]
		public abstract Animator animator { [Token(Token = "0x600A8A6")] get; }

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x0600A8A7 RID: 43175 RVA: 0x00041598 File Offset: 0x0003F798
		// (set) Token: 0x0600A8A8 RID: 43176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001397")]
		private protected bool inited
		{
			[Token(Token = "0x600A8A7")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600A8A8")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600A8A9 RID: 43177
		[Token(Token = "0x17001398")]
		protected abstract float roomDepth { [Token(Token = "0x600A8A9")] get; }

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600A8AA RID: 43178 RVA: 0x000415B0 File Offset: 0x0003F7B0
		[Token(Token = "0x17001399")]
		protected virtual float innerDepth
		{
			[Token(Token = "0x600A8AA")]
			[Address(RVA = "0x32460D0", Offset = "0x3244CD0", VA = "0x1832460D0", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x000415C8 File Offset: 0x0003F7C8
		[Token(Token = "0x1700139A")]
		protected virtual float doorDepth
		{
			[Token(Token = "0x600A8AB")]
			[Address(RVA = "0x3245FD0", Offset = "0x3244BD0", VA = "0x183245FD0", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x0600A8AC RID: 43180 RVA: 0x000415E0 File Offset: 0x0003F7E0
		[Token(Token = "0x1700139B")]
		protected virtual float floorAltitude
		{
			[Token(Token = "0x600A8AC")]
			[Address(RVA = "0x3246020", Offset = "0x3244C20", VA = "0x183246020", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x0600A8AD RID: 43181
		[Token(Token = "0x1700139C")]
		protected abstract string doorId { [Token(Token = "0x600A8AD")] get; }

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x0600A8AE RID: 43182 RVA: 0x000415F8 File Offset: 0x0003F7F8
		// (set) Token: 0x0600A8AF RID: 43183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700139D")]
		private protected GridPosition roomSize
		{
			[Token(Token = "0x600A8AE")]
			[Address(RVA = "0x3147630", Offset = "0x3146230", VA = "0x183147630")]
			[CompilerGenerated]
			protected get
			{
				return default(GridPosition);
			}
			[Token(Token = "0x600A8AF")]
			[Address(RVA = "0x20BDE40", Offset = "0x20BCA40", VA = "0x1820BDE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x0600A8B0 RID: 43184 RVA: 0x00041610 File Offset: 0x0003F810
		[Token(Token = "0x1700139E")]
		protected Vector3 gridUnit
		{
			[Token(Token = "0x600A8B0")]
			[Address(RVA = "0x3246060", Offset = "0x3244C60", VA = "0x183246060")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x0600A8B1 RID: 43185 RVA: 0x00041628 File Offset: 0x0003F828
		[Token(Token = "0x1700139F")]
		protected virtual Vector3 wallThickness
		{
			[Token(Token = "0x600A8B1")]
			[Address(RVA = "0x3246190", Offset = "0x3244D90", VA = "0x183246190", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600A8B2 RID: 43186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013A0")]
		protected Transform parentHolder
		{
			[Token(Token = "0x600A8B2")]
			[Address(RVA = "0x3246160", Offset = "0x3244D60", VA = "0x183246160")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8B3")]
		[Address(RVA = "0x3245B80", Offset = "0x3244780", VA = "0x183245B80")]
		public void Init(VRoomGraphic.Options options, out VDoor leftDoor, out VDoor rightDoor)
		{
		}

		// Token: 0x0600A8B4 RID: 43188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8B4")]
		[Address(RVA = "0x3245C40", Offset = "0x3244840", VA = "0x183245C40", Slot = "11")]
		public virtual void UpdateDoor(bool hasDoor, SharedConsts.LeftOrRight side, ref VDoor door)
		{
		}

		// Token: 0x0600A8B5 RID: 43189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8B5")]
		[Address(RVA = "0x32457D0", Offset = "0x32443D0", VA = "0x1832457D0")]
		public void GetFloorArea(GridPosition gridSize, out Rect area, out float altitude)
		{
		}

		// Token: 0x0600A8B6 RID: 43190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8B6")]
		[Address(RVA = "0x32454C0", Offset = "0x32440C0", VA = "0x1832454C0")]
		public void GetBackwallArea(GridPosition gridSize, out Rect area, out float depth)
		{
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x00041640 File Offset: 0x0003F840
		[Token(Token = "0x600A8B7")]
		[Address(RVA = "0x3245310", Offset = "0x3243F10", VA = "0x183245310")]
		public GridPosition CalculateEstimatedFloorGridSize()
		{
			return default(GridPosition);
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x00041658 File Offset: 0x0003F858
		[Token(Token = "0x600A8B8")]
		[Address(RVA = "0x3245170", Offset = "0x3243D70", VA = "0x183245170")]
		public GridPosition CalculateEstimatedBackwallGridSize()
		{
			return default(GridPosition);
		}

		// Token: 0x0600A8B9 RID: 43193
		[Token(Token = "0x600A8B9")]
		protected abstract void OnInit(VRoomGraphic.Options options);

		// Token: 0x0600A8BA RID: 43194 RVA: 0x00041670 File Offset: 0x0003F870
		[Token(Token = "0x600A8BA")]
		[Address(RVA = "0x3245A80", Offset = "0x3244680", VA = "0x183245A80")]
		protected Rect GetRawFloorBoundary()
		{
			return default(Rect);
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x00041688 File Offset: 0x0003F888
		[Token(Token = "0x600A8BB")]
		[Address(RVA = "0x3245970", Offset = "0x3244570", VA = "0x183245970", Slot = "13")]
		protected virtual Rect GetFloorBoundary()
		{
			return default(Rect);
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x000416A0 File Offset: 0x0003F8A0
		[Token(Token = "0x600A8BC")]
		[Address(RVA = "0x3245660", Offset = "0x3244260", VA = "0x183245660", Slot = "14")]
		protected virtual Rect GetBackwallBoundary()
		{
			return default(Rect);
		}

		// Token: 0x0600A8BD RID: 43197
		[Token(Token = "0x600A8BD")]
		protected abstract bool FetchDoorPos(bool hasDoor, SharedConsts.LeftOrRight side, out Vector3 worldPos);

		// Token: 0x0600A8BE RID: 43198
		[Token(Token = "0x600A8BE")]
		protected abstract void LocateDoor(VDoor door, Vector3 localPos, SharedConsts.LeftOrRight side);

		// Token: 0x0600A8BF RID: 43199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8BF")]
		[Address(RVA = "0x3245F80", Offset = "0x3244B80", VA = "0x183245F80")]
		private void _InitDoors(bool hasLeftDoor, bool hasRightDoor, out VDoor leftDoor, out VDoor rightDoor)
		{
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8C0")]
		[Address(RVA = "0x3245D40", Offset = "0x3244940", VA = "0x183245D40")]
		private void _CreateDoor(bool hasDoor, SharedConsts.LeftOrRight side, out VDoor door)
		{
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8C1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected VRoomGraphic()
		{
		}

		// Token: 0x02001A44 RID: 6724
		[Token(Token = "0x2001A44")]
		public struct Options
		{
			// Token: 0x0400A0D7 RID: 41175
			[Token(Token = "0x400A0D7")]
			[FieldOffset(Offset = "0x0")]
			public GridPosition roomSize;

			// Token: 0x0400A0D8 RID: 41176
			[Token(Token = "0x400A0D8")]
			[FieldOffset(Offset = "0x8")]
			public bool hasLeftDoor;

			// Token: 0x0400A0D9 RID: 41177
			[Token(Token = "0x400A0D9")]
			[FieldOffset(Offset = "0x9")]
			public bool hasRightDoor;
		}
	}
}
