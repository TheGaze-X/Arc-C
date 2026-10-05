using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EED RID: 24301
	[Token(Token = "0x2005EED")]
	public class CharacterLvlupMaxState : UIPopupState
	{
		// Token: 0x06023352 RID: 144210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023352")]
		[Address(RVA = "0x1DB50C0", Offset = "0x1DB3CC0", VA = "0x181DB50C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023353 RID: 144211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023353")]
		[Address(RVA = "0x1DB5350", Offset = "0x1DB3F50", VA = "0x181DB5350", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023354 RID: 144212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023354")]
		[Address(RVA = "0x1DB4F90", Offset = "0x1DB3B90", VA = "0x181DB4F90")]
		public void EventOnStateClick()
		{
		}

		// Token: 0x06023355 RID: 144213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023355")]
		[Address(RVA = "0x1DB57D0", Offset = "0x1DB43D0", VA = "0x181DB57D0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x06023356 RID: 144214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023356")]
		[Address(RVA = "0x1DB54A0", Offset = "0x1DB40A0", VA = "0x181DB54A0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06023357 RID: 144215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023357")]
		[Address(RVA = "0x1DB5120", Offset = "0x1DB3D20", VA = "0x181DB5120", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06023358 RID: 144216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023358")]
		[Address(RVA = "0x1DB55E0", Offset = "0x1DB41E0", VA = "0x181DB55E0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06023359 RID: 144217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023359")]
		[Address(RVA = "0x1DB5260", Offset = "0x1DB3E60", VA = "0x181DB5260", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602335A RID: 144218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602335A")]
		[Address(RVA = "0x1DB5700", Offset = "0x1DB4300", VA = "0x181DB5700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602335B RID: 144219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602335B")]
		[Address(RVA = "0x1DB5930", Offset = "0x1DB4530", VA = "0x181DB5930")]
		public CharacterLvlupMaxState()
		{
		}

		// Token: 0x0602335C RID: 144220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602335C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04030836 RID: 198710
		[Token(Token = "0x4030836")]
		private const string ANIM_MAX_STATE = "lvlup_max_state";

		// Token: 0x04030837 RID: 198711
		[Token(Token = "0x4030837")]
		private const float DURATION_ANIM_CAN_SKIP = 1f;

		// Token: 0x04030838 RID: 198712
		[Token(Token = "0x4030838")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICharacterLevelMaxView _maxView;

		// Token: 0x04030839 RID: 198713
		[Token(Token = "0x4030839")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICharacterLevelMaxBindWrapper _bindWrapper;

		// Token: 0x0403083A RID: 198714
		[Token(Token = "0x403083A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403083B RID: 198715
		[Token(Token = "0x403083B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICommonPageEffectHolder _effectHolder;

		// Token: 0x0403083C RID: 198716
		[Token(Token = "0x403083C")]
		[FieldOffset(Offset = "0x80")]
		private CharacterLvlupMaxStateBean m_stateBean;

		// Token: 0x0403083D RID: 198717
		[Token(Token = "0x403083D")]
		[FieldOffset(Offset = "0x88")]
		private bool m_animPlaying;

		// Token: 0x0403083E RID: 198718
		[Token(Token = "0x403083E")]
		[FieldOffset(Offset = "0x89")]
		private bool m_hasInited;

		// Token: 0x0403083F RID: 198719
		[Token(Token = "0x403083F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030840 RID: 198720
		[Token(Token = "0x4030840")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030841 RID: 198721
		[Token(Token = "0x4030841")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnStateClick;

		// Token: 0x04030842 RID: 198722
		[Token(Token = "0x4030842")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04030843 RID: 198723
		[Token(Token = "0x4030843")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04030844 RID: 198724
		[Token(Token = "0x4030844")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04030845 RID: 198725
		[Token(Token = "0x4030845")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04030846 RID: 198726
		[Token(Token = "0x4030846")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04030847 RID: 198727
		[Token(Token = "0x4030847")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030848 RID: 198728
		[Token(Token = "0x4030848")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
