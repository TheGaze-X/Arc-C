using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200253D RID: 9533
	[Token(Token = "0x200253D")]
	public class UdflowAdvancedSelector : AdvancedSelector
	{
		// Token: 0x0600F5E8 RID: 62952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5E8")]
		[Address(RVA = "0x6EDFA0", Offset = "0x6ECBA0", VA = "0x1806EDFA0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5E9 RID: 62953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5E9")]
		[Address(RVA = "0x6EE940", Offset = "0x6ED540", VA = "0x1806EE940")]
		public UdflowAdvancedSelector()
		{
		}

		// Token: 0x0600F5EA RID: 62954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5EA")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x040110BB RID: 69819
		[Token(Token = "0x40110BB")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _allowDistance;

		// Token: 0x040110BC RID: 69820
		[Token(Token = "0x40110BC")]
		[FieldOffset(Offset = "0xF4")]
		private float m_lastValidLocationComponent;

		// Token: 0x040110BD RID: 69821
		[Token(Token = "0x40110BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x040110BE RID: 69822
		[Token(Token = "0x40110BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
