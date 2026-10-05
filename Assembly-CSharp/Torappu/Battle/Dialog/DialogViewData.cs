using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002816 RID: 10262
	[Token(Token = "0x2002816")]
	public class DialogViewData : IHotfixable
	{
		// Token: 0x0601112B RID: 69931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601112B")]
		[Address(RVA = "0x8F9260", Offset = "0x8F7E60", VA = "0x1808F9260")]
		public void Reset()
		{
		}

		// Token: 0x0601112C RID: 69932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601112C")]
		[Address(RVA = "0x8F9490", Offset = "0x8F8090", VA = "0x1808F9490")]
		public DialogViewData()
		{
		}

		// Token: 0x0601112D RID: 69933 RVA: 0x00069330 File Offset: 0x00067530
		[Token(Token = "0x601112D")]
		[Address(RVA = "0x8F9130", Offset = "0x8F7D30", VA = "0x1808F9130")]
		public bool IsFilled(bool isSkip)
		{
			return default(bool);
		}

		// Token: 0x04013200 RID: 78336
		[Token(Token = "0x4013200")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly DialogViewData DEFAULT;

		// Token: 0x04013201 RID: 78337
		[Token(Token = "0x4013201")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04013202 RID: 78338
		[Token(Token = "0x4013202")]
		[FieldOffset(Offset = "0x18")]
		public string avatarId;

		// Token: 0x04013203 RID: 78339
		[Token(Token = "0x4013203")]
		[FieldOffset(Offset = "0x20")]
		public string content;

		// Token: 0x04013204 RID: 78340
		[Token(Token = "0x4013204")]
		[FieldOffset(Offset = "0x28")]
		public bool isAvatarRight;

		// Token: 0x04013205 RID: 78341
		[Token(Token = "0x4013205")]
		[FieldOffset(Offset = "0x30")]
		public List<BattleDialogOption> dialogOptions;

		// Token: 0x04013206 RID: 78342
		[Token(Token = "0x4013206")]
		[FieldOffset(Offset = "0x38")]
		public float delay;

		// Token: 0x04013207 RID: 78343
		[Token(Token = "0x4013207")]
		[FieldOffset(Offset = "0x3C")]
		public BattleDialogType dialogType;

		// Token: 0x04013208 RID: 78344
		[Token(Token = "0x4013208")]
		[FieldOffset(Offset = "0x40")]
		public int commandIndex;

		// Token: 0x04013209 RID: 78345
		[Token(Token = "0x4013209")]
		[FieldOffset(Offset = "0x48")]
		public string commandKey;

		// Token: 0x0401320A RID: 78346
		[Token(Token = "0x401320A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401320B RID: 78347
		[Token(Token = "0x401320B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401320C RID: 78348
		[Token(Token = "0x401320C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsFilled;
	}
}
