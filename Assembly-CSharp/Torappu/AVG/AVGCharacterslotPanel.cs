using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E97 RID: 7831
	[Token(Token = "0x2001E97")]
	public class AVGCharacterslotPanel : ExecutorComponent, IContainsResRefs, IFadeTimeRatio
	{
		// Token: 0x0600C1E6 RID: 49638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1E6")]
		[Address(RVA = "0x33F06B0", Offset = "0x33EF2B0", VA = "0x1833F06B0", Slot = "13")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C1E7 RID: 49639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1E7")]
		[Address(RVA = "0x33F0830", Offset = "0x33EF430", VA = "0x1833F0830", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C1E8 RID: 49640 RVA: 0x000472C8 File Offset: 0x000454C8
		[Token(Token = "0x600C1E8")]
		[Address(RVA = "0x33F1540", Offset = "0x33F0140", VA = "0x1833F1540")]
		private bool _ExecuteCharslotMask(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C1E9 RID: 49641 RVA: 0x000472E0 File Offset: 0x000454E0
		[Token(Token = "0x600C1E9")]
		[Address(RVA = "0x33F2920", Offset = "0x33F1520", VA = "0x1833F2920")]
		private bool _ExecuteGlitchTween(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C1EA RID: 49642 RVA: 0x000472F8 File Offset: 0x000454F8
		[Token(Token = "0x600C1EA")]
		[Address(RVA = "0x33F18C0", Offset = "0x33F04C0", VA = "0x1833F18C0")]
		private bool _ExecuteCharslot(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C1EB RID: 49643 RVA: 0x00047310 File Offset: 0x00045510
		[Token(Token = "0x600C1EB")]
		[Address(RVA = "0x33F0F60", Offset = "0x33EFB60", VA = "0x1833F0F60")]
		private bool _CleanSlotsWithTween(float duartion, bool isBlock)
		{
			return default(bool);
		}

		// Token: 0x0600C1EC RID: 49644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1EC")]
		[Address(RVA = "0x33F4720", Offset = "0x33F3320", VA = "0x1833F4720")]
		private void _UpdateSeqWithTween(ref Sequence curSeq, Tween tw, float delay = 0f)
		{
		}

		// Token: 0x0600C1ED RID: 49645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1ED")]
		[Address(RVA = "0x33F1300", Offset = "0x33EFF00", VA = "0x1833F1300")]
		private Sequence _DoCleanSlot(string slotType, float duration)
		{
			return null;
		}

		// Token: 0x0600C1EE RID: 49646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1EE")]
		[Address(RVA = "0x33F4160", Offset = "0x33F2D60", VA = "0x1833F4160")]
		private void _SetSeqPlayed(string slotType)
		{
		}

		// Token: 0x0600C1EF RID: 49647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1EF")]
		[Address(RVA = "0x33F3F30", Offset = "0x33F2B30", VA = "0x1833F3F30")]
		private void _ProcessFocusArray(string[] focusArray)
		{
		}

		// Token: 0x0600C1F0 RID: 49648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F0")]
		[Address(RVA = "0x33F42E0", Offset = "0x33F2EE0", VA = "0x1833F42E0")]
		private void _UpdateSeqWithParam(ref Sequence cacheSeq, AVGCharacterslotPanel.TweenerOptions options)
		{
		}

		// Token: 0x0600C1F1 RID: 49649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1F1")]
		[Address(RVA = "0x33F31B0", Offset = "0x33F1DB0", VA = "0x1833F31B0")]
		private Tween _GenSlotActionTw(AVGCharacterSlot slot, AVGCharacterslotPanel.TweenerOptions options)
		{
			return null;
		}

		// Token: 0x0600C1F2 RID: 49650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1F2")]
		[Address(RVA = "0x33F2C30", Offset = "0x33F1830", VA = "0x1833F2C30")]
		private Tween _GenCharslotJump(AVGCharacterSlot slot, AVGCharacterslotPanel.TweenerOptions options)
		{
			return null;
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1F3")]
		[Address(RVA = "0x33F30D0", Offset = "0x33F1CD0", VA = "0x1833F30D0")]
		private Tween _GenCharslotZoom(AVGCharacterSlot slot, AVGCharacterslotPanel.TweenerOptions options)
		{
			return null;
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1F4")]
		[Address(RVA = "0x33F2E60", Offset = "0x33F1A60", VA = "0x1833F2E60")]
		private Tween _GenCharslotShake(AVGCharacterSlot slot, AVGCharacterslotPanel.TweenerOptions options)
		{
			return null;
		}

		// Token: 0x0600C1F5 RID: 49653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1F5")]
		[Address(RVA = "0x33F2D60", Offset = "0x33F1960", VA = "0x1833F2D60")]
		private Tween _GenCharslotMove(AVGCharacterSlot slot, AVGCharacterslotPanel.TweenerOptions options)
		{
			return null;
		}

		// Token: 0x0600C1F6 RID: 49654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1F6")]
		[Address(RVA = "0x33F2F70", Offset = "0x33F1B70", VA = "0x1833F2F70")]
		private Tween _GenCharslotShakemove(AVGCharacterSlot slot, AVGCharacterslotPanel.TweenerOptions options)
		{
			return null;
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x00047328 File Offset: 0x00045528
		[Token(Token = "0x600C1F7")]
		[Address(RVA = "0x33F3900", Offset = "0x33F2500", VA = "0x1833F3900")]
		private Color _GetSlotColorWithFocus(string slot)
		{
			return default(Color);
		}

		// Token: 0x0600C1F8 RID: 49656 RVA: 0x00047340 File Offset: 0x00045540
		[Token(Token = "0x600C1F8")]
		[Address(RVA = "0x33F39D0", Offset = "0x33F25D0", VA = "0x1833F39D0")]
		private bool _GetSlotFocusStatus(string slot)
		{
			return default(bool);
		}

		// Token: 0x0600C1F9 RID: 49657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1F9")]
		[Address(RVA = "0x33F3E60", Offset = "0x33F2A60", VA = "0x1833F3E60")]
		private void _ProcessCharFocus()
		{
		}

		// Token: 0x0600C1FA RID: 49658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1FA")]
		[Address(RVA = "0x33F3B60", Offset = "0x33F2760", VA = "0x1833F3B60")]
		private AVGCharacterSlot _GetSlotWithName(string slot)
		{
			return null;
		}

		// Token: 0x0600C1FB RID: 49659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C1FB")]
		[Address(RVA = "0x33F3630", Offset = "0x33F2230", VA = "0x1833F3630")]
		private Sequence _GetCachedSlotSeq(string slotType)
		{
			return null;
		}

		// Token: 0x0600C1FC RID: 49660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FC")]
		[Address(RVA = "0x33F11E0", Offset = "0x33EFDE0", VA = "0x1833F11E0")]
		private void _ClearSeq()
		{
		}

		// Token: 0x0600C1FD RID: 49661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FD")]
		[Address(RVA = "0x33F0AE0", Offset = "0x33EF6E0", VA = "0x1833F0AE0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C1FE RID: 49662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FE")]
		[Address(RVA = "0x33F07C0", Offset = "0x33EF3C0", VA = "0x1833F07C0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C1FF RID: 49663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1FF")]
		[Address(RVA = "0x33F0BB0", Offset = "0x33EF7B0", VA = "0x1833F0BB0", Slot = "5")]
		public override void OnStoryBegin(Story story)
		{
		}

		// Token: 0x0600C200 RID: 49664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C200")]
		[Address(RVA = "0x33F3CF0", Offset = "0x33F28F0", VA = "0x1833F3CF0")]
		private void _InitCamEffectBind()
		{
		}

		// Token: 0x0600C201 RID: 49665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C201")]
		[Address(RVA = "0x33F0D90", Offset = "0x33EF990", VA = "0x1833F0D90", Slot = "6")]
		public override void OnStoryEnd(Story story)
		{
		}

		// Token: 0x0600C202 RID: 49666 RVA: 0x00047358 File Offset: 0x00045558
		[Token(Token = "0x600C202")]
		[Address(RVA = "0x33F0A30", Offset = "0x33EF630", VA = "0x1833F0A30", Slot = "15")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C203 RID: 49667 RVA: 0x00047370 File Offset: 0x00045570
		[Token(Token = "0x600C203")]
		[Address(RVA = "0x33F05F0", Offset = "0x33EF1F0", VA = "0x1833F05F0", Slot = "14")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C204 RID: 49668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C204")]
		[Address(RVA = "0x33F4920", Offset = "0x33F3520", VA = "0x1833F4920")]
		public AVGCharacterslotPanel()
		{
		}

		// Token: 0x0600C209 RID: 49673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C209")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C20A RID: 49674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C20A")]
		[Address(RVA = "0x33F0E70", Offset = "0x33EFA70", VA = "0x1833F0E70")]
		private void <>xLuaBaseProxy_OnStoryBegin(Story P0)
		{
		}

		// Token: 0x0600C20B RID: 49675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C20B")]
		[Address(RVA = "0x33F0E80", Offset = "0x33EFA80", VA = "0x1833F0E80")]
		private void <>xLuaBaseProxy_OnStoryEnd(Story P0)
		{
		}

		// Token: 0x0400C375 RID: 50037
		[Token(Token = "0x400C375")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGCharacterSlot _middleSlot;

		// Token: 0x0400C376 RID: 50038
		[Token(Token = "0x400C376")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AVGCharacterSlot _leftSlot;

		// Token: 0x0400C377 RID: 50039
		[Token(Token = "0x400C377")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AVGCharacterSlot _rightSlot;

		// Token: 0x0400C378 RID: 50040
		[Token(Token = "0x400C378")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _focusColor;

		// Token: 0x0400C379 RID: 50041
		[Token(Token = "0x400C379")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _unfocusColor;

		// Token: 0x0400C37A RID: 50042
		[Token(Token = "0x400C37A")]
		private const string SLOT_LEFT = "left";

		// Token: 0x0400C37B RID: 50043
		[Token(Token = "0x400C37B")]
		private const string SLOT_RIGHT = "right";

		// Token: 0x0400C37C RID: 50044
		[Token(Token = "0x400C37C")]
		private const string SLOT_MIDDLE = "middle";

		// Token: 0x0400C37D RID: 50045
		[Token(Token = "0x400C37D")]
		private const string SLOT_LEFT_SHORT = "l";

		// Token: 0x0400C37E RID: 50046
		[Token(Token = "0x400C37E")]
		private const string SLOT_RIGHT_SHORT = "r";

		// Token: 0x0400C37F RID: 50047
		[Token(Token = "0x400C37F")]
		private const string SLOT_MIDDLE_SHORT = "m";

		// Token: 0x0400C380 RID: 50048
		[Token(Token = "0x400C380")]
		private const string SLOT_ALL = "all";

		// Token: 0x0400C381 RID: 50049
		[Token(Token = "0x400C381")]
		private const string SLOT_NONE = "none";

		// Token: 0x0400C382 RID: 50050
		[Token(Token = "0x400C382")]
		private const float ALPHA_ZERO = 0f;

		// Token: 0x0400C383 RID: 50051
		[Token(Token = "0x400C383")]
		private const float ALPHA_ONE = 1f;

		// Token: 0x0400C384 RID: 50052
		[Token(Token = "0x400C384")]
		private const float ALPHA_DEFAULT = -1f;

		// Token: 0x0400C385 RID: 50053
		[Token(Token = "0x400C385")]
		private const string EMPTY_CHAR = "char_empty";

		// Token: 0x0400C386 RID: 50054
		[Token(Token = "0x400C386")]
		private const string DEFAULT_GLITCH_SETTING = "greenscreen_middle";

		// Token: 0x0400C387 RID: 50055
		[Token(Token = "0x400C387")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] GLITCH_COMMANDS;

		// Token: 0x0400C388 RID: 50056
		[Token(Token = "0x400C388")]
		[FieldOffset(Offset = "0x88")]
		private bool m_focusLeft;

		// Token: 0x0400C389 RID: 50057
		[Token(Token = "0x400C389")]
		[FieldOffset(Offset = "0x89")]
		private bool m_focusRight;

		// Token: 0x0400C38A RID: 50058
		[Token(Token = "0x400C38A")]
		[FieldOffset(Offset = "0x8A")]
		private bool m_focusMiddle;

		// Token: 0x0400C38B RID: 50059
		[Token(Token = "0x400C38B")]
		[FieldOffset(Offset = "0x90")]
		private PostDisplayHandler m_ghostLeft;

		// Token: 0x0400C38C RID: 50060
		[Token(Token = "0x400C38C")]
		[FieldOffset(Offset = "0x98")]
		private PostDisplayHandler m_ghostRight;

		// Token: 0x0400C38D RID: 50061
		[Token(Token = "0x400C38D")]
		[FieldOffset(Offset = "0xA0")]
		private PostDisplayHandler m_ghostMiddle;

		// Token: 0x0400C38E RID: 50062
		[Token(Token = "0x400C38E")]
		[FieldOffset(Offset = "0xA8")]
		private Sequence m_leftSeq;

		// Token: 0x0400C38F RID: 50063
		[Token(Token = "0x400C38F")]
		[FieldOffset(Offset = "0xB0")]
		private Sequence m_rightSeq;

		// Token: 0x0400C390 RID: 50064
		[Token(Token = "0x400C390")]
		[FieldOffset(Offset = "0xB8")]
		private Sequence m_middleSeq;

		// Token: 0x0400C391 RID: 50065
		[Token(Token = "0x400C391")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_leftSeqPlayed;

		// Token: 0x0400C392 RID: 50066
		[Token(Token = "0x400C392")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_rightSeqPlayed;

		// Token: 0x0400C393 RID: 50067
		[Token(Token = "0x400C393")]
		[FieldOffset(Offset = "0xC2")]
		private bool m_middleSeqPlayed;

		// Token: 0x0400C394 RID: 50068
		[Token(Token = "0x400C394")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C395 RID: 50069
		[Token(Token = "0x400C395")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C396 RID: 50070
		[Token(Token = "0x400C396")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteCharslotMask;

		// Token: 0x0400C397 RID: 50071
		[Token(Token = "0x400C397")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteGlitchTween;

		// Token: 0x0400C398 RID: 50072
		[Token(Token = "0x400C398")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteCharslot;

		// Token: 0x0400C399 RID: 50073
		[Token(Token = "0x400C399")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CleanSlotsWithTween;

		// Token: 0x0400C39A RID: 50074
		[Token(Token = "0x400C39A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateSeqWithTween;

		// Token: 0x0400C39B RID: 50075
		[Token(Token = "0x400C39B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoCleanSlot;

		// Token: 0x0400C39C RID: 50076
		[Token(Token = "0x400C39C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetSeqPlayed;

		// Token: 0x0400C39D RID: 50077
		[Token(Token = "0x400C39D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ProcessFocusArray;

		// Token: 0x0400C39E RID: 50078
		[Token(Token = "0x400C39E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateSeqWithParam;

		// Token: 0x0400C39F RID: 50079
		[Token(Token = "0x400C39F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenSlotActionTw;

		// Token: 0x0400C3A0 RID: 50080
		[Token(Token = "0x400C3A0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenCharslotJump;

		// Token: 0x0400C3A1 RID: 50081
		[Token(Token = "0x400C3A1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenCharslotZoom;

		// Token: 0x0400C3A2 RID: 50082
		[Token(Token = "0x400C3A2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenCharslotShake;

		// Token: 0x0400C3A3 RID: 50083
		[Token(Token = "0x400C3A3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenCharslotMove;

		// Token: 0x0400C3A4 RID: 50084
		[Token(Token = "0x400C3A4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GenCharslotShakemove;

		// Token: 0x0400C3A5 RID: 50085
		[Token(Token = "0x400C3A5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetSlotColorWithFocus;

		// Token: 0x0400C3A6 RID: 50086
		[Token(Token = "0x400C3A6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetSlotFocusStatus;

		// Token: 0x0400C3A7 RID: 50087
		[Token(Token = "0x400C3A7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ProcessCharFocus;

		// Token: 0x0400C3A8 RID: 50088
		[Token(Token = "0x400C3A8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetSlotWithName;

		// Token: 0x0400C3A9 RID: 50089
		[Token(Token = "0x400C3A9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetCachedSlotSeq;

		// Token: 0x0400C3AA RID: 50090
		[Token(Token = "0x400C3AA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ClearSeq;

		// Token: 0x0400C3AB RID: 50091
		[Token(Token = "0x400C3AB")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C3AC RID: 50092
		[Token(Token = "0x400C3AC")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C3AD RID: 50093
		[Token(Token = "0x400C3AD")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400C3AE RID: 50094
		[Token(Token = "0x400C3AE")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__InitCamEffectBind;

		// Token: 0x0400C3AF RID: 50095
		[Token(Token = "0x400C3AF")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x0400C3B0 RID: 50096
		[Token(Token = "0x400C3B0")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C3B1 RID: 50097
		[Token(Token = "0x400C3B1")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C3B2 RID: 50098
		[Token(Token = "0x400C3B2")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001E98 RID: 7832
		[Token(Token = "0x2001E98")]
		public class TweenerOptions
		{
			// Token: 0x0600C20C RID: 49676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C20C")]
			[Address(RVA = "0x3404FD0", Offset = "0x3403BD0", VA = "0x183404FD0")]
			public TweenerOptions()
			{
			}

			// Token: 0x0400C3B3 RID: 50099
			[Token(Token = "0x400C3B3")]
			[FieldOffset(Offset = "0x10")]
			public string slotType;

			// Token: 0x0400C3B4 RID: 50100
			[Token(Token = "0x400C3B4")]
			[FieldOffset(Offset = "0x18")]
			public string charName;

			// Token: 0x0400C3B5 RID: 50101
			[Token(Token = "0x400C3B5")]
			[FieldOffset(Offset = "0x20")]
			public string[] focusArray;

			// Token: 0x0400C3B6 RID: 50102
			[Token(Token = "0x400C3B6")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 posFrom;

			// Token: 0x0400C3B7 RID: 50103
			[Token(Token = "0x400C3B7")]
			[FieldOffset(Offset = "0x30")]
			public Vector2 posTo;

			// Token: 0x0400C3B8 RID: 50104
			[Token(Token = "0x400C3B8")]
			[FieldOffset(Offset = "0x38")]
			public Vector2 zoomPos;

			// Token: 0x0400C3B9 RID: 50105
			[Token(Token = "0x400C3B9")]
			[FieldOffset(Offset = "0x40")]
			public Color color;

			// Token: 0x0400C3BA RID: 50106
			[Token(Token = "0x400C3BA")]
			[FieldOffset(Offset = "0x50")]
			public float delay;

			// Token: 0x0400C3BB RID: 50107
			[Token(Token = "0x400C3BB")]
			[FieldOffset(Offset = "0x54")]
			public float alphaFrom;

			// Token: 0x0400C3BC RID: 50108
			[Token(Token = "0x400C3BC")]
			[FieldOffset(Offset = "0x58")]
			public float alphaTo;

			// Token: 0x0400C3BD RID: 50109
			[Token(Token = "0x400C3BD")]
			[FieldOffset(Offset = "0x60")]
			public string actionName;

			// Token: 0x0400C3BE RID: 50110
			[Token(Token = "0x400C3BE")]
			[FieldOffset(Offset = "0x68")]
			public float duration;

			// Token: 0x0400C3BF RID: 50111
			[Token(Token = "0x400C3BF")]
			[FieldOffset(Offset = "0x6C")]
			public float blackStart;

			// Token: 0x0400C3C0 RID: 50112
			[Token(Token = "0x400C3C0")]
			[FieldOffset(Offset = "0x70")]
			public float blackEnd;

			// Token: 0x0400C3C1 RID: 50113
			[Token(Token = "0x400C3C1")]
			[FieldOffset(Offset = "0x74")]
			public bool blackMaskInverse;

			// Token: 0x0400C3C2 RID: 50114
			[Token(Token = "0x400C3C2")]
			[FieldOffset(Offset = "0x75")]
			public bool isEnd;

			// Token: 0x0400C3C3 RID: 50115
			[Token(Token = "0x400C3C3")]
			[FieldOffset(Offset = "0x76")]
			public bool isBlock;

			// Token: 0x0400C3C4 RID: 50116
			[Token(Token = "0x400C3C4")]
			[FieldOffset(Offset = "0x77")]
			public bool enableGlitch;

			// Token: 0x0400C3C5 RID: 50117
			[Token(Token = "0x400C3C5")]
			[FieldOffset(Offset = "0x78")]
			public string matSettingName;

			// Token: 0x0400C3C6 RID: 50118
			[Token(Token = "0x400C3C6")]
			[FieldOffset(Offset = "0x80")]
			public float power;

			// Token: 0x0400C3C7 RID: 50119
			[Token(Token = "0x400C3C7")]
			[FieldOffset(Offset = "0x84")]
			public int times;

			// Token: 0x0400C3C8 RID: 50120
			[Token(Token = "0x400C3C8")]
			[FieldOffset(Offset = "0x88")]
			public int shakeRandom;

			// Token: 0x0400C3C9 RID: 50121
			[Token(Token = "0x400C3C9")]
			[FieldOffset(Offset = "0x8C")]
			public float scale;
		}

		// Token: 0x02001E99 RID: 7833
		[Token(Token = "0x2001E99")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C20D RID: 49677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C20D")]
			[Address(RVA = "0x3404920", Offset = "0x3403520", VA = "0x183404920", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C20E RID: 49678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C20E")]
			[Address(RVA = "0x34044F0", Offset = "0x34030F0", VA = "0x1834044F0", Slot = "5")]
			public override void GatherResFilenames(Command command, HashSet<string> filenames)
			{
			}

			// Token: 0x0600C20F RID: 49679 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C20F")]
			[Address(RVA = "0x3404C30", Offset = "0x3403830", VA = "0x183404C30")]
			private string _StripResPath(string name)
			{
				return null;
			}

			// Token: 0x0600C210 RID: 49680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C210")]
			[Address(RVA = "0x3404CD0", Offset = "0x34038D0", VA = "0x183404CD0")]
			public InternalResRefCollector()
			{
			}

			// Token: 0x0400C3CA RID: 50122
			[Token(Token = "0x400C3CA")]
			[FieldOffset(Offset = "0x10")]
			private Regex m_regex;
		}
	}
}
