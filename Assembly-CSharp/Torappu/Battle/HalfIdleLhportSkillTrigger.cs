using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002567 RID: 9575
	[Token(Token = "0x2002567")]
	[RequireComponent(typeof(TargetSelector))]
	public class HalfIdleLhportSkillTrigger : SelectorTrigger
	{
		// Token: 0x0600F71F RID: 63263 RVA: 0x0005C3A0 File Offset: 0x0005A5A0
		[Token(Token = "0x600F71F")]
		[Address(RVA = "0x70E4D0", Offset = "0x70D0D0", VA = "0x18070E4D0", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F720 RID: 63264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F720")]
		[Address(RVA = "0x70E640", Offset = "0x70D240", VA = "0x18070E640")]
		public HalfIdleLhportSkillTrigger()
		{
		}

		// Token: 0x0600F721 RID: 63265 RVA: 0x0005C3B8 File Offset: 0x0005A5B8
		[Token(Token = "0x600F721")]
		[Address(RVA = "0x6F1EC0", Offset = "0x6F0AC0", VA = "0x1806F1EC0")]
		private bool <>xLuaBaseProxy_Search(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04011284 RID: 70276
		[Token(Token = "0x4011284")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _envSystemKey;

		// Token: 0x04011285 RID: 70277
		[Token(Token = "0x4011285")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x04011286 RID: 70278
		[Token(Token = "0x4011286")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
