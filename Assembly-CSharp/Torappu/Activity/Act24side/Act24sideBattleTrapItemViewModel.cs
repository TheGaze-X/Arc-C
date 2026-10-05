using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007579 RID: 30073
	[Token(Token = "0x2007579")]
	public class Act24sideBattleTrapItemViewModel : IHotfixable
	{
		// Token: 0x170063A8 RID: 25512
		// (get) Token: 0x0602A568 RID: 173416 RVA: 0x000D8168 File Offset: 0x000D6368
		// (set) Token: 0x0602A569 RID: 173417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063A8")]
		public Act24sideBattleTrapItemViewModel.UnlockState unlockState
		{
			[Token(Token = "0x602A568")]
			[Address(RVA = "0x25F79A0", Offset = "0x25F65A0", VA = "0x1825F79A0")]
			[CompilerGenerated]
			get
			{
				return Act24sideBattleTrapItemViewModel.UnlockState.NONE;
			}
			[Token(Token = "0x602A569")]
			[Address(RVA = "0x25F7C60", Offset = "0x25F6860", VA = "0x1825F7C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063A9 RID: 25513
		// (get) Token: 0x0602A56A RID: 173418 RVA: 0x000D8180 File Offset: 0x000D6380
		// (set) Token: 0x0602A56B RID: 173419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063A9")]
		public bool isTempSelect
		{
			[Token(Token = "0x602A56A")]
			[Address(RVA = "0x25F7820", Offset = "0x25F6420", VA = "0x1825F7820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602A56B")]
			[Address(RVA = "0x25F7A80", Offset = "0x25F6680", VA = "0x1825F7A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063AA RID: 25514
		// (get) Token: 0x0602A56C RID: 173420 RVA: 0x000D8198 File Offset: 0x000D6398
		// (set) Token: 0x0602A56D RID: 173421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063AA")]
		public PlayerActivity.PlayerAct24SideActivity.ToolState trapStatus
		{
			[Token(Token = "0x602A56C")]
			[Address(RVA = "0x25F7940", Offset = "0x25F6540", VA = "0x1825F7940")]
			[CompilerGenerated]
			get
			{
				return PlayerActivity.PlayerAct24SideActivity.ToolState.LOCK;
			}
			[Token(Token = "0x602A56D")]
			[Address(RVA = "0x25F7BF0", Offset = "0x25F67F0", VA = "0x1825F7BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063AB RID: 25515
		// (get) Token: 0x0602A56E RID: 173422 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A56F RID: 173423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063AB")]
		public Act24SideData.ToolData toolData
		{
			[Token(Token = "0x602A56E")]
			[Address(RVA = "0x25F7880", Offset = "0x25F6480", VA = "0x1825F7880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A56F")]
			[Address(RVA = "0x25F7AF0", Offset = "0x25F66F0", VA = "0x1825F7AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063AC RID: 25516
		// (get) Token: 0x0602A570 RID: 173424 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A571 RID: 173425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063AC")]
		public string actId
		{
			[Token(Token = "0x602A570")]
			[Address(RVA = "0x25F77C0", Offset = "0x25F63C0", VA = "0x1825F77C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A571")]
			[Address(RVA = "0x25F7A00", Offset = "0x25F6600", VA = "0x1825F7A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063AD RID: 25517
		// (get) Token: 0x0602A572 RID: 173426 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A573 RID: 173427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063AD")]
		public string toolId
		{
			[Token(Token = "0x602A572")]
			[Address(RVA = "0x25F78E0", Offset = "0x25F64E0", VA = "0x1825F78E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A573")]
			[Address(RVA = "0x25F7B70", Offset = "0x25F6770", VA = "0x1825F7B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602A574 RID: 173428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A574")]
		[Address(RVA = "0x25F6FD0", Offset = "0x25F5BD0", VA = "0x1825F6FD0")]
		public void LoadData(string activityId, Act24SideData.ToolData tool)
		{
		}

		// Token: 0x0602A575 RID: 173429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A575")]
		[Address(RVA = "0x25F73B0", Offset = "0x25F5FB0", VA = "0x1825F73B0")]
		public void UpdateData(PlayerActivity.PlayerAct24SideActivity.ToolState battleTrapStatus)
		{
		}

		// Token: 0x0602A576 RID: 173430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A576")]
		[Address(RVA = "0x25F7520", Offset = "0x25F6120", VA = "0x1825F7520")]
		public void UpdateUnlockState()
		{
		}

		// Token: 0x0602A577 RID: 173431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A577")]
		[Address(RVA = "0x25F7480", Offset = "0x25F6080", VA = "0x1825F7480")]
		public void UpdateTempSelectState(bool isSelect)
		{
		}

		// Token: 0x0602A578 RID: 173432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A578")]
		[Address(RVA = "0x25F71C0", Offset = "0x25F5DC0", VA = "0x1825F71C0")]
		public void TryConsumeNewUnlockTrack()
		{
		}

		// Token: 0x0602A579 RID: 173433 RVA: 0x000D81B0 File Offset: 0x000D63B0
		[Token(Token = "0x602A579")]
		[Address(RVA = "0x25F76A0", Offset = "0x25F62A0", VA = "0x1825F76A0")]
		private Act24sideBattleTrapItemViewModel.UnlockState _GetToolUnlockStateByToolState(PlayerActivity.PlayerAct24SideActivity.ToolState battleTrapStatus)
		{
			return Act24sideBattleTrapItemViewModel.UnlockState.NONE;
		}

		// Token: 0x0602A57A RID: 173434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A57A")]
		[Address(RVA = "0x25F7760", Offset = "0x25F6360", VA = "0x1825F7760")]
		public Act24sideBattleTrapItemViewModel()
		{
		}

		// Token: 0x0403CE39 RID: 249401
		[Token(Token = "0x403CE39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_unlockState;

		// Token: 0x0403CE3A RID: 249402
		[Token(Token = "0x403CE3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_unlockState;

		// Token: 0x0403CE3B RID: 249403
		[Token(Token = "0x403CE3B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isTempSelect;

		// Token: 0x0403CE3C RID: 249404
		[Token(Token = "0x403CE3C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isTempSelect;

		// Token: 0x0403CE3D RID: 249405
		[Token(Token = "0x403CE3D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_trapStatus;

		// Token: 0x0403CE3E RID: 249406
		[Token(Token = "0x403CE3E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_trapStatus;

		// Token: 0x0403CE3F RID: 249407
		[Token(Token = "0x403CE3F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_toolData;

		// Token: 0x0403CE40 RID: 249408
		[Token(Token = "0x403CE40")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_toolData;

		// Token: 0x0403CE41 RID: 249409
		[Token(Token = "0x403CE41")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403CE42 RID: 249410
		[Token(Token = "0x403CE42")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403CE43 RID: 249411
		[Token(Token = "0x403CE43")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_toolId;

		// Token: 0x0403CE44 RID: 249412
		[Token(Token = "0x403CE44")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_toolId;

		// Token: 0x0403CE45 RID: 249413
		[Token(Token = "0x403CE45")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CE46 RID: 249414
		[Token(Token = "0x403CE46")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403CE47 RID: 249415
		[Token(Token = "0x403CE47")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateUnlockState;

		// Token: 0x0403CE48 RID: 249416
		[Token(Token = "0x403CE48")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateTempSelectState;

		// Token: 0x0403CE49 RID: 249417
		[Token(Token = "0x403CE49")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TryConsumeNewUnlockTrack;

		// Token: 0x0403CE4A RID: 249418
		[Token(Token = "0x403CE4A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GetToolUnlockStateByToolState;

		// Token: 0x0403CE4B RID: 249419
		[Token(Token = "0x403CE4B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200757A RID: 30074
		[Token(Token = "0x200757A")]
		public enum UnlockState
		{
			// Token: 0x0403CE4D RID: 249421
			[Token(Token = "0x403CE4D")]
			NONE,
			// Token: 0x0403CE4E RID: 249422
			[Token(Token = "0x403CE4E")]
			LOCK,
			// Token: 0x0403CE4F RID: 249423
			[Token(Token = "0x403CE4F")]
			NEW_UNLOCK = 4,
			// Token: 0x0403CE50 RID: 249424
			[Token(Token = "0x403CE50")]
			UNLOCKED = 3
		}
	}
}
