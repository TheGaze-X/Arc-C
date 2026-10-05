using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.DynamicSprite
{
	// Token: 0x02005A55 RID: 23125
	[Token(Token = "0x2005A55")]
	public class DynamicSpriteHolder : MonoBehaviour
	{
		// Token: 0x06021A89 RID: 137865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A89")]
		[Address(RVA = "0x1C1A950", Offset = "0x1C19550", VA = "0x181C1A950")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021A8A RID: 137866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A8A")]
		[Address(RVA = "0x1C1A730", Offset = "0x1C19330", VA = "0x181C1A730")]
		public Sprite GetSprite(string id)
		{
			return null;
		}

		// Token: 0x06021A8B RID: 137867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A8B")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DynamicSpriteHolder()
		{
		}

		// Token: 0x0402E054 RID: 188500
		[Token(Token = "0x402E054")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private string _packingTag;

		// Token: 0x0402E055 RID: 188501
		[Token(Token = "0x402E055")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private List<DynamicSpriteHolder.SpriteItem> _sprites;

		// Token: 0x0402E056 RID: 188502
		[Token(Token = "0x402E056")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, Sprite> m_spriteHub;

		// Token: 0x02005A56 RID: 23126
		[Token(Token = "0x2005A56")]
		[Serializable]
		public struct SpriteItem
		{
			// Token: 0x0402E057 RID: 188503
			[Token(Token = "0x402E057")]
			[FieldOffset(Offset = "0x0")]
			public string guid;

			// Token: 0x0402E058 RID: 188504
			[Token(Token = "0x402E058")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;
		}
	}
}
