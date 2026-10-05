using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200050C RID: 1292
	[Token(Token = "0x200050C")]
	public class SpriteHub : MonoISpriteHub
	{
		// Token: 0x06004EF5 RID: 20213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EF5")]
		[Address(RVA = "0x188FAB0", Offset = "0x188E6B0", VA = "0x18188FAB0")]
		public IEnumerator<KeyValuePair<string, Sprite>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x0002E260 File Offset: 0x0002C460
		[Token(Token = "0x6004EF6")]
		[Address(RVA = "0x188FB50", Offset = "0x188E750", VA = "0x18188FB50")]
		public bool TryGetSprite(string id, out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF7")]
		[Address(RVA = "0x188FC20", Offset = "0x188E820", VA = "0x18188FC20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF8")]
		[Address(RVA = "0x1881530", Offset = "0x1880130", VA = "0x181881530")]
		public SpriteHub()
		{
		}

		// Token: 0x04001319 RID: 4889
		[Token(Token = "0x4001319")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _caseSensitive;

		// Token: 0x0400131A RID: 4890
		[Token(Token = "0x400131A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite[] _sprites;

		// Token: 0x0400131B RID: 4891
		[Token(Token = "0x400131B")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Sprite> m_spriteHub;
	}
}
