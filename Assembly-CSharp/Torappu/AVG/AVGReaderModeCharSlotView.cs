using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F24 RID: 7972
	[Token(Token = "0x2001F24")]
	public class AVGReaderModeCharSlotView : MonoBehaviour, IAVGDataSubscriber<AVGReaderModePerformanceViewModel>, IHotfixable
	{
		// Token: 0x0600C620 RID: 50720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C620")]
		[Address(RVA = "0x3467F70", Offset = "0x3466B70", VA = "0x183467F70", Slot = "4")]
		public void OnValueChanged(AVGReaderModePerformanceViewModel viewModel)
		{
		}

		// Token: 0x0600C621 RID: 50721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C621")]
		[Address(RVA = "0x3468130", Offset = "0x3466D30", VA = "0x183468130")]
		public void RenderView(Command command)
		{
		}

		// Token: 0x0600C622 RID: 50722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C622")]
		[Address(RVA = "0x346A210", Offset = "0x3468E10", VA = "0x18346A210")]
		private void _RenderSlotCommand(string slotType, bool keepCurrentIfMissing = false)
		{
		}

		// Token: 0x0600C623 RID: 50723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C623")]
		[Address(RVA = "0x3468980", Offset = "0x3467580", VA = "0x183468980")]
		private void _ExecuteCharacterForSlot(string slotType, Command command)
		{
		}

		// Token: 0x0600C624 RID: 50724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C624")]
		[Address(RVA = "0x3468D50", Offset = "0x3467950", VA = "0x183468D50")]
		private void _ExecuteCharacter(Command command)
		{
		}

		// Token: 0x0600C625 RID: 50725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C625")]
		[Address(RVA = "0x3469000", Offset = "0x3467C00", VA = "0x183469000")]
		private void _ExecuteCharslot(Command command)
		{
		}

		// Token: 0x0600C626 RID: 50726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C626")]
		[Address(RVA = "0x3469C30", Offset = "0x3468830", VA = "0x183469C30")]
		private void _ProcessSlotWithParam(Command command, string name, AVGReaderModeCharSlotView.ECharSlot slot, string nStart, string nEnd)
		{
		}

		// Token: 0x0600C627 RID: 50727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C627")]
		[Address(RVA = "0x346A040", Offset = "0x3468C40", VA = "0x18346A040")]
		private void _ProcessSlot(AVGReaderModeCharSlotView.ECharSlot slot, AVGReaderModeCharSlotView.CharSlotParam param)
		{
		}

		// Token: 0x0600C628 RID: 50728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C628")]
		[Address(RVA = "0x3468340", Offset = "0x3466F40", VA = "0x183468340")]
		private void _CleanSlotsWithTween(float duration)
		{
		}

		// Token: 0x0600C629 RID: 50729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C629")]
		[Address(RVA = "0x346A700", Offset = "0x3469300", VA = "0x18346A700")]
		private void _UpdateSeqWithTween(ref Sequence curSeq, Tween tw, float delay = 0f)
		{
		}

		// Token: 0x0600C62A RID: 50730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C62A")]
		[Address(RVA = "0x3468770", Offset = "0x3467370", VA = "0x183468770")]
		private Sequence _DoCleanSlot(string slotType, float duration)
		{
			return null;
		}

		// Token: 0x0600C62B RID: 50731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62B")]
		[Address(RVA = "0x346A430", Offset = "0x3469030", VA = "0x18346A430")]
		private void _SetSeqPlayed(string slotType)
		{
		}

		// Token: 0x0600C62C RID: 50732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C62C")]
		[Address(RVA = "0x3469950", Offset = "0x3468550", VA = "0x183469950")]
		private AVGCharacterSlot _GetSlotWithName(string slot)
		{
			return null;
		}

		// Token: 0x0600C62D RID: 50733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C62D")]
		[Address(RVA = "0x3469360", Offset = "0x3467F60", VA = "0x183469360")]
		private Sequence _GetCachedSlotSeq(string slotType)
		{
			return null;
		}

		// Token: 0x0600C62E RID: 50734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62E")]
		[Address(RVA = "0x3469AC0", Offset = "0x34686C0", VA = "0x183469AC0")]
		private void _HideAllSlots()
		{
		}

		// Token: 0x0600C62F RID: 50735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62F")]
		[Address(RVA = "0x346A590", Offset = "0x3469190", VA = "0x18346A590")]
		private void _ShowAllSlots()
		{
		}

		// Token: 0x0600C630 RID: 50736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C630")]
		[Address(RVA = "0x3468570", Offset = "0x3467170", VA = "0x183468570")]
		private void _ClearAllSlotsImmediate()
		{
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C631")]
		[Address(RVA = "0x34686A0", Offset = "0x34672A0", VA = "0x1834686A0")]
		private void _ClearSlotImmediate(string slotType)
		{
		}

		// Token: 0x0600C632 RID: 50738 RVA: 0x00048720 File Offset: 0x00046920
		[Token(Token = "0x600C632")]
		[Address(RVA = "0x34695E0", Offset = "0x34681E0", VA = "0x1834695E0")]
		private AVGReaderModeCharSlotView.ECharSlot _GetSlotEnum(string slotType)
		{
			return AVGReaderModeCharSlotView.ECharSlot.NONE;
		}

		// Token: 0x0600C633 RID: 50739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C633")]
		[Address(RVA = "0x34697E0", Offset = "0x34683E0", VA = "0x1834697E0")]
		private string _GetSlotName(AVGReaderModeCharSlotView.ECharSlot slot)
		{
			return null;
		}

		// Token: 0x0600C634 RID: 50740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C634")]
		[Address(RVA = "0x346A7B0", Offset = "0x34693B0", VA = "0x18346A7B0")]
		public AVGReaderModeCharSlotView()
		{
		}

		// Token: 0x0400CB1D RID: 51997
		[Token(Token = "0x400CB1D")]
		private const string COMMAND_CHARACTER = "character";

		// Token: 0x0400CB1E RID: 51998
		[Token(Token = "0x400CB1E")]
		private const string COMMAND_CHARSLOT = "charslot";

		// Token: 0x0400CB1F RID: 51999
		[Token(Token = "0x400CB1F")]
		private const string PARAM_NAME_BSTART_1 = "blackstart";

		// Token: 0x0400CB20 RID: 52000
		[Token(Token = "0x400CB20")]
		private const string PARAM_NAME_BSTART_2 = "blackstart2";

		// Token: 0x0400CB21 RID: 52001
		[Token(Token = "0x400CB21")]
		private const string PARAM_NAME_BEND_1 = "blackend";

		// Token: 0x0400CB22 RID: 52002
		[Token(Token = "0x400CB22")]
		private const string PARAM_NAME_BEND_2 = "blackend2";

		// Token: 0x0400CB23 RID: 52003
		[Token(Token = "0x400CB23")]
		private const string PARAM_NAME_BSTART = "bstart";

		// Token: 0x0400CB24 RID: 52004
		[Token(Token = "0x400CB24")]
		private const string PARAM_NAME_BEND = "bend";

		// Token: 0x0400CB25 RID: 52005
		[Token(Token = "0x400CB25")]
		private const string SLOT_LEFT = "left";

		// Token: 0x0400CB26 RID: 52006
		[Token(Token = "0x400CB26")]
		private const string SLOT_RIGHT = "right";

		// Token: 0x0400CB27 RID: 52007
		[Token(Token = "0x400CB27")]
		private const string SLOT_MIDDLE = "middle";

		// Token: 0x0400CB28 RID: 52008
		[Token(Token = "0x400CB28")]
		private const string SLOT_LEFT_SHORT = "l";

		// Token: 0x0400CB29 RID: 52009
		[Token(Token = "0x400CB29")]
		private const string SLOT_RIGHT_SHORT = "r";

		// Token: 0x0400CB2A RID: 52010
		[Token(Token = "0x400CB2A")]
		private const string SLOT_MIDDLE_SHORT = "m";

		// Token: 0x0400CB2B RID: 52011
		[Token(Token = "0x400CB2B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGCharacterSlot _middleSlot;

		// Token: 0x0400CB2C RID: 52012
		[Token(Token = "0x400CB2C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AVGCharacterSlot _leftSlot;

		// Token: 0x0400CB2D RID: 52013
		[Token(Token = "0x400CB2D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AVGCharacterSlot _rightSlot;

		// Token: 0x0400CB2E RID: 52014
		[Token(Token = "0x400CB2E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _focusColor;

		// Token: 0x0400CB2F RID: 52015
		[Token(Token = "0x400CB2F")]
		[FieldOffset(Offset = "0x40")]
		private Sequence m_leftSeq;

		// Token: 0x0400CB30 RID: 52016
		[Token(Token = "0x400CB30")]
		[FieldOffset(Offset = "0x48")]
		private Sequence m_rightSeq;

		// Token: 0x0400CB31 RID: 52017
		[Token(Token = "0x400CB31")]
		[FieldOffset(Offset = "0x50")]
		private Sequence m_middleSeq;

		// Token: 0x0400CB32 RID: 52018
		[Token(Token = "0x400CB32")]
		[FieldOffset(Offset = "0x58")]
		private bool m_leftSeqPlayed;

		// Token: 0x0400CB33 RID: 52019
		[Token(Token = "0x400CB33")]
		[FieldOffset(Offset = "0x59")]
		private bool m_rightSeqPlayed;

		// Token: 0x0400CB34 RID: 52020
		[Token(Token = "0x400CB34")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_middleSeqPlayed;

		// Token: 0x0400CB35 RID: 52021
		[Token(Token = "0x400CB35")]
		[FieldOffset(Offset = "0x60")]
		private AVGReaderModePerformanceViewModel m_cachedViewModel;

		// Token: 0x0400CB36 RID: 52022
		[Token(Token = "0x400CB36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CB37 RID: 52023
		[Token(Token = "0x400CB37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0400CB38 RID: 52024
		[Token(Token = "0x400CB38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSlotCommand;

		// Token: 0x0400CB39 RID: 52025
		[Token(Token = "0x400CB39")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteCharacterForSlot;

		// Token: 0x0400CB3A RID: 52026
		[Token(Token = "0x400CB3A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteCharacter;

		// Token: 0x0400CB3B RID: 52027
		[Token(Token = "0x400CB3B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteCharslot;

		// Token: 0x0400CB3C RID: 52028
		[Token(Token = "0x400CB3C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ProcessSlotWithParam;

		// Token: 0x0400CB3D RID: 52029
		[Token(Token = "0x400CB3D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ProcessSlot;

		// Token: 0x0400CB3E RID: 52030
		[Token(Token = "0x400CB3E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CleanSlotsWithTween;

		// Token: 0x0400CB3F RID: 52031
		[Token(Token = "0x400CB3F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateSeqWithTween;

		// Token: 0x0400CB40 RID: 52032
		[Token(Token = "0x400CB40")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoCleanSlot;

		// Token: 0x0400CB41 RID: 52033
		[Token(Token = "0x400CB41")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetSeqPlayed;

		// Token: 0x0400CB42 RID: 52034
		[Token(Token = "0x400CB42")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetSlotWithName;

		// Token: 0x0400CB43 RID: 52035
		[Token(Token = "0x400CB43")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetCachedSlotSeq;

		// Token: 0x0400CB44 RID: 52036
		[Token(Token = "0x400CB44")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HideAllSlots;

		// Token: 0x0400CB45 RID: 52037
		[Token(Token = "0x400CB45")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ShowAllSlots;

		// Token: 0x0400CB46 RID: 52038
		[Token(Token = "0x400CB46")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearAllSlotsImmediate;

		// Token: 0x0400CB47 RID: 52039
		[Token(Token = "0x400CB47")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ClearSlotImmediate;

		// Token: 0x0400CB48 RID: 52040
		[Token(Token = "0x400CB48")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetSlotEnum;

		// Token: 0x0400CB49 RID: 52041
		[Token(Token = "0x400CB49")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetSlotName;

		// Token: 0x0400CB4A RID: 52042
		[Token(Token = "0x400CB4A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F25 RID: 7973
		[Token(Token = "0x2001F25")]
		private enum ECharSlot
		{
			// Token: 0x0400CB4C RID: 52044
			[Token(Token = "0x400CB4C")]
			NONE,
			// Token: 0x0400CB4D RID: 52045
			[Token(Token = "0x400CB4D")]
			LEFT,
			// Token: 0x0400CB4E RID: 52046
			[Token(Token = "0x400CB4E")]
			RIGHT,
			// Token: 0x0400CB4F RID: 52047
			[Token(Token = "0x400CB4F")]
			MIDDLE
		}

		// Token: 0x02001F26 RID: 7974
		[Token(Token = "0x2001F26")]
		private struct CharSlotParam
		{
			// Token: 0x0400CB50 RID: 52048
			[Token(Token = "0x400CB50")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0400CB51 RID: 52049
			[Token(Token = "0x400CB51")]
			[FieldOffset(Offset = "0x8")]
			public float blackStart;

			// Token: 0x0400CB52 RID: 52050
			[Token(Token = "0x400CB52")]
			[FieldOffset(Offset = "0xC")]
			public float blackEnd;
		}
	}
}
