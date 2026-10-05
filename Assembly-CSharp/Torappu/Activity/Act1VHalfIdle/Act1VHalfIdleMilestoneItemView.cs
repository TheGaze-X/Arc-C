using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077BE RID: 30654
	[Token(Token = "0x20077BE")]
	public class Act1VHalfIdleMilestoneItemView : TemplateActivityCommonMileStoneItemView
	{
		// Token: 0x0602B078 RID: 176248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B078")]
		[Address(RVA = "0x26D9D10", Offset = "0x26D8910", VA = "0x1826D9D10", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0602B079 RID: 176249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B079")]
		[Address(RVA = "0x26DA080", Offset = "0x26D8C80", VA = "0x1826DA080")]
		public Act1VHalfIdleMilestoneItemView()
		{
		}

		// Token: 0x0602B07A RID: 176250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B07A")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0403E21F RID: 254495
		[Token(Token = "0x403E21F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403E220 RID: 254496
		[Token(Token = "0x403E220")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textDescUnavail;

		// Token: 0x0403E221 RID: 254497
		[Token(Token = "0x403E221")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _availStatusPnl;

		// Token: 0x0403E222 RID: 254498
		[Token(Token = "0x403E222")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _notAvailStatusPnl;

		// Token: 0x0403E223 RID: 254499
		[Token(Token = "0x403E223")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _lockedStatusPnl;

		// Token: 0x0403E224 RID: 254500
		[Token(Token = "0x403E224")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text[] _textLevelNumList;

		// Token: 0x0403E225 RID: 254501
		[Token(Token = "0x403E225")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _objMaskFinished;

		// Token: 0x0403E226 RID: 254502
		[Token(Token = "0x403E226")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _rewardContainer;

		// Token: 0x0403E227 RID: 254503
		[Token(Token = "0x403E227")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _lockedTimeRemainText;

		// Token: 0x0403E228 RID: 254504
		[Token(Token = "0x403E228")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E229 RID: 254505
		[Token(Token = "0x403E229")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
