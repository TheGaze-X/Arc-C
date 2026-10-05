using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E43 RID: 28227
	[Token(Token = "0x2006E43")]
	public class ActVecBreakV2MileStoneItemView : TemplateActivityCommonMileStoneItemView
	{
		// Token: 0x060282BB RID: 164539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282BB")]
		[Address(RVA = "0x2376400", Offset = "0x2375000", VA = "0x182376400", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x060282BC RID: 164540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282BC")]
		[Address(RVA = "0x2376690", Offset = "0x2375290", VA = "0x182376690")]
		public ActVecBreakV2MileStoneItemView()
		{
		}

		// Token: 0x060282BD RID: 164541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60282BD")]
		[Address(RVA = "0x15FF010", Offset = "0x15FDC10", VA = "0x1815FF010")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x040390C4 RID: 233668
		[Token(Token = "0x40390C4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _lockedPart;

		// Token: 0x040390C5 RID: 233669
		[Token(Token = "0x40390C5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _lockedTimeRemainText;

		// Token: 0x040390C6 RID: 233670
		[Token(Token = "0x40390C6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _notAvailPart;

		// Token: 0x040390C7 RID: 233671
		[Token(Token = "0x40390C7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _availPart;

		// Token: 0x040390C8 RID: 233672
		[Token(Token = "0x40390C8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text[] _textLevelNumList;

		// Token: 0x040390C9 RID: 233673
		[Token(Token = "0x40390C9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _claimedMask;

		// Token: 0x040390CA RID: 233674
		[Token(Token = "0x40390CA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _rewardPart;

		// Token: 0x040390CB RID: 233675
		[Token(Token = "0x40390CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040390CC RID: 233676
		[Token(Token = "0x40390CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
