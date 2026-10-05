using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FA8 RID: 24488
	[Token(Token = "0x2005FA8")]
	public class CharacterInfoRightProfSubProfView : CharacterInfoRightProfObj
	{
		// Token: 0x060236D4 RID: 145108 RVA: 0x000C0DE0 File Offset: 0x000BEFE0
		[Token(Token = "0x60236D4")]
		[Address(RVA = "0x1E073F0", Offset = "0x1E05FF0", VA = "0x181E073F0", Slot = "4")]
		public override float GetAndApplyHeight()
		{
			return 0f;
		}

		// Token: 0x060236D5 RID: 145109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236D5")]
		[Address(RVA = "0x1E07480", Offset = "0x1E06080", VA = "0x181E07480", Slot = "6")]
		public override void Render(CharacterInfoHolderBean.CharViewModel viewModel)
		{
		}

		// Token: 0x060236D6 RID: 145110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236D6")]
		[Address(RVA = "0x1E07660", Offset = "0x1E06260", VA = "0x181E07660")]
		public CharacterInfoRightProfSubProfView()
		{
		}

		// Token: 0x060236D7 RID: 145111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236D7")]
		[Address(RVA = "0x1E03130", Offset = "0x1E01D30", VA = "0x181E03130")]
		private void <>xLuaBaseProxy_Render(CharacterInfoHolderBean.CharViewModel P0)
		{
		}

		// Token: 0x04030F46 RID: 200518
		[Token(Token = "0x4030F46")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _subProfIcon;

		// Token: 0x04030F47 RID: 200519
		[Token(Token = "0x4030F47")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _subProfName;

		// Token: 0x04030F48 RID: 200520
		[Token(Token = "0x4030F48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAndApplyHeight;

		// Token: 0x04030F49 RID: 200521
		[Token(Token = "0x4030F49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030F4A RID: 200522
		[Token(Token = "0x4030F4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
