using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007947 RID: 31047
	[Token(Token = "0x2007947")]
	public class Act1ArcadeEntryState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0602B8F9 RID: 178425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8F9")]
		[Address(RVA = "0x27748E0", Offset = "0x27734E0", VA = "0x1827748E0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602B8FA RID: 178426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B8FA")]
		[Address(RVA = "0x2774880", Offset = "0x2773480", VA = "0x182774880", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B8FB RID: 178427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B8FB")]
		[Address(RVA = "0x2774D30", Offset = "0x2773930", VA = "0x182774D30", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602B8FC RID: 178428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8FC")]
		[Address(RVA = "0x2774F00", Offset = "0x2773B00", VA = "0x182774F00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B8FD RID: 178429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8FD")]
		[Address(RVA = "0x2774A90", Offset = "0x2773690", VA = "0x182774A90", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602B8FE RID: 178430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8FE")]
		[Address(RVA = "0x2774BA0", Offset = "0x27737A0", VA = "0x182774BA0")]
		public void OnTrigEntryAnim(bool skipAnim)
		{
		}

		// Token: 0x0602B8FF RID: 178431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8FF")]
		[Address(RVA = "0x2775290", Offset = "0x2773E90", VA = "0x182775290")]
		private void _OnClickBack()
		{
		}

		// Token: 0x0602B900 RID: 178432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B900")]
		private void _GotoOtherState<T>() where T : State
		{
		}

		// Token: 0x0602B901 RID: 178433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B901")]
		[Address(RVA = "0x2775720", Offset = "0x2774320", VA = "0x182775720")]
		private void _OnJumpToStageSelectState(IStateBean stateBean)
		{
		}

		// Token: 0x0602B902 RID: 178434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B902")]
		[Address(RVA = "0x27755F0", Offset = "0x27741F0", VA = "0x1827755F0")]
		private void _OnJumpToBadgeBookState(IStateBean bean)
		{
		}

		// Token: 0x0602B903 RID: 178435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B903")]
		[Address(RVA = "0x27753A0", Offset = "0x2773FA0", VA = "0x1827753A0")]
		private void _OnClickMedalEntry()
		{
		}

		// Token: 0x0602B904 RID: 178436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B904")]
		[Address(RVA = "0x2775800", Offset = "0x2774400", VA = "0x182775800")]
		public Act1ArcadeEntryState()
		{
		}

		// Token: 0x0602B905 RID: 178437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B905")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602B906 RID: 178438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B906")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0403F027 RID: 258087
		[Token(Token = "0x403F027")]
		[NonSerialized]
		public const int MSG_ON_GAME_ENTRY_CLICK = 1;

		// Token: 0x0403F028 RID: 258088
		[Token(Token = "0x403F028")]
		[NonSerialized]
		public const int MSG_ON_BADGE_ENTRY_CLICK = 2;

		// Token: 0x0403F029 RID: 258089
		[Token(Token = "0x403F029")]
		[NonSerialized]
		public const int MSG_ON_MILE_STONE_CLICK = 3;

		// Token: 0x0403F02A RID: 258090
		[Token(Token = "0x403F02A")]
		[NonSerialized]
		public const int MSG_ON_MEDAL_ENTRY_CLICK = 4;

		// Token: 0x0403F02B RID: 258091
		[Token(Token = "0x403F02B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1ArcadeEntryView _view;

		// Token: 0x0403F02C RID: 258092
		[Token(Token = "0x403F02C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CustomPageActivityStateEntryComp _entryComp;

		// Token: 0x0403F02D RID: 258093
		[Token(Token = "0x403F02D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403F02E RID: 258094
		[Token(Token = "0x403F02E")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedClickedEntryZoneId;

		// Token: 0x0403F02F RID: 258095
		[Token(Token = "0x403F02F")]
		[FieldOffset(Offset = "0x90")]
		private string m_actId;

		// Token: 0x0403F030 RID: 258096
		[Token(Token = "0x403F030")]
		[FieldOffset(Offset = "0x98")]
		private Act1ArcadeStateBean m_stateBean;

		// Token: 0x0403F031 RID: 258097
		[Token(Token = "0x403F031")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403F032 RID: 258098
		[Token(Token = "0x403F032")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F033 RID: 258099
		[Token(Token = "0x403F033")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403F034 RID: 258100
		[Token(Token = "0x403F034")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F035 RID: 258101
		[Token(Token = "0x403F035")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0403F036 RID: 258102
		[Token(Token = "0x403F036")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTrigEntryAnim;

		// Token: 0x0403F037 RID: 258103
		[Token(Token = "0x403F037")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnClickBack;

		// Token: 0x0403F038 RID: 258104
		[Token(Token = "0x403F038")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GotoOtherState;

		// Token: 0x0403F039 RID: 258105
		[Token(Token = "0x403F039")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnJumpToStageSelectState;

		// Token: 0x0403F03A RID: 258106
		[Token(Token = "0x403F03A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnJumpToBadgeBookState;

		// Token: 0x0403F03B RID: 258107
		[Token(Token = "0x403F03B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnClickMedalEntry;

		// Token: 0x0403F03C RID: 258108
		[Token(Token = "0x403F03C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
