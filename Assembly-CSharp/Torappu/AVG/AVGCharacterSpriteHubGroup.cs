using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F53 RID: 8019
	[Token(Token = "0x2001F53")]
	[RequireComponent(typeof(RectTransform))]
	public class AVGCharacterSpriteHubGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C757 RID: 51031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C757")]
		[Address(RVA = "0x3479870", Offset = "0x3478470", VA = "0x183479870")]
		public void SetImage(AlphaSplitImageHolder imageHolder, int body, string alias, CharacterParam param)
		{
		}

		// Token: 0x0600C758 RID: 51032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C758")]
		[Address(RVA = "0x3479400", Offset = "0x3478000", VA = "0x183479400")]
		public void SetImage(AlphaSplitImageHolder imageHolder, int body, CharacterParam param)
		{
		}

		// Token: 0x0600C759 RID: 51033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C759")]
		[Address(RVA = "0x3479D40", Offset = "0x3478940", VA = "0x183479D40")]
		private void _PickSetImageImpl(AlphaSplitImageHolder imageHolder, AVGCharacterSpriteHub.SpriteConfig targetConfig, int body, CharacterParam param)
		{
		}

		// Token: 0x0600C75A RID: 51034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C75A")]
		[Address(RVA = "0x347A040", Offset = "0x3478C40", VA = "0x18347A040")]
		private void _SetImage(AlphaSplitImageHolder imageHolder, AVGCharacterSpriteHub.SpriteConfig charConfig, AVGCharacterSpriteHub.SpriteConfig faceConfig, int body, CharacterParam param)
		{
		}

		// Token: 0x0600C75B RID: 51035 RVA: 0x00048AB0 File Offset: 0x00046CB0
		[Token(Token = "0x600C75B")]
		[Address(RVA = "0x3479C10", Offset = "0x3478810", VA = "0x183479C10")]
		private bool _HasFace(int body)
		{
			return default(bool);
		}

		// Token: 0x0600C75C RID: 51036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C75C")]
		[Address(RVA = "0x347A770", Offset = "0x3479370", VA = "0x18347A770")]
		public AVGCharacterSpriteHubGroup()
		{
		}

		// Token: 0x0400CD3D RID: 52541
		[Token(Token = "0x400CD3D")]
		[FieldOffset(Offset = "0x18")]
		public AVGCharacterSpriteHubGroup.SpriteConfigGroup[] spriteGroups;

		// Token: 0x0400CD3E RID: 52542
		[Token(Token = "0x400CD3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetImage;

		// Token: 0x0400CD3F RID: 52543
		[Token(Token = "0x400CD3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_SetImage;

		// Token: 0x0400CD40 RID: 52544
		[Token(Token = "0x400CD40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PickSetImageImpl;

		// Token: 0x0400CD41 RID: 52545
		[Token(Token = "0x400CD41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetImage;

		// Token: 0x0400CD42 RID: 52546
		[Token(Token = "0x400CD42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HasFace;

		// Token: 0x0400CD43 RID: 52547
		[Token(Token = "0x400CD43")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F54 RID: 8020
		[Token(Token = "0x2001F54")]
		[Serializable]
		public class SpriteConfigGroup
		{
			// Token: 0x0600C75D RID: 51037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C75D")]
			[Address(RVA = "0x34885F0", Offset = "0x34871F0", VA = "0x1834885F0")]
			public SpriteConfigGroup()
			{
			}

			// Token: 0x0400CD44 RID: 52548
			[Token(Token = "0x400CD44")]
			[FieldOffset(Offset = "0x10")]
			public AVGCharacterSpriteHub.SpriteConfig[] sprites;

			// Token: 0x0400CD45 RID: 52549
			[Token(Token = "0x400CD45")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 facePos;

			// Token: 0x0400CD46 RID: 52550
			[Token(Token = "0x400CD46")]
			[FieldOffset(Offset = "0x24")]
			public Vector2 faceSize;
		}
	}
}
