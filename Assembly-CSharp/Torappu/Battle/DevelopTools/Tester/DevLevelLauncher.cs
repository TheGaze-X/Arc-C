using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.DevelopTools.Tester
{
	// Token: 0x020028A4 RID: 10404
	[Token(Token = "0x20028A4")]
	public class DevLevelLauncher : BattleLauncher
	{
		// Token: 0x060114EB RID: 70891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114EB")]
		[Address(RVA = "0x921530", Offset = "0x920130", VA = "0x180921530", Slot = "8")]
		protected override LevelData LoadLevelData()
		{
			return null;
		}

		// Token: 0x060114EC RID: 70892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114EC")]
		[Address(RVA = "0x9217A0", Offset = "0x9203A0", VA = "0x1809217A0")]
		public DevLevelLauncher()
		{
		}

		// Token: 0x060114ED RID: 70893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114ED")]
		[Address(RVA = "0x921790", Offset = "0x920390", VA = "0x180921790")]
		private LevelData <>xLuaBaseProxy_LoadLevelData()
		{
			return null;
		}

		// Token: 0x0401354C RID: 79180
		[Token(Token = "0x401354C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private DevLevelLauncher.DataSource _dataSource;

		// Token: 0x0401354D RID: 79181
		[Token(Token = "0x401354D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadLevelData;

		// Token: 0x0401354E RID: 79182
		[Token(Token = "0x401354E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020028A5 RID: 10405
		[Token(Token = "0x20028A5")]
		private enum DataSource
		{
			// Token: 0x04013550 RID: 79184
			[Token(Token = "0x4013550")]
			DEFAULT,
			// Token: 0x04013551 RID: 79185
			[Token(Token = "0x4013551")]
			FROM_BATTLE_INOUT
		}
	}
}
