using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034AD RID: 13485
	[Token(Token = "0x20034AD")]
	public class ActBattleFinishCommonMilestoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060157E9 RID: 88041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157E9")]
		[Address(RVA = "0xDF5B60", Offset = "0xDF4760", VA = "0x180DF5B60")]
		public void Render(ActBattleFinishCommonMilestoneViewModel model)
		{
		}

		// Token: 0x060157EA RID: 88042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60157EA")]
		[Address(RVA = "0xDF5A10", Offset = "0xDF4610", VA = "0x180DF5A10")]
		public Tween PlayAnim()
		{
			return null;
		}

		// Token: 0x060157EB RID: 88043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157EB")]
		[Address(RVA = "0xDF6120", Offset = "0xDF4D20", VA = "0x180DF6120")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060157EC RID: 88044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157EC")]
		[Address(RVA = "0xDF62A0", Offset = "0xDF4EA0", VA = "0x180DF62A0")]
		private void _KillAllTweenIfNeed()
		{
		}

		// Token: 0x060157ED RID: 88045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157ED")]
		[Address(RVA = "0xDF6370", Offset = "0xDF4F70", VA = "0x180DF6370")]
		private void _PlayLevelAnimationIfNeed()
		{
		}

		// Token: 0x060157EE RID: 88046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157EE")]
		[Address(RVA = "0xDF6480", Offset = "0xDF5080", VA = "0x180DF6480")]
		public ActBattleFinishCommonMilestoneView()
		{
		}

		// Token: 0x04019BF1 RID: 105457
		[Token(Token = "0x4019BF1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x04019BF2 RID: 105458
		[Token(Token = "0x4019BF2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _expProgressText;

		// Token: 0x04019BF3 RID: 105459
		[Token(Token = "0x4019BF3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _expTargetText;

		// Token: 0x04019BF4 RID: 105460
		[Token(Token = "0x4019BF4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _expProgressSlider;

		// Token: 0x04019BF5 RID: 105461
		[Token(Token = "0x4019BF5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _sliderPanel;

		// Token: 0x04019BF6 RID: 105462
		[Token(Token = "0x4019BF6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _playBarDuration;

		// Token: 0x04019BF7 RID: 105463
		[Token(Token = "0x4019BF7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _levelUpAnimation;

		// Token: 0x04019BF8 RID: 105464
		[Token(Token = "0x4019BF8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _levelMaxAnimation;

		// Token: 0x04019BF9 RID: 105465
		[Token(Token = "0x4019BF9")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04019BFA RID: 105466
		[Token(Token = "0x4019BFA")]
		[FieldOffset(Offset = "0x70")]
		private AnimationWrapper m_levelUpWrapper;

		// Token: 0x04019BFB RID: 105467
		[Token(Token = "0x4019BFB")]
		[FieldOffset(Offset = "0x78")]
		private AnimationWrapper m_levelMaxWrapper;

		// Token: 0x04019BFC RID: 105468
		[Token(Token = "0x4019BFC")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasAnim;

		// Token: 0x04019BFD RID: 105469
		[Token(Token = "0x4019BFD")]
		[FieldOffset(Offset = "0x88")]
		private List<ActBattleFinishCommonMilestoneViewModel.LevelPlayItem> m_playItems;

		// Token: 0x04019BFE RID: 105470
		[Token(Token = "0x4019BFE")]
		[FieldOffset(Offset = "0x90")]
		private bool m_levelUp;

		// Token: 0x04019BFF RID: 105471
		[Token(Token = "0x4019BFF")]
		[FieldOffset(Offset = "0x91")]
		private bool m_levelMax;

		// Token: 0x04019C00 RID: 105472
		[Token(Token = "0x4019C00")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_levelUpTween;

		// Token: 0x04019C01 RID: 105473
		[Token(Token = "0x4019C01")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_levelMaxTween;

		// Token: 0x04019C02 RID: 105474
		[Token(Token = "0x4019C02")]
		[FieldOffset(Offset = "0xA8")]
		private ActBattleFinishCommonMilestoneView.ProceduralTween m_proceduralTween;

		// Token: 0x04019C03 RID: 105475
		[Token(Token = "0x4019C03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04019C04 RID: 105476
		[Token(Token = "0x4019C04")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x04019C05 RID: 105477
		[Token(Token = "0x4019C05")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019C06 RID: 105478
		[Token(Token = "0x4019C06")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__KillAllTweenIfNeed;

		// Token: 0x04019C07 RID: 105479
		[Token(Token = "0x4019C07")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayLevelAnimationIfNeed;

		// Token: 0x04019C08 RID: 105480
		[Token(Token = "0x4019C08")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034AE RID: 13486
		[Token(Token = "0x20034AE")]
		private class ProceduralTween : UIProceduralTween<ActBattleFinishCommonMilestoneViewModel.LevelPlayItem>
		{
			// Token: 0x060157EF RID: 88047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60157EF")]
			[Address(RVA = "0xE05D50", Offset = "0xE04950", VA = "0x180E05D50")]
			public ProceduralTween(ActBattleFinishCommonMilestoneView closure)
			{
			}

			// Token: 0x060157F0 RID: 88048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60157F0")]
			[Address(RVA = "0xE05B30", Offset = "0xE04730", VA = "0x180E05B30", Slot = "4")]
			protected override void SampleClip(ActBattleFinishCommonMilestoneViewModel.LevelPlayItem clip, int localIndex)
			{
			}

			// Token: 0x04019C09 RID: 105481
			[Token(Token = "0x4019C09")]
			[FieldOffset(Offset = "0x48")]
			private readonly ActBattleFinishCommonMilestoneView m_closure;

			// Token: 0x04019C0A RID: 105482
			[Token(Token = "0x4019C0A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019C0B RID: 105483
			[Token(Token = "0x4019C0B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SampleClip;
		}
	}
}
