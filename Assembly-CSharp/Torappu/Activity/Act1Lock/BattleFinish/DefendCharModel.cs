using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078F5 RID: 30965
	[Token(Token = "0x20078F5")]
	public class DefendCharModel : IHotfixable
	{
		// Token: 0x170065B0 RID: 26032
		// (get) Token: 0x0602B6B9 RID: 177849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065B0")]
		public string charId
		{
			[Token(Token = "0x602B6B9")]
			[Address(RVA = "0x275AAB0", Offset = "0x27596B0", VA = "0x18275AAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B6BA RID: 177850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6BA")]
		[Address(RVA = "0x275AA50", Offset = "0x2759650", VA = "0x18275AA50")]
		public DefendCharModel()
		{
		}

		// Token: 0x0403ECA8 RID: 257192
		[Token(Token = "0x403ECA8")]
		[FieldOffset(Offset = "0x10")]
		public CharacterCardViewModel cardModel;

		// Token: 0x0403ECA9 RID: 257193
		[Token(Token = "0x403ECA9")]
		[FieldOffset(Offset = "0x18")]
		public bool isAssist;

		// Token: 0x0403ECAA RID: 257194
		[Token(Token = "0x403ECAA")]
		[FieldOffset(Offset = "0x19")]
		public bool isEvacuate;

		// Token: 0x0403ECAB RID: 257195
		[Token(Token = "0x403ECAB")]
		[FieldOffset(Offset = "0x1A")]
		public bool isEnter;

		// Token: 0x0403ECAC RID: 257196
		[Token(Token = "0x403ECAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0403ECAD RID: 257197
		[Token(Token = "0x403ECAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
