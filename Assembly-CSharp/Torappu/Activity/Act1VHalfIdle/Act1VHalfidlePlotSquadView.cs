using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007774 RID: 30580
	[Token(Token = "0x2007774")]
	public class Act1VHalfidlePlotSquadView : DataBinder<Act1VHalfIdlePlotSquadProperty>
	{
		// Token: 0x0602AF46 RID: 175942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF46")]
		[Address(RVA = "0x26D6330", Offset = "0x26D4F30", VA = "0x1826D6330")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AF47 RID: 175943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF47")]
		[Address(RVA = "0x26D63B0", Offset = "0x26D4FB0", VA = "0x1826D63B0")]
		private void _RenderBaseInfo(Act1VHalfIdlePlotSquadViewModel viewModel)
		{
		}

		// Token: 0x0602AF48 RID: 175944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF48")]
		[Address(RVA = "0x26D60F0", Offset = "0x26D4CF0", VA = "0x1826D60F0")]
		public void Render(Act1VHalfIdlePlotSquadViewModel viewModel)
		{
		}

		// Token: 0x0602AF49 RID: 175945 RVA: 0x000DA808 File Offset: 0x000D8A08
		[Token(Token = "0x602AF49")]
		[Address(RVA = "0x26D6570", Offset = "0x26D5170", VA = "0x1826D6570")]
		private bool _ValidatePlots(Act1VHalfIdlePlotSquadViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0602AF4A RID: 175946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF4A")]
		[Address(RVA = "0x26D5DC0", Offset = "0x26D49C0", VA = "0x1826D5DC0", Slot = "7")]
		public override void OnValueChanged(Act1VHalfIdlePlotSquadProperty property)
		{
		}

		// Token: 0x0602AF4B RID: 175947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF4B")]
		[Address(RVA = "0x26D5CD0", Offset = "0x26D48D0", VA = "0x1826D5CD0")]
		public void EventOnStartBattleClicked()
		{
		}

		// Token: 0x0602AF4C RID: 175948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF4C")]
		[Address(RVA = "0x26D5E60", Offset = "0x26D4A60", VA = "0x1826D5E60")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AF4D RID: 175949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF4D")]
		[Address(RVA = "0x26D66B0", Offset = "0x26D52B0", VA = "0x1826D66B0")]
		public Act1VHalfidlePlotSquadView()
		{
		}

		// Token: 0x0403DF9E RID: 253854
		[Token(Token = "0x403DF9E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfIdlePlotType[] _groupTypeArray;

		// Token: 0x0403DF9F RID: 253855
		[Token(Token = "0x403DF9F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403DFA0 RID: 253856
		[Token(Token = "0x403DFA0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _validBtn;

		// Token: 0x0403DFA1 RID: 253857
		[Token(Token = "0x403DFA1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _disableBtn;

		// Token: 0x0403DFA2 RID: 253858
		[Token(Token = "0x403DFA2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _plotListGO;

		// Token: 0x0403DFA3 RID: 253859
		[Token(Token = "0x403DFA3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _tipGO;

		// Token: 0x0403DFA4 RID: 253860
		[Token(Token = "0x403DFA4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _btnStartBattleGO;

		// Token: 0x0403DFA5 RID: 253861
		[Token(Token = "0x403DFA5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlPredefinedTip;

		// Token: 0x0403DFA6 RID: 253862
		[Token(Token = "0x403DFA6")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x0403DFA7 RID: 253863
		[Token(Token = "0x403DFA7")]
		[FieldOffset(Offset = "0x68")]
		private Act1VHalfidlePlotSquadGroupAdapter m_squadGroupAdapter;

		// Token: 0x0403DFA8 RID: 253864
		[Token(Token = "0x403DFA8")]
		[FieldOffset(Offset = "0x70")]
		private bool m_plotValid;

		// Token: 0x0403DFA9 RID: 253865
		[Token(Token = "0x403DFA9")]
		[FieldOffset(Offset = "0x78")]
		private string m_actId;

		// Token: 0x0403DFAA RID: 253866
		[Token(Token = "0x403DFAA")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DFAB RID: 253867
		[Token(Token = "0x403DFAB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DFAC RID: 253868
		[Token(Token = "0x403DFAC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderBaseInfo;

		// Token: 0x0403DFAD RID: 253869
		[Token(Token = "0x403DFAD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DFAE RID: 253870
		[Token(Token = "0x403DFAE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ValidatePlots;

		// Token: 0x0403DFAF RID: 253871
		[Token(Token = "0x403DFAF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403DFB0 RID: 253872
		[Token(Token = "0x403DFB0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnStartBattleClicked;

		// Token: 0x0403DFB1 RID: 253873
		[Token(Token = "0x403DFB1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DFB2 RID: 253874
		[Token(Token = "0x403DFB2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
