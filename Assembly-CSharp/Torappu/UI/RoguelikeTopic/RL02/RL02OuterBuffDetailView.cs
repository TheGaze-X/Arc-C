using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004610 RID: 17936
	[Token(Token = "0x2004610")]
	public class RL02OuterBuffDetailView : DataBinder<RL02OuterBuffProperty>, IHotfixable
	{
		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x0601B42F RID: 111663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B430 RID: 111664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040FB")]
		public Action onNodeActivateClicked
		{
			[Token(Token = "0x601B42F")]
			[Address(RVA = "0x1465520", Offset = "0x1464120", VA = "0x181465520")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B430")]
			[Address(RVA = "0x14655E0", Offset = "0x14641E0", VA = "0x1814655E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x0601B431 RID: 111665 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B432 RID: 111666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040FC")]
		public Action onSummaryClicked
		{
			[Token(Token = "0x601B431")]
			[Address(RVA = "0x1465580", Offset = "0x1464180", VA = "0x181465580")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B432")]
			[Address(RVA = "0x1465660", Offset = "0x1464260", VA = "0x181465660")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B433 RID: 111667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B433")]
		[Address(RVA = "0x1464BB0", Offset = "0x14637B0", VA = "0x181464BB0")]
		public void OnInit(UIPage page)
		{
		}

		// Token: 0x0601B434 RID: 111668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B434")]
		[Address(RVA = "0x1464F10", Offset = "0x1463B10", VA = "0x181464F10", Slot = "7")]
		public override void OnValueChanged(RL02OuterBuffProperty property)
		{
		}

		// Token: 0x0601B435 RID: 111669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B435")]
		[Address(RVA = "0x1464CF0", Offset = "0x14638F0", VA = "0x181464CF0")]
		public void OnNodeActivateClicked()
		{
		}

		// Token: 0x0601B436 RID: 111670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B436")]
		[Address(RVA = "0x1464E00", Offset = "0x1463A00", VA = "0x181464E00")]
		public void OnSummaryClicked()
		{
		}

		// Token: 0x0601B437 RID: 111671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B437")]
		[Address(RVA = "0x1465480", Offset = "0x1464080", VA = "0x181465480")]
		public RL02OuterBuffDetailView()
		{
		}

		// Token: 0x040232C9 RID: 144073
		[Token(Token = "0x40232C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggleButtonBannedText;

		// Token: 0x040232CA RID: 144074
		[Token(Token = "0x40232CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _toggleAllComplete;

		// Token: 0x040232CB RID: 144075
		[Token(Token = "0x40232CB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelBtnCanUpgrade;

		// Token: 0x040232CC RID: 144076
		[Token(Token = "0x40232CC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelBtnBanned;

		// Token: 0x040232CD RID: 144077
		[Token(Token = "0x40232CD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelBtnNodeActivated;

		// Token: 0x040232CE RID: 144078
		[Token(Token = "0x40232CE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x040232CF RID: 144079
		[Token(Token = "0x40232CF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textTokenCount;

		// Token: 0x040232D0 RID: 144080
		[Token(Token = "0x40232D0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textTokenCost;

		// Token: 0x040232D1 RID: 144081
		[Token(Token = "0x40232D1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _formatProgress;

		// Token: 0x040232D2 RID: 144082
		[Token(Token = "0x40232D2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _formatNodeActivateCost;

		// Token: 0x040232D3 RID: 144083
		[Token(Token = "0x40232D3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textNodeName;

		// Token: 0x040232D4 RID: 144084
		[Token(Token = "0x40232D4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textNodeDesc;

		// Token: 0x040232D5 RID: 144085
		[Token(Token = "0x40232D5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgNodeIcon;

		// Token: 0x040232D6 RID: 144086
		[Token(Token = "0x40232D6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x040232D7 RID: 144087
		[Token(Token = "0x40232D7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _animDuration;

		// Token: 0x040232DA RID: 144090
		[Token(Token = "0x40232DA")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x040232DB RID: 144091
		[Token(Token = "0x40232DB")]
		[FieldOffset(Offset = "0xB8")]
		private RL02OuterBuffItemModel m_selectNode;

		// Token: 0x040232DC RID: 144092
		[Token(Token = "0x40232DC")]
		[FieldOffset(Offset = "0xC0")]
		private UIPage m_cachePage;

		// Token: 0x040232DD RID: 144093
		[Token(Token = "0x40232DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeActivateClicked;

		// Token: 0x040232DE RID: 144094
		[Token(Token = "0x40232DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeActivateClicked;

		// Token: 0x040232DF RID: 144095
		[Token(Token = "0x40232DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onSummaryClicked;

		// Token: 0x040232E0 RID: 144096
		[Token(Token = "0x40232E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onSummaryClicked;

		// Token: 0x040232E1 RID: 144097
		[Token(Token = "0x40232E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040232E2 RID: 144098
		[Token(Token = "0x40232E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040232E3 RID: 144099
		[Token(Token = "0x40232E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnNodeActivateClicked;

		// Token: 0x040232E4 RID: 144100
		[Token(Token = "0x40232E4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSummaryClicked;

		// Token: 0x040232E5 RID: 144101
		[Token(Token = "0x40232E5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
