using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077DC RID: 30684
	[Token(Token = "0x20077DC")]
	public class Act1VHalfIdleRecruitNormalGachaDialog : UICompDialog<GachaDialogOption>, ICompDialogCallBack
	{
		// Token: 0x0602B0E5 RID: 176357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0E5")]
		[Address(RVA = "0x26DD930", Offset = "0x26DC530", VA = "0x1826DD930")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B0E6 RID: 176358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0E6")]
		[Address(RVA = "0x26DE130", Offset = "0x26DCD30", VA = "0x1826DE130")]
		private void _Render(Act1VHalfIdleRecruitNormalGachaDialog.NormalGachaViewModel viewModel)
		{
		}

		// Token: 0x0602B0E7 RID: 176359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0E7")]
		[Address(RVA = "0x26DD6B0", Offset = "0x26DC2B0", VA = "0x1826DD6B0", Slot = "18")]
		protected override void OnRender(GachaDialogOption input)
		{
		}

		// Token: 0x0602B0E8 RID: 176360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0E8")]
		[Address(RVA = "0x26DDDF0", Offset = "0x26DC9F0", VA = "0x1826DDDF0")]
		private void _OnIncreaseBtnClicked()
		{
		}

		// Token: 0x0602B0E9 RID: 176361 RVA: 0x000DAB50 File Offset: 0x000D8D50
		[Token(Token = "0x602B0E9")]
		[Address(RVA = "0x26DDEF0", Offset = "0x26DCAF0", VA = "0x1826DDEF0")]
		private bool _OnIncreaseBtnLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0602B0EA RID: 176362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0EA")]
		[Address(RVA = "0x26DDBE0", Offset = "0x26DC7E0", VA = "0x1826DDBE0")]
		private void _OnDecreaseBtnClicked()
		{
		}

		// Token: 0x0602B0EB RID: 176363 RVA: 0x000DAB68 File Offset: 0x000D8D68
		[Token(Token = "0x602B0EB")]
		[Address(RVA = "0x26DDCE0", Offset = "0x26DC8E0", VA = "0x1826DDCE0")]
		private bool _OnDecreaseBtnLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0602B0EC RID: 176364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0EC")]
		[Address(RVA = "0x26DE360", Offset = "0x26DCF60", VA = "0x1826DE360")]
		private void _SendNormalGachaRequest()
		{
		}

		// Token: 0x0602B0ED RID: 176365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0ED")]
		[Address(RVA = "0x26DE000", Offset = "0x26DCC00", VA = "0x1826DE000")]
		private void _OpenRecruitResultDialog(Act1VHalfIdleRecruitResultDialog.Options options)
		{
		}

		// Token: 0x0602B0EE RID: 176366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0EE")]
		[Address(RVA = "0x26DD260", Offset = "0x26DBE60", VA = "0x1826DD260", Slot = "19")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602B0EF RID: 176367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0EF")]
		[Address(RVA = "0x26DD610", Offset = "0x26DC210", VA = "0x1826DD610")]
		public void OnBtnMinClicked()
		{
		}

		// Token: 0x0602B0F0 RID: 176368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0F0")]
		[Address(RVA = "0x26DD570", Offset = "0x26DC170", VA = "0x1826DD570")]
		public void OnBtnMaxClicked()
		{
		}

		// Token: 0x0602B0F1 RID: 176369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0F1")]
		[Address(RVA = "0x26DD440", Offset = "0x26DC040", VA = "0x1826DD440")]
		public void OnBtnGachaClicked()
		{
		}

		// Token: 0x0602B0F2 RID: 176370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0F2")]
		[Address(RVA = "0x26DE6D0", Offset = "0x26DD2D0", VA = "0x1826DE6D0")]
		public Act1VHalfIdleRecruitNormalGachaDialog()
		{
		}

		// Token: 0x0403E31D RID: 254749
		[Token(Token = "0x403E31D")]
		private const int SIGNAL_SEND_RECRUIT_REQ = 0;

		// Token: 0x0403E31E RID: 254750
		[Token(Token = "0x403E31E")]
		private const int SIGNAL_OPEN_RESULT_DIALOG = 1;

		// Token: 0x0403E31F RID: 254751
		[Token(Token = "0x403E31F")]
		private const string FORMAT_COST_ITEM = "-{0}";

		// Token: 0x0403E320 RID: 254752
		[Token(Token = "0x403E320")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403E321 RID: 254753
		[Token(Token = "0x403E321")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UILongPressButtonEx _btnIncrease;

		// Token: 0x0403E322 RID: 254754
		[Token(Token = "0x403E322")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UILongPressButtonEx _btnDecrease;

		// Token: 0x0403E323 RID: 254755
		[Token(Token = "0x403E323")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textCurrItemCount;

		// Token: 0x0403E324 RID: 254756
		[Token(Token = "0x403E324")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textSelectedGachaTimes;

		// Token: 0x0403E325 RID: 254757
		[Token(Token = "0x403E325")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textSelectedItemCostAvailable;

		// Token: 0x0403E326 RID: 254758
		[Token(Token = "0x403E326")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textSelectedItemCostDisabled;

		// Token: 0x0403E327 RID: 254759
		[Token(Token = "0x403E327")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _pnlAvailable;

		// Token: 0x0403E328 RID: 254760
		[Token(Token = "0x403E328")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _pnlDisabled;

		// Token: 0x0403E329 RID: 254761
		[Token(Token = "0x403E329")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _gachaItemName;

		// Token: 0x0403E32A RID: 254762
		[Token(Token = "0x403E32A")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_inited;

		// Token: 0x0403E32B RID: 254763
		[Token(Token = "0x403E32B")]
		[FieldOffset(Offset = "0xD0")]
		private UIAnimationTween m_showTween;

		// Token: 0x0403E32C RID: 254764
		[Token(Token = "0x403E32C")]
		[FieldOffset(Offset = "0xD8")]
		private Act1VHalfIdleRecruitNormalGachaDialog.NormalGachaViewModel m_viewModel;

		// Token: 0x0403E32D RID: 254765
		[Token(Token = "0x403E32D")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E32E RID: 254766
		[Token(Token = "0x403E32E")]
		[FieldOffset(Offset = "0xF0")]
		private int m_resultDialogInstId;

		// Token: 0x0403E32F RID: 254767
		[Token(Token = "0x403E32F")]
		[FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E330 RID: 254768
		[Token(Token = "0x403E330")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E331 RID: 254769
		[Token(Token = "0x403E331")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403E332 RID: 254770
		[Token(Token = "0x403E332")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E333 RID: 254771
		[Token(Token = "0x403E333")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnClicked;

		// Token: 0x0403E334 RID: 254772
		[Token(Token = "0x403E334")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnLongPressed;

		// Token: 0x0403E335 RID: 254773
		[Token(Token = "0x403E335")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnClicked;

		// Token: 0x0403E336 RID: 254774
		[Token(Token = "0x403E336")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnLongPressed;

		// Token: 0x0403E337 RID: 254775
		[Token(Token = "0x403E337")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendNormalGachaRequest;

		// Token: 0x0403E338 RID: 254776
		[Token(Token = "0x403E338")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OpenRecruitResultDialog;

		// Token: 0x0403E339 RID: 254777
		[Token(Token = "0x403E339")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403E33A RID: 254778
		[Token(Token = "0x403E33A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnMinClicked;

		// Token: 0x0403E33B RID: 254779
		[Token(Token = "0x403E33B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnMaxClicked;

		// Token: 0x0403E33C RID: 254780
		[Token(Token = "0x403E33C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnGachaClicked;

		// Token: 0x0403E33D RID: 254781
		[Token(Token = "0x403E33D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077DD RID: 30685
		[Token(Token = "0x20077DD")]
		public class NormalGachaViewModel : IHotfixable
		{
			// Token: 0x0602B0F5 RID: 176373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0F5")]
			[Address(RVA = "0x26EB7D0", Offset = "0x26EA3D0", VA = "0x1826EB7D0")]
			public void LoadData(string actId, string gachaPoolId)
			{
			}

			// Token: 0x0602B0F6 RID: 176374 RVA: 0x000DAB80 File Offset: 0x000D8D80
			[Token(Token = "0x602B0F6")]
			[Address(RVA = "0x26EBBC0", Offset = "0x26EA7C0", VA = "0x1826EBBC0")]
			public bool ModifySelectedGachaTimes(int offset)
			{
				return default(bool);
			}

			// Token: 0x0602B0F7 RID: 176375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0F7")]
			[Address(RVA = "0x26EBAF0", Offset = "0x26EA6F0", VA = "0x1826EBAF0")]
			public void ModifySelectedGachaTimesToTarget(int targetGachaTimes)
			{
			}

			// Token: 0x0602B0F8 RID: 176376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0F8")]
			[Address(RVA = "0x26EBC60", Offset = "0x26EA860", VA = "0x1826EBC60")]
			public NormalGachaViewModel()
			{
			}

			// Token: 0x0403E33E RID: 254782
			[Token(Token = "0x403E33E")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E33F RID: 254783
			[Token(Token = "0x403E33F")]
			[FieldOffset(Offset = "0x18")]
			public string gachaPoolId;

			// Token: 0x0403E340 RID: 254784
			[Token(Token = "0x403E340")]
			[FieldOffset(Offset = "0x20")]
			public int gachaPoolSortId;

			// Token: 0x0403E341 RID: 254785
			[Token(Token = "0x403E341")]
			[FieldOffset(Offset = "0x24")]
			public Act1VHalfIdleGachaPoolType gachaPoolType;

			// Token: 0x0403E342 RID: 254786
			[Token(Token = "0x403E342")]
			[FieldOffset(Offset = "0x28")]
			public string itemId;

			// Token: 0x0403E343 RID: 254787
			[Token(Token = "0x403E343")]
			[FieldOffset(Offset = "0x30")]
			public string gachaItemName;

			// Token: 0x0403E344 RID: 254788
			[Token(Token = "0x403E344")]
			[FieldOffset(Offset = "0x38")]
			public int currItemCount;

			// Token: 0x0403E345 RID: 254789
			[Token(Token = "0x403E345")]
			[FieldOffset(Offset = "0x3C")]
			public int currGachaTimes;

			// Token: 0x0403E346 RID: 254790
			[Token(Token = "0x403E346")]
			[FieldOffset(Offset = "0x40")]
			public int availableGachaTimes;

			// Token: 0x0403E347 RID: 254791
			[Token(Token = "0x403E347")]
			[FieldOffset(Offset = "0x44")]
			public int selectedGachaTimes;

			// Token: 0x0403E348 RID: 254792
			[Token(Token = "0x403E348")]
			[FieldOffset(Offset = "0x48")]
			public int selectedCostItemCount;

			// Token: 0x0403E349 RID: 254793
			[Token(Token = "0x403E349")]
			[FieldOffset(Offset = "0x50")]
			public Act1VHalfIdleGachaPoolData gachaPoolData;

			// Token: 0x0403E34A RID: 254794
			[Token(Token = "0x403E34A")]
			[FieldOffset(Offset = "0x58")]
			public int maxAvailableGachaTimes;

			// Token: 0x0403E34B RID: 254795
			[Token(Token = "0x403E34B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403E34C RID: 254796
			[Token(Token = "0x403E34C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ModifySelectedGachaTimes;

			// Token: 0x0403E34D RID: 254797
			[Token(Token = "0x403E34D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ModifySelectedGachaTimesToTarget;

			// Token: 0x0403E34E RID: 254798
			[Token(Token = "0x403E34E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
