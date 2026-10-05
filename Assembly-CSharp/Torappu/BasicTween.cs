using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000593 RID: 1427
	[Token(Token = "0x2000593")]
	public abstract class BasicTween<ValueType> : MonoBehaviour, IHotfixable
	{
		// Token: 0x06005C2A RID: 23594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2A")]
		private void Start()
		{
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2B")]
		private void OnEnable()
		{
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2C")]
		private void OnDisable()
		{
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2D")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2E")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x06005C2F RID: 23599
		[Token(Token = "0x6005C2F")]
		protected abstract ValueType GetTweenValue();

		// Token: 0x06005C30 RID: 23600
		[Token(Token = "0x6005C30")]
		protected abstract void SetTweenValue(ValueType val);

		// Token: 0x06005C31 RID: 23601
		[Token(Token = "0x6005C31")]
		protected abstract Tweener ConstructTweener(ValueType fromValue, ValueType toValue, float duration);

		// Token: 0x06005C32 RID: 23602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C32")]
		public void PlayWithDirection(bool isForward)
		{
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C33")]
		public void Play()
		{
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C34")]
		public void Pause()
		{
		}

		// Token: 0x06005C35 RID: 23605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C35")]
		public void Stop()
		{
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C36")]
		private void _Play(bool isForward, bool startByFrom)
		{
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C37")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C38")]
		protected BasicTween()
		{
		}

		// Token: 0x040021D3 RID: 8659
		[Token(Token = "0x40021D3")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ValueType _from;

		// Token: 0x040021D4 RID: 8660
		[Token(Token = "0x40021D4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ValueType _to;

		// Token: 0x040021D5 RID: 8661
		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _startByFrom;

		// Token: 0x040021D6 RID: 8662
		[Token(Token = "0x40021D6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _duration;

		// Token: 0x040021D7 RID: 8663
		[Token(Token = "0x40021D7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float _delay;

		// Token: 0x040021D8 RID: 8664
		[Token(Token = "0x40021D8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x040021D9 RID: 8665
		[Token(Token = "0x40021D9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int _loop;

		// Token: 0x040021DA RID: 8666
		[Token(Token = "0x40021DA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LoopType _loopType;

		// Token: 0x040021DB RID: 8667
		[Token(Token = "0x40021DB")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _playWhenStart;

		// Token: 0x040021DC RID: 8668
		[Token(Token = "0x40021DC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _ignoreTimeScale;

		// Token: 0x040021DD RID: 8669
		[Token(Token = "0x40021DD")]
		[FieldOffset(Offset = "0x0")]
		private Tweener m_tweener;

		// Token: 0x040021DE RID: 8670
		[Token(Token = "0x40021DE")]
		[FieldOffset(Offset = "0x0")]
		private bool m_hasInited;

		// Token: 0x040021DF RID: 8671
		[Token(Token = "0x40021DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040021E0 RID: 8672
		[Token(Token = "0x40021E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x040021E1 RID: 8673
		[Token(Token = "0x40021E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x040021E2 RID: 8674
		[Token(Token = "0x40021E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040021E3 RID: 8675
		[Token(Token = "0x40021E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040021E4 RID: 8676
		[Token(Token = "0x40021E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PlayWithDirection;

		// Token: 0x040021E5 RID: 8677
		[Token(Token = "0x40021E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x040021E6 RID: 8678
		[Token(Token = "0x40021E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Pause;

		// Token: 0x040021E7 RID: 8679
		[Token(Token = "0x40021E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x040021E8 RID: 8680
		[Token(Token = "0x40021E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Play;

		// Token: 0x040021E9 RID: 8681
		[Token(Token = "0x40021E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040021EA RID: 8682
		[Token(Token = "0x40021EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
