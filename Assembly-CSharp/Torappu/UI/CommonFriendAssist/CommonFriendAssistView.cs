using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CommonFriendAssist
{
	// Token: 0x02005BCD RID: 23501
	[Token(Token = "0x2005BCD")]
	public class CommonFriendAssistView : DataBinder<CommonFriendAssistViewModelProperty>
	{
		// Token: 0x17004FC0 RID: 20416
		// (get) Token: 0x06022142 RID: 139586 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022143 RID: 139587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FC0")]
		public CommonFriendAssistView.ICtrl ctrl
		{
			[Token(Token = "0x6022142")]
			[Address(RVA = "0x1C8F350", Offset = "0x1C8DF50", VA = "0x181C8F350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022143")]
			[Address(RVA = "0x1C8F3B0", Offset = "0x1C8DFB0", VA = "0x181C8F3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022144 RID: 139588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022144")]
		[Address(RVA = "0x1C8EC60", Offset = "0x1C8D860", VA = "0x181C8EC60", Slot = "7")]
		public override void OnValueChanged(CommonFriendAssistViewModelProperty property)
		{
		}

		// Token: 0x06022145 RID: 139589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022145")]
		[Address(RVA = "0x1C8F0B0", Offset = "0x1C8DCB0", VA = "0x181C8F0B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022146 RID: 139590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022146")]
		[Address(RVA = "0x1C8EB70", Offset = "0x1C8D770", VA = "0x181C8EB70")]
		public void EventOnRefresh()
		{
		}

		// Token: 0x06022147 RID: 139591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022147")]
		[Address(RVA = "0x1C8EF40", Offset = "0x1C8DB40", VA = "0x181C8EF40")]
		private void _EventOnStarFriendTabClick(bool prevState)
		{
		}

		// Token: 0x06022148 RID: 139592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022148")]
		[Address(RVA = "0x1C8F2E0", Offset = "0x1C8DEE0", VA = "0x181C8F2E0")]
		public CommonFriendAssistView()
		{
		}

		// Token: 0x0402EBF2 RID: 191474
		[Token(Token = "0x402EBF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _tips;

		// Token: 0x0402EBF3 RID: 191475
		[Token(Token = "0x402EBF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _profList;

		// Token: 0x0402EBF4 RID: 191476
		[Token(Token = "0x402EBF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _assistList;

		// Token: 0x0402EBF5 RID: 191477
		[Token(Token = "0x402EBF5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _emptyList;

		// Token: 0x0402EBF6 RID: 191478
		[Token(Token = "0x402EBF6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SquadStarFriendTabView _starFriendTabView;

		// Token: 0x0402EBF7 RID: 191479
		[Token(Token = "0x402EBF7")]
		[FieldOffset(Offset = "0x48")]
		private CommonFriendAssistView.ProfTabAdapter _profTabAdapter;

		// Token: 0x0402EBF8 RID: 191480
		[Token(Token = "0x402EBF8")]
		[FieldOffset(Offset = "0x50")]
		private CommonFriendAssistView.AssistItemAdapter _assistItemAdapter;

		// Token: 0x0402EBFA RID: 191482
		[Token(Token = "0x402EBFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ctrl;

		// Token: 0x0402EBFB RID: 191483
		[Token(Token = "0x402EBFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ctrl;

		// Token: 0x0402EBFC RID: 191484
		[Token(Token = "0x402EBFC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402EBFD RID: 191485
		[Token(Token = "0x402EBFD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EBFE RID: 191486
		[Token(Token = "0x402EBFE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnRefresh;

		// Token: 0x0402EBFF RID: 191487
		[Token(Token = "0x402EBFF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnStarFriendTabClick;

		// Token: 0x0402EC00 RID: 191488
		[Token(Token = "0x402EC00")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BCE RID: 23502
		[Token(Token = "0x2005BCE")]
		public interface ICtrl : CommonFriendAssistItem.ICtrl, CommonFriendAssistProfessionTabView.ICtrl
		{
			// Token: 0x06022149 RID: 139593
			[Token(Token = "0x6022149")]
			void Refresh();

			// Token: 0x0602214A RID: 139594
			[Token(Token = "0x602214A")]
			void SetStarFriendTab(bool prevState);
		}

		// Token: 0x02005BCF RID: 23503
		[Token(Token = "0x2005BCF")]
		private class ProfTabAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004FC1 RID: 20417
			// (get) Token: 0x0602214B RID: 139595 RVA: 0x000BC4D8 File Offset: 0x000BA6D8
			[Token(Token = "0x17004FC1")]
			public override int count
			{
				[Token(Token = "0x602214B")]
				[Address(RVA = "0x1C98D80", Offset = "0x1C97980", VA = "0x181C98D80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602214C RID: 139596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602214C")]
			[Address(RVA = "0x1C98A30", Offset = "0x1C97630", VA = "0x181C98A30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602214D RID: 139597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602214D")]
			[Address(RVA = "0x1C98D20", Offset = "0x1C97920", VA = "0x181C98D20")]
			public ProfTabAdapter()
			{
			}

			// Token: 0x0402EC01 RID: 191489
			[Token(Token = "0x402EC01")]
			[FieldOffset(Offset = "0x20")]
			public CommonFriendAssistView closure;

			// Token: 0x0402EC02 RID: 191490
			[Token(Token = "0x402EC02")]
			[FieldOffset(Offset = "0x28")]
			public List<CommonFriendAssistViewModel.ProfTabModel> tabList;

			// Token: 0x0402EC03 RID: 191491
			[Token(Token = "0x402EC03")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EC04 RID: 191492
			[Token(Token = "0x402EC04")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402EC05 RID: 191493
			[Token(Token = "0x402EC05")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005BD0 RID: 23504
		[Token(Token = "0x2005BD0")]
		private class AssistItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004FC2 RID: 20418
			// (get) Token: 0x0602214E RID: 139598 RVA: 0x000BC4F0 File Offset: 0x000BA6F0
			[Token(Token = "0x17004FC2")]
			public override int count
			{
				[Token(Token = "0x602214E")]
				[Address(RVA = "0x1C85650", Offset = "0x1C84250", VA = "0x181C85650", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602214F RID: 139599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602214F")]
			[Address(RVA = "0x1C85430", Offset = "0x1C84030", VA = "0x181C85430", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022150 RID: 139600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022150")]
			[Address(RVA = "0x1C855F0", Offset = "0x1C841F0", VA = "0x181C855F0")]
			public AssistItemAdapter()
			{
			}

			// Token: 0x0402EC06 RID: 191494
			[Token(Token = "0x402EC06")]
			[FieldOffset(Offset = "0x20")]
			public CommonFriendAssistView colusure;

			// Token: 0x0402EC07 RID: 191495
			[Token(Token = "0x402EC07")]
			[FieldOffset(Offset = "0x28")]
			public List<CommonFriendAssistViewModel.FriendItemModel> assistList;

			// Token: 0x0402EC08 RID: 191496
			[Token(Token = "0x402EC08")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402EC09 RID: 191497
			[Token(Token = "0x402EC09")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402EC0A RID: 191498
			[Token(Token = "0x402EC0A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
