using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200406C RID: 16492
	[Token(Token = "0x200406C")]
	public abstract class SandboxV2AdminPageBase : StateEnginePage, ISandboxV2TopicIdHolder, ISandboxV2DialogHolder
	{
		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x06019822 RID: 104482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CC4")]
		public string topicId
		{
			[Token(Token = "0x6019822")]
			[Address(RVA = "0x1233050", Offset = "0x1231C50", VA = "0x181233050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x06019823 RID: 104483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CC5")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x6019823")]
			[Address(RVA = "0x1232FF0", Offset = "0x1231BF0", VA = "0x181232FF0", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019824 RID: 104484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019824")]
		[Address(RVA = "0x1232840", Offset = "0x1231440", VA = "0x181232840", Slot = "29")]
		public string GetTopicId()
		{
			return null;
		}

		// Token: 0x06019825 RID: 104485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019825")]
		[Address(RVA = "0x12328F0", Offset = "0x12314F0", VA = "0x1812328F0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06019826 RID: 104486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019826")]
		[Address(RVA = "0x1232BC0", Offset = "0x12317C0", VA = "0x181232BC0", Slot = "28")]
		protected override void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x06019827 RID: 104487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019827")]
		[Address(RVA = "0x1232DB0", Offset = "0x12319B0", VA = "0x181232DB0")]
		private void _OnRouteToState(Type to)
		{
		}

		// Token: 0x06019828 RID: 104488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019828")]
		[Address(RVA = "0x1232730", Offset = "0x1231330", VA = "0x181232730")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06019829 RID: 104489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019829")]
		[Address(RVA = "0x1232E80", Offset = "0x1231A80", VA = "0x181232E80")]
		private void _TutorialOnly_RegisterObject()
		{
		}

		// Token: 0x0601982A RID: 104490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601982A")]
		[Address(RVA = "0x1232F90", Offset = "0x1231B90", VA = "0x181232F90")]
		protected SandboxV2AdminPageBase()
		{
		}

		// Token: 0x0601982C RID: 104492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601982C")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601982D RID: 104493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601982D")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x0401FCB7 RID: 130231
		[Token(Token = "0x401FCB7")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _btnBack;

		// Token: 0x0401FCB8 RID: 130232
		[Token(Token = "0x401FCB8")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0401FCB9 RID: 130233
		[Token(Token = "0x401FCB9")]
		[FieldOffset(Offset = "0x100")]
		private StateEngine.OnStateChangeListener m_stateChangeListener;

		// Token: 0x0401FCBA RID: 130234
		[Token(Token = "0x401FCBA")]
		[FieldOffset(Offset = "0x108")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0401FCBB RID: 130235
		[Token(Token = "0x401FCBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0401FCBC RID: 130236
		[Token(Token = "0x401FCBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x0401FCBD RID: 130237
		[Token(Token = "0x401FCBD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTopicId;

		// Token: 0x0401FCBE RID: 130238
		[Token(Token = "0x401FCBE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401FCBF RID: 130239
		[Token(Token = "0x401FCBF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x0401FCC0 RID: 130240
		[Token(Token = "0x401FCC0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnRouteToState;

		// Token: 0x0401FCC1 RID: 130241
		[Token(Token = "0x401FCC1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0401FCC2 RID: 130242
		[Token(Token = "0x401FCC2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterObject;

		// Token: 0x0401FCC3 RID: 130243
		[Token(Token = "0x401FCC3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200406D RID: 16493
		[Token(Token = "0x200406D")]
		public class ParamBase
		{
			// Token: 0x0601982E RID: 104494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601982E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ParamBase()
			{
			}

			// Token: 0x0401FCC4 RID: 130244
			[Token(Token = "0x401FCC4")]
			[FieldOffset(Offset = "0x10")]
			public string topic;

			// Token: 0x0401FCC5 RID: 130245
			[Token(Token = "0x401FCC5")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2AdminMainPanelType initialPanel;

			// Token: 0x0401FCC6 RID: 130246
			[Token(Token = "0x401FCC6")]
			[FieldOffset(Offset = "0x20")]
			public ISandboxV2AdminMainTabPanelInitParam initialPanelParam;
		}
	}
}
