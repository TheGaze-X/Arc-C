using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x020049A3 RID: 18851
	[Token(Token = "0x20049A3")]
	public class MedalTypeViewModel : IHotfixable
	{
		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x0601C671 RID: 116337 RVA: 0x000A82E8 File Offset: 0x000A64E8
		[Token(Token = "0x17004340")]
		public int sortId
		{
			[Token(Token = "0x601C671")]
			[Address(RVA = "0x15F0130", Offset = "0x15EED30", VA = "0x1815F0130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x0601C672 RID: 116338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004341")]
		public string typeId
		{
			[Token(Token = "0x601C672")]
			[Address(RVA = "0x15F0220", Offset = "0x15EEE20", VA = "0x1815F0220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x0601C673 RID: 116339 RVA: 0x000A8300 File Offset: 0x000A6500
		[Token(Token = "0x17004342")]
		public int totalCount
		{
			[Token(Token = "0x601C673")]
			[Address(RVA = "0x15F01A0", Offset = "0x15EEDA0", VA = "0x1815F01A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x0601C674 RID: 116340 RVA: 0x000A8318 File Offset: 0x000A6518
		[Token(Token = "0x17004343")]
		public int getCount
		{
			[Token(Token = "0x601C674")]
			[Address(RVA = "0x15F00B0", Offset = "0x15EECB0", VA = "0x1815F00B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x0601C675 RID: 116341 RVA: 0x000A8330 File Offset: 0x000A6530
		[Token(Token = "0x17004344")]
		public int achievedHiddenCount
		{
			[Token(Token = "0x601C675")]
			[Address(RVA = "0x15F0030", Offset = "0x15EEC30", VA = "0x1815F0030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C676 RID: 116342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C676")]
		[Address(RVA = "0x15EFBB0", Offset = "0x15EE7B0", VA = "0x1815EFBB0")]
		public void AddMedalData(MedalCommonViewModel viewModel, long curTs)
		{
		}

		// Token: 0x0601C677 RID: 116343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C677")]
		[Address(RVA = "0x15EFF00", Offset = "0x15EEB00", VA = "0x1815EFF00")]
		public void SetMedalCount(MedalCount medalCount)
		{
		}

		// Token: 0x0601C678 RID: 116344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C678")]
		[Address(RVA = "0x15EFF90", Offset = "0x15EEB90", VA = "0x1815EFF90")]
		public MedalTypeViewModel()
		{
		}

		// Token: 0x04025341 RID: 152385
		[Token(Token = "0x4025341")]
		[FieldOffset(Offset = "0x10")]
		private MedalCount m_medalCount;

		// Token: 0x04025342 RID: 152386
		[Token(Token = "0x4025342")]
		[FieldOffset(Offset = "0x20")]
		public MedalTypeData typeData;

		// Token: 0x04025343 RID: 152387
		[Token(Token = "0x4025343")]
		[FieldOffset(Offset = "0x28")]
		public List<MedalGroupViewModel> groupViewModelList;

		// Token: 0x04025344 RID: 152388
		[Token(Token = "0x4025344")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04025345 RID: 152389
		[Token(Token = "0x4025345")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_typeId;

		// Token: 0x04025346 RID: 152390
		[Token(Token = "0x4025346")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x04025347 RID: 152391
		[Token(Token = "0x4025347")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_getCount;

		// Token: 0x04025348 RID: 152392
		[Token(Token = "0x4025348")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_achievedHiddenCount;

		// Token: 0x04025349 RID: 152393
		[Token(Token = "0x4025349")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddMedalData;

		// Token: 0x0402534A RID: 152394
		[Token(Token = "0x402534A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetMedalCount;

		// Token: 0x0402534B RID: 152395
		[Token(Token = "0x402534B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
