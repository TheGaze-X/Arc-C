using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F0 RID: 9456
	[Token(Token = "0x20024F0")]
	public class AdvancedSelectorWithInstanceUid : AdvancedSelector
	{
		// Token: 0x0600F39E RID: 62366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F39E")]
		[Address(RVA = "0x69E220", Offset = "0x69CE20", VA = "0x18069E220", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F39F RID: 62367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F39F")]
		[Address(RVA = "0x69E3D0", Offset = "0x69CFD0", VA = "0x18069E3D0")]
		public AdvancedSelectorWithInstanceUid()
		{
		}

		// Token: 0x0600F3A0 RID: 62368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3A0")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DB8 RID: 69048
		[Token(Token = "0x4010DB8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _blackboardKey;

		// Token: 0x04010DB9 RID: 69049
		[Token(Token = "0x4010DB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DBA RID: 69050
		[Token(Token = "0x4010DBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
