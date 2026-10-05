using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F9F RID: 24479
	[Token(Token = "0x2005F9F")]
	public class CharacterInfoRightProfView : CharacterInfoCommonObj
	{
		// Token: 0x0602369A RID: 145050 RVA: 0x000C0C78 File Offset: 0x000BEE78
		[Token(Token = "0x602369A")]
		[Address(RVA = "0x1E08220", Offset = "0x1E06E20", VA = "0x181E08220", Slot = "4")]
		public override float GetHeight()
		{
			return 0f;
		}

		// Token: 0x0602369B RID: 145051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602369B")]
		[Address(RVA = "0x1E080D0", Offset = "0x1E06CD0", VA = "0x181E080D0", Slot = "6")]
		public override void AllHide()
		{
		}

		// Token: 0x0602369C RID: 145052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602369C")]
		[Address(RVA = "0x1E08170", Offset = "0x1E06D70", VA = "0x181E08170", Slot = "5")]
		public override void ApplyViewModel(CharacterInfoHolderBean.CharViewModel charViewModel)
		{
		}

		// Token: 0x0602369D RID: 145053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602369D")]
		[Address(RVA = "0x1E08510", Offset = "0x1E07110", VA = "0x181E08510")]
		private void _OnHide()
		{
		}

		// Token: 0x0602369E RID: 145054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602369E")]
		[Address(RVA = "0x1E085F0", Offset = "0x1E071F0", VA = "0x181E085F0")]
		private void _OnShow()
		{
		}

		// Token: 0x0602369F RID: 145055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602369F")]
		[Address(RVA = "0x1E08730", Offset = "0x1E07330", VA = "0x181E08730")]
		private void _TweenBackColor(float target)
		{
		}

		// Token: 0x060236A0 RID: 145056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236A0")]
		[Address(RVA = "0x1E082B0", Offset = "0x1E06EB0", VA = "0x181E082B0")]
		public void OnClickHide()
		{
		}

		// Token: 0x060236A1 RID: 145057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236A1")]
		[Address(RVA = "0x1E08320", Offset = "0x1E06F20", VA = "0x181E08320")]
		public void OnClickShow()
		{
		}

		// Token: 0x060236A2 RID: 145058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236A2")]
		[Address(RVA = "0x1E088B0", Offset = "0x1E074B0", VA = "0x181E088B0")]
		public CharacterInfoRightProfView()
		{
		}

		// Token: 0x060236A5 RID: 145061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60236A5")]
		[Address(RVA = "0x1DFEB20", Offset = "0x1DFD720", VA = "0x181DFEB20")]
		private void <>xLuaBaseProxy_AllHide()
		{
		}

		// Token: 0x04030EDD RID: 200413
		[Token(Token = "0x4030EDD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x04030EDE RID: 200414
		[Token(Token = "0x4030EDE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterInfoRightProfHideView _profHideView;

		// Token: 0x04030EDF RID: 200415
		[Token(Token = "0x4030EDF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CharacterInfoRightProfSpreadView _spreadView;

		// Token: 0x04030EE0 RID: 200416
		[Token(Token = "0x4030EE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x04030EE1 RID: 200417
		[Token(Token = "0x4030EE1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x04030EE2 RID: 200418
		[Token(Token = "0x4030EE2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent _onResetEquipId;

		// Token: 0x04030EE3 RID: 200419
		[Token(Token = "0x4030EE3")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public int equipScrollSequenceNum;

		// Token: 0x04030EE4 RID: 200420
		[Token(Token = "0x4030EE4")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_cacheTween;

		// Token: 0x04030EE5 RID: 200421
		[Token(Token = "0x4030EE5")]
		private const string ANIM_PARAM = "prof_spread_anim";

		// Token: 0x04030EE6 RID: 200422
		[Token(Token = "0x4030EE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetHeight;

		// Token: 0x04030EE7 RID: 200423
		[Token(Token = "0x4030EE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AllHide;

		// Token: 0x04030EE8 RID: 200424
		[Token(Token = "0x4030EE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyViewModel;

		// Token: 0x04030EE9 RID: 200425
		[Token(Token = "0x4030EE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnHide;

		// Token: 0x04030EEA RID: 200426
		[Token(Token = "0x4030EEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnShow;

		// Token: 0x04030EEB RID: 200427
		[Token(Token = "0x4030EEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TweenBackColor;

		// Token: 0x04030EEC RID: 200428
		[Token(Token = "0x4030EEC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickHide;

		// Token: 0x04030EED RID: 200429
		[Token(Token = "0x4030EED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickShow;

		// Token: 0x04030EEE RID: 200430
		[Token(Token = "0x4030EEE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
