using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005ECF RID: 24271
	[Token(Token = "0x2005ECF")]
	public class CharacterInfoHolderState : State
	{
		// Token: 0x06023256 RID: 143958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023256")]
		[Address(RVA = "0x1DAA930", Offset = "0x1DA9530", VA = "0x181DAA930", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06023257 RID: 143959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023257")]
		[Address(RVA = "0x1DAAC30", Offset = "0x1DA9830", VA = "0x181DAAC30", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06023258 RID: 143960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023258")]
		[Address(RVA = "0x1DA91C0", Offset = "0x1DA7DC0", VA = "0x181DA91C0")]
		public void OnIllustrationChanged(int illustIndex)
		{
		}

		// Token: 0x06023259 RID: 143961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023259")]
		[Address(RVA = "0x1DAA290", Offset = "0x1DA8E90", VA = "0x181DAA290")]
		public void OnSwitchIllustrationClicked()
		{
		}

		// Token: 0x0602325A RID: 143962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602325A")]
		[Address(RVA = "0x1DA96A0", Offset = "0x1DA82A0", VA = "0x181DA96A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602325B RID: 143963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602325B")]
		[Address(RVA = "0x1DA8FE0", Offset = "0x1DA7BE0", VA = "0x181DA8FE0")]
		public void OnHandBookInfo()
		{
		}

		// Token: 0x0602325C RID: 143964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602325C")]
		[Address(RVA = "0x1DA8150", Offset = "0x1DA6D50", VA = "0x181DA8150")]
		public void OnBtnTokenClick()
		{
		}

		// Token: 0x0602325D RID: 143965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602325D")]
		[Address(RVA = "0x1DA8E50", Offset = "0x1DA7A50", VA = "0x181DA8E50")]
		public void OnEvolveClick()
		{
		}

		// Token: 0x0602325E RID: 143966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602325E")]
		[Address(RVA = "0x1DAA2F0", Offset = "0x1DA8EF0", VA = "0x181DAA2F0")]
		public void OnTransClick()
		{
		}

		// Token: 0x0602325F RID: 143967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602325F")]
		[Address(RVA = "0x1DA9220", Offset = "0x1DA7E20", VA = "0x181DA9220")]
		public void OnPotentialClick()
		{
		}

		// Token: 0x06023260 RID: 143968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023260")]
		[Address(RVA = "0x1DAA5D0", Offset = "0x1DA91D0", VA = "0x181DAA5D0")]
		public void OnUniEquipClick()
		{
		}

		// Token: 0x06023261 RID: 143969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023261")]
		[Address(RVA = "0x1DAA6F0", Offset = "0x1DA92F0", VA = "0x181DAA6F0")]
		public void OnUplevelClicked()
		{
		}

		// Token: 0x06023262 RID: 143970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023262")]
		[Address(RVA = "0x1DA9070", Offset = "0x1DA7C70", VA = "0x181DA9070")]
		public void OnIllustClicked()
		{
		}

		// Token: 0x06023263 RID: 143971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023263")]
		[Address(RVA = "0x1DA9BA0", Offset = "0x1DA87A0", VA = "0x181DA9BA0")]
		public void OnSkillHideClick()
		{
		}

		// Token: 0x06023264 RID: 143972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023264")]
		[Address(RVA = "0x1DA99E0", Offset = "0x1DA85E0", VA = "0x181DA99E0")]
		public void OnSelectSkillClick()
		{
		}

		// Token: 0x06023265 RID: 143973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023265")]
		[Address(RVA = "0x1DA98F0", Offset = "0x1DA84F0", VA = "0x181DA98F0")]
		public void OnSelectSkillAllClick()
		{
		}

		// Token: 0x06023266 RID: 143974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023266")]
		[Address(RVA = "0x1DA9E30", Offset = "0x1DA8A30", VA = "0x181DA9E30")]
		public void OnSpOpTargetClick()
		{
		}

		// Token: 0x06023267 RID: 143975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023267")]
		[Address(RVA = "0x1DA8010", Offset = "0x1DA6C10", VA = "0x181DA8010")]
		public void EventOnTrainingClick()
		{
		}

		// Token: 0x06023268 RID: 143976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023268")]
		[Address(RVA = "0x1DA9D90", Offset = "0x1DA8990", VA = "0x181DA9D90")]
		public void OnSpCharMissionClick()
		{
		}

		// Token: 0x06023269 RID: 143977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023269")]
		[Address(RVA = "0x1DA7E90", Offset = "0x1DA6A90", VA = "0x181DA7E90")]
		public void EventOnBackButtonClick()
		{
		}

		// Token: 0x0602326A RID: 143978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602326A")]
		[Address(RVA = "0x1DA9420", Offset = "0x1DA8020", VA = "0x181DA9420")]
		public void OnProfessionDetailClick()
		{
		}

		// Token: 0x0602326B RID: 143979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602326B")]
		[Address(RVA = "0x1DA9F30", Offset = "0x1DA8B30", VA = "0x181DA9F30")]
		public void OnStarMarkCharacterClick()
		{
		}

		// Token: 0x0602326C RID: 143980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602326C")]
		[Address(RVA = "0x1DA9360", Offset = "0x1DA7F60", VA = "0x181DA9360")]
		public void OnPotentialSwitchClick()
		{
		}

		// Token: 0x0602326D RID: 143981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602326D")]
		[Address(RVA = "0x1DAB450", Offset = "0x1DAA050", VA = "0x181DAB450")]
		private void _OnJumpToEvolveState(IStateBean stateBean)
		{
		}

		// Token: 0x0602326E RID: 143982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602326E")]
		[Address(RVA = "0x1DAB0B0", Offset = "0x1DA9CB0", VA = "0x181DAB0B0")]
		private void _OnJumpFromEvolveState(IStateBean stateBean)
		{
		}

		// Token: 0x0602326F RID: 143983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602326F")]
		[Address(RVA = "0x1DAB570", Offset = "0x1DAA170", VA = "0x181DAB570")]
		private void _OnJumpToHandbookState(IStateBean stateBean)
		{
		}

		// Token: 0x06023270 RID: 143984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023270")]
		[Address(RVA = "0x1DAB800", Offset = "0x1DAA400", VA = "0x181DAB800")]
		private void _OnJumpToToSelectSkillState(IStateBean stateBean)
		{
		}

		// Token: 0x06023271 RID: 143985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023271")]
		[Address(RVA = "0x1DAB190", Offset = "0x1DA9D90", VA = "0x181DAB190")]
		private void _OnJumpFromSelectSkillState(IStateBean stateBean)
		{
		}

		// Token: 0x06023272 RID: 143986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023272")]
		[Address(RVA = "0x1DAB690", Offset = "0x1DAA290", VA = "0x181DAB690")]
		private void _OnJumpToSpCharMissionState(IStateBean stateBean)
		{
		}

		// Token: 0x06023273 RID: 143987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023273")]
		[Address(RVA = "0x1DAB210", Offset = "0x1DA9E10", VA = "0x181DAB210")]
		private void _OnJumpFromSpCharMissionState(IStateBean stateBean)
		{
		}

		// Token: 0x06023274 RID: 143988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023274")]
		[Address(RVA = "0x1DAB040", Offset = "0x1DA9C40", VA = "0x181DAB040")]
		private void _OnExitCharacterInfoHome()
		{
		}

		// Token: 0x06023275 RID: 143989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023275")]
		[Address(RVA = "0x1DABBF0", Offset = "0x1DAA7F0", VA = "0x181DABBF0")]
		private void _TriggerAvg()
		{
		}

		// Token: 0x06023276 RID: 143990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023276")]
		[Address(RVA = "0x1DABD70", Offset = "0x1DAA970", VA = "0x181DABD70")]
		private void _UniqEquipGuideEndCallback(Story story)
		{
		}

		// Token: 0x06023277 RID: 143991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023277")]
		[Address(RVA = "0x1DABCC0", Offset = "0x1DAA8C0", VA = "0x181DABCC0")]
		private void _TriggerStarMarkToast(bool isSelected)
		{
		}

		// Token: 0x06023278 RID: 143992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023278")]
		[Address(RVA = "0x1DA95B0", Offset = "0x1DA81B0", VA = "0x181DA95B0")]
		public void OnResetSkillId()
		{
		}

		// Token: 0x06023279 RID: 143993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023279")]
		[Address(RVA = "0x1DA82D0", Offset = "0x1DA6ED0", VA = "0x181DA82D0")]
		public void OnChangeSkill()
		{
		}

		// Token: 0x0602327A RID: 143994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602327A")]
		[Address(RVA = "0x1DA9AD0", Offset = "0x1DA86D0", VA = "0x181DA9AD0")]
		public void OnSelectSkillId(string skillId)
		{
		}

		// Token: 0x0602327B RID: 143995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602327B")]
		[Address(RVA = "0x1DA94C0", Offset = "0x1DA80C0", VA = "0x181DA94C0")]
		public void OnResetEquipId()
		{
		}

		// Token: 0x0602327C RID: 143996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602327C")]
		[Address(RVA = "0x1DA9820", Offset = "0x1DA8420", VA = "0x181DA9820")]
		public void OnSelectEquipId(string equipId)
		{
		}

		// Token: 0x0602327D RID: 143997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602327D")]
		[Address(RVA = "0x1DA8660", Offset = "0x1DA7260", VA = "0x181DA8660")]
		public void OnChangeUniEquip()
		{
		}

		// Token: 0x0602327E RID: 143998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602327E")]
		[Address(RVA = "0x1DA80F0", Offset = "0x1DA6CF0", VA = "0x181DA80F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602327F RID: 143999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602327F")]
		[Address(RVA = "0x1DA8A50", Offset = "0x1DA7650", VA = "0x181DA8A50")]
		public void OnDetailHide()
		{
		}

		// Token: 0x06023280 RID: 144000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023280")]
		[Address(RVA = "0x1DA8AE0", Offset = "0x1DA76E0", VA = "0x181DA8AE0")]
		public void OnDetailShow()
		{
		}

		// Token: 0x06023281 RID: 144001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023281")]
		[Address(RVA = "0x1DA9110", Offset = "0x1DA7D10", VA = "0x181DA9110")]
		public void OnIllustDataApply(int focusPos)
		{
		}

		// Token: 0x06023282 RID: 144002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023282")]
		[Address(RVA = "0x1DAB950", Offset = "0x1DAA550", VA = "0x181DAB950")]
		private void _OnStateChange(float target, float duration, Action onComplete)
		{
		}

		// Token: 0x06023283 RID: 144003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023283")]
		[Address(RVA = "0x1DA8BF0", Offset = "0x1DA77F0", VA = "0x181DA8BF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023284 RID: 144004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023284")]
		[Address(RVA = "0x1DA8F50", Offset = "0x1DA7B50", VA = "0x181DA8F50", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06023285 RID: 144005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023285")]
		[Address(RVA = "0x1DA89C0", Offset = "0x1DA75C0", VA = "0x181DA89C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06023286 RID: 144006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023286")]
		[Address(RVA = "0x1DABE40", Offset = "0x1DAAA40", VA = "0x181DABE40")]
		public CharacterInfoHolderState()
		{
		}

		// Token: 0x06023289 RID: 144009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023289")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602328A RID: 144010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602328A")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602328B RID: 144011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602328B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602328C RID: 144012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602328C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602328D RID: 144013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602328D")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403071D RID: 198429
		[Token(Token = "0x403071D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CharacterInfoHolderBean _stateBean;

		// Token: 0x0403071E RID: 198430
		[Token(Token = "0x403071E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterInfoIllustHolder _holder;

		// Token: 0x0403071F RID: 198431
		[Token(Token = "0x403071F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterInfoRightHolderView _rightHolderView;

		// Token: 0x04030720 RID: 198432
		[Token(Token = "0x4030720")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x04030721 RID: 198433
		[Token(Token = "0x4030721")]
		private const string ANIM_PARAM = "on_detail_show";

		// Token: 0x04030722 RID: 198434
		[Token(Token = "0x4030722")]
		private const float HIDE_DURATION = 1f;

		// Token: 0x04030723 RID: 198435
		[Token(Token = "0x4030723")]
		private const float SHOW_PRE_HIDE_DURATION = 0.2f;

		// Token: 0x04030724 RID: 198436
		[Token(Token = "0x4030724")]
		private const float SHOW_DURATION = 0.4f;

		// Token: 0x04030725 RID: 198437
		[Token(Token = "0x4030725")]
		[FieldOffset(Offset = "0x70")]
		private RefCountReference m_buildingContextRef;

		// Token: 0x04030726 RID: 198438
		[Token(Token = "0x4030726")]
		[FieldOffset(Offset = "0x78")]
		private float m_animIndex;

		// Token: 0x04030727 RID: 198439
		[Token(Token = "0x4030727")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_cacheTween;

		// Token: 0x04030728 RID: 198440
		[Token(Token = "0x4030728")]
		private const int HIDE_STATE = 1;

		// Token: 0x04030729 RID: 198441
		[Token(Token = "0x4030729")]
		private const int SHOW_STATE = 0;

		// Token: 0x0403072A RID: 198442
		[Token(Token = "0x403072A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403072B RID: 198443
		[Token(Token = "0x403072B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403072C RID: 198444
		[Token(Token = "0x403072C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnIllustrationChanged;

		// Token: 0x0403072D RID: 198445
		[Token(Token = "0x403072D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSwitchIllustrationClicked;

		// Token: 0x0403072E RID: 198446
		[Token(Token = "0x403072E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403072F RID: 198447
		[Token(Token = "0x403072F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnHandBookInfo;

		// Token: 0x04030730 RID: 198448
		[Token(Token = "0x4030730")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnTokenClick;

		// Token: 0x04030731 RID: 198449
		[Token(Token = "0x4030731")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEvolveClick;

		// Token: 0x04030732 RID: 198450
		[Token(Token = "0x4030732")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTransClick;

		// Token: 0x04030733 RID: 198451
		[Token(Token = "0x4030733")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPotentialClick;

		// Token: 0x04030734 RID: 198452
		[Token(Token = "0x4030734")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnUniEquipClick;

		// Token: 0x04030735 RID: 198453
		[Token(Token = "0x4030735")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnUplevelClicked;

		// Token: 0x04030736 RID: 198454
		[Token(Token = "0x4030736")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnIllustClicked;

		// Token: 0x04030737 RID: 198455
		[Token(Token = "0x4030737")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnSkillHideClick;

		// Token: 0x04030738 RID: 198456
		[Token(Token = "0x4030738")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnSelectSkillClick;

		// Token: 0x04030739 RID: 198457
		[Token(Token = "0x4030739")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnSelectSkillAllClick;

		// Token: 0x0403073A RID: 198458
		[Token(Token = "0x403073A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnSpOpTargetClick;

		// Token: 0x0403073B RID: 198459
		[Token(Token = "0x403073B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnTrainingClick;

		// Token: 0x0403073C RID: 198460
		[Token(Token = "0x403073C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnSpCharMissionClick;

		// Token: 0x0403073D RID: 198461
		[Token(Token = "0x403073D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnBackButtonClick;

		// Token: 0x0403073E RID: 198462
		[Token(Token = "0x403073E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnProfessionDetailClick;

		// Token: 0x0403073F RID: 198463
		[Token(Token = "0x403073F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnStarMarkCharacterClick;

		// Token: 0x04030740 RID: 198464
		[Token(Token = "0x4030740")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnPotentialSwitchClick;

		// Token: 0x04030741 RID: 198465
		[Token(Token = "0x4030741")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnJumpToEvolveState;

		// Token: 0x04030742 RID: 198466
		[Token(Token = "0x4030742")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnJumpFromEvolveState;

		// Token: 0x04030743 RID: 198467
		[Token(Token = "0x4030743")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnJumpToHandbookState;

		// Token: 0x04030744 RID: 198468
		[Token(Token = "0x4030744")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnJumpToToSelectSkillState;

		// Token: 0x04030745 RID: 198469
		[Token(Token = "0x4030745")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnJumpFromSelectSkillState;

		// Token: 0x04030746 RID: 198470
		[Token(Token = "0x4030746")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnJumpToSpCharMissionState;

		// Token: 0x04030747 RID: 198471
		[Token(Token = "0x4030747")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnJumpFromSpCharMissionState;

		// Token: 0x04030748 RID: 198472
		[Token(Token = "0x4030748")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnExitCharacterInfoHome;

		// Token: 0x04030749 RID: 198473
		[Token(Token = "0x4030749")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__TriggerAvg;

		// Token: 0x0403074A RID: 198474
		[Token(Token = "0x403074A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__UniqEquipGuideEndCallback;

		// Token: 0x0403074B RID: 198475
		[Token(Token = "0x403074B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__TriggerStarMarkToast;

		// Token: 0x0403074C RID: 198476
		[Token(Token = "0x403074C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnResetSkillId;

		// Token: 0x0403074D RID: 198477
		[Token(Token = "0x403074D")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnChangeSkill;

		// Token: 0x0403074E RID: 198478
		[Token(Token = "0x403074E")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnSelectSkillId;

		// Token: 0x0403074F RID: 198479
		[Token(Token = "0x403074F")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnResetEquipId;

		// Token: 0x04030750 RID: 198480
		[Token(Token = "0x4030750")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnSelectEquipId;

		// Token: 0x04030751 RID: 198481
		[Token(Token = "0x4030751")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnChangeUniEquip;

		// Token: 0x04030752 RID: 198482
		[Token(Token = "0x4030752")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030753 RID: 198483
		[Token(Token = "0x4030753")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OnDetailHide;

		// Token: 0x04030754 RID: 198484
		[Token(Token = "0x4030754")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_OnDetailShow;

		// Token: 0x04030755 RID: 198485
		[Token(Token = "0x4030755")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_OnIllustDataApply;

		// Token: 0x04030756 RID: 198486
		[Token(Token = "0x4030756")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__OnStateChange;

		// Token: 0x04030757 RID: 198487
		[Token(Token = "0x4030757")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030758 RID: 198488
		[Token(Token = "0x4030758")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04030759 RID: 198489
		[Token(Token = "0x4030759")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403075A RID: 198490
		[Token(Token = "0x403075A")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
