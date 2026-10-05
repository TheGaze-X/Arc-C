using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A2F RID: 23087
	[Token(Token = "0x2005A2F")]
	public class UIChooseCharDialog : UICustomDialog<UIChooseCharDialog.Options>
	{
		// Token: 0x060219E1 RID: 137697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219E1")]
		[Address(RVA = "0x1C12C10", Offset = "0x1C11810", VA = "0x181C12C10", Slot = "7")]
		protected override void OnRender(UIChooseCharDialog.Options options)
		{
		}

		// Token: 0x060219E2 RID: 137698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219E2")]
		[Address(RVA = "0x1C12B50", Offset = "0x1C11750", VA = "0x181C12B50", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060219E3 RID: 137699 RVA: 0x000BAE10 File Offset: 0x000B9010
		[Token(Token = "0x60219E3")]
		[Address(RVA = "0x1C12BB0", Offset = "0x1C117B0", VA = "0x181C12BB0", Slot = "11")]
		protected override bool IncludeNotificationCamaraForBlur()
		{
			return default(bool);
		}

		// Token: 0x060219E4 RID: 137700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219E4")]
		[Address(RVA = "0x1C13610", Offset = "0x1C12210", VA = "0x181C13610")]
		private void _RenderGroupView()
		{
		}

		// Token: 0x060219E5 RID: 137701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219E5")]
		[Address(RVA = "0x1C13260", Offset = "0x1C11E60", VA = "0x181C13260")]
		private List<UIRecycleLayoutAdapter.IVirtualView> _GenerateVirtualViews()
		{
			return null;
		}

		// Token: 0x060219E6 RID: 137702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219E6")]
		[Address(RVA = "0x1C12E20", Offset = "0x1C11A20", VA = "0x181C12E20")]
		private void _GeneRowViews(UIChooseCharDialog.RowParam rowParam, ref List<UIRecycleLayoutAdapter.IVirtualView> virtualViews)
		{
		}

		// Token: 0x060219E7 RID: 137703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219E7")]
		[Address(RVA = "0x1C13490", Offset = "0x1C12090", VA = "0x181C13490")]
		private CommonChooseCharRowComp _LoadRowComp()
		{
			return null;
		}

		// Token: 0x060219E8 RID: 137704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219E8")]
		[Address(RVA = "0x1C13570", Offset = "0x1C12170", VA = "0x181C13570")]
		private void _OnItemClick(string charId)
		{
		}

		// Token: 0x060219E9 RID: 137705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219E9")]
		[Address(RVA = "0x1C12AE0", Offset = "0x1C116E0", VA = "0x181C12AE0")]
		public void EventOnDismissClick()
		{
		}

		// Token: 0x060219EA RID: 137706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219EA")]
		[Address(RVA = "0x1C13830", Offset = "0x1C12430", VA = "0x181C13830")]
		public UIChooseCharDialog()
		{
		}

		// Token: 0x0402DF79 RID: 188281
		[Token(Token = "0x402DF79")]
		private const int ROW_COUNT = 6;

		// Token: 0x0402DF7A RID: 188282
		[Token(Token = "0x402DF7A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0402DF7B RID: 188283
		[Token(Token = "0x402DF7B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x0402DF7C RID: 188284
		[Token(Token = "0x402DF7C")]
		[FieldOffset(Offset = "0x70")]
		private UIChooseCharDialog.Options m_options;

		// Token: 0x0402DF7D RID: 188285
		[Token(Token = "0x402DF7D")]
		[FieldOffset(Offset = "0x98")]
		private UIChooseCharDialogViewModel m_viewModel;

		// Token: 0x0402DF7E RID: 188286
		[Token(Token = "0x402DF7E")]
		[FieldOffset(Offset = "0xA0")]
		private CommonSingleChooseCharGroupView m_groupView;

		// Token: 0x0402DF7F RID: 188287
		[Token(Token = "0x402DF7F")]
		[FieldOffset(Offset = "0xA8")]
		private CommonChooseCharRowComp m_rowComp;

		// Token: 0x0402DF80 RID: 188288
		[Token(Token = "0x402DF80")]
		[FieldOffset(Offset = "0xB0")]
		private UIChooseCharDialog.GroupViewBuilder m_viewBuilder;

		// Token: 0x0402DF81 RID: 188289
		[Token(Token = "0x402DF81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402DF82 RID: 188290
		[Token(Token = "0x402DF82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402DF83 RID: 188291
		[Token(Token = "0x402DF83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IncludeNotificationCamaraForBlur;

		// Token: 0x0402DF84 RID: 188292
		[Token(Token = "0x402DF84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderGroupView;

		// Token: 0x0402DF85 RID: 188293
		[Token(Token = "0x402DF85")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateVirtualViews;

		// Token: 0x0402DF86 RID: 188294
		[Token(Token = "0x402DF86")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GeneRowViews;

		// Token: 0x0402DF87 RID: 188295
		[Token(Token = "0x402DF87")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadRowComp;

		// Token: 0x0402DF88 RID: 188296
		[Token(Token = "0x402DF88")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0402DF89 RID: 188297
		[Token(Token = "0x402DF89")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnDismissClick;

		// Token: 0x0402DF8A RID: 188298
		[Token(Token = "0x402DF8A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A30 RID: 23088
		[Token(Token = "0x2005A30")]
		public struct Options
		{
			// Token: 0x0402DF8B RID: 188299
			[Token(Token = "0x402DF8B")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x0402DF8C RID: 188300
			[Token(Token = "0x402DF8C")]
			[FieldOffset(Offset = "0x8")]
			public string topDesc;

			// Token: 0x0402DF8D RID: 188301
			[Token(Token = "0x402DF8D")]
			[FieldOffset(Offset = "0x10")]
			public bool needIncludeNotificationCameraBlur;

			// Token: 0x0402DF8E RID: 188302
			[Token(Token = "0x402DF8E")]
			[FieldOffset(Offset = "0x18")]
			public List<string> charIdList;

			// Token: 0x0402DF8F RID: 188303
			[Token(Token = "0x402DF8F")]
			[FieldOffset(Offset = "0x20")]
			public Action<int, string> onCharSelected;
		}

		// Token: 0x02005A31 RID: 23089
		[Token(Token = "0x2005A31")]
		private struct RowParam
		{
			// Token: 0x0402DF90 RID: 188304
			[Token(Token = "0x402DF90")]
			[FieldOffset(Offset = "0x0")]
			public List<UIChooseCharDialogCharItemViewModel> charList;

			// Token: 0x0402DF91 RID: 188305
			[Token(Token = "0x402DF91")]
			[FieldOffset(Offset = "0x8")]
			public CommonChooseCharRowComp.OwnTagStatus ownTag;
		}

		// Token: 0x02005A32 RID: 23090
		[Token(Token = "0x2005A32")]
		private class GroupViewBuilder : CommonSingleChooseCharGroupView.AbstractViewBuilder
		{
			// Token: 0x060219EB RID: 137707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219EB")]
			[Address(RVA = "0x1C0E420", Offset = "0x1C0D020", VA = "0x181C0E420")]
			public void SetHostView(UIChooseCharDialog host)
			{
			}

			// Token: 0x060219EC RID: 137708 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60219EC")]
			[Address(RVA = "0x1C0E340", Offset = "0x1C0CF40", VA = "0x181C0E340", Slot = "4")]
			public override string GetTitleText()
			{
				return null;
			}

			// Token: 0x060219ED RID: 137709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60219ED")]
			[Address(RVA = "0x1C0E3B0", Offset = "0x1C0CFB0", VA = "0x181C0E3B0", Slot = "5")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GetVirtualViews()
			{
				return null;
			}

			// Token: 0x060219EE RID: 137710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219EE")]
			[Address(RVA = "0x1C0E4A0", Offset = "0x1C0D0A0", VA = "0x181C0E4A0")]
			public GroupViewBuilder()
			{
			}

			// Token: 0x0402DF92 RID: 188306
			[Token(Token = "0x402DF92")]
			[FieldOffset(Offset = "0x18")]
			private UIChooseCharDialog m_host;

			// Token: 0x0402DF93 RID: 188307
			[Token(Token = "0x402DF93")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetHostView;

			// Token: 0x0402DF94 RID: 188308
			[Token(Token = "0x402DF94")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTitleText;

			// Token: 0x0402DF95 RID: 188309
			[Token(Token = "0x402DF95")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetVirtualViews;

			// Token: 0x0402DF96 RID: 188310
			[Token(Token = "0x402DF96")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
