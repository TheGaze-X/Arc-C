using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200255A RID: 9562
	[Token(Token = "0x200255A")]
	public class AlwaysTrigger : TargetTrigger
	{
		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x0600F6D1 RID: 63185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002057")]
		public override Entity target
		{
			[Token(Token = "0x600F6D1")]
			[Address(RVA = "0x6EF900", Offset = "0x6EE500", VA = "0x1806EF900", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x0600F6D2 RID: 63186 RVA: 0x0005BFF8 File Offset: 0x0005A1F8
		[Token(Token = "0x17002058")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F6D2")]
			[Address(RVA = "0x6EF8A0", Offset = "0x6EE4A0", VA = "0x1806EF8A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F6D3 RID: 63187 RVA: 0x0005C010 File Offset: 0x0005A210
		[Token(Token = "0x600F6D3")]
		[Address(RVA = "0x6EF780", Offset = "0x6EE380", VA = "0x1806EF780", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F6D4 RID: 63188 RVA: 0x0005C028 File Offset: 0x0005A228
		[Token(Token = "0x600F6D4")]
		[Address(RVA = "0x6EF710", Offset = "0x6EE310", VA = "0x1806EF710", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F6D5 RID: 63189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6D5")]
		[Address(RVA = "0x6EF800", Offset = "0x6EE400", VA = "0x1806EF800")]
		public AlwaysTrigger()
		{
		}

		// Token: 0x0600F6D6 RID: 63190 RVA: 0x0005C040 File Offset: 0x0005A240
		[Token(Token = "0x600F6D6")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x04011228 RID: 70184
		[Token(Token = "0x4011228")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04011229 RID: 70185
		[Token(Token = "0x4011229")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x0401122A RID: 70186
		[Token(Token = "0x401122A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x0401122B RID: 70187
		[Token(Token = "0x401122B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x0401122C RID: 70188
		[Token(Token = "0x401122C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
