using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x0200490C RID: 18700
	[Token(Token = "0x200490C")]
	public class StoryReviewActivityDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C336 RID: 115510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C336")]
		[Address(RVA = "0x15B21B0", Offset = "0x15B0DB0", VA = "0x1815B21B0")]
		public void ApplyData(StoryReviewViewModel storyModel, bool outOfTime)
		{
		}

		// Token: 0x0601C337 RID: 115511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C337")]
		[Address(RVA = "0x15B2470", Offset = "0x15B1070", VA = "0x1815B2470")]
		public void EventOnStoryClicked()
		{
		}

		// Token: 0x0601C338 RID: 115512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C338")]
		[Address(RVA = "0x15B2500", Offset = "0x15B1100", VA = "0x1815B2500")]
		public StoryReviewActivityDetailItemView()
		{
		}

		// Token: 0x04024DD5 RID: 150997
		[Token(Token = "0x4024DD5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _titleCode;

		// Token: 0x04024DD6 RID: 150998
		[Token(Token = "0x4024DD6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleName;

		// Token: 0x04024DD7 RID: 150999
		[Token(Token = "0x4024DD7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _storyTag;

		// Token: 0x04024DD8 RID: 151000
		[Token(Token = "0x4024DD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _storyInfo;

		// Token: 0x04024DD9 RID: 151001
		[Token(Token = "0x4024DD9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StoryReviewUnlockItemView _unlockItem;

		// Token: 0x04024DDA RID: 151002
		[Token(Token = "0x4024DDA")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onStoryPlayClicked;

		// Token: 0x04024DDB RID: 151003
		[Token(Token = "0x4024DDB")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onStoryRead;

		// Token: 0x04024DDC RID: 151004
		[Token(Token = "0x4024DDC")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string> onStoryUnlockClicked;

		// Token: 0x04024DDD RID: 151005
		[Token(Token = "0x4024DDD")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedStoryReviewId;

		// Token: 0x04024DDE RID: 151006
		[Token(Token = "0x4024DDE")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedStoryId;

		// Token: 0x04024DDF RID: 151007
		[Token(Token = "0x4024DDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04024DE0 RID: 151008
		[Token(Token = "0x4024DE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnStoryClicked;

		// Token: 0x04024DE1 RID: 151009
		[Token(Token = "0x4024DE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
