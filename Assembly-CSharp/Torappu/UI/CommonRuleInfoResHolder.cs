using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003752 RID: 14162
	[Token(Token = "0x2003752")]
	public class CommonRuleInfoResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x060167FA RID: 92154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035E8")]
		public List<CommonRuleInfoNodeView> infoRes
		{
			[Token(Token = "0x60167FA")]
			[Address(RVA = "0xED8D50", Offset = "0xED7950", VA = "0x180ED8D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060167FB RID: 92155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167FB")]
		[Address(RVA = "0xED8CF0", Offset = "0xED78F0", VA = "0x180ED8CF0")]
		public CommonRuleInfoResHolder()
		{
		}

		// Token: 0x0401B19E RID: 111006
		[Token(Token = "0x401B19E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CommonRuleInfoNodeView> _infoRes;

		// Token: 0x0401B19F RID: 111007
		[Token(Token = "0x401B19F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_infoRes;

		// Token: 0x0401B1A0 RID: 111008
		[Token(Token = "0x401B1A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
