using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004062 RID: 16482
	[Token(Token = "0x2004062")]
	internal class SandboxV2AdminMainTabPanelDefinedList : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x060197F1 RID: 104433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CBD")]
		public IList<SandboxV2AdminMainTabPanel> tabPanelList
		{
			[Token(Token = "0x60197F1")]
			[Address(RVA = "0x12308E0", Offset = "0x122F4E0", VA = "0x1812308E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060197F2 RID: 104434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197F2")]
		[Address(RVA = "0x1230880", Offset = "0x122F480", VA = "0x181230880")]
		public SandboxV2AdminMainTabPanelDefinedList()
		{
		}

		// Token: 0x0401FC68 RID: 130152
		[Token(Token = "0x401FC68")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2AdminMainTabPanel[] _definedTabPanels;

		// Token: 0x0401FC69 RID: 130153
		[Token(Token = "0x401FC69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tabPanelList;

		// Token: 0x0401FC6A RID: 130154
		[Token(Token = "0x401FC6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
