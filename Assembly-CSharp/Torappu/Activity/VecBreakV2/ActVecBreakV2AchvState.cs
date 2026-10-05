using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DCE RID: 28110
	[Token(Token = "0x2006DCE")]
	public class ActVecBreakV2AchvState : State, IValueMsgReceiver
	{
		// Token: 0x06028067 RID: 163943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028067")]
		[Address(RVA = "0x2349F50", Offset = "0x2348B50", VA = "0x182349F50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028068 RID: 163944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028068")]
		[Address(RVA = "0x234A400", Offset = "0x2349000", VA = "0x18234A400", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028069 RID: 163945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028069")]
		[Address(RVA = "0x234A570", Offset = "0x2349170", VA = "0x18234A570", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602806A RID: 163946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602806A")]
		[Address(RVA = "0x234AF00", Offset = "0x2349B00", VA = "0x18234AF00")]
		private void _OnJumpToMedalDisplayState(IStateBean stateBean)
		{
		}

		// Token: 0x0602806B RID: 163947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602806B")]
		[Address(RVA = "0x2349FB0", Offset = "0x2348BB0", VA = "0x182349FB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602806C RID: 163948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602806C")]
		[Address(RVA = "0x234AA20", Offset = "0x2349620", VA = "0x18234AA20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602806D RID: 163949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602806D")]
		[Address(RVA = "0x234A6D0", Offset = "0x23492D0", VA = "0x18234A6D0")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x0602806E RID: 163950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602806E")]
		[Address(RVA = "0x234A7E0", Offset = "0x23493E0", VA = "0x18234A7E0")]
		private void _EventOnNavToPrev()
		{
		}

		// Token: 0x0602806F RID: 163951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602806F")]
		[Address(RVA = "0x234A780", Offset = "0x2349380", VA = "0x18234A780")]
		private void _EventOnNavToNext()
		{
		}

		// Token: 0x06028070 RID: 163952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028070")]
		[Address(RVA = "0x234A840", Offset = "0x2349440", VA = "0x18234A840")]
		private void _EventOnViewMedalGroup()
		{
		}

		// Token: 0x06028071 RID: 163953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028071")]
		[Address(RVA = "0x234ABD0", Offset = "0x23497D0", VA = "0x18234ABD0")]
		private void _NavToSeason(bool navToNext)
		{
		}

		// Token: 0x06028072 RID: 163954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028072")]
		[Address(RVA = "0x234B080", Offset = "0x2349C80", VA = "0x18234B080")]
		public ActVecBreakV2AchvState()
		{
		}

		// Token: 0x06028073 RID: 163955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028073")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028074 RID: 163956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028074")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04038C02 RID: 232450
		[Token(Token = "0x4038C02")]
		[NonSerialized]
		public const int MSG_NAV_TO_PREV = 1;

		// Token: 0x04038C03 RID: 232451
		[Token(Token = "0x4038C03")]
		[NonSerialized]
		public const int MSG_NAV_TO_NEXT = 2;

		// Token: 0x04038C04 RID: 232452
		[Token(Token = "0x4038C04")]
		[NonSerialized]
		public const int MSG_VIEW_MEDAL_GROUP = 3;

		// Token: 0x04038C05 RID: 232453
		[Token(Token = "0x4038C05")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActVecBreakV2AchvView _view;

		// Token: 0x04038C06 RID: 232454
		[Token(Token = "0x4038C06")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04038C07 RID: 232455
		[Token(Token = "0x4038C07")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animPrevFadeOut;

		// Token: 0x04038C08 RID: 232456
		[Token(Token = "0x4038C08")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animPrevFadeIn;

		// Token: 0x04038C09 RID: 232457
		[Token(Token = "0x4038C09")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animNextFadeOut;

		// Token: 0x04038C0A RID: 232458
		[Token(Token = "0x4038C0A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animNextFadeIn;

		// Token: 0x04038C0B RID: 232459
		[Token(Token = "0x4038C0B")]
		[FieldOffset(Offset = "0xA0")]
		private ActVecBreakV2AchvStateBean m_stateBean;

		// Token: 0x04038C0C RID: 232460
		[Token(Token = "0x4038C0C")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_navTween;

		// Token: 0x04038C0D RID: 232461
		[Token(Token = "0x4038C0D")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x04038C0E RID: 232462
		[Token(Token = "0x4038C0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038C0F RID: 232463
		[Token(Token = "0x4038C0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04038C10 RID: 232464
		[Token(Token = "0x4038C10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04038C11 RID: 232465
		[Token(Token = "0x4038C11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToMedalDisplayState;

		// Token: 0x04038C12 RID: 232466
		[Token(Token = "0x4038C12")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038C13 RID: 232467
		[Token(Token = "0x4038C13")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038C14 RID: 232468
		[Token(Token = "0x4038C14")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04038C15 RID: 232469
		[Token(Token = "0x4038C15")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnNavToPrev;

		// Token: 0x04038C16 RID: 232470
		[Token(Token = "0x4038C16")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnNavToNext;

		// Token: 0x04038C17 RID: 232471
		[Token(Token = "0x4038C17")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnViewMedalGroup;

		// Token: 0x04038C18 RID: 232472
		[Token(Token = "0x4038C18")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__NavToSeason;

		// Token: 0x04038C19 RID: 232473
		[Token(Token = "0x4038C19")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
