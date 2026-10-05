using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Mode
{
	// Token: 0x0200466C RID: 18028
	[Token(Token = "0x200466C")]
	public abstract class RoguelikeTopicSubView : DataBinder<RoguelikeTopicModeViewProperty>
	{
		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x0601B5F6 RID: 112118 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B5F7 RID: 112119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700412A")]
		private protected RoguelikeTopicState.Bridge bindBridge
		{
			[Token(Token = "0x601B5F6")]
			[Address(RVA = "0x14BFF60", Offset = "0x14BEB60", VA = "0x1814BFF60")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601B5F7")]
			[Address(RVA = "0x14C00E0", Offset = "0x14BECE0", VA = "0x1814C00E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x0601B5F8 RID: 112120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700412B")]
		public string topicId
		{
			[Token(Token = "0x601B5F8")]
			[Address(RVA = "0x14BFFC0", Offset = "0x14BEBC0", VA = "0x1814BFFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x0601B5F9 RID: 112121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700412C")]
		public string bgmInstIdAlias
		{
			[Token(Token = "0x601B5F9")]
			[Address(RVA = "0x14BFE60", Offset = "0x14BEA60", VA = "0x1814BFE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B5FA RID: 112122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5FA")]
		[Address(RVA = "0x14BFCB0", Offset = "0x14BE8B0", VA = "0x1814BFCB0")]
		public void Init(RoguelikeTopicState.Bridge bridge)
		{
		}

		// Token: 0x0601B5FB RID: 112123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5FB")]
		[Address(RVA = "0x14BB4E0", Offset = "0x14BA0E0", VA = "0x1814BB4E0", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B5FC RID: 112124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5FC")]
		[Address(RVA = "0x14BB540", Offset = "0x14BA140", VA = "0x1814BB540", Slot = "8")]
		public virtual void SetEffectEnable(bool enable)
		{
		}

		// Token: 0x0601B5FD RID: 112125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5FD")]
		[Address(RVA = "0x14BFD90", Offset = "0x14BE990", VA = "0x1814BFD90", Slot = "9")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0601B5FE RID: 112126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5FE")]
		[Address(RVA = "0x14BFDF0", Offset = "0x14BE9F0", VA = "0x1814BFDF0")]
		protected RoguelikeTopicSubView()
		{
		}

		// Token: 0x040235FC RID: 144892
		[Token(Token = "0x40235FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindBridge;

		// Token: 0x040235FD RID: 144893
		[Token(Token = "0x40235FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindBridge;

		// Token: 0x040235FE RID: 144894
		[Token(Token = "0x40235FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040235FF RID: 144895
		[Token(Token = "0x40235FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_bgmInstIdAlias;

		// Token: 0x04023600 RID: 144896
		[Token(Token = "0x4023600")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023601 RID: 144897
		[Token(Token = "0x4023601")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023602 RID: 144898
		[Token(Token = "0x4023602")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetEffectEnable;

		// Token: 0x04023603 RID: 144899
		[Token(Token = "0x4023603")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04023604 RID: 144900
		[Token(Token = "0x4023604")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
