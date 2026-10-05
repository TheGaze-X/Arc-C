using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x0200490A RID: 18698
	[Token(Token = "0x200490A")]
	public class MiniReviewDetailBinder : DataBinder<ActivityReviewDetailProperty>, IHotfixable
	{
		// Token: 0x0601C330 RID: 115504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C330")]
		[Address(RVA = "0x15B1C50", Offset = "0x15B0850", VA = "0x1815B1C50")]
		private void _UpdateAdapterStatus(StoryReviewChapter groupModel)
		{
		}

		// Token: 0x0601C331 RID: 115505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C331")]
		[Address(RVA = "0x15B1940", Offset = "0x15B0540", VA = "0x1815B1940", Slot = "7")]
		public override void OnValueChanged(ActivityReviewDetailProperty property)
		{
		}

		// Token: 0x0601C332 RID: 115506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C332")]
		[Address(RVA = "0x15B1B90", Offset = "0x15B0790", VA = "0x1815B1B90")]
		public void SetCallbacks(Action<string> onReviewStoryClicked, Action<string> onUnlockStoryClicked, Action<string> onStoryRead)
		{
		}

		// Token: 0x0601C333 RID: 115507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C333")]
		[Address(RVA = "0x15B2070", Offset = "0x15B0C70", VA = "0x1815B2070")]
		public MiniReviewDetailBinder()
		{
		}

		// Token: 0x04024DC4 RID: 150980
		[Token(Token = "0x4024DC4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04024DC5 RID: 150981
		[Token(Token = "0x4024DC5")]
		[FieldOffset(Offset = "0x28")]
		private MiniReviewDetailAdapter m_miniReviewAdapter;

		// Token: 0x04024DC6 RID: 150982
		[Token(Token = "0x4024DC6")]
		[FieldOffset(Offset = "0x30")]
		private string m_groupId;

		// Token: 0x04024DC7 RID: 150983
		[Token(Token = "0x4024DC7")]
		[FieldOffset(Offset = "0x38")]
		private MiniReviewDetailBinder.AdapterPluginInfo m_adapterPluginInfo;

		// Token: 0x04024DC8 RID: 150984
		[Token(Token = "0x4024DC8")]
		[FieldOffset(Offset = "0x50")]
		private GameObject m_customInfoPrefab;

		// Token: 0x04024DC9 RID: 150985
		[Token(Token = "0x4024DC9")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_customLockPrefab;

		// Token: 0x04024DCA RID: 150986
		[Token(Token = "0x4024DCA")]
		[FieldOffset(Offset = "0x60")]
		private Action<string> m_onReviewStoryClicked;

		// Token: 0x04024DCB RID: 150987
		[Token(Token = "0x4024DCB")]
		[FieldOffset(Offset = "0x68")]
		private Action<string> m_onUnlockStoryClicked;

		// Token: 0x04024DCC RID: 150988
		[Token(Token = "0x4024DCC")]
		[FieldOffset(Offset = "0x70")]
		private Action<string> m_onStoryRead;

		// Token: 0x04024DCD RID: 150989
		[Token(Token = "0x4024DCD")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_finder;

		// Token: 0x04024DCE RID: 150990
		[Token(Token = "0x4024DCE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateAdapterStatus;

		// Token: 0x04024DCF RID: 150991
		[Token(Token = "0x4024DCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024DD0 RID: 150992
		[Token(Token = "0x4024DD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x04024DD1 RID: 150993
		[Token(Token = "0x4024DD1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200490B RID: 18699
		[Token(Token = "0x200490B")]
		private struct AdapterPluginInfo
		{
			// Token: 0x0601C334 RID: 115508 RVA: 0x000A78B0 File Offset: 0x000A5AB0
			[Token(Token = "0x601C334")]
			[Address(RVA = "0x15AB5F0", Offset = "0x15AA1F0", VA = "0x1815AB5F0")]
			public static MiniReviewDetailBinder.AdapterPluginInfo Create(StoryReviewChapter viewModel)
			{
				return default(MiniReviewDetailBinder.AdapterPluginInfo);
			}

			// Token: 0x0601C335 RID: 115509 RVA: 0x000A78C8 File Offset: 0x000A5AC8
			[Token(Token = "0x601C335")]
			[Address(RVA = "0x15AB660", Offset = "0x15AA260", VA = "0x1815AB660")]
			public bool ShouldRebuildAdapter(MiniReviewDetailBinder.AdapterPluginInfo prevInfo)
			{
				return default(bool);
			}

			// Token: 0x04024DD2 RID: 150994
			[Token(Token = "0x4024DD2")]
			[FieldOffset(Offset = "0x0")]
			public bool isEmpty;

			// Token: 0x04024DD3 RID: 150995
			[Token(Token = "0x4024DD3")]
			[FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x04024DD4 RID: 150996
			[Token(Token = "0x4024DD4")]
			[FieldOffset(Offset = "0x10")]
			public StoryReviewCustomType customType;
		}
	}
}
