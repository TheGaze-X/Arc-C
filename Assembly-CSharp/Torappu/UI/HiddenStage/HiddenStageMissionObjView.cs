using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CA5 RID: 19621
	[Token(Token = "0x2004CA5")]
	public class HiddenStageMissionObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D69A RID: 120474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D69A")]
		[Address(RVA = "0x170A0D0", Offset = "0x1708CD0", VA = "0x18170A0D0")]
		public void RenderView(HiddenStageMissionViewModel viewModel, int position)
		{
		}

		// Token: 0x0601D69B RID: 120475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D69B")]
		[Address(RVA = "0x170AB60", Offset = "0x1709760", VA = "0x18170AB60")]
		private void _RenderRiddle(HiddenStageMissionViewModel viewModel)
		{
		}

		// Token: 0x0601D69C RID: 120476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D69C")]
		[Address(RVA = "0x170A620", Offset = "0x1709220", VA = "0x18170A620")]
		private void _RenderDecode(HiddenStageMissionViewModel viewModel)
		{
		}

		// Token: 0x0601D69D RID: 120477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D69D")]
		[Address(RVA = "0x1709FD0", Offset = "0x1708BD0", VA = "0x181709FD0")]
		public void EventOnSwitchPanel()
		{
		}

		// Token: 0x0601D69E RID: 120478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D69E")]
		[Address(RVA = "0x170A480", Offset = "0x1709080", VA = "0x18170A480")]
		private void _PlayDecodePanelAnim()
		{
		}

		// Token: 0x0601D69F RID: 120479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D69F")]
		[Address(RVA = "0x170A550", Offset = "0x1709150", VA = "0x18170A550")]
		private void _PlayRiddlePanelAnim()
		{
		}

		// Token: 0x0601D6A0 RID: 120480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6A0")]
		[Address(RVA = "0x170A730", Offset = "0x1709330", VA = "0x18170A730")]
		private void _RenderPanel()
		{
		}

		// Token: 0x0601D6A1 RID: 120481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D6A1")]
		[Address(RVA = "0x170A380", Offset = "0x1708F80", VA = "0x18170A380")]
		private AnimationSwitchTween _EnsureSwitchTween()
		{
			return null;
		}

		// Token: 0x0601D6A2 RID: 120482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6A2")]
		[Address(RVA = "0x170A040", Offset = "0x1708C40", VA = "0x18170A040")]
		public void EventOnToBattle()
		{
		}

		// Token: 0x0601D6A3 RID: 120483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6A3")]
		[Address(RVA = "0x170ACD0", Offset = "0x17098D0", VA = "0x18170ACD0")]
		public HiddenStageMissionObjView()
		{
		}

		// Token: 0x04026BA9 RID: 158633
		[Token(Token = "0x4026BA9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x04026BAA RID: 158634
		[Token(Token = "0x4026BAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objLock;

		// Token: 0x04026BAB RID: 158635
		[Token(Token = "0x4026BAB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objUnlocked;

		// Token: 0x04026BAC RID: 158636
		[Token(Token = "0x4026BAC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Riddle")]
		private GameObject _panelRiddle;

		// Token: 0x04026BAD RID: 158637
		[Token(Token = "0x4026BAD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Riddle")]
		private Text _textRiddle;

		// Token: 0x04026BAE RID: 158638
		[Token(Token = "0x4026BAE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Riddle")]
		private Text _lockedDesc;

		// Token: 0x04026BAF RID: 158639
		[Token(Token = "0x4026BAF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Riddle")]
		private GameObject _lockInfoPanel;

		// Token: 0x04026BB0 RID: 158640
		[Token(Token = "0x4026BB0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Riddle")]
		private GameObject _panelNotFinish;

		// Token: 0x04026BB1 RID: 158641
		[Token(Token = "0x4026BB1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _missionName;

		// Token: 0x04026BB2 RID: 158642
		[Token(Token = "0x4026BB2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _missionCode;

		// Token: 0x04026BB3 RID: 158643
		[Token(Token = "0x4026BB3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _switchBtn;

		// Token: 0x04026BB4 RID: 158644
		[Token(Token = "0x4026BB4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _missionAnimLoc;

		// Token: 0x04026BB5 RID: 158645
		[Token(Token = "0x4026BB5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Decode")]
		private GameObject _panelDecode;

		// Token: 0x04026BB6 RID: 158646
		[Token(Token = "0x4026BB6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Decode")]
		private Text _missionDesc;

		// Token: 0x04026BB7 RID: 158647
		[Token(Token = "0x4026BB7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Decode")]
		private GameObject _panelToBattle;

		// Token: 0x04026BB8 RID: 158648
		[Token(Token = "0x4026BB8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x04026BB9 RID: 158649
		[Token(Token = "0x4026BB9")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Action<string> eventOnJumpToBattle;

		// Token: 0x04026BBA RID: 158650
		[Token(Token = "0x4026BBA")]
		private const string ANIM_DECODE_PANEL = "mission_decode_show";

		// Token: 0x04026BBB RID: 158651
		[Token(Token = "0x4026BBB")]
		private const string ANIM_RIDDLE_PANEL = "mission_riddle_show";

		// Token: 0x04026BBC RID: 158652
		[Token(Token = "0x4026BBC")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inDecodePanel;

		// Token: 0x04026BBD RID: 158653
		[Token(Token = "0x4026BBD")]
		[FieldOffset(Offset = "0xB0")]
		private string m_missionStageId;

		// Token: 0x04026BBE RID: 158654
		[Token(Token = "0x4026BBE")]
		[FieldOffset(Offset = "0xB8")]
		private AnimationSwitchTween m_stateSwitchTween;

		// Token: 0x04026BBF RID: 158655
		[Token(Token = "0x4026BBF")]
		[FieldOffset(Offset = "0xC0")]
		private HiddenStageMissionViewModel m_cachedModel;

		// Token: 0x04026BC0 RID: 158656
		[Token(Token = "0x4026BC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04026BC1 RID: 158657
		[Token(Token = "0x4026BC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderRiddle;

		// Token: 0x04026BC2 RID: 158658
		[Token(Token = "0x4026BC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderDecode;

		// Token: 0x04026BC3 RID: 158659
		[Token(Token = "0x4026BC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnSwitchPanel;

		// Token: 0x04026BC4 RID: 158660
		[Token(Token = "0x4026BC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayDecodePanelAnim;

		// Token: 0x04026BC5 RID: 158661
		[Token(Token = "0x4026BC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayRiddlePanelAnim;

		// Token: 0x04026BC6 RID: 158662
		[Token(Token = "0x4026BC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderPanel;

		// Token: 0x04026BC7 RID: 158663
		[Token(Token = "0x4026BC7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTween;

		// Token: 0x04026BC8 RID: 158664
		[Token(Token = "0x4026BC8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnToBattle;

		// Token: 0x04026BC9 RID: 158665
		[Token(Token = "0x4026BC9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
