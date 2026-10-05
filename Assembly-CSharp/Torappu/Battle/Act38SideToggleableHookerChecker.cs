using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002144 RID: 8516
	[Token(Token = "0x2002144")]
	public class Act38SideToggleableHookerChecker : ToggleableHookerChecker
	{
		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x0600D16A RID: 53610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001908")]
		public Act38SideBattleManager manager
		{
			[Token(Token = "0x600D16A")]
			[Address(RVA = "0x3524E90", Offset = "0x3523A90", VA = "0x183524E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x0004B768 File Offset: 0x00049968
		[Token(Token = "0x600D16B")]
		[Address(RVA = "0x3524C80", Offset = "0x3523880", VA = "0x183524C80", Slot = "4")]
		public override bool CheckValidity()
		{
			return default(bool);
		}

		// Token: 0x0600D16C RID: 53612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D16C")]
		[Address(RVA = "0x3524DD0", Offset = "0x35239D0", VA = "0x183524DD0")]
		public Act38SideToggleableHookerChecker()
		{
		}

		// Token: 0x0400DFD6 RID: 57302
		[Token(Token = "0x400DFD6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _level;

		// Token: 0x0400DFD7 RID: 57303
		[Token(Token = "0x400DFD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _eventSystemKey;

		// Token: 0x0400DFD8 RID: 57304
		[Token(Token = "0x400DFD8")]
		[FieldOffset(Offset = "0x28")]
		private Act38SideBattleManager m_manager;

		// Token: 0x0400DFD9 RID: 57305
		[Token(Token = "0x400DFD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_manager;

		// Token: 0x0400DFDA RID: 57306
		[Token(Token = "0x400DFDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckValidity;

		// Token: 0x0400DFDB RID: 57307
		[Token(Token = "0x400DFDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
