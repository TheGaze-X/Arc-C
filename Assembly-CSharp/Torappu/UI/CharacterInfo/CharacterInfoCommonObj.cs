using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F94 RID: 24468
	[Token(Token = "0x2005F94")]
	public abstract class CharacterInfoCommonObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023664 RID: 144996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023664")]
		[Address(RVA = "0x1DFEDD0", Offset = "0x1DFD9D0", VA = "0x181DFEDD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023665 RID: 144997
		[Token(Token = "0x6023665")]
		public abstract float GetHeight();

		// Token: 0x06023666 RID: 144998
		[Token(Token = "0x6023666")]
		public abstract void ApplyViewModel(CharacterInfoHolderBean.CharViewModel charViewModel);

		// Token: 0x06023667 RID: 144999 RVA: 0x000C0B88 File Offset: 0x000BED88
		[Token(Token = "0x6023667")]
		[Address(RVA = "0x1DFEB80", Offset = "0x1DFD780", VA = "0x181DFEB80")]
		public bool IsTweening()
		{
			return default(bool);
		}

		// Token: 0x06023668 RID: 145000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023668")]
		[Address(RVA = "0x1DFEC30", Offset = "0x1DFD830", VA = "0x181DFEC30")]
		public void TweenHeight(bool stageChangeFlag = false)
		{
		}

		// Token: 0x06023669 RID: 145001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023669")]
		[Address(RVA = "0x1DFEB20", Offset = "0x1DFD720", VA = "0x181DFEB20", Slot = "6")]
		public virtual void AllHide()
		{
		}

		// Token: 0x0602366A RID: 145002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602366A")]
		[Address(RVA = "0x1DFEE70", Offset = "0x1DFDA70", VA = "0x181DFEE70")]
		protected CharacterInfoCommonObj()
		{
		}

		// Token: 0x04030E81 RID: 200321
		[Token(Token = "0x4030E81")]
		private const float TWEEN_DURATION = 0.35f;

		// Token: 0x04030E82 RID: 200322
		[Token(Token = "0x4030E82")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HeightTweenLayoutElement _layoutElement;

		// Token: 0x04030E83 RID: 200323
		[Token(Token = "0x4030E83")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action onStateChange;

		// Token: 0x04030E84 RID: 200324
		[Token(Token = "0x4030E84")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public bool isHide;

		// Token: 0x04030E85 RID: 200325
		[Token(Token = "0x4030E85")]
		[FieldOffset(Offset = "0x29")]
		private bool m_isInited;

		// Token: 0x04030E86 RID: 200326
		[Token(Token = "0x4030E86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030E87 RID: 200327
		[Token(Token = "0x4030E87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsTweening;

		// Token: 0x04030E88 RID: 200328
		[Token(Token = "0x4030E88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TweenHeight;

		// Token: 0x04030E89 RID: 200329
		[Token(Token = "0x4030E89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AllHide;

		// Token: 0x04030E8A RID: 200330
		[Token(Token = "0x4030E8A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
