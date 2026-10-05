using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062F7 RID: 25335
	[Token(Token = "0x20062F7")]
	public class AutoChessSettleGameTeamPlayerLikeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024850 RID: 149584 RVA: 0x000C4710 File Offset: 0x000C2910
		[Token(Token = "0x6024850")]
		[Address(RVA = "0x1F5FCA0", Offset = "0x1F5E8A0", VA = "0x181F5FCA0")]
		public bool Show(string uid, PlayerAvatarQuery avatarQuery)
		{
			return default(bool);
		}

		// Token: 0x06024851 RID: 149585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024851")]
		[Address(RVA = "0x1F5FEE0", Offset = "0x1F5EAE0", VA = "0x181F5FEE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024852 RID: 149586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024852")]
		[Address(RVA = "0x1F5FF70", Offset = "0x1F5EB70", VA = "0x181F5FF70")]
		public AutoChessSettleGameTeamPlayerLikeItemView()
		{
		}

		// Token: 0x04032EA4 RID: 208548
		[Token(Token = "0x4032EA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgPlayerAvatar;

		// Token: 0x04032EA5 RID: 208549
		[Token(Token = "0x4032EA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x04032EA6 RID: 208550
		[Token(Token = "0x4032EA6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04032EA7 RID: 208551
		[Token(Token = "0x4032EA7")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_showTween;

		// Token: 0x04032EA8 RID: 208552
		[Token(Token = "0x4032EA8")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04032EA9 RID: 208553
		[Token(Token = "0x4032EA9")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedUid;

		// Token: 0x04032EAA RID: 208554
		[Token(Token = "0x4032EAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04032EAB RID: 208555
		[Token(Token = "0x4032EAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032EAC RID: 208556
		[Token(Token = "0x4032EAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
