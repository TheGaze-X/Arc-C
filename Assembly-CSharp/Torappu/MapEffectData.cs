using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x020010E1 RID: 4321
	[Token(Token = "0x20010E1")]
	[Serializable]
	public class MapEffectData
	{
		// Token: 0x06006E83 RID: 28291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E83")]
		[Address(RVA = "0x21076D0", Offset = "0x21062D0", VA = "0x1821076D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E84 RID: 28292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E84")]
		[Address(RVA = "0x2107630", Offset = "0x2106230", VA = "0x182107630")]
		public MapEffectData DeepClone()
		{
			return null;
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E85")]
		[Address(RVA = "0x21077B0", Offset = "0x21063B0", VA = "0x1821077B0")]
		public MapEffectData()
		{
		}

		// Token: 0x04005C9B RID: 23707
		[Token(Token = "0x4005C9B")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x04005C9C RID: 23708
		[Token(Token = "0x4005C9C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 offset;

		// Token: 0x04005C9D RID: 23709
		[Token(Token = "0x4005C9D")]
		[FieldOffset(Offset = "0x24")]
		public SharedConsts.Direction direction;
	}
}
