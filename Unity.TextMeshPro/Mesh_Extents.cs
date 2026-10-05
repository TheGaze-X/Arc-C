using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[Serializable]
	public struct Mesh_Extents
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1787730", Offset = "0x1786330", VA = "0x181787730")]
		public Mesh_Extents(Vector2 min, Vector2 max)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x5881930", Offset = "0x5880530", VA = "0x185881930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 min;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 max;
	}
}
