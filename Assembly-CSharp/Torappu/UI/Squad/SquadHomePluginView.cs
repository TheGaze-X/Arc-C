using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E33 RID: 15923
	[Token(Token = "0x2003E33")]
	public abstract class SquadHomePluginView : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x06018BEA RID: 101354 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018BEB RID: 101355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AEC")]
		private protected SquadGroupViewModel squadGroupModel
		{
			[Token(Token = "0x6018BEA")]
			[Address(RVA = "0x1141D80", Offset = "0x1140980", VA = "0x181141D80")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6018BEB")]
			[Address(RVA = "0x1141E60", Offset = "0x1140A60", VA = "0x181141E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x06018BEC RID: 101356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018BED RID: 101357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AED")]
		private protected SquadHomePlugin.GroupControllerBindings groupControllerBindings
		{
			[Token(Token = "0x6018BEC")]
			[Address(RVA = "0x1141D20", Offset = "0x1140920", VA = "0x181141D20")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6018BED")]
			[Address(RVA = "0x1141DE0", Offset = "0x11409E0", VA = "0x181141DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06018BEE RID: 101358
		[Token(Token = "0x6018BEE")]
		public abstract void Show(SquadHomePlugin.PluginInputParams param);

		// Token: 0x06018BEF RID: 101359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BEF")]
		[Address(RVA = "0x11419E0", Offset = "0x11405E0", VA = "0x1811419E0", Slot = "9")]
		protected virtual void OnSquadGroupChanged(SquadGroupViewModel groupModel)
		{
		}

		// Token: 0x06018BF0 RID: 101360 RVA: 0x0009B8B0 File Offset: 0x00099AB0
		[Token(Token = "0x6018BF0")]
		[Address(RVA = "0x1141C50", Offset = "0x1140850", VA = "0x181141C50", Slot = "10")]
		public virtual bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x06018BF1 RID: 101361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BF1")]
		[Address(RVA = "0x11417C0", Offset = "0x11403C0", VA = "0x1811417C0")]
		public void BindGroupController(SquadHomePlugin.GroupControllerBindings bindings)
		{
		}

		// Token: 0x06018BF2 RID: 101362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BF2")]
		[Address(RVA = "0x1141980", Offset = "0x1140580", VA = "0x181141980", Slot = "11")]
		public virtual SquadHomeStartBattleServicePluginBase CreateStartBattlePlugin()
		{
			return null;
		}

		// Token: 0x06018BF3 RID: 101363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BF3")]
		[Address(RVA = "0x1141920", Offset = "0x1140520", VA = "0x181141920", Slot = "12")]
		public virtual SquadHomeFinishBattleServicePluginBase CreateFinishBattlePlugin()
		{
			return null;
		}

		// Token: 0x06018BF4 RID: 101364 RVA: 0x0009B8C8 File Offset: 0x00099AC8
		[Token(Token = "0x6018BF4")]
		[Address(RVA = "0x1141BA0", Offset = "0x11407A0", VA = "0x181141BA0", Slot = "13")]
		public virtual BattleActivityMeta OverrideActMeta(string activityId)
		{
			return default(BattleActivityMeta);
		}

		// Token: 0x06018BF5 RID: 101365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BF5")]
		[Address(RVA = "0x1141A40", Offset = "0x1140640", VA = "0x181141A40", Slot = "7")]
		public sealed override void OnValueChanged(SquadGroupViewProperty groupProp)
		{
		}

		// Token: 0x06018BF6 RID: 101366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BF6")]
		[Address(RVA = "0x1141CB0", Offset = "0x11408B0", VA = "0x181141CB0")]
		protected SquadHomePluginView()
		{
		}

		// Token: 0x0401E666 RID: 124518
		[Token(Token = "0x401E666")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadGroupModel;

		// Token: 0x0401E667 RID: 124519
		[Token(Token = "0x401E667")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_squadGroupModel;

		// Token: 0x0401E668 RID: 124520
		[Token(Token = "0x401E668")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_groupControllerBindings;

		// Token: 0x0401E669 RID: 124521
		[Token(Token = "0x401E669")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_groupControllerBindings;

		// Token: 0x0401E66A RID: 124522
		[Token(Token = "0x401E66A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSquadGroupChanged;

		// Token: 0x0401E66B RID: 124523
		[Token(Token = "0x401E66B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0401E66C RID: 124524
		[Token(Token = "0x401E66C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BindGroupController;

		// Token: 0x0401E66D RID: 124525
		[Token(Token = "0x401E66D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateStartBattlePlugin;

		// Token: 0x0401E66E RID: 124526
		[Token(Token = "0x401E66E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateFinishBattlePlugin;

		// Token: 0x0401E66F RID: 124527
		[Token(Token = "0x401E66F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OverrideActMeta;

		// Token: 0x0401E670 RID: 124528
		[Token(Token = "0x401E670")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E671 RID: 124529
		[Token(Token = "0x401E671")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
