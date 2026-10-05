using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200628B RID: 25227
	[Token(Token = "0x200628B")]
	public class AutoChessBandChooseBandItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602460B RID: 149003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602460B")]
		[Address(RVA = "0x1F23520", Offset = "0x1F22120", VA = "0x181F23520")]
		public void Render(AutoChessBandChooseBandItemModel model, string selectedBandId)
		{
		}

		// Token: 0x0602460C RID: 149004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602460C")]
		[Address(RVA = "0x1F23440", Offset = "0x1F22040", VA = "0x181F23440")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602460D RID: 149005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602460D")]
		[Address(RVA = "0x1F23730", Offset = "0x1F22330", VA = "0x181F23730")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x0602460E RID: 149006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602460E")]
		[Address(RVA = "0x1F237F0", Offset = "0x1F223F0", VA = "0x181F237F0")]
		public AutoChessBandChooseBandItemView()
		{
		}

		// Token: 0x04032993 RID: 207251
		[Token(Token = "0x4032993")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04032994 RID: 207252
		[Token(Token = "0x4032994")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelectedSelf;

		// Token: 0x04032995 RID: 207253
		[Token(Token = "0x4032995")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelectedOther;

		// Token: 0x04032996 RID: 207254
		[Token(Token = "0x4032996")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelVictorMark;

		// Token: 0x04032997 RID: 207255
		[Token(Token = "0x4032997")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x04032998 RID: 207256
		[Token(Token = "0x4032998")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelBkg;

		// Token: 0x04032999 RID: 207257
		[Token(Token = "0x4032999")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403299A RID: 207258
		[Token(Token = "0x403299A")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedBandId;

		// Token: 0x0403299B RID: 207259
		[Token(Token = "0x403299B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403299C RID: 207260
		[Token(Token = "0x403299C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403299D RID: 207261
		[Token(Token = "0x403299D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x0403299E RID: 207262
		[Token(Token = "0x403299E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
