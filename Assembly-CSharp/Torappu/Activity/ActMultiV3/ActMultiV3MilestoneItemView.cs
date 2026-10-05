using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F38 RID: 28472
	[Token(Token = "0x2006F38")]
	public class ActMultiV3MilestoneItemView : TemplateActivityCommonMileStoneItemView
	{
		// Token: 0x060286F8 RID: 165624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286F8")]
		[Address(RVA = "0x23B9ED0", Offset = "0x23B8AD0", VA = "0x1823B9ED0", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x060286F9 RID: 165625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286F9")]
		[Address(RVA = "0x23B9DB0", Offset = "0x23B89B0", VA = "0x1823B9DB0")]
		public void EventOnClick()
		{
		}

		// Token: 0x060286FA RID: 165626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286FA")]
		[Address(RVA = "0x23BA180", Offset = "0x23B8D80", VA = "0x1823BA180")]
		public ActMultiV3MilestoneItemView()
		{
		}

		// Token: 0x060286FB RID: 165627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286FB")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x04039850 RID: 235600
		[Token(Token = "0x4039850")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _availStatusGO;

		// Token: 0x04039851 RID: 235601
		[Token(Token = "0x4039851")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _notAvailStatusGO;

		// Token: 0x04039852 RID: 235602
		[Token(Token = "0x4039852")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _lockedStatusGO;

		// Token: 0x04039853 RID: 235603
		[Token(Token = "0x4039853")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text[] _textLevelNumList;

		// Token: 0x04039854 RID: 235604
		[Token(Token = "0x4039854")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _objMaskFinished;

		// Token: 0x04039855 RID: 235605
		[Token(Token = "0x4039855")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _lockedTimeRemainText;

		// Token: 0x04039856 RID: 235606
		[Token(Token = "0x4039856")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _rewardContainer;

		// Token: 0x04039857 RID: 235607
		[Token(Token = "0x4039857")]
		[FieldOffset(Offset = "0xB0")]
		private UIStateFinder m_finder;

		// Token: 0x04039858 RID: 235608
		[Token(Token = "0x4039858")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04039859 RID: 235609
		[Token(Token = "0x4039859")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403985A RID: 235610
		[Token(Token = "0x403985A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
