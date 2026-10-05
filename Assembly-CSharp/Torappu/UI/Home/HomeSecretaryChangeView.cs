using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C1A RID: 19482
	[Token(Token = "0x2004C1A")]
	public class HomeSecretaryChangeView : DataBinder<HomeSecretaryChangeCardGroupViewProperty>
	{
		// Token: 0x0601D42F RID: 119855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D42F")]
		[Address(RVA = "0x16D68E0", Offset = "0x16D54E0", VA = "0x1816D68E0", Slot = "7")]
		public override void OnValueChanged(HomeSecretaryChangeCardGroupViewProperty property)
		{
		}

		// Token: 0x0601D430 RID: 119856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D430")]
		[Address(RVA = "0x16D6C10", Offset = "0x16D5810", VA = "0x1816D6C10")]
		public void ResetListToTop()
		{
		}

		// Token: 0x0601D431 RID: 119857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D431")]
		[Address(RVA = "0x16D6C80", Offset = "0x16D5880", VA = "0x1816D6C80")]
		public HomeSecretaryChangeView()
		{
		}

		// Token: 0x04026787 RID: 157575
		[Token(Token = "0x4026787")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _selectedCharRealName;

		// Token: 0x04026788 RID: 157576
		[Token(Token = "0x4026788")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _selectedCharNickName;

		// Token: 0x04026789 RID: 157577
		[Token(Token = "0x4026789")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HomeSecretaryChangeGridAdapter _dataTarget;

		// Token: 0x0402678A RID: 157578
		[Token(Token = "0x402678A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LoopVerticalScrollRect _charListScrollRect;

		// Token: 0x0402678B RID: 157579
		[Token(Token = "0x402678B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _selectedCharNum;

		// Token: 0x0402678C RID: 157580
		[Token(Token = "0x402678C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402678D RID: 157581
		[Token(Token = "0x402678D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetListToTop;

		// Token: 0x0402678E RID: 157582
		[Token(Token = "0x402678E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
