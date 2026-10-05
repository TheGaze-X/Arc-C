using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F51 RID: 8017
	[Token(Token = "0x2001F51")]
	[RequireComponent(typeof(RectTransform))]
	public class AVGCharacterSpriteHub : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C74F RID: 51023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C74F")]
		[Address(RVA = "0x347A9D0", Offset = "0x34795D0", VA = "0x18347A9D0")]
		public void SetImage(AlphaSplitImageHolder imageHolder, CharacterParam param)
		{
		}

		// Token: 0x0600C750 RID: 51024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C750")]
		[Address(RVA = "0x347A7D0", Offset = "0x34793D0", VA = "0x18347A7D0")]
		public void SetImage(AlphaSplitImageHolder imageHolder, string alias, CharacterParam param)
		{
		}

		// Token: 0x0600C751 RID: 51025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C751")]
		[Address(RVA = "0x347ACB0", Offset = "0x34798B0", VA = "0x18347ACB0")]
		private void _PickSetImageImpl(AlphaSplitImageHolder imageHolder, AVGCharacterSpriteHub.SpriteConfig targetConfig, CharacterParam param)
		{
		}

		// Token: 0x0600C752 RID: 51026 RVA: 0x00048A98 File Offset: 0x00046C98
		[Token(Token = "0x600C752")]
		[Address(RVA = "0x347ABC0", Offset = "0x34797C0", VA = "0x18347ABC0")]
		private bool _HasFace()
		{
			return default(bool);
		}

		// Token: 0x0600C753 RID: 51027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C753")]
		[Address(RVA = "0x347AF10", Offset = "0x3479B10", VA = "0x18347AF10")]
		private void _SetImage(AlphaSplitImageHolder imageHolder, AVGCharacterSpriteHub.SpriteConfig config, AVGCharacterSpriteHub.SpriteConfig faceConfig, CharacterParam param)
		{
		}

		// Token: 0x0600C754 RID: 51028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C754")]
		[Address(RVA = "0x347B430", Offset = "0x347A030", VA = "0x18347B430")]
		public AVGCharacterSpriteHub()
		{
		}

		// Token: 0x0400CD2F RID: 52527
		[Token(Token = "0x400CD2F")]
		[FieldOffset(Offset = "0x18")]
		public AVGCharacterSpriteHub.SpriteConfig[] sprites;

		// Token: 0x0400CD30 RID: 52528
		[Token(Token = "0x400CD30")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 FacePos;

		// Token: 0x0400CD31 RID: 52529
		[Token(Token = "0x400CD31")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 FaceSize;

		// Token: 0x0400CD32 RID: 52530
		[Token(Token = "0x400CD32")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform m_rectTransform;

		// Token: 0x0400CD33 RID: 52531
		[Token(Token = "0x400CD33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetImage;

		// Token: 0x0400CD34 RID: 52532
		[Token(Token = "0x400CD34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_SetImage;

		// Token: 0x0400CD35 RID: 52533
		[Token(Token = "0x400CD35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PickSetImageImpl;

		// Token: 0x0400CD36 RID: 52534
		[Token(Token = "0x400CD36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HasFace;

		// Token: 0x0400CD37 RID: 52535
		[Token(Token = "0x400CD37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetImage;

		// Token: 0x0400CD38 RID: 52536
		[Token(Token = "0x400CD38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F52 RID: 8018
		[Token(Token = "0x2001F52")]
		[Serializable]
		public class SpriteConfig
		{
			// Token: 0x0600C755 RID: 51029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C755")]
			[Address(RVA = "0x3488670", Offset = "0x3487270", VA = "0x183488670", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600C756 RID: 51030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C756")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpriteConfig()
			{
			}

			// Token: 0x0400CD39 RID: 52537
			[Token(Token = "0x400CD39")]
			[FieldOffset(Offset = "0x10")]
			public Sprite sprite;

			// Token: 0x0400CD3A RID: 52538
			[Token(Token = "0x400CD3A")]
			[FieldOffset(Offset = "0x18")]
			public Texture alphaTex;

			// Token: 0x0400CD3B RID: 52539
			[Token(Token = "0x400CD3B")]
			[FieldOffset(Offset = "0x20")]
			public string alias;

			// Token: 0x0400CD3C RID: 52540
			[Token(Token = "0x400CD3C")]
			[FieldOffset(Offset = "0x28")]
			public bool isWholeBody;
		}
	}
}
