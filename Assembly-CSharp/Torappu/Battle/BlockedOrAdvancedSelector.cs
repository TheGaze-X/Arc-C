using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024FF RID: 9471
	[Token(Token = "0x20024FF")]
	public class BlockedOrAdvancedSelector : BlockedBaseSelector
	{
		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x0600F3E9 RID: 62441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F3EA RID: 62442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001FC0")]
		private protected Character character
		{
			[Token(Token = "0x600F3E9")]
			[Address(RVA = "0x6B6A30", Offset = "0x6B5630", VA = "0x1806B6A30")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600F3EA")]
			[Address(RVA = "0x6B6AF0", Offset = "0x6B56F0", VA = "0x1806B6AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x0600F3EB RID: 62443 RVA: 0x00059F40 File Offset: 0x00058140
		[Token(Token = "0x17001FC1")]
		protected bool limitedMaxTargetNumToBlockedCnt
		{
			[Token(Token = "0x600F3EB")]
			[Address(RVA = "0x6B6A90", Offset = "0x6B5690", VA = "0x1806B6A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x0600F3EC RID: 62444 RVA: 0x00059F58 File Offset: 0x00058158
		[Token(Token = "0x17001FC2")]
		protected bool allowZeroBlockCntLimit
		{
			[Token(Token = "0x600F3EC")]
			[Address(RVA = "0x6B69D0", Offset = "0x6B55D0", VA = "0x1806B69D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F3ED RID: 62445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3ED")]
		[Address(RVA = "0x6B6720", Offset = "0x6B5320", VA = "0x1806B6720", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F3EE RID: 62446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3EE")]
		[Address(RVA = "0x6B6120", Offset = "0x6B4D20", VA = "0x1806B6120", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F3EF RID: 62447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3EF")]
		[Address(RVA = "0x6B60A0", Offset = "0x6B4CA0", VA = "0x1806B60A0")]
		protected ReusableList<Entity> DoBaseFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F3F0 RID: 62448 RVA: 0x00059F70 File Offset: 0x00058170
		[Token(Token = "0x600F3F0")]
		[Address(RVA = "0x6B6880", Offset = "0x6B5480", VA = "0x1806B6880", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F3F1 RID: 62449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3F1")]
		[Address(RVA = "0x6B6930", Offset = "0x6B5530", VA = "0x1806B6930")]
		public BlockedOrAdvancedSelector()
		{
		}

		// Token: 0x0600F3F2 RID: 62450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3F2")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F3F3 RID: 62451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3F3")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F3F4 RID: 62452 RVA: 0x00059F88 File Offset: 0x00058188
		[Token(Token = "0x600F3F4")]
		[Address(RVA = "0x6B51E0", Offset = "0x6B3DE0", VA = "0x1806B51E0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010E16 RID: 69142
		[Token(Token = "0x4010E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _limitedMaxTargetNumToBlockedCnt;

		// Token: 0x04010E17 RID: 69143
		[Token(Token = "0x4010E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[SerializeField]
		private bool _allowZeroBlockCntLimit;

		// Token: 0x04010E18 RID: 69144
		[Token(Token = "0x4010E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected List<Entity> m_tmpList;

		// Token: 0x04010E1A RID: 69146
		[Token(Token = "0x4010E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04010E1B RID: 69147
		[Token(Token = "0x4010E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x04010E1C RID: 69148
		[Token(Token = "0x4010E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_limitedMaxTargetNumToBlockedCnt;

		// Token: 0x04010E1D RID: 69149
		[Token(Token = "0x4010E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_allowZeroBlockCntLimit;

		// Token: 0x04010E1E RID: 69150
		[Token(Token = "0x4010E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010E1F RID: 69151
		[Token(Token = "0x4010E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010E20 RID: 69152
		[Token(Token = "0x4010E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoBaseFindTargets_DISPOSE;

		// Token: 0x04010E21 RID: 69153
		[Token(Token = "0x4010E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010E22 RID: 69154
		[Token(Token = "0x4010E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
