using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062E7 RID: 25319
	[Token(Token = "0x20062E7")]
	public class AutoChessRoomSelectState : AutoChessPrepareBaseState, ICompDialogCallBack
	{
		// Token: 0x060247DE RID: 149470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247DE")]
		[Address(RVA = "0x1F525C0", Offset = "0x1F511C0", VA = "0x181F525C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060247DF RID: 149471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247DF")]
		[Address(RVA = "0x1F528F0", Offset = "0x1F514F0", VA = "0x181F528F0")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x060247E0 RID: 149472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247E0")]
		[Address(RVA = "0x1F52A20", Offset = "0x1F51620", VA = "0x181F52A20")]
		private void _TopMenuAchieveInst(GameObject inst)
		{
		}

		// Token: 0x060247E1 RID: 149473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247E1")]
		[Address(RVA = "0x1F51DA0", Offset = "0x1F509A0", VA = "0x181F51DA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060247E2 RID: 149474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247E2")]
		[Address(RVA = "0x1F51FB0", Offset = "0x1F50BB0", VA = "0x181F51FB0", Slot = "31")]
		protected override void OnStateEnter()
		{
		}

		// Token: 0x060247E3 RID: 149475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247E3")]
		[Address(RVA = "0x1F52090", Offset = "0x1F50C90", VA = "0x181F52090", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060247E4 RID: 149476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247E4")]
		[Address(RVA = "0x1F521E0", Offset = "0x1F50DE0", VA = "0x181F521E0")]
		private Tween _GenEntryTween()
		{
			return null;
		}

		// Token: 0x060247E5 RID: 149477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247E5")]
		[Address(RVA = "0x1F514F0", Offset = "0x1F500F0", VA = "0x181F514F0")]
		public void EventOnCreateTeam()
		{
		}

		// Token: 0x060247E6 RID: 149478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247E6")]
		[Address(RVA = "0x1F51870", Offset = "0x1F50470", VA = "0x181F51870")]
		public void EventOnJoinTeam()
		{
		}

		// Token: 0x060247E7 RID: 149479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247E7")]
		[Address(RVA = "0x1F51AA0", Offset = "0x1F506A0", VA = "0x181F51AA0")]
		public void EventOnRoomIdEndEdit(string input)
		{
		}

		// Token: 0x060247E8 RID: 149480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247E8")]
		[Address(RVA = "0x1F51B30", Offset = "0x1F50730", VA = "0x181F51B30")]
		public void EventOnTrainingMode()
		{
		}

		// Token: 0x060247E9 RID: 149481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247E9")]
		[Address(RVA = "0x1F516D0", Offset = "0x1F502D0", VA = "0x181F516D0")]
		public void EventOnInvitationBtnClick()
		{
		}

		// Token: 0x060247EA RID: 149482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247EA")]
		[Address(RVA = "0x1F51E00", Offset = "0x1F50A00", VA = "0x181F51E00", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x060247EB RID: 149483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247EB")]
		[Address(RVA = "0x1F524C0", Offset = "0x1F510C0", VA = "0x181F524C0")]
		private void _HandleTrainingModeDialogCallback(ValueBundle outputBundle)
		{
		}

		// Token: 0x060247EC RID: 149484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247EC")]
		[Address(RVA = "0x1F522E0", Offset = "0x1F50EE0", VA = "0x181F522E0")]
		private void _HandleInviteDialogCallback(ValueBundle outputBundle)
		{
		}

		// Token: 0x060247ED RID: 149485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247ED")]
		[Address(RVA = "0x1F52B50", Offset = "0x1F51750", VA = "0x181F52B50")]
		public AutoChessRoomSelectState()
		{
		}

		// Token: 0x060247EE RID: 149486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247EE")]
		[Address(RVA = "0x1F25FB0", Offset = "0x1F24BB0", VA = "0x181F25FB0")]
		private void <>xLuaBaseProxy_OnStateEnter()
		{
		}

		// Token: 0x060247EF RID: 149487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247EF")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x04032D8C RID: 208268
		[Token(Token = "0x4032D8C")]
		[FieldOffset(Offset = "0x80")]
		private float SHOW_BLOCK_DURATION;

		// Token: 0x04032D8D RID: 208269
		[Token(Token = "0x4032D8D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _leftEntryAnim;

		// Token: 0x04032D8E RID: 208270
		[Token(Token = "0x4032D8E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _rightEntryAnim;

		// Token: 0x04032D8F RID: 208271
		[Token(Token = "0x4032D8F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x04032D90 RID: 208272
		[Token(Token = "0x4032D90")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04032D91 RID: 208273
		[Token(Token = "0x4032D91")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private InputField _teamCodeInput;

		// Token: 0x04032D92 RID: 208274
		[Token(Token = "0x4032D92")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _trainingModeNameText;

		// Token: 0x04032D93 RID: 208275
		[Token(Token = "0x4032D93")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UICommonTrackPoint _trackPointInvite;

		// Token: 0x04032D94 RID: 208276
		[Token(Token = "0x4032D94")]
		[FieldOffset(Offset = "0xD8")]
		private string m_actId;

		// Token: 0x04032D95 RID: 208277
		[Token(Token = "0x4032D95")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isInited;

		// Token: 0x04032D96 RID: 208278
		[Token(Token = "0x4032D96")]
		[FieldOffset(Offset = "0xE4")]
		private int m_trainingConfirmInst;

		// Token: 0x04032D97 RID: 208279
		[Token(Token = "0x4032D97")]
		[FieldOffset(Offset = "0xE8")]
		private int m_inviteDlgInstId;

		// Token: 0x04032D98 RID: 208280
		[Token(Token = "0x4032D98")]
		[FieldOffset(Offset = "0xF0")]
		private Dictionary<string, long> m_invitedCache;

		// Token: 0x04032D99 RID: 208281
		[Token(Token = "0x4032D99")]
		[FieldOffset(Offset = "0xF8")]
		private Tween m_entryAnimTween;

		// Token: 0x04032D9A RID: 208282
		[Token(Token = "0x4032D9A")]
		[FieldOffset(Offset = "0x100")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032D9B RID: 208283
		[Token(Token = "0x4032D9B")]
		[FieldOffset(Offset = "0x110")]
		private TrackPointViewProperty m_trackPointInvite;

		// Token: 0x04032D9C RID: 208284
		[Token(Token = "0x4032D9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032D9D RID: 208285
		[Token(Token = "0x4032D9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x04032D9E RID: 208286
		[Token(Token = "0x4032D9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TopMenuAchieveInst;

		// Token: 0x04032D9F RID: 208287
		[Token(Token = "0x4032D9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04032DA0 RID: 208288
		[Token(Token = "0x4032DA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStateEnter;

		// Token: 0x04032DA1 RID: 208289
		[Token(Token = "0x4032DA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04032DA2 RID: 208290
		[Token(Token = "0x4032DA2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenEntryTween;

		// Token: 0x04032DA3 RID: 208291
		[Token(Token = "0x4032DA3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnCreateTeam;

		// Token: 0x04032DA4 RID: 208292
		[Token(Token = "0x4032DA4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnJoinTeam;

		// Token: 0x04032DA5 RID: 208293
		[Token(Token = "0x4032DA5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnRoomIdEndEdit;

		// Token: 0x04032DA6 RID: 208294
		[Token(Token = "0x4032DA6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnTrainingMode;

		// Token: 0x04032DA7 RID: 208295
		[Token(Token = "0x4032DA7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnInvitationBtnClick;

		// Token: 0x04032DA8 RID: 208296
		[Token(Token = "0x4032DA8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04032DA9 RID: 208297
		[Token(Token = "0x4032DA9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HandleTrainingModeDialogCallback;

		// Token: 0x04032DAA RID: 208298
		[Token(Token = "0x4032DAA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandleInviteDialogCallback;

		// Token: 0x04032DAB RID: 208299
		[Token(Token = "0x4032DAB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062E8 RID: 25320
		[Token(Token = "0x20062E8")]
		private class InvitedTrackModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x060247F0 RID: 149488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60247F0")]
			[Address(RVA = "0x1F65AB0", Offset = "0x1F646B0", VA = "0x181F65AB0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x170055EC RID: 21996
			// (get) Token: 0x060247F1 RID: 149489 RVA: 0x000C4668 File Offset: 0x000C2868
			// (set) Token: 0x060247F2 RID: 149490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170055EC")]
			public bool isShow
			{
				[Token(Token = "0x60247F1")]
				[Address(RVA = "0x1F65C50", Offset = "0x1F64850", VA = "0x181F65C50", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60247F2")]
				[Address(RVA = "0x1F65CB0", Offset = "0x1F648B0", VA = "0x181F65CB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060247F3 RID: 149491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60247F3")]
			[Address(RVA = "0x1F65BF0", Offset = "0x1F647F0", VA = "0x181F65BF0")]
			public InvitedTrackModel()
			{
			}

			// Token: 0x04032DAD RID: 208301
			[Token(Token = "0x4032DAD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04032DAE RID: 208302
			[Token(Token = "0x4032DAE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04032DAF RID: 208303
			[Token(Token = "0x4032DAF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x04032DB0 RID: 208304
			[Token(Token = "0x4032DB0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
