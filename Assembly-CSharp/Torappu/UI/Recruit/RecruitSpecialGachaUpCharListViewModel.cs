using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200471D RID: 18205
	[Token(Token = "0x200471D")]
	public class RecruitSpecialGachaUpCharListViewModel : IHotfixable
	{
		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x0601B983 RID: 113027 RVA: 0x000A5A20 File Offset: 0x000A3C20
		[Token(Token = "0x170041AA")]
		public bool hasConfirmed
		{
			[Token(Token = "0x601B983")]
			[Address(RVA = "0x14EABA0", Offset = "0x14E97A0", VA = "0x1814EABA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x0601B984 RID: 113028 RVA: 0x000A5A38 File Offset: 0x000A3C38
		[Token(Token = "0x170041AB")]
		public bool isAllSelected
		{
			[Token(Token = "0x601B984")]
			[Address(RVA = "0x14EAD80", Offset = "0x14E9980", VA = "0x1814EAD80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B985 RID: 113029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B985")]
		[Address(RVA = "0x14EA810", Offset = "0x14E9410", VA = "0x1814EA810")]
		public void RefreshData(List<string> charIdList)
		{
		}

		// Token: 0x0601B986 RID: 113030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B986")]
		[Address(RVA = "0x14EA500", Offset = "0x14E9100", VA = "0x1814EA500")]
		public Dictionary<int, List<string>> GenerateRarityCharDict()
		{
			return null;
		}

		// Token: 0x0601B987 RID: 113031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B987")]
		[Address(RVA = "0x14EAAA0", Offset = "0x14E96A0", VA = "0x1814EAAA0")]
		public RecruitSpecialGachaUpCharListViewModel()
		{
		}

		// Token: 0x04023C0C RID: 146444
		[Token(Token = "0x4023C0C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, List<RecruitSpecialGachaUpCharCardViewModel>> charGroupModel;

		// Token: 0x04023C0D RID: 146445
		[Token(Token = "0x4023C0D")]
		[FieldOffset(Offset = "0x18")]
		public string poolId;

		// Token: 0x04023C0E RID: 146446
		[Token(Token = "0x4023C0E")]
		[FieldOffset(Offset = "0x20")]
		public string detailTitle;

		// Token: 0x04023C0F RID: 146447
		[Token(Token = "0x4023C0F")]
		[FieldOffset(Offset = "0x28")]
		public string detailInfo;

		// Token: 0x04023C10 RID: 146448
		[Token(Token = "0x4023C10")]
		[FieldOffset(Offset = "0x30")]
		public Color colorTheme;

		// Token: 0x04023C11 RID: 146449
		[Token(Token = "0x4023C11")]
		[FieldOffset(Offset = "0x40")]
		public string selectJudgeText;

		// Token: 0x04023C12 RID: 146450
		[Token(Token = "0x4023C12")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, List<string>> selectCharIdDict;

		// Token: 0x04023C13 RID: 146451
		[Token(Token = "0x4023C13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasConfirmed;

		// Token: 0x04023C14 RID: 146452
		[Token(Token = "0x4023C14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAllSelected;

		// Token: 0x04023C15 RID: 146453
		[Token(Token = "0x4023C15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04023C16 RID: 146454
		[Token(Token = "0x4023C16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateRarityCharDict;

		// Token: 0x04023C17 RID: 146455
		[Token(Token = "0x4023C17")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
