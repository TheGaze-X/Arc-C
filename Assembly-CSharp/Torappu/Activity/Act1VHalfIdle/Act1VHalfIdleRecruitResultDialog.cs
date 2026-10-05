using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077E8 RID: 30696
	[Token(Token = "0x20077E8")]
	public class Act1VHalfIdleRecruitResultDialog : UICompDialog<Act1VHalfIdleRecruitResultDialog.Options>
	{
		// Token: 0x0602B11E RID: 176414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B11E")]
		[Address(RVA = "0x26E00F0", Offset = "0x26DECF0", VA = "0x1826E00F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B11F RID: 176415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B11F")]
		[Address(RVA = "0x26E0040", Offset = "0x26DEC40", VA = "0x1826E0040", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleRecruitResultDialog.Options input)
		{
		}

		// Token: 0x0602B120 RID: 176416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B120")]
		[Address(RVA = "0x26DFEA0", Offset = "0x26DEAA0", VA = "0x1826DFEA0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602B121 RID: 176417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B121")]
		[Address(RVA = "0x26DFF00", Offset = "0x26DEB00", VA = "0x1826DFF00")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x0602B122 RID: 176418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B122")]
		[Address(RVA = "0x26E0370", Offset = "0x26DEF70", VA = "0x1826E0370")]
		public Act1VHalfIdleRecruitResultDialog()
		{
		}

		// Token: 0x0602B123 RID: 176419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B123")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403E39B RID: 254875
		[Token(Token = "0x403E39B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0403E39C RID: 254876
		[Token(Token = "0x403E39C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403E39D RID: 254877
		[Token(Token = "0x403E39D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _recycleLayout;

		// Token: 0x0403E39E RID: 254878
		[Token(Token = "0x403E39E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Act1VHalfIdleRecruitResultTitleItemView _titleItemPrefab;

		// Token: 0x0403E39F RID: 254879
		[Token(Token = "0x403E39F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Act1VHalfIdleRecruitResultCharItemView _charItemPrefab;

		// Token: 0x0403E3A0 RID: 254880
		[Token(Token = "0x403E3A0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int _columnCount;

		// Token: 0x0403E3A1 RID: 254881
		[Token(Token = "0x403E3A1")]
		[FieldOffset(Offset = "0xA8")]
		private UIAnimationTween m_showTween;

		// Token: 0x0403E3A2 RID: 254882
		[Token(Token = "0x403E3A2")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x0403E3A3 RID: 254883
		[Token(Token = "0x403E3A3")]
		[FieldOffset(Offset = "0xB8")]
		private Act1VHalfIdleRecruitResultDialog.Adapter m_adapter;

		// Token: 0x0403E3A4 RID: 254884
		[Token(Token = "0x403E3A4")]
		[FieldOffset(Offset = "0xC0")]
		private Act1VHalfIdleRecruitResultDialog.RecruitResultViewModel m_viewModel;

		// Token: 0x0403E3A5 RID: 254885
		[Token(Token = "0x403E3A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E3A6 RID: 254886
		[Token(Token = "0x403E3A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E3A7 RID: 254887
		[Token(Token = "0x403E3A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403E3A8 RID: 254888
		[Token(Token = "0x403E3A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x0403E3A9 RID: 254889
		[Token(Token = "0x403E3A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077E9 RID: 30697
		[Token(Token = "0x20077E9")]
		public class Options
		{
			// Token: 0x0602B124 RID: 176420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B124")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0403E3AA RID: 254890
			[Token(Token = "0x403E3AA")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E3AB RID: 254891
			[Token(Token = "0x403E3AB")]
			[FieldOffset(Offset = "0x18")]
			public List<string> newChar;

			// Token: 0x0403E3AC RID: 254892
			[Token(Token = "0x403E3AC")]
			[FieldOffset(Offset = "0x20")]
			public List<string> oldChar;

			// Token: 0x0403E3AD RID: 254893
			[Token(Token = "0x403E3AD")]
			[FieldOffset(Offset = "0x28")]
			public int ticketCount;
		}

		// Token: 0x020077EA RID: 30698
		[Token(Token = "0x20077EA")]
		private class RecruitResultViewModel : IHotfixable
		{
			// Token: 0x0602B125 RID: 176421 RVA: 0x000DABE0 File Offset: 0x000D8DE0
			[Token(Token = "0x602B125")]
			[Address(RVA = "0x26ECB20", Offset = "0x26EB720", VA = "0x1826ECB20")]
			private int _CompareChar(Act1VHalfIdleCharAvatarViewModel lhs, Act1VHalfIdleCharAvatarViewModel rhs)
			{
				return 0;
			}

			// Token: 0x0602B126 RID: 176422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B126")]
			[Address(RVA = "0x26EC840", Offset = "0x26EB440", VA = "0x1826EC840")]
			public void LoadData(Act1VHalfIdleRecruitResultDialog.Options options)
			{
			}

			// Token: 0x0602B127 RID: 176423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B127")]
			[Address(RVA = "0x26ECC80", Offset = "0x26EB880", VA = "0x1826ECC80")]
			private Act1VHalfIdleCharAvatarViewModel _GetAct1VHalfIdleCharAvatarViewModel(string charId)
			{
				return null;
			}

			// Token: 0x0602B128 RID: 176424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B128")]
			[Address(RVA = "0x26ECE60", Offset = "0x26EBA60", VA = "0x1826ECE60")]
			public RecruitResultViewModel()
			{
			}

			// Token: 0x0403E3AE RID: 254894
			[Token(Token = "0x403E3AE")]
			[FieldOffset(Offset = "0x10")]
			public List<Act1VHalfIdleCharAvatarViewModel> newChar;

			// Token: 0x0403E3AF RID: 254895
			[Token(Token = "0x403E3AF")]
			[FieldOffset(Offset = "0x18")]
			public List<Act1VHalfIdleCharAvatarViewModel> oldChar;

			// Token: 0x0403E3B0 RID: 254896
			[Token(Token = "0x403E3B0")]
			[FieldOffset(Offset = "0x20")]
			public int refundItemCount;

			// Token: 0x0403E3B1 RID: 254897
			[Token(Token = "0x403E3B1")]
			[FieldOffset(Offset = "0x28")]
			public string actId;

			// Token: 0x0403E3B2 RID: 254898
			[Token(Token = "0x403E3B2")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, string> charIdMap;

			// Token: 0x0403E3B3 RID: 254899
			[Token(Token = "0x403E3B3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__CompareChar;

			// Token: 0x0403E3B4 RID: 254900
			[Token(Token = "0x403E3B4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403E3B5 RID: 254901
			[Token(Token = "0x403E3B5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__GetAct1VHalfIdleCharAvatarViewModel;

			// Token: 0x0403E3B6 RID: 254902
			[Token(Token = "0x403E3B6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077EB RID: 30699
		[Token(Token = "0x20077EB")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0602B129 RID: 176425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B129")]
			[Address(RVA = "0x26E9BB0", Offset = "0x26E87B0", VA = "0x1826E9BB0")]
			public Adapter(Act1VHalfIdleRecruitResultDialog closure)
			{
			}

			// Token: 0x0602B12A RID: 176426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B12A")]
			[Address(RVA = "0x26E80C0", Offset = "0x26E6CC0", VA = "0x1826E80C0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0602B12B RID: 176427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B12B")]
			[Address(RVA = "0x26E8320", Offset = "0x26E6F20", VA = "0x1826E8320")]
			public void RebuildList(Act1VHalfIdleRecruitResultDialog.RecruitResultViewModel viewModel)
			{
			}

			// Token: 0x0403E3B7 RID: 254903
			[Token(Token = "0x403E3B7")]
			[FieldOffset(Offset = "0x18")]
			private Act1VHalfIdleRecruitResultDialog m_closure;

			// Token: 0x0403E3B8 RID: 254904
			[Token(Token = "0x403E3B8")]
			[FieldOffset(Offset = "0x20")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0403E3B9 RID: 254905
			[Token(Token = "0x403E3B9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E3BA RID: 254906
			[Token(Token = "0x403E3BA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0403E3BB RID: 254907
			[Token(Token = "0x403E3BB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;
		}
	}
}
