using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ReportPlayer
{
	// Token: 0x020046DF RID: 18143
	[Token(Token = "0x20046DF")]
	public class ReportPlayerPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700417C RID: 16764
		// (get) Token: 0x0601B817 RID: 112663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B818 RID: 112664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700417C")]
		public Action onBtnCancelClick
		{
			[Token(Token = "0x601B817")]
			[Address(RVA = "0x14D1790", Offset = "0x14D0390", VA = "0x1814D1790")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B818")]
			[Address(RVA = "0x14D18B0", Offset = "0x14D04B0", VA = "0x1814D18B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700417D RID: 16765
		// (get) Token: 0x0601B819 RID: 112665 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B81A RID: 112666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700417D")]
		public Action<string> onReportSuc
		{
			[Token(Token = "0x601B819")]
			[Address(RVA = "0x14D1850", Offset = "0x14D0450", VA = "0x1814D1850")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B81A")]
			[Address(RVA = "0x14D19B0", Offset = "0x14D05B0", VA = "0x1814D19B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700417E RID: 16766
		// (get) Token: 0x0601B81B RID: 112667 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B81C RID: 112668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700417E")]
		public Action<string> onReportButNoItemSelect
		{
			[Token(Token = "0x601B81B")]
			[Address(RVA = "0x14D17F0", Offset = "0x14D03F0", VA = "0x1814D17F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B81C")]
			[Address(RVA = "0x14D1930", Offset = "0x14D0530", VA = "0x1814D1930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B81D RID: 112669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B81D")]
		[Address(RVA = "0x14D0990", Offset = "0x14CF590", VA = "0x1814D0990")]
		public void Render(ReportPlayerPanelInputParam inputParam)
		{
		}

		// Token: 0x0601B81E RID: 112670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B81E")]
		[Address(RVA = "0x14D1360", Offset = "0x14CFF60", VA = "0x1814D1360")]
		private void _ShowPanel(ReportPlayerViewModel reportModel)
		{
		}

		// Token: 0x0601B81F RID: 112671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B81F")]
		[Address(RVA = "0x14D1050", Offset = "0x14CFC50", VA = "0x1814D1050")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B820 RID: 112672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B820")]
		[Address(RVA = "0x14D1200", Offset = "0x14CFE00", VA = "0x1814D1200")]
		private void _OnReportItemClick(string reportId)
		{
		}

		// Token: 0x0601B821 RID: 112673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B821")]
		[Address(RVA = "0x14D0430", Offset = "0x14CF030", VA = "0x1814D0430")]
		public void EventOnCancel()
		{
		}

		// Token: 0x0601B822 RID: 112674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B822")]
		[Address(RVA = "0x14D04E0", Offset = "0x14CF0E0", VA = "0x1814D04E0")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0601B823 RID: 112675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B823")]
		[Address(RVA = "0x14D1730", Offset = "0x14D0330", VA = "0x1814D1730")]
		public ReportPlayerPanel()
		{
		}

		// Token: 0x04023A11 RID: 145937
		[Token(Token = "0x4023A11")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _blurFloatPanel;

		// Token: 0x04023A12 RID: 145938
		[Token(Token = "0x4023A12")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _reportItemList;

		// Token: 0x04023A13 RID: 145939
		[Token(Token = "0x4023A13")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04023A14 RID: 145940
		[Token(Token = "0x4023A14")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgAvatar;

		// Token: 0x04023A15 RID: 145941
		[Token(Token = "0x4023A15")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTargetLv;

		// Token: 0x04023A16 RID: 145942
		[Token(Token = "0x4023A16")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTargetName;

		// Token: 0x04023A17 RID: 145943
		[Token(Token = "0x4023A17")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _cancelBtnRect;

		// Token: 0x04023A18 RID: 145944
		[Token(Token = "0x4023A18")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04023A19 RID: 145945
		[Token(Token = "0x4023A19")]
		[FieldOffset(Offset = "0x58")]
		private ReportPlayerViewModel m_reportModel;

		// Token: 0x04023A1A RID: 145946
		[Token(Token = "0x4023A1A")]
		[FieldOffset(Offset = "0x60")]
		private string m_targetUid;

		// Token: 0x04023A1B RID: 145947
		[Token(Token = "0x4023A1B")]
		[FieldOffset(Offset = "0x68")]
		private ReportPlayerPanel.ReportItemAdapter m_itemListAdapter;

		// Token: 0x04023A1F RID: 145951
		[Token(Token = "0x4023A1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnCancelClick;

		// Token: 0x04023A20 RID: 145952
		[Token(Token = "0x4023A20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnCancelClick;

		// Token: 0x04023A21 RID: 145953
		[Token(Token = "0x4023A21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onReportSuc;

		// Token: 0x04023A22 RID: 145954
		[Token(Token = "0x4023A22")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onReportSuc;

		// Token: 0x04023A23 RID: 145955
		[Token(Token = "0x4023A23")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onReportButNoItemSelect;

		// Token: 0x04023A24 RID: 145956
		[Token(Token = "0x4023A24")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onReportButNoItemSelect;

		// Token: 0x04023A25 RID: 145957
		[Token(Token = "0x4023A25")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023A26 RID: 145958
		[Token(Token = "0x4023A26")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowPanel;

		// Token: 0x04023A27 RID: 145959
		[Token(Token = "0x4023A27")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023A28 RID: 145960
		[Token(Token = "0x4023A28")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnReportItemClick;

		// Token: 0x04023A29 RID: 145961
		[Token(Token = "0x4023A29")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnCancel;

		// Token: 0x04023A2A RID: 145962
		[Token(Token = "0x4023A2A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04023A2B RID: 145963
		[Token(Token = "0x4023A2B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046E0 RID: 18144
		[Token(Token = "0x20046E0")]
		private class ReportItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B824 RID: 112676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B824")]
			[Address(RVA = "0x14CFF30", Offset = "0x14CEB30", VA = "0x1814CFF30")]
			public ReportItemAdapter(ReportPlayerPanel closure)
			{
			}

			// Token: 0x1700417F RID: 16767
			// (get) Token: 0x0601B825 RID: 112677 RVA: 0x000A5648 File Offset: 0x000A3848
			[Token(Token = "0x1700417F")]
			public override int count
			{
				[Token(Token = "0x601B825")]
				[Address(RVA = "0x14CFFB0", Offset = "0x14CEBB0", VA = "0x1814CFFB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B826 RID: 112678 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B826")]
			[Address(RVA = "0x14CFA90", Offset = "0x14CE690", VA = "0x1814CFA90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04023A2C RID: 145964
			[Token(Token = "0x4023A2C")]
			[FieldOffset(Offset = "0x20")]
			private ReportPlayerPanel m_closure;

			// Token: 0x04023A2D RID: 145965
			[Token(Token = "0x4023A2D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023A2E RID: 145966
			[Token(Token = "0x4023A2E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023A2F RID: 145967
			[Token(Token = "0x4023A2F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
