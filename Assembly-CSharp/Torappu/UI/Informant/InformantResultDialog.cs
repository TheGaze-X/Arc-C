using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A26 RID: 18982
	[Token(Token = "0x2004A26")]
	public class InformantResultDialog : UICompDialog<InformantDialogCommonInput>
	{
		// Token: 0x0601C8D9 RID: 116953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8D9")]
		[Address(RVA = "0x1601DB0", Offset = "0x16009B0", VA = "0x181601DB0", Slot = "18")]
		protected override void OnRender(InformantDialogCommonInput input)
		{
		}

		// Token: 0x0601C8DA RID: 116954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8DA")]
		[Address(RVA = "0x1601CF0", Offset = "0x16008F0", VA = "0x181601CF0", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0601C8DB RID: 116955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8DB")]
		[Address(RVA = "0x1602220", Offset = "0x1600E20", VA = "0x181602220")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C8DC RID: 116956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8DC")]
		[Address(RVA = "0x1601C20", Offset = "0x1600820", VA = "0x181601C20")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601C8DD RID: 116957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8DD")]
		[Address(RVA = "0x1602400", Offset = "0x1601000", VA = "0x181602400")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x0601C8DE RID: 116958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8DE")]
		[Address(RVA = "0x16024E0", Offset = "0x16010E0", VA = "0x1816024E0")]
		public InformantResultDialog()
		{
		}

		// Token: 0x0601C8DF RID: 116959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C8DF")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x04025729 RID: 153385
		[Token(Token = "0x4025729")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtDay;

		// Token: 0x0402572A RID: 153386
		[Token(Token = "0x402572A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _customerItemList;

		// Token: 0x0402572B RID: 153387
		[Token(Token = "0x402572B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _transPointItemHolder;

		// Token: 0x0402572C RID: 153388
		[Token(Token = "0x402572C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InformantMilestonePointItemView _pointItemViewPrefab;

		// Token: 0x0402572D RID: 153389
		[Token(Token = "0x402572D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _txtTotalGetCount;

		// Token: 0x0402572E RID: 153390
		[Token(Token = "0x402572E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0402572F RID: 153391
		[Token(Token = "0x402572F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04025730 RID: 153392
		[Token(Token = "0x4025730")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04025731 RID: 153393
		[Token(Token = "0x4025731")]
		[FieldOffset(Offset = "0xB8")]
		private InformantResultDialog.CustomerItemListAdapter m_customerItemListAdapter;

		// Token: 0x04025732 RID: 153394
		[Token(Token = "0x4025732")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_hasInited;

		// Token: 0x04025733 RID: 153395
		[Token(Token = "0x4025733")]
		[FieldOffset(Offset = "0xC8")]
		private InformantMilestonePointItemView m_pointItemView;

		// Token: 0x04025734 RID: 153396
		[Token(Token = "0x4025734")]
		[FieldOffset(Offset = "0xD0")]
		private InformantResultDialogViewModel m_cachedViewModel;

		// Token: 0x04025735 RID: 153397
		[Token(Token = "0x4025735")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04025736 RID: 153398
		[Token(Token = "0x4025736")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04025737 RID: 153399
		[Token(Token = "0x4025737")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025738 RID: 153400
		[Token(Token = "0x4025738")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x04025739 RID: 153401
		[Token(Token = "0x4025739")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x0402573A RID: 153402
		[Token(Token = "0x402573A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A27 RID: 18983
		[Token(Token = "0x2004A27")]
		private class CustomerItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601C8E0 RID: 116960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C8E0")]
			[Address(RVA = "0x160AA10", Offset = "0x1609610", VA = "0x18160AA10")]
			public CustomerItemListAdapter(InformantResultDialog closure)
			{
			}

			// Token: 0x17004371 RID: 17265
			// (get) Token: 0x0601C8E1 RID: 116961 RVA: 0x000A8A50 File Offset: 0x000A6C50
			[Token(Token = "0x17004371")]
			public override int count
			{
				[Token(Token = "0x601C8E1")]
				[Address(RVA = "0x160AA90", Offset = "0x1609690", VA = "0x18160AA90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C8E2 RID: 116962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C8E2")]
			[Address(RVA = "0x160A850", Offset = "0x1609450", VA = "0x18160A850", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402573B RID: 153403
			[Token(Token = "0x402573B")]
			[FieldOffset(Offset = "0x20")]
			private InformantResultDialog m_closure;

			// Token: 0x0402573C RID: 153404
			[Token(Token = "0x402573C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402573D RID: 153405
			[Token(Token = "0x402573D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402573E RID: 153406
			[Token(Token = "0x402573E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
