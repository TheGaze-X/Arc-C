using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006398 RID: 25496
	[Token(Token = "0x2006398")]
	public class AutoChessStageInfoChessGroupView : UISimpleRecycleLayoutItemView<AutoChessStageInfoChessGroupModel>, IHotfixable
	{
		// Token: 0x06024C4E RID: 150606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C4E")]
		[Address(RVA = "0x1FA61F0", Offset = "0x1FA4DF0", VA = "0x181FA61F0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C4F RID: 150607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C4F")]
		[Address(RVA = "0x1FA6260", Offset = "0x1FA4E60", VA = "0x181FA6260", Slot = "6")]
		protected override void OnRender(AutoChessStageInfoChessGroupModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x06024C50 RID: 150608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C50")]
		[Address(RVA = "0x1FA65C0", Offset = "0x1FA51C0", VA = "0x181FA65C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C51 RID: 150609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C51")]
		[Address(RVA = "0x1FA66E0", Offset = "0x1FA52E0", VA = "0x181FA66E0")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x06024C52 RID: 150610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C52")]
		[Address(RVA = "0x1FA67A0", Offset = "0x1FA53A0", VA = "0x181FA67A0")]
		public AutoChessStageInfoChessGroupView()
		{
		}

		// Token: 0x0403360D RID: 210445
		[Token(Token = "0x403360D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBond;

		// Token: 0x0403360E RID: 210446
		[Token(Token = "0x403360E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgBondIcon;

		// Token: 0x0403360F RID: 210447
		[Token(Token = "0x403360F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textBondName;

		// Token: 0x04033610 RID: 210448
		[Token(Token = "0x4033610")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04033611 RID: 210449
		[Token(Token = "0x4033611")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelBkg;

		// Token: 0x04033612 RID: 210450
		[Token(Token = "0x4033612")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04033613 RID: 210451
		[Token(Token = "0x4033613")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessStageInfoChessGroupView.Adapter m_adapter;

		// Token: 0x04033614 RID: 210452
		[Token(Token = "0x4033614")]
		[FieldOffset(Offset = "0x60")]
		private List<AutoChessStageInfoChessViewModel> m_cachedChessList;

		// Token: 0x04033615 RID: 210453
		[Token(Token = "0x4033615")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033616 RID: 210454
		[Token(Token = "0x4033616")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033617 RID: 210455
		[Token(Token = "0x4033617")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033618 RID: 210456
		[Token(Token = "0x4033618")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033619 RID: 210457
		[Token(Token = "0x4033619")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x0403361A RID: 210458
		[Token(Token = "0x403361A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006399 RID: 25497
		[Token(Token = "0x2006399")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06024C53 RID: 150611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024C53")]
			[Address(RVA = "0x1F96D30", Offset = "0x1F95930", VA = "0x181F96D30")]
			public Adapter(AutoChessStageInfoChessGroupView closure)
			{
			}

			// Token: 0x170056CB RID: 22219
			// (get) Token: 0x06024C54 RID: 150612 RVA: 0x000C56B8 File Offset: 0x000C38B8
			[Token(Token = "0x170056CB")]
			public override int count
			{
				[Token(Token = "0x6024C54")]
				[Address(RVA = "0x1F97020", Offset = "0x1F95C20", VA = "0x181F97020", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024C55 RID: 150613 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024C55")]
			[Address(RVA = "0x1F96930", Offset = "0x1F95530", VA = "0x181F96930", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403361B RID: 210459
			[Token(Token = "0x403361B")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessStageInfoChessGroupView m_closure;

			// Token: 0x0403361C RID: 210460
			[Token(Token = "0x403361C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403361D RID: 210461
			[Token(Token = "0x403361D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403361E RID: 210462
			[Token(Token = "0x403361E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
