using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CBE RID: 27838
	[Token(Token = "0x2006CBE")]
	public class TemplateActivityCommonFavorUpView : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x06027B8A RID: 162698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B8A")]
		[Address(RVA = "0x22D6DE0", Offset = "0x22D59E0", VA = "0x1822D6DE0", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027B8B RID: 162699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B8B")]
		[Address(RVA = "0x22D6F60", Offset = "0x22D5B60", VA = "0x1822D6F60")]
		public void Render(List<string> favorList, string actId)
		{
		}

		// Token: 0x06027B8C RID: 162700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B8C")]
		[Address(RVA = "0x22D76A0", Offset = "0x22D62A0", VA = "0x1822D76A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027B8D RID: 162701 RVA: 0x000CF258 File Offset: 0x000CD458
		[Token(Token = "0x6027B8D")]
		[Address(RVA = "0x22D75E0", Offset = "0x22D61E0", VA = "0x1822D75E0")]
		private int _CompareFavorUpChar(TemplateActivityCommonFavorUpView.ActFavorUpCharData lhs, TemplateActivityCommonFavorUpView.ActFavorUpCharData rhs)
		{
			return 0;
		}

		// Token: 0x06027B8E RID: 162702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B8E")]
		[Address(RVA = "0x22D7730", Offset = "0x22D6330", VA = "0x1822D7730")]
		public TemplateActivityCommonFavorUpView()
		{
		}

		// Token: 0x0403851A RID: 230682
		[Token(Token = "0x403851A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _newUpGroup;

		// Token: 0x0403851B RID: 230683
		[Token(Token = "0x403851B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _upGroup;

		// Token: 0x0403851C RID: 230684
		[Token(Token = "0x403851C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403851D RID: 230685
		[Token(Token = "0x403851D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x0403851E RID: 230686
		[Token(Token = "0x403851E")]
		[FieldOffset(Offset = "0x38")]
		private List<TemplateActivityCommonFavorUpView.ActFavorUpCharData> m_newUpCharList;

		// Token: 0x0403851F RID: 230687
		[Token(Token = "0x403851F")]
		[FieldOffset(Offset = "0x40")]
		private List<TemplateActivityCommonFavorUpView.ActFavorUpCharData> m_upCharList;

		// Token: 0x04038520 RID: 230688
		[Token(Token = "0x4038520")]
		[FieldOffset(Offset = "0x48")]
		private TemplateActivityCommonFavorUpView.ActFavorUpGroupViewAdapter m_newUpGroupAdapter;

		// Token: 0x04038521 RID: 230689
		[Token(Token = "0x4038521")]
		[FieldOffset(Offset = "0x50")]
		private TemplateActivityCommonFavorUpView.ActFavorUpGroupViewAdapter m_upGroupAdapter;

		// Token: 0x04038522 RID: 230690
		[Token(Token = "0x4038522")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04038523 RID: 230691
		[Token(Token = "0x4038523")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x04038524 RID: 230692
		[Token(Token = "0x4038524")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038525 RID: 230693
		[Token(Token = "0x4038525")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038526 RID: 230694
		[Token(Token = "0x4038526")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CompareFavorUpChar;

		// Token: 0x04038527 RID: 230695
		[Token(Token = "0x4038527")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CBF RID: 27839
		[Token(Token = "0x2006CBF")]
		private class ActFavorUpCharData
		{
			// Token: 0x06027B8F RID: 162703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B8F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActFavorUpCharData()
			{
			}

			// Token: 0x04038528 RID: 230696
			[Token(Token = "0x4038528")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04038529 RID: 230697
			[Token(Token = "0x4038529")]
			[FieldOffset(Offset = "0x18")]
			public int index;

			// Token: 0x0403852A RID: 230698
			[Token(Token = "0x403852A")]
			[FieldOffset(Offset = "0x1C")]
			public RarityRank rarity;
		}

		// Token: 0x02006CC0 RID: 27840
		[Token(Token = "0x2006CC0")]
		private class ActFavorUpGroupViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005DCC RID: 24012
			// (get) Token: 0x06027B90 RID: 162704 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027B91 RID: 162705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005DCC")]
			public List<TemplateActivityCommonFavorUpView.ActFavorUpCharData> dataSet
			{
				[Token(Token = "0x6027B90")]
				[Address(RVA = "0x22D44B0", Offset = "0x22D30B0", VA = "0x1822D44B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027B91")]
				[Address(RVA = "0x22D4560", Offset = "0x22D3160", VA = "0x1822D4560")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005DCD RID: 24013
			// (get) Token: 0x06027B92 RID: 162706 RVA: 0x000CF270 File Offset: 0x000CD470
			[Token(Token = "0x17005DCD")]
			public override int count
			{
				[Token(Token = "0x6027B92")]
				[Address(RVA = "0x22D4430", Offset = "0x22D3030", VA = "0x1822D4430", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027B93 RID: 162707 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027B93")]
			[Address(RVA = "0x22D4210", Offset = "0x22D2E10", VA = "0x1822D4210", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06027B94 RID: 162708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B94")]
			[Address(RVA = "0x22D43D0", Offset = "0x22D2FD0", VA = "0x1822D43D0")]
			public ActFavorUpGroupViewAdapter()
			{
			}

			// Token: 0x0403852C RID: 230700
			[Token(Token = "0x403852C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0403852D RID: 230701
			[Token(Token = "0x403852D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0403852E RID: 230702
			[Token(Token = "0x403852E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403852F RID: 230703
			[Token(Token = "0x403852F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04038530 RID: 230704
			[Token(Token = "0x4038530")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
