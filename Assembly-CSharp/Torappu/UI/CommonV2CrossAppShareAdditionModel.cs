using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A53 RID: 14931
	[Token(Token = "0x2003A53")]
	public class CommonV2CrossAppShareAdditionModel : ICrossAppShareRemakeAdditionBaseModel, IHotfixable
	{
		// Token: 0x0601799C RID: 96668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601799C")]
		[Address(RVA = "0xFE27E0", Offset = "0xFE13E0", VA = "0x180FE27E0")]
		public void InitData()
		{
		}

		// Token: 0x0601799D RID: 96669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601799D")]
		[Address(RVA = "0xFE2A70", Offset = "0xFE1670", VA = "0x180FE2A70")]
		public void SetSkinId(string nameCardSkinId, int nameCardSkinTmpl)
		{
		}

		// Token: 0x0601799E RID: 96670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601799E")]
		[Address(RVA = "0xFE2B10", Offset = "0xFE1710", VA = "0x180FE2B10")]
		public CommonV2CrossAppShareAdditionModel()
		{
		}

		// Token: 0x0401C7B0 RID: 116656
		[Token(Token = "0x401C7B0")]
		private const string NICK_NUMBER_FORMAT = "#{0}";

		// Token: 0x0401C7B1 RID: 116657
		[Token(Token = "0x401C7B1")]
		private const string UID_FORMAT = "ID {0}";

		// Token: 0x0401C7B2 RID: 116658
		[Token(Token = "0x401C7B2")]
		private const string TIME_DAY_FORMAT = "yyyy/MM/dd";

		// Token: 0x0401C7B3 RID: 116659
		[Token(Token = "0x401C7B3")]
		private const string TIME_SECOND_FORMAT = "HH:mm:ss";

		// Token: 0x0401C7B4 RID: 116660
		[Token(Token = "0x401C7B4")]
		[FieldOffset(Offset = "0x10")]
		public string nickName;

		// Token: 0x0401C7B5 RID: 116661
		[Token(Token = "0x401C7B5")]
		[FieldOffset(Offset = "0x18")]
		public string nickNumber;

		// Token: 0x0401C7B6 RID: 116662
		[Token(Token = "0x401C7B6")]
		[FieldOffset(Offset = "0x20")]
		public string uid;

		// Token: 0x0401C7B7 RID: 116663
		[Token(Token = "0x401C7B7")]
		[FieldOffset(Offset = "0x28")]
		public string shareTimeDay;

		// Token: 0x0401C7B8 RID: 116664
		[Token(Token = "0x401C7B8")]
		[FieldOffset(Offset = "0x30")]
		public string shareTimeSecond;

		// Token: 0x0401C7B9 RID: 116665
		[Token(Token = "0x401C7B9")]
		[FieldOffset(Offset = "0x38")]
		public string nameCardSkinId;

		// Token: 0x0401C7BA RID: 116666
		[Token(Token = "0x401C7BA")]
		[FieldOffset(Offset = "0x40")]
		public int nameCardSkinTmpl;

		// Token: 0x0401C7BB RID: 116667
		[Token(Token = "0x401C7BB")]
		[FieldOffset(Offset = "0x44")]
		public bool showUid;

		// Token: 0x0401C7BC RID: 116668
		[Token(Token = "0x401C7BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401C7BD RID: 116669
		[Token(Token = "0x401C7BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSkinId;

		// Token: 0x0401C7BE RID: 116670
		[Token(Token = "0x401C7BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
