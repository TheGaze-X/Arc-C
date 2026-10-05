using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041D5 RID: 16853
	[Token(Token = "0x20041D5")]
	public class SandboxV2DungeonController : PageSingleComponent, IValueMsgReceiver, ITimeWatcher, IAsyncObjectListener
	{
		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x06019FB8 RID: 106424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DEB")]
		public string topicId
		{
			[Token(Token = "0x6019FB8")]
			[Address(RVA = "0x12D5830", Offset = "0x12D4430", VA = "0x1812D5830")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x06019FB9 RID: 106425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DEC")]
		public SandboxV2DungeonProperty dungeonProperty
		{
			[Token(Token = "0x6019FB9")]
			[Address(RVA = "0x12D5710", Offset = "0x12D4310", VA = "0x1812D5710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x06019FBA RID: 106426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DED")]
		public SandboxV2DungeonViewConfig dungeonViewConfig
		{
			[Token(Token = "0x6019FBA")]
			[Address(RVA = "0x12D5770", Offset = "0x12D4370", VA = "0x1812D5770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x06019FBB RID: 106427 RVA: 0x0009FF00 File Offset: 0x0009E100
		[Token(Token = "0x17003DEE")]
		public bool isAsyncLoading
		{
			[Token(Token = "0x6019FBB")]
			[Address(RVA = "0x12D57D0", Offset = "0x12D43D0", VA = "0x1812D57D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06019FBC RID: 106428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FBC")]
		[Address(RVA = "0x12CF5B0", Offset = "0x12CE1B0", VA = "0x1812CF5B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06019FBD RID: 106429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FBD")]
		[Address(RVA = "0x12CF550", Offset = "0x12CE150", VA = "0x1812CF550")]
		private void OnDisable()
		{
		}

		// Token: 0x06019FBE RID: 106430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FBE")]
		[Address(RVA = "0x12D0EE0", Offset = "0x12CFAE0", VA = "0x1812D0EE0", Slot = "13")]
		public void UpdateTime(float delta)
		{
		}

		// Token: 0x06019FBF RID: 106431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FBF")]
		[Address(RVA = "0x12CF4E0", Offset = "0x12CE0E0", VA = "0x1812CF4E0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06019FC0 RID: 106432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FC0")]
		[Address(RVA = "0x12CFC00", Offset = "0x12CE800", VA = "0x1812CFC00")]
		public void StartAsyncTask(int index, AsyncGameObjectLoader.Handler handler)
		{
		}

		// Token: 0x06019FC1 RID: 106433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FC1")]
		[Address(RVA = "0x12CF610", Offset = "0x12CE210", VA = "0x1812CF610", Slot = "14")]
		public void OnGameObjectLoaded(GameObject obj)
		{
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x06019FC2 RID: 106434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DEF")]
		public SandboxV2DungeonCameraRTHolder cameraRTHolder
		{
			[Token(Token = "0x6019FC2")]
			[Address(RVA = "0x12D56B0", Offset = "0x12D42B0", VA = "0x1812D56B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019FC3 RID: 106435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FC3")]
		[Address(RVA = "0x12CF470", Offset = "0x12CE070", VA = "0x1812CF470", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06019FC4 RID: 106436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FC4")]
		[Address(RVA = "0x12D2040", Offset = "0x12D0C40", VA = "0x1812D2040")]
		private void _InitController()
		{
		}

		// Token: 0x06019FC5 RID: 106437 RVA: 0x0009FF18 File Offset: 0x0009E118
		[Token(Token = "0x6019FC5")]
		[Address(RVA = "0x12D1050", Offset = "0x12CFC50", VA = "0x1812D1050")]
		private bool _CheckUIStable()
		{
			return default(bool);
		}

		// Token: 0x06019FC6 RID: 106438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FC6")]
		[Address(RVA = "0x12D1200", Offset = "0x12CFE00", VA = "0x1812D1200")]
		private void _FocusNode(string nodeId, SandboxV2DungeonNodeFocusType focusType, bool fastMode = false)
		{
		}

		// Token: 0x06019FC7 RID: 106439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FC7")]
		[Address(RVA = "0x12D2340", Offset = "0x12D0F40", VA = "0x1812D2340")]
		private void _OnCameraCancelSelectedNodeDetail()
		{
		}

		// Token: 0x06019FC8 RID: 106440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FC8")]
		[Address(RVA = "0x12D0F60", Offset = "0x12CFB60", VA = "0x1812D0F60")]
		private void _CancelSelectedNodeDetail()
		{
		}

		// Token: 0x06019FC9 RID: 106441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FC9")]
		[Address(RVA = "0x12CF680", Offset = "0x12CE280", VA = "0x1812CF680", Slot = "12")]
		public void OnMessage(int msg, ValueBundle data)
		{
		}

		// Token: 0x06019FCA RID: 106442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FCA")]
		[Address(RVA = "0x12D2CC0", Offset = "0x12D18C0", VA = "0x1812D2CC0")]
		private void _OnNodeClicked(string nodeId)
		{
		}

		// Token: 0x06019FCB RID: 106443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FCB")]
		[Address(RVA = "0x12D2750", Offset = "0x12D1350", VA = "0x1812D2750")]
		private void _OnFloatClicked(string nodeId)
		{
		}

		// Token: 0x06019FCC RID: 106444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FCC")]
		[Address(RVA = "0x12D3F60", Offset = "0x12D2B60", VA = "0x1812D3F60")]
		private void _OnNodeSupplyClicked(string nodeId)
		{
		}

		// Token: 0x06019FCD RID: 106445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FCD")]
		[Address(RVA = "0x12D4220", Offset = "0x12D2E20", VA = "0x1812D4220")]
		private void _OnNodeUpgradeClicked(string nodeId)
		{
		}

		// Token: 0x06019FCE RID: 106446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FCE")]
		[Address(RVA = "0x12D37B0", Offset = "0x12D23B0", VA = "0x1812D37B0")]
		private void _OnNodeMapClicked(string nodeId)
		{
		}

		// Token: 0x06019FCF RID: 106447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FCF")]
		[Address(RVA = "0x12D30E0", Offset = "0x12D1CE0", VA = "0x1812D30E0")]
		private void _OnNodeEnemyDetailClicked(string nodeId)
		{
		}

		// Token: 0x06019FD0 RID: 106448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FD0")]
		[Address(RVA = "0x12D2F40", Offset = "0x12D1B40", VA = "0x1812D2F40")]
		private void _OnNodeDropDetailClicked(string nodeId)
		{
		}

		// Token: 0x06019FD1 RID: 106449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FD1")]
		[Address(RVA = "0x12D3950", Offset = "0x12D2550", VA = "0x1812D3950")]
		private void _OnNodeStartBattleClicked(string nodeId)
		{
		}

		// Token: 0x06019FD2 RID: 106450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FD2")]
		[Address(RVA = "0x12D4E70", Offset = "0x12D3A70", VA = "0x1812D4E70")]
		private void _StartSelectionStage()
		{
		}

		// Token: 0x06019FD3 RID: 106451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FD3")]
		[Address(RVA = "0x12D43C0", Offset = "0x12D2FC0", VA = "0x1812D43C0")]
		private void _OnOpenAdminPageClicked(SandboxV2AdminMainPanelType pnlType)
		{
		}

		// Token: 0x06019FD4 RID: 106452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FD4")]
		[Address(RVA = "0x12D47A0", Offset = "0x12D33A0", VA = "0x1812D47A0")]
		private void _OnOpenRiftPage()
		{
		}

		// Token: 0x06019FD5 RID: 106453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FD5")]
		private void _OnTrackerClicked<T>() where T : SandboxV2TrackerState
		{
		}

		// Token: 0x06019FD6 RID: 106454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FD6")]
		[Address(RVA = "0x12D23B0", Offset = "0x12D0FB0", VA = "0x1812D23B0")]
		private void _OnDiscardApClicked()
		{
		}

		// Token: 0x06019FD7 RID: 106455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FD7")]
		[Address(RVA = "0x12D1570", Offset = "0x12D0170", VA = "0x1812D1570")]
		private void _HandleDiscardApService()
		{
		}

		// Token: 0x06019FD8 RID: 106456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019FD8")]
		[Address(RVA = "0x12D5430", Offset = "0x12D4030", VA = "0x1812D5430")]
		private IEnumerator _TryOpenCrossDayPage()
		{
			return null;
		}

		// Token: 0x06019FD9 RID: 106457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019FD9")]
		[Address(RVA = "0x12D54E0", Offset = "0x12D40E0", VA = "0x1812D54E0")]
		private IEnumerator _TryOpenRiftSettle()
		{
			return null;
		}

		// Token: 0x06019FDA RID: 106458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019FDA")]
		[Address(RVA = "0x12D5380", Offset = "0x12D3F80", VA = "0x1812D5380")]
		private IEnumerator _TryOpenChallengeSettle()
		{
			return null;
		}

		// Token: 0x06019FDB RID: 106459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FDB")]
		[Address(RVA = "0x12D2B20", Offset = "0x12D1720", VA = "0x1812D2B20")]
		private void _OnGameflowPanelClicked()
		{
		}

		// Token: 0x06019FDC RID: 106460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FDC")]
		[Address(RVA = "0x12D1310", Offset = "0x12CFF10", VA = "0x1812D1310")]
		private void _HandleChallengeSettleService()
		{
		}

		// Token: 0x06019FDD RID: 106461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FDD")]
		[Address(RVA = "0x12D49C0", Offset = "0x12D35C0", VA = "0x1812D49C0")]
		private void _OnRiftLeaveDirectlyClicked()
		{
		}

		// Token: 0x06019FDE RID: 106462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FDE")]
		[Address(RVA = "0x12D1920", Offset = "0x12D0520", VA = "0x1812D1920")]
		private void _HandleNextDayService()
		{
		}

		// Token: 0x06019FDF RID: 106463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FDF")]
		[Address(RVA = "0x12D1B80", Offset = "0x12D0780", VA = "0x1812D1B80")]
		private void _HandleRiftSettleService()
		{
		}

		// Token: 0x06019FE0 RID: 106464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FE0")]
		[Address(RVA = "0x12D44F0", Offset = "0x12D30F0", VA = "0x1812D44F0")]
		private void _OnOpenProduceDrink()
		{
		}

		// Token: 0x06019FE1 RID: 106465 RVA: 0x0009FF30 File Offset: 0x0009E130
		[Token(Token = "0x6019FE1")]
		[Address(RVA = "0x12D0230", Offset = "0x12CEE30", VA = "0x1812D0230")]
		public bool TutorialOnly_IsDungeonStable()
		{
			return default(bool);
		}

		// Token: 0x06019FE2 RID: 106466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FE2")]
		[Address(RVA = "0x12CFD30", Offset = "0x12CE930", VA = "0x1812CFD30")]
		public void TriggerNodeSelection()
		{
		}

		// Token: 0x06019FE3 RID: 106467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FE3")]
		[Address(RVA = "0x12CF9C0", Offset = "0x12CE5C0", VA = "0x1812CF9C0")]
		public void ReloadDungeon([Optional] SandboxV2DungeonViewModel.LoadDataParam loadParam)
		{
		}

		// Token: 0x06019FE4 RID: 106468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019FE4")]
		[Address(RVA = "0x12D1150", Offset = "0x12CFD50", VA = "0x1812D1150")]
		private IEnumerator _CoroutinePlayEnterAnim()
		{
			return null;
		}

		// Token: 0x06019FE5 RID: 106469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FE5")]
		[Address(RVA = "0x12D52A0", Offset = "0x12D3EA0", VA = "0x1812D52A0")]
		private void _StopEnterAnimCoroutine()
		{
		}

		// Token: 0x06019FE6 RID: 106470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FE6")]
		[Address(RVA = "0x12CF3F0", Offset = "0x12CDFF0", VA = "0x1812CF3F0")]
		public void OnCancelSelectedNodeClicked()
		{
		}

		// Token: 0x06019FE7 RID: 106471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FE7")]
		[Address(RVA = "0x12CE080", Offset = "0x12CCC80", VA = "0x1812CE080")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06019FE8 RID: 106472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FE8")]
		[Address(RVA = "0x12CE460", Offset = "0x12CD060", VA = "0x1812CE460")]
		public void OnBtnCharRepoClicked()
		{
		}

		// Token: 0x06019FE9 RID: 106473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FE9")]
		[Address(RVA = "0x12CE590", Offset = "0x12CD190", VA = "0x1812CE590")]
		public void OnBtnInventoryClicked()
		{
		}

		// Token: 0x06019FEA RID: 106474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FEA")]
		[Address(RVA = "0x12CE4C0", Offset = "0x12CD0C0", VA = "0x1812CE4C0")]
		public void OnBtnCookClicked()
		{
		}

		// Token: 0x06019FEB RID: 106475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FEB")]
		[Address(RVA = "0x12CF390", Offset = "0x12CDF90", VA = "0x1812CF390")]
		public void OnBtnWorkbenchClicked()
		{
		}

		// Token: 0x06019FEC RID: 106476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FEC")]
		[Address(RVA = "0x12CF2E0", Offset = "0x12CDEE0", VA = "0x1812CF2E0")]
		public void OnBtnShopClicked()
		{
		}

		// Token: 0x06019FED RID: 106477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FED")]
		[Address(RVA = "0x12CEE90", Offset = "0x12CDA90", VA = "0x1812CEE90")]
		public void OnBtnScienceClicked()
		{
		}

		// Token: 0x06019FEE RID: 106478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FEE")]
		[Address(RVA = "0x12CE520", Offset = "0x12CD120", VA = "0x1812CE520")]
		public void OnBtnEnemyRushTrackerClicked()
		{
		}

		// Token: 0x06019FEF RID: 106479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FEF")]
		[Address(RVA = "0x12CED50", Offset = "0x12CD950", VA = "0x1812CED50")]
		public void OnBtnOtherTrackerClicked()
		{
		}

		// Token: 0x06019FF0 RID: 106480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF0")]
		[Address(RVA = "0x12CEDC0", Offset = "0x12CD9C0", VA = "0x1812CEDC0")]
		public void OnBtnQuestTrackerClicked()
		{
		}

		// Token: 0x06019FF1 RID: 106481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF1")]
		[Address(RVA = "0x12CE8A0", Offset = "0x12CD4A0", VA = "0x1812CE8A0")]
		public void OnBtnLogisticsClicked()
		{
		}

		// Token: 0x06019FF2 RID: 106482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF2")]
		[Address(RVA = "0x12CE220", Offset = "0x12CCE20", VA = "0x1812CE220")]
		public void OnBtnArchiveClicked()
		{
		}

		// Token: 0x06019FF3 RID: 106483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF3")]
		[Address(RVA = "0x12CEAB0", Offset = "0x12CD6B0", VA = "0x1812CEAB0")]
		public void OnBtnMilestoneClicked()
		{
		}

		// Token: 0x06019FF4 RID: 106484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF4")]
		[Address(RVA = "0x12CEEF0", Offset = "0x12CDAF0", VA = "0x1812CEEF0")]
		public void OnBtnSettleGameClicked()
		{
		}

		// Token: 0x06019FF5 RID: 106485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF5")]
		[Address(RVA = "0x12CE5F0", Offset = "0x12CD1F0", VA = "0x1812CE5F0")]
		public void OnBtnLoadArchiveClicked()
		{
		}

		// Token: 0x06019FF6 RID: 106486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF6")]
		[Address(RVA = "0x12D1DE0", Offset = "0x12D09E0", VA = "0x1812D1DE0")]
		private void _HandleSettleGameService()
		{
		}

		// Token: 0x06019FF7 RID: 106487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF7")]
		[Address(RVA = "0x12D17D0", Offset = "0x12D03D0", VA = "0x1812D17D0")]
		private void _HandleLoadArchiveService()
		{
		}

		// Token: 0x06019FF8 RID: 106488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF8")]
		[Address(RVA = "0x12D0040", Offset = "0x12CEC40", VA = "0x1812D0040")]
		public void TutorialOnly_FocusOnNode(string nodeId)
		{
		}

		// Token: 0x06019FF9 RID: 106489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FF9")]
		[Address(RVA = "0x12CFED0", Offset = "0x12CEAD0", VA = "0x1812CFED0")]
		public void TutorialOnly_CameraZoom(SandboxV2DungeonCameraController.ZoomType zoomType, string nodeId)
		{
		}

		// Token: 0x06019FFA RID: 106490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FFA")]
		[Address(RVA = "0x12D03F0", Offset = "0x12CEFF0", VA = "0x1812D03F0")]
		public void TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x06019FFB RID: 106491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019FFB")]
		[Address(RVA = "0x12D5590", Offset = "0x12D4190", VA = "0x1812D5590")]
		public SandboxV2DungeonController()
		{
		}

		// Token: 0x0601A006 RID: 106502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A006")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0601A007 RID: 106503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A007")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x04020BA7 RID: 134055
		[Token(Token = "0x4020BA7")]
		private const uint PER_FRAME_TOTAL_COST = 200U;

		// Token: 0x04020BA8 RID: 134056
		[Token(Token = "0x4020BA8")]
		[NonSerialized]
		public const int ON_NODE_CLICKED = 0;

		// Token: 0x04020BA9 RID: 134057
		[Token(Token = "0x4020BA9")]
		[NonSerialized]
		public const int ON_NODE_SUPPLY_CLICKED = 1;

		// Token: 0x04020BAA RID: 134058
		[Token(Token = "0x4020BAA")]
		[NonSerialized]
		public const int ON_NODE_UPGRADE_CLICKED = 2;

		// Token: 0x04020BAB RID: 134059
		[Token(Token = "0x4020BAB")]
		[NonSerialized]
		public const int ON_NODE_MAP_CLICKED = 3;

		// Token: 0x04020BAC RID: 134060
		[Token(Token = "0x4020BAC")]
		[NonSerialized]
		public const int ON_NODE_ENEMY_DETAIL_CLICKED = 4;

		// Token: 0x04020BAD RID: 134061
		[Token(Token = "0x4020BAD")]
		[NonSerialized]
		public const int ON_NODE_DROP_DETAIL_CLICKED = 5;

		// Token: 0x04020BAE RID: 134062
		[Token(Token = "0x4020BAE")]
		[NonSerialized]
		public const int ON_NODE_START_BATTLE_CLICKED = 6;

		// Token: 0x04020BAF RID: 134063
		[Token(Token = "0x4020BAF")]
		[NonSerialized]
		public const int ON_FLOAT_CLICKED = 7;

		// Token: 0x04020BB0 RID: 134064
		[Token(Token = "0x4020BB0")]
		[NonSerialized]
		public const int ON_DISCARD_AP_CLICKED = 8;

		// Token: 0x04020BB1 RID: 134065
		[Token(Token = "0x4020BB1")]
		[NonSerialized]
		public const int ON_GAMEFLOW_PANEL_CLICKED = 9;

		// Token: 0x04020BB2 RID: 134066
		[Token(Token = "0x4020BB2")]
		[NonSerialized]
		public const int ON_PRODUCE_DRINK = 10;

		// Token: 0x04020BB3 RID: 134067
		[Token(Token = "0x4020BB3")]
		[NonSerialized]
		public const int ON_RIFT_LEAVE_DIRECTLY_CLICKED = 11;

		// Token: 0x04020BB4 RID: 134068
		[Token(Token = "0x4020BB4")]
		[NonSerialized]
		public const int ON_OPEN_RIFT_RESERVE_CLICKED = 12;

		// Token: 0x04020BB5 RID: 134069
		[Token(Token = "0x4020BB5")]
		[NonSerialized]
		public const int ON_LOAD_ARCHIVE_CLICKED = 13;

		// Token: 0x04020BB6 RID: 134070
		[Token(Token = "0x4020BB6")]
		[NonSerialized]
		public const int ON_DELETE_ARCHIVE_CLICKED = 14;

		// Token: 0x04020BB7 RID: 134071
		[Token(Token = "0x4020BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x04020BB8 RID: 134072
		[Token(Token = "0x4020BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2DungeonCameraController _cameraController;

		// Token: 0x04020BB9 RID: 134073
		[Token(Token = "0x4020BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2DungeonMapView _dungeonMapView;

		// Token: 0x04020BBA RID: 134074
		[Token(Token = "0x4020BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2DungeonView _dungeonView;

		// Token: 0x04020BBB RID: 134075
		[Token(Token = "0x4020BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2StateBindingPanelManager _stateBindingPanelMgr;

		// Token: 0x04020BBC RID: 134076
		[Token(Token = "0x4020BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _tutorialLeftSliderGo;

		// Token: 0x04020BBD RID: 134077
		[Token(Token = "0x4020BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x04020BBE RID: 134078
		[Token(Token = "0x4020BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04020BBF RID: 134079
		[Token(Token = "0x4020BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string m_topicId;

		// Token: 0x04020BC0 RID: 134080
		[Token(Token = "0x4020BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SandboxV2DungeonProperty m_dungeonProperty;

		// Token: 0x04020BC1 RID: 134081
		[Token(Token = "0x4020BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SandboxV2DungeonViewConfig m_dungeonViewConfig;

		// Token: 0x04020BC2 RID: 134082
		[Token(Token = "0x4020BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AsyncGameObjectLoader m_objLoader;

		// Token: 0x04020BC3 RID: 134083
		[Token(Token = "0x4020BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int m_pendingAsyncTaskCount;

		// Token: 0x04020BC4 RID: 134084
		[Token(Token = "0x4020BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Coroutine m_enterCoroutine;

		// Token: 0x04020BC5 RID: 134085
		[Token(Token = "0x4020BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_isPlayingEnterAnim;

		// Token: 0x04020BC6 RID: 134086
		[Token(Token = "0x4020BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonConstructChecker;

		// Token: 0x04020BC7 RID: 134087
		[Token(Token = "0x4020BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SandboxV2DungeonCameraRTHolder m_cameraRTHolder;

		// Token: 0x04020BC8 RID: 134088
		[Token(Token = "0x4020BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020BC9 RID: 134089
		[Token(Token = "0x4020BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dungeonProperty;

		// Token: 0x04020BCA RID: 134090
		[Token(Token = "0x4020BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dungeonViewConfig;

		// Token: 0x04020BCB RID: 134091
		[Token(Token = "0x4020BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isAsyncLoading;

		// Token: 0x04020BCC RID: 134092
		[Token(Token = "0x4020BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04020BCD RID: 134093
		[Token(Token = "0x4020BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04020BCE RID: 134094
		[Token(Token = "0x4020BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x04020BCF RID: 134095
		[Token(Token = "0x4020BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04020BD0 RID: 134096
		[Token(Token = "0x4020BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_StartAsyncTask;

		// Token: 0x04020BD1 RID: 134097
		[Token(Token = "0x4020BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnGameObjectLoaded;

		// Token: 0x04020BD2 RID: 134098
		[Token(Token = "0x4020BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_cameraRTHolder;

		// Token: 0x04020BD3 RID: 134099
		[Token(Token = "0x4020BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04020BD4 RID: 134100
		[Token(Token = "0x4020BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitController;

		// Token: 0x04020BD5 RID: 134101
		[Token(Token = "0x4020BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x04020BD6 RID: 134102
		[Token(Token = "0x4020BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__FocusNode;

		// Token: 0x04020BD7 RID: 134103
		[Token(Token = "0x4020BD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCameraCancelSelectedNodeDetail;

		// Token: 0x04020BD8 RID: 134104
		[Token(Token = "0x4020BD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CancelSelectedNodeDetail;

		// Token: 0x04020BD9 RID: 134105
		[Token(Token = "0x4020BD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020BDA RID: 134106
		[Token(Token = "0x4020BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnNodeClicked;

		// Token: 0x04020BDB RID: 134107
		[Token(Token = "0x4020BDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnFloatClicked;

		// Token: 0x04020BDC RID: 134108
		[Token(Token = "0x4020BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnNodeSupplyClicked;

		// Token: 0x04020BDD RID: 134109
		[Token(Token = "0x4020BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnNodeUpgradeClicked;

		// Token: 0x04020BDE RID: 134110
		[Token(Token = "0x4020BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnNodeMapClicked;

		// Token: 0x04020BDF RID: 134111
		[Token(Token = "0x4020BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnNodeEnemyDetailClicked;

		// Token: 0x04020BE0 RID: 134112
		[Token(Token = "0x4020BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnNodeDropDetailClicked;

		// Token: 0x04020BE1 RID: 134113
		[Token(Token = "0x4020BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnNodeStartBattleClicked;

		// Token: 0x04020BE2 RID: 134114
		[Token(Token = "0x4020BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__StartSelectionStage;

		// Token: 0x04020BE3 RID: 134115
		[Token(Token = "0x4020BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnOpenAdminPageClicked;

		// Token: 0x04020BE4 RID: 134116
		[Token(Token = "0x4020BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnOpenRiftPage;

		// Token: 0x04020BE5 RID: 134117
		[Token(Token = "0x4020BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnTrackerClicked;

		// Token: 0x04020BE6 RID: 134118
		[Token(Token = "0x4020BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnDiscardApClicked;

		// Token: 0x04020BE7 RID: 134119
		[Token(Token = "0x4020BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__HandleDiscardApService;

		// Token: 0x04020BE8 RID: 134120
		[Token(Token = "0x4020BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__TryOpenCrossDayPage;

		// Token: 0x04020BE9 RID: 134121
		[Token(Token = "0x4020BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__TryOpenRiftSettle;

		// Token: 0x04020BEA RID: 134122
		[Token(Token = "0x4020BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__TryOpenChallengeSettle;

		// Token: 0x04020BEB RID: 134123
		[Token(Token = "0x4020BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnGameflowPanelClicked;

		// Token: 0x04020BEC RID: 134124
		[Token(Token = "0x4020BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__HandleChallengeSettleService;

		// Token: 0x04020BED RID: 134125
		[Token(Token = "0x4020BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnRiftLeaveDirectlyClicked;

		// Token: 0x04020BEE RID: 134126
		[Token(Token = "0x4020BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__HandleNextDayService;

		// Token: 0x04020BEF RID: 134127
		[Token(Token = "0x4020BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__HandleRiftSettleService;

		// Token: 0x04020BF0 RID: 134128
		[Token(Token = "0x4020BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnOpenProduceDrink;

		// Token: 0x04020BF1 RID: 134129
		[Token(Token = "0x4020BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_TutorialOnly_IsDungeonStable;

		// Token: 0x04020BF2 RID: 134130
		[Token(Token = "0x4020BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_TriggerNodeSelection;

		// Token: 0x04020BF3 RID: 134131
		[Token(Token = "0x4020BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_ReloadDungeon;

		// Token: 0x04020BF4 RID: 134132
		[Token(Token = "0x4020BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__CoroutinePlayEnterAnim;

		// Token: 0x04020BF5 RID: 134133
		[Token(Token = "0x4020BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__StopEnterAnimCoroutine;

		// Token: 0x04020BF6 RID: 134134
		[Token(Token = "0x4020BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OnCancelSelectedNodeClicked;

		// Token: 0x04020BF7 RID: 134135
		[Token(Token = "0x4020BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04020BF8 RID: 134136
		[Token(Token = "0x4020BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_OnBtnCharRepoClicked;

		// Token: 0x04020BF9 RID: 134137
		[Token(Token = "0x4020BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_OnBtnInventoryClicked;

		// Token: 0x04020BFA RID: 134138
		[Token(Token = "0x4020BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnBtnCookClicked;

		// Token: 0x04020BFB RID: 134139
		[Token(Token = "0x4020BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_OnBtnWorkbenchClicked;

		// Token: 0x04020BFC RID: 134140
		[Token(Token = "0x4020BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_OnBtnShopClicked;

		// Token: 0x04020BFD RID: 134141
		[Token(Token = "0x4020BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_OnBtnScienceClicked;

		// Token: 0x04020BFE RID: 134142
		[Token(Token = "0x4020BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_OnBtnEnemyRushTrackerClicked;

		// Token: 0x04020BFF RID: 134143
		[Token(Token = "0x4020BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_OnBtnOtherTrackerClicked;

		// Token: 0x04020C00 RID: 134144
		[Token(Token = "0x4020C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_OnBtnQuestTrackerClicked;

		// Token: 0x04020C01 RID: 134145
		[Token(Token = "0x4020C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_OnBtnLogisticsClicked;

		// Token: 0x04020C02 RID: 134146
		[Token(Token = "0x4020C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_OnBtnArchiveClicked;

		// Token: 0x04020C03 RID: 134147
		[Token(Token = "0x4020C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_OnBtnMilestoneClicked;

		// Token: 0x04020C04 RID: 134148
		[Token(Token = "0x4020C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_OnBtnSettleGameClicked;

		// Token: 0x04020C05 RID: 134149
		[Token(Token = "0x4020C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_OnBtnLoadArchiveClicked;

		// Token: 0x04020C06 RID: 134150
		[Token(Token = "0x4020C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__HandleSettleGameService;

		// Token: 0x04020C07 RID: 134151
		[Token(Token = "0x4020C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__HandleLoadArchiveService;

		// Token: 0x04020C08 RID: 134152
		[Token(Token = "0x4020C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_TutorialOnly_FocusOnNode;

		// Token: 0x04020C09 RID: 134153
		[Token(Token = "0x4020C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_TutorialOnly_CameraZoom;

		// Token: 0x04020C0A RID: 134154
		[Token(Token = "0x4020C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x04020C0B RID: 134155
		[Token(Token = "0x4020C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
