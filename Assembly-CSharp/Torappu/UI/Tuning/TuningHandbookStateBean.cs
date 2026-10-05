using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C91 RID: 15505
	[Token(Token = "0x2003C91")]
	public class TuningHandbookStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601836A RID: 99178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601836A")]
		[Address(RVA = "0x10B4CA0", Offset = "0x10B38A0", VA = "0x1810B4CA0")]
		public void LoadData()
		{
		}

		// Token: 0x0601836B RID: 99179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601836B")]
		[Address(RVA = "0x10B4E20", Offset = "0x10B3A20", VA = "0x1810B4E20")]
		public void SelectGroup(string sId)
		{
		}

		// Token: 0x0601836C RID: 99180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601836C")]
		[Address(RVA = "0x10B4F00", Offset = "0x10B3B00", VA = "0x1810B4F00")]
		public TuningHandbookStateBean()
		{
		}

		// Token: 0x0401D7DD RID: 120797
		[Token(Token = "0x401D7DD")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0401D7DE RID: 120798
		[Token(Token = "0x401D7DE")]
		[FieldOffset(Offset = "0x18")]
		public string emotionId;

		// Token: 0x0401D7DF RID: 120799
		[Token(Token = "0x401D7DF")]
		[FieldOffset(Offset = "0x20")]
		public TuningHandbookProperty viewProperty;

		// Token: 0x0401D7E0 RID: 120800
		[Token(Token = "0x401D7E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D7E1 RID: 120801
		[Token(Token = "0x401D7E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectGroup;

		// Token: 0x0401D7E2 RID: 120802
		[Token(Token = "0x401D7E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
