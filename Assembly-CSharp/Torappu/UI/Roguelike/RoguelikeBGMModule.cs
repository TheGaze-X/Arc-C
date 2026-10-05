using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005366 RID: 21350
	[Token(Token = "0x2005366")]
	public abstract class RoguelikeBGMModule : RoguelikeDungeonModule
	{
		// Token: 0x170049D2 RID: 18898
		// (get) Token: 0x0601F788 RID: 128904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F789 RID: 128905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049D2")]
		private protected string topicId
		{
			[Token(Token = "0x601F788")]
			[Address(RVA = "0x1922590", Offset = "0x1921190", VA = "0x181922590")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F789")]
			[Address(RVA = "0x1922660", Offset = "0x1921260", VA = "0x181922660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x0601F78A RID: 128906 RVA: 0x000B2140 File Offset: 0x000B0340
		// (set) Token: 0x0601F78B RID: 128907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049D3")]
		private protected long instId
		{
			[Token(Token = "0x601F78A")]
			[Address(RVA = "0x1922530", Offset = "0x1921130", VA = "0x181922530")]
			[CompilerGenerated]
			protected get
			{
				return 0L;
			}
			[Token(Token = "0x601F78B")]
			[Address(RVA = "0x19225F0", Offset = "0x19211F0", VA = "0x1819225F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F78C RID: 128908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F78C")]
		[Address(RVA = "0x1921D70", Offset = "0x1920970", VA = "0x181921D70", Slot = "4")]
		protected sealed override void OnCreate()
		{
		}

		// Token: 0x0601F78D RID: 128909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F78D")]
		[Address(RVA = "0x1922030", Offset = "0x1920C30", VA = "0x181922030", Slot = "5")]
		protected sealed override void OnReloadDungeon()
		{
		}

		// Token: 0x0601F78E RID: 128910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F78E")]
		[Address(RVA = "0x1921FD0", Offset = "0x1920BD0", VA = "0x181921FD0", Slot = "6")]
		protected sealed override void OnDestroy()
		{
		}

		// Token: 0x0601F78F RID: 128911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F78F")]
		[Address(RVA = "0x1922400", Offset = "0x1921000", VA = "0x181922400")]
		private void _TriggerSignal()
		{
		}

		// Token: 0x0601F790 RID: 128912
		[Token(Token = "0x601F790")]
		protected abstract void OnTriggerSignal();

		// Token: 0x0601F791 RID: 128913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F791")]
		[Address(RVA = "0x19221B0", Offset = "0x1920DB0", VA = "0x1819221B0")]
		protected void _Clear()
		{
		}

		// Token: 0x0601F792 RID: 128914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F792")]
		[Address(RVA = "0x1922280", Offset = "0x1920E80", VA = "0x181922280")]
		protected string _GetBgmSignalByZoneId(string topicId, string zoneId)
		{
			return null;
		}

		// Token: 0x0601F793 RID: 128915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F793")]
		[Address(RVA = "0x1922490", Offset = "0x1921090", VA = "0x181922490")]
		protected RoguelikeBGMModule()
		{
		}

		// Token: 0x0601F794 RID: 128916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F794")]
		[Address(RVA = "0x1922090", Offset = "0x1920C90", VA = "0x181922090")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0601F795 RID: 128917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F795")]
		[Address(RVA = "0x1922150", Offset = "0x1920D50", VA = "0x181922150")]
		private void <>xLuaBaseProxy_OnReloadDungeon()
		{
		}

		// Token: 0x0601F796 RID: 128918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F796")]
		[Address(RVA = "0x19220F0", Offset = "0x1920CF0", VA = "0x1819220F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402A56A RID: 173418
		[Token(Token = "0x402A56A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402A56B RID: 173419
		[Token(Token = "0x402A56B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402A56C RID: 173420
		[Token(Token = "0x402A56C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402A56D RID: 173421
		[Token(Token = "0x402A56D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_instId;

		// Token: 0x0402A56E RID: 173422
		[Token(Token = "0x402A56E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402A56F RID: 173423
		[Token(Token = "0x402A56F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnReloadDungeon;

		// Token: 0x0402A570 RID: 173424
		[Token(Token = "0x402A570")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402A571 RID: 173425
		[Token(Token = "0x402A571")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TriggerSignal;

		// Token: 0x0402A572 RID: 173426
		[Token(Token = "0x402A572")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Clear;

		// Token: 0x0402A573 RID: 173427
		[Token(Token = "0x402A573")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetBgmSignalByZoneId;

		// Token: 0x0402A574 RID: 173428
		[Token(Token = "0x402A574")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
