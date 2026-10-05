using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Atlas
{
	// Token: 0x02005C2C RID: 23596
	[Token(Token = "0x2005C2C")]
	public class UIAtlasTextureRef : ScriptableObject, IHotfixable
	{
		// Token: 0x0602234F RID: 140111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602234F")]
		[Address(RVA = "0x1CB38B0", Offset = "0x1CB24B0", VA = "0x181CB38B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022350 RID: 140112 RVA: 0x000BCAF0 File Offset: 0x000BACF0
		[Token(Token = "0x6022350")]
		[Address(RVA = "0x1CB3450", Offset = "0x1CB2050", VA = "0x181CB3450")]
		public SpriteRenderData GetRenderData(string id)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x06022351 RID: 140113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022351")]
		[Address(RVA = "0x1CB3A80", Offset = "0x1CB2680", VA = "0x181CB3A80")]
		public UIAtlasTextureRef()
		{
		}

		// Token: 0x0402EECB RID: 192203
		[Token(Token = "0x402EECB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private List<AtlasSprite> _sprites;

		// Token: 0x0402EECC RID: 192204
		[Token(Token = "0x402EECC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ReadOnly]
		private AtlasInfo _atlas;

		// Token: 0x0402EECD RID: 192205
		[Token(Token = "0x402EECD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ReadOnly]
		private int _index;

		// Token: 0x0402EECE RID: 192206
		[Token(Token = "0x402EECE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ReadOnly]
		private AtlasCheckInfo _sign;

		// Token: 0x0402EECF RID: 192207
		[Token(Token = "0x402EECF")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, AtlasSprite> m_spriteMap;

		// Token: 0x0402EED0 RID: 192208
		[Token(Token = "0x402EED0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EED1 RID: 192209
		[Token(Token = "0x402EED1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRenderData;

		// Token: 0x0402EED2 RID: 192210
		[Token(Token = "0x402EED2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C2D RID: 23597
		[Token(Token = "0x2005C2D")]
		public struct EditorPackOptions
		{
			// Token: 0x0402EED3 RID: 192211
			[Token(Token = "0x402EED3")]
			[FieldOffset(Offset = "0x0")]
			public string textureDir;

			// Token: 0x0402EED4 RID: 192212
			[Token(Token = "0x402EED4")]
			[FieldOffset(Offset = "0x8")]
			public bool useAlpha;

			// Token: 0x0402EED5 RID: 192213
			[Token(Token = "0x402EED5")]
			[FieldOffset(Offset = "0x9")]
			public bool forceRepack;

			// Token: 0x0402EED6 RID: 192214
			[Token(Token = "0x402EED6")]
			[FieldOffset(Offset = "0xC")]
			public int maxAtlasSize;
		}
	}
}
