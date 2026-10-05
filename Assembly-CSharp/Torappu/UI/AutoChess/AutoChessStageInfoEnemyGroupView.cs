using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200639C RID: 25500
	[Token(Token = "0x200639C")]
	public class AutoChessStageInfoEnemyGroupView : UISimpleRecycleLayoutItemView<AutoChessStageInfoEnemyGroupModel>, IHotfixable
	{
		// Token: 0x06024C5B RID: 150619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C5B")]
		[Address(RVA = "0x1FA73A0", Offset = "0x1FA5FA0", VA = "0x181FA73A0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C5C RID: 150620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C5C")]
		[Address(RVA = "0x1FA7410", Offset = "0x1FA6010", VA = "0x181FA7410", Slot = "6")]
		protected override void OnRender(AutoChessStageInfoEnemyGroupModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x06024C5D RID: 150621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C5D")]
		[Address(RVA = "0x1FA7780", Offset = "0x1FA6380", VA = "0x181FA7780")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C5E RID: 150622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C5E")]
		[Address(RVA = "0x1FA78A0", Offset = "0x1FA64A0", VA = "0x181FA78A0")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x06024C5F RID: 150623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C5F")]
		[Address(RVA = "0x1FA7960", Offset = "0x1FA6560", VA = "0x181FA7960")]
		public AutoChessStageInfoEnemyGroupView()
		{
		}

		// Token: 0x04033628 RID: 210472
		[Token(Token = "0x4033628")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBoss;

		// Token: 0x04033629 RID: 210473
		[Token(Token = "0x4033629")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgBossIcon;

		// Token: 0x0403362A RID: 210474
		[Token(Token = "0x403362A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textBossName;

		// Token: 0x0403362B RID: 210475
		[Token(Token = "0x403362B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textBossDesc;

		// Token: 0x0403362C RID: 210476
		[Token(Token = "0x403362C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403362D RID: 210477
		[Token(Token = "0x403362D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelBkg;

		// Token: 0x0403362E RID: 210478
		[Token(Token = "0x403362E")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403362F RID: 210479
		[Token(Token = "0x403362F")]
		[FieldOffset(Offset = "0x60")]
		private AutoChessStageInfoEnemyGroupView.Adapter m_adapter;

		// Token: 0x04033630 RID: 210480
		[Token(Token = "0x4033630")]
		[FieldOffset(Offset = "0x68")]
		private List<AutoChessStageInfoEnemyTypeViewModel> m_cachedItemModel;

		// Token: 0x04033631 RID: 210481
		[Token(Token = "0x4033631")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033632 RID: 210482
		[Token(Token = "0x4033632")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033633 RID: 210483
		[Token(Token = "0x4033633")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033634 RID: 210484
		[Token(Token = "0x4033634")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x04033635 RID: 210485
		[Token(Token = "0x4033635")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200639D RID: 25501
		[Token(Token = "0x200639D")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06024C60 RID: 150624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024C60")]
			[Address(RVA = "0x1F96EB0", Offset = "0x1F95AB0", VA = "0x181F96EB0")]
			public Adapter(AutoChessStageInfoEnemyGroupView closure)
			{
			}

			// Token: 0x170056CC RID: 22220
			// (get) Token: 0x06024C61 RID: 150625 RVA: 0x000C56D0 File Offset: 0x000C38D0
			[Token(Token = "0x170056CC")]
			public override int count
			{
				[Token(Token = "0x6024C61")]
				[Address(RVA = "0x1F96FA0", Offset = "0x1F95BA0", VA = "0x181F96FA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024C62 RID: 150626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024C62")]
			[Address(RVA = "0x1F966F0", Offset = "0x1F952F0", VA = "0x181F966F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04033636 RID: 210486
			[Token(Token = "0x4033636")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessStageInfoEnemyGroupView m_closure;

			// Token: 0x04033637 RID: 210487
			[Token(Token = "0x4033637")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033638 RID: 210488
			[Token(Token = "0x4033638")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033639 RID: 210489
			[Token(Token = "0x4033639")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
