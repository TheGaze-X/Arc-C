using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D95 RID: 28053
	[Token(Token = "0x2006D95")]
	public class ActCommonMiniStoryBinder : DataBinder<ActCommonMiniStoryProperty>, IHotfixable
	{
		// Token: 0x06027F54 RID: 163668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F54")]
		[Address(RVA = "0x232DF40", Offset = "0x232CB40", VA = "0x18232DF40")]
		private void _UpdateAdapterStatus(ActCommonMiniStoryViewModel groupModel)
		{
		}

		// Token: 0x06027F55 RID: 163669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F55")]
		[Address(RVA = "0x232DC80", Offset = "0x232C880", VA = "0x18232DC80", Slot = "7")]
		public override void OnValueChanged(ActCommonMiniStoryProperty property)
		{
		}

		// Token: 0x06027F56 RID: 163670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F56")]
		[Address(RVA = "0x232DE80", Offset = "0x232CA80", VA = "0x18232DE80")]
		public void SetCallbacks(Action<string> onReviewStoryClicked, Action<string> onUnlockStoryClicked, Action<string> onStoryRead)
		{
		}

		// Token: 0x06027F57 RID: 163671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F57")]
		[Address(RVA = "0x232E300", Offset = "0x232CF00", VA = "0x18232E300")]
		public ActCommonMiniStoryBinder()
		{
		}

		// Token: 0x04038A17 RID: 231959
		[Token(Token = "0x4038A17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04038A18 RID: 231960
		[Token(Token = "0x4038A18")]
		[FieldOffset(Offset = "0x28")]
		private ActCommonMiniStoryAdapter m_storyAdapter;

		// Token: 0x04038A19 RID: 231961
		[Token(Token = "0x4038A19")]
		[FieldOffset(Offset = "0x30")]
		private Action<string> m_onReviewStoryClicked;

		// Token: 0x04038A1A RID: 231962
		[Token(Token = "0x4038A1A")]
		[FieldOffset(Offset = "0x38")]
		private Action<string> m_onStoryUnlockClicked;

		// Token: 0x04038A1B RID: 231963
		[Token(Token = "0x4038A1B")]
		[FieldOffset(Offset = "0x40")]
		private Action<string> m_onStoryReadClicked;

		// Token: 0x04038A1C RID: 231964
		[Token(Token = "0x4038A1C")]
		[FieldOffset(Offset = "0x48")]
		private ActCommonMiniStoryBinder.AdapterPluginInfo m_adapterPluginInfo;

		// Token: 0x04038A1D RID: 231965
		[Token(Token = "0x4038A1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateAdapterStatus;

		// Token: 0x04038A1E RID: 231966
		[Token(Token = "0x4038A1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04038A1F RID: 231967
		[Token(Token = "0x4038A1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x04038A20 RID: 231968
		[Token(Token = "0x4038A20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D96 RID: 28054
		[Token(Token = "0x2006D96")]
		private struct AdapterPluginInfo
		{
			// Token: 0x06027F58 RID: 163672 RVA: 0x000D02C0 File Offset: 0x000CE4C0
			[Token(Token = "0x6027F58")]
			[Address(RVA = "0x2340840", Offset = "0x233F440", VA = "0x182340840")]
			public static ActCommonMiniStoryBinder.AdapterPluginInfo Create(ActCommonMiniStoryViewModel viewModel)
			{
				return default(ActCommonMiniStoryBinder.AdapterPluginInfo);
			}

			// Token: 0x04038A21 RID: 231969
			[Token(Token = "0x4038A21")]
			[FieldOffset(Offset = "0x0")]
			public bool isEmpty;

			// Token: 0x04038A22 RID: 231970
			[Token(Token = "0x4038A22")]
			[FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x04038A23 RID: 231971
			[Token(Token = "0x4038A23")]
			[FieldOffset(Offset = "0x10")]
			public StoryReviewCustomType customType;
		}
	}
}
