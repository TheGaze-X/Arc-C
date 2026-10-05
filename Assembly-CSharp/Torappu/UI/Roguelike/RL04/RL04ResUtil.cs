using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005703 RID: 22275
	[Token(Token = "0x2005703")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RL04ResUtil
	{
		// Token: 0x06020AB8 RID: 133816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020AB8")]
		[Address(RVA = "0x1ACE960", Offset = "0x1ACD560", VA = "0x181ACE960")]
		public static Sprite LoadZoneLabelSprite(ILoadAsset loader, string topicId, string zoneId)
		{
			return null;
		}

		// Token: 0x06020AB9 RID: 133817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020AB9")]
		[Address(RVA = "0x1ACE8A0", Offset = "0x1ACD4A0", VA = "0x181ACE8A0")]
		public static Sprite LoadZoneBgSprite(ILoadAsset loader, string topicId, string zoneId)
		{
			return null;
		}

		// Token: 0x06020ABA RID: 133818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020ABA")]
		[Address(RVA = "0x1ACE800", Offset = "0x1ACD400", VA = "0x181ACE800")]
		public static Sprite LoadSpriteInMisc(ILoadAsset loader, string topicId, string spriteId)
		{
			return null;
		}

		// Token: 0x06020ABB RID: 133819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020ABB")]
		[Address(RVA = "0x1ACE760", Offset = "0x1ACD360", VA = "0x181ACE760")]
		public static Sprite LoadFragmentTypeIcon(ILoadAsset loader, string topicId, string typeIconId)
		{
			return null;
		}

		// Token: 0x06020ABC RID: 133820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020ABC")]
		[Address(RVA = "0x1ACE6C0", Offset = "0x1ACD2C0", VA = "0x181ACE6C0")]
		public static Sprite LoadDisasterToastIcon(ILoadAsset loader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x06020ABD RID: 133821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020ABD")]
		[Address(RVA = "0x1ACEA20", Offset = "0x1ACD620", VA = "0x181ACEA20")]
		private static Sprite _LoadAutoPackSprite(ILoadAsset loader, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x06020ABE RID: 133822 RVA: 0x000B6C58 File Offset: 0x000B4E58
		[Token(Token = "0x6020ABE")]
		[Address(RVA = "0x1ACE4A0", Offset = "0x1ACD0A0", VA = "0x181ACE4A0")]
		public static RL04ResUtil.TraderReturnText GetTraderReturnText(List<ItemBundle> items, string topicId)
		{
			return default(RL04ResUtil.TraderReturnText);
		}

		// Token: 0x0402C566 RID: 181606
		[Token(Token = "0x402C566")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadZoneLabelSprite;

		// Token: 0x0402C567 RID: 181607
		[Token(Token = "0x402C567")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadZoneBgSprite;

		// Token: 0x0402C568 RID: 181608
		[Token(Token = "0x402C568")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadSpriteInMisc;

		// Token: 0x0402C569 RID: 181609
		[Token(Token = "0x402C569")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadFragmentTypeIcon;

		// Token: 0x0402C56A RID: 181610
		[Token(Token = "0x402C56A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadDisasterToastIcon;

		// Token: 0x0402C56B RID: 181611
		[Token(Token = "0x402C56B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x0402C56C RID: 181612
		[Token(Token = "0x402C56C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTraderReturnText;

		// Token: 0x02005704 RID: 22276
		[Token(Token = "0x2005704")]
		public struct TraderReturnText
		{
			// Token: 0x0402C56D RID: 181613
			[Token(Token = "0x402C56D")]
			[FieldOffset(Offset = "0x0")]
			public string title;

			// Token: 0x0402C56E RID: 181614
			[Token(Token = "0x402C56E")]
			[FieldOffset(Offset = "0x8")]
			public string desc;

			// Token: 0x0402C56F RID: 181615
			[Token(Token = "0x402C56F")]
			[FieldOffset(Offset = "0x0")]
			public static RL04ResUtil.TraderReturnText EMPTY;
		}
	}
}
