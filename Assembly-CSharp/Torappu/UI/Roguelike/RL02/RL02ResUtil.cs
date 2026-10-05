using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200579D RID: 22429
	[Token(Token = "0x200579D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RL02ResUtil
	{
		// Token: 0x06020CEB RID: 134379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CEB")]
		[Address(RVA = "0x1B26270", Offset = "0x1B24E70", VA = "0x181B26270")]
		public static Sprite LoadZoneLabelSprite(ILoadAsset loader, string topicId, string zoneId)
		{
			return null;
		}

		// Token: 0x06020CEC RID: 134380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CEC")]
		[Address(RVA = "0x1B26330", Offset = "0x1B24F30", VA = "0x181B26330")]
		private static Sprite _LoadAutoPackSprite(ILoadAsset loader, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0402C94A RID: 182602
		[Token(Token = "0x402C94A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadZoneLabelSprite;

		// Token: 0x0402C94B RID: 182603
		[Token(Token = "0x402C94B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;
	}
}
