using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005827 RID: 22567
	[Token(Token = "0x2005827")]
	public class RL03DungeonChaosChangeToast : RoguelikeDungeonModule
	{
		// Token: 0x06020F95 RID: 135061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F95")]
		[Address(RVA = "0x1B47A20", Offset = "0x1B46620", VA = "0x181B47A20", Slot = "4")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06020F96 RID: 135062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F96")]
		[Address(RVA = "0x1B47B60", Offset = "0x1B46760", VA = "0x181B47B60")]
		private void _TryToToast(object arg)
		{
		}

		// Token: 0x06020F97 RID: 135063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F97")]
		[Address(RVA = "0x1B47F00", Offset = "0x1B46B00", VA = "0x181B47F00")]
		public RL03DungeonChaosChangeToast()
		{
		}

		// Token: 0x06020F98 RID: 135064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F98")]
		[Address(RVA = "0x1A4A420", Offset = "0x1A49020", VA = "0x181A4A420")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0402CD7C RID: 183676
		[Token(Token = "0x402CD7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL03ChaosChangeToastView _toastPrefab;

		// Token: 0x0402CD7D RID: 183677
		[Token(Token = "0x402CD7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402CD7E RID: 183678
		[Token(Token = "0x402CD7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryToToast;

		// Token: 0x0402CD7F RID: 183679
		[Token(Token = "0x402CD7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
