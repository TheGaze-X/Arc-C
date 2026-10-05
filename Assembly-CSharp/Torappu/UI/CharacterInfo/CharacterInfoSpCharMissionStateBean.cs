using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F27 RID: 24359
	[Token(Token = "0x2005F27")]
	public class CharacterInfoSpCharMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023484 RID: 144516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023484")]
		[Address(RVA = "0x1DDBE00", Offset = "0x1DDAA00", VA = "0x181DDBE00")]
		public void LoadData()
		{
		}

		// Token: 0x06023485 RID: 144517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023485")]
		[Address(RVA = "0x1DDC110", Offset = "0x1DDAD10", VA = "0x181DDC110")]
		public CharacterInfoSpCharMissionStateBean()
		{
		}

		// Token: 0x04030A4A RID: 199242
		[Token(Token = "0x4030A4A")]
		[FieldOffset(Offset = "0x10")]
		public CharacterInfoSpCharMissionStateBean.Input input;

		// Token: 0x04030A4B RID: 199243
		[Token(Token = "0x4030A4B")]
		[FieldOffset(Offset = "0x18")]
		public CharacterInfoSpCharMissionStateBean.Output output;

		// Token: 0x04030A4C RID: 199244
		[Token(Token = "0x4030A4C")]
		[FieldOffset(Offset = "0x20")]
		public List<SpCharMissionCharViewModel> charModels;

		// Token: 0x04030A4D RID: 199245
		[Token(Token = "0x4030A4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030A4E RID: 199246
		[Token(Token = "0x4030A4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F28 RID: 24360
		[Token(Token = "0x2005F28")]
		public class Input
		{
			// Token: 0x06023486 RID: 144518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023486")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04030A4F RID: 199247
			[Token(Token = "0x4030A4F")]
			[FieldOffset(Offset = "0x10")]
			public int charInstId;
		}

		// Token: 0x02005F29 RID: 24361
		[Token(Token = "0x2005F29")]
		public class Output
		{
			// Token: 0x06023487 RID: 144519 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023487")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x04030A50 RID: 199248
			[Token(Token = "0x4030A50")]
			[FieldOffset(Offset = "0x10")]
			public int jumpToCharInstId;
		}
	}
}
