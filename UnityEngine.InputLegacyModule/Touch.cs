using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[NativeHeader("Runtime/Input/InputBindings.h")]
	public struct Touch
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public int fingerId
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000002")]
		public Vector2 position
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x15ABE60", Offset = "0x15AAA60", VA = "0x1815ABE60")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x15ABE80", Offset = "0x15AAA80", VA = "0x1815ABE80")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000003")]
		public Vector2 rawPosition
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x59BA3F0", Offset = "0x59B8FF0", VA = "0x1859BA3F0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x59BA420", Offset = "0x59B9020", VA = "0x1859BA420")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000004")]
		public Vector2 deltaPosition
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x56C9550", Offset = "0x56C8150", VA = "0x1856C9550")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x59BA410", Offset = "0x59B9010", VA = "0x1859BA410")]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x17000005")]
		public float deltaTime
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x59BA3A0", Offset = "0x59B8FA0", VA = "0x1859BA3A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x17000006")]
		public int tapCount
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x5958CC0", Offset = "0x59578C0", VA = "0x185958CC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x17000007")]
		public TouchPhase phase
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x59BA3B0", Offset = "0x59B8FB0", VA = "0x1859BA3B0")]
			get
			{
				return TouchPhase.Began;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x17000008")]
		public float pressure
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x59BA3C0", Offset = "0x59B8FC0", VA = "0x1859BA3C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x17000009")]
		public float maximumPossiblePressure
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x5911BA0", Offset = "0x59107A0", VA = "0x185911BA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x1700000A")]
		public TouchType type
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x59649A0", Offset = "0x59635A0", VA = "0x1859649A0")]
			get
			{
				return TouchType.Direct;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x1700000B")]
		public float altitudeAngle
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x59BA380", Offset = "0x59B8F80", VA = "0x1859BA380")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002158 File Offset: 0x00000358
		[Token(Token = "0x1700000C")]
		public float azimuthAngle
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x59BA390", Offset = "0x59B8F90", VA = "0x1859BA390")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002170 File Offset: 0x00000370
		[Token(Token = "0x1700000D")]
		public float radius
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x59BA3E0", Offset = "0x59B8FE0", VA = "0x1859BA3E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002188 File Offset: 0x00000388
		[Token(Token = "0x1700000E")]
		public float radiusVariance
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x59BA3D0", Offset = "0x59B8FD0", VA = "0x1859BA3D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		private int m_FingerId;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x4")]
		private Vector2 m_Position;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0xC")]
		private Vector2 m_RawPosition;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 m_PositionDelta;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x1C")]
		private float m_TimeDelta;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		private int m_TapCount;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x24")]
		private TouchPhase m_Phase;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		private TouchType m_Type;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x2C")]
		private float m_Pressure;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x30")]
		private float m_maximumPossiblePressure;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x34")]
		private float m_Radius;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x38")]
		private float m_RadiusVariance;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x3C")]
		private float m_AltitudeAngle;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x40")]
		private float m_AzimuthAngle;
	}
}
