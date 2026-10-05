using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200259E RID: 9630
	[Token(Token = "0x200259E")]
	public class KeepInBattleResDisposer : SingletonWithMonoHost<KeepInBattleResDisposer, BattleController>, IDisposable
	{
		// Token: 0x0600F839 RID: 63545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F839")]
		[Address(RVA = "0x70FF10", Offset = "0x70EB10", VA = "0x18070FF10")]
		private KeepInBattleResDisposer()
		{
		}

		// Token: 0x0600F83A RID: 63546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83A")]
		[Address(RVA = "0x70FCB0", Offset = "0x70E8B0", VA = "0x18070FCB0")]
		public void BindKeepInBattleObject(KeepInBattleLoaderRoot comp)
		{
		}

		// Token: 0x0600F83B RID: 63547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83B")]
		[Address(RVA = "0x70FDC0", Offset = "0x70E9C0", VA = "0x18070FDC0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040113D5 RID: 70613
		[Token(Token = "0x40113D5")]
		[FieldOffset(Offset = "0x10")]
		private List<GameObject> m_objs;

		// Token: 0x040113D6 RID: 70614
		[Token(Token = "0x40113D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040113D7 RID: 70615
		[Token(Token = "0x40113D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindKeepInBattleObject;

		// Token: 0x040113D8 RID: 70616
		[Token(Token = "0x40113D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
