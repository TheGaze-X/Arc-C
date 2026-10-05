using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D9A RID: 15770
	[Token(Token = "0x2003D9A")]
	public abstract class TemplateMissionBaseView : DataBinder<TemplateMissionProperty>
	{
		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x06018870 RID: 100464 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018871 RID: 100465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A7F")]
		private protected AbstractTemplateMissionViewController controller
		{
			[Token(Token = "0x6018870")]
			[Address(RVA = "0x1109230", Offset = "0x1107E30", VA = "0x181109230")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6018871")]
			[Address(RVA = "0x11093B0", Offset = "0x1107FB0", VA = "0x1811093B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x06018872 RID: 100466 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018873 RID: 100467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A80")]
		private protected TemplateMissionViewModel viewModel
		{
			[Token(Token = "0x6018872")]
			[Address(RVA = "0x1109350", Offset = "0x1107F50", VA = "0x181109350")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6018873")]
			[Address(RVA = "0x1109530", Offset = "0x1108130", VA = "0x181109530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003A81 RID: 14977
		// (get) Token: 0x06018874 RID: 100468 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018875 RID: 100469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A81")]
		public ITemplateMissionEntryTween entryTween
		{
			[Token(Token = "0x6018874")]
			[Address(RVA = "0x11092F0", Offset = "0x1107EF0", VA = "0x1811092F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018875")]
			[Address(RVA = "0x11094B0", Offset = "0x11080B0", VA = "0x1811094B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17003A82 RID: 14978
		// (get) Token: 0x06018876 RID: 100470 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018877 RID: 100471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A82")]
		private protected TemplateMissionCustomResHolder customResHolder
		{
			[Token(Token = "0x6018876")]
			[Address(RVA = "0x1109290", Offset = "0x1107E90", VA = "0x181109290")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6018877")]
			[Address(RVA = "0x1109430", Offset = "0x1108030", VA = "0x181109430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06018878 RID: 100472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018878")]
		[Address(RVA = "0x1108F70", Offset = "0x1107B70", VA = "0x181108F70", Slot = "8")]
		public virtual void Init(AbstractTemplateMissionViewController ctrl_, TemplateMissionCustomResHolder customResHolder_)
		{
		}

		// Token: 0x06018879 RID: 100473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018879")]
		[Address(RVA = "0x11090B0", Offset = "0x1107CB0", VA = "0x1811090B0", Slot = "7")]
		public override void OnValueChanged(TemplateMissionProperty property)
		{
		}

		// Token: 0x0601887A RID: 100474
		[Token(Token = "0x601887A")]
		protected abstract void RenderView();

		// Token: 0x0601887B RID: 100475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601887B")]
		[Address(RVA = "0x11091C0", Offset = "0x1107DC0", VA = "0x1811091C0")]
		protected TemplateMissionBaseView()
		{
		}

		// Token: 0x0401E12D RID: 123181
		[Token(Token = "0x401E12D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0401E12E RID: 123182
		[Token(Token = "0x401E12E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0401E12F RID: 123183
		[Token(Token = "0x401E12F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x0401E130 RID: 123184
		[Token(Token = "0x401E130")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_viewModel;

		// Token: 0x0401E131 RID: 123185
		[Token(Token = "0x401E131")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_entryTween;

		// Token: 0x0401E132 RID: 123186
		[Token(Token = "0x401E132")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_entryTween;

		// Token: 0x0401E133 RID: 123187
		[Token(Token = "0x401E133")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_customResHolder;

		// Token: 0x0401E134 RID: 123188
		[Token(Token = "0x401E134")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_customResHolder;

		// Token: 0x0401E135 RID: 123189
		[Token(Token = "0x401E135")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E136 RID: 123190
		[Token(Token = "0x401E136")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E137 RID: 123191
		[Token(Token = "0x401E137")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
