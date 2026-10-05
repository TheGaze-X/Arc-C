using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005751 RID: 22353
	[Token(Token = "0x2005751")]
	public class RL02ReportMutationAndVirtueView : RL02CommonReportView<RL02EndingFrameMutationAndVirtueReportViewModel>
	{
		// Token: 0x06020C07 RID: 134151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C07")]
		[Address(RVA = "0x1B0B4C0", Offset = "0x1B0A0C0", VA = "0x181B0B4C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020C08 RID: 134152 RVA: 0x000B70A8 File Offset: 0x000B52A8
		[Token(Token = "0x6020C08")]
		[Address(RVA = "0x1B0AF60", Offset = "0x1B09B60", VA = "0x181B0AF60", Slot = "4")]
		public override RL02ReportController.ReportViewType GetViewType()
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020C09 RID: 134153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C09")]
		[Address(RVA = "0x1B0AEF0", Offset = "0x1B09AF0", VA = "0x181B0AEF0", Slot = "7")]
		protected override string GetShowAnimName()
		{
			return null;
		}

		// Token: 0x06020C0A RID: 134154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C0A")]
		[Address(RVA = "0x1B0AFC0", Offset = "0x1B09BC0", VA = "0x181B0AFC0", Slot = "8")]
		protected override void Render(RL02EndingFrameMutationAndVirtueReportViewModel viewModel)
		{
		}

		// Token: 0x06020C0B RID: 134155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C0B")]
		[Address(RVA = "0x1B0B2F0", Offset = "0x1B09EF0", VA = "0x181B0B2F0")]
		private string _BuildMutationString(List<string> mutationCharList)
		{
			return null;
		}

		// Token: 0x06020C0C RID: 134156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C0C")]
		[Address(RVA = "0x1B0B5F0", Offset = "0x1B0A1F0", VA = "0x181B0B5F0")]
		public RL02ReportMutationAndVirtueView()
		{
		}

		// Token: 0x0402C76D RID: 182125
		[Token(Token = "0x402C76D")]
		private const string ENTER_ANIM_NAME = "report_mutation";

		// Token: 0x0402C76E RID: 182126
		[Token(Token = "0x402C76E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlMutation;

		// Token: 0x0402C76F RID: 182127
		[Token(Token = "0x402C76F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pnlVirtue;

		// Token: 0x0402C770 RID: 182128
		[Token(Token = "0x402C770")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RL02ClassicEndingStatsMutationAndVirtueItemView _itemMutation;

		// Token: 0x0402C771 RID: 182129
		[Token(Token = "0x402C771")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textMutationDesc;

		// Token: 0x0402C772 RID: 182130
		[Token(Token = "0x402C772")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _virtueGroup;

		// Token: 0x0402C773 RID: 182131
		[Token(Token = "0x402C773")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0402C774 RID: 182132
		[Token(Token = "0x402C774")]
		[FieldOffset(Offset = "0x88")]
		private RL02ReportMutationAndVirtueView.Adapter m_adapter;

		// Token: 0x0402C775 RID: 182133
		[Token(Token = "0x402C775")]
		[FieldOffset(Offset = "0x90")]
		private RL02EndingFrameMutationAndVirtueReportViewModel m_cachedModel;

		// Token: 0x0402C776 RID: 182134
		[Token(Token = "0x402C776")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C777 RID: 182135
		[Token(Token = "0x402C777")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402C778 RID: 182136
		[Token(Token = "0x402C778")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowAnimName;

		// Token: 0x0402C779 RID: 182137
		[Token(Token = "0x402C779")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C77A RID: 182138
		[Token(Token = "0x402C77A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__BuildMutationString;

		// Token: 0x0402C77B RID: 182139
		[Token(Token = "0x402C77B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005752 RID: 22354
		[Token(Token = "0x2005752")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06020C0D RID: 134157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C0D")]
			[Address(RVA = "0x1B03C90", Offset = "0x1B02890", VA = "0x181B03C90")]
			public Adapter(RL02ReportMutationAndVirtueView closure)
			{
			}

			// Token: 0x17004CCB RID: 19659
			// (get) Token: 0x06020C0E RID: 134158 RVA: 0x000B70C0 File Offset: 0x000B52C0
			[Token(Token = "0x17004CCB")]
			public override int count
			{
				[Token(Token = "0x6020C0E")]
				[Address(RVA = "0x1B03ED0", Offset = "0x1B02AD0", VA = "0x181B03ED0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020C0F RID: 134159 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020C0F")]
			[Address(RVA = "0x1B035E0", Offset = "0x1B021E0", VA = "0x181B035E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402C77C RID: 182140
			[Token(Token = "0x402C77C")]
			[FieldOffset(Offset = "0x20")]
			private RL02ReportMutationAndVirtueView m_closure;

			// Token: 0x0402C77D RID: 182141
			[Token(Token = "0x402C77D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C77E RID: 182142
			[Token(Token = "0x402C77E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C77F RID: 182143
			[Token(Token = "0x402C77F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
