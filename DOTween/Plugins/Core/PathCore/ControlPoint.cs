using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	[Serializable]
	public struct ControlPoint
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x3746830", Offset = "0x3745430", VA = "0x183746830")]
		public ControlPoint(Vector3 a, Vector3 b)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x3746850", Offset = "0x3745450", VA = "0x183746850")]
		public static ControlPoint operator +(ControlPoint cp, Vector3 v)
		{
			return default(ControlPoint);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x3746600", Offset = "0x3745200", VA = "0x183746600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 a;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 b;
	}
}
