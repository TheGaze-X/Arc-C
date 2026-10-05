using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F2A RID: 20266
	[Token(Token = "0x2004F2A")]
	public class EnemyHandbookBossShuffleObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E30E RID: 123662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E30E")]
		[Address(RVA = "0x17EE2F0", Offset = "0x17ECEF0", VA = "0x1817EE2F0")]
		public void OnAllClick()
		{
		}

		// Token: 0x0601E30F RID: 123663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E30F")]
		[Address(RVA = "0x17EE370", Offset = "0x17ECF70", VA = "0x1817EE370")]
		public void OnBossClick()
		{
		}

		// Token: 0x0601E310 RID: 123664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E310")]
		[Address(RVA = "0x17EE3F0", Offset = "0x17ECFF0", VA = "0x1817EE3F0")]
		public void OnEliteClick()
		{
		}

		// Token: 0x0601E311 RID: 123665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E311")]
		[Address(RVA = "0x17EE470", Offset = "0x17ED070", VA = "0x1817EE470")]
		public void SetEnemyLevelShuffle(EnemyLevelMask lvlType)
		{
		}

		// Token: 0x0601E312 RID: 123666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E312")]
		[Address(RVA = "0x17EE8F0", Offset = "0x17ED4F0", VA = "0x1817EE8F0")]
		private void _StopAllTween()
		{
		}

		// Token: 0x0601E313 RID: 123667 RVA: 0x000ADC70 File Offset: 0x000ABE70
		[Token(Token = "0x601E313")]
		[Address(RVA = "0x17EE7A0", Offset = "0x17ED3A0", VA = "0x1817EE7A0")]
		private float _GetAlpha(EnemyLevelMask type1, EnemyLevelMask type2)
		{
			return 0f;
		}

		// Token: 0x0601E314 RID: 123668 RVA: 0x000ADC88 File Offset: 0x000ABE88
		[Token(Token = "0x601E314")]
		[Address(RVA = "0x17EE850", Offset = "0x17ED450", VA = "0x1817EE850")]
		private float _GetPos(EnemyLevelMask type1)
		{
			return 0f;
		}

		// Token: 0x0601E315 RID: 123669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E315")]
		[Address(RVA = "0x17EE9F0", Offset = "0x17ED5F0", VA = "0x1817EE9F0")]
		public EnemyHandbookBossShuffleObject()
		{
		}

		// Token: 0x04028375 RID: 164725
		[Token(Token = "0x4028375")]
		[FieldOffset(Offset = "0x18")]
		private float CHANGE_DURATION;

		// Token: 0x04028376 RID: 164726
		[Token(Token = "0x4028376")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _allText;

		// Token: 0x04028377 RID: 164727
		[Token(Token = "0x4028377")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _elteText;

		// Token: 0x04028378 RID: 164728
		[Token(Token = "0x4028378")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _bossText;

		// Token: 0x04028379 RID: 164729
		[Token(Token = "0x4028379")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bar;

		// Token: 0x0402837A RID: 164730
		[Token(Token = "0x402837A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _allPos;

		// Token: 0x0402837B RID: 164731
		[Token(Token = "0x402837B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _elitePos;

		// Token: 0x0402837C RID: 164732
		[Token(Token = "0x402837C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _bossPos;

		// Token: 0x0402837D RID: 164733
		[Token(Token = "0x402837D")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UnityEnemyLevelEvent enemyLevelEvent;

		// Token: 0x0402837E RID: 164734
		[Token(Token = "0x402837E")]
		[FieldOffset(Offset = "0x58")]
		private List<Tween> m_cacheTweenList;

		// Token: 0x0402837F RID: 164735
		[Token(Token = "0x402837F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAllClick;

		// Token: 0x04028380 RID: 164736
		[Token(Token = "0x4028380")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBossClick;

		// Token: 0x04028381 RID: 164737
		[Token(Token = "0x4028381")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEliteClick;

		// Token: 0x04028382 RID: 164738
		[Token(Token = "0x4028382")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetEnemyLevelShuffle;

		// Token: 0x04028383 RID: 164739
		[Token(Token = "0x4028383")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StopAllTween;

		// Token: 0x04028384 RID: 164740
		[Token(Token = "0x4028384")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetAlpha;

		// Token: 0x04028385 RID: 164741
		[Token(Token = "0x4028385")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetPos;

		// Token: 0x04028386 RID: 164742
		[Token(Token = "0x4028386")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
