using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003413 RID: 13331
	[Token(Token = "0x2003413")]
	public class UICooperateBattlePinMarkMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x060154B9 RID: 87225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154B9")]
		[Address(RVA = "0xDB3700", Offset = "0xDB2300", VA = "0x180DB3700")]
		public void SetToTile(Tile tile, Action<PinType, Tile> action)
		{
		}

		// Token: 0x060154BA RID: 87226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154BA")]
		[Address(RVA = "0xDB3550", Offset = "0xDB2150", VA = "0x180DB3550")]
		public void OnButtonClicked(int type)
		{
		}

		// Token: 0x060154BB RID: 87227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154BB")]
		[Address(RVA = "0xDB3490", Offset = "0xDB2090", VA = "0x180DB3490")]
		public void ClearMenu()
		{
		}

		// Token: 0x060154BC RID: 87228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154BC")]
		[Address(RVA = "0xDB3830", Offset = "0xDB2430", VA = "0x180DB3830")]
		private void _ShowMenu(Tile tile)
		{
		}

		// Token: 0x060154BD RID: 87229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154BD")]
		[Address(RVA = "0xDB3A70", Offset = "0xDB2670", VA = "0x180DB3A70")]
		public UICooperateBattlePinMarkMenu()
		{
		}

		// Token: 0x0401972A RID: 104234
		[Token(Token = "0x401972A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _leftMenu;

		// Token: 0x0401972B RID: 104235
		[Token(Token = "0x401972B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _rightMenu;

		// Token: 0x0401972C RID: 104236
		[Token(Token = "0x401972C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Follower2D _follower;

		// Token: 0x0401972D RID: 104237
		[Token(Token = "0x401972D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x0401972E RID: 104238
		[Token(Token = "0x401972E")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_tween;

		// Token: 0x0401972F RID: 104239
		[Token(Token = "0x401972F")]
		[FieldOffset(Offset = "0x40")]
		private CanvasGroup m_curMenu;

		// Token: 0x04019730 RID: 104240
		[Token(Token = "0x4019730")]
		[FieldOffset(Offset = "0x48")]
		private Tile m_curTile;

		// Token: 0x04019731 RID: 104241
		[Token(Token = "0x4019731")]
		[FieldOffset(Offset = "0x50")]
		private Action<PinType, Tile> m_pinAction;

		// Token: 0x04019732 RID: 104242
		[Token(Token = "0x4019732")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetToTile;

		// Token: 0x04019733 RID: 104243
		[Token(Token = "0x4019733")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnButtonClicked;

		// Token: 0x04019734 RID: 104244
		[Token(Token = "0x4019734")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearMenu;

		// Token: 0x04019735 RID: 104245
		[Token(Token = "0x4019735")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowMenu;

		// Token: 0x04019736 RID: 104246
		[Token(Token = "0x4019736")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
