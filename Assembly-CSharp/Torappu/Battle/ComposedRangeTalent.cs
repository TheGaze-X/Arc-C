using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200246E RID: 9326
	[Token(Token = "0x200246E")]
	public class ComposedRangeTalent : Talent
	{
		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x0600F01E RID: 61470 RVA: 0x00058788 File Offset: 0x00056988
		[Token(Token = "0x17001F36")]
		public override bool attachInDummy
		{
			[Token(Token = "0x600F01E")]
			[Address(RVA = "0x66F840", Offset = "0x66E440", VA = "0x18066F840", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x0600F01F RID: 61471 RVA: 0x000587A0 File Offset: 0x000569A0
		[Token(Token = "0x17001F37")]
		public override bool isAttached
		{
			[Token(Token = "0x600F01F")]
			[Address(RVA = "0x66F8A0", Offset = "0x66E4A0", VA = "0x18066F8A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F020 RID: 61472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F020")]
		[Address(RVA = "0x66E3A0", Offset = "0x66CFA0", VA = "0x18066E3A0", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F021 RID: 61473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F021")]
		[Address(RVA = "0x66E5B0", Offset = "0x66D1B0", VA = "0x18066E5B0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F022 RID: 61474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F022")]
		[Address(RVA = "0x66EB70", Offset = "0x66D770", VA = "0x18066EB70")]
		private IEnumerator _AttachRangesCoroutine()
		{
			return null;
		}

		// Token: 0x0600F023 RID: 61475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F023")]
		[Address(RVA = "0x66EC20", Offset = "0x66D820", VA = "0x18066EC20")]
		private void _AttachRanges(object _)
		{
		}

		// Token: 0x0600F024 RID: 61476 RVA: 0x000587B8 File Offset: 0x000569B8
		[Token(Token = "0x600F024")]
		[Address(RVA = "0x66F470", Offset = "0x66E070", VA = "0x18066F470")]
		private bool _PrepareLinkRange()
		{
			return default(bool);
		}

		// Token: 0x0600F025 RID: 61477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F025")]
		[Address(RVA = "0x66F180", Offset = "0x66DD80", VA = "0x18066F180")]
		private void _AttachSkillIfCharacter(Character character, ref List<ComposedRange> ranges)
		{
		}

		// Token: 0x0600F026 RID: 61478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F026")]
		[Address(RVA = "0x66F310", Offset = "0x66DF10", VA = "0x18066F310")]
		private void _AttachUnitModeAttack(Unit unit, ref List<ComposedRange> ranges)
		{
		}

		// Token: 0x0600F027 RID: 61479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F027")]
		[Address(RVA = "0x66E950", Offset = "0x66D550", VA = "0x18066E950")]
		private void _AttachAbilities(Unit unit, ref List<ComposedRange> ranges)
		{
		}

		// Token: 0x0600F028 RID: 61480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F028")]
		[Address(RVA = "0x66E870", Offset = "0x66D470", VA = "0x18066E870")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600F029 RID: 61481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F029")]
		[Address(RVA = "0x66F730", Offset = "0x66E330", VA = "0x18066F730")]
		public ComposedRangeTalent()
		{
		}

		// Token: 0x0600F02A RID: 61482 RVA: 0x000587D0 File Offset: 0x000569D0
		[Token(Token = "0x600F02A")]
		[Address(RVA = "0x66E940", Offset = "0x66D540", VA = "0x18066E940")]
		private bool <>xLuaBaseProxy_get_attachInDummy()
		{
			return default(bool);
		}

		// Token: 0x0600F02B RID: 61483 RVA: 0x000587E8 File Offset: 0x000569E8
		[Token(Token = "0x600F02B")]
		[Address(RVA = "0x66C800", Offset = "0x66B400", VA = "0x18066C800")]
		private bool <>xLuaBaseProxy_get_isAttached()
		{
			return default(bool);
		}

		// Token: 0x0600F02C RID: 61484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F02C")]
		[Address(RVA = "0x66A3B0", Offset = "0x668FB0", VA = "0x18066A3B0")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F02D RID: 61485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F02D")]
		[Address(RVA = "0x66A420", Offset = "0x669020", VA = "0x18066A420")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04010986 RID: 67974
		[Token(Token = "0x4010986")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _useSkillRangeId;

		// Token: 0x04010987 RID: 67975
		[Token(Token = "0x4010987")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Range _range;

		// Token: 0x04010988 RID: 67976
		[Token(Token = "0x4010988")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<string> _attachedSkillIds;

		// Token: 0x04010989 RID: 67977
		[Token(Token = "0x4010989")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<string> _attachedAbilityNames;

		// Token: 0x0401098A RID: 67978
		[Token(Token = "0x401098A")]
		[FieldOffset(Offset = "0xB0")]
		private List<ComposedRange> m_ranges;

		// Token: 0x0401098B RID: 67979
		[Token(Token = "0x401098B")]
		[FieldOffset(Offset = "0xB8")]
		private List<Range> m_linkRange;

		// Token: 0x0401098C RID: 67980
		[Token(Token = "0x401098C")]
		[FieldOffset(Offset = "0xC0")]
		private CoroutineId m_attachCoroutine;

		// Token: 0x0401098D RID: 67981
		[Token(Token = "0x401098D")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isAttached;

		// Token: 0x0401098E RID: 67982
		[Token(Token = "0x401098E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_attachInDummy;

		// Token: 0x0401098F RID: 67983
		[Token(Token = "0x401098F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAttached;

		// Token: 0x04010990 RID: 67984
		[Token(Token = "0x4010990")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010991 RID: 67985
		[Token(Token = "0x4010991")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010992 RID: 67986
		[Token(Token = "0x4010992")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AttachRangesCoroutine;

		// Token: 0x04010993 RID: 67987
		[Token(Token = "0x4010993")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AttachRanges;

		// Token: 0x04010994 RID: 67988
		[Token(Token = "0x4010994")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PrepareLinkRange;

		// Token: 0x04010995 RID: 67989
		[Token(Token = "0x4010995")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AttachSkillIfCharacter;

		// Token: 0x04010996 RID: 67990
		[Token(Token = "0x4010996")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AttachUnitModeAttack;

		// Token: 0x04010997 RID: 67991
		[Token(Token = "0x4010997")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AttachAbilities;

		// Token: 0x04010998 RID: 67992
		[Token(Token = "0x4010998")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04010999 RID: 67993
		[Token(Token = "0x4010999")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
