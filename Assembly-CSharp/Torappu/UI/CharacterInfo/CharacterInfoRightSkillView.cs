using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FA0 RID: 24480
	[Token(Token = "0x2005FA0")]
	public class CharacterInfoRightSkillView : CharacterInfoCommonObj, IHotfixable
	{
		// Token: 0x060236A6 RID: 145062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236A6")]
		[Address(RVA = "0x1E0A150", Offset = "0x1E08D50", VA = "0x181E0A150", Slot = "6")]
		public override void AllHide()
		{
		}

		// Token: 0x060236A7 RID: 145063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236A7")]
		[Address(RVA = "0x1E0A1F0", Offset = "0x1E08DF0", VA = "0x181E0A1F0", Slot = "5")]
		public override void ApplyViewModel(CharacterInfoHolderBean.CharViewModel charViewModel)
		{
		}

		// Token: 0x060236A8 RID: 145064 RVA: 0x000C0CA8 File Offset: 0x000BEEA8
		[Token(Token = "0x60236A8")]
		[Address(RVA = "0x1E0A310", Offset = "0x1E08F10", VA = "0x181E0A310", Slot = "4")]
		public override float GetHeight()
		{
			return 0f;
		}

		// Token: 0x060236A9 RID: 145065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236A9")]
		[Address(RVA = "0x1E0A5E0", Offset = "0x1E091E0", VA = "0x181E0A5E0")]
		private void _OnHide()
		{
		}

		// Token: 0x060236AA RID: 145066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236AA")]
		[Address(RVA = "0x1E0A6C0", Offset = "0x1E092C0", VA = "0x181E0A6C0")]
		private void _OnShow()
		{
		}

		// Token: 0x060236AB RID: 145067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236AB")]
		[Address(RVA = "0x1E0A8B0", Offset = "0x1E094B0", VA = "0x181E0A8B0")]
		private void _TweenBackColor(float target)
		{
		}

		// Token: 0x060236AC RID: 145068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236AC")]
		[Address(RVA = "0x1E0A510", Offset = "0x1E09110", VA = "0x181E0A510")]
		public void OnClickHide()
		{
		}

		// Token: 0x060236AD RID: 145069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236AD")]
		[Address(RVA = "0x1E0A570", Offset = "0x1E09170", VA = "0x181E0A570")]
		public void OnClickShow()
		{
		}

		// Token: 0x060236AE RID: 145070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236AE")]
		[Address(RVA = "0x1E0AA30", Offset = "0x1E09630", VA = "0x181E0AA30")]
		public CharacterInfoRightSkillView()
		{
		}

		// Token: 0x060236B2 RID: 145074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236B2")]
		[Address(RVA = "0x1DFEB20", Offset = "0x1DFD720", VA = "0x181DFEB20")]
		private void <>xLuaBaseProxy_AllHide()
		{
		}

		// Token: 0x04030EEF RID: 200431
		[Token(Token = "0x4030EEF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x04030EF0 RID: 200432
		[Token(Token = "0x4030EF0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterInfoRightSkillHideView _hideView;

		// Token: 0x04030EF1 RID: 200433
		[Token(Token = "0x4030EF1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CharacterInfoRightSkillSpreadView _spreadView;

		// Token: 0x04030EF2 RID: 200434
		[Token(Token = "0x4030EF2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x04030EF3 RID: 200435
		[Token(Token = "0x4030EF3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x04030EF4 RID: 200436
		[Token(Token = "0x4030EF4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent _onResetSkill;

		// Token: 0x04030EF5 RID: 200437
		[Token(Token = "0x4030EF5")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_cacheTween;

		// Token: 0x04030EF6 RID: 200438
		[Token(Token = "0x4030EF6")]
		[FieldOffset(Offset = "0x68")]
		private CharacterInfoHolderBean.CharViewModel m_cacheViewModel;

		// Token: 0x04030EF7 RID: 200439
		[Token(Token = "0x4030EF7")]
		private const string ANIM_PARAM = "skill_anim";

		// Token: 0x04030EF8 RID: 200440
		[Token(Token = "0x4030EF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AllHide;

		// Token: 0x04030EF9 RID: 200441
		[Token(Token = "0x4030EF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyViewModel;

		// Token: 0x04030EFA RID: 200442
		[Token(Token = "0x4030EFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetHeight;

		// Token: 0x04030EFB RID: 200443
		[Token(Token = "0x4030EFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnHide;

		// Token: 0x04030EFC RID: 200444
		[Token(Token = "0x4030EFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnShow;

		// Token: 0x04030EFD RID: 200445
		[Token(Token = "0x4030EFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TweenBackColor;

		// Token: 0x04030EFE RID: 200446
		[Token(Token = "0x4030EFE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickHide;

		// Token: 0x04030EFF RID: 200447
		[Token(Token = "0x4030EFF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickShow;

		// Token: 0x04030F00 RID: 200448
		[Token(Token = "0x4030F00")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
