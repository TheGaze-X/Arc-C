using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002817 RID: 10263
	[Token(Token = "0x2002817")]
	public class DialogPanel : DialogExecutorBase
	{
		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x0601112F RID: 69935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025A6")]
		public DialogViewData viewData
		{
			[Token(Token = "0x601112F")]
			[Address(RVA = "0x8F8140", Offset = "0x8F6D40", VA = "0x1808F8140")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x06011130 RID: 69936 RVA: 0x00069348 File Offset: 0x00067548
		// (set) Token: 0x06011131 RID: 69937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025A7")]
		private int taskCnt
		{
			[Token(Token = "0x6011130")]
			[Address(RVA = "0x8F8060", Offset = "0x8F6C60", VA = "0x1808F8060")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6011131")]
			[Address(RVA = "0x8F81C0", Offset = "0x8F6DC0", VA = "0x1808F81C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x06011132 RID: 69938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025A8")]
		public DialogPlaybackPanel playbackPanel
		{
			[Token(Token = "0x6011132")]
			[Address(RVA = "0x8F7FE0", Offset = "0x8F6BE0", VA = "0x1808F7FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011133 RID: 69939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011133")]
		[Address(RVA = "0x8F4350", Offset = "0x8F2F50", VA = "0x1808F4350")]
		private void _AttachPluginExecutors()
		{
		}

		// Token: 0x06011134 RID: 69940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011134")]
		[Address(RVA = "0x8F5F30", Offset = "0x8F4B30", VA = "0x1808F5F30")]
		private void _InitPluginIfNot()
		{
		}

		// Token: 0x06011135 RID: 69941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011135")]
		[Address(RVA = "0x8F7E40", Offset = "0x8F6A40", VA = "0x1808F7E40")]
		public DialogPanel()
		{
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x06011136 RID: 69942 RVA: 0x00069360 File Offset: 0x00067560
		[Token(Token = "0x170025A9")]
		public override BattleDialogType type
		{
			[Token(Token = "0x6011136")]
			[Address(RVA = "0x8F80D0", Offset = "0x8F6CD0", VA = "0x1808F80D0", Slot = "4")]
			get
			{
				return BattleDialogType.NONE;
			}
		}

		// Token: 0x06011137 RID: 69943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011137")]
		[Address(RVA = "0x8F3C70", Offset = "0x8F2870", VA = "0x1808F3C70", Slot = "6")]
		public override void Init()
		{
		}

		// Token: 0x06011138 RID: 69944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011138")]
		[Address(RVA = "0x8F6270", Offset = "0x8F4E70", VA = "0x1808F6270")]
		private void _PrepareMainUI()
		{
		}

		// Token: 0x06011139 RID: 69945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011139")]
		[Address(RVA = "0x8F3FF0", Offset = "0x8F2BF0", VA = "0x1808F3FF0", Slot = "7")]
		public override void StartSignal(BattleDialogParam param)
		{
		}

		// Token: 0x0601113A RID: 69946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601113A")]
		[Address(RVA = "0x8F7B00", Offset = "0x8F6700", VA = "0x1808F7B00")]
		private IEnumerator _UpdateCommandData(int decision = -1, bool isSkip = false)
		{
			return null;
		}

		// Token: 0x0601113B RID: 69947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601113B")]
		[Address(RVA = "0x8F7A40", Offset = "0x8F6640", VA = "0x1808F7A40")]
		private IEnumerator _RenderView()
		{
			return null;
		}

		// Token: 0x0601113C RID: 69948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601113C")]
		[Address(RVA = "0x8F6DB0", Offset = "0x8F59B0", VA = "0x1808F6DB0")]
		private void _RenderDefault()
		{
		}

		// Token: 0x0601113D RID: 69949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601113D")]
		[Address(RVA = "0x8F4D10", Offset = "0x8F3910", VA = "0x1808F4D10")]
		private IEnumerator _DoFadeIn()
		{
			return null;
		}

		// Token: 0x0601113E RID: 69950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601113E")]
		[Address(RVA = "0x8F4DD0", Offset = "0x8F39D0", VA = "0x1808F4DD0")]
		private IEnumerator _DoFadeOut()
		{
			return null;
		}

		// Token: 0x0601113F RID: 69951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601113F")]
		[Address(RVA = "0x8F73B0", Offset = "0x8F5FB0", VA = "0x1808F73B0")]
		private void _RenderOptions()
		{
		}

		// Token: 0x06011140 RID: 69952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011140")]
		[Address(RVA = "0x8F71E0", Offset = "0x8F5DE0", VA = "0x1808F71E0")]
		private void _RenderName()
		{
		}

		// Token: 0x06011141 RID: 69953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011141")]
		[Address(RVA = "0x8F6F80", Offset = "0x8F5B80", VA = "0x1808F6F80")]
		private void _RenderLogPanel()
		{
		}

		// Token: 0x06011142 RID: 69954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011142")]
		[Address(RVA = "0x8F78F0", Offset = "0x8F64F0", VA = "0x1808F78F0")]
		private void _RenderSkipButton()
		{
		}

		// Token: 0x06011143 RID: 69955 RVA: 0x00069378 File Offset: 0x00067578
		[Token(Token = "0x6011143")]
		[Address(RVA = "0x8F5350", Offset = "0x8F3F50", VA = "0x1808F5350")]
		public bool _EndProcess()
		{
			return default(bool);
		}

		// Token: 0x06011144 RID: 69956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011144")]
		[Address(RVA = "0x8F4A00", Offset = "0x8F3600", VA = "0x1808F4A00")]
		private void _CompleteTweens()
		{
		}

		// Token: 0x06011145 RID: 69957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011145")]
		[Address(RVA = "0x8F65E0", Offset = "0x8F51E0", VA = "0x1808F65E0")]
		private void _RenderAvatar()
		{
		}

		// Token: 0x06011146 RID: 69958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011146")]
		[Address(RVA = "0x8F5DA0", Offset = "0x8F49A0", VA = "0x1808F5DA0")]
		private void _FadeGraphic(Graphic slot, float alpha)
		{
		}

		// Token: 0x06011147 RID: 69959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011147")]
		[Address(RVA = "0x8F5C10", Offset = "0x8F4810", VA = "0x1808F5C10")]
		private void _FadeCanvasGroup(CanvasGroup slot, float alpha)
		{
		}

		// Token: 0x06011148 RID: 69960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011148")]
		[Address(RVA = "0x8F6AD0", Offset = "0x8F56D0", VA = "0x1808F6AD0")]
		private void _RenderContent()
		{
		}

		// Token: 0x06011149 RID: 69961 RVA: 0x00069390 File Offset: 0x00067590
		[Token(Token = "0x6011149")]
		[Address(RVA = "0x8F4950", Offset = "0x8F3550", VA = "0x1808F4950")]
		private bool _CommandIs(string val)
		{
			return default(bool);
		}

		// Token: 0x0601114A RID: 69962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601114A")]
		[Address(RVA = "0x8F61B0", Offset = "0x8F4DB0", VA = "0x1808F61B0")]
		private void _OnTypeEnd()
		{
		}

		// Token: 0x0601114B RID: 69963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601114B")]
		[Address(RVA = "0x8F4FC0", Offset = "0x8F3BC0", VA = "0x1808F4FC0")]
		private void _EnableGraphic(string target, bool enable, bool withoutFade = false)
		{
		}

		// Token: 0x0601114C RID: 69964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601114C")]
		[Address(RVA = "0x8F3F40", Offset = "0x8F2B40", VA = "0x1808F3F40")]
		public void OnSkipClicked()
		{
		}

		// Token: 0x0601114D RID: 69965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601114D")]
		[Address(RVA = "0x8F3E70", Offset = "0x8F2A70", VA = "0x1808F3E70")]
		public void OnMaskClicked()
		{
		}

		// Token: 0x0601114E RID: 69966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601114E")]
		[Address(RVA = "0x8F3DB0", Offset = "0x8F29B0", VA = "0x1808F3DB0")]
		public void OnDisplayLogClicked()
		{
		}

		// Token: 0x0601114F RID: 69967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601114F")]
		[Address(RVA = "0x8F38B0", Offset = "0x8F24B0", VA = "0x1808F38B0", Slot = "5")]
		public override Dictionary<string, BattleStoryTree.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06011150 RID: 69968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011150")]
		[Address(RVA = "0x8F4E90", Offset = "0x8F3A90", VA = "0x1808F4E90")]
		private void _DoUpdateNextCommandAndUpdateView(bool isSkip = false)
		{
		}

		// Token: 0x06011151 RID: 69969 RVA: 0x000693A8 File Offset: 0x000675A8
		[Token(Token = "0x6011151")]
		[Address(RVA = "0x8F5AF0", Offset = "0x8F46F0", VA = "0x1808F5AF0")]
		private bool _ExecuteUIOperation(Command command)
		{
			return default(bool);
		}

		// Token: 0x06011152 RID: 69970 RVA: 0x000693C0 File Offset: 0x000675C0
		[Token(Token = "0x6011152")]
		[Address(RVA = "0x8F5640", Offset = "0x8F4240", VA = "0x1808F5640")]
		private bool _ExecuteDelay(Command command)
		{
			return default(bool);
		}

		// Token: 0x06011153 RID: 69971 RVA: 0x000693D8 File Offset: 0x000675D8
		[Token(Token = "0x6011153")]
		[Address(RVA = "0x8F5A60", Offset = "0x8F4660", VA = "0x1808F5A60")]
		private bool _ExecuteHeader(Command command)
		{
			return default(bool);
		}

		// Token: 0x06011154 RID: 69972 RVA: 0x000693F0 File Offset: 0x000675F0
		[Token(Token = "0x6011154")]
		[Address(RVA = "0x8F5710", Offset = "0x8F4310", VA = "0x1808F5710")]
		private bool _ExecuteDialog(Command command)
		{
			return default(bool);
		}

		// Token: 0x06011155 RID: 69973 RVA: 0x00069408 File Offset: 0x00067608
		[Token(Token = "0x6011155")]
		[Address(RVA = "0x8F5400", Offset = "0x8F4000", VA = "0x1808F5400")]
		private bool _ExecuteDecision(Command command)
		{
			return default(bool);
		}

		// Token: 0x06011156 RID: 69974 RVA: 0x00069420 File Offset: 0x00067620
		[Token(Token = "0x6011156")]
		[Address(RVA = "0x8F59D0", Offset = "0x8F45D0", VA = "0x1808F59D0")]
		private bool _ExecuteEnd(Command command)
		{
			return default(bool);
		}

		// Token: 0x06011157 RID: 69975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011157")]
		[Address(RVA = "0x8F6100", Offset = "0x8F4D00", VA = "0x1808F6100")]
		private void _OnExecuteCommand(Command command)
		{
		}

		// Token: 0x06011158 RID: 69976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011158")]
		[Address(RVA = "0x8F4220", Offset = "0x8F2E20", VA = "0x1808F4220")]
		private void Update()
		{
		}

		// Token: 0x06011159 RID: 69977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011159")]
		[Address(RVA = "0x8F3D10", Offset = "0x8F2910", VA = "0x1808F3D10")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601115D RID: 69981 RVA: 0x00069438 File Offset: 0x00067638
		[Token(Token = "0x601115D")]
		[Address(RVA = "0x8F3850", Offset = "0x8F2450", VA = "0x1808F3850")]
		private BattleDialogType <>xLuaBaseProxy_get_type()
		{
			return BattleDialogType.NONE;
		}

		// Token: 0x0601115E RID: 69982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601115E")]
		[Address(RVA = "0x8F35F0", Offset = "0x8F21F0", VA = "0x1808F35F0")]
		private void <>xLuaBaseProxy_Init()
		{
		}

		// Token: 0x0601115F RID: 69983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601115F")]
		[Address(RVA = "0x8F3650", Offset = "0x8F2250", VA = "0x1808F3650")]
		private void <>xLuaBaseProxy_StartSignal(BattleDialogParam P0)
		{
		}

		// Token: 0x06011160 RID: 69984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011160")]
		[Address(RVA = "0x8F40D0", Offset = "0x8F2CD0", VA = "0x1808F40D0")]
		private Dictionary<string, BattleStoryTree.Executor> <>xLuaBaseProxy_GetExecutors()
		{
			return null;
		}

		// Token: 0x0401320D RID: 78349
		[Token(Token = "0x401320D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _skipButton;

		// Token: 0x0401320E RID: 78350
		[Token(Token = "0x401320E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Name")]
		private Text _charNameText;

		// Token: 0x0401320F RID: 78351
		[Token(Token = "0x401320F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Name")]
		private CanvasGroup _charNameRoot;

		// Token: 0x04013210 RID: 78352
		[Token(Token = "0x4013210")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Content")]
		private Transform _contentLeftMount;

		// Token: 0x04013211 RID: 78353
		[Token(Token = "0x4013211")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Content")]
		private Transform _contentRightMount;

		// Token: 0x04013212 RID: 78354
		[Token(Token = "0x4013212")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Content")]
		private GameObject _blockMask;

		// Token: 0x04013213 RID: 78355
		[Token(Token = "0x4013213")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Content")]
		private EventTrigger _mask;

		// Token: 0x04013214 RID: 78356
		[Token(Token = "0x4013214")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Content")]
		private AVGTypeWriterText _contentTypeWriter;

		// Token: 0x04013215 RID: 78357
		[Token(Token = "0x4013215")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Content")]
		private GameObject _contentDeco;

		// Token: 0x04013216 RID: 78358
		[Token(Token = "0x4013216")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Avatar Slot")]
		private UIAtlasImage _avatarEmpty;

		// Token: 0x04013217 RID: 78359
		[Token(Token = "0x4013217")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Avatar Slot")]
		private Image _avatar;

		// Token: 0x04013218 RID: 78360
		[Token(Token = "0x4013218")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Avatar Slot")]
		private Transform _avatarLeftMount;

		// Token: 0x04013219 RID: 78361
		[Token(Token = "0x4013219")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Avatar Slot")]
		private Transform _avatarRightMount;

		// Token: 0x0401321A RID: 78362
		[Token(Token = "0x401321A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0401321B RID: 78363
		[Token(Token = "0x401321B")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _fadeInDuration;

		// Token: 0x0401321C RID: 78364
		[Token(Token = "0x401321C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _fadeOutDuration;

		// Token: 0x0401321D RID: 78365
		[Token(Token = "0x401321D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Opt Button")]
		private DialogDecisionButton _optButtonPrefab;

		// Token: 0x0401321E RID: 78366
		[Token(Token = "0x401321E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Opt Button")]
		private CanvasGroup _optButtonRoot;

		// Token: 0x0401321F RID: 78367
		[Token(Token = "0x401321F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Playback Panel")]
		private DialogPlaybackPanel _playbackPanel;

		// Token: 0x04013220 RID: 78368
		[Token(Token = "0x4013220")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private AnimationWrapper _entryAnimationWrapper;

		// Token: 0x04013221 RID: 78369
		[Token(Token = "0x4013221")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private Ease _entryEase;

		// Token: 0x04013222 RID: 78370
		[Token(Token = "0x4013222")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Animation Wrapper")]
		private AnimationWrapper _decisionAnimationWrapper;

		// Token: 0x04013223 RID: 78371
		[Token(Token = "0x4013223")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform _pluginRoot;

		// Token: 0x04013224 RID: 78372
		[Token(Token = "0x4013224")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CanvasGroup _dialogContent;

		// Token: 0x04013225 RID: 78373
		[Token(Token = "0x4013225")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _fastActionDialog;

		// Token: 0x04013226 RID: 78374
		[Token(Token = "0x4013226")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private List<DialogPanel.UIOperationTarget> _uiOperationTargets;

		// Token: 0x04013227 RID: 78375
		[Token(Token = "0x4013227")]
		[FieldOffset(Offset = "0xE0")]
		private AlphaSplitImageHolder m_characterImgHolderF;

		// Token: 0x04013228 RID: 78376
		[Token(Token = "0x4013228")]
		[FieldOffset(Offset = "0xE8")]
		private AlphaSplitImageHolder m_characterImgHolderB;

		// Token: 0x04013229 RID: 78377
		[Token(Token = "0x4013229")]
		[FieldOffset(Offset = "0xF0")]
		private List<DialogDecisionButton> m_optButton;

		// Token: 0x0401322A RID: 78378
		[Token(Token = "0x401322A")]
		[FieldOffset(Offset = "0xF8")]
		private Coroutine m_mainCoroutine;

		// Token: 0x0401322B RID: 78379
		[Token(Token = "0x401322B")]
		[FieldOffset(Offset = "0x100")]
		private DialogViewData m_viewData;

		// Token: 0x0401322C RID: 78380
		[Token(Token = "0x401322C")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly List<string> FLOW_COMMAND;

		// Token: 0x0401322D RID: 78381
		[Token(Token = "0x401322D")]
		[FieldOffset(Offset = "0x8")]
		[HideInInspector]
		public static readonly List<string> BLOCK_COMMAND;

		// Token: 0x0401322E RID: 78382
		[Token(Token = "0x401322E")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public static readonly List<string> BLOCK_COMMAND_NOT_SKIPPABLE;

		// Token: 0x04013230 RID: 78384
		[Token(Token = "0x4013230")]
		public const string EMPTY_CHAR = "char_empty_b";

		// Token: 0x04013231 RID: 78385
		[Token(Token = "0x4013231")]
		private const string DIALOG_ENTRY = "dialog_entry";

		// Token: 0x04013232 RID: 78386
		[Token(Token = "0x4013232")]
		private const string DIALOG_DECISION = "dialog_decision";

		// Token: 0x04013233 RID: 78387
		[Token(Token = "0x4013233")]
		[FieldOffset(Offset = "0x110")]
		private List<DialogPanel.IPlugin> m_plugins;

		// Token: 0x04013234 RID: 78388
		[Token(Token = "0x4013234")]
		[FieldOffset(Offset = "0x118")]
		private bool m_pluginInited;

		// Token: 0x04013235 RID: 78389
		[Token(Token = "0x4013235")]
		[FieldOffset(Offset = "0x120")]
		[NonSerialized]
		public Action onSkipClicked;

		// Token: 0x04013236 RID: 78390
		[Token(Token = "0x4013236")]
		[FieldOffset(Offset = "0x128")]
		[NonSerialized]
		public Action onMaskClicked;

		// Token: 0x04013237 RID: 78391
		[Token(Token = "0x4013237")]
		[FieldOffset(Offset = "0x130")]
		[NonSerialized]
		public Action<int> onOptSelected;

		// Token: 0x04013238 RID: 78392
		[Token(Token = "0x4013238")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<string, BattleStoryTree.Executor> m_executor;

		// Token: 0x04013239 RID: 78393
		[Token(Token = "0x4013239")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_viewData;

		// Token: 0x0401323A RID: 78394
		[Token(Token = "0x401323A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_taskCnt;

		// Token: 0x0401323B RID: 78395
		[Token(Token = "0x401323B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_taskCnt;

		// Token: 0x0401323C RID: 78396
		[Token(Token = "0x401323C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_playbackPanel;

		// Token: 0x0401323D RID: 78397
		[Token(Token = "0x401323D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AttachPluginExecutors;

		// Token: 0x0401323E RID: 78398
		[Token(Token = "0x401323E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitPluginIfNot;

		// Token: 0x0401323F RID: 78399
		[Token(Token = "0x401323F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013240 RID: 78400
		[Token(Token = "0x4013240")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04013241 RID: 78401
		[Token(Token = "0x4013241")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013242 RID: 78402
		[Token(Token = "0x4013242")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PrepareMainUI;

		// Token: 0x04013243 RID: 78403
		[Token(Token = "0x4013243")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_StartSignal;

		// Token: 0x04013244 RID: 78404
		[Token(Token = "0x4013244")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateCommandData;

		// Token: 0x04013245 RID: 78405
		[Token(Token = "0x4013245")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x04013246 RID: 78406
		[Token(Token = "0x4013246")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderDefault;

		// Token: 0x04013247 RID: 78407
		[Token(Token = "0x4013247")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__DoFadeIn;

		// Token: 0x04013248 RID: 78408
		[Token(Token = "0x4013248")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__DoFadeOut;

		// Token: 0x04013249 RID: 78409
		[Token(Token = "0x4013249")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RenderOptions;

		// Token: 0x0401324A RID: 78410
		[Token(Token = "0x401324A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RenderName;

		// Token: 0x0401324B RID: 78411
		[Token(Token = "0x401324B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RenderLogPanel;

		// Token: 0x0401324C RID: 78412
		[Token(Token = "0x401324C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__RenderSkipButton;

		// Token: 0x0401324D RID: 78413
		[Token(Token = "0x401324D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EndProcess;

		// Token: 0x0401324E RID: 78414
		[Token(Token = "0x401324E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CompleteTweens;

		// Token: 0x0401324F RID: 78415
		[Token(Token = "0x401324F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RenderAvatar;

		// Token: 0x04013250 RID: 78416
		[Token(Token = "0x4013250")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__FadeGraphic;

		// Token: 0x04013251 RID: 78417
		[Token(Token = "0x4013251")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__FadeCanvasGroup;

		// Token: 0x04013252 RID: 78418
		[Token(Token = "0x4013252")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RenderContent;

		// Token: 0x04013253 RID: 78419
		[Token(Token = "0x4013253")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CommandIs;

		// Token: 0x04013254 RID: 78420
		[Token(Token = "0x4013254")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnTypeEnd;

		// Token: 0x04013255 RID: 78421
		[Token(Token = "0x4013255")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__EnableGraphic;

		// Token: 0x04013256 RID: 78422
		[Token(Token = "0x4013256")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnSkipClicked;

		// Token: 0x04013257 RID: 78423
		[Token(Token = "0x4013257")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnMaskClicked;

		// Token: 0x04013258 RID: 78424
		[Token(Token = "0x4013258")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnDisplayLogClicked;

		// Token: 0x04013259 RID: 78425
		[Token(Token = "0x4013259")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0401325A RID: 78426
		[Token(Token = "0x401325A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__DoUpdateNextCommandAndUpdateView;

		// Token: 0x0401325B RID: 78427
		[Token(Token = "0x401325B")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ExecuteUIOperation;

		// Token: 0x0401325C RID: 78428
		[Token(Token = "0x401325C")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__ExecuteDelay;

		// Token: 0x0401325D RID: 78429
		[Token(Token = "0x401325D")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__ExecuteHeader;

		// Token: 0x0401325E RID: 78430
		[Token(Token = "0x401325E")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__ExecuteDialog;

		// Token: 0x0401325F RID: 78431
		[Token(Token = "0x401325F")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__ExecuteDecision;

		// Token: 0x04013260 RID: 78432
		[Token(Token = "0x4013260")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__ExecuteEnd;

		// Token: 0x04013261 RID: 78433
		[Token(Token = "0x4013261")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__OnExecuteCommand;

		// Token: 0x04013262 RID: 78434
		[Token(Token = "0x4013262")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04013263 RID: 78435
		[Token(Token = "0x4013263")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x02002818 RID: 10264
		[Token(Token = "0x2002818")]
		[Serializable]
		public class UIOperationTarget
		{
			// Token: 0x06011161 RID: 69985 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011161")]
			[Address(RVA = "0x9015C0", Offset = "0x9001C0", VA = "0x1809015C0")]
			public void OnEnable(bool enable = false, bool force = false)
			{
			}

			// Token: 0x06011162 RID: 69986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011162")]
			[Address(RVA = "0x9014E0", Offset = "0x9000E0", VA = "0x1809014E0", Slot = "4")]
			public virtual void OnComplete()
			{
			}

			// Token: 0x06011163 RID: 69987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011163")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UIOperationTarget()
			{
			}

			// Token: 0x04013264 RID: 78436
			[Token(Token = "0x4013264")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04013265 RID: 78437
			[Token(Token = "0x4013265")]
			[FieldOffset(Offset = "0x18")]
			public CanvasGroup[] targetCanvas;

			// Token: 0x04013266 RID: 78438
			[Token(Token = "0x4013266")]
			[FieldOffset(Offset = "0x20")]
			public Graphic[] targetGraphic;

			// Token: 0x04013267 RID: 78439
			[Token(Token = "0x4013267")]
			[FieldOffset(Offset = "0x28")]
			public AnimationWrapper wrapper;

			// Token: 0x04013268 RID: 78440
			[Token(Token = "0x4013268")]
			[FieldOffset(Offset = "0x30")]
			public string clipName;

			// Token: 0x04013269 RID: 78441
			[Token(Token = "0x4013269")]
			[FieldOffset(Offset = "0x38")]
			public Ease fadeOutEase;

			// Token: 0x0401326A RID: 78442
			[Token(Token = "0x401326A")]
			[FieldOffset(Offset = "0x3C")]
			public float fadeOutTime;

			// Token: 0x0401326B RID: 78443
			[Token(Token = "0x401326B")]
			[FieldOffset(Offset = "0x40")]
			public CanvasGroup mainCanvas;

			// Token: 0x0401326C RID: 78444
			[Token(Token = "0x401326C")]
			[FieldOffset(Offset = "0x48")]
			[NonSerialized]
			public bool isEnabled;
		}

		// Token: 0x02002819 RID: 10265
		[Token(Token = "0x2002819")]
		public interface IPlugin
		{
			// Token: 0x06011164 RID: 69988
			[Token(Token = "0x6011164")]
			Dictionary<string, BattleStoryTree.Executor> GetExecutors();
		}
	}
}
