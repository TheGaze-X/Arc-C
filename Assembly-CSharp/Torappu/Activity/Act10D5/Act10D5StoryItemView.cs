using System;
using Il2CppDummyDll;
using Torappu.UI.StoryReview;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B34 RID: 31540
	[Token(Token = "0x2007B34")]
	public class Act10D5StoryItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C274 RID: 180852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C274")]
		[Address(RVA = "0x280A9E0", Offset = "0x28095E0", VA = "0x18280A9E0")]
		public void ApplyData(StoryReviewViewModel storyModel, Color storyColor)
		{
		}

		// Token: 0x0602C275 RID: 180853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C275")]
		[Address(RVA = "0x280AF00", Offset = "0x2809B00", VA = "0x18280AF00")]
		private Sprite _LoadSprite(string picId)
		{
			return null;
		}

		// Token: 0x0602C276 RID: 180854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C276")]
		[Address(RVA = "0x280AE70", Offset = "0x2809A70", VA = "0x18280AE70")]
		public void EventOnStoryClicked()
		{
		}

		// Token: 0x0602C277 RID: 180855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C277")]
		[Address(RVA = "0x280B0F0", Offset = "0x2809CF0", VA = "0x18280B0F0")]
		public Act10D5StoryItemView()
		{
		}

		// Token: 0x0404000F RID: 262159
		[Token(Token = "0x404000F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _infoPanel;

		// Token: 0x04040010 RID: 262160
		[Token(Token = "0x4040010")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _charImage;

		// Token: 0x04040011 RID: 262161
		[Token(Token = "0x4040011")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _titleName;

		// Token: 0x04040012 RID: 262162
		[Token(Token = "0x4040012")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _newTag;

		// Token: 0x04040013 RID: 262163
		[Token(Token = "0x4040013")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _newBg;

		// Token: 0x04040014 RID: 262164
		[Token(Token = "0x4040014")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _decoText;

		// Token: 0x04040015 RID: 262165
		[Token(Token = "0x4040015")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _newText;

		// Token: 0x04040016 RID: 262166
		[Token(Token = "0x4040016")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private StoryReviewUnlockItemView _unlockView;

		// Token: 0x04040017 RID: 262167
		[Token(Token = "0x4040017")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<string> onClicked;

		// Token: 0x04040018 RID: 262168
		[Token(Token = "0x4040018")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<string> onStoryRead;

		// Token: 0x04040019 RID: 262169
		[Token(Token = "0x4040019")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onUnlockClicked;

		// Token: 0x0404001A RID: 262170
		[Token(Token = "0x404001A")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedStoryTextId;

		// Token: 0x0404001B RID: 262171
		[Token(Token = "0x404001B")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedStoryId;

		// Token: 0x0404001C RID: 262172
		[Token(Token = "0x404001C")]
		[FieldOffset(Offset = "0x80")]
		private StoryReviewUnlockItemView m_unlockView;

		// Token: 0x0404001D RID: 262173
		[Token(Token = "0x404001D")]
		private const float DECO_SPRITE_ALPHA = 0.75f;

		// Token: 0x0404001E RID: 262174
		[Token(Token = "0x404001E")]
		[FieldOffset(Offset = "0x88")]
		private Color m_lightTextColor;

		// Token: 0x0404001F RID: 262175
		[Token(Token = "0x404001F")]
		[FieldOffset(Offset = "0x98")]
		private Color m_darkTextColor;

		// Token: 0x04040020 RID: 262176
		[Token(Token = "0x4040020")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04040021 RID: 262177
		[Token(Token = "0x4040021")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x04040022 RID: 262178
		[Token(Token = "0x4040022")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnStoryClicked;

		// Token: 0x04040023 RID: 262179
		[Token(Token = "0x4040023")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
