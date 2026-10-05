using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm
{
	// Token: 0x0200400C RID: 16396
	[Token(Token = "0x200400C")]
	public class SandboxPermHomeState : State, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x17003C8C RID: 15500
		// (get) Token: 0x0601963E RID: 103998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C8C")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601963E")]
			[Address(RVA = "0x1219150", Offset = "0x1217D50", VA = "0x181219150")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601963F RID: 103999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601963F")]
		[Address(RVA = "0x1217CF0", Offset = "0x12168F0", VA = "0x181217CF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019640 RID: 104000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019640")]
		[Address(RVA = "0x12182D0", Offset = "0x1216ED0", VA = "0x1812182D0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06019641 RID: 104001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019641")]
		[Address(RVA = "0x12180B0", Offset = "0x1216CB0", VA = "0x1812180B0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019642 RID: 104002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019642")]
		[Address(RVA = "0x12185D0", Offset = "0x12171D0", VA = "0x1812185D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019643 RID: 104003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019643")]
		[Address(RVA = "0x12184A0", Offset = "0x12170A0", VA = "0x1812184A0")]
		public Coroutine PageOnlyStartShowEffects(bool fastMode, bool backFromBattle)
		{
			return null;
		}

		// Token: 0x06019644 RID: 104004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019644")]
		[Address(RVA = "0x12183C0", Offset = "0x1216FC0", VA = "0x1812183C0")]
		public void PageOnlyDisposeEffects()
		{
		}

		// Token: 0x06019645 RID: 104005 RVA: 0x0009DE60 File Offset: 0x0009C060
		[Token(Token = "0x6019645")]
		[Address(RVA = "0x1217C10", Offset = "0x1216810", VA = "0x181217C10")]
		public bool CheckIfUseFastEnter()
		{
			return default(bool);
		}

		// Token: 0x06019646 RID: 104006 RVA: 0x0009DE78 File Offset: 0x0009C078
		[Token(Token = "0x6019646")]
		[Address(RVA = "0x1217D50", Offset = "0x1216950", VA = "0x181217D50")]
		public SandboxPermHomePage.DisplayTweenConfig GetDisplayTweenConfig(bool fastMode)
		{
			return default(SandboxPermHomePage.DisplayTweenConfig);
		}

		// Token: 0x06019647 RID: 104007 RVA: 0x0009DE90 File Offset: 0x0009C090
		[Token(Token = "0x6019647")]
		[Address(RVA = "0x1217FD0", Offset = "0x1216BD0", VA = "0x181217FD0")]
		public bool OnBackClick()
		{
			return default(bool);
		}

		// Token: 0x06019648 RID: 104008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019648")]
		[Address(RVA = "0x1217E90", Offset = "0x1216A90", VA = "0x181217E90", Slot = "24")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06019649 RID: 104009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019649")]
		[Address(RVA = "0x1218BE0", Offset = "0x12177E0", VA = "0x181218BE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601964A RID: 104010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601964A")]
		[Address(RVA = "0x12187A0", Offset = "0x12173A0", VA = "0x1812187A0")]
		private void _BindEffectsAndCanvasInController()
		{
		}

		// Token: 0x0601964B RID: 104011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601964B")]
		[Address(RVA = "0x1218AD0", Offset = "0x12176D0", VA = "0x181218AD0")]
		private void _EventOpenMedalGroup()
		{
		}

		// Token: 0x0601964C RID: 104012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601964C")]
		[Address(RVA = "0x1218A40", Offset = "0x1217640", VA = "0x181218A40")]
		private void _EventOnOpenAnnounce()
		{
		}

		// Token: 0x0601964D RID: 104013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601964D")]
		[Address(RVA = "0x1218E60", Offset = "0x1217A60", VA = "0x181218E60")]
		private void _JumpToMedalGroupState(IStateBean stateBean)
		{
		}

		// Token: 0x0601964E RID: 104014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601964E")]
		[Address(RVA = "0x1218FA0", Offset = "0x1217BA0", VA = "0x181218FA0")]
		public void _ToDiffModeState(IStateBean stateBean)
		{
		}

		// Token: 0x0601964F RID: 104015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601964F")]
		[Address(RVA = "0x12190F0", Offset = "0x1217CF0", VA = "0x1812190F0")]
		public SandboxPermHomeState()
		{
		}

		// Token: 0x06019650 RID: 104016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019650")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06019651 RID: 104017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019651")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401F962 RID: 129378
		[Token(Token = "0x401F962")]
		[NonSerialized]
		public const int MSG_OPEN_MEDAL_GROUP = 1;

		// Token: 0x0401F963 RID: 129379
		[Token(Token = "0x401F963")]
		[NonSerialized]
		public const int MSG_OPEN_ANNOUNCE = 2;

		// Token: 0x0401F964 RID: 129380
		[Token(Token = "0x401F964")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _homeViewContainer;

		// Token: 0x0401F965 RID: 129381
		[Token(Token = "0x401F965")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0401F966 RID: 129382
		[Token(Token = "0x401F966")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401F967 RID: 129383
		[Token(Token = "0x401F967")]
		[FieldOffset(Offset = "0x68")]
		private SandboxPermHomeControllerBase m_homeController;

		// Token: 0x0401F968 RID: 129384
		[Token(Token = "0x401F968")]
		[FieldOffset(Offset = "0x70")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0401F969 RID: 129385
		[Token(Token = "0x401F969")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x0401F96A RID: 129386
		[Token(Token = "0x401F96A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F96B RID: 129387
		[Token(Token = "0x401F96B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401F96C RID: 129388
		[Token(Token = "0x401F96C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401F96D RID: 129389
		[Token(Token = "0x401F96D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401F96E RID: 129390
		[Token(Token = "0x401F96E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PageOnlyStartShowEffects;

		// Token: 0x0401F96F RID: 129391
		[Token(Token = "0x401F96F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PageOnlyDisposeEffects;

		// Token: 0x0401F970 RID: 129392
		[Token(Token = "0x401F970")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfUseFastEnter;

		// Token: 0x0401F971 RID: 129393
		[Token(Token = "0x401F971")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetDisplayTweenConfig;

		// Token: 0x0401F972 RID: 129394
		[Token(Token = "0x401F972")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0401F973 RID: 129395
		[Token(Token = "0x401F973")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0401F974 RID: 129396
		[Token(Token = "0x401F974")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F975 RID: 129397
		[Token(Token = "0x401F975")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__BindEffectsAndCanvasInController;

		// Token: 0x0401F976 RID: 129398
		[Token(Token = "0x401F976")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOpenMedalGroup;

		// Token: 0x0401F977 RID: 129399
		[Token(Token = "0x401F977")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnOpenAnnounce;

		// Token: 0x0401F978 RID: 129400
		[Token(Token = "0x401F978")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__JumpToMedalGroupState;

		// Token: 0x0401F979 RID: 129401
		[Token(Token = "0x401F979")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ToDiffModeState;

		// Token: 0x0401F97A RID: 129402
		[Token(Token = "0x401F97A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
