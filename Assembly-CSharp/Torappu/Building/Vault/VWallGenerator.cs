using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A6D RID: 6765
	[Token(Token = "0x2001A6D")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class VWallGenerator : MonoBehaviour
	{
		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x0600AA7C RID: 43644 RVA: 0x00041FE8 File Offset: 0x000401E8
		// (set) Token: 0x0600AA7D RID: 43645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001411")]
		public bool isEnabled
		{
			[Token(Token = "0x600AA7C")]
			[Address(RVA = "0xFD66E0", Offset = "0xFD52E0", VA = "0x180FD66E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AA7D")]
			[Address(RVA = "0x326A2F0", Offset = "0x3268EF0", VA = "0x18326A2F0")]
			private set
			{
			}
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA7E")]
		[Address(RVA = "0x3269660", Offset = "0x3268260", VA = "0x183269660")]
		public void Generate(List<RoomSlotModel> layout, Rect boundingBox)
		{
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA7F")]
		[Address(RVA = "0x32697B0", Offset = "0x32683B0", VA = "0x1832697B0")]
		private Mesh _CreateMesh(IList<Rect> bounds, Rect boundingBox)
		{
			return null;
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA80")]
		[Address(RVA = "0x3269BC0", Offset = "0x32687C0", VA = "0x183269BC0")]
		private List<Rect> _GenerateEmptySlots(List<RoomSlotModel> layout, Rect boundingBox)
		{
			return null;
		}

		// Token: 0x0600AA81 RID: 43649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA81")]
		[Address(RVA = "0x3269570", Offset = "0x3268170", VA = "0x183269570")]
		private void Awake()
		{
		}

		// Token: 0x0600AA82 RID: 43650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA82")]
		[Address(RVA = "0x326A270", Offset = "0x3268E70", VA = "0x18326A270")]
		public VWallGenerator()
		{
		}

		// Token: 0x0400A2C7 RID: 41671
		[Token(Token = "0x400A2C7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material _wallMaterial;

		// Token: 0x0400A2C8 RID: 41672
		[Token(Token = "0x400A2C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _paddingX;

		// Token: 0x0400A2C9 RID: 41673
		[Token(Token = "0x400A2C9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _paddingY;

		// Token: 0x0400A2CA RID: 41674
		[Token(Token = "0x400A2CA")]
		[FieldOffset(Offset = "0x28")]
		private MeshFilter m_meshFilter;

		// Token: 0x0400A2CB RID: 41675
		[Token(Token = "0x400A2CB")]
		[FieldOffset(Offset = "0x30")]
		private MeshRenderer m_meshRenderer;

		// Token: 0x0400A2CC RID: 41676
		[Token(Token = "0x400A2CC")]
		[FieldOffset(Offset = "0x38")]
		private EasyMeshGenerator m_generator;

		// Token: 0x02001A6E RID: 6766
		[Token(Token = "0x2001A6E")]
		private struct BoundaryItem : IComparable<VWallGenerator.BoundaryItem>
		{
			// Token: 0x0600AA83 RID: 43651 RVA: 0x00042000 File Offset: 0x00040200
			[Token(Token = "0x600AA83")]
			[Address(RVA = "0x3251500", Offset = "0x3250100", VA = "0x183251500", Slot = "4")]
			public int CompareTo(VWallGenerator.BoundaryItem other)
			{
				return 0;
			}

			// Token: 0x0400A2CD RID: 41677
			[Token(Token = "0x400A2CD")]
			[FieldOffset(Offset = "0x0")]
			public RoomSlotModel room;

			// Token: 0x0400A2CE RID: 41678
			[Token(Token = "0x400A2CE")]
			[FieldOffset(Offset = "0x8")]
			public VWallGenerator.BoundaryItem.BoundaryType boundaryType;

			// Token: 0x0400A2CF RID: 41679
			[Token(Token = "0x400A2CF")]
			[FieldOffset(Offset = "0xC")]
			public float yRow;

			// Token: 0x02001A6F RID: 6767
			[Token(Token = "0x2001A6F")]
			public enum BoundaryType
			{
				// Token: 0x0400A2D1 RID: 41681
				[Token(Token = "0x400A2D1")]
				BEGIN,
				// Token: 0x0400A2D2 RID: 41682
				[Token(Token = "0x400A2D2")]
				END
			}
		}

		// Token: 0x02001A70 RID: 6768
		[Token(Token = "0x2001A70")]
		private struct RoomWrapper : IComparable<VWallGenerator.RoomWrapper>
		{
			// Token: 0x0600AA84 RID: 43652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA84")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public RoomWrapper(RoomSlotModel room)
			{
			}

			// Token: 0x0600AA85 RID: 43653 RVA: 0x00042018 File Offset: 0x00040218
			[Token(Token = "0x600AA85")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			public static implicit operator VWallGenerator.RoomWrapper(RoomSlotModel room)
			{
				return default(VWallGenerator.RoomWrapper);
			}

			// Token: 0x0600AA86 RID: 43654 RVA: 0x00042030 File Offset: 0x00040230
			[Token(Token = "0x600AA86")]
			[Address(RVA = "0x32516B0", Offset = "0x32502B0", VA = "0x1832516B0", Slot = "4")]
			public int CompareTo(VWallGenerator.RoomWrapper other)
			{
				return 0;
			}

			// Token: 0x0400A2D3 RID: 41683
			[Token(Token = "0x400A2D3")]
			[FieldOffset(Offset = "0x0")]
			public RoomSlotModel room;
		}
	}
}
