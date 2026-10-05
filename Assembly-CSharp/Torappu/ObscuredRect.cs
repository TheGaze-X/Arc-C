using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200112D RID: 4397
	[Token(Token = "0x200112D")]
	public struct ObscuredRect
	{
		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06006EFA RID: 28410 RVA: 0x00032418 File Offset: 0x00030618
		[Token(Token = "0x17000D2D")]
		public Vector2 center
		{
			[Token(Token = "0x6006EFA")]
			[Address(RVA = "0x2108A90", Offset = "0x2107690", VA = "0x182108A90")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06006EFB RID: 28411 RVA: 0x00032430 File Offset: 0x00030630
		[Token(Token = "0x17000D2E")]
		public Vector2 size
		{
			[Token(Token = "0x6006EFB")]
			[Address(RVA = "0x2108BE0", Offset = "0x21077E0", VA = "0x182108BE0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06006EFC RID: 28412 RVA: 0x00032448 File Offset: 0x00030648
		[Token(Token = "0x17000D2F")]
		public ObscuredFloat width
		{
			[Token(Token = "0x6006EFC")]
			[Address(RVA = "0x2108C90", Offset = "0x2107890", VA = "0x182108C90")]
			get
			{
				return default(ObscuredFloat);
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06006EFD RID: 28413 RVA: 0x00032460 File Offset: 0x00030660
		[Token(Token = "0x17000D30")]
		public ObscuredFloat height
		{
			[Token(Token = "0x6006EFD")]
			[Address(RVA = "0x2108BC0", Offset = "0x21077C0", VA = "0x182108BC0")]
			get
			{
				return default(ObscuredFloat);
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06006EFE RID: 28414 RVA: 0x00032478 File Offset: 0x00030678
		[Token(Token = "0x17000D31")]
		public ObscuredFloat x
		{
			[Token(Token = "0x6006EFE")]
			[Address(RVA = "0x2108CB0", Offset = "0x21078B0", VA = "0x182108CB0")]
			get
			{
				return default(ObscuredFloat);
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06006EFF RID: 28415 RVA: 0x00032490 File Offset: 0x00030690
		[Token(Token = "0x17000D32")]
		public ObscuredFloat y
		{
			[Token(Token = "0x6006EFF")]
			[Address(RVA = "0x15F2880", Offset = "0x15F1480", VA = "0x1815F2880")]
			get
			{
				return default(ObscuredFloat);
			}
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F00")]
		[Address(RVA = "0x21088B0", Offset = "0x21074B0", VA = "0x1821088B0")]
		public ObscuredRect(Vector2 position, Vector2 size)
		{
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F01")]
		[Address(RVA = "0x2108990", Offset = "0x2107590", VA = "0x182108990")]
		public ObscuredRect(float x, float y, float width, float height)
		{
		}

		// Token: 0x04005E35 RID: 24117
		[Token(Token = "0x4005E35")]
		[FieldOffset(Offset = "0x0")]
		private ObscuredFloat m_xMin;

		// Token: 0x04005E36 RID: 24118
		[Token(Token = "0x4005E36")]
		[FieldOffset(Offset = "0x18")]
		private ObscuredFloat m_yMin;

		// Token: 0x04005E37 RID: 24119
		[Token(Token = "0x4005E37")]
		[FieldOffset(Offset = "0x30")]
		private ObscuredFloat m_width;

		// Token: 0x04005E38 RID: 24120
		[Token(Token = "0x4005E38")]
		[FieldOffset(Offset = "0x48")]
		private ObscuredFloat m_height;
	}
}
