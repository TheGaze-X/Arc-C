using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public struct Ray : IFormattable
	{
		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x5936E40", Offset = "0x5935A40", VA = "0x185936E40")]
		public Ray(Vector3 origin, Vector3 direction)
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public Vector3 origin
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x5920CC0", Offset = "0x591F8C0", VA = "0x185920CC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x361F830", Offset = "0x361E430", VA = "0x18361F830")]
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002AD8 File Offset: 0x00000CD8
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		public Vector3 direction
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x5920CE0", Offset = "0x591F8E0", VA = "0x185920CE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x5936EA0", Offset = "0x5935AA0", VA = "0x185936EA0")]
			set
			{
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x5936BE0", Offset = "0x59357E0", VA = "0x185936BE0")]
		public Vector3 GetPoint(float distance)
		{
			return default(Vector3);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x5936C50", Offset = "0x5935850", VA = "0x185936C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x5936E30", Offset = "0x5935A30", VA = "0x185936E30")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x5936C60", Offset = "0x5935860", VA = "0x185936C60", Slot = "4")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x0")]
		private Vector3 m_Origin;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xC")]
		private Vector3 m_Direction;
	}
}
