using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
	[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct RaycastHit2D
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x17000009")]
		public Vector2 point
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x15795A0", Offset = "0x15781A0", VA = "0x1815795A0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x1700000A")]
		public Vector2 normal
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x26FA000", Offset = "0x26F8C00", VA = "0x1826FA000")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x1700000B")]
		public float distance
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x5917F60", Offset = "0x5916B60", VA = "0x185917F60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public Collider2D collider
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x59C6540", Offset = "0x59C5140", VA = "0x1859C6540")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public Rigidbody2D rigidbody
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x59C6620", Offset = "0x59C5220", VA = "0x1859C6620")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		public Transform transform
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x59C66D0", Offset = "0x59C52D0", VA = "0x1859C66D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x59C67B0", Offset = "0x59C53B0", VA = "0x1859C67B0")]
		public static implicit operator bool(RaycastHit2D hit)
		{
			return default(bool);
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("centroid")]
		private Vector2 m_Centroid;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("point")]
		private Vector2 m_Point;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x10")]
		[NativeName("normal")]
		private Vector2 m_Normal;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x18")]
		[NativeName("distance")]
		private float m_Distance;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x1C")]
		[NativeName("fraction")]
		private float m_Fraction;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x20")]
		[NativeName("collider")]
		private int m_Collider;
	}
}
