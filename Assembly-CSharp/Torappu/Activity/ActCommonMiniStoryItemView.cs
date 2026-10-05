using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.StoryReview;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D97 RID: 28055
	[Token(Token = "0x2006D97")]
	public class ActCommonMiniStoryItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027F59 RID: 163673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F59")]
		[Address(RVA = "0x232E3A0", Offset = "0x232CFA0", VA = "0x18232E3A0")]
		public void ApplyData(StoryReviewViewModel storyModel, Color storyColor, [Optional] GameObject customPrefab, [Optional] GameObject customLockPrefab)
		{
		}

		// Token: 0x06027F5A RID: 163674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F5A")]
		[Address(RVA = "0x232EBC0", Offset = "0x232D7C0", VA = "0x18232EBC0")]
		private void _TryRenderCustomInfo(GameObject customPrefab, Sprite charSprite, bool locked, bool read)
		{
		}

		// Token: 0x06027F5B RID: 163675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F5B")]
		[Address(RVA = "0x232EB20", Offset = "0x232D720", VA = "0x18232EB20")]
		private Sprite _LoadSprite(string picId)
		{
			return null;
		}

		// Token: 0x06027F5C RID: 163676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F5C")]
		[Address(RVA = "0x232EA90", Offset = "0x232D690", VA = "0x18232EA90")]
		public void EventOnStoryClicked()
		{
		}

		// Token: 0x06027F5D RID: 163677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F5D")]
		[Address(RVA = "0x232ED70", Offset = "0x232D970", VA = "0x18232ED70")]
		public ActCommonMiniStoryItemView()
		{
		}

		// Token: 0x04038A24 RID: 231972
		[Token(Token = "0x4038A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x04038A25 RID: 231973
		[Token(Token = "0x4038A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _charImage;

		// Token: 0x04038A26 RID: 231974
		[Token(Token = "0x4038A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _titleName;

		// Token: 0x04038A27 RID: 231975
		[Token(Token = "0x4038A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _newTag;

		// Token: 0x04038A28 RID: 231976
		[Token(Token = "0x4038A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _newBg;

		// Token: 0x04038A29 RID: 231977
		[Token(Token = "0x4038A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _decoText;

		// Token: 0x04038A2A RID: 231978
		[Token(Token = "0x4038A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _newText;

		// Token: 0x04038A2B RID: 231979
		[Token(Token = "0x4038A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StoryReviewUnlockItemView _unlockView;

		// Token: 0x04038A2C RID: 231980
		[Token(Token = "0x4038A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _customContainer;

		// Token: 0x04038A2D RID: 231981
		[Token(Token = "0x4038A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _titlePanel;

		// Token: 0x04038A2E RID: 231982
		[Token(Token = "0x4038A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onClicked;

		// Token: 0x04038A2F RID: 231983
		[Token(Token = "0x4038A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onStoryRead;

		// Token: 0x04038A30 RID: 231984
		[Token(Token = "0x4038A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<string> onUnlockClicked;

		// Token: 0x04038A31 RID: 231985
		[Token(Token = "0x4038A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string m_cachedStoryTextId;

		// Token: 0x04038A32 RID: 231986
		[Token(Token = "0x4038A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string m_cachedStoryId;

		// Token: 0x04038A33 RID: 231987
		[Token(Token = "0x4038A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private StoryReviewUnlockItemView m_unlockView;

		// Token: 0x04038A34 RID: 231988
		[Token(Token = "0x4038A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private StoryReviewCustomMiniItemInfoView m_itemInfoView;

		// Token: 0x04038A35 RID: 231989
		[Token(Token = "0x4038A35")]
		private const float DECO_SPRITE_ALPHA = 0.75f;

		// Token: 0x04038A36 RID: 231990
		[Token(Token = "0x4038A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Color m_lightTextColor;

		// Token: 0x04038A37 RID: 231991
		[Token(Token = "0x4038A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Color m_darkTextColor;

		// Token: 0x04038A38 RID: 231992
		[Token(Token = "0x4038A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04038A39 RID: 231993
		[Token(Token = "0x4038A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryRenderCustomInfo;

		// Token: 0x04038A3A RID: 231994
		[Token(Token = "0x4038A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x04038A3B RID: 231995
		[Token(Token = "0x4038A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnStoryClicked;

		// Token: 0x04038A3C RID: 231996
		[Token(Token = "0x4038A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
