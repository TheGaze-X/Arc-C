using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E66 RID: 28262
	[Token(Token = "0x2006E66")]
	public class VecBreakV2OffenseBossModel : IHotfixable
	{
		// Token: 0x0602838C RID: 164748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602838C")]
		[Address(RVA = "0x2389230", Offset = "0x2387E30", VA = "0x182389230")]
		public void LoadData(ActVecBreakV2BossData bossData)
		{
		}

		// Token: 0x0602838D RID: 164749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602838D")]
		[Address(RVA = "0x2389330", Offset = "0x2387F30", VA = "0x182389330")]
		public VecBreakV2OffenseBossModel()
		{
		}

		// Token: 0x04039295 RID: 234133
		[Token(Token = "0x4039295")]
		[FieldOffset(Offset = "0x10")]
		public bool isEmpty;

		// Token: 0x04039296 RID: 234134
		[Token(Token = "0x4039296")]
		[FieldOffset(Offset = "0x18")]
		public string enemyId;

		// Token: 0x04039297 RID: 234135
		[Token(Token = "0x4039297")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04039298 RID: 234136
		[Token(Token = "0x4039298")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x04039299 RID: 234137
		[Token(Token = "0x4039299")]
		[FieldOffset(Offset = "0x30")]
		public int level;

		// Token: 0x0403929A RID: 234138
		[Token(Token = "0x403929A")]
		[FieldOffset(Offset = "0x38")]
		public string iconId;

		// Token: 0x0403929B RID: 234139
		[Token(Token = "0x403929B")]
		[FieldOffset(Offset = "0x40")]
		public string decoId;

		// Token: 0x0403929C RID: 234140
		[Token(Token = "0x403929C")]
		[FieldOffset(Offset = "0x48")]
		public string levelDecoFigureId;

		// Token: 0x0403929D RID: 234141
		[Token(Token = "0x403929D")]
		[FieldOffset(Offset = "0x50")]
		public string levelDecoSignId;

		// Token: 0x0403929E RID: 234142
		[Token(Token = "0x403929E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403929F RID: 234143
		[Token(Token = "0x403929F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
