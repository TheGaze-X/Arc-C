using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F3C RID: 24380
	[Token(Token = "0x2005F3C")]
	public class CharacterTokenTalentItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060234E6 RID: 144614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E6")]
		[Address(RVA = "0x1DE0040", Offset = "0x1DDEC40", VA = "0x181DE0040")]
		public void Render(CharacterTokenTalentViewModel viewModel)
		{
		}

		// Token: 0x060234E7 RID: 144615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234E7")]
		[Address(RVA = "0x1DE0180", Offset = "0x1DDED80", VA = "0x181DE0180")]
		public CharacterTokenTalentItemView()
		{
		}

		// Token: 0x04030B48 RID: 199496
		[Token(Token = "0x4030B48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _talentName;

		// Token: 0x04030B49 RID: 199497
		[Token(Token = "0x4030B49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x04030B4A RID: 199498
		[Token(Token = "0x4030B4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030B4B RID: 199499
		[Token(Token = "0x4030B4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
