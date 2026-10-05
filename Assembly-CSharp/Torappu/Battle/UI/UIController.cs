using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.Battle.Dialog;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200332B RID: 13099
	[Token(Token = "0x200332B")]
	public class UIController : SingletonMonoBehaviour<UIController>, IBattleModule, ISingletonNotAutoCreate, IHotfixable
	{
		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x06014D83 RID: 85379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003168")]
		public UIStateMachine stateMachine
		{
			[Token(Token = "0x6014D83")]
			[Address(RVA = "0xD47210", Offset = "0xD45E10", VA = "0x180D47210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x06014D84 RID: 85380 RVA: 0x00088DB8 File Offset: 0x00086FB8
		[Token(Token = "0x17003169")]
		public UIStateEnum currentState
		{
			[Token(Token = "0x6014D84")]
			[Address(RVA = "0xD462F0", Offset = "0xD44EF0", VA = "0x180D462F0")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x06014D85 RID: 85381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700316A")]
		public EventPool<UIController.Event> eventPool
		{
			[Token(Token = "0x6014D85")]
			[Address(RVA = "0xD46660", Offset = "0xD45260", VA = "0x180D46660")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x06014D86 RID: 85382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700316B")]
		public UITopBar topbar
		{
			[Token(Token = "0x6014D86")]
			[Address(RVA = "0xD47400", Offset = "0xD46000", VA = "0x180D47400")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x06014D87 RID: 85383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700316C")]
		public Image bottomMask
		{
			[Token(Token = "0x6014D87")]
			[Address(RVA = "0xD46000", Offset = "0xD44C00", VA = "0x180D46000")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x06014D88 RID: 85384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700316D")]
		public UICharacterMenuState characterMenuState
		{
			[Token(Token = "0x6014D88")]
			[Address(RVA = "0xD461F0", Offset = "0xD44DF0", VA = "0x180D461F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x06014D89 RID: 85385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700316E")]
		public UIFakeBlur fakeBlur
		{
			[Token(Token = "0x6014D89")]
			[Address(RVA = "0xD466E0", Offset = "0xD452E0", VA = "0x180D466E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x06014D8A RID: 85386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700316F")]
		public UIDirectionSelector directionSelector
		{
			[Token(Token = "0x6014D8A")]
			[Address(RVA = "0xD46380", Offset = "0xD44F80", VA = "0x180D46380")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x06014D8B RID: 85387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003170")]
		public UIAnimationPerform battleAccomplishedPerform
		{
			[Token(Token = "0x6014D8B")]
			[Address(RVA = "0xD45F80", Offset = "0xD44B80", VA = "0x180D45F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x06014D8C RID: 85388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003171")]
		public Transform hudPanel
		{
			[Token(Token = "0x6014D8C")]
			[Address(RVA = "0xD46A50", Offset = "0xD45650", VA = "0x180D46A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x06014D8D RID: 85389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003172")]
		public UIToastController toastController
		{
			[Token(Token = "0x6014D8D")]
			[Address(RVA = "0xD47390", Offset = "0xD45F90", VA = "0x180D47390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x06014D8E RID: 85390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003173")]
		public UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6014D8E")]
			[Address(RVA = "0xD46170", Offset = "0xD44D70", VA = "0x180D46170")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x06014D8F RID: 85391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003174")]
		public UIBattleSystemMenuPanel systemMenuPanel
		{
			[Token(Token = "0x6014D8F")]
			[Address(RVA = "0xD47290", Offset = "0xD45E90", VA = "0x180D47290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x06014D90 RID: 85392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003175")]
		public Canvas perspectiveCanvas
		{
			[Token(Token = "0x6014D90")]
			[Address(RVA = "0xD46F40", Offset = "0xD45B40", VA = "0x180D46F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x06014D91 RID: 85393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003176")]
		public UICardList cardList
		{
			[Token(Token = "0x6014D91")]
			[Address(RVA = "0xD460F0", Offset = "0xD44CF0", VA = "0x180D460F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x06014D92 RID: 85394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003177")]
		public UICanvasScalerHelper scalerHelper
		{
			[Token(Token = "0x6014D92")]
			[Address(RVA = "0xD47040", Offset = "0xD45C40", VA = "0x180D47040")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x06014D93 RID: 85395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003178")]
		private UIAutoBattlePanel autoBattlePanel
		{
			[Token(Token = "0x6014D93")]
			[Address(RVA = "0xD45BA0", Offset = "0xD447A0", VA = "0x180D45BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x06014D94 RID: 85396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003179")]
		public RectTransform groupRoot
		{
			[Token(Token = "0x6014D94")]
			[Address(RVA = "0xD467D0", Offset = "0xD453D0", VA = "0x180D467D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x06014D95 RID: 85397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700317A")]
		public RectTransform groupStatic
		{
			[Token(Token = "0x6014D95")]
			[Address(RVA = "0xD46850", Offset = "0xD45450", VA = "0x180D46850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x06014D96 RID: 85398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700317B")]
		public RectTransform groupTop
		{
			[Token(Token = "0x6014D96")]
			[Address(RVA = "0xD46950", Offset = "0xD45550", VA = "0x180D46950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x06014D97 RID: 85399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700317C")]
		public RectTransform groupTopBar
		{
			[Token(Token = "0x6014D97")]
			[Address(RVA = "0xD468D0", Offset = "0xD454D0", VA = "0x180D468D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x06014D98 RID: 85400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700317D")]
		public List<RectTransform> hideWhenDialog
		{
			[Token(Token = "0x6014D98")]
			[Address(RVA = "0xD469D0", Offset = "0xD455D0", VA = "0x180D469D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x06014D99 RID: 85401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700317E")]
		public RectTransform groupDialogue
		{
			[Token(Token = "0x6014D99")]
			[Address(RVA = "0xD46750", Offset = "0xD45350", VA = "0x180D46750")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x06014D9A RID: 85402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700317F")]
		public RectTransform tempPanelPerspective
		{
			[Token(Token = "0x6014D9A")]
			[Address(RVA = "0xD47310", Offset = "0xD45F10", VA = "0x180D47310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x06014D9B RID: 85403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003180")]
		public Camera camera
		{
			[Token(Token = "0x6014D9B")]
			[Address(RVA = "0xD46070", Offset = "0xD44C70", VA = "0x180D46070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x06014D9C RID: 85404 RVA: 0x00088DD0 File Offset: 0x00086FD0
		[Token(Token = "0x17003181")]
		public bool isPaused
		{
			[Token(Token = "0x6014D9C")]
			[Address(RVA = "0xD46C90", Offset = "0xD45890", VA = "0x180D46C90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x06014D9D RID: 85405 RVA: 0x00088DE8 File Offset: 0x00086FE8
		[Token(Token = "0x17003182")]
		public bool isPausedButNotInGuideMode
		{
			[Token(Token = "0x6014D9D")]
			[Address(RVA = "0xD46C00", Offset = "0xD45800", VA = "0x180D46C00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x06014D9E RID: 85406 RVA: 0x00088E00 File Offset: 0x00087000
		[Token(Token = "0x17003183")]
		public bool isCameraDragValidState
		{
			[Token(Token = "0x6014D9E")]
			[Address(RVA = "0xD46AD0", Offset = "0xD456D0", VA = "0x180D46AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x06014D9F RID: 85407 RVA: 0x00088E18 File Offset: 0x00087018
		[Token(Token = "0x17003184")]
		public bool enableUIShowCardState
		{
			[Token(Token = "0x6014D9F")]
			[Address(RVA = "0xD46400", Offset = "0xD45000", VA = "0x180D46400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x06014DA0 RID: 85408 RVA: 0x00088E30 File Offset: 0x00087030
		// (set) Token: 0x06014DA1 RID: 85409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003185")]
		public bool isGuideMode
		{
			[Token(Token = "0x6014DA0")]
			[Address(RVA = "0xD46B80", Offset = "0xD45780", VA = "0x180D46B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014DA1")]
			[Address(RVA = "0xD475B0", Offset = "0xD461B0", VA = "0x180D475B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x06014DA2 RID: 85410 RVA: 0x00088E48 File Offset: 0x00087048
		// (set) Token: 0x06014DA3 RID: 85411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003186")]
		public bool isPerspectiveCanvasOn
		{
			[Token(Token = "0x6014DA2")]
			[Address(RVA = "0xD46DC0", Offset = "0xD459C0", VA = "0x180D46DC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014DA3")]
			[Address(RVA = "0xD47640", Offset = "0xD46240", VA = "0x180D47640")]
			set
			{
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x06014DA4 RID: 85412 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014DA5 RID: 85413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003187")]
		private BattleController controller
		{
			[Token(Token = "0x6014DA4")]
			[Address(RVA = "0xD46270", Offset = "0xD44E70", VA = "0x180D46270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6014DA5")]
			[Address(RVA = "0xD47510", Offset = "0xD46110", VA = "0x180D47510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x06014DA6 RID: 85414 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014DA7 RID: 85415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003188")]
		public AVGTutorialPanel.IAVGTutorialPanelPlugin avgTutorialPlugin
		{
			[Token(Token = "0x6014DA6")]
			[Address(RVA = "0xD45F00", Offset = "0xD44B00", VA = "0x180D45F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6014DA7")]
			[Address(RVA = "0xD47470", Offset = "0xD46070", VA = "0x180D47470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x06014DA8 RID: 85416 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014DA9 RID: 85417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003189")]
		public UIController.Plugin plugin
		{
			[Token(Token = "0x6014DA8")]
			[Address(RVA = "0xD46FC0", Offset = "0xD45BC0", VA = "0x180D46FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6014DA9")]
			[Address(RVA = "0xD477E0", Offset = "0xD463E0", VA = "0x180D477E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x06014DAA RID: 85418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700318A")]
		private UIEnemyGiantBossInfoPanel enemyBossInfo
		{
			[Token(Token = "0x6014DAA")]
			[Address(RVA = "0xD46540", Offset = "0xD45140", VA = "0x180D46540")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x06014DAB RID: 85419 RVA: 0x00088E60 File Offset: 0x00087060
		[Token(Token = "0x1700318B")]
		public bool showCharacterStatusInDummy
		{
			[Token(Token = "0x6014DAB")]
			[Address(RVA = "0xD47110", Offset = "0xD45D10", VA = "0x180D47110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x06014DAC RID: 85420 RVA: 0x00088E78 File Offset: 0x00087078
		[Token(Token = "0x1700318C")]
		public bool needReleaseIllust
		{
			[Token(Token = "0x6014DAC")]
			[Address(RVA = "0xD46E40", Offset = "0xD45A40", VA = "0x180D46E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014DAD RID: 85421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DAD")]
		[Address(RVA = "0xD3E520", Offset = "0xD3D120", VA = "0x180D3E520")]
		public void OnCardMenuShow(Deck.Card card)
		{
		}

		// Token: 0x06014DAE RID: 85422 RVA: 0x00088E90 File Offset: 0x00087090
		[Token(Token = "0x6014DAE")]
		[Address(RVA = "0xD3CFE0", Offset = "0xD3BBE0", VA = "0x180D3CFE0")]
		public bool CanPluginPressBackButton()
		{
			return default(bool);
		}

		// Token: 0x06014DAF RID: 85423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DAF")]
		[Address(RVA = "0xD3E980", Offset = "0xD3D580", VA = "0x180D3E980")]
		public void OnCharacterMenuShow(Character character)
		{
		}

		// Token: 0x06014DB0 RID: 85424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DB0")]
		[Address(RVA = "0xD3E880", Offset = "0xD3D480", VA = "0x180D3E880")]
		public void OnCharacterMenuHide()
		{
		}

		// Token: 0x06014DB1 RID: 85425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DB1")]
		[Address(RVA = "0xD3EC50", Offset = "0xD3D850", VA = "0x180D3EC50")]
		public void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x06014DB2 RID: 85426 RVA: 0x00088EA8 File Offset: 0x000870A8
		[Token(Token = "0x6014DB2")]
		[Address(RVA = "0xD40F80", Offset = "0xD3FB80", VA = "0x180D40F80")]
		public bool SetPaused(bool value, bool quiet = false, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x06014DB3 RID: 85427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DB3")]
		[Address(RVA = "0xD408A0", Offset = "0xD3F4A0", VA = "0x180D408A0")]
		public void RaiseTutorialSignal(string signal = "any")
		{
		}

		// Token: 0x06014DB4 RID: 85428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DB4")]
		[Address(RVA = "0xD407B0", Offset = "0xD3F3B0", VA = "0x180D407B0")]
		public void RaiseTutorialSignalIfRuning(string signal = "any")
		{
		}

		// Token: 0x06014DB5 RID: 85429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DB5")]
		[Address(RVA = "0xD40980", Offset = "0xD3F580", VA = "0x180D40980")]
		public void RegisterTutorialExtraBattleTarget(string signal, GameObject target)
		{
		}

		// Token: 0x06014DB6 RID: 85430 RVA: 0x00088EC0 File Offset: 0x000870C0
		[Token(Token = "0x6014DB6")]
		[Address(RVA = "0xD42A90", Offset = "0xD41690", VA = "0x180D42A90")]
		public bool TryMatchingTutorialWaitSignalStringParam(string waitSignal, string paramKey, string targetValue)
		{
			return default(bool);
		}

		// Token: 0x06014DB7 RID: 85431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DB7")]
		[Address(RVA = "0xD3E3A0", Offset = "0xD3CFA0", VA = "0x180D3E3A0")]
		public void OnCardBeginDrag(UICard card)
		{
		}

		// Token: 0x06014DB8 RID: 85432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DB8")]
		[Address(RVA = "0xD3E460", Offset = "0xD3D060", VA = "0x180D3E460")]
		public void OnCardEndDrag(UICard card)
		{
		}

		// Token: 0x06014DB9 RID: 85433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DB9")]
		[Address(RVA = "0xD3E630", Offset = "0xD3D230", VA = "0x180D3E630")]
		public void OnCardToggled(UICard card, bool isOn)
		{
		}

		// Token: 0x06014DBA RID: 85434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DBA")]
		[Address(RVA = "0xD3D900", Offset = "0xD3C500", VA = "0x180D3D900")]
		public void HideCharacterInfo(bool unselectActiveCard = false)
		{
		}

		// Token: 0x06014DBB RID: 85435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DBB")]
		[Address(RVA = "0xD42EB0", Offset = "0xD41AB0", VA = "0x180D42EB0")]
		public void UpdateCardListToggleGroup(bool isEnabled)
		{
		}

		// Token: 0x06014DBC RID: 85436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DBC")]
		[Address(RVA = "0xD3DCC0", Offset = "0xD3C8C0", VA = "0x180D3DCC0")]
		public void OnBottomMaskClicked(object arg)
		{
		}

		// Token: 0x06014DBD RID: 85437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DBD")]
		[Address(RVA = "0xD3E120", Offset = "0xD3CD20", VA = "0x180D3E120")]
		public void OnBottomMaskDrag(object arg)
		{
		}

		// Token: 0x06014DBE RID: 85438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DBE")]
		[Address(RVA = "0xD3DBF0", Offset = "0xD3C7F0", VA = "0x180D3DBF0")]
		public void OnBottomMaskBeginDrag(object arg)
		{
		}

		// Token: 0x06014DBF RID: 85439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DBF")]
		[Address(RVA = "0xD3E1F0", Offset = "0xD3CDF0", VA = "0x180D3E1F0")]
		public void OnBottomMaskEndDrag(object arg)
		{
		}

		// Token: 0x06014DC0 RID: 85440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DC0")]
		[Address(RVA = "0xD3DED0", Offset = "0xD3CAD0", VA = "0x180D3DED0")]
		public void OnBottomMaskDown(object arg)
		{
		}

		// Token: 0x06014DC1 RID: 85441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DC1")]
		[Address(RVA = "0xD3E2C0", Offset = "0xD3CEC0", VA = "0x180D3E2C0")]
		public void OnBottomMaskUp(object arg)
		{
		}

		// Token: 0x06014DC2 RID: 85442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DC2")]
		[Address(RVA = "0xD406F0", Offset = "0xD3F2F0", VA = "0x180D406F0")]
		public void PrepareThenRestartGame()
		{
		}

		// Token: 0x06014DC3 RID: 85443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DC3")]
		[Address(RVA = "0xD40CA0", Offset = "0xD3F8A0", VA = "0x180D40CA0")]
		public void RestartGame()
		{
		}

		// Token: 0x06014DC4 RID: 85444 RVA: 0x00088ED8 File Offset: 0x000870D8
		[Token(Token = "0x6014DC4")]
		[Address(RVA = "0xD3D390", Offset = "0xD3BF90", VA = "0x180D3D390")]
		public Vector2 GameToUIWorldPos(Vector3 position)
		{
			return default(Vector2);
		}

		// Token: 0x06014DC5 RID: 85445 RVA: 0x00088EF0 File Offset: 0x000870F0
		[Token(Token = "0x6014DC5")]
		[Address(RVA = "0xD3D230", Offset = "0xD3BE30", VA = "0x180D3D230")]
		public Vector2 GameToUIPixel(Vector3 position)
		{
			return default(Vector2);
		}

		// Token: 0x06014DC6 RID: 85446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DC6")]
		[Address(RVA = "0xD3D190", Offset = "0xD3BD90", VA = "0x180D3D190")]
		public void EnableFunction(BattleFunctionDisableMask mask)
		{
		}

		// Token: 0x06014DC7 RID: 85447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DC7")]
		[Address(RVA = "0xD3D0F0", Offset = "0xD3BCF0", VA = "0x180D3D0F0")]
		public void DisableFunction(BattleFunctionDisableMask mask)
		{
		}

		// Token: 0x06014DC8 RID: 85448 RVA: 0x00088F08 File Offset: 0x00087108
		[Token(Token = "0x6014DC8")]
		[Address(RVA = "0xD3D870", Offset = "0xD3C470", VA = "0x180D3D870")]
		public bool HasFunction(BattleFunctionDisableMask mask)
		{
			return default(bool);
		}

		// Token: 0x06014DC9 RID: 85449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DC9")]
		[Address(RVA = "0xD3DA10", Offset = "0xD3C610", VA = "0x180D3DA10")]
		public void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x06014DCA RID: 85450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DCA")]
		[Address(RVA = "0xD44BD0", Offset = "0xD437D0", VA = "0x180D44BD0")]
		private void _TriggerPauseWhenApplicationPaused()
		{
		}

		// Token: 0x06014DCB RID: 85451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DCB")]
		[Address(RVA = "0xD45170", Offset = "0xD43D70", VA = "0x180D45170")]
		private void _UpdateDisableMask(BattleFunctionDisableMask mask)
		{
		}

		// Token: 0x06014DCC RID: 85452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DCC")]
		[Address(RVA = "0xD45350", Offset = "0xD43F50", VA = "0x180D45350")]
		private void _UpdateGameInfo()
		{
		}

		// Token: 0x06014DCD RID: 85453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DCD")]
		[Address(RVA = "0xD45600", Offset = "0xD44200", VA = "0x180D45600")]
		private void _UpdateHudScaleIfNot()
		{
		}

		// Token: 0x06014DCE RID: 85454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014DCE")]
		[Address(RVA = "0xD43910", Offset = "0xD42510", VA = "0x180D43910")]
		private RectTransform _LoadRuntimeUIPluginIfNot(string name)
		{
			return null;
		}

		// Token: 0x06014DCF RID: 85455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DCF")]
		[Address(RVA = "0xD3CB60", Offset = "0xD3B760", VA = "0x180D3CB60")]
		public void AddRuntimeUIPlugin(UIController.RtUIPluginPosition position, string name)
		{
		}

		// Token: 0x06014DD0 RID: 85456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DD0")]
		[Address(RVA = "0xD40AE0", Offset = "0xD3F6E0", VA = "0x180D40AE0")]
		public void RemoveRuntimeUIPlugin(string name)
		{
		}

		// Token: 0x06014DD1 RID: 85457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DD1")]
		[Address(RVA = "0xD41090", Offset = "0xD3FC90", VA = "0x180D41090")]
		public void SetPlayerSide(PlayerSide side)
		{
		}

		// Token: 0x06014DD2 RID: 85458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DD2")]
		[Address(RVA = "0xD43510", Offset = "0xD42110", VA = "0x180D43510")]
		private void _InitStateMachine()
		{
		}

		// Token: 0x06014DD3 RID: 85459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DD3")]
		[Address(RVA = "0xD44CE0", Offset = "0xD438E0", VA = "0x180D44CE0")]
		private void _TryCreatePlugin()
		{
		}

		// Token: 0x06014DD4 RID: 85460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014DD4")]
		[Address(RVA = "0xD43190", Offset = "0xD41D90", VA = "0x180D43190")]
		private GameObject _CreatePluginByLevelData(LevelData levelData)
		{
			return null;
		}

		// Token: 0x06014DD5 RID: 85461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DD5")]
		[Address(RVA = "0xD41130", Offset = "0xD3FD30", VA = "0x180D41130")]
		public void SetUIStateParam(UIStateEnum targetState, object param)
		{
		}

		// Token: 0x06014DD6 RID: 85462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014DD6")]
		public T GetUIStateParam<T>(UIStateEnum targetState)
		{
			return null;
		}

		// Token: 0x06014DD7 RID: 85463 RVA: 0x00088F20 File Offset: 0x00087120
		[Token(Token = "0x6014DD7")]
		[Address(RVA = "0xD42DA0", Offset = "0xD419A0", VA = "0x180D42DA0")]
		public Vector2 UIPixelToWorldVector(Vector2 vector)
		{
			return default(Vector2);
		}

		// Token: 0x06014DD8 RID: 85464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DD8")]
		[Address(RVA = "0xD41990", Offset = "0xD40590", VA = "0x180D41990")]
		public void ShowModifierText(ref Modifier modifier, Transform spawnPoint)
		{
		}

		// Token: 0x06014DD9 RID: 85465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DD9")]
		[Address(RVA = "0xD41E90", Offset = "0xD40A90", VA = "0x180D41E90")]
		public void ShowNumericText(ref Modifier modifier, Transform spawnPoint, UINumericText _text, bool useFixedValue = false, int value = 0)
		{
		}

		// Token: 0x06014DDA RID: 85466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DDA")]
		[Address(RVA = "0xD41620", Offset = "0xD40220", VA = "0x180D41620")]
		public void ShowMessageText(string message, Transform spawnPoint)
		{
		}

		// Token: 0x06014DDB RID: 85467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DDB")]
		[Address(RVA = "0xD417C0", Offset = "0xD403C0", VA = "0x180D417C0")]
		public void ShowMessageText(string message, Transform spawnPoint, Color color)
		{
		}

		// Token: 0x06014DDC RID: 85468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DDC")]
		[Address(RVA = "0xD42240", Offset = "0xD40E40", VA = "0x180D42240")]
		public void ShowSlowMessageText(string message, Transform spawnPoint, Color color)
		{
		}

		// Token: 0x06014DDD RID: 85469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DDD")]
		[Address(RVA = "0xD420A0", Offset = "0xD40CA0", VA = "0x180D420A0")]
		public void ShowRetriggerSkillCost(string message, Transform spawnPoint)
		{
		}

		// Token: 0x06014DDE RID: 85470 RVA: 0x00088F38 File Offset: 0x00087138
		[Token(Token = "0x6014DDE")]
		[Address(RVA = "0xD41400", Offset = "0xD40000", VA = "0x180D41400")]
		public bool ShowGameModeNumericTest(int value, Transform spawnPoint, Color color)
		{
			return default(bool);
		}

		// Token: 0x06014DDF RID: 85471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DDF")]
		[Address(RVA = "0xD426D0", Offset = "0xD412D0", VA = "0x180D426D0")]
		public void SwitchToBattleFinishService(BattleFinishServiceStateParam param)
		{
		}

		// Token: 0x06014DE0 RID: 85472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE0")]
		[Address(RVA = "0xD42540", Offset = "0xD41140", VA = "0x180D42540")]
		public void SwitchToBattleFailedState(BattleFailedStateParam param)
		{
		}

		// Token: 0x06014DE1 RID: 85473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE1")]
		[Address(RVA = "0xD42410", Offset = "0xD41010", VA = "0x180D42410")]
		public void SwitchToBattleAccomplishedState()
		{
		}

		// Token: 0x06014DE2 RID: 85474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE2")]
		[Address(RVA = "0xD427C0", Offset = "0xD413C0", VA = "0x180D427C0")]
		public void SwitchToDialogState(BattleDialogParam param)
		{
		}

		// Token: 0x06014DE3 RID: 85475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE3")]
		[Address(RVA = "0xD401F0", Offset = "0xD3EDF0", VA = "0x180D401F0")]
		public void OnSystemMenuCancel()
		{
		}

		// Token: 0x06014DE4 RID: 85476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE4")]
		[Address(RVA = "0xD41200", Offset = "0xD3FE00", VA = "0x180D41200")]
		public void ShowDynamicHUDGroup(bool isActive)
		{
		}

		// Token: 0x06014DE5 RID: 85477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE5")]
		[Address(RVA = "0xD41560", Offset = "0xD40160", VA = "0x180D41560")]
		public void ShowHint(string text, UIHintController.BannerStyle style = UIHintController.BannerStyle.DEFAULT)
		{
		}

		// Token: 0x06014DE6 RID: 85478 RVA: 0x00088F50 File Offset: 0x00087150
		[Token(Token = "0x6014DE6")]
		[Address(RVA = "0xD3CD50", Offset = "0xD3B950", VA = "0x180D3CD50")]
		public bool AttachHudPlugin(Unit unit, Transform plugin)
		{
			return default(bool);
		}

		// Token: 0x06014DE7 RID: 85479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE7")]
		[Address(RVA = "0xD40440", Offset = "0xD3F040", VA = "0x180D40440")]
		public void PrepareHideForDialog()
		{
		}

		// Token: 0x06014DE8 RID: 85480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE8")]
		[Address(RVA = "0xD40DB0", Offset = "0xD3F9B0", VA = "0x180D40DB0")]
		public void RestoreHideForDialog()
		{
		}

		// Token: 0x06014DE9 RID: 85481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DE9")]
		[Address(RVA = "0xD3F6D0", Offset = "0xD3E2D0", VA = "0x180D3F6D0", Slot = "8")]
		public void OnGameReset(BattleController controller)
		{
		}

		// Token: 0x06014DEA RID: 85482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DEA")]
		[Address(RVA = "0xD3EE40", Offset = "0xD3DA40", VA = "0x180D3EE40", Slot = "9")]
		public void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x06014DEB RID: 85483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DEB")]
		[Address(RVA = "0xD3F4A0", Offset = "0xD3E0A0", VA = "0x180D3F4A0", Slot = "10")]
		public void OnGameReady()
		{
		}

		// Token: 0x06014DEC RID: 85484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DEC")]
		[Address(RVA = "0xD3FF50", Offset = "0xD3EB50", VA = "0x180D3FF50", Slot = "11")]
		public void OnGameStart()
		{
		}

		// Token: 0x06014DED RID: 85485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DED")]
		[Address(RVA = "0xD3F1D0", Offset = "0xD3DDD0", VA = "0x180D3F1D0", Slot = "12")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x06014DEE RID: 85486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DEE")]
		[Address(RVA = "0xD40150", Offset = "0xD3ED50", VA = "0x180D40150")]
		public void OnSwitchToBattleFinish()
		{
		}

		// Token: 0x06014DEF RID: 85487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DEF")]
		[Address(RVA = "0xD402F0", Offset = "0xD3EEF0", VA = "0x180D402F0")]
		public void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x06014DF0 RID: 85488 RVA: 0x00088F68 File Offset: 0x00087168
		[Token(Token = "0x6014DF0")]
		[Address(RVA = "0xD3D4F0", Offset = "0xD3C0F0", VA = "0x180D3D4F0")]
		public Vector3 GetPredefinedLocationByUI(PredefinedLocation location)
		{
			return default(Vector3);
		}

		// Token: 0x06014DF1 RID: 85489 RVA: 0x00088F80 File Offset: 0x00087180
		[Token(Token = "0x6014DF1")]
		[Address(RVA = "0xD428B0", Offset = "0xD414B0", VA = "0x180D428B0")]
		public bool TryGetCardPositionByUI(uint cardUniqueId, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x06014DF2 RID: 85490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DF2")]
		[Address(RVA = "0xD444F0", Offset = "0xD430F0", VA = "0x180D444F0")]
		private void _OnUnitBorn(Unit unit)
		{
		}

		// Token: 0x06014DF3 RID: 85491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014DF3")]
		[Address(RVA = "0xD43440", Offset = "0xD42040", VA = "0x180D43440")]
		private UIUnitHUD _GetDefaultHud(Unit unit)
		{
			return null;
		}

		// Token: 0x06014DF4 RID: 85492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DF4")]
		[Address(RVA = "0xD44340", Offset = "0xD42F40", VA = "0x180D44340")]
		private void _OnGiantBossHudUsed(IUseGiantBossInfoPanel target)
		{
		}

		// Token: 0x06014DF5 RID: 85493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DF5")]
		[Address(RVA = "0xD44900", Offset = "0xD43500", VA = "0x180D44900")]
		private void _OnUnitFinish(Unit unit)
		{
		}

		// Token: 0x06014DF6 RID: 85494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DF6")]
		[Address(RVA = "0xD443F0", Offset = "0xD42FF0", VA = "0x180D443F0")]
		private void _OnStateChanged(int newState, int oldState)
		{
		}

		// Token: 0x06014DF7 RID: 85495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DF7")]
		[Address(RVA = "0xD43FE0", Offset = "0xD42BE0", VA = "0x180D43FE0")]
		private void _OnDisplayEnemyInfo(object arg)
		{
		}

		// Token: 0x06014DF8 RID: 85496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DF8")]
		[Address(RVA = "0xD43CD0", Offset = "0xD428D0", VA = "0x180D43CD0")]
		private void _OnBlockAnyRoutes(object arg)
		{
		}

		// Token: 0x06014DF9 RID: 85497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DF9")]
		[Address(RVA = "0xD441B0", Offset = "0xD42DB0", VA = "0x180D441B0")]
		private void _OnDisplayLegionBlastCard(object arg)
		{
		}

		// Token: 0x06014DFA RID: 85498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DFA")]
		[Address(RVA = "0xD43E30", Offset = "0xD42A30", VA = "0x180D43E30")]
		private void _OnDisplayDeckBuffEffect(object arg)
		{
		}

		// Token: 0x06014DFB RID: 85499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DFB")]
		[Address(RVA = "0xD43BC0", Offset = "0xD427C0", VA = "0x180D43BC0")]
		private void _OnAutoReplayModeChanged(object arg)
		{
		}

		// Token: 0x06014DFC RID: 85500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DFC")]
		[Address(RVA = "0xD43AB0", Offset = "0xD426B0", VA = "0x180D43AB0")]
		private void _OnAutoReplayFinished(object arg)
		{
		}

		// Token: 0x06014DFD RID: 85501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DFD")]
		[Address(RVA = "0xD3CE60", Offset = "0xD3BA60", VA = "0x180D3CE60", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x06014DFE RID: 85502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DFE")]
		[Address(RVA = "0xD3EA90", Offset = "0xD3D690", VA = "0x180D3EA90", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06014DFF RID: 85503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014DFF")]
		[Address(RVA = "0xD42F50", Offset = "0xD41B50", VA = "0x180D42F50")]
		private void Update()
		{
		}

		// Token: 0x06014E00 RID: 85504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E00")]
		[Address(RVA = "0xD45840", Offset = "0xD44440", VA = "0x180D45840")]
		public UIController()
		{
		}

		// Token: 0x04018C82 RID: 101506
		[Token(Token = "0x4018C82")]
		public const float ALERT_INFO_POPUP_TIME = 2f;

		// Token: 0x04018C83 RID: 101507
		[Token(Token = "0x4018C83")]
		private const float ENEMY_INFO_TOAST_TIME = 5f;

		// Token: 0x04018C84 RID: 101508
		[Token(Token = "0x4018C84")]
		private const float LEGION_BLAST_CARD_TOAST_TIME = 2f;

		// Token: 0x04018C85 RID: 101509
		[Token(Token = "0x4018C85")]
		private const float LEGION_TRAP_EFFECT_TOAST_TIME = 2f;

		// Token: 0x04018C86 RID: 101510
		[Token(Token = "0x4018C86")]
		private const string MISS_TEXT = "miss";

		// Token: 0x04018C87 RID: 101511
		[Token(Token = "0x4018C87")]
		private const string BLOCKED_TEXT = "block";

		// Token: 0x04018C88 RID: 101512
		[Token(Token = "0x4018C88")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3 PREDEFINED_LOCATION_COST_OFFSET;

		// Token: 0x04018C89 RID: 101513
		[Token(Token = "0x4018C89")]
		[FieldOffset(Offset = "0xC")]
		private static readonly Vector3 PREDEFINED_LOCATION_LEGION_CARD_PENDING_OFFSET;

		// Token: 0x04018C8A RID: 101514
		[Token(Token = "0x4018C8A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector3 PREDEFINED_LOCATION_FUNLIVE_PHOTO_PENDING_OFFSET;

		// Token: 0x04018C8B RID: 101515
		[Token(Token = "0x4018C8B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _uiCamera;

		// Token: 0x04018C8C RID: 101516
		[Token(Token = "0x4018C8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Canvas _rootCanvas;

		// Token: 0x04018C8D RID: 101517
		[Token(Token = "0x4018C8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Canvas _perspectiveCanvas;

		// Token: 0x04018C8E RID: 101518
		[Token(Token = "0x4018C8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Widgets")]
		private UITopBar _topBar;

		// Token: 0x04018C8F RID: 101519
		[Token(Token = "0x4018C8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Widgets")]
		private UICharacterInfoPanel _characterInfo;

		// Token: 0x04018C90 RID: 101520
		[Token(Token = "0x4018C90")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Widgets")]
		private UIFakeBlur _fakeBlur;

		// Token: 0x04018C91 RID: 101521
		[Token(Token = "0x4018C91")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Widgets")]
		private UICardList _cardList;

		// Token: 0x04018C92 RID: 101522
		[Token(Token = "0x4018C92")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Widgets")]
		private UIToastController _toastController;

		// Token: 0x04018C93 RID: 101523
		[Token(Token = "0x4018C93")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Widgets")]
		private UIHintController _hintController;

		// Token: 0x04018C94 RID: 101524
		[Token(Token = "0x4018C94")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Widgets")]
		private UIAutoBattlePanel _autoBattlePanel;

		// Token: 0x04018C95 RID: 101525
		[Token(Token = "0x4018C95")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Widgets")]
		private UIBattleSystemMenuPanel _systemMenuPanel;

		// Token: 0x04018C96 RID: 101526
		[Token(Token = "0x4018C96")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Widgets")]
		private Image _bottomMask;

		// Token: 0x04018C97 RID: 101527
		[Token(Token = "0x4018C97")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("BasicInfo")]
		private UICostPanel _costPanel;

		// Token: 0x04018C98 RID: 101528
		[Token(Token = "0x4018C98")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Containers")]
		private RectTransform _hudPanel;

		// Token: 0x04018C99 RID: 101529
		[Token(Token = "0x4018C99")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Containers")]
		private RectTransform _tempPanel;

		// Token: 0x04018C9A RID: 101530
		[Token(Token = "0x4018C9A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Containers")]
		private RectTransform _tempPanelPerspective;

		// Token: 0x04018C9B RID: 101531
		[Token(Token = "0x4018C9B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Prefabs")]
		private UIUnitHUD _unitHud;

		// Token: 0x04018C9C RID: 101532
		[Token(Token = "0x4018C9C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Prefabs")]
		private UIUnitHudPluginHolder _hudPluginHolder;

		// Token: 0x04018C9D RID: 101533
		[Token(Token = "0x4018C9D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Prefabs")]
		private UINumericText _damageText;

		// Token: 0x04018C9E RID: 101534
		[Token(Token = "0x4018C9E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Prefabs")]
		private UINumericText _healText;

		// Token: 0x04018C9F RID: 101535
		[Token(Token = "0x4018C9F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Prefabs")]
		private UINumericText _blockText;

		// Token: 0x04018CA0 RID: 101536
		[Token(Token = "0x4018CA0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Prefabs")]
		private UIMessageText _messageText;

		// Token: 0x04018CA1 RID: 101537
		[Token(Token = "0x4018CA1")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Prefabs")]
		private UIMessageText _messageTextSlow;

		// Token: 0x04018CA2 RID: 101538
		[Token(Token = "0x4018CA2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Prefabs")]
		private UIAnimationText _retriggerSkillCostText;

		// Token: 0x04018CA3 RID: 101539
		[Token(Token = "0x4018CA3")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Prefabs")]
		private UIEnemyGiantBossInfoPanel _enemyBossInfo;

		// Token: 0x04018CA4 RID: 101540
		[Token(Token = "0x4018CA4")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Prefabs")]
		private UIAnimationPerform _battleAccomplishedPerform;

		// Token: 0x04018CA5 RID: 101541
		[Token(Token = "0x4018CA5")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Prefabs")]
		private UIDirectionSelector _directionSelector;

		// Token: 0x04018CA6 RID: 101542
		[Token(Token = "0x4018CA6")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Prefabs")]
		private PoolManager.ObjectConfig[] _additionalPreloads;

		// Token: 0x04018CA7 RID: 101543
		[Token(Token = "0x4018CA7")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("States")]
		private UIStateNode[] _states;

		// Token: 0x04018CA8 RID: 101544
		[Token(Token = "0x4018CA8")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("States")]
		private UICharacterMenuState _characterMenuState;

		// Token: 0x04018CA9 RID: 101545
		[Token(Token = "0x4018CA9")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("BasicInfo")]
		private UIRemainingAvailableCharacter _remainingCharacter;

		// Token: 0x04018CAA RID: 101546
		[Token(Token = "0x4018CAA")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Group")]
		private List<RectTransform> _hideWhenDialog;

		// Token: 0x04018CAB RID: 101547
		[Token(Token = "0x4018CAB")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Group")]
		private RectTransform _groupRoot;

		// Token: 0x04018CAC RID: 101548
		[Token(Token = "0x4018CAC")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Group")]
		private RectTransform _groupStatic;

		// Token: 0x04018CAD RID: 101549
		[Token(Token = "0x4018CAD")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Group")]
		private RectTransform _groupTop;

		// Token: 0x04018CAE RID: 101550
		[Token(Token = "0x4018CAE")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Group")]
		private RectTransform _groupTopBar;

		// Token: 0x04018CAF RID: 101551
		[Token(Token = "0x4018CAF")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Group")]
		private RectTransform _groupDialogue;

		// Token: 0x04018CB0 RID: 101552
		[Token(Token = "0x4018CB0")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Group")]
		private RectTransform _groupEnemy;

		// Token: 0x04018CB1 RID: 101553
		[Token(Token = "0x4018CB1")]
		[FieldOffset(Offset = "0x148")]
		private UIEnemyGiantBossInfoPanel m_enemyBossInfo;

		// Token: 0x04018CB2 RID: 101554
		[Token(Token = "0x4018CB2")]
		[FieldOffset(Offset = "0x150")]
		private bool m_isPerspectiveCanvasOn;

		// Token: 0x04018CB3 RID: 101555
		[Token(Token = "0x4018CB3")]
		[FieldOffset(Offset = "0x158")]
		private Camera m_uiPerspectiveCamera;

		// Token: 0x04018CB4 RID: 101556
		[Token(Token = "0x4018CB4")]
		[FieldOffset(Offset = "0x160")]
		private UIStateMachine m_stateMachine;

		// Token: 0x04018CB5 RID: 101557
		[Token(Token = "0x4018CB5")]
		[FieldOffset(Offset = "0x168")]
		private ListDict<UIStateEnum, object> m_stateParams;

		// Token: 0x04018CB6 RID: 101558
		[Token(Token = "0x4018CB6")]
		[FieldOffset(Offset = "0x170")]
		private EventPool<UIController.Event> m_eventPool;

		// Token: 0x04018CB7 RID: 101559
		[Token(Token = "0x4018CB7")]
		[FieldOffset(Offset = "0x178")]
		private Dictionary<uint, UIUnitHUD> m_hudMap;

		// Token: 0x04018CB8 RID: 101560
		[Token(Token = "0x4018CB8")]
		[FieldOffset(Offset = "0x180")]
		private BattleFunctionDisableMask m_functionDisableMask;

		// Token: 0x04018CB9 RID: 101561
		[Token(Token = "0x4018CB9")]
		[FieldOffset(Offset = "0x188")]
		private UICanvasScalerHelper m_canvasScalerHelper;

		// Token: 0x04018CBA RID: 101562
		[Token(Token = "0x4018CBA")]
		[FieldOffset(Offset = "0x190")]
		private float m_cameraHudScale;

		// Token: 0x04018CBB RID: 101563
		[Token(Token = "0x4018CBB")]
		[FieldOffset(Offset = "0x198")]
		private TileInfoController _tileInfoController;

		// Token: 0x04018CBC RID: 101564
		[Token(Token = "0x4018CBC")]
		[FieldOffset(Offset = "0x1A0")]
		private VoicePlayer m_voicePlayer;

		// Token: 0x04018CBD RID: 101565
		[Token(Token = "0x4018CBD")]
		[FieldOffset(Offset = "0x1A8")]
		private ListDict<RectTransform, bool> m_hideCache;

		// Token: 0x04018CBE RID: 101566
		[Token(Token = "0x4018CBE")]
		[FieldOffset(Offset = "0x1B0")]
		private Dictionary<string, RectTransform> m_loadedUIPlugins;

		// Token: 0x04018CBF RID: 101567
		[Token(Token = "0x4018CBF")]
		[FieldOffset(Offset = "0x1B8")]
		private Dictionary<string, int> m_runTimeUIPluginRefCount;

		// Token: 0x04018CC0 RID: 101568
		[Token(Token = "0x4018CC0")]
		[FieldOffset(Offset = "0x1C0")]
		private UIAutoBattlePanel m_autoBattlePanel;

		// Token: 0x04018CC5 RID: 101573
		[Token(Token = "0x4018CC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_stateMachine;

		// Token: 0x04018CC6 RID: 101574
		[Token(Token = "0x4018CC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_currentState;

		// Token: 0x04018CC7 RID: 101575
		[Token(Token = "0x4018CC7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x04018CC8 RID: 101576
		[Token(Token = "0x4018CC8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_topbar;

		// Token: 0x04018CC9 RID: 101577
		[Token(Token = "0x4018CC9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_bottomMask;

		// Token: 0x04018CCA RID: 101578
		[Token(Token = "0x4018CCA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_characterMenuState;

		// Token: 0x04018CCB RID: 101579
		[Token(Token = "0x4018CCB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_fakeBlur;

		// Token: 0x04018CCC RID: 101580
		[Token(Token = "0x4018CCC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_directionSelector;

		// Token: 0x04018CCD RID: 101581
		[Token(Token = "0x4018CCD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_battleAccomplishedPerform;

		// Token: 0x04018CCE RID: 101582
		[Token(Token = "0x4018CCE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_hudPanel;

		// Token: 0x04018CCF RID: 101583
		[Token(Token = "0x4018CCF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_toastController;

		// Token: 0x04018CD0 RID: 101584
		[Token(Token = "0x4018CD0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x04018CD1 RID: 101585
		[Token(Token = "0x4018CD1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_systemMenuPanel;

		// Token: 0x04018CD2 RID: 101586
		[Token(Token = "0x4018CD2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_perspectiveCanvas;

		// Token: 0x04018CD3 RID: 101587
		[Token(Token = "0x4018CD3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_cardList;

		// Token: 0x04018CD4 RID: 101588
		[Token(Token = "0x4018CD4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_scalerHelper;

		// Token: 0x04018CD5 RID: 101589
		[Token(Token = "0x4018CD5")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_autoBattlePanel;

		// Token: 0x04018CD6 RID: 101590
		[Token(Token = "0x4018CD6")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_groupRoot;

		// Token: 0x04018CD7 RID: 101591
		[Token(Token = "0x4018CD7")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_groupStatic;

		// Token: 0x04018CD8 RID: 101592
		[Token(Token = "0x4018CD8")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_groupTop;

		// Token: 0x04018CD9 RID: 101593
		[Token(Token = "0x4018CD9")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_groupTopBar;

		// Token: 0x04018CDA RID: 101594
		[Token(Token = "0x4018CDA")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_hideWhenDialog;

		// Token: 0x04018CDB RID: 101595
		[Token(Token = "0x4018CDB")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_groupDialogue;

		// Token: 0x04018CDC RID: 101596
		[Token(Token = "0x4018CDC")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_tempPanelPerspective;

		// Token: 0x04018CDD RID: 101597
		[Token(Token = "0x4018CDD")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_camera;

		// Token: 0x04018CDE RID: 101598
		[Token(Token = "0x4018CDE")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_isPaused;

		// Token: 0x04018CDF RID: 101599
		[Token(Token = "0x4018CDF")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_isPausedButNotInGuideMode;

		// Token: 0x04018CE0 RID: 101600
		[Token(Token = "0x4018CE0")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_isCameraDragValidState;

		// Token: 0x04018CE1 RID: 101601
		[Token(Token = "0x4018CE1")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_enableUIShowCardState;

		// Token: 0x04018CE2 RID: 101602
		[Token(Token = "0x4018CE2")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_isGuideMode;

		// Token: 0x04018CE3 RID: 101603
		[Token(Token = "0x4018CE3")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_isGuideMode;

		// Token: 0x04018CE4 RID: 101604
		[Token(Token = "0x4018CE4")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_isPerspectiveCanvasOn;

		// Token: 0x04018CE5 RID: 101605
		[Token(Token = "0x4018CE5")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_set_isPerspectiveCanvasOn;

		// Token: 0x04018CE6 RID: 101606
		[Token(Token = "0x4018CE6")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04018CE7 RID: 101607
		[Token(Token = "0x4018CE7")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04018CE8 RID: 101608
		[Token(Token = "0x4018CE8")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_avgTutorialPlugin;

		// Token: 0x04018CE9 RID: 101609
		[Token(Token = "0x4018CE9")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_set_avgTutorialPlugin;

		// Token: 0x04018CEA RID: 101610
		[Token(Token = "0x4018CEA")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x04018CEB RID: 101611
		[Token(Token = "0x4018CEB")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_set_plugin;

		// Token: 0x04018CEC RID: 101612
		[Token(Token = "0x4018CEC")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_enemyBossInfo;

		// Token: 0x04018CED RID: 101613
		[Token(Token = "0x4018CED")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_showCharacterStatusInDummy;

		// Token: 0x04018CEE RID: 101614
		[Token(Token = "0x4018CEE")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_needReleaseIllust;

		// Token: 0x04018CEF RID: 101615
		[Token(Token = "0x4018CEF")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_OnCardMenuShow;

		// Token: 0x04018CF0 RID: 101616
		[Token(Token = "0x4018CF0")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_CanPluginPressBackButton;

		// Token: 0x04018CF1 RID: 101617
		[Token(Token = "0x4018CF1")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

		// Token: 0x04018CF2 RID: 101618
		[Token(Token = "0x4018CF2")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnCharacterMenuHide;

		// Token: 0x04018CF3 RID: 101619
		[Token(Token = "0x4018CF3")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x04018CF4 RID: 101620
		[Token(Token = "0x4018CF4")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_SetPaused;

		// Token: 0x04018CF5 RID: 101621
		[Token(Token = "0x4018CF5")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_RaiseTutorialSignal;

		// Token: 0x04018CF6 RID: 101622
		[Token(Token = "0x4018CF6")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_RaiseTutorialSignalIfRuning;

		// Token: 0x04018CF7 RID: 101623
		[Token(Token = "0x4018CF7")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_RegisterTutorialExtraBattleTarget;

		// Token: 0x04018CF8 RID: 101624
		[Token(Token = "0x4018CF8")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_TryMatchingTutorialWaitSignalStringParam;

		// Token: 0x04018CF9 RID: 101625
		[Token(Token = "0x4018CF9")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_OnCardBeginDrag;

		// Token: 0x04018CFA RID: 101626
		[Token(Token = "0x4018CFA")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_OnCardEndDrag;

		// Token: 0x04018CFB RID: 101627
		[Token(Token = "0x4018CFB")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_OnCardToggled;

		// Token: 0x04018CFC RID: 101628
		[Token(Token = "0x4018CFC")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_HideCharacterInfo;

		// Token: 0x04018CFD RID: 101629
		[Token(Token = "0x4018CFD")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_UpdateCardListToggleGroup;

		// Token: 0x04018CFE RID: 101630
		[Token(Token = "0x4018CFE")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_OnBottomMaskClicked;

		// Token: 0x04018CFF RID: 101631
		[Token(Token = "0x4018CFF")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_OnBottomMaskDrag;

		// Token: 0x04018D00 RID: 101632
		[Token(Token = "0x4018D00")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_OnBottomMaskBeginDrag;

		// Token: 0x04018D01 RID: 101633
		[Token(Token = "0x4018D01")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_OnBottomMaskEndDrag;

		// Token: 0x04018D02 RID: 101634
		[Token(Token = "0x4018D02")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_OnBottomMaskDown;

		// Token: 0x04018D03 RID: 101635
		[Token(Token = "0x4018D03")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_OnBottomMaskUp;

		// Token: 0x04018D04 RID: 101636
		[Token(Token = "0x4018D04")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_PrepareThenRestartGame;

		// Token: 0x04018D05 RID: 101637
		[Token(Token = "0x4018D05")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_RestartGame;

		// Token: 0x04018D06 RID: 101638
		[Token(Token = "0x4018D06")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GameToUIWorldPos;

		// Token: 0x04018D07 RID: 101639
		[Token(Token = "0x4018D07")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GameToUIPixel;

		// Token: 0x04018D08 RID: 101640
		[Token(Token = "0x4018D08")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_EnableFunction;

		// Token: 0x04018D09 RID: 101641
		[Token(Token = "0x4018D09")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_DisableFunction;

		// Token: 0x04018D0A RID: 101642
		[Token(Token = "0x4018D0A")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_HasFunction;

		// Token: 0x04018D0B RID: 101643
		[Token(Token = "0x4018D0B")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_OnApplicationPause;

		// Token: 0x04018D0C RID: 101644
		[Token(Token = "0x4018D0C")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__TriggerPauseWhenApplicationPaused;

		// Token: 0x04018D0D RID: 101645
		[Token(Token = "0x4018D0D")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__UpdateDisableMask;

		// Token: 0x04018D0E RID: 101646
		[Token(Token = "0x4018D0E")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__UpdateGameInfo;

		// Token: 0x04018D0F RID: 101647
		[Token(Token = "0x4018D0F")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__UpdateHudScaleIfNot;

		// Token: 0x04018D10 RID: 101648
		[Token(Token = "0x4018D10")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__LoadRuntimeUIPluginIfNot;

		// Token: 0x04018D11 RID: 101649
		[Token(Token = "0x4018D11")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_AddRuntimeUIPlugin;

		// Token: 0x04018D12 RID: 101650
		[Token(Token = "0x4018D12")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_RemoveRuntimeUIPlugin;

		// Token: 0x04018D13 RID: 101651
		[Token(Token = "0x4018D13")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_SetPlayerSide;

		// Token: 0x04018D14 RID: 101652
		[Token(Token = "0x4018D14")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__InitStateMachine;

		// Token: 0x04018D15 RID: 101653
		[Token(Token = "0x4018D15")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__TryCreatePlugin;

		// Token: 0x04018D16 RID: 101654
		[Token(Token = "0x4018D16")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__CreatePluginByLevelData;

		// Token: 0x04018D17 RID: 101655
		[Token(Token = "0x4018D17")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_SetUIStateParam;

		// Token: 0x04018D18 RID: 101656
		[Token(Token = "0x4018D18")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_GetUIStateParam;

		// Token: 0x04018D19 RID: 101657
		[Token(Token = "0x4018D19")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_UIPixelToWorldVector;

		// Token: 0x04018D1A RID: 101658
		[Token(Token = "0x4018D1A")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_ShowModifierText;

		// Token: 0x04018D1B RID: 101659
		[Token(Token = "0x4018D1B")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_ShowNumericText;

		// Token: 0x04018D1C RID: 101660
		[Token(Token = "0x4018D1C")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_ShowMessageText;

		// Token: 0x04018D1D RID: 101661
		[Token(Token = "0x4018D1D")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix1_ShowMessageText;

		// Token: 0x04018D1E RID: 101662
		[Token(Token = "0x4018D1E")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_ShowSlowMessageText;

		// Token: 0x04018D1F RID: 101663
		[Token(Token = "0x4018D1F")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_ShowRetriggerSkillCost;

		// Token: 0x04018D20 RID: 101664
		[Token(Token = "0x4018D20")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_ShowGameModeNumericTest;

		// Token: 0x04018D21 RID: 101665
		[Token(Token = "0x4018D21")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_SwitchToBattleFinishService;

		// Token: 0x04018D22 RID: 101666
		[Token(Token = "0x4018D22")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_SwitchToBattleFailedState;

		// Token: 0x04018D23 RID: 101667
		[Token(Token = "0x4018D23")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_SwitchToBattleAccomplishedState;

		// Token: 0x04018D24 RID: 101668
		[Token(Token = "0x4018D24")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_SwitchToDialogState;

		// Token: 0x04018D25 RID: 101669
		[Token(Token = "0x4018D25")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_OnSystemMenuCancel;

		// Token: 0x04018D26 RID: 101670
		[Token(Token = "0x4018D26")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_ShowDynamicHUDGroup;

		// Token: 0x04018D27 RID: 101671
		[Token(Token = "0x4018D27")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_ShowHint;

		// Token: 0x04018D28 RID: 101672
		[Token(Token = "0x4018D28")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_AttachHudPlugin;

		// Token: 0x04018D29 RID: 101673
		[Token(Token = "0x4018D29")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_PrepareHideForDialog;

		// Token: 0x04018D2A RID: 101674
		[Token(Token = "0x4018D2A")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_RestoreHideForDialog;

		// Token: 0x04018D2B RID: 101675
		[Token(Token = "0x4018D2B")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x04018D2C RID: 101676
		[Token(Token = "0x4018D2C")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x04018D2D RID: 101677
		[Token(Token = "0x4018D2D")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x04018D2E RID: 101678
		[Token(Token = "0x4018D2E")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x04018D2F RID: 101679
		[Token(Token = "0x4018D2F")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x04018D30 RID: 101680
		[Token(Token = "0x4018D30")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_OnSwitchToBattleFinish;

		// Token: 0x04018D31 RID: 101681
		[Token(Token = "0x4018D31")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x04018D32 RID: 101682
		[Token(Token = "0x4018D32")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_GetPredefinedLocationByUI;

		// Token: 0x04018D33 RID: 101683
		[Token(Token = "0x4018D33")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_TryGetCardPositionByUI;

		// Token: 0x04018D34 RID: 101684
		[Token(Token = "0x4018D34")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x04018D35 RID: 101685
		[Token(Token = "0x4018D35")]
		[FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0__GetDefaultHud;

		// Token: 0x04018D36 RID: 101686
		[Token(Token = "0x4018D36")]
		[FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0__OnGiantBossHudUsed;

		// Token: 0x04018D37 RID: 101687
		[Token(Token = "0x4018D37")]
		[FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x04018D38 RID: 101688
		[Token(Token = "0x4018D38")]
		[FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0__OnStateChanged;

		// Token: 0x04018D39 RID: 101689
		[Token(Token = "0x4018D39")]
		[FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0__OnDisplayEnemyInfo;

		// Token: 0x04018D3A RID: 101690
		[Token(Token = "0x4018D3A")]
		[FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0__OnBlockAnyRoutes;

		// Token: 0x04018D3B RID: 101691
		[Token(Token = "0x4018D3B")]
		[FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0__OnDisplayLegionBlastCard;

		// Token: 0x04018D3C RID: 101692
		[Token(Token = "0x4018D3C")]
		[FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0__OnDisplayDeckBuffEffect;

		// Token: 0x04018D3D RID: 101693
		[Token(Token = "0x4018D3D")]
		[FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0__OnAutoReplayModeChanged;

		// Token: 0x04018D3E RID: 101694
		[Token(Token = "0x4018D3E")]
		[FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0__OnAutoReplayFinished;

		// Token: 0x04018D3F RID: 101695
		[Token(Token = "0x4018D3F")]
		[FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018D40 RID: 101696
		[Token(Token = "0x4018D40")]
		[FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018D41 RID: 101697
		[Token(Token = "0x4018D41")]
		[FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018D42 RID: 101698
		[Token(Token = "0x4018D42")]
		[FieldOffset(Offset = "0x410")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200332C RID: 13100
		[Token(Token = "0x200332C")]
		public abstract class Plugin : MonoBehaviour, IHotfixable
		{
			// Token: 0x1700318D RID: 12685
			// (get) Token: 0x06014E05 RID: 85509 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014E06 RID: 85510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700318D")]
			private protected UIController uiController
			{
				[Token(Token = "0x6014E05")]
				[Address(RVA = "0xD58980", Offset = "0xD57580", VA = "0x180D58980")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x6014E06")]
				[Address(RVA = "0xD58A60", Offset = "0xD57660", VA = "0x180D58A60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700318E RID: 12686
			// (get) Token: 0x06014E07 RID: 85511 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06014E08 RID: 85512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700318E")]
			private protected BattleController battleController
			{
				[Token(Token = "0x6014E07")]
				[Address(RVA = "0xD587E0", Offset = "0xD573E0", VA = "0x180D587E0")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x6014E08")]
				[Address(RVA = "0xD589E0", Offset = "0xD575E0", VA = "0x180D589E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700318F RID: 12687
			// (get) Token: 0x06014E09 RID: 85513 RVA: 0x00088F98 File Offset: 0x00087198
			[Token(Token = "0x1700318F")]
			public virtual bool isPaused
			{
				[Token(Token = "0x6014E09")]
				[Address(RVA = "0xD588A0", Offset = "0xD574A0", VA = "0x180D588A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003190 RID: 12688
			// (get) Token: 0x06014E0A RID: 85514 RVA: 0x00088FB0 File Offset: 0x000871B0
			[Token(Token = "0x17003190")]
			public virtual bool showCharacterStatusInDummy
			{
				[Token(Token = "0x6014E0A")]
				[Address(RVA = "0xD523D0", Offset = "0xD50FD0", VA = "0x180D523D0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003191 RID: 12689
			// (get) Token: 0x06014E0B RID: 85515 RVA: 0x00088FC8 File Offset: 0x000871C8
			[Token(Token = "0x17003191")]
			public virtual bool slowMotionInCharacterMenuState
			{
				[Token(Token = "0x6014E0B")]
				[Address(RVA = "0xD52430", Offset = "0xD51030", VA = "0x180D52430", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003192 RID: 12690
			// (get) Token: 0x06014E0C RID: 85516 RVA: 0x00088FE0 File Offset: 0x000871E0
			[Token(Token = "0x17003192")]
			public virtual Vector3 hudScale
			{
				[Token(Token = "0x6014E0C")]
				[Address(RVA = "0xD522C0", Offset = "0xD50EC0", VA = "0x180D522C0", Slot = "7")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17003193 RID: 12691
			// (get) Token: 0x06014E0D RID: 85517 RVA: 0x00088FF8 File Offset: 0x000871F8
			[Token(Token = "0x17003193")]
			public virtual bool needPerspectiveAlwaysOn
			{
				[Token(Token = "0x6014E0D")]
				[Address(RVA = "0xD58920", Offset = "0xD57520", VA = "0x180D58920", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003194 RID: 12692
			// (get) Token: 0x06014E0E RID: 85518 RVA: 0x00089010 File Offset: 0x00087210
			[Token(Token = "0x17003194")]
			public virtual bool forceUpdateCharacterLevel
			{
				[Token(Token = "0x6014E0E")]
				[Address(RVA = "0xD58840", Offset = "0xD57440", VA = "0x180D58840", Slot = "9")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003195 RID: 12693
			// (get) Token: 0x06014E0F RID: 85519 RVA: 0x00089028 File Offset: 0x00087228
			[Token(Token = "0x17003195")]
			public virtual bool needReleaseIllust
			{
				[Token(Token = "0x6014E0F")]
				[Address(RVA = "0xD52370", Offset = "0xD50F70", VA = "0x180D52370", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06014E10 RID: 85520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E10")]
			[Address(RVA = "0xD582C0", Offset = "0xD56EC0", VA = "0x180D582C0", Slot = "11")]
			public virtual void OnCreate(UIController uiController)
			{
			}

			// Token: 0x06014E11 RID: 85521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E11")]
			[Address(RVA = "0xD521A0", Offset = "0xD50DA0", VA = "0x180D521A0", Slot = "12")]
			public virtual void OnInitStateMachine(UIStateMachine stateMachine)
			{
			}

			// Token: 0x06014E12 RID: 85522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E12")]
			[Address(RVA = "0xD52200", Offset = "0xD50E00", VA = "0x180D52200", Slot = "13")]
			public virtual void OnUIStateChanged(IUIStateNode stateNode)
			{
			}

			// Token: 0x06014E13 RID: 85523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E13")]
			[Address(RVA = "0xD58510", Offset = "0xD57110", VA = "0x180D58510", Slot = "14")]
			public virtual void OnGameReset(BattleController battleController)
			{
			}

			// Token: 0x06014E14 RID: 85524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E14")]
			[Address(RVA = "0xD520E0", Offset = "0xD50CE0", VA = "0x180D520E0", Slot = "15")]
			public virtual void OnGameInit(LevelData.Options levelOptions)
			{
			}

			// Token: 0x06014E15 RID: 85525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E15")]
			[Address(RVA = "0xD584B0", Offset = "0xD570B0", VA = "0x180D584B0", Slot = "16")]
			public virtual void OnGameReady()
			{
			}

			// Token: 0x06014E16 RID: 85526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E16")]
			[Address(RVA = "0xD52140", Offset = "0xD50D40", VA = "0x180D52140", Slot = "17")]
			public virtual void OnGameStart()
			{
			}

			// Token: 0x06014E17 RID: 85527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E17")]
			[Address(RVA = "0xD583F0", Offset = "0xD56FF0", VA = "0x180D583F0", Slot = "18")]
			public virtual void OnFixedUpdate(FP deltaTime)
			{
			}

			// Token: 0x06014E18 RID: 85528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E18")]
			[Address(RVA = "0xD58450", Offset = "0xD57050", VA = "0x180D58450", Slot = "19")]
			public virtual void OnGameOver(BattleController.GameResult result)
			{
			}

			// Token: 0x06014E19 RID: 85529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E19")]
			[Address(RVA = "0xD585C0", Offset = "0xD571C0", VA = "0x180D585C0", Slot = "20")]
			public virtual void OnSystemMenuCancel()
			{
			}

			// Token: 0x06014E1A RID: 85530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E1A")]
			[Address(RVA = "0xD52260", Offset = "0xD50E60", VA = "0x180D52260", Slot = "21")]
			public virtual void UpdateGameInfo()
			{
			}

			// Token: 0x06014E1B RID: 85531 RVA: 0x00089040 File Offset: 0x00087240
			[Token(Token = "0x6014E1B")]
			[Address(RVA = "0xD57EA0", Offset = "0xD56AA0", VA = "0x180D57EA0", Slot = "22")]
			public virtual bool HookGameReadyStateSwitch()
			{
				return default(bool);
			}

			// Token: 0x06014E1C RID: 85532 RVA: 0x00089058 File Offset: 0x00087258
			[Token(Token = "0x6014E1C")]
			[Address(RVA = "0xD57F00", Offset = "0xD56B00", VA = "0x180D57F00", Slot = "23")]
			public virtual bool HookGameStartStateSwitch()
			{
				return default(bool);
			}

			// Token: 0x06014E1D RID: 85533 RVA: 0x00089070 File Offset: 0x00087270
			[Token(Token = "0x6014E1D")]
			[Address(RVA = "0xD57B40", Offset = "0xD56740", VA = "0x180D57B40", Slot = "24")]
			public virtual bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
			{
				return default(bool);
			}

			// Token: 0x06014E1E RID: 85534 RVA: 0x00089088 File Offset: 0x00087288
			[Token(Token = "0x6014E1E")]
			[Address(RVA = "0xD57960", Offset = "0xD56560", VA = "0x180D57960", Slot = "25")]
			public virtual bool HookBattleAccomplishedStateSwitch()
			{
				return default(bool);
			}

			// Token: 0x06014E1F RID: 85535 RVA: 0x000890A0 File Offset: 0x000872A0
			[Token(Token = "0x6014E1F")]
			[Address(RVA = "0xD51FC0", Offset = "0xD50BC0", VA = "0x180D51FC0", Slot = "26")]
			public virtual bool HookUIShowCardState()
			{
				return default(bool);
			}

			// Token: 0x06014E20 RID: 85536 RVA: 0x000890B8 File Offset: 0x000872B8
			[Token(Token = "0x6014E20")]
			[Address(RVA = "0xD58010", Offset = "0xD56C10", VA = "0x180D58010", Slot = "27")]
			public virtual bool HookOnBattleFinishServiceStateEnter()
			{
				return default(bool);
			}

			// Token: 0x06014E21 RID: 85537 RVA: 0x000890D0 File Offset: 0x000872D0
			[Token(Token = "0x6014E21")]
			[Address(RVA = "0xD57DB0", Offset = "0xD569B0", VA = "0x180D57DB0", Slot = "28")]
			public virtual bool HookDragAndPutDownState()
			{
				return default(bool);
			}

			// Token: 0x06014E22 RID: 85538 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014E22")]
			[Address(RVA = "0xD57A80", Offset = "0xD56680", VA = "0x180D57A80", Slot = "29")]
			public virtual RectTransform HookBattleFailedPanelInit()
			{
				return null;
			}

			// Token: 0x06014E23 RID: 85539 RVA: 0x000890E8 File Offset: 0x000872E8
			[Token(Token = "0x6014E23")]
			[Address(RVA = "0xD57AE0", Offset = "0xD566E0", VA = "0x180D57AE0", Slot = "30")]
			public virtual bool HookBattleFailedPanelShow()
			{
				return default(bool);
			}

			// Token: 0x06014E24 RID: 85540 RVA: 0x00089100 File Offset: 0x00087300
			[Token(Token = "0x6014E24")]
			[Address(RVA = "0xD57A20", Offset = "0xD56620", VA = "0x180D57A20", Slot = "31")]
			public virtual bool HookBattleFailedPanelHide()
			{
				return default(bool);
			}

			// Token: 0x06014E25 RID: 85541 RVA: 0x00089118 File Offset: 0x00087318
			[Token(Token = "0x6014E25")]
			[Address(RVA = "0xD57C50", Offset = "0xD56850", VA = "0x180D57C50", Slot = "32")]
			public virtual bool HookBattleSystemMenuSwitch()
			{
				return default(bool);
			}

			// Token: 0x06014E26 RID: 85542 RVA: 0x00089130 File Offset: 0x00087330
			[Token(Token = "0x6014E26")]
			[Address(RVA = "0xD57BB0", Offset = "0xD567B0", VA = "0x180D57BB0", Slot = "33")]
			public virtual bool HookBattleFailedTips(int tipCnt, out TipData[] tipDatas)
			{
				return default(bool);
			}

			// Token: 0x06014E27 RID: 85543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014E27")]
			[Address(RVA = "0xD51ED0", Offset = "0xD50AD0", VA = "0x180D51ED0", Slot = "34")]
			public virtual UICharacterMenuState.IUICharacterMenuPanel GetHookUICharacterMenuPanel(Character character)
			{
				return null;
			}

			// Token: 0x06014E28 RID: 85544 RVA: 0x00089148 File Offset: 0x00087348
			[Token(Token = "0x6014E28")]
			[Address(RVA = "0xD57D40", Offset = "0xD56940", VA = "0x180D57D40", Slot = "35")]
			public virtual bool HookConfirmFinish(Action finishCallback)
			{
				return default(bool);
			}

			// Token: 0x06014E29 RID: 85545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E29")]
			[Address(RVA = "0xD579C0", Offset = "0xD565C0", VA = "0x180D579C0", Slot = "36")]
			public virtual void HookBattleData(CommonFinishBattleRequest.BattleData battleData)
			{
			}

			// Token: 0x06014E2A RID: 85546 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014E2A")]
			[Address(RVA = "0xD51F50", Offset = "0xD50B50", VA = "0x180D51F50", Slot = "37")]
			public virtual UICharacterInfoPanel.HookedCharacterInfoSubPanel[] HookCharacterInfoSubPanels()
			{
				return null;
			}

			// Token: 0x06014E2B RID: 85547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E2B")]
			[Address(RVA = "0xD58370", Offset = "0xD56F70", VA = "0x180D58370", Slot = "38")]
			public virtual void OnDummyTouchedToTile(Character character, Tile tile)
			{
			}

			// Token: 0x06014E2C RID: 85548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E2C")]
			[Address(RVA = "0xD52080", Offset = "0xD50C80", VA = "0x180D52080", Slot = "39")]
			public virtual void OnCharacterMenuShow(Character character)
			{
			}

			// Token: 0x06014E2D RID: 85549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E2D")]
			[Address(RVA = "0xD58260", Offset = "0xD56E60", VA = "0x180D58260", Slot = "40")]
			public virtual void OnCardMenuShow(Deck.Card card)
			{
			}

			// Token: 0x06014E2E RID: 85550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E2E")]
			[Address(RVA = "0xD52020", Offset = "0xD50C20", VA = "0x180D52020", Slot = "41")]
			public virtual void OnCharacterMenuHide()
			{
			}

			// Token: 0x06014E2F RID: 85551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E2F")]
			[Address(RVA = "0xD58620", Offset = "0xD57220", VA = "0x180D58620", Slot = "42")]
			public virtual void OnUnitBorn(Unit unit)
			{
			}

			// Token: 0x06014E30 RID: 85552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E30")]
			[Address(RVA = "0xD58720", Offset = "0xD57320", VA = "0x180D58720", Slot = "43")]
			public virtual void UpdateDisableMask(BattleFunctionDisableMask mask)
			{
			}

			// Token: 0x06014E31 RID: 85553 RVA: 0x00089160 File Offset: 0x00087360
			[Token(Token = "0x6014E31")]
			[Address(RVA = "0xD57880", Offset = "0xD56480", VA = "0x180D57880", Slot = "44")]
			public virtual bool CanPressBackButton()
			{
				return default(bool);
			}

			// Token: 0x06014E32 RID: 85554 RVA: 0x00089178 File Offset: 0x00087378
			[Token(Token = "0x6014E32")]
			[Address(RVA = "0xD58070", Offset = "0xD56C70", VA = "0x180D58070", Slot = "45")]
			public virtual bool HookPauseMask(bool isPause)
			{
				return default(bool);
			}

			// Token: 0x06014E33 RID: 85555 RVA: 0x00089190 File Offset: 0x00087390
			[Token(Token = "0x6014E33")]
			[Address(RVA = "0xD580E0", Offset = "0xD56CE0", VA = "0x180D580E0", Slot = "46")]
			public virtual bool HookPredefinedUILocation(Camera uiCam, PredefinedLocation location, out Vector3 worldPos)
			{
				return default(bool);
			}

			// Token: 0x06014E34 RID: 85556 RVA: 0x000891A8 File Offset: 0x000873A8
			[Token(Token = "0x6014E34")]
			[Address(RVA = "0xD578E0", Offset = "0xD564E0", VA = "0x180D578E0", Slot = "47")]
			public virtual bool HookBattleAccomplishPerform(out UIAnimationPerform perform)
			{
				return default(bool);
			}

			// Token: 0x06014E35 RID: 85557 RVA: 0x000891C0 File Offset: 0x000873C0
			[Token(Token = "0x6014E35")]
			[Address(RVA = "0xD57CB0", Offset = "0xD568B0", VA = "0x180D57CB0", Slot = "48")]
			public virtual bool HookCharacterInfoSubPanelSkillParse(Blackboard blackboard, BattleCharacterData data, ref string description)
			{
				return default(bool);
			}

			// Token: 0x06014E36 RID: 85558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E36")]
			[Address(RVA = "0xD58680", Offset = "0xD57280", VA = "0x180D58680", Slot = "49")]
			public virtual void ShowGameModeText(int value, Transform spawnPoint, Color color)
			{
			}

			// Token: 0x06014E37 RID: 85559 RVA: 0x000891D8 File Offset: 0x000873D8
			[Token(Token = "0x6014E37")]
			[Address(RVA = "0xD581F0", Offset = "0xD56DF0", VA = "0x180D581F0", Slot = "50")]
			public virtual bool HookShowCharacter(Character character)
			{
				return default(bool);
			}

			// Token: 0x06014E38 RID: 85560 RVA: 0x000891F0 File Offset: 0x000873F0
			[Token(Token = "0x6014E38")]
			[Address(RVA = "0xD58180", Offset = "0xD56D80", VA = "0x180D58180", Slot = "51")]
			public virtual bool HookShowCard(UICard card)
			{
				return default(bool);
			}

			// Token: 0x06014E39 RID: 85561 RVA: 0x00089208 File Offset: 0x00087408
			[Token(Token = "0x6014E39")]
			[Address(RVA = "0xD57E10", Offset = "0xD56A10", VA = "0x180D57E10", Slot = "52")]
			public virtual bool HookDragAndPutDownState(UICard card, out UIStateEnum uiState)
			{
				return default(bool);
			}

			// Token: 0x06014E3A RID: 85562 RVA: 0x00089220 File Offset: 0x00087420
			[Token(Token = "0x6014E3A")]
			[Address(RVA = "0xD57F60", Offset = "0xD56B60", VA = "0x180D57F60", Slot = "53")]
			public virtual bool HookGetProfessionImage(Image image, Deck.Card card, ObjectPtr<Character> characterPtr, UICharacterInfoPanel.ModeType mode)
			{
				return default(bool);
			}

			// Token: 0x06014E3B RID: 85563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014E3B")]
			[Address(RVA = "0xD58780", Offset = "0xD57380", VA = "0x180D58780")]
			protected Plugin()
			{
			}

			// Token: 0x04018D45 RID: 101701
			[Token(Token = "0x4018D45")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_uiController;

			// Token: 0x04018D46 RID: 101702
			[Token(Token = "0x4018D46")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_uiController;

			// Token: 0x04018D47 RID: 101703
			[Token(Token = "0x4018D47")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_battleController;

			// Token: 0x04018D48 RID: 101704
			[Token(Token = "0x4018D48")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_battleController;

			// Token: 0x04018D49 RID: 101705
			[Token(Token = "0x4018D49")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_isPaused;

			// Token: 0x04018D4A RID: 101706
			[Token(Token = "0x4018D4A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_showCharacterStatusInDummy;

			// Token: 0x04018D4B RID: 101707
			[Token(Token = "0x4018D4B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_slowMotionInCharacterMenuState;

			// Token: 0x04018D4C RID: 101708
			[Token(Token = "0x4018D4C")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_hudScale;

			// Token: 0x04018D4D RID: 101709
			[Token(Token = "0x4018D4D")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_needPerspectiveAlwaysOn;

			// Token: 0x04018D4E RID: 101710
			[Token(Token = "0x4018D4E")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_forceUpdateCharacterLevel;

			// Token: 0x04018D4F RID: 101711
			[Token(Token = "0x4018D4F")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_needReleaseIllust;

			// Token: 0x04018D50 RID: 101712
			[Token(Token = "0x4018D50")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnCreate;

			// Token: 0x04018D51 RID: 101713
			[Token(Token = "0x4018D51")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnInitStateMachine;

			// Token: 0x04018D52 RID: 101714
			[Token(Token = "0x4018D52")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_OnUIStateChanged;

			// Token: 0x04018D53 RID: 101715
			[Token(Token = "0x4018D53")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_OnGameReset;

			// Token: 0x04018D54 RID: 101716
			[Token(Token = "0x4018D54")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnGameInit;

			// Token: 0x04018D55 RID: 101717
			[Token(Token = "0x4018D55")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnGameReady;

			// Token: 0x04018D56 RID: 101718
			[Token(Token = "0x4018D56")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_OnGameStart;

			// Token: 0x04018D57 RID: 101719
			[Token(Token = "0x4018D57")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_OnFixedUpdate;

			// Token: 0x04018D58 RID: 101720
			[Token(Token = "0x4018D58")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_OnGameOver;

			// Token: 0x04018D59 RID: 101721
			[Token(Token = "0x4018D59")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_OnSystemMenuCancel;

			// Token: 0x04018D5A RID: 101722
			[Token(Token = "0x4018D5A")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_UpdateGameInfo;

			// Token: 0x04018D5B RID: 101723
			[Token(Token = "0x4018D5B")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_HookGameReadyStateSwitch;

			// Token: 0x04018D5C RID: 101724
			[Token(Token = "0x4018D5C")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0_HookGameStartStateSwitch;

			// Token: 0x04018D5D RID: 101725
			[Token(Token = "0x4018D5D")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

			// Token: 0x04018D5E RID: 101726
			[Token(Token = "0x4018D5E")]
			[FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_HookBattleAccomplishedStateSwitch;

			// Token: 0x04018D5F RID: 101727
			[Token(Token = "0x4018D5F")]
			[FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_HookUIShowCardState;

			// Token: 0x04018D60 RID: 101728
			[Token(Token = "0x4018D60")]
			[FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_HookOnBattleFinishServiceStateEnter;

			// Token: 0x04018D61 RID: 101729
			[Token(Token = "0x4018D61")]
			[FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0_HookDragAndPutDownState;

			// Token: 0x04018D62 RID: 101730
			[Token(Token = "0x4018D62")]
			[FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_HookBattleFailedPanelInit;

			// Token: 0x04018D63 RID: 101731
			[Token(Token = "0x4018D63")]
			[FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_HookBattleFailedPanelShow;

			// Token: 0x04018D64 RID: 101732
			[Token(Token = "0x4018D64")]
			[FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_HookBattleFailedPanelHide;

			// Token: 0x04018D65 RID: 101733
			[Token(Token = "0x4018D65")]
			[FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_HookBattleSystemMenuSwitch;

			// Token: 0x04018D66 RID: 101734
			[Token(Token = "0x4018D66")]
			[FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_HookBattleFailedTips;

			// Token: 0x04018D67 RID: 101735
			[Token(Token = "0x4018D67")]
			[FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0_GetHookUICharacterMenuPanel;

			// Token: 0x04018D68 RID: 101736
			[Token(Token = "0x4018D68")]
			[FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_HookConfirmFinish;

			// Token: 0x04018D69 RID: 101737
			[Token(Token = "0x4018D69")]
			[FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_HookBattleData;

			// Token: 0x04018D6A RID: 101738
			[Token(Token = "0x4018D6A")]
			[FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_HookCharacterInfoSubPanels;

			// Token: 0x04018D6B RID: 101739
			[Token(Token = "0x4018D6B")]
			[FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_OnDummyTouchedToTile;

			// Token: 0x04018D6C RID: 101740
			[Token(Token = "0x4018D6C")]
			[FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0_OnCharacterMenuShow;

			// Token: 0x04018D6D RID: 101741
			[Token(Token = "0x4018D6D")]
			[FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0_OnCardMenuShow;

			// Token: 0x04018D6E RID: 101742
			[Token(Token = "0x4018D6E")]
			[FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_OnCharacterMenuHide;

			// Token: 0x04018D6F RID: 101743
			[Token(Token = "0x4018D6F")]
			[FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_OnUnitBorn;

			// Token: 0x04018D70 RID: 101744
			[Token(Token = "0x4018D70")]
			[FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0_UpdateDisableMask;

			// Token: 0x04018D71 RID: 101745
			[Token(Token = "0x4018D71")]
			[FieldOffset(Offset = "0x160")]
			private static DelegateBridge __Hotfix0_CanPressBackButton;

			// Token: 0x04018D72 RID: 101746
			[Token(Token = "0x4018D72")]
			[FieldOffset(Offset = "0x168")]
			private static DelegateBridge __Hotfix0_HookPauseMask;

			// Token: 0x04018D73 RID: 101747
			[Token(Token = "0x4018D73")]
			[FieldOffset(Offset = "0x170")]
			private static DelegateBridge __Hotfix0_HookPredefinedUILocation;

			// Token: 0x04018D74 RID: 101748
			[Token(Token = "0x4018D74")]
			[FieldOffset(Offset = "0x178")]
			private static DelegateBridge __Hotfix0_HookBattleAccomplishPerform;

			// Token: 0x04018D75 RID: 101749
			[Token(Token = "0x4018D75")]
			[FieldOffset(Offset = "0x180")]
			private static DelegateBridge __Hotfix0_HookCharacterInfoSubPanelSkillParse;

			// Token: 0x04018D76 RID: 101750
			[Token(Token = "0x4018D76")]
			[FieldOffset(Offset = "0x188")]
			private static DelegateBridge __Hotfix0_ShowGameModeText;

			// Token: 0x04018D77 RID: 101751
			[Token(Token = "0x4018D77")]
			[FieldOffset(Offset = "0x190")]
			private static DelegateBridge __Hotfix0_HookShowCharacter;

			// Token: 0x04018D78 RID: 101752
			[Token(Token = "0x4018D78")]
			[FieldOffset(Offset = "0x198")]
			private static DelegateBridge __Hotfix0_HookShowCard;

			// Token: 0x04018D79 RID: 101753
			[Token(Token = "0x4018D79")]
			[FieldOffset(Offset = "0x1A0")]
			private static DelegateBridge __Hotfix1_HookDragAndPutDownState;

			// Token: 0x04018D7A RID: 101754
			[Token(Token = "0x4018D7A")]
			[FieldOffset(Offset = "0x1A8")]
			private static DelegateBridge __Hotfix0_HookGetProfessionImage;

			// Token: 0x04018D7B RID: 101755
			[Token(Token = "0x4018D7B")]
			[FieldOffset(Offset = "0x1B0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200332D RID: 13101
		[Token(Token = "0x200332D")]
		public enum Event
		{
			// Token: 0x04018D7D RID: 101757
			[Token(Token = "0x4018D7D")]
			ON_BOTTOM_MASK_CLICKED,
			// Token: 0x04018D7E RID: 101758
			[Token(Token = "0x4018D7E")]
			ON_BOTTOM_MASK_DOWN,
			// Token: 0x04018D7F RID: 101759
			[Token(Token = "0x4018D7F")]
			ON_BOTTOM_MASK_UP,
			// Token: 0x04018D80 RID: 101760
			[Token(Token = "0x4018D80")]
			ON_CARD_BEGIN_DRAG,
			// Token: 0x04018D81 RID: 101761
			[Token(Token = "0x4018D81")]
			ON_CARD_END_DRAG,
			// Token: 0x04018D82 RID: 101762
			[Token(Token = "0x4018D82")]
			ON_CARD_TOGGLED,
			// Token: 0x04018D83 RID: 101763
			[Token(Token = "0x4018D83")]
			ON_TILE_CLICKED,
			// Token: 0x04018D84 RID: 101764
			[Token(Token = "0x4018D84")]
			ON_STATE_CHANGED,
			// Token: 0x04018D85 RID: 101765
			[Token(Token = "0x4018D85")]
			PLUGIN_EVENT_0,
			// Token: 0x04018D86 RID: 101766
			[Token(Token = "0x4018D86")]
			PLUGIN_EVENT_1,
			// Token: 0x04018D87 RID: 101767
			[Token(Token = "0x4018D87")]
			PLUGIN_EVENT_2,
			// Token: 0x04018D88 RID: 101768
			[Token(Token = "0x4018D88")]
			PLUGIN_EVENT_3,
			// Token: 0x04018D89 RID: 101769
			[Token(Token = "0x4018D89")]
			PLUGIN_EVENT_4,
			// Token: 0x04018D8A RID: 101770
			[Token(Token = "0x4018D8A")]
			PLUGIN_EVENT_5,
			// Token: 0x04018D8B RID: 101771
			[Token(Token = "0x4018D8B")]
			PLUGIN_EVENT_6,
			// Token: 0x04018D8C RID: 101772
			[Token(Token = "0x4018D8C")]
			PLUGIN_EVENT_7,
			// Token: 0x04018D8D RID: 101773
			[Token(Token = "0x4018D8D")]
			PLUGIN_EVENT_8,
			// Token: 0x04018D8E RID: 101774
			[Token(Token = "0x4018D8E")]
			PLUGIN_EVENT_9,
			// Token: 0x04018D8F RID: 101775
			[Token(Token = "0x4018D8F")]
			ON_BOTTOM_MASK_DRAG,
			// Token: 0x04018D90 RID: 101776
			[Token(Token = "0x4018D90")]
			ON_BOTTOM_MASK_BEGIN_DRAG,
			// Token: 0x04018D91 RID: 101777
			[Token(Token = "0x4018D91")]
			ON_BOTTOM_MASK_END_DRAG,
			// Token: 0x04018D92 RID: 101778
			[Token(Token = "0x4018D92")]
			ON_CHAR_MENU_ENTER,
			// Token: 0x04018D93 RID: 101779
			[Token(Token = "0x4018D93")]
			ON_CHAR_MENU_EXIT,
			// Token: 0x04018D94 RID: 101780
			[Token(Token = "0x4018D94")]
			ON_CARD_MENU_ENTER,
			// Token: 0x04018D95 RID: 101781
			[Token(Token = "0x4018D95")]
			ON_CARD_MENU_EXIT,
			// Token: 0x04018D96 RID: 101782
			[Token(Token = "0x4018D96")]
			E_NUM
		}

		// Token: 0x0200332E RID: 13102
		[Token(Token = "0x200332E")]
		public enum RtUIPluginPosition
		{
			// Token: 0x04018D98 RID: 101784
			[Token(Token = "0x4018D98")]
			COST_PANAL,
			// Token: 0x04018D99 RID: 101785
			[Token(Token = "0x4018D99")]
			TOP_BAR
		}
	}
}
