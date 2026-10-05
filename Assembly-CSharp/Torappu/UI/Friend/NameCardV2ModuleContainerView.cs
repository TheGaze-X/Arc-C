using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E13 RID: 19987
	[Token(Token = "0x2004E13")]
	public class NameCardV2ModuleContainerView : DataBinder<NameCardV2Property>
	{
		// Token: 0x0601DDC5 RID: 122309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDC5")]
		[Address(RVA = "0x1777AE0", Offset = "0x17766E0", VA = "0x181777AE0")]
		public void Update()
		{
		}

		// Token: 0x0601DDC6 RID: 122310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDC6")]
		[Address(RVA = "0x1777860", Offset = "0x1776460", VA = "0x181777860", Slot = "7")]
		public override void OnValueChanged(NameCardV2Property property)
		{
		}

		// Token: 0x0601DDC7 RID: 122311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDC7")]
		[Address(RVA = "0x1777EE0", Offset = "0x1776AE0", VA = "0x181777EE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DDC8 RID: 122312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDC8")]
		[Address(RVA = "0x1778950", Offset = "0x1777550", VA = "0x181778950")]
		private void _RenderAndSortUnselectedModules(ListDict<string, NameCardV2RemovableModuleBaseModel> listDict)
		{
		}

		// Token: 0x0601DDC9 RID: 122313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDC9")]
		[Address(RVA = "0x1778280", Offset = "0x1776E80", VA = "0x181778280")]
		private void _RenderAndSortUnselectedModulesWithTween(ListDict<string, NameCardV2RemovableModuleBaseModel> listDict)
		{
		}

		// Token: 0x0601DDCA RID: 122314 RVA: 0x000AC8C0 File Offset: 0x000AAAC0
		[Token(Token = "0x601DDCA")]
		[Address(RVA = "0x1778B50", Offset = "0x1777750", VA = "0x181778B50")]
		private int _SortUnselectedVirtualViews(KeyValuePair<string, UIRecycleLayoutAdapter.IVirtualView> a, KeyValuePair<string, UIRecycleLayoutAdapter.IVirtualView> b)
		{
			return 0;
		}

		// Token: 0x0601DDCB RID: 122315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDCB")]
		[Address(RVA = "0x1778080", Offset = "0x1776C80", VA = "0x181778080")]
		private void _OnModuleHidden(string moduleId)
		{
		}

		// Token: 0x0601DDCC RID: 122316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DDCC")]
		[Address(RVA = "0x1777BB0", Offset = "0x17767B0", VA = "0x181777BB0")]
		private UIRecycleLayoutAdapter.IVirtualView _GetRightPanelModuleVirtualView(NameCardV2RemovableModuleBaseModel moduleModel)
		{
			return null;
		}

		// Token: 0x0601DDCD RID: 122317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDCD")]
		[Address(RVA = "0x17777D0", Offset = "0x17763D0", VA = "0x1817777D0")]
		public void CloseSelectPanel()
		{
		}

		// Token: 0x0601DDCE RID: 122318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DDCE")]
		[Address(RVA = "0x1778D40", Offset = "0x1777940", VA = "0x181778D40")]
		public NameCardV2ModuleContainerView()
		{
		}

		// Token: 0x04027953 RID: 162131
		[Token(Token = "0x4027953")]
		private const int DEFAULT_NAME_CARD_SKIN_TMPL = 0;

		// Token: 0x04027954 RID: 162132
		[Token(Token = "0x4027954")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _listEmptyItem;

		// Token: 0x04027955 RID: 162133
		[Token(Token = "0x4027955")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04027956 RID: 162134
		[Token(Token = "0x4027956")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x04027957 RID: 162135
		[Token(Token = "0x4027957")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04027958 RID: 162136
		[Token(Token = "0x4027958")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027959 RID: 162137
		[Token(Token = "0x4027959")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402795A RID: 162138
		[Token(Token = "0x402795A")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedEditSeqNum;

		// Token: 0x0402795B RID: 162139
		[Token(Token = "0x402795B")]
		[FieldOffset(Offset = "0x68")]
		private ListDict<string, UIRecycleLayoutAdapter.IVirtualView> m_unselectedViews;

		// Token: 0x0402795C RID: 162140
		[Token(Token = "0x402795C")]
		[FieldOffset(Offset = "0x70")]
		private NameCardV2ModuleContainerView.PanelRightAdpter m_adapter;

		// Token: 0x0402795D RID: 162141
		[Token(Token = "0x402795D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402795E RID: 162142
		[Token(Token = "0x402795E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402795F RID: 162143
		[Token(Token = "0x402795F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027960 RID: 162144
		[Token(Token = "0x4027960")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderAndSortUnselectedModules;

		// Token: 0x04027961 RID: 162145
		[Token(Token = "0x4027961")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderAndSortUnselectedModulesWithTween;

		// Token: 0x04027962 RID: 162146
		[Token(Token = "0x4027962")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SortUnselectedVirtualViews;

		// Token: 0x04027963 RID: 162147
		[Token(Token = "0x4027963")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnModuleHidden;

		// Token: 0x04027964 RID: 162148
		[Token(Token = "0x4027964")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetRightPanelModuleVirtualView;

		// Token: 0x04027965 RID: 162149
		[Token(Token = "0x4027965")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CloseSelectPanel;

		// Token: 0x04027966 RID: 162150
		[Token(Token = "0x4027966")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E14 RID: 19988
		[Token(Token = "0x2004E14")]
		private class PanelRightAdpter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601DDCF RID: 122319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDCF")]
			[Address(RVA = "0x177D0B0", Offset = "0x177BCB0", VA = "0x18177D0B0")]
			public PanelRightAdpter(NameCardV2ModuleContainerView closure)
			{
			}

			// Token: 0x0601DDD0 RID: 122320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DDD0")]
			[Address(RVA = "0x177C880", Offset = "0x177B480", VA = "0x18177C880", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0601DDD1 RID: 122321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDD1")]
			[Address(RVA = "0x177CBC0", Offset = "0x177B7C0", VA = "0x18177CBC0")]
			public void RebuildAll()
			{
			}

			// Token: 0x0601DDD2 RID: 122322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDD2")]
			[Address(RVA = "0x177CA70", Offset = "0x177B670", VA = "0x18177CA70")]
			public void PlayViewSwitchTween(bool isShow, int index)
			{
			}

			// Token: 0x0601DDD3 RID: 122323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDD3")]
			[Address(RVA = "0x177CED0", Offset = "0x177BAD0", VA = "0x18177CED0")]
			public void ResetViewSwitchTween(bool isShow, int index)
			{
			}

			// Token: 0x0601DDD4 RID: 122324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDD4")]
			[Address(RVA = "0x177CD80", Offset = "0x177B980", VA = "0x18177CD80")]
			public void RenderView(int index, NameCardV2ModuleBaseModel model)
			{
			}

			// Token: 0x0601DDD5 RID: 122325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDD5")]
			[Address(RVA = "0x177CC50", Offset = "0x177B850", VA = "0x18177CC50")]
			public void RemoveView(UIRecycleLayoutAdapter.IVirtualView view)
			{
			}

			// Token: 0x0601DDD6 RID: 122326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDD6")]
			[Address(RVA = "0x177C920", Offset = "0x177B520", VA = "0x18177C920")]
			public void InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view)
			{
			}

			// Token: 0x0601DDD7 RID: 122327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DDD7")]
			[Address(RVA = "0x177D020", Offset = "0x177BC20", VA = "0x18177D020")]
			public void UpdateSize()
			{
			}

			// Token: 0x04027967 RID: 162151
			[Token(Token = "0x4027967")]
			[FieldOffset(Offset = "0x18")]
			private NameCardV2ModuleContainerView m_closure;

			// Token: 0x04027968 RID: 162152
			[Token(Token = "0x4027968")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027969 RID: 162153
			[Token(Token = "0x4027969")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402796A RID: 162154
			[Token(Token = "0x402796A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildAll;

			// Token: 0x0402796B RID: 162155
			[Token(Token = "0x402796B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PlayViewSwitchTween;

			// Token: 0x0402796C RID: 162156
			[Token(Token = "0x402796C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ResetViewSwitchTween;

			// Token: 0x0402796D RID: 162157
			[Token(Token = "0x402796D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402796E RID: 162158
			[Token(Token = "0x402796E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RemoveView;

			// Token: 0x0402796F RID: 162159
			[Token(Token = "0x402796F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_InsertView;

			// Token: 0x04027970 RID: 162160
			[Token(Token = "0x4027970")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_UpdateSize;
		}
	}
}
