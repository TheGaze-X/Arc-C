using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F9C RID: 20380
	[Token(Token = "0x2004F9C")]
	public class EnemyDuelEntryVideoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E4B5 RID: 124085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B5")]
		[Address(RVA = "0x1802900", Offset = "0x1801500", VA = "0x181802900")]
		public void OnCreate()
		{
		}

		// Token: 0x0601E4B6 RID: 124086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B6")]
		[Address(RVA = "0x1802B60", Offset = "0x1801760", VA = "0x181802B60")]
		public void OnDispose()
		{
		}

		// Token: 0x0601E4B7 RID: 124087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B7")]
		[Address(RVA = "0x1802BC0", Offset = "0x18017C0", VA = "0x181802BC0")]
		private void _CancelTweenIfNeeded()
		{
		}

		// Token: 0x0601E4B8 RID: 124088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B8")]
		[Address(RVA = "0x1802C50", Offset = "0x1801850", VA = "0x181802C50")]
		public EnemyDuelEntryVideoView()
		{
		}

		// Token: 0x04028703 RID: 165635
		[Token(Token = "0x4028703")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation[] _loopAnims;

		// Token: 0x04028704 RID: 165636
		[Token(Token = "0x4028704")]
		[FieldOffset(Offset = "0x20")]
		private Tween m_animTween;

		// Token: 0x04028705 RID: 165637
		[Token(Token = "0x4028705")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04028706 RID: 165638
		[Token(Token = "0x4028706")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDispose;

		// Token: 0x04028707 RID: 165639
		[Token(Token = "0x4028707")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CancelTweenIfNeeded;

		// Token: 0x04028708 RID: 165640
		[Token(Token = "0x4028708")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
