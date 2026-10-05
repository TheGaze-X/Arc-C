using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005845 RID: 22597
	[Token(Token = "0x2005845")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RL03ResUtil
	{
		// Token: 0x0602104D RID: 135245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602104D")]
		[Address(RVA = "0x1B4F1A0", Offset = "0x1B4DDA0", VA = "0x181B4F1A0")]
		public static Sprite LoadZoneIconSprite(ILoadAsset loader, string topicId, string zoneIconId)
		{
			return null;
		}

		// Token: 0x0602104E RID: 135246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602104E")]
		[Address(RVA = "0x1B4F0D0", Offset = "0x1B4DCD0", VA = "0x181B4F0D0")]
		public static Sprite LoadSpriteFromMiscHub(ILoadAsset loader, string topicId, string spriteId)
		{
			return null;
		}

		// Token: 0x0602104F RID: 135247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602104F")]
		[Address(RVA = "0x1B4F290", Offset = "0x1B4DE90", VA = "0x181B4F290")]
		private static Sprite _LoadAutoPackSprite(ILoadAsset loader, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0402CE98 RID: 183960
		[Token(Token = "0x402CE98")]
		[FieldOffset(Offset = "0x0")]
		private static string ZONE_BIG_ICON_SUFFIX;

		// Token: 0x0402CE99 RID: 183961
		[Token(Token = "0x402CE99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadZoneIconSprite;

		// Token: 0x0402CE9A RID: 183962
		[Token(Token = "0x402CE9A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromMiscHub;

		// Token: 0x0402CE9B RID: 183963
		[Token(Token = "0x402CE9B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;
	}
}
