using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EC3 RID: 20163
	[Token(Token = "0x2004EC3")]
	public class FifthAnnivExploreGroupChooseStateBean : IStateBean, IHotfixable
	{
		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x0601E16C RID: 123244 RVA: 0x000AD778 File Offset: 0x000AB978
		[Token(Token = "0x1700469A")]
		public bool needConfirmHeritage
		{
			[Token(Token = "0x601E16C")]
			[Address(RVA = "0x17BC8C0", Offset = "0x17BB4C0", VA = "0x1817BC8C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x0601E16D RID: 123245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700469B")]
		public string selectedGroupId
		{
			[Token(Token = "0x601E16D")]
			[Address(RVA = "0x17BC970", Offset = "0x17BB570", VA = "0x1817BC970")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x0601E16E RID: 123246 RVA: 0x000AD790 File Offset: 0x000AB990
		[Token(Token = "0x1700469C")]
		public bool hasSelectHeritage
		{
			[Token(Token = "0x601E16E")]
			[Address(RVA = "0x17BC810", Offset = "0x17BB410", VA = "0x1817BC810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601E16F RID: 123247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E16F")]
		[Address(RVA = "0x17BC540", Offset = "0x17BB140", VA = "0x1817BC540")]
		public void LoadData()
		{
		}

		// Token: 0x0601E170 RID: 123248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E170")]
		[Address(RVA = "0x17BC5F0", Offset = "0x17BB1F0", VA = "0x1817BC5F0")]
		public void SelectGroup(int position)
		{
		}

		// Token: 0x0601E171 RID: 123249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E171")]
		[Address(RVA = "0x17BC6B0", Offset = "0x17BB2B0", VA = "0x1817BC6B0")]
		public void SetSelectHeritage(bool select)
		{
		}

		// Token: 0x0601E172 RID: 123250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E172")]
		[Address(RVA = "0x17BC770", Offset = "0x17BB370", VA = "0x1817BC770")]
		public FifthAnnivExploreGroupChooseStateBean()
		{
		}

		// Token: 0x0402806A RID: 163946
		[Token(Token = "0x402806A")]
		[FieldOffset(Offset = "0x10")]
		public FifthAnnivExploreGroupChooseProperty property;

		// Token: 0x0402806B RID: 163947
		[Token(Token = "0x402806B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_needConfirmHeritage;

		// Token: 0x0402806C RID: 163948
		[Token(Token = "0x402806C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedGroupId;

		// Token: 0x0402806D RID: 163949
		[Token(Token = "0x402806D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasSelectHeritage;

		// Token: 0x0402806E RID: 163950
		[Token(Token = "0x402806E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402806F RID: 163951
		[Token(Token = "0x402806F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectGroup;

		// Token: 0x04028070 RID: 163952
		[Token(Token = "0x4028070")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetSelectHeritage;

		// Token: 0x04028071 RID: 163953
		[Token(Token = "0x4028071")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
