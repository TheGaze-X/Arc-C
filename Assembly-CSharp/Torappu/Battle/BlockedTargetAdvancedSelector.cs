using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002506 RID: 9478
	[Token(Token = "0x2002506")]
	public class BlockedTargetAdvancedSelector : AdvancedSelector
	{
		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x0600F420 RID: 62496 RVA: 0x0005A168 File Offset: 0x00058368
		[Token(Token = "0x17001FCC")]
		protected bool shrinkInTheEnd
		{
			[Token(Token = "0x600F420")]
			[Address(RVA = "0x6B9730", Offset = "0x6B8330", VA = "0x1806B9730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F421 RID: 62497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F421")]
		[Address(RVA = "0x6B9270", Offset = "0x6B7E70", VA = "0x1806B9270", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F422 RID: 62498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F422")]
		[Address(RVA = "0x6B8FE0", Offset = "0x6B7BE0", VA = "0x1806B8FE0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F423 RID: 62499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F423")]
		[Address(RVA = "0x6B96D0", Offset = "0x6B82D0", VA = "0x1806B96D0")]
		public BlockedTargetAdvancedSelector()
		{
		}

		// Token: 0x0600F425 RID: 62501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F425")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F426 RID: 62502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F426")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010E4C RID: 69196
		[Token(Token = "0x4010E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _shrinkInTheEnd;

		// Token: 0x04010E4D RID: 69197
		[Token(Token = "0x4010E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private int _shrinkNum;

		// Token: 0x04010E4E RID: 69198
		[Token(Token = "0x4010E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool _pickMyTokenFirst;

		// Token: 0x04010E4F RID: 69199
		[Token(Token = "0x4010E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Character m_character;

		// Token: 0x04010E50 RID: 69200
		[Token(Token = "0x4010E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shrinkInTheEnd;

		// Token: 0x04010E51 RID: 69201
		[Token(Token = "0x4010E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010E52 RID: 69202
		[Token(Token = "0x4010E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010E53 RID: 69203
		[Token(Token = "0x4010E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
