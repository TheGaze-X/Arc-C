using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002500 RID: 9472
	[Token(Token = "0x2002500")]
	public class BlockedOrAdvancedSelectorWithBuffStackCount : BlockedOrAdvancedSelector
	{
		// Token: 0x0600F3F5 RID: 62453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3F5")]
		[Address(RVA = "0x6B5710", Offset = "0x6B4310", VA = "0x1806B5710", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3F6 RID: 62454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3F6")]
		[Address(RVA = "0x6B5790", Offset = "0x6B4390", VA = "0x1806B5790")]
		private void _CheckBuff(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3F7 RID: 62455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3F7")]
		[Address(RVA = "0x6B5990", Offset = "0x6B4590", VA = "0x1806B5990")]
		public BlockedOrAdvancedSelectorWithBuffStackCount()
		{
		}

		// Token: 0x0600F3F8 RID: 62456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3F8")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010E23 RID: 69155
		[Token(Token = "0x4010E23")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x04010E24 RID: 69156
		[Token(Token = "0x4010E24")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private uint _buffStackcount;

		// Token: 0x04010E25 RID: 69157
		[Token(Token = "0x4010E25")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private CompareType _compareType;

		// Token: 0x04010E26 RID: 69158
		[Token(Token = "0x4010E26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010E27 RID: 69159
		[Token(Token = "0x4010E27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckBuff;

		// Token: 0x04010E28 RID: 69160
		[Token(Token = "0x4010E28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
