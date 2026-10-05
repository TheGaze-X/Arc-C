using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Wardrobe
{
	// Token: 0x02004A4A RID: 19018
	[Token(Token = "0x2004A4A")]
	public class WardrobeKVSpriteLoader : PageAssetPool<Sprite>
	{
		// Token: 0x0601C969 RID: 117097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C969")]
		[Address(RVA = "0x161F100", Offset = "0x161DD00", VA = "0x18161F100")]
		public static Sprite LoadSpriteFromHubStatic(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601C96A RID: 117098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C96A")]
		[Address(RVA = "0x161F290", Offset = "0x161DE90", VA = "0x18161F290")]
		public Sprite LoadSpriteFromHub(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601C96B RID: 117099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C96B")]
		[Address(RVA = "0x161F330", Offset = "0x161DF30", VA = "0x18161F330")]
		private Sprite _LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601C96C RID: 117100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C96C")]
		[Address(RVA = "0x161F570", Offset = "0x161E170", VA = "0x18161F570")]
		private Sprite _LoadSpriteFromAutoPackHubByPage(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601C96D RID: 117101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C96D")]
		[Address(RVA = "0x161F6C0", Offset = "0x161E2C0", VA = "0x18161F6C0")]
		public WardrobeKVSpriteLoader()
		{
		}

		// Token: 0x0402588D RID: 153741
		[Token(Token = "0x402588D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromHubStatic;

		// Token: 0x0402588E RID: 153742
		[Token(Token = "0x402588E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromHub;

		// Token: 0x0402588F RID: 153743
		[Token(Token = "0x402588F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x04025890 RID: 153744
		[Token(Token = "0x4025890")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromAutoPackHubByPage;

		// Token: 0x04025891 RID: 153745
		[Token(Token = "0x4025891")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
