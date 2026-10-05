using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005ED9 RID: 24281
	[Token(Token = "0x2005ED9")]
	public class CharacterInfoSelectSkillState : PopupFloatState
	{
		// Token: 0x060232CA RID: 144074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232CA")]
		[Address(RVA = "0x1DAF410", Offset = "0x1DAE010", VA = "0x181DAF410", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060232CB RID: 144075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232CB")]
		[Address(RVA = "0x1DAF470", Offset = "0x1DAE070", VA = "0x181DAF470", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060232CC RID: 144076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232CC")]
		[Address(RVA = "0x1DAF0A0", Offset = "0x1DADCA0", VA = "0x181DAF0A0")]
		public void EventOnSkillToggleClick(int skillIndex)
		{
		}

		// Token: 0x060232CD RID: 144077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232CD")]
		[Address(RVA = "0x1DAEF70", Offset = "0x1DADB70", VA = "0x181DAEF70")]
		public void EventOnExitSelectSkill()
		{
		}

		// Token: 0x060232CE RID: 144078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232CE")]
		[Address(RVA = "0x1DAF000", Offset = "0x1DADC00", VA = "0x181DAF000")]
		public void EventOnLvlUp()
		{
		}

		// Token: 0x060232CF RID: 144079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232CF")]
		[Address(RVA = "0x1DAF6B0", Offset = "0x1DAE2B0", VA = "0x181DAF6B0")]
		private void _OnJumpFromAllLvlUpState(IStateBean stateBean)
		{
		}

		// Token: 0x060232D0 RID: 144080 RVA: 0x000C00D8 File Offset: 0x000BE2D8
		[Token(Token = "0x60232D0")]
		[Address(RVA = "0x1DAF640", Offset = "0x1DAE240", VA = "0x181DAF640", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x060232D1 RID: 144081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232D1")]
		[Address(RVA = "0x1DAF4E0", Offset = "0x1DAE0E0", VA = "0x181DAF4E0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x060232D2 RID: 144082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232D2")]
		[Address(RVA = "0x1DAF750", Offset = "0x1DAE350", VA = "0x181DAF750")]
		public CharacterInfoSelectSkillState()
		{
		}

		// Token: 0x060232D3 RID: 144083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232D3")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060232D4 RID: 144084 RVA: 0x000C00F0 File Offset: 0x000BE2F0
		[Token(Token = "0x60232D4")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x060232D5 RID: 144085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232D5")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04030793 RID: 198547
		[Token(Token = "0x4030793")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x04030794 RID: 198548
		[Token(Token = "0x4030794")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CharacterInfoSelectSkillBean _stateBean;

		// Token: 0x04030795 RID: 198549
		[Token(Token = "0x4030795")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_tagTipTweener;

		// Token: 0x04030796 RID: 198550
		[Token(Token = "0x4030796")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030797 RID: 198551
		[Token(Token = "0x4030797")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030798 RID: 198552
		[Token(Token = "0x4030798")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnSkillToggleClick;

		// Token: 0x04030799 RID: 198553
		[Token(Token = "0x4030799")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnExitSelectSkill;

		// Token: 0x0403079A RID: 198554
		[Token(Token = "0x403079A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnLvlUp;

		// Token: 0x0403079B RID: 198555
		[Token(Token = "0x403079B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpFromAllLvlUpState;

		// Token: 0x0403079C RID: 198556
		[Token(Token = "0x403079C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0403079D RID: 198557
		[Token(Token = "0x403079D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403079E RID: 198558
		[Token(Token = "0x403079E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
