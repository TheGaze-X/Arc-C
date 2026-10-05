using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Fx;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F56 RID: 8022
	[Token(Token = "0x2001F56")]
	public class AVGEffectItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x0600C76B RID: 51051 RVA: 0x00048B28 File Offset: 0x00046D28
		// (set) Token: 0x0600C76C RID: 51052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700179F")]
		public float duration
		{
			[Token(Token = "0x600C76B")]
			[Address(RVA = "0x347DBC0", Offset = "0x347C7C0", VA = "0x18347DBC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600C76C")]
			[Address(RVA = "0x347DD60", Offset = "0x347C960", VA = "0x18347DD60")]
			set
			{
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x0600C76D RID: 51053 RVA: 0x00048B40 File Offset: 0x00046D40
		// (set) Token: 0x0600C76E RID: 51054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017A0")]
		public AVGEffectItem.FadeType fadeType
		{
			[Token(Token = "0x600C76D")]
			[Address(RVA = "0x347DC20", Offset = "0x347C820", VA = "0x18347DC20")]
			get
			{
				return AVGEffectItem.FadeType.NONE;
			}
			[Token(Token = "0x600C76E")]
			[Address(RVA = "0x347DDD0", Offset = "0x347C9D0", VA = "0x18347DDD0")]
			set
			{
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x0600C76F RID: 51055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C770 RID: 51056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017A1")]
		public Animator animator
		{
			[Token(Token = "0x600C76F")]
			[Address(RVA = "0x347DB60", Offset = "0x347C760", VA = "0x18347DB60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C770")]
			[Address(RVA = "0x347DCE0", Offset = "0x347C8E0", VA = "0x18347DCE0")]
			set
			{
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x0600C771 RID: 51057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A2")]
		public MeshRenderer[] imageEffectMeshRenderers
		{
			[Token(Token = "0x600C771")]
			[Address(RVA = "0x347DC80", Offset = "0x347C880", VA = "0x18347DC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C772 RID: 51058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C772")]
		[Address(RVA = "0x347C400", Offset = "0x347B000", VA = "0x18347C400")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C773 RID: 51059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C773")]
		[Address(RVA = "0x347C720", Offset = "0x347B320", VA = "0x18347C720")]
		private void _CacheParam()
		{
		}

		// Token: 0x0600C774 RID: 51060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C774")]
		[Address(RVA = "0x347C090", Offset = "0x347AC90", VA = "0x18347C090")]
		public void InitEffectShow(float duration)
		{
		}

		// Token: 0x0600C775 RID: 51061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C775")]
		[Address(RVA = "0x347CBA0", Offset = "0x347B7A0", VA = "0x18347CBA0")]
		private void _ProcessAnimation(float duration)
		{
		}

		// Token: 0x0600C776 RID: 51062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C776")]
		[Address(RVA = "0x347CC70", Offset = "0x347B870", VA = "0x18347CC70")]
		private void _ProcessAnimatorHide(float duration)
		{
		}

		// Token: 0x0600C777 RID: 51063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C777")]
		[Address(RVA = "0x347CFC0", Offset = "0x347BBC0", VA = "0x18347CFC0")]
		private void _ProcessAnimatorShow(float duration)
		{
		}

		// Token: 0x0600C778 RID: 51064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C778")]
		[Address(RVA = "0x347CA70", Offset = "0x347B670", VA = "0x18347CA70")]
		private void _OnAnimatorDestroy()
		{
		}

		// Token: 0x0600C779 RID: 51065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C779")]
		[Address(RVA = "0x347C890", Offset = "0x347B490", VA = "0x18347C890")]
		private IEnumerator _CheckAnimatorState(Animator animator, string stateName, Action callback)
		{
			return null;
		}

		// Token: 0x0600C77A RID: 51066 RVA: 0x00048B58 File Offset: 0x00046D58
		[Token(Token = "0x600C77A")]
		[Address(RVA = "0x347C9A0", Offset = "0x347B5A0", VA = "0x18347C9A0")]
		private bool _CheckAnimatorState(Animator animator, string stateName)
		{
			return default(bool);
		}

		// Token: 0x0600C77B RID: 51067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C77B")]
		[Address(RVA = "0x347D5E0", Offset = "0x347C1E0", VA = "0x18347D5E0")]
		private void _ProcessTween(float duration)
		{
		}

		// Token: 0x0600C77C RID: 51068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C77C")]
		[Address(RVA = "0x347D2E0", Offset = "0x347BEE0", VA = "0x18347D2E0")]
		private void _ProcessEmission(float duration)
		{
		}

		// Token: 0x0600C77D RID: 51069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C77D")]
		[Address(RVA = "0x347BE90", Offset = "0x347AA90", VA = "0x18347BE90")]
		public void HideEffect(float duration)
		{
		}

		// Token: 0x0600C77E RID: 51070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C77E")]
		[Address(RVA = "0x347D170", Offset = "0x347BD70", VA = "0x18347D170")]
		private void _ProcessEmissionState(bool isShow, float duration)
		{
		}

		// Token: 0x0600C77F RID: 51071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C77F")]
		[Address(RVA = "0x347D3A0", Offset = "0x347BFA0", VA = "0x18347D3A0")]
		private void _ProcessParticleEmissions(bool active)
		{
		}

		// Token: 0x0600C780 RID: 51072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C780")]
		[Address(RVA = "0x347D4B0", Offset = "0x347C0B0", VA = "0x18347D4B0")]
		private void _ProcessTwHide(float duration)
		{
		}

		// Token: 0x0600C781 RID: 51073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C781")]
		[Address(RVA = "0x347C4E0", Offset = "0x347B0E0", VA = "0x18347C4E0")]
		private void Update()
		{
		}

		// Token: 0x0600C782 RID: 51074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C782")]
		[Address(RVA = "0x347CAD0", Offset = "0x347B6D0", VA = "0x18347CAD0")]
		private void _OnStateChage(AVGEffectItem.State from, AVGEffectItem.State to)
		{
		}

		// Token: 0x0600C783 RID: 51075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C783")]
		[Address(RVA = "0x347D8F0", Offset = "0x347C4F0", VA = "0x18347D8F0")]
		private void _UpdateParticleCount(float multiplior)
		{
		}

		// Token: 0x0600C784 RID: 51076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C784")]
		[Address(RVA = "0x347DAA0", Offset = "0x347C6A0", VA = "0x18347DAA0")]
		public AVGEffectItem()
		{
		}

		// Token: 0x0400CD5A RID: 52570
		[Token(Token = "0x400CD5A")]
		public const string ANIMATOR_CONDITION_END = "End";

		// Token: 0x0400CD5B RID: 52571
		[Token(Token = "0x400CD5B")]
		public const string ANIMATOR_DESTORY_STATE_NAME = "destroy";

		// Token: 0x0400CD5C RID: 52572
		[Token(Token = "0x400CD5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _effectDuration;

		// Token: 0x0400CD5D RID: 52573
		[Token(Token = "0x400CD5D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private AVGEffectItem.FadeType _fadeType;

		// Token: 0x0400CD5E RID: 52574
		[Token(Token = "0x400CD5E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem[] _particleSystemList;

		// Token: 0x0400CD5F RID: 52575
		[Token(Token = "0x400CD5F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animation _fadeAnimation;

		// Token: 0x0400CD60 RID: 52576
		[Token(Token = "0x400CD60")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animator _effectAnimator;

		// Token: 0x0400CD61 RID: 52577
		[Token(Token = "0x400CD61")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MeshRenderer[] _meshRenderers;

		// Token: 0x0400CD62 RID: 52578
		[Token(Token = "0x400CD62")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FxUVTweenerAdvance _tweenController;

		// Token: 0x0400CD63 RID: 52579
		[Token(Token = "0x400CD63")]
		[FieldOffset(Offset = "0x48")]
		private TweenUtils.SmoothStep m_particleFadeTween;

		// Token: 0x0400CD64 RID: 52580
		[Token(Token = "0x400CD64")]
		[FieldOffset(Offset = "0x80")]
		private int[] maxParticleTarget;

		// Token: 0x0400CD65 RID: 52581
		[Token(Token = "0x400CD65")]
		[FieldOffset(Offset = "0x88")]
		private AVGEffectItem.State m_state;

		// Token: 0x0400CD66 RID: 52582
		[Token(Token = "0x400CD66")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_animatorEnd;

		// Token: 0x0400CD67 RID: 52583
		[Token(Token = "0x400CD67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_duration;

		// Token: 0x0400CD68 RID: 52584
		[Token(Token = "0x400CD68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_duration;

		// Token: 0x0400CD69 RID: 52585
		[Token(Token = "0x400CD69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fadeType;

		// Token: 0x0400CD6A RID: 52586
		[Token(Token = "0x400CD6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_fadeType;

		// Token: 0x0400CD6B RID: 52587
		[Token(Token = "0x400CD6B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x0400CD6C RID: 52588
		[Token(Token = "0x400CD6C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_animator;

		// Token: 0x0400CD6D RID: 52589
		[Token(Token = "0x400CD6D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_imageEffectMeshRenderers;

		// Token: 0x0400CD6E RID: 52590
		[Token(Token = "0x400CD6E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CD6F RID: 52591
		[Token(Token = "0x400CD6F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CacheParam;

		// Token: 0x0400CD70 RID: 52592
		[Token(Token = "0x400CD70")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitEffectShow;

		// Token: 0x0400CD71 RID: 52593
		[Token(Token = "0x400CD71")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ProcessAnimation;

		// Token: 0x0400CD72 RID: 52594
		[Token(Token = "0x400CD72")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ProcessAnimatorHide;

		// Token: 0x0400CD73 RID: 52595
		[Token(Token = "0x400CD73")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ProcessAnimatorShow;

		// Token: 0x0400CD74 RID: 52596
		[Token(Token = "0x400CD74")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnAnimatorDestroy;

		// Token: 0x0400CD75 RID: 52597
		[Token(Token = "0x400CD75")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckAnimatorState;

		// Token: 0x0400CD76 RID: 52598
		[Token(Token = "0x400CD76")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1__CheckAnimatorState;

		// Token: 0x0400CD77 RID: 52599
		[Token(Token = "0x400CD77")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ProcessTween;

		// Token: 0x0400CD78 RID: 52600
		[Token(Token = "0x400CD78")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ProcessEmission;

		// Token: 0x0400CD79 RID: 52601
		[Token(Token = "0x400CD79")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0400CD7A RID: 52602
		[Token(Token = "0x400CD7A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ProcessEmissionState;

		// Token: 0x0400CD7B RID: 52603
		[Token(Token = "0x400CD7B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ProcessParticleEmissions;

		// Token: 0x0400CD7C RID: 52604
		[Token(Token = "0x400CD7C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ProcessTwHide;

		// Token: 0x0400CD7D RID: 52605
		[Token(Token = "0x400CD7D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400CD7E RID: 52606
		[Token(Token = "0x400CD7E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnStateChage;

		// Token: 0x0400CD7F RID: 52607
		[Token(Token = "0x400CD7F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UpdateParticleCount;

		// Token: 0x0400CD80 RID: 52608
		[Token(Token = "0x400CD80")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F57 RID: 8023
		[Token(Token = "0x2001F57")]
		public enum State
		{
			// Token: 0x0400CD82 RID: 52610
			[Token(Token = "0x400CD82")]
			IDLE,
			// Token: 0x0400CD83 RID: 52611
			[Token(Token = "0x400CD83")]
			SHOWING,
			// Token: 0x0400CD84 RID: 52612
			[Token(Token = "0x400CD84")]
			HIDING
		}

		// Token: 0x02001F58 RID: 8024
		[Token(Token = "0x2001F58")]
		public enum FadeType
		{
			// Token: 0x0400CD86 RID: 52614
			[Token(Token = "0x400CD86")]
			NONE,
			// Token: 0x0400CD87 RID: 52615
			[Token(Token = "0x400CD87")]
			ANIMATION,
			// Token: 0x0400CD88 RID: 52616
			[Token(Token = "0x400CD88")]
			TWEEN,
			// Token: 0x0400CD89 RID: 52617
			[Token(Token = "0x400CD89")]
			EMISSION,
			// Token: 0x0400CD8A RID: 52618
			[Token(Token = "0x400CD8A")]
			ANIMATOR
		}
	}
}
