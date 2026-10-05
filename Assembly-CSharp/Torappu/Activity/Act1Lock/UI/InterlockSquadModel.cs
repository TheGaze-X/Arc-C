using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078C9 RID: 30921
	[Token(Token = "0x20078C9")]
	public class InterlockSquadModel : IHotfixable
	{
		// Token: 0x1700657A RID: 25978
		// (get) Token: 0x0602B5C6 RID: 177606 RVA: 0x000DB858 File Offset: 0x000D9A58
		[Token(Token = "0x1700657A")]
		public bool isInterlock
		{
			[Token(Token = "0x602B5C6")]
			[Address(RVA = "0x2733DE0", Offset = "0x27329E0", VA = "0x182733DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B5C7 RID: 177607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B5C7")]
		[Address(RVA = "0x2733D30", Offset = "0x2732930", VA = "0x182733D30")]
		public InterlockSquadModel()
		{
		}

		// Token: 0x0403EB43 RID: 256835
		[Token(Token = "0x403EB43")]
		[FieldOffset(Offset = "0x10")]
		public ActivityInterlockData.StageAdditionData additionData;

		// Token: 0x0403EB44 RID: 256836
		[Token(Token = "0x403EB44")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterCardViewModel> interlockCharList;

		// Token: 0x0403EB45 RID: 256837
		[Token(Token = "0x403EB45")]
		[FieldOffset(Offset = "0x20")]
		public CharacterCardViewModel assistCharModel;

		// Token: 0x0403EB46 RID: 256838
		[Token(Token = "0x403EB46")]
		[FieldOffset(Offset = "0x28")]
		public bool isExpand;

		// Token: 0x0403EB47 RID: 256839
		[Token(Token = "0x403EB47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInterlock;

		// Token: 0x0403EB48 RID: 256840
		[Token(Token = "0x403EB48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
