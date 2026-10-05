using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200757B RID: 30075
	[Token(Token = "0x200757B")]
	public class Act24sideBattleTrapViewModel : IHotfixable
	{
		// Token: 0x170063AE RID: 25518
		// (get) Token: 0x0602A57B RID: 173435 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A57C RID: 173436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063AE")]
		public string actId
		{
			[Token(Token = "0x602A57B")]
			[Address(RVA = "0x25FC770", Offset = "0x25FB370", VA = "0x1825FC770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A57C")]
			[Address(RVA = "0x25FC830", Offset = "0x25FB430", VA = "0x1825FC830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063AF RID: 25519
		// (get) Token: 0x0602A57D RID: 173437 RVA: 0x000D81C8 File Offset: 0x000D63C8
		// (set) Token: 0x0602A57E RID: 173438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063AF")]
		public int toolMaxCanTakeCount
		{
			[Token(Token = "0x602A57D")]
			[Address(RVA = "0x25FC7D0", Offset = "0x25FB3D0", VA = "0x1825FC7D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602A57E")]
			[Address(RVA = "0x25FC8B0", Offset = "0x25FB4B0", VA = "0x1825FC8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602A57F RID: 173439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A57F")]
		[Address(RVA = "0x25FC110", Offset = "0x25FAD10", VA = "0x1825FC110")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x0602A580 RID: 173440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A580")]
		[Address(RVA = "0x25FC410", Offset = "0x25FB010", VA = "0x1825FC410")]
		public void UpdateData()
		{
		}

		// Token: 0x0602A581 RID: 173441 RVA: 0x000D81E0 File Offset: 0x000D63E0
		[Token(Token = "0x602A581")]
		[Address(RVA = "0x25FBB50", Offset = "0x25FA750", VA = "0x1825FBB50")]
		public int GetTempSelectCount()
		{
			return 0;
		}

		// Token: 0x0602A582 RID: 173442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A582")]
		[Address(RVA = "0x25FBC30", Offset = "0x25FA830", VA = "0x1825FBC30")]
		public List<string> GetTempSelectTrapIdList()
		{
			return null;
		}

		// Token: 0x0602A583 RID: 173443 RVA: 0x000D81F8 File Offset: 0x000D63F8
		[Token(Token = "0x602A583")]
		[Address(RVA = "0x25FB860", Offset = "0x25FA460", VA = "0x1825FB860")]
		public bool CheckIfTempSelectSaved()
		{
			return default(bool);
		}

		// Token: 0x0602A584 RID: 173444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A584")]
		[Address(RVA = "0x25FBD90", Offset = "0x25FA990", VA = "0x1825FBD90")]
		public List<Act24sideBattleTrapItemViewModel> GetTempSelectTrapViewModelList()
		{
			return null;
		}

		// Token: 0x0602A585 RID: 173445 RVA: 0x000D8210 File Offset: 0x000D6410
		[Token(Token = "0x602A585")]
		[Address(RVA = "0x25FC020", Offset = "0x25FAC20", VA = "0x1825FC020")]
		public bool IsAllTrapLock()
		{
			return default(bool);
		}

		// Token: 0x0602A586 RID: 173446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A586")]
		[Address(RVA = "0x25FBEE0", Offset = "0x25FAAE0", VA = "0x1825FBEE0")]
		public Act24sideBattleTrapItemViewModel GetTrapItemViewModelById(string trapId)
		{
			return null;
		}

		// Token: 0x0602A587 RID: 173447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A587")]
		[Address(RVA = "0x25FBA80", Offset = "0x25FA680", VA = "0x1825FBA80")]
		public void ConsumeAllNewUnlockTrack()
		{
		}

		// Token: 0x0602A588 RID: 173448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A588")]
		[Address(RVA = "0x25FC6C0", Offset = "0x25FB2C0", VA = "0x1825FC6C0")]
		public Act24sideBattleTrapViewModel()
		{
		}

		// Token: 0x0403CE53 RID: 249427
		[Token(Token = "0x403CE53")]
		[FieldOffset(Offset = "0x20")]
		public List<Act24sideBattleTrapItemViewModel> trapItemViewModelList;

		// Token: 0x0403CE54 RID: 249428
		[Token(Token = "0x403CE54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403CE55 RID: 249429
		[Token(Token = "0x403CE55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403CE56 RID: 249430
		[Token(Token = "0x403CE56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_toolMaxCanTakeCount;

		// Token: 0x0403CE57 RID: 249431
		[Token(Token = "0x403CE57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_toolMaxCanTakeCount;

		// Token: 0x0403CE58 RID: 249432
		[Token(Token = "0x403CE58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CE59 RID: 249433
		[Token(Token = "0x403CE59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403CE5A RID: 249434
		[Token(Token = "0x403CE5A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTempSelectCount;

		// Token: 0x0403CE5B RID: 249435
		[Token(Token = "0x403CE5B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetTempSelectTrapIdList;

		// Token: 0x0403CE5C RID: 249436
		[Token(Token = "0x403CE5C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfTempSelectSaved;

		// Token: 0x0403CE5D RID: 249437
		[Token(Token = "0x403CE5D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetTempSelectTrapViewModelList;

		// Token: 0x0403CE5E RID: 249438
		[Token(Token = "0x403CE5E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsAllTrapLock;

		// Token: 0x0403CE5F RID: 249439
		[Token(Token = "0x403CE5F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetTrapItemViewModelById;

		// Token: 0x0403CE60 RID: 249440
		[Token(Token = "0x403CE60")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ConsumeAllNewUnlockTrack;

		// Token: 0x0403CE61 RID: 249441
		[Token(Token = "0x403CE61")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
