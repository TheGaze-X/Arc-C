using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200772A RID: 30506
	[Token(Token = "0x200772A")]
	public class Act1VHalfIdleCharAvatarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602ADC7 RID: 175559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADC7")]
		[Address(RVA = "0x2695E30", Offset = "0x2694A30", VA = "0x182695E30")]
		public void Render(Act1VHalfIdleCharAvatarViewModel viewModel, bool isFirstRecruit)
		{
		}

		// Token: 0x0602ADC8 RID: 175560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADC8")]
		[Address(RVA = "0x2695FC0", Offset = "0x2694BC0", VA = "0x182695FC0")]
		public Act1VHalfIdleCharAvatarView()
		{
		}

		// Token: 0x0403DCA2 RID: 253090
		[Token(Token = "0x403DCA2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlBgFirst;

		// Token: 0x0403DCA3 RID: 253091
		[Token(Token = "0x403DCA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlBgAgain;

		// Token: 0x0403DCA4 RID: 253092
		[Token(Token = "0x403DCA4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgCharAvatar;

		// Token: 0x0403DCA5 RID: 253093
		[Token(Token = "0x403DCA5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgStar;

		// Token: 0x0403DCA6 RID: 253094
		[Token(Token = "0x403DCA6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0403DCA7 RID: 253095
		[Token(Token = "0x403DCA7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlDisabled;

		// Token: 0x0403DCA8 RID: 253096
		[Token(Token = "0x403DCA8")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedCharId;

		// Token: 0x0403DCA9 RID: 253097
		[Token(Token = "0x403DCA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DCAA RID: 253098
		[Token(Token = "0x403DCAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
