using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x020049A4 RID: 18852
	[Token(Token = "0x20049A4")]
	public class MedalGroupViewModel : IHotfixable
	{
		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x0601C679 RID: 116345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004345")]
		public string groupId
		{
			[Token(Token = "0x601C679")]
			[Address(RVA = "0x15EB0B0", Offset = "0x15E9CB0", VA = "0x1815EB0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x0601C67A RID: 116346 RVA: 0x000A8348 File Offset: 0x000A6548
		[Token(Token = "0x17004346")]
		public int totalCount
		{
			[Token(Token = "0x601C67A")]
			[Address(RVA = "0x15EB1A0", Offset = "0x15E9DA0", VA = "0x1815EB1A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C67B RID: 116347 RVA: 0x000A8360 File Offset: 0x000A6560
		[Token(Token = "0x601C67B")]
		[Address(RVA = "0x15EABD0", Offset = "0x15E97D0", VA = "0x1815EABD0")]
		public long GetLastGetTime()
		{
			return 0L;
		}

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x0601C67C RID: 116348 RVA: 0x000A8378 File Offset: 0x000A6578
		[Token(Token = "0x17004347")]
		public int availCount
		{
			[Token(Token = "0x601C67C")]
			[Address(RVA = "0x15EB030", Offset = "0x15E9C30", VA = "0x1815EB030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C67D RID: 116349 RVA: 0x000A8390 File Offset: 0x000A6590
		[Token(Token = "0x601C67D")]
		[Address(RVA = "0x15EAA20", Offset = "0x15E9620", VA = "0x1815EAA20")]
		public bool ContainsAchievedMedal()
		{
			return default(bool);
		}

		// Token: 0x0601C67E RID: 116350 RVA: 0x000A83A8 File Offset: 0x000A65A8
		[Token(Token = "0x601C67E")]
		[Address(RVA = "0x15EAB40", Offset = "0x15E9740", VA = "0x1815EAB40")]
		public bool ContainsNotAchievedMedal()
		{
			return default(bool);
		}

		// Token: 0x0601C67F RID: 116351 RVA: 0x000A83C0 File Offset: 0x000A65C0
		[Token(Token = "0x601C67F")]
		[Address(RVA = "0x15EAAB0", Offset = "0x15E96B0", VA = "0x1815EAAB0")]
		public bool ContainsMedalToDisplay()
		{
			return default(bool);
		}

		// Token: 0x0601C680 RID: 116352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C680")]
		[Address(RVA = "0x15EA990", Offset = "0x15E9590", VA = "0x1815EA990")]
		public void AddMedal(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x0601C681 RID: 116353 RVA: 0x000A83D8 File Offset: 0x000A65D8
		[Token(Token = "0x17004348")]
		public int sortId
		{
			[Token(Token = "0x601C681")]
			[Address(RVA = "0x15EB130", Offset = "0x15E9D30", VA = "0x1815EB130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C682 RID: 116354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C682")]
		[Address(RVA = "0x15EADB0", Offset = "0x15E99B0", VA = "0x1815EADB0")]
		public void SetMedalCount(MedalCount medalCount)
		{
		}

		// Token: 0x0601C683 RID: 116355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C683")]
		[Address(RVA = "0x15EAE40", Offset = "0x15E9A40", VA = "0x1815EAE40")]
		public void UpdateGroupExpireStatus(long curTs)
		{
		}

		// Token: 0x0601C684 RID: 116356 RVA: 0x000A83F0 File Offset: 0x000A65F0
		[Token(Token = "0x601C684")]
		[Address(RVA = "0x15EAD40", Offset = "0x15E9940", VA = "0x1815EAD40")]
		public bool IsPermExpired()
		{
			return default(bool);
		}

		// Token: 0x0601C685 RID: 116357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C685")]
		[Address(RVA = "0x15EAF00", Offset = "0x15E9B00", VA = "0x1815EAF00")]
		public MedalGroupViewModel()
		{
		}

		// Token: 0x0402534C RID: 152396
		[Token(Token = "0x402534C")]
		public const string DEFAULT_GROUP = "DEFAULT";

		// Token: 0x0402534D RID: 152397
		[Token(Token = "0x402534D")]
		[FieldOffset(Offset = "0x10")]
		private MedalCount m_medalCount;

		// Token: 0x0402534E RID: 152398
		[Token(Token = "0x402534E")]
		[FieldOffset(Offset = "0x1C")]
		private MedalExpireStatus m_expireStatus;

		// Token: 0x0402534F RID: 152399
		[Token(Token = "0x402534F")]
		[FieldOffset(Offset = "0x28")]
		public string typeId;

		// Token: 0x04025350 RID: 152400
		[Token(Token = "0x4025350")]
		[FieldOffset(Offset = "0x30")]
		public MedalGroupData data;

		// Token: 0x04025351 RID: 152401
		[Token(Token = "0x4025351")]
		[FieldOffset(Offset = "0x38")]
		public List<MedalCommonViewModel> medalList;

		// Token: 0x04025352 RID: 152402
		[Token(Token = "0x4025352")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x04025353 RID: 152403
		[Token(Token = "0x4025353")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x04025354 RID: 152404
		[Token(Token = "0x4025354")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetLastGetTime;

		// Token: 0x04025355 RID: 152405
		[Token(Token = "0x4025355")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_availCount;

		// Token: 0x04025356 RID: 152406
		[Token(Token = "0x4025356")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ContainsAchievedMedal;

		// Token: 0x04025357 RID: 152407
		[Token(Token = "0x4025357")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ContainsNotAchievedMedal;

		// Token: 0x04025358 RID: 152408
		[Token(Token = "0x4025358")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ContainsMedalToDisplay;

		// Token: 0x04025359 RID: 152409
		[Token(Token = "0x4025359")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AddMedal;

		// Token: 0x0402535A RID: 152410
		[Token(Token = "0x402535A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402535B RID: 152411
		[Token(Token = "0x402535B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetMedalCount;

		// Token: 0x0402535C RID: 152412
		[Token(Token = "0x402535C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateGroupExpireStatus;

		// Token: 0x0402535D RID: 152413
		[Token(Token = "0x402535D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsPermExpired;

		// Token: 0x0402535E RID: 152414
		[Token(Token = "0x402535E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
