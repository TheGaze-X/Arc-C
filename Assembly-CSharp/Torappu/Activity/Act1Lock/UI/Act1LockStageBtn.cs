using System;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078C1 RID: 30913
	[Token(Token = "0x20078C1")]
	public class Act1LockStageBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B59F RID: 177567 RVA: 0x000DB780 File Offset: 0x000D9980
		[Token(Token = "0x602B59F")]
		[Address(RVA = "0x2731C90", Offset = "0x2730890", VA = "0x182731C90")]
		public bool RenderStageBtn(Act1LockStageViewModel stageViewModel, [Optional] string selectedStageId)
		{
			return default(bool);
		}

		// Token: 0x0602B5A0 RID: 177568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5A0")]
		[Address(RVA = "0x2732100", Offset = "0x2730D00", VA = "0x182732100")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B5A1 RID: 177569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5A1")]
		[Address(RVA = "0x2732170", Offset = "0x2730D70", VA = "0x182732170")]
		private void _RenderBtn(Act1LockStageViewModel stageViewModel)
		{
		}

		// Token: 0x0602B5A2 RID: 177570 RVA: 0x000DB798 File Offset: 0x000D9998
		[Token(Token = "0x602B5A2")]
		[Address(RVA = "0x27329F0", Offset = "0x27315F0", VA = "0x1827329F0")]
		private bool _TryLockStage()
		{
			return default(bool);
		}

		// Token: 0x0602B5A3 RID: 177571 RVA: 0x000DB7B0 File Offset: 0x000D99B0
		[Token(Token = "0x602B5A3")]
		[Address(RVA = "0x2732060", Offset = "0x2730C60", VA = "0x182732060")]
		private bool _CheckStageLocked(Act1LockStageViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0602B5A4 RID: 177572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5A4")]
		[Address(RVA = "0x2732650", Offset = "0x2731250", VA = "0x182732650")]
		private void _RenderInterLockInfo()
		{
		}

		// Token: 0x0602B5A5 RID: 177573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5A5")]
		[Address(RVA = "0x27323D0", Offset = "0x2730FD0", VA = "0x1827323D0")]
		private void _RenderFinalInfo()
		{
		}

		// Token: 0x0602B5A6 RID: 177574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5A6")]
		[Address(RVA = "0x2731C10", Offset = "0x2730810", VA = "0x182731C10")]
		public void OnEventClick()
		{
		}

		// Token: 0x1700656E RID: 25966
		// (get) Token: 0x0602B5A7 RID: 177575 RVA: 0x000DB7C8 File Offset: 0x000D99C8
		[Token(Token = "0x1700656E")]
		public ActivityInterlockData.InterlockStageType stageType
		{
			[Token(Token = "0x602B5A7")]
			[Address(RVA = "0x2732B30", Offset = "0x2731730", VA = "0x182732B30")]
			get
			{
				return ActivityInterlockData.InterlockStageType.NONE;
			}
		}

		// Token: 0x1700656F RID: 25967
		// (get) Token: 0x0602B5A8 RID: 177576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700656F")]
		public AnimationWrapper animWrapper
		{
			[Token(Token = "0x602B5A8")]
			[Address(RVA = "0x2732AD0", Offset = "0x27316D0", VA = "0x182732AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B5A9 RID: 177577 RVA: 0x000DB7E0 File Offset: 0x000D99E0
		[Token(Token = "0x602B5A9")]
		[Address(RVA = "0x2731EF0", Offset = "0x2730AF0", VA = "0x182731EF0")]
		private bool _ApplySelect(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602B5AA RID: 177578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5AA")]
		[Address(RVA = "0x2732A60", Offset = "0x2731660", VA = "0x182732A60")]
		public Act1LockStageBtn()
		{
		}

		// Token: 0x0403EAF1 RID: 256753
		[Token(Token = "0x403EAF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("StageInfo")]
		private ActivityInterlockData.InterlockStageType _stageType;

		// Token: 0x0403EAF2 RID: 256754
		[Token(Token = "0x403EAF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("StageInfo")]
		private Text _stageCode;

		// Token: 0x0403EAF3 RID: 256755
		[Token(Token = "0x403EAF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("StageInfo")]
		[Tooltip("Nullable")]
		private StageRankViewViaSwitch _stageRank;

		// Token: 0x0403EAF4 RID: 256756
		[Token(Token = "0x403EAF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("StageInfo")]
		private GameObject _selected;

		// Token: 0x0403EAF5 RID: 256757
		[Token(Token = "0x403EAF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("StageInfo")]
		private UIColorGraphic _uIColorGraphic;

		// Token: 0x0403EAF6 RID: 256758
		[Token(Token = "0x403EAF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("StageInfo")]
		private Color _selectedColor;

		// Token: 0x0403EAF7 RID: 256759
		[Token(Token = "0x403EAF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _interlockPanel;

		// Token: 0x0403EAF8 RID: 256760
		[Token(Token = "0x403EAF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _finalPanel;

		// Token: 0x0403EAF9 RID: 256761
		[Token(Token = "0x403EAF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Final Stage")]
		private Act1LockInterlockStageStatusView[] _interLockStageStatus;

		// Token: 0x0403EAFA RID: 256762
		[Token(Token = "0x403EAFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Final Stage")]
		private AnimationWrapper _animation;

		// Token: 0x0403EAFB RID: 256763
		[Token(Token = "0x403EAFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("InterLock Stage")]
		private Image _stageEnemyIcon;

		// Token: 0x0403EAFC RID: 256764
		[Token(Token = "0x403EAFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("InterLock Stage")]
		private Image _stageEnemyBg;

		// Token: 0x0403EAFD RID: 256765
		[Token(Token = "0x403EAFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("InterLock Stage")]
		private Image _interLockAssistIcon;

		// Token: 0x0403EAFE RID: 256766
		[Token(Token = "0x403EAFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("InterLock Stage")]
		private GameObject _interLockAssistPanel;

		// Token: 0x0403EAFF RID: 256767
		[Token(Token = "0x403EAFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("InterLock Stage")]
		private Text _interLockAssistCount;

		// Token: 0x0403EB00 RID: 256768
		[Token(Token = "0x403EB00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("InterLock Stage")]
		private GameObject _interLockHasSquad;

		// Token: 0x0403EB01 RID: 256769
		[Token(Token = "0x403EB01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("InterLock Stage")]
		private GameObject _interLockNonSquad;

		// Token: 0x0403EB02 RID: 256770
		[Token(Token = "0x403EB02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("InterLock Stage")]
		private Image _interLockAsssitBg;

		// Token: 0x0403EB03 RID: 256771
		[Token(Token = "0x403EB03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("InterLock Stage")]
		private GameObject _interLockUseSpAssist;

		// Token: 0x0403EB04 RID: 256772
		[Token(Token = "0x403EB04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _interLockedColor;

		// Token: 0x0403EB05 RID: 256773
		[Token(Token = "0x403EB05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _interNormalColor;

		// Token: 0x0403EB06 RID: 256774
		[Token(Token = "0x403EB06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public Action<string> onStageClick;

		// Token: 0x0403EB07 RID: 256775
		[Token(Token = "0x403EB07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Act1LockStageViewModel m_cachedViewModel;

		// Token: 0x0403EB08 RID: 256776
		[Token(Token = "0x403EB08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_inited;

		// Token: 0x0403EB09 RID: 256777
		[Token(Token = "0x403EB09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderStageBtn;

		// Token: 0x0403EB0A RID: 256778
		[Token(Token = "0x403EB0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EB0B RID: 256779
		[Token(Token = "0x403EB0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBtn;

		// Token: 0x0403EB0C RID: 256780
		[Token(Token = "0x403EB0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryLockStage;

		// Token: 0x0403EB0D RID: 256781
		[Token(Token = "0x403EB0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckStageLocked;

		// Token: 0x0403EB0E RID: 256782
		[Token(Token = "0x403EB0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderInterLockInfo;

		// Token: 0x0403EB0F RID: 256783
		[Token(Token = "0x403EB0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderFinalInfo;

		// Token: 0x0403EB10 RID: 256784
		[Token(Token = "0x403EB10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEventClick;

		// Token: 0x0403EB11 RID: 256785
		[Token(Token = "0x403EB11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_stageType;

		// Token: 0x0403EB12 RID: 256786
		[Token(Token = "0x403EB12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_animWrapper;

		// Token: 0x0403EB13 RID: 256787
		[Token(Token = "0x403EB13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplySelect;

		// Token: 0x0403EB14 RID: 256788
		[Token(Token = "0x403EB14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
