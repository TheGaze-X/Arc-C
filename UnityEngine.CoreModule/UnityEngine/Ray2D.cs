using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public struct Ray2D : IFormattable
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x5936B60", Offset = "0x5935760", VA = "0x185936B60")]
		public Ray2D(Vector2 origin, Vector2 direction)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00002B08 File Offset: 0x00000D08
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public Vector2 origin
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x3BFB910", Offset = "0x3BFA510", VA = "0x183BFB910")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002B20 File Offset: 0x00000D20
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		public Vector2 direction
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x15795A0", Offset = "0x15781A0", VA = "0x1815795A0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x5936BA0", Offset = "0x59357A0", VA = "0x185936BA0")]
			set
			{
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x5936940", Offset = "0x5935540", VA = "0x185936940")]
		public Vector2 GetPoint(float distance)
		{
			return default(Vector2);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x5936980", Offset = "0x5935580", VA = "0x185936980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x5936970", Offset = "0x5935570", VA = "0x185936970")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x5936990", Offset = "0x5935590", VA = "0x185936990", Slot = "4")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_Origin;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x8")]
		private Vector2 m_Direction;
	}
}
