using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200707D RID: 28797
	[Token(Token = "0x200707D")]
	public abstract class ActMultiV3PrepareMainSquadPanelProcViewBase : ActMultiV3PrepareMainSquadPanelViewBase
	{
		// Token: 0x170060B4 RID: 24756
		// (get) Token: 0x06028E5A RID: 167514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028E5B RID: 167515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060B4")]
		private protected IActMultiV3PrepareMainSquadPanelProcEvent procEvt
		{
			[Token(Token = "0x6028E5A")]
			[Address(RVA = "0x245AC90", Offset = "0x2459890", VA = "0x18245AC90")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6028E5B")]
			[Address(RVA = "0x245ACF0", Offset = "0x24598F0", VA = "0x18245ACF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028E5C RID: 167516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E5C")]
		[Address(RVA = "0x245A9E0", Offset = "0x24595E0", VA = "0x18245A9E0")]
		public void Init(IActMultiV3PrepareMainSquadPanelProcEvent procEventImpl)
		{
		}

		// Token: 0x06028E5D RID: 167517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E5D")]
		[Address(RVA = "0x245AAC0", Offset = "0x24596C0", VA = "0x18245AAC0", Slot = "7")]
		public sealed override void OnValueChanged(ActMultiV3PrepareMainSquadPanelViewModelProperty property)
		{
		}

		// Token: 0x170060B5 RID: 24757
		// (get) Token: 0x06028E5E RID: 167518
		[Token(Token = "0x170060B5")]
		public abstract ActMultiV3PrepareMainSquadProc procType { [Token(Token = "0x6028E5E")] get; }

		// Token: 0x06028E5F RID: 167519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E5F")]
		[Address(RVA = "0x2459360", Offset = "0x2457F60", VA = "0x182459360", Slot = "10")]
		protected virtual void OnUpdate(ActMultiV3PrepareMainSquadPanelViewModel model)
		{
		}

		// Token: 0x06028E60 RID: 167520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E60")]
		[Address(RVA = "0x245ABE0", Offset = "0x24597E0", VA = "0x18245ABE0")]
		protected ActMultiV3PrepareMainSquadPanelProcViewBase()
		{
		}

		// Token: 0x0403A563 RID: 238947
		[Token(Token = "0x403A563")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_procEvt;

		// Token: 0x0403A564 RID: 238948
		[Token(Token = "0x403A564")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_procEvt;

		// Token: 0x0403A565 RID: 238949
		[Token(Token = "0x403A565")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403A566 RID: 238950
		[Token(Token = "0x403A566")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A567 RID: 238951
		[Token(Token = "0x403A567")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A568 RID: 238952
		[Token(Token = "0x403A568")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
