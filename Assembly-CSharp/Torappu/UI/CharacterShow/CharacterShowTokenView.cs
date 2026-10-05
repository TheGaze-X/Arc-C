using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DF6 RID: 24054
	[Token(Token = "0x2005DF6")]
	public class CharacterShowTokenView : CharacterShowRightInfoViewBase
	{
		// Token: 0x06022DA8 RID: 142760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DA8")]
		[Address(RVA = "0x1D705F0", Offset = "0x1D6F1F0", VA = "0x181D705F0", Slot = "7")]
		public override void OnValueChanged(CharacterShowProp property)
		{
		}

		// Token: 0x06022DA9 RID: 142761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DA9")]
		[Address(RVA = "0x1D706E0", Offset = "0x1D6F2E0", VA = "0x181D706E0")]
		public CharacterShowTokenView()
		{
		}

		// Token: 0x0402FFF5 RID: 196597
		[Token(Token = "0x402FFF5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterTokenDetailShowView _showView;

		// Token: 0x0402FFF6 RID: 196598
		[Token(Token = "0x402FFF6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _bottomDetailObj;

		// Token: 0x0402FFF7 RID: 196599
		[Token(Token = "0x402FFF7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _divideLineObj;

		// Token: 0x0402FFF8 RID: 196600
		[Token(Token = "0x402FFF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402FFF9 RID: 196601
		[Token(Token = "0x402FFF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
