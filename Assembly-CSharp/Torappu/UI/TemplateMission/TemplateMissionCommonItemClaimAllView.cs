using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D87 RID: 15751
	[Token(Token = "0x2003D87")]
	public class TemplateMissionCommonItemClaimAllView : AbstractTemplateMissionItemClaimAllView
	{
		// Token: 0x06018815 RID: 100373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018815")]
		[Address(RVA = "0x110C940", Offset = "0x110B540", VA = "0x18110C940")]
		public void Render(TemplateMissionListClaimAllItemViewModel viewModel)
		{
		}

		// Token: 0x06018816 RID: 100374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018816")]
		[Address(RVA = "0x110C840", Offset = "0x110B440", VA = "0x18110C840")]
		public void EventOnClaimAllClick()
		{
		}

		// Token: 0x06018817 RID: 100375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018817")]
		[Address(RVA = "0x110CB70", Offset = "0x110B770", VA = "0x18110CB70")]
		public TemplateMissionCommonItemClaimAllView()
		{
		}

		// Token: 0x0401E06E RID: 122990
		[Token(Token = "0x401E06E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0401E06F RID: 122991
		[Token(Token = "0x401E06F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtTips;

		// Token: 0x0401E070 RID: 122992
		[Token(Token = "0x401E070")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgClaimAllBtnBg;

		// Token: 0x0401E071 RID: 122993
		[Token(Token = "0x401E071")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E072 RID: 122994
		[Token(Token = "0x401E072")]
		[FieldOffset(Offset = "0x40")]
		private TemplateMissionListClaimAllItemViewModel m_cachedViewModel;

		// Token: 0x0401E073 RID: 122995
		[Token(Token = "0x401E073")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E074 RID: 122996
		[Token(Token = "0x401E074")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClaimAllClick;

		// Token: 0x0401E075 RID: 122997
		[Token(Token = "0x401E075")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D88 RID: 15752
		[Token(Token = "0x2003D88")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<TemplateMissionCommonItemClaimAllView>
		{
			// Token: 0x06018818 RID: 100376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018818")]
			[Address(RVA = "0x111B0C0", Offset = "0x1119CC0", VA = "0x18111B0C0")]
			public VirtualView(TemplateMissionCommonItemClaimAllView prefab, TemplateMissionListClaimAllItemViewModel viewModel)
			{
			}

			// Token: 0x06018819 RID: 100377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018819")]
			[Address(RVA = "0x111AC60", Offset = "0x1119860", VA = "0x18111AC60", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601881A RID: 100378 RVA: 0x0009A9F8 File Offset: 0x00098BF8
			[Token(Token = "0x601881A")]
			[Address(RVA = "0x111ADB0", Offset = "0x11199B0", VA = "0x18111ADB0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601881B RID: 100379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601881B")]
			[Address(RVA = "0x111AF50", Offset = "0x1119B50", VA = "0x18111AF50", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601881C RID: 100380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601881C")]
			[Address(RVA = "0x111AEC0", Offset = "0x1119AC0", VA = "0x18111AEC0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0401E076 RID: 122998
			[Token(Token = "0x401E076")]
			[FieldOffset(Offset = "0x20")]
			private TemplateMissionCommonItemClaimAllView m_prefab;

			// Token: 0x0401E077 RID: 122999
			[Token(Token = "0x401E077")]
			[FieldOffset(Offset = "0x28")]
			private TemplateMissionListClaimAllItemViewModel m_viewModel;

			// Token: 0x0401E078 RID: 123000
			[Token(Token = "0x401E078")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E079 RID: 123001
			[Token(Token = "0x401E079")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401E07A RID: 123002
			[Token(Token = "0x401E07A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401E07B RID: 123003
			[Token(Token = "0x401E07B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0401E07C RID: 123004
			[Token(Token = "0x401E07C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;
		}
	}
}
