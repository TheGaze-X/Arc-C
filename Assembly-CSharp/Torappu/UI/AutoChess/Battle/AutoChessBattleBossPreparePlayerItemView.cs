using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006488 RID: 25736
	[Token(Token = "0x2006488")]
	public class AutoChessBattleBossPreparePlayerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025047 RID: 151623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025047")]
		[Address(RVA = "0x1FDC6D0", Offset = "0x1FDB2D0", VA = "0x181FDC6D0")]
		public void Render(AutoChessBattlePlayerStatusModel playerModel, bool isSelf)
		{
		}

		// Token: 0x06025048 RID: 151624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025048")]
		[Address(RVA = "0x1FDC870", Offset = "0x1FDB470", VA = "0x181FDC870")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025049 RID: 151625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025049")]
		[Address(RVA = "0x1FDC640", Offset = "0x1FDB240", VA = "0x181FDC640")]
		public Tween GenerateTween()
		{
			return null;
		}

		// Token: 0x0602504A RID: 151626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602504A")]
		[Address(RVA = "0x1FDC900", Offset = "0x1FDB500", VA = "0x181FDC900")]
		private void _RenderAvatar(AutoChessBattlePlayerStatusModel itemModel)
		{
		}

		// Token: 0x0602504B RID: 151627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602504B")]
		[Address(RVA = "0x1FDCB60", Offset = "0x1FDB760", VA = "0x181FDCB60")]
		public AutoChessBattleBossPreparePlayerItemView()
		{
		}

		// Token: 0x04033CED RID: 212205
		[Token(Token = "0x4033CED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _itemRootGO;

		// Token: 0x04033CEE RID: 212206
		[Token(Token = "0x4033CEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textHp;

		// Token: 0x04033CEF RID: 212207
		[Token(Token = "0x4033CEF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selfIconGO;

		// Token: 0x04033CF0 RID: 212208
		[Token(Token = "0x4033CF0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x04033CF1 RID: 212209
		[Token(Token = "0x4033CF1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x04033CF2 RID: 212210
		[Token(Token = "0x4033CF2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animHp;

		// Token: 0x04033CF3 RID: 212211
		[Token(Token = "0x4033CF3")]
		[FieldOffset(Offset = "0x50")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04033CF4 RID: 212212
		[Token(Token = "0x4033CF4")]
		[FieldOffset(Offset = "0x58")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04033CF5 RID: 212213
		[Token(Token = "0x4033CF5")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04033CF6 RID: 212214
		[Token(Token = "0x4033CF6")]
		[FieldOffset(Offset = "0x69")]
		private bool m_isEmpty;

		// Token: 0x04033CF7 RID: 212215
		[Token(Token = "0x4033CF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033CF8 RID: 212216
		[Token(Token = "0x4033CF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033CF9 RID: 212217
		[Token(Token = "0x4033CF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateTween;

		// Token: 0x04033CFA RID: 212218
		[Token(Token = "0x4033CFA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderAvatar;

		// Token: 0x04033CFB RID: 212219
		[Token(Token = "0x4033CFB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
