using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024EC RID: 9452
	[Token(Token = "0x20024EC")]
	public class AdvancedSelectorWithHostOrTokenRange : SecondaryFilterAdvancedSelector
	{
		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x0600F386 RID: 62342 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F387 RID: 62343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001FBB")]
		private protected Character character
		{
			[Token(Token = "0x600F386")]
			[Address(RVA = "0x69DFB0", Offset = "0x69CBB0", VA = "0x18069DFB0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600F387")]
			[Address(RVA = "0x69E010", Offset = "0x69CC10", VA = "0x18069E010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600F388 RID: 62344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F388")]
		[Address(RVA = "0x69DCF0", Offset = "0x69C8F0", VA = "0x18069DCF0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F389 RID: 62345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F389")]
		[Address(RVA = "0x69D8D0", Offset = "0x69C4D0", VA = "0x18069D8D0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F38A RID: 62346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F38A")]
		[Address(RVA = "0x69D280", Offset = "0x69BE80", VA = "0x18069D280", Slot = "42")]
		protected virtual void DoFindTargetsInHostOrTokenRange()
		{
		}

		// Token: 0x0600F38B RID: 62347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F38B")]
		[Address(RVA = "0x69DEC0", Offset = "0x69CAC0", VA = "0x18069DEC0")]
		public AdvancedSelectorWithHostOrTokenRange()
		{
		}

		// Token: 0x0600F38C RID: 62348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F38C")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F38D RID: 62349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F38D")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010D91 RID: 69009
		[Token(Token = "0x4010D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _fetchHost;

		// Token: 0x04010D93 RID: 69011
		[Token(Token = "0x4010D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<Entity> m_entities;

		// Token: 0x04010D94 RID: 69012
		[Token(Token = "0x4010D94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<Entity> m_extraTargets;

		// Token: 0x04010D95 RID: 69013
		[Token(Token = "0x4010D95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04010D96 RID: 69014
		[Token(Token = "0x4010D96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x04010D97 RID: 69015
		[Token(Token = "0x4010D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010D98 RID: 69016
		[Token(Token = "0x4010D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010D99 RID: 69017
		[Token(Token = "0x4010D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoFindTargetsInHostOrTokenRange;

		// Token: 0x04010D9A RID: 69018
		[Token(Token = "0x4010D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
