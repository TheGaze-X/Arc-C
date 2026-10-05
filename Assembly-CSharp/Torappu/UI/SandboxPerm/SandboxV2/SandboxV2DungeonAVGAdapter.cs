using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041CE RID: 16846
	[Token(Token = "0x20041CE")]
	public class SandboxV2DungeonAVGAdapter : ExecutorComponent
	{
		// Token: 0x06019F87 RID: 106375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F87")]
		[Address(RVA = "0x12CC870", Offset = "0x12CB470", VA = "0x1812CC870", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x06019F88 RID: 106376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F88")]
		[Address(RVA = "0x12CC8D0", Offset = "0x12CB4D0", VA = "0x1812CC8D0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06019F89 RID: 106377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F89")]
		[Address(RVA = "0x12CCD80", Offset = "0x12CB980", VA = "0x1812CCD80")]
		private void Start()
		{
		}

		// Token: 0x06019F8A RID: 106378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F8A")]
		[Address(RVA = "0x12CCCA0", Offset = "0x12CB8A0", VA = "0x1812CCCA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06019F8B RID: 106379 RVA: 0x0009FDE0 File Offset: 0x0009DFE0
		[Token(Token = "0x6019F8B")]
		[Address(RVA = "0x12CD8B0", Offset = "0x12CC4B0", VA = "0x1812CD8B0")]
		private bool _ExecuteEnsureDungeonQuest(Command command)
		{
			return default(bool);
		}

		// Token: 0x06019F8C RID: 106380 RVA: 0x0009FDF8 File Offset: 0x0009DFF8
		[Token(Token = "0x6019F8C")]
		[Address(RVA = "0x12CD9B0", Offset = "0x12CC5B0", VA = "0x1812CD9B0")]
		private bool _ExecuteEnsureDungeonStable(Command command)
		{
			return default(bool);
		}

		// Token: 0x06019F8D RID: 106381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F8D")]
		[Address(RVA = "0x12CD270", Offset = "0x12CBE70", VA = "0x1812CD270")]
		private IEnumerator _CoroutineEnsureDungeonStable()
		{
			return null;
		}

		// Token: 0x06019F8E RID: 106382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F8E")]
		[Address(RVA = "0x12CCE30", Offset = "0x12CBA30", VA = "0x1812CCE30")]
		public void TriggerWhenDialogQueueCompleted(string msgId)
		{
		}

		// Token: 0x06019F8F RID: 106383 RVA: 0x0009FE10 File Offset: 0x0009E010
		[Token(Token = "0x6019F8F")]
		[Address(RVA = "0x12CD580", Offset = "0x12CC180", VA = "0x1812CD580")]
		private bool _ExecuteDungeonFocusNode(Command command)
		{
			return default(bool);
		}

		// Token: 0x06019F90 RID: 106384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F90")]
		[Address(RVA = "0x12CD1A0", Offset = "0x12CBDA0", VA = "0x1812CD1A0")]
		private IEnumerator _CoroutineDungeonFocusNode(string focusNodeId)
		{
			return null;
		}

		// Token: 0x06019F91 RID: 106385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F91")]
		[Address(RVA = "0x12CCF50", Offset = "0x12CBB50", VA = "0x1812CCF50")]
		private IEnumerator _CoroutineCameraZoom(SandboxV2DungeonCameraController.ZoomType zoomType, string focusNodeId)
		{
			return null;
		}

		// Token: 0x06019F92 RID: 106386 RVA: 0x0009FE28 File Offset: 0x0009E028
		[Token(Token = "0x6019F92")]
		[Address(RVA = "0x12CD450", Offset = "0x12CC050", VA = "0x1812CD450")]
		private bool _ExecuteDungeonBackToDungeonState(Command command)
		{
			return default(bool);
		}

		// Token: 0x06019F93 RID: 106387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F93")]
		[Address(RVA = "0x12CD0F0", Offset = "0x12CBCF0", VA = "0x1812CD0F0")]
		private IEnumerator _CoroutineDungeonBackToDungeonState()
		{
			return null;
		}

		// Token: 0x06019F94 RID: 106388 RVA: 0x0009FE40 File Offset: 0x0009E040
		[Token(Token = "0x6019F94")]
		[Address(RVA = "0x12CDAE0", Offset = "0x12CC6E0", VA = "0x1812CDAE0")]
		private bool _ExecuteOpenGainItemPage(Command command)
		{
			return default(bool);
		}

		// Token: 0x06019F95 RID: 106389 RVA: 0x0009FE58 File Offset: 0x0009E058
		[Token(Token = "0x6019F95")]
		[Address(RVA = "0x12CD320", Offset = "0x12CBF20", VA = "0x1812CD320")]
		private bool _ExecuteCloseGainItemPage(Command command)
		{
			return default(bool);
		}

		// Token: 0x06019F96 RID: 106390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019F96")]
		[Address(RVA = "0x12CD040", Offset = "0x12CBC40", VA = "0x1812CD040")]
		private IEnumerator _CoroutineCloseGainItemPage()
		{
			return null;
		}

		// Token: 0x06019F97 RID: 106391 RVA: 0x0009FE70 File Offset: 0x0009E070
		[Token(Token = "0x6019F97")]
		[Address(RVA = "0x12CDDB0", Offset = "0x12CC9B0", VA = "0x1812CDDB0")]
		private bool _ExecuteSettleGameAndLeave(Command command)
		{
			return default(bool);
		}

		// Token: 0x06019F98 RID: 106392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F98")]
		[Address(RVA = "0x12CE020", Offset = "0x12CCC20", VA = "0x1812CE020")]
		public SandboxV2DungeonAVGAdapter()
		{
		}

		// Token: 0x04020B75 RID: 134005
		[Token(Token = "0x4020B75")]
		private const float FOCUS_NODE_WAIT_TIME = 1.1f;

		// Token: 0x04020B76 RID: 134006
		[Token(Token = "0x4020B76")]
		private const float NODE_PREVIEW_FADE_OUT_WAIT_TIME = 0.3f;

		// Token: 0x04020B77 RID: 134007
		[Token(Token = "0x4020B77")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2DungeonPage _page;

		// Token: 0x04020B78 RID: 134008
		[Token(Token = "0x4020B78")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2DungeonController _controller;

		// Token: 0x04020B79 RID: 134009
		[Token(Token = "0x4020B79")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x04020B7A RID: 134010
		[Token(Token = "0x4020B7A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SandboxV2FloatPanelManager _floatPanelManager;

		// Token: 0x04020B7B RID: 134011
		[Token(Token = "0x4020B7B")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine m_coroutine;

		// Token: 0x04020B7C RID: 134012
		[Token(Token = "0x4020B7C")]
		[FieldOffset(Offset = "0x78")]
		private int m_guideStartMsgSeq;

		// Token: 0x04020B7D RID: 134013
		[Token(Token = "0x4020B7D")]
		[FieldOffset(Offset = "0x80")]
		private string m_currWaitingGuideStartMsgId;

		// Token: 0x04020B7E RID: 134014
		[Token(Token = "0x4020B7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x04020B7F RID: 134015
		[Token(Token = "0x4020B7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x04020B80 RID: 134016
		[Token(Token = "0x4020B80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04020B81 RID: 134017
		[Token(Token = "0x4020B81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04020B82 RID: 134018
		[Token(Token = "0x4020B82")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteEnsureDungeonQuest;

		// Token: 0x04020B83 RID: 134019
		[Token(Token = "0x4020B83")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteEnsureDungeonStable;

		// Token: 0x04020B84 RID: 134020
		[Token(Token = "0x4020B84")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CoroutineEnsureDungeonStable;

		// Token: 0x04020B85 RID: 134021
		[Token(Token = "0x4020B85")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TriggerWhenDialogQueueCompleted;

		// Token: 0x04020B86 RID: 134022
		[Token(Token = "0x4020B86")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExecuteDungeonFocusNode;

		// Token: 0x04020B87 RID: 134023
		[Token(Token = "0x4020B87")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CoroutineDungeonFocusNode;

		// Token: 0x04020B88 RID: 134024
		[Token(Token = "0x4020B88")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CoroutineCameraZoom;

		// Token: 0x04020B89 RID: 134025
		[Token(Token = "0x4020B89")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExecuteDungeonBackToDungeonState;

		// Token: 0x04020B8A RID: 134026
		[Token(Token = "0x4020B8A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CoroutineDungeonBackToDungeonState;

		// Token: 0x04020B8B RID: 134027
		[Token(Token = "0x4020B8B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ExecuteOpenGainItemPage;

		// Token: 0x04020B8C RID: 134028
		[Token(Token = "0x4020B8C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ExecuteCloseGainItemPage;

		// Token: 0x04020B8D RID: 134029
		[Token(Token = "0x4020B8D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CoroutineCloseGainItemPage;

		// Token: 0x04020B8E RID: 134030
		[Token(Token = "0x4020B8E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ExecuteSettleGameAndLeave;

		// Token: 0x04020B8F RID: 134031
		[Token(Token = "0x4020B8F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041CF RID: 16847
		[Token(Token = "0x20041CF")]
		private enum FocusNodeType
		{
			// Token: 0x04020B91 RID: 134033
			[Token(Token = "0x4020B91")]
			NONE,
			// Token: 0x04020B92 RID: 134034
			[Token(Token = "0x4020B92")]
			FOCUS_BY_NODE_ID,
			// Token: 0x04020B93 RID: 134035
			[Token(Token = "0x4020B93")]
			FOCUS_BY_ENEMY_RUSH,
			// Token: 0x04020B94 RID: 134036
			[Token(Token = "0x4020B94")]
			PURE_CAMERA_ZOOM
		}
	}
}
