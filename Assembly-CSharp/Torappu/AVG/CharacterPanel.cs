using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EC4 RID: 7876
	[Token(Token = "0x2001EC4")]
	public class CharacterPanel : ExecutorComponent, IContainsResRefs, IFadeTimeRatio
	{
		// Token: 0x0600C32D RID: 49965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C32D")]
		[Address(RVA = "0x3407920", Offset = "0x3406520", VA = "0x183407920", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C32E RID: 49966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C32E")]
		[Address(RVA = "0x3407B50", Offset = "0x3406750", VA = "0x183407B50", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C32F RID: 49967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C32F")]
		[Address(RVA = "0x3407830", Offset = "0x3406430", VA = "0x183407830", Slot = "13")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C330 RID: 49968 RVA: 0x00047A18 File Offset: 0x00045C18
		[Token(Token = "0x600C330")]
		[Address(RVA = "0x3409440", Offset = "0x3408040", VA = "0x183409440")]
		private bool _ExecuteCharacter(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C331 RID: 49969 RVA: 0x00047A30 File Offset: 0x00045C30
		[Token(Token = "0x600C331")]
		[Address(RVA = "0x3409CF0", Offset = "0x34088F0", VA = "0x183409CF0")]
		private Vector2 _GenPosition(CharacterPanel.ECharSlot slot, string enter)
		{
			return default(Vector2);
		}

		// Token: 0x0600C332 RID: 49970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C332")]
		[Address(RVA = "0x3409FB0", Offset = "0x3408BB0", VA = "0x183409FB0")]
		private void _ProcessSlotWithParam(Command command, string name, CharacterPanel.ECharSlot slot, int focus, float duration, CharacterPanel.ECharTransType transType, string nEnter, string nStart, string nEnd, string nPosx, string nPosy)
		{
		}

		// Token: 0x0600C333 RID: 49971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C333")]
		[Address(RVA = "0x340A540", Offset = "0x3409140", VA = "0x18340A540")]
		private void _ProcessSlot(CharacterPanel.ECharSlot slot, CharacterPanel.CharSlotParam param)
		{
		}

		// Token: 0x0600C334 RID: 49972 RVA: 0x00047A48 File Offset: 0x00045C48
		[Token(Token = "0x600C334")]
		[Address(RVA = "0x3409F20", Offset = "0x3408B20", VA = "0x183409F20")]
		private float _ProcessDurationWithTransType(float duration, CharacterPanel.ECharTransType tType)
		{
			return 0f;
		}

		// Token: 0x0600C335 RID: 49973 RVA: 0x00047A60 File Offset: 0x00045C60
		[Token(Token = "0x600C335")]
		[Address(RVA = "0x3407DC0", Offset = "0x34069C0", VA = "0x183407DC0")]
		private bool _ExecuteCharacterAction(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C336 RID: 49974 RVA: 0x00047A78 File Offset: 0x00045C78
		[Token(Token = "0x600C336")]
		[Address(RVA = "0x34088C0", Offset = "0x34074C0", VA = "0x1834088C0")]
		private bool _ExecuteCharacterMove(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x00047A90 File Offset: 0x00045C90
		[Token(Token = "0x600C337")]
		[Address(RVA = "0x3408410", Offset = "0x3407010", VA = "0x183408410")]
		private bool _ExecuteCharacterJump(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C338 RID: 49976 RVA: 0x00047AA8 File Offset: 0x00045CA8
		[Token(Token = "0x600C338")]
		[Address(RVA = "0x3408C30", Offset = "0x3407830", VA = "0x183408C30")]
		private bool _ExecuteCharacterShake(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C339 RID: 49977 RVA: 0x00047AC0 File Offset: 0x00045CC0
		[Token(Token = "0x600C339")]
		[Address(RVA = "0x3409050", Offset = "0x3407C50", VA = "0x183409050")]
		private bool _ExecuteCharacterZoom(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C33A RID: 49978 RVA: 0x00047AD8 File Offset: 0x00045CD8
		[Token(Token = "0x600C33A")]
		[Address(RVA = "0x3408050", Offset = "0x3406C50", VA = "0x183408050")]
		private bool _ExecuteCharacterExit(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C33B RID: 49979 RVA: 0x00047AF0 File Offset: 0x00045CF0
		[Token(Token = "0x600C33B")]
		[Address(RVA = "0x34099F0", Offset = "0x34085F0", VA = "0x1834099F0")]
		private Vector2 _GenExitPosition(string slot, string direction)
		{
			return default(Vector2);
		}

		// Token: 0x0600C33C RID: 49980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C33C")]
		[Address(RVA = "0x34078C0", Offset = "0x34064C0", VA = "0x1834078C0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C33D RID: 49981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C33D")]
		[Address(RVA = "0x3407BF0", Offset = "0x34067F0", VA = "0x183407BF0", Slot = "6")]
		public override void OnStoryEnd(Story story)
		{
		}

		// Token: 0x0600C33E RID: 49982 RVA: 0x00047B08 File Offset: 0x00045D08
		[Token(Token = "0x600C33E")]
		[Address(RVA = "0x3407CB0", Offset = "0x34068B0", VA = "0x183407CB0")]
		private bool _AddFinishCommand(bool block, Tween tween)
		{
			return default(bool);
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x00047B20 File Offset: 0x00045D20
		[Token(Token = "0x600C33F")]
		[Address(RVA = "0x3407790", Offset = "0x3406390", VA = "0x183407790", Slot = "14")]
		public float CalculateFadetime(float initialFadetime)
		{
			return 0f;
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x00047B38 File Offset: 0x00045D38
		[Token(Token = "0x600C340")]
		[Address(RVA = "0x3407AB0", Offset = "0x34066B0", VA = "0x183407AB0", Slot = "15")]
		public bool NeedSkipAnimation(float fadetime)
		{
			return default(bool);
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C341")]
		[Address(RVA = "0x340A940", Offset = "0x3409540", VA = "0x18340A940")]
		public CharacterPanel()
		{
		}

		// Token: 0x0600C342 RID: 49986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C342")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C343 RID: 49987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C343")]
		[Address(RVA = "0x33F0E80", Offset = "0x33EFA80", VA = "0x1833F0E80")]
		private void <>xLuaBaseProxy_OnStoryEnd(Story P0)
		{
		}

		// Token: 0x0400C53C RID: 50492
		[Token(Token = "0x400C53C")]
		private const float HORIZONTAL_OUTSCREEN_DELTA = 1152f;

		// Token: 0x0400C53D RID: 50493
		[Token(Token = "0x400C53D")]
		private const float VERTICAL_OUTSCREEN_DELTA = 1072f;

		// Token: 0x0400C53E RID: 50494
		[Token(Token = "0x400C53E")]
		private const float LEFT_CHAR_HORIZONAL_DELTA = 200f;

		// Token: 0x0400C53F RID: 50495
		[Token(Token = "0x400C53F")]
		private const string PARAM_NAME_ENTER_1 = "enter";

		// Token: 0x0400C540 RID: 50496
		[Token(Token = "0x400C540")]
		private const string PARAM_NAME_ENTER_2 = "enter2";

		// Token: 0x0400C541 RID: 50497
		[Token(Token = "0x400C541")]
		private const string PARAM_NAME_BSTART_1 = "blackstart";

		// Token: 0x0400C542 RID: 50498
		[Token(Token = "0x400C542")]
		private const string PARAM_NAME_BSTART_2 = "blackstart2";

		// Token: 0x0400C543 RID: 50499
		[Token(Token = "0x400C543")]
		private const string PARAM_NAME_BEND_1 = "blackend";

		// Token: 0x0400C544 RID: 50500
		[Token(Token = "0x400C544")]
		private const string PARAM_NAME_BEND_2 = "blackend2";

		// Token: 0x0400C545 RID: 50501
		[Token(Token = "0x400C545")]
		private const string PARAM_NAME_XPOS_1 = "xpos1";

		// Token: 0x0400C546 RID: 50502
		[Token(Token = "0x400C546")]
		private const string PARAM_NAME_YPOS_1 = "ypos1";

		// Token: 0x0400C547 RID: 50503
		[Token(Token = "0x400C547")]
		private const string PARAM_NAME_XPOS_2 = "xpos2";

		// Token: 0x0400C548 RID: 50504
		[Token(Token = "0x400C548")]
		private const string PARAM_NAME_YPOS_2 = "ypos2";

		// Token: 0x0400C549 RID: 50505
		[Token(Token = "0x400C549")]
		private const float DEFAULT_FADE_TIME = 0.15f;

		// Token: 0x0400C54A RID: 50506
		[Token(Token = "0x400C54A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGCharacterSlot _middleSlot;

		// Token: 0x0400C54B RID: 50507
		[Token(Token = "0x400C54B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AVGCharacterSlot _leftSlot;

		// Token: 0x0400C54C RID: 50508
		[Token(Token = "0x400C54C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AVGCharacterSlot _rightSlot;

		// Token: 0x0400C54D RID: 50509
		[Token(Token = "0x400C54D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _focusColor;

		// Token: 0x0400C54E RID: 50510
		[Token(Token = "0x400C54E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _unfocusColor;

		// Token: 0x0400C54F RID: 50511
		[Token(Token = "0x400C54F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C550 RID: 50512
		[Token(Token = "0x400C550")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C551 RID: 50513
		[Token(Token = "0x400C551")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C552 RID: 50514
		[Token(Token = "0x400C552")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteCharacter;

		// Token: 0x0400C553 RID: 50515
		[Token(Token = "0x400C553")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenPosition;

		// Token: 0x0400C554 RID: 50516
		[Token(Token = "0x400C554")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ProcessSlotWithParam;

		// Token: 0x0400C555 RID: 50517
		[Token(Token = "0x400C555")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ProcessSlot;

		// Token: 0x0400C556 RID: 50518
		[Token(Token = "0x400C556")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ProcessDurationWithTransType;

		// Token: 0x0400C557 RID: 50519
		[Token(Token = "0x400C557")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExecuteCharacterAction;

		// Token: 0x0400C558 RID: 50520
		[Token(Token = "0x400C558")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExecuteCharacterMove;

		// Token: 0x0400C559 RID: 50521
		[Token(Token = "0x400C559")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ExecuteCharacterJump;

		// Token: 0x0400C55A RID: 50522
		[Token(Token = "0x400C55A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExecuteCharacterShake;

		// Token: 0x0400C55B RID: 50523
		[Token(Token = "0x400C55B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExecuteCharacterZoom;

		// Token: 0x0400C55C RID: 50524
		[Token(Token = "0x400C55C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ExecuteCharacterExit;

		// Token: 0x0400C55D RID: 50525
		[Token(Token = "0x400C55D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenExitPosition;

		// Token: 0x0400C55E RID: 50526
		[Token(Token = "0x400C55E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C55F RID: 50527
		[Token(Token = "0x400C55F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x0400C560 RID: 50528
		[Token(Token = "0x400C560")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__AddFinishCommand;

		// Token: 0x0400C561 RID: 50529
		[Token(Token = "0x400C561")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CalculateFadetime;

		// Token: 0x0400C562 RID: 50530
		[Token(Token = "0x400C562")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_NeedSkipAnimation;

		// Token: 0x0400C563 RID: 50531
		[Token(Token = "0x400C563")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EC5 RID: 7877
		[Token(Token = "0x2001EC5")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C344 RID: 49988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C344")]
			[Address(RVA = "0x34134B0", Offset = "0x34120B0", VA = "0x1834134B0", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C345 RID: 49989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C345")]
			[Address(RVA = "0x3413090", Offset = "0x3411C90", VA = "0x183413090", Slot = "5")]
			public override void GatherResFilenames(Command command, HashSet<string> filenames)
			{
			}

			// Token: 0x0600C346 RID: 49990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C346")]
			[Address(RVA = "0x3404C30", Offset = "0x3403830", VA = "0x183404C30")]
			private string _StripResPath(string name)
			{
				return null;
			}

			// Token: 0x0600C347 RID: 49991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C347")]
			[Address(RVA = "0x3413610", Offset = "0x3412210", VA = "0x183413610")]
			public InternalResRefCollector()
			{
			}

			// Token: 0x0400C564 RID: 50532
			[Token(Token = "0x400C564")]
			[FieldOffset(Offset = "0x10")]
			private Regex m_regex;
		}

		// Token: 0x02001EC6 RID: 7878
		[Token(Token = "0x2001EC6")]
		public enum ECharTransType
		{
			// Token: 0x0400C566 RID: 50534
			[Token(Token = "0x400C566")]
			NONE,
			// Token: 0x0400C567 RID: 50535
			[Token(Token = "0x400C567")]
			ALPHA_IN,
			// Token: 0x0400C568 RID: 50536
			[Token(Token = "0x400C568")]
			ALPHA_OUT
		}

		// Token: 0x02001EC7 RID: 7879
		[Token(Token = "0x2001EC7")]
		private enum ECharSlot
		{
			// Token: 0x0400C56A RID: 50538
			[Token(Token = "0x400C56A")]
			NONE,
			// Token: 0x0400C56B RID: 50539
			[Token(Token = "0x400C56B")]
			LEFT,
			// Token: 0x0400C56C RID: 50540
			[Token(Token = "0x400C56C")]
			RIGHT,
			// Token: 0x0400C56D RID: 50541
			[Token(Token = "0x400C56D")]
			MIDDLE
		}

		// Token: 0x02001EC8 RID: 7880
		[Token(Token = "0x2001EC8")]
		private struct CharSlotParam
		{
			// Token: 0x0400C56E RID: 50542
			[Token(Token = "0x400C56E")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 position;

			// Token: 0x0400C56F RID: 50543
			[Token(Token = "0x400C56F")]
			[FieldOffset(Offset = "0x8")]
			public string name;

			// Token: 0x0400C570 RID: 50544
			[Token(Token = "0x400C570")]
			[FieldOffset(Offset = "0x10")]
			public int focus;

			// Token: 0x0400C571 RID: 50545
			[Token(Token = "0x400C571")]
			[FieldOffset(Offset = "0x14")]
			public Color charColor;

			// Token: 0x0400C572 RID: 50546
			[Token(Token = "0x400C572")]
			[FieldOffset(Offset = "0x24")]
			public float duration;

			// Token: 0x0400C573 RID: 50547
			[Token(Token = "0x400C573")]
			[FieldOffset(Offset = "0x28")]
			public bool enterNotNull;

			// Token: 0x0400C574 RID: 50548
			[Token(Token = "0x400C574")]
			[FieldOffset(Offset = "0x2C")]
			public float blackStart;

			// Token: 0x0400C575 RID: 50549
			[Token(Token = "0x400C575")]
			[FieldOffset(Offset = "0x30")]
			public float blackEnd;

			// Token: 0x0400C576 RID: 50550
			[Token(Token = "0x400C576")]
			[FieldOffset(Offset = "0x34")]
			public CharacterPanel.ECharTransType transType;

			// Token: 0x0400C577 RID: 50551
			[Token(Token = "0x400C577")]
			[FieldOffset(Offset = "0x38")]
			public bool blackMaskInverse;
		}
	}
}
