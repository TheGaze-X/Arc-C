using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200794F RID: 31055
	[Token(Token = "0x200794F")]
	public class Act1ArcadeMilestoneItemView : TemplateActivityCommonMileStoneItemView
	{
		// Token: 0x0602B92B RID: 178475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B92B")]
		[Address(RVA = "0x2776C90", Offset = "0x2775890", VA = "0x182776C90", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0602B92C RID: 178476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B92C")]
		[Address(RVA = "0x2776B70", Offset = "0x2775770", VA = "0x182776B70")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602B92D RID: 178477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B92D")]
		[Address(RVA = "0x2776DA0", Offset = "0x27759A0", VA = "0x182776DA0")]
		public Act1ArcadeMilestoneItemView()
		{
		}

		// Token: 0x0602B92E RID: 178478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B92E")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0403F079 RID: 258169
		[Token(Token = "0x403F079")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle _displayToggle;

		// Token: 0x0403F07A RID: 258170
		[Token(Token = "0x403F07A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _objMaskFinished;

		// Token: 0x0403F07B RID: 258171
		[Token(Token = "0x403F07B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text[] _textLevelNumList;

		// Token: 0x0403F07C RID: 258172
		[Token(Token = "0x403F07C")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_finder;

		// Token: 0x0403F07D RID: 258173
		[Token(Token = "0x403F07D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F07E RID: 258174
		[Token(Token = "0x403F07E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403F07F RID: 258175
		[Token(Token = "0x403F07F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
