using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005011 RID: 20497
	[Token(Token = "0x2005011")]
	public class EnemyDuelRoundEndStandPlayerInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E69F RID: 124575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E69F")]
		[Address(RVA = "0x181F900", Offset = "0x181E500", VA = "0x18181F900")]
		public void ApplyData(string actId, EnemyDuelPlayerData data, int curRoundIndex, bool isProtectedRound, bool isLastRound)
		{
		}

		// Token: 0x0601E6A0 RID: 124576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6A0")]
		[Address(RVA = "0x181FF60", Offset = "0x181EB60", VA = "0x18181FF60")]
		private static void _PlayAnim(UIAnimationLocation anim, ref Tween tween)
		{
		}

		// Token: 0x0601E6A1 RID: 124577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6A1")]
		[Address(RVA = "0x1820070", Offset = "0x181EC70", VA = "0x181820070")]
		public EnemyDuelRoundEndStandPlayerInfoView()
		{
		}

		// Token: 0x04028B08 RID: 166664
		[Token(Token = "0x4028B08")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Mine")]
		private GameObject _objMine;

		// Token: 0x04028B09 RID: 166665
		[Token(Token = "0x4028B09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Mine")]
		private Text _textNameMine;

		// Token: 0x04028B0A RID: 166666
		[Token(Token = "0x4028B0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Mine")]
		private Image _imgAvatarMine;

		// Token: 0x04028B0B RID: 166667
		[Token(Token = "0x4028B0B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Other Normal")]
		private GameObject _objOtherNormal;

		// Token: 0x04028B0C RID: 166668
		[Token(Token = "0x4028B0C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Other Normal")]
		private Text _textNameOtherNormal;

		// Token: 0x04028B0D RID: 166669
		[Token(Token = "0x4028B0D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Other Normal")]
		private Image _imgAvatarOtherNormal;

		// Token: 0x04028B0E RID: 166670
		[Token(Token = "0x4028B0E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Other shield broken")]
		private GameObject _objOtherShieldBroken;

		// Token: 0x04028B0F RID: 166671
		[Token(Token = "0x4028B0F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Other shield broken")]
		private Text _textNameOtherShieldBroken;

		// Token: 0x04028B10 RID: 166672
		[Token(Token = "0x4028B10")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Other shield broken")]
		private Image _imgAvatarOtherShieldBroken;

		// Token: 0x04028B11 RID: 166673
		[Token(Token = "0x4028B11")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objWin;

		// Token: 0x04028B12 RID: 166674
		[Token(Token = "0x4028B12")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objChampion;

		// Token: 0x04028B13 RID: 166675
		[Token(Token = "0x4028B13")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objShieldBroken;

		// Token: 0x04028B14 RID: 166676
		[Token(Token = "0x4028B14")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objShield;

		// Token: 0x04028B15 RID: 166677
		[Token(Token = "0x4028B15")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _objOut;

		// Token: 0x04028B16 RID: 166678
		[Token(Token = "0x4028B16")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textNameOut;

		// Token: 0x04028B17 RID: 166679
		[Token(Token = "0x4028B17")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _animChampion;

		// Token: 0x04028B18 RID: 166680
		[Token(Token = "0x4028B18")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _animOut;

		// Token: 0x04028B19 RID: 166681
		[Token(Token = "0x4028B19")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _animShieldBreak;

		// Token: 0x04028B1A RID: 166682
		[Token(Token = "0x4028B1A")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028B1B RID: 166683
		[Token(Token = "0x4028B1B")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_tweenWin;

		// Token: 0x04028B1C RID: 166684
		[Token(Token = "0x4028B1C")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_tweenChampion;

		// Token: 0x04028B1D RID: 166685
		[Token(Token = "0x4028B1D")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_tweenOut;

		// Token: 0x04028B1E RID: 166686
		[Token(Token = "0x4028B1E")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_tweenShieldBreak;

		// Token: 0x04028B1F RID: 166687
		[Token(Token = "0x4028B1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04028B20 RID: 166688
		[Token(Token = "0x4028B20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x04028B21 RID: 166689
		[Token(Token = "0x4028B21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
