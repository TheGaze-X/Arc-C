using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x0200446E RID: 17518
	[Token(Token = "0x200446E")]
	public class RoguelikeEntryMainView : DataBinder<RoguelikeEntryProperty>, IHotfixable
	{
		// Token: 0x0601AC76 RID: 109686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC76")]
		[Address(RVA = "0x13D72D0", Offset = "0x13D5ED0", VA = "0x1813D72D0", Slot = "7")]
		public override void OnValueChanged(RoguelikeEntryProperty property)
		{
		}

		// Token: 0x0601AC77 RID: 109687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC77")]
		[Address(RVA = "0x13D7240", Offset = "0x13D5E40", VA = "0x1813D7240")]
		public void EventOnPinBtnClicked()
		{
		}

		// Token: 0x0601AC78 RID: 109688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC78")]
		[Address(RVA = "0x13D71B0", Offset = "0x13D5DB0", VA = "0x1813D71B0")]
		public void EventOnArchiveBtnClicked()
		{
		}

		// Token: 0x0601AC79 RID: 109689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC79")]
		[Address(RVA = "0x13D78A0", Offset = "0x13D64A0", VA = "0x1813D78A0")]
		private void _Render(RoguelikeEntryItemViewModel model)
		{
		}

		// Token: 0x0601AC7A RID: 109690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC7A")]
		[Address(RVA = "0x13D7800", Offset = "0x13D6400", VA = "0x1813D7800")]
		private void _KillSwitchAnimIfNecessary()
		{
		}

		// Token: 0x0601AC7B RID: 109691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC7B")]
		[Address(RVA = "0x13D7610", Offset = "0x13D6210", VA = "0x1813D7610")]
		private Tween _GenerateSwitchAnim(RoguelikeEntryItemViewModel model)
		{
			return null;
		}

		// Token: 0x0601AC7C RID: 109692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC7C")]
		[Address(RVA = "0x13D7A70", Offset = "0x13D6670", VA = "0x1813D7A70")]
		public RoguelikeEntryMainView()
		{
		}

		// Token: 0x040223C0 RID: 140224
		[Token(Token = "0x40223C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUpdateUncomplete;

		// Token: 0x040223C1 RID: 140225
		[Token(Token = "0x40223C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUpdateComplete;

		// Token: 0x040223C2 RID: 140226
		[Token(Token = "0x40223C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelReview;

		// Token: 0x040223C3 RID: 140227
		[Token(Token = "0x40223C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgMain;

		// Token: 0x040223C4 RID: 140228
		[Token(Token = "0x40223C4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelPinned;

		// Token: 0x040223C5 RID: 140229
		[Token(Token = "0x40223C5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelBtnPin;

		// Token: 0x040223C6 RID: 140230
		[Token(Token = "0x40223C6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040223C7 RID: 140231
		[Token(Token = "0x40223C7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _fadeInAnim;

		// Token: 0x040223C8 RID: 140232
		[Token(Token = "0x40223C8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _fadeOutAnim;

		// Token: 0x040223C9 RID: 140233
		[Token(Token = "0x40223C9")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040223CA RID: 140234
		[Token(Token = "0x40223CA")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedEntrySequence;

		// Token: 0x040223CB RID: 140235
		[Token(Token = "0x40223CB")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedTopicId;

		// Token: 0x040223CC RID: 140236
		[Token(Token = "0x40223CC")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_switchAnim;

		// Token: 0x040223CD RID: 140237
		[Token(Token = "0x40223CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040223CE RID: 140238
		[Token(Token = "0x40223CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnPinBtnClicked;

		// Token: 0x040223CF RID: 140239
		[Token(Token = "0x40223CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnArchiveBtnClicked;

		// Token: 0x040223D0 RID: 140240
		[Token(Token = "0x40223D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040223D1 RID: 140241
		[Token(Token = "0x40223D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__KillSwitchAnimIfNecessary;

		// Token: 0x040223D2 RID: 140242
		[Token(Token = "0x40223D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateSwitchAnim;

		// Token: 0x040223D3 RID: 140243
		[Token(Token = "0x40223D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
