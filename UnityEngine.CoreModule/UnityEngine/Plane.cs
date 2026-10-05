using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[UsedByNativeCode]
	public struct Plane : IFormattable
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x17000087")]
		public Vector3 normal
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x5920CC0", Offset = "0x591F8C0", VA = "0x185920CC0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x17000088")]
		public float distance
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x5917F50", Offset = "0x5916B50", VA = "0x185917F50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x5935F70", Offset = "0x5934B70", VA = "0x185935F70")]
		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x5936010", Offset = "0x5934C10", VA = "0x185936010")]
		public Plane(Vector3 inNormal, float d)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x5936070", Offset = "0x5934C70", VA = "0x185936070")]
		public Plane(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5935C00", Offset = "0x5934800", VA = "0x185935C00")]
		public float GetDistanceToPoint(Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x5935C50", Offset = "0x5934850", VA = "0x185935C50")]
		public bool Raycast(Ray ray, out float enter)
		{
			return default(bool);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x5935F60", Offset = "0x5934B60", VA = "0x185935F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x5935D90", Offset = "0x5934990", VA = "0x185935D90", Slot = "4")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		internal const int size = 16;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x0")]
		private Vector3 m_Normal;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0xC")]
		private float m_Distance;
	}
}
