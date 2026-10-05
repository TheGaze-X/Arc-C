using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A45 RID: 6725
	[Token(Token = "0x2001A45")]
	public class VRoomMeshGraphic : VRoomGraphic
	{
		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x0600A8C2 RID: 43202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013A1")]
		public override Animator animator
		{
			[Token(Token = "0x600A8C2")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x0600A8C3 RID: 43203 RVA: 0x000416B8 File Offset: 0x0003F8B8
		[Token(Token = "0x170013A2")]
		protected override float floorAltitude
		{
			[Token(Token = "0x600A8C3")]
			[Address(RVA = "0x3246C20", Offset = "0x3245820", VA = "0x183246C20", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x0600A8C4 RID: 43204 RVA: 0x000416D0 File Offset: 0x0003F8D0
		[Token(Token = "0x170013A3")]
		protected override float roomDepth
		{
			[Token(Token = "0x600A8C4")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500", Slot = "5")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x0600A8C5 RID: 43205 RVA: 0x000416E8 File Offset: 0x0003F8E8
		[Token(Token = "0x170013A4")]
		protected override Vector3 wallThickness
		{
			[Token(Token = "0x600A8C5")]
			[Address(RVA = "0x3246C70", Offset = "0x3245870", VA = "0x183246C70", Slot = "10")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x0600A8C6 RID: 43206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013A5")]
		protected override string doorId
		{
			[Token(Token = "0x600A8C6")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8C7")]
		[Address(RVA = "0x32468D0", Offset = "0x32454D0", VA = "0x1832468D0", Slot = "11")]
		public override void UpdateDoor(bool hasDoor, SharedConsts.LeftOrRight side, ref VDoor door)
		{
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8C8")]
		[Address(RVA = "0x3246690", Offset = "0x3245290", VA = "0x183246690", Slot = "12")]
		protected override void OnInit(VRoomGraphic.Options options)
		{
		}

		// Token: 0x0600A8C9 RID: 43209 RVA: 0x00041700 File Offset: 0x0003F900
		[Token(Token = "0x600A8C9")]
		[Address(RVA = "0x3246200", Offset = "0x3244E00", VA = "0x183246200", Slot = "15")]
		protected override bool FetchDoorPos(bool hasDoor, SharedConsts.LeftOrRight side, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x0600A8CA RID: 43210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8CA")]
		[Address(RVA = "0x32465C0", Offset = "0x32451C0", VA = "0x1832465C0", Slot = "16")]
		protected override void LocateDoor(VDoor door, Vector3 worldPos, SharedConsts.LeftOrRight side)
		{
		}

		// Token: 0x0600A8CB RID: 43211 RVA: 0x00041718 File Offset: 0x0003F918
		[Token(Token = "0x600A8CB")]
		[Address(RVA = "0x3246310", Offset = "0x3244F10", VA = "0x183246310", Slot = "13")]
		protected override Rect GetFloorBoundary()
		{
			return default(Rect);
		}

		// Token: 0x0600A8CC RID: 43212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8CC")]
		[Address(RVA = "0x3246690", Offset = "0x3245290", VA = "0x183246690")]
		private void _ResizeMeshToMatchSize()
		{
		}

		// Token: 0x0600A8CD RID: 43213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A8CD")]
		[Address(RVA = "0x3246A40", Offset = "0x3245640", VA = "0x183246A40")]
		private Transform _GetDoorPlaceholder(SharedConsts.LeftOrRight side)
		{
			return null;
		}

		// Token: 0x0600A8CE RID: 43214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8CE")]
		[Address(RVA = "0x3246B30", Offset = "0x3245730", VA = "0x183246B30")]
		public VRoomMeshGraphic()
		{
		}

		// Token: 0x0400A0DA RID: 41178
		[Token(Token = "0x400A0DA")]
		private const string NAME_LDOOR = "LDoor";

		// Token: 0x0400A0DB RID: 41179
		[Token(Token = "0x400A0DB")]
		private const string NAME_RDOOR = "RDoor";

		// Token: 0x0400A0DC RID: 41180
		[Token(Token = "0x400A0DC")]
		private const string DEFAULT_DOOR_ID = "room_door_01";

		// Token: 0x0400A0DD RID: 41181
		[Token(Token = "0x400A0DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public float _roomDepth;

		// Token: 0x0400A0DE RID: 41182
		[Token(Token = "0x400A0DE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public float _floorOffset;

		// Token: 0x0400A0DF RID: 41183
		[Token(Token = "0x400A0DF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public Rect _floorValidRegion;

		// Token: 0x0400A0E0 RID: 41184
		[Token(Token = "0x400A0E0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public Vector3 _walkThicknessScale;

		// Token: 0x0400A0E1 RID: 41185
		[Token(Token = "0x400A0E1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public bool _autoScaleMesh;

		// Token: 0x0400A0E2 RID: 41186
		[Token(Token = "0x400A0E2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("_meshSize")]
		public Vector3 _builtInSize;

		// Token: 0x0400A0E3 RID: 41187
		[Token(Token = "0x400A0E3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Door")]
		public Transform _leftDoorPlaceholder;

		// Token: 0x0400A0E4 RID: 41188
		[Token(Token = "0x400A0E4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Door")]
		public Transform _rightDoorPlaceholder;

		// Token: 0x0400A0E5 RID: 41189
		[Token(Token = "0x400A0E5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400A0E6 RID: 41190
		[Token(Token = "0x400A0E6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _doorId;
	}
}
