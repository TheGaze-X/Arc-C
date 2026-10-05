using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006508 RID: 25864
	[Token(Token = "0x2006508")]
	public class AutoChessBattleUIPrepReadyPlayerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060252E0 RID: 152288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252E0")]
		[Address(RVA = "0x203F6C0", Offset = "0x203E2C0", VA = "0x18203F6C0")]
		public void Render(bool isShow, bool fastMode, bool showWithDelay = false)
		{
		}

		// Token: 0x060252E1 RID: 152289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252E1")]
		[Address(RVA = "0x203F940", Offset = "0x203E540", VA = "0x18203F940")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060252E2 RID: 152290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252E2")]
		[Address(RVA = "0x203F9D0", Offset = "0x203E5D0", VA = "0x18203F9D0")]
		public AutoChessBattleUIPrepReadyPlayerView()
		{
		}

		// Token: 0x04034255 RID: 213589
		[Token(Token = "0x4034255")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x04034256 RID: 213590
		[Token(Token = "0x4034256")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _hideAnimLocation;

		// Token: 0x04034257 RID: 213591
		[Token(Token = "0x4034257")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _showDelay;

		// Token: 0x04034258 RID: 213592
		[Token(Token = "0x4034258")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isInited;

		// Token: 0x04034259 RID: 213593
		[Token(Token = "0x4034259")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0403425A RID: 213594
		[Token(Token = "0x403425A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403425B RID: 213595
		[Token(Token = "0x403425B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403425C RID: 213596
		[Token(Token = "0x403425C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
