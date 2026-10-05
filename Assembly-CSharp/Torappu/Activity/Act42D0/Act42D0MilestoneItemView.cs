using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073A0 RID: 29600
	[Token(Token = "0x20073A0")]
	public class Act42D0MilestoneItemView : TemplateActivityCommonMileStoneItemView
	{
		// Token: 0x06029D79 RID: 171385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D79")]
		[Address(RVA = "0x2572690", Offset = "0x2571290", VA = "0x182572690", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06029D7A RID: 171386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D7A")]
		[Address(RVA = "0x2572830", Offset = "0x2571430", VA = "0x182572830")]
		public Act42D0MilestoneItemView()
		{
		}

		// Token: 0x06029D7B RID: 171387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D7B")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0403BF3D RID: 245565
		[Token(Token = "0x403BF3D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403BF3E RID: 245566
		[Token(Token = "0x403BF3E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _displayToggle;

		// Token: 0x0403BF3F RID: 245567
		[Token(Token = "0x403BF3F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text[] _textLevelNumList;

		// Token: 0x0403BF40 RID: 245568
		[Token(Token = "0x403BF40")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _objMaskFinished;

		// Token: 0x0403BF41 RID: 245569
		[Token(Token = "0x403BF41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403BF42 RID: 245570
		[Token(Token = "0x403BF42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
