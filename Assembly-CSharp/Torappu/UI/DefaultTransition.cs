using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200368D RID: 13965
	[Token(Token = "0x200368D")]
	public class DefaultTransition : Transition
	{
		// Token: 0x06016364 RID: 90980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016364")]
		[Address(RVA = "0xEB3A30", Offset = "0xEB2630", VA = "0x180EB3A30")]
		public static Transition NewInstance()
		{
			return null;
		}

		// Token: 0x06016365 RID: 90981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016365")]
		[Address(RVA = "0xEB3970", Offset = "0xEB2570", VA = "0x180EB3970", Slot = "4")]
		public override void AddStaticAction(ITransAction action)
		{
		}

		// Token: 0x06016366 RID: 90982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016366")]
		[Address(RVA = "0xEB39D0", Offset = "0xEB25D0", VA = "0x180EB39D0", Slot = "5")]
		public override void AddStaticActions(ITransAction[] actions)
		{
		}

		// Token: 0x06016367 RID: 90983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016367")]
		[Address(RVA = "0xEB3B10", Offset = "0xEB2710", VA = "0x180EB3B10")]
		public DefaultTransition()
		{
		}

		// Token: 0x06016368 RID: 90984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016368")]
		[Address(RVA = "0xEB3AF0", Offset = "0xEB26F0", VA = "0x180EB3AF0")]
		private void <>xLuaBaseProxy_AddStaticAction(ITransAction P0)
		{
		}

		// Token: 0x06016369 RID: 90985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016369")]
		[Address(RVA = "0xEB3B00", Offset = "0xEB2700", VA = "0x180EB3B00")]
		private void <>xLuaBaseProxy_AddStaticActions(ITransAction[] P0)
		{
		}

		// Token: 0x0401AB19 RID: 109337
		[Token(Token = "0x401AB19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NewInstance;

		// Token: 0x0401AB1A RID: 109338
		[Token(Token = "0x401AB1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddStaticAction;

		// Token: 0x0401AB1B RID: 109339
		[Token(Token = "0x401AB1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddStaticActions;

		// Token: 0x0401AB1C RID: 109340
		[Token(Token = "0x401AB1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
