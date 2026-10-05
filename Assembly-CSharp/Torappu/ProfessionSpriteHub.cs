using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000571 RID: 1393
	[Token(Token = "0x2000571")]
	public class ProfessionSpriteHub : MonoISpriteHub
	{
		// Token: 0x06005B9A RID: 23450 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0x1AF8E00", Offset = "0x1AF7A00", VA = "0x181AF8E00")]
		public bool TryGetSprite(ProfessionCategory key, out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9B")]
		[Address(RVA = "0x1AF8FA0", Offset = "0x1AF7BA0", VA = "0x181AF8FA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B9C")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public ProfessionSpriteHub()
		{
		}

		// Token: 0x04002128 RID: 8488
		[Token(Token = "0x4002128")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ProfessionSpriteHub.DataPair[] _sprites;

		// Token: 0x04002129 RID: 8489
		[Token(Token = "0x4002129")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ProfessionCategory, Sprite> m_spriteHub;

		// Token: 0x02000572 RID: 1394
		[Token(Token = "0x2000572")]
		[Serializable]
		private struct DataPair
		{
			// Token: 0x06005B9D RID: 23453 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B9D")]
			[Address(RVA = "0x1AED730", Offset = "0x1AEC330", VA = "0x181AED730", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400212A RID: 8490
			[Token(Token = "0x400212A")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory key;

			// Token: 0x0400212B RID: 8491
			[Token(Token = "0x400212B")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;
		}
	}
}
