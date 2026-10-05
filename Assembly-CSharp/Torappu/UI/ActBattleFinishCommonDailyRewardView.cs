using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034AC RID: 13484
	[Token(Token = "0x20034AC")]
	public class ActBattleFinishCommonDailyRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060157E3 RID: 88035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157E3")]
		[Address(RVA = "0xDF48A0", Offset = "0xDF34A0", VA = "0x180DF48A0")]
		public void Render(ActBattleFinishCommonDailyRewardViewModel model)
		{
		}

		// Token: 0x060157E4 RID: 88036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60157E4")]
		[Address(RVA = "0xDF46A0", Offset = "0xDF32A0", VA = "0x180DF46A0")]
		public Tween PlayAnim()
		{
			return null;
		}

		// Token: 0x060157E5 RID: 88037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157E5")]
		[Address(RVA = "0xDF4D30", Offset = "0xDF3930", VA = "0x180DF4D30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060157E6 RID: 88038 RVA: 0x0008C418 File Offset: 0x0008A618
		[Token(Token = "0x60157E6")]
		[Address(RVA = "0xDF4CD0", Offset = "0xDF38D0", VA = "0x180DF4CD0")]
		private float _GetPosition()
		{
			return 0f;
		}

		// Token: 0x060157E7 RID: 88039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157E7")]
		[Address(RVA = "0xDF4DC0", Offset = "0xDF39C0", VA = "0x180DF4DC0")]
		private void _SetPosition(float position)
		{
		}

		// Token: 0x060157E8 RID: 88040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157E8")]
		[Address(RVA = "0xDF4F20", Offset = "0xDF3B20", VA = "0x180DF4F20")]
		public ActBattleFinishCommonDailyRewardView()
		{
		}

		// Token: 0x04019BDA RID: 105434
		[Token(Token = "0x4019BDA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _rootPanel;

		// Token: 0x04019BDB RID: 105435
		[Token(Token = "0x4019BDB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _progressText;

		// Token: 0x04019BDC RID: 105436
		[Token(Token = "0x4019BDC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _targetText;

		// Token: 0x04019BDD RID: 105437
		[Token(Token = "0x4019BDD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _progressPanel;

		// Token: 0x04019BDE RID: 105438
		[Token(Token = "0x4019BDE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x04019BDF RID: 105439
		[Token(Token = "0x4019BDF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _rewardCountText;

		// Token: 0x04019BE0 RID: 105440
		[Token(Token = "0x4019BE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _playBarDuration;

		// Token: 0x04019BE1 RID: 105441
		[Token(Token = "0x4019BE1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _playAnimation;

		// Token: 0x04019BE2 RID: 105442
		[Token(Token = "0x4019BE2")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04019BE3 RID: 105443
		[Token(Token = "0x4019BE3")]
		[FieldOffset(Offset = "0x68")]
		private AnimationWrapper m_playWrapper;

		// Token: 0x04019BE4 RID: 105444
		[Token(Token = "0x4019BE4")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasAnim;

		// Token: 0x04019BE5 RID: 105445
		[Token(Token = "0x4019BE5")]
		[FieldOffset(Offset = "0x74")]
		private int m_figureMoveStart;

		// Token: 0x04019BE6 RID: 105446
		[Token(Token = "0x4019BE6")]
		[FieldOffset(Offset = "0x78")]
		private int m_figureMoveEnd;

		// Token: 0x04019BE7 RID: 105447
		[Token(Token = "0x4019BE7")]
		[FieldOffset(Offset = "0x7C")]
		private int m_figureVolume;

		// Token: 0x04019BE8 RID: 105448
		[Token(Token = "0x4019BE8")]
		[FieldOffset(Offset = "0x80")]
		private float m_figureMovePosition;

		// Token: 0x04019BE9 RID: 105449
		[Token(Token = "0x4019BE9")]
		[FieldOffset(Offset = "0x84")]
		private bool m_complete;

		// Token: 0x04019BEA RID: 105450
		[Token(Token = "0x4019BEA")]
		[FieldOffset(Offset = "0x88")]
		private Sequence m_sequence;

		// Token: 0x04019BEB RID: 105451
		[Token(Token = "0x4019BEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04019BEC RID: 105452
		[Token(Token = "0x4019BEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x04019BED RID: 105453
		[Token(Token = "0x4019BED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019BEE RID: 105454
		[Token(Token = "0x4019BEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x04019BEF RID: 105455
		[Token(Token = "0x4019BEF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetPosition;

		// Token: 0x04019BF0 RID: 105456
		[Token(Token = "0x4019BF0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
