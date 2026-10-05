using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Audio.Middleware.Data;
using XLua;

namespace Torappu.Audio.Middleware
{
	// Token: 0x02001FB5 RID: 8117
	[Token(Token = "0x2001FB5")]
	public abstract class AudioAtom : IHotfixable
	{
		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x0600C993 RID: 51603 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C994 RID: 51604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017E1")]
		public Bank bank
		{
			[Token(Token = "0x600C993")]
			[Address(RVA = "0x349D660", Offset = "0x349C260", VA = "0x18349D660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600C994")]
			[Address(RVA = "0x349D7E0", Offset = "0x349C3E0", VA = "0x18349D7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x0600C995 RID: 51605 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C996 RID: 51606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017E2")]
		public string name
		{
			[Token(Token = "0x600C995")]
			[Address(RVA = "0x349D6C0", Offset = "0x349C2C0", VA = "0x18349D6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600C996")]
			[Address(RVA = "0x349D860", Offset = "0x349C460", VA = "0x18349D860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x0600C997 RID: 51607 RVA: 0x000492F0 File Offset: 0x000474F0
		// (set) Token: 0x0600C998 RID: 51608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017E3")]
		public float volume
		{
			[Token(Token = "0x600C997")]
			[Address(RVA = "0x349D720", Offset = "0x349C320", VA = "0x18349D720")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600C998")]
			[Address(RVA = "0x349D8E0", Offset = "0x349C4E0", VA = "0x18349D8E0")]
			set
			{
			}
		}

		// Token: 0x0600C999 RID: 51609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C999")]
		[Address(RVA = "0x349D520", Offset = "0x349C120", VA = "0x18349D520", Slot = "4")]
		public virtual void SetParameter(string paramName, float value)
		{
		}

		// Token: 0x0600C99A RID: 51610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C99A")]
		[Address(RVA = "0x349D5A0", Offset = "0x349C1A0", VA = "0x18349D5A0", Slot = "5")]
		public virtual void Stop(float fadetime)
		{
		}

		// Token: 0x0600C99B RID: 51611
		[Token(Token = "0x600C99B")]
		public abstract bool Update(float deltaTime);

		// Token: 0x0600C99C RID: 51612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C99C")]
		[Address(RVA = "0x349D600", Offset = "0x349C200", VA = "0x18349D600")]
		protected AudioAtom()
		{
		}

		// Token: 0x0400D202 RID: 53762
		[Token(Token = "0x400D202")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bank;

		// Token: 0x0400D203 RID: 53763
		[Token(Token = "0x400D203")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bank;

		// Token: 0x0400D204 RID: 53764
		[Token(Token = "0x400D204")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0400D205 RID: 53765
		[Token(Token = "0x400D205")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0400D206 RID: 53766
		[Token(Token = "0x400D206")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_volume;

		// Token: 0x0400D207 RID: 53767
		[Token(Token = "0x400D207")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_volume;

		// Token: 0x0400D208 RID: 53768
		[Token(Token = "0x400D208")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetParameter;

		// Token: 0x0400D209 RID: 53769
		[Token(Token = "0x400D209")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0400D20A RID: 53770
		[Token(Token = "0x400D20A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
