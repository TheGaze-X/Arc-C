using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterCommon
{
	// Token: 0x02005FD3 RID: 24531
	[Token(Token = "0x2005FD3")]
	public class CharacterMasterViewModel : IComparable<CharacterMasterViewModel>
	{
		// Token: 0x0602376C RID: 145260 RVA: 0x000C0F48 File Offset: 0x000BF148
		[Token(Token = "0x602376C")]
		[Address(RVA = "0x1E22360", Offset = "0x1E20F60", VA = "0x181E22360", Slot = "4")]
		public int CompareTo(CharacterMasterViewModel other)
		{
			return 0;
		}

		// Token: 0x0602376D RID: 145261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602376D")]
		[Address(RVA = "0x1E22390", Offset = "0x1E20F90", VA = "0x181E22390")]
		public string GetContent()
		{
			return null;
		}

		// Token: 0x0602376E RID: 145262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602376E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharacterMasterViewModel()
		{
		}

		// Token: 0x040310F8 RID: 200952
		[Token(Token = "0x40310F8")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040310F9 RID: 200953
		[Token(Token = "0x40310F9")]
		[FieldOffset(Offset = "0x18")]
		public string rawContent;

		// Token: 0x040310FA RID: 200954
		[Token(Token = "0x40310FA")]
		[FieldOffset(Offset = "0x20")]
		public EvolvePhase nextUnlockPhase;

		// Token: 0x040310FB RID: 200955
		[Token(Token = "0x40310FB")]
		[FieldOffset(Offset = "0x24")]
		public MasterUnlockType unlock;

		// Token: 0x040310FC RID: 200956
		[Token(Token = "0x40310FC")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x040310FD RID: 200957
		[Token(Token = "0x40310FD")]
		[FieldOffset(Offset = "0x30")]
		private string m_content;
	}
}
