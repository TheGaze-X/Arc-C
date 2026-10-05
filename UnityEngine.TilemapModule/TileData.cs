using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[RequiredByNativeCode]
	[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
	public struct TileData
	{
		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public Sprite sprite
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x5A05FE0", Offset = "0x5A04BE0", VA = "0x185A05FE0")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public Color color
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5892F90", Offset = "0x5891B90", VA = "0x185892F90")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public Matrix4x4 transform
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x5A06070", Offset = "0x5A04C70", VA = "0x185A06070")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public GameObject gameObject
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x5A05F50", Offset = "0x5A04B50", VA = "0x185A05F50")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public TileFlags flags
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x4A5BF80", Offset = "0x4A5AB80", VA = "0x184A5BF80")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public Tile.ColliderType colliderType
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x541D100", Offset = "0x541BD00", VA = "0x18541D100")]
			set
			{
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5A05D10", Offset = "0x5A04910", VA = "0x185A05D10")]
		private static TileData CreateDefault()
		{
			return default(TileData);
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		private int m_Sprite;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x4")]
		private Color m_Color;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x14")]
		private Matrix4x4 m_Transform;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x54")]
		private int m_GameObject;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x58")]
		private TileFlags m_Flags;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x5C")]
		private Tile.ColliderType m_ColliderType;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly TileData Default;
	}
}
