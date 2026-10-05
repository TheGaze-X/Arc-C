using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[RequiredByNativeCode]
	[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
	[Serializable]
	public class Tile : TileBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public Sprite sprite
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public Color color
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5A06280", Offset = "0x5A04E80", VA = "0x185A06280")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x4A9EF00", Offset = "0x4A9DB00", VA = "0x184A9EF00")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public Matrix4x4 transform
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x5A06290", Offset = "0x5A04E90", VA = "0x185A06290")]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x5A062C0", Offset = "0x5A04EC0", VA = "0x185A062C0")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		public GameObject gameObject
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x5997760", Offset = "0x5996360", VA = "0x185997760")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		public TileFlags flags
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x59B7930", Offset = "0x59B6530", VA = "0x1859B7930")]
			get
			{
				return TileFlags.None;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2B0B050", Offset = "0x2B09C50", VA = "0x182B0B050")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public Tile.ColliderType colliderType
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x5A06270", Offset = "0x5A04E70", VA = "0x185A06270")]
			get
			{
				return Tile.ColliderType.None;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x557C490", Offset = "0x557B090", VA = "0x18557C490")]
			set
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5A06090", Offset = "0x5A04C90", VA = "0x185A06090", Slot = "5")]
		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5A061F0", Offset = "0x5A04DF0", VA = "0x185A061F0")]
		public Tile()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_Sprite;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color m_Color;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Matrix4x4 m_Transform;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject m_InstancedGameObject;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TileFlags m_Flags;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Tile.ColliderType m_ColliderType;

		// Token: 0x02000004 RID: 4
		[Token(Token = "0x2000004")]
		public enum ColliderType
		{
			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			None,
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			Sprite,
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			Grid
		}
	}
}
