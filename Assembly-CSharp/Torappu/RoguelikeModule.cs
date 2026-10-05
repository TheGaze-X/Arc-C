using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011E1 RID: 4577
	[Token(Token = "0x20011E1")]
	public class RoguelikeModule
	{
		// Token: 0x06006FCE RID: 28622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCE")]
		[Address(RVA = "0x21120C0", Offset = "0x2110CC0", VA = "0x1821120C0")]
		public RoguelikeModule()
		{
		}

		// Token: 0x04006238 RID: 25144
		[Token(Token = "0x4006238")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeModuleType> moduleTypes;

		// Token: 0x04006239 RID: 25145
		[Token(Token = "0x4006239")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeSanCheckModuleData sanCheck;

		// Token: 0x0400623A RID: 25146
		[Token(Token = "0x400623A")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeDiceModuleData dice;

		// Token: 0x0400623B RID: 25147
		[Token(Token = "0x400623B")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeChaosModuleData chaos;

		// Token: 0x0400623C RID: 25148
		[Token(Token = "0x400623C")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeTotemBuffModuleData totemBuff;

		// Token: 0x0400623D RID: 25149
		[Token(Token = "0x400623D")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeVisionModuleData vision;

		// Token: 0x0400623E RID: 25150
		[Token(Token = "0x400623E")]
		[FieldOffset(Offset = "0x40")]
		public RoguelikeFragmentModuleData fragment;

		// Token: 0x0400623F RID: 25151
		[Token(Token = "0x400623F")]
		[FieldOffset(Offset = "0x48")]
		public RoguelikeDisasterModuleData disaster;

		// Token: 0x04006240 RID: 25152
		[Token(Token = "0x4006240")]
		[FieldOffset(Offset = "0x50")]
		public RoguelikeNodeUpgradeModuleData nodeUpgrade;

		// Token: 0x04006241 RID: 25153
		[Token(Token = "0x4006241")]
		[FieldOffset(Offset = "0x58")]
		public RoguelikeCopperModuleData copper;

		// Token: 0x04006242 RID: 25154
		[Token(Token = "0x4006242")]
		[FieldOffset(Offset = "0x60")]
		public RoguelikeWrathModuleData wrath;

		// Token: 0x04006243 RID: 25155
		[Token(Token = "0x4006243")]
		[FieldOffset(Offset = "0x68")]
		public RoguelikeCandleModuleData candle;

		// Token: 0x04006244 RID: 25156
		[Token(Token = "0x4006244")]
		[FieldOffset(Offset = "0x70")]
		public RoguelikeSkyModuleData sky;
	}
}
