using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024E5 RID: 9445
	[Token(Token = "0x20024E5")]
	public class AdvancedSelectorWithBuffStackcount : AdvancedSelector
	{
		// Token: 0x0600F365 RID: 62309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F365")]
		[Address(RVA = "0x69BAF0", Offset = "0x69A6F0", VA = "0x18069BAF0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F366 RID: 62310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F366")]
		[Address(RVA = "0x69BA60", Offset = "0x69A660", VA = "0x18069BA60", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F367 RID: 62311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F367")]
		[Address(RVA = "0x69BBA0", Offset = "0x69A7A0", VA = "0x18069BBA0")]
		private void _CheckBuff(List<Entity> candidates)
		{
		}

		// Token: 0x0600F368 RID: 62312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F368")]
		[Address(RVA = "0x69BED0", Offset = "0x69AAD0", VA = "0x18069BED0")]
		public AdvancedSelectorWithBuffStackcount()
		{
		}

		// Token: 0x0600F369 RID: 62313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F369")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F36A RID: 62314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F36A")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010D51 RID: 68945
		[Token(Token = "0x4010D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x04010D52 RID: 68946
		[Token(Token = "0x4010D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private uint _buffStackcount;

		// Token: 0x04010D53 RID: 68947
		[Token(Token = "0x4010D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private bool _keepMinistAsCnt;

		// Token: 0x04010D54 RID: 68948
		[Token(Token = "0x4010D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		[SerializeField]
		private bool notCheckContainsBuff;

		// Token: 0x04010D55 RID: 68949
		[Token(Token = "0x4010D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CompareType _compareType;

		// Token: 0x04010D56 RID: 68950
		[Token(Token = "0x4010D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private uint m_buffStackCnt;

		// Token: 0x04010D57 RID: 68951
		[Token(Token = "0x4010D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010D58 RID: 68952
		[Token(Token = "0x4010D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010D59 RID: 68953
		[Token(Token = "0x4010D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckBuff;

		// Token: 0x04010D5A RID: 68954
		[Token(Token = "0x4010D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
