using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BF5 RID: 7157
	[Token(Token = "0x2001BF5")]
	public class WorkshopMotionEffect : MonoBehaviour
	{
		// Token: 0x0600B277 RID: 45687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B277")]
		[Address(RVA = "0x32EB630", Offset = "0x32EA230", VA = "0x1832EB630")]
		private IEnumerator _MakeEffectCoroutine(bool ingredient1Play, bool ingredient2Play, bool ingredient3Play, int workCount, Action<int> circleHandler, Action endHandler)
		{
			return null;
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B278")]
		[Address(RVA = "0x32EB830", Offset = "0x32EA430", VA = "0x1832EB830")]
		private IEnumerator _RecoverCoroutine(float duration)
		{
			return null;
		}

		// Token: 0x0600B279 RID: 45689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B279")]
		[Address(RVA = "0x32EB550", Offset = "0x32EA150", VA = "0x1832EB550")]
		public void ResetMakeEffect()
		{
		}

		// Token: 0x0600B27A RID: 45690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B27A")]
		[Address(RVA = "0x32EB380", Offset = "0x32E9F80", VA = "0x1832EB380")]
		public void PerformMakeEffect(bool ingredient1Play, bool ingredient2Play, bool ingredient3Play, int workCount, Action<int> circleHandler, Action endHandler)
		{
		}

		// Token: 0x0600B27B RID: 45691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B27B")]
		[Address(RVA = "0x32EB490", Offset = "0x32EA090", VA = "0x1832EB490")]
		public void PerformRecoverEffect()
		{
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B27C")]
		[Address(RVA = "0x32EB5F0", Offset = "0x32EA1F0", VA = "0x1832EB5F0")]
		public void StopMakeEffect()
		{
		}

		// Token: 0x0600B27D RID: 45693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B27D")]
		[Address(RVA = "0x32EB340", Offset = "0x32E9F40", VA = "0x1832EB340")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B27E RID: 45694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B27E")]
		[Address(RVA = "0x32EB7D0", Offset = "0x32EA3D0", VA = "0x1832EB7D0")]
		private void _PlayStartIndustSe()
		{
		}

		// Token: 0x0600B27F RID: 45695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B27F")]
		[Address(RVA = "0x32EB770", Offset = "0x32EA370", VA = "0x1832EB770")]
		private void _PlayIndustCircleSingleSe()
		{
		}

		// Token: 0x0600B280 RID: 45696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B280")]
		[Address(RVA = "0x32EB710", Offset = "0x32EA310", VA = "0x1832EB710")]
		private void _PlayIndustCircleMultiSe()
		{
		}

		// Token: 0x0600B281 RID: 45697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B281")]
		[Address(RVA = "0x32EB8C0", Offset = "0x32EA4C0", VA = "0x1832EB8C0")]
		public WorkshopMotionEffect()
		{
		}

		// Token: 0x0400AD92 RID: 44434
		[Token(Token = "0x400AD92")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _barTime;

		// Token: 0x0400AD93 RID: 44435
		[Token(Token = "0x400AD93")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _circleTime;

		// Token: 0x0400AD94 RID: 44436
		[Token(Token = "0x400AD94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _progressCircle;

		// Token: 0x0400AD95 RID: 44437
		[Token(Token = "0x400AD95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _subBar1;

		// Token: 0x0400AD96 RID: 44438
		[Token(Token = "0x400AD96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _subBar2;

		// Token: 0x0400AD97 RID: 44439
		[Token(Token = "0x400AD97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _subBar3;

		// Token: 0x0400AD98 RID: 44440
		[Token(Token = "0x400AD98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _barAnimationCurve;

		// Token: 0x0400AD99 RID: 44441
		[Token(Token = "0x400AD99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _maxCircleCount;

		// Token: 0x0400AD9A RID: 44442
		[Token(Token = "0x400AD9A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _recoverDuration;

		// Token: 0x0400AD9B RID: 44443
		[Token(Token = "0x400AD9B")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine m_coroutine;

		// Token: 0x0400AD9C RID: 44444
		[Token(Token = "0x400AD9C")]
		[FieldOffset(Offset = "0x58")]
		private bool m_shouldBreak;
	}
}
