using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F8 RID: 9464
	[Token(Token = "0x20024F8")]
	public class AdvancedSelectorWithTagFilteredWithCreatedTime : AdvancedSelector
	{
		// Token: 0x0600F3C5 RID: 62405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C5")]
		[Address(RVA = "0x6A17C0", Offset = "0x6A03C0", VA = "0x1806A17C0", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F3C6 RID: 62406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C6")]
		[Address(RVA = "0x6A14F0", Offset = "0x6A00F0", VA = "0x1806A14F0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3C7 RID: 62407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C7")]
		[Address(RVA = "0x6A18A0", Offset = "0x6A04A0", VA = "0x1806A18A0")]
		public AdvancedSelectorWithTagFilteredWithCreatedTime()
		{
		}

		// Token: 0x0600F3C8 RID: 62408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C8")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F3C9 RID: 62409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3C9")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DF1 RID: 69105
		[Token(Token = "0x4010DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CompareType _compareWithOwnerCreatedTime;

		// Token: 0x04010DF2 RID: 69106
		[Token(Token = "0x4010DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool _tagExcluded;

		// Token: 0x04010DF3 RID: 69107
		[Token(Token = "0x4010DF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private string _filterTag;

		// Token: 0x04010DF4 RID: 69108
		[Token(Token = "0x4010DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private FP m_ownerCreatedTime;

		// Token: 0x04010DF5 RID: 69109
		[Token(Token = "0x4010DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private uint m_instanceUid;

		// Token: 0x04010DF6 RID: 69110
		[Token(Token = "0x4010DF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010DF7 RID: 69111
		[Token(Token = "0x4010DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DF8 RID: 69112
		[Token(Token = "0x4010DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
