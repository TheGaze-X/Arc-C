using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004913 RID: 18707
	[Token(Token = "0x2004913")]
	public class StoryReviewMiniItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C34B RID: 115531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C34B")]
		[Address(RVA = "0x15B4240", Offset = "0x15B2E40", VA = "0x1815B4240")]
		public void ApplyData(StoryReviewViewModel storyModel, Color storyColor, bool outOfTime, [Optional] GameObject customPrefab, [Optional] GameObject customLockPrefab)
		{
		}

		// Token: 0x0601C34C RID: 115532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C34C")]
		[Address(RVA = "0x15B4850", Offset = "0x15B3450", VA = "0x1815B4850")]
		private void _TryRenderCustomInfo(GameObject customPrefab, Sprite charSprite, bool locked, bool read)
		{
		}

		// Token: 0x0601C34D RID: 115533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C34D")]
		[Address(RVA = "0x15B47A0", Offset = "0x15B33A0", VA = "0x1815B47A0")]
		public void EventOnStoryClicked()
		{
		}

		// Token: 0x0601C34E RID: 115534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C34E")]
		[Address(RVA = "0x15B4AB0", Offset = "0x15B36B0", VA = "0x1815B4AB0")]
		public StoryReviewMiniItemView()
		{
		}

		// Token: 0x04024E0B RID: 151051
		[Token(Token = "0x4024E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x04024E0C RID: 151052
		[Token(Token = "0x4024E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _charImage;

		// Token: 0x04024E0D RID: 151053
		[Token(Token = "0x4024E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _titleName;

		// Token: 0x04024E0E RID: 151054
		[Token(Token = "0x4024E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _newTag;

		// Token: 0x04024E0F RID: 151055
		[Token(Token = "0x4024E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _newBg;

		// Token: 0x04024E10 RID: 151056
		[Token(Token = "0x4024E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _decoText;

		// Token: 0x04024E11 RID: 151057
		[Token(Token = "0x4024E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _newText;

		// Token: 0x04024E12 RID: 151058
		[Token(Token = "0x4024E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StoryReviewUnlockItemView _unlockView;

		// Token: 0x04024E13 RID: 151059
		[Token(Token = "0x4024E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _customContainer;

		// Token: 0x04024E14 RID: 151060
		[Token(Token = "0x4024E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _titlePanel;

		// Token: 0x04024E15 RID: 151061
		[Token(Token = "0x4024E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onClicked;

		// Token: 0x04024E16 RID: 151062
		[Token(Token = "0x4024E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onStoryRead;

		// Token: 0x04024E17 RID: 151063
		[Token(Token = "0x4024E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<string> onUnlockClicked;

		// Token: 0x04024E18 RID: 151064
		[Token(Token = "0x4024E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private StoryReviewViewModel m_cachedModel;

		// Token: 0x04024E19 RID: 151065
		[Token(Token = "0x4024E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private StoryReviewUnlockItemView m_unlockView;

		// Token: 0x04024E1A RID: 151066
		[Token(Token = "0x4024E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private StoryReviewCustomMiniItemInfoView m_itemInfoView;

		// Token: 0x04024E1B RID: 151067
		[Token(Token = "0x4024E1B")]
		private const float DECO_SPRITE_ALPHA = 0.75f;

		// Token: 0x04024E1C RID: 151068
		[Token(Token = "0x4024E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Color m_lightTextColor;

		// Token: 0x04024E1D RID: 151069
		[Token(Token = "0x4024E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Color m_darkTextColor;

		// Token: 0x04024E1E RID: 151070
		[Token(Token = "0x4024E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04024E1F RID: 151071
		[Token(Token = "0x4024E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryRenderCustomInfo;

		// Token: 0x04024E20 RID: 151072
		[Token(Token = "0x4024E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnStoryClicked;

		// Token: 0x04024E21 RID: 151073
		[Token(Token = "0x4024E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
