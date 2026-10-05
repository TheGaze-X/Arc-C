using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005742 RID: 22338
	[Token(Token = "0x2005742")]
	public class RL02DungeonEffectModuleWithSan : RoguelikeDungeonModule
	{
		// Token: 0x06020BBA RID: 134074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BBA")]
		[Address(RVA = "0x1B08C70", Offset = "0x1B07870", VA = "0x181B08C70", Slot = "4")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06020BBB RID: 134075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BBB")]
		[Address(RVA = "0x1B08CD0", Offset = "0x1B078D0", VA = "0x181B08CD0", Slot = "5")]
		protected override void OnReloadDungeon()
		{
		}

		// Token: 0x06020BBC RID: 134076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BBC")]
		[Address(RVA = "0x1B08E00", Offset = "0x1B07A00", VA = "0x181B08E00")]
		private void _RefreshEffect()
		{
		}

		// Token: 0x06020BBD RID: 134077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BBD")]
		[Address(RVA = "0x1B08D30", Offset = "0x1B07930", VA = "0x181B08D30", Slot = "7")]
		protected override void OnStateChanged()
		{
		}

		// Token: 0x06020BBE RID: 134078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BBE")]
		[Address(RVA = "0x1B091F0", Offset = "0x1B07DF0", VA = "0x181B091F0")]
		public RL02DungeonEffectModuleWithSan()
		{
		}

		// Token: 0x06020BBF RID: 134079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BBF")]
		[Address(RVA = "0x1A4A420", Offset = "0x1A49020", VA = "0x181A4A420")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x06020BC0 RID: 134080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC0")]
		[Address(RVA = "0x1AA71A0", Offset = "0x1AA5DA0", VA = "0x181AA71A0")]
		private void <>xLuaBaseProxy_OnReloadDungeon()
		{
		}

		// Token: 0x06020BC1 RID: 134081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BC1")]
		[Address(RVA = "0x1AA71B0", Offset = "0x1AA5DB0", VA = "0x181AA71B0")]
		private void <>xLuaBaseProxy_OnStateChanged()
		{
		}

		// Token: 0x0402C6FD RID: 182013
		[Token(Token = "0x402C6FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL02DungeonSanEffect _effect;

		// Token: 0x0402C6FE RID: 182014
		[Token(Token = "0x402C6FE")]
		[FieldOffset(Offset = "0x30")]
		private RL02DungeonSanEffect m_effect;

		// Token: 0x0402C6FF RID: 182015
		[Token(Token = "0x402C6FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402C700 RID: 182016
		[Token(Token = "0x402C700")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReloadDungeon;

		// Token: 0x0402C701 RID: 182017
		[Token(Token = "0x402C701")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshEffect;

		// Token: 0x0402C702 RID: 182018
		[Token(Token = "0x402C702")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStateChanged;

		// Token: 0x0402C703 RID: 182019
		[Token(Token = "0x402C703")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
