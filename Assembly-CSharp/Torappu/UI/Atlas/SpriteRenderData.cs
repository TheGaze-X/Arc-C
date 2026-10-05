using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Atlas
{
	// Token: 0x02005C35 RID: 23605
	[Token(Token = "0x2005C35")]
	public struct SpriteRenderData : IHotfixable, ILuaCallCSharp
	{
		// Token: 0x0602235F RID: 140127 RVA: 0x000BCB50 File Offset: 0x000BAD50
		[Token(Token = "0x602235F")]
		[Address(RVA = "0x1CB28F0", Offset = "0x1CB14F0", VA = "0x181CB28F0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06022360 RID: 140128 RVA: 0x000BCB68 File Offset: 0x000BAD68
		[Token(Token = "0x6022360")]
		[Address(RVA = "0x1CB26A0", Offset = "0x1CB12A0", VA = "0x181CB26A0")]
		public Vector2 GetNativeSize()
		{
			return default(Vector2);
		}

		// Token: 0x06022361 RID: 140129 RVA: 0x000BCB80 File Offset: 0x000BAD80
		[Token(Token = "0x6022361")]
		[Address(RVA = "0x1CB2770", Offset = "0x1CB1370", VA = "0x181CB2770")]
		public Vector4 GetUVs(int padding = 0)
		{
			return default(Vector4);
		}

		// Token: 0x06022362 RID: 140130 RVA: 0x000BCB98 File Offset: 0x000BAD98
		[Token(Token = "0x6022362")]
		[Address(RVA = "0x1CB2230", Offset = "0x1CB0E30", VA = "0x181CB2230")]
		public static SpriteRenderData CreateFromSprite(Sprite sprite)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0402EEF5 RID: 192245
		[Token(Token = "0x402EEF5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SpriteRenderData EMPTY;

		// Token: 0x0402EEF6 RID: 192246
		[Token(Token = "0x402EEF6")]
		[FieldOffset(Offset = "0x0")]
		public Texture2D mainTex;

		// Token: 0x0402EEF7 RID: 192247
		[Token(Token = "0x402EEF7")]
		[FieldOffset(Offset = "0x8")]
		public Texture2D alphaTex;

		// Token: 0x0402EEF8 RID: 192248
		[Token(Token = "0x402EEF8")]
		[FieldOffset(Offset = "0x10")]
		public AtlasCoord rect;

		// Token: 0x0402EEF9 RID: 192249
		[Token(Token = "0x402EEF9")]
		[FieldOffset(Offset = "0x20")]
		public int atlasSize;

		// Token: 0x0402EEFA RID: 192250
		[Token(Token = "0x402EEFA")]
		[FieldOffset(Offset = "0x24")]
		public bool rotate;

		// Token: 0x0402EEFB RID: 192251
		[Token(Token = "0x402EEFB")]
		[FieldOffset(Offset = "0x28")]
		public Vector4? fixedUVs;

		// Token: 0x0402EEFC RID: 192252
		[Token(Token = "0x402EEFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0402EEFD RID: 192253
		[Token(Token = "0x402EEFD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetNativeSize;

		// Token: 0x0402EEFE RID: 192254
		[Token(Token = "0x402EEFE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetUVs;

		// Token: 0x0402EEFF RID: 192255
		[Token(Token = "0x402EEFF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CreateFromSprite;
	}
}
