using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A78 RID: 6776
	[Token(Token = "0x2001A78")]
	public class VCharacterEmojiPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AACB RID: 43723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AACB")]
		[Address(RVA = "0x325CF30", Offset = "0x325BB30", VA = "0x18325CF30")]
		public void BindVCharacter(VCharacter character)
		{
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AACC")]
		[Address(RVA = "0x325D2D0", Offset = "0x325BED0", VA = "0x18325D2D0")]
		public void UpdatePosition()
		{
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AACD")]
		[Address(RVA = "0x325CFB0", Offset = "0x325BBB0", VA = "0x18325CFB0")]
		public void Render(string emojiId)
		{
		}

		// Token: 0x0600AACE RID: 43726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AACE")]
		[Address(RVA = "0x325D450", Offset = "0x325C050", VA = "0x18325D450")]
		public VCharacterEmojiPanel()
		{
		}

		// Token: 0x0400A32C RID: 41772
		[Token(Token = "0x400A32C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _prefabContainer;

		// Token: 0x0400A32D RID: 41773
		[Token(Token = "0x400A32D")]
		[FieldOffset(Offset = "0x20")]
		private VCharacter m_character;

		// Token: 0x0400A32E RID: 41774
		[Token(Token = "0x400A32E")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, VCharacterEmojiAnimItem> m_emojiPrefabDict;

		// Token: 0x0400A32F RID: 41775
		[Token(Token = "0x400A32F")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_emojiTween;

		// Token: 0x0400A330 RID: 41776
		[Token(Token = "0x400A330")]
		[FieldOffset(Offset = "0x38")]
		private VCharacterEmojiAnimItem m_curEmojiPrefab;

		// Token: 0x0400A331 RID: 41777
		[Token(Token = "0x400A331")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindVCharacter;

		// Token: 0x0400A332 RID: 41778
		[Token(Token = "0x400A332")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdatePosition;

		// Token: 0x0400A333 RID: 41779
		[Token(Token = "0x400A333")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A334 RID: 41780
		[Token(Token = "0x400A334")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
