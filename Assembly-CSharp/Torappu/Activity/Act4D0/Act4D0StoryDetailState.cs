using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200727F RID: 29311
	[Token(Token = "0x200727F")]
	public class Act4D0StoryDetailState : PopupFloatState
	{
		// Token: 0x0602983D RID: 170045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602983D")]
		[Address(RVA = "0x24E1C60", Offset = "0x24E0860", VA = "0x1824E1C60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602983E RID: 170046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602983E")]
		[Address(RVA = "0x24E1D50", Offset = "0x24E0950", VA = "0x1824E1D50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602983F RID: 170047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602983F")]
		[Address(RVA = "0x24E2050", Offset = "0x24E0C50", VA = "0x1824E2050")]
		public void OnStartButtonPressed()
		{
		}

		// Token: 0x06029840 RID: 170048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029840")]
		[Address(RVA = "0x24E20D0", Offset = "0x24E0CD0", VA = "0x1824E20D0")]
		public void ShowStory()
		{
		}

		// Token: 0x06029841 RID: 170049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029841")]
		[Address(RVA = "0x24E2480", Offset = "0x24E1080", VA = "0x1824E2480")]
		private void _TrySendFinishCurrentStoryAndPlay()
		{
		}

		// Token: 0x06029842 RID: 170050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029842")]
		[Address(RVA = "0x24E21B0", Offset = "0x24E0DB0", VA = "0x1824E21B0")]
		private void _StartStory(string storyId)
		{
		}

		// Token: 0x06029843 RID: 170051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029843")]
		[Address(RVA = "0x24E1CC0", Offset = "0x24E08C0", VA = "0x1824E1CC0")]
		public void OnBackgroundPressed()
		{
		}

		// Token: 0x06029844 RID: 170052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029844")]
		[Address(RVA = "0x24E2710", Offset = "0x24E1310", VA = "0x1824E2710")]
		public Act4D0StoryDetailState()
		{
		}

		// Token: 0x06029846 RID: 170054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029846")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403B50D RID: 242957
		[Token(Token = "0x403B50D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act4D0StoryDetailStateBean _stateBean;

		// Token: 0x0403B50E RID: 242958
		[Token(Token = "0x403B50E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _stageTitleText;

		// Token: 0x0403B50F RID: 242959
		[Token(Token = "0x403B50F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _stageDescText;

		// Token: 0x0403B510 RID: 242960
		[Token(Token = "0x403B510")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _stageSort;

		// Token: 0x0403B511 RID: 242961
		[Token(Token = "0x403B511")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _hideTopBar;

		// Token: 0x0403B512 RID: 242962
		[Token(Token = "0x403B512")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _stageImage;

		// Token: 0x0403B513 RID: 242963
		[Token(Token = "0x403B513")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B514 RID: 242964
		[Token(Token = "0x403B514")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B515 RID: 242965
		[Token(Token = "0x403B515")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStartButtonPressed;

		// Token: 0x0403B516 RID: 242966
		[Token(Token = "0x403B516")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowStory;

		// Token: 0x0403B517 RID: 242967
		[Token(Token = "0x403B517")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TrySendFinishCurrentStoryAndPlay;

		// Token: 0x0403B518 RID: 242968
		[Token(Token = "0x403B518")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StartStory;

		// Token: 0x0403B519 RID: 242969
		[Token(Token = "0x403B519")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackgroundPressed;

		// Token: 0x0403B51A RID: 242970
		[Token(Token = "0x403B51A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
