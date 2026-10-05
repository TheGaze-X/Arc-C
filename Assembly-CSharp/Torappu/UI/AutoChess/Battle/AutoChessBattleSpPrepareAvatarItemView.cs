using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064BE RID: 25790
	[Token(Token = "0x20064BE")]
	public class AutoChessBattleSpPrepareAvatarItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025115 RID: 151829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025115")]
		[Address(RVA = "0x1FE1A00", Offset = "0x1FE0600", VA = "0x181FE1A00")]
		public void Render(AutoChessBattleSpPreparePlayerModel model)
		{
		}

		// Token: 0x06025116 RID: 151830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025116")]
		[Address(RVA = "0x1FE1B10", Offset = "0x1FE0710", VA = "0x181FE1B10")]
		public AutoChessBattleSpPrepareAvatarItemView()
		{
		}

		// Token: 0x04033E86 RID: 212614
		[Token(Token = "0x4033E86")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgPlayerIcon;

		// Token: 0x04033E87 RID: 212615
		[Token(Token = "0x4033E87")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelf;

		// Token: 0x04033E88 RID: 212616
		[Token(Token = "0x4033E88")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04033E89 RID: 212617
		[Token(Token = "0x4033E89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033E8A RID: 212618
		[Token(Token = "0x4033E8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
