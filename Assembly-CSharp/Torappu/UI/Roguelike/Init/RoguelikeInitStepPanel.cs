using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Init.Style;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057D6 RID: 22486
	[Token(Token = "0x20057D6")]
	public abstract class RoguelikeInitStepPanel<ContextType> : RoguelikeInitPanel where ContextType : RoguelikeInitStepContext
	{
		// Token: 0x17004D27 RID: 19751
		// (get) Token: 0x06020E32 RID: 134706 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020E33 RID: 134707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D27")]
		private protected ContextType curContext
		{
			[Token(Token = "0x6020E32")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020E33")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004D28 RID: 19752
		// (get) Token: 0x06020E34 RID: 134708 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020E35 RID: 134709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D28")]
		private protected RoguelikeInitStyle uiStyle
		{
			[Token(Token = "0x6020E34")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020E35")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06020E36 RID: 134710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E36")]
		private void _UpdateContext(ContextType ctx)
		{
		}

		// Token: 0x06020E37 RID: 134711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E37")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x06020E38 RID: 134712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E38")]
		protected virtual void OnUpdateContext(bool isNew)
		{
		}

		// Token: 0x06020E39 RID: 134713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E39")]
		public override void OnValueChanged(RoguelikeInitModelProperty property)
		{
		}

		// Token: 0x06020E3A RID: 134714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E3A")]
		protected void _PlayCardBornAnim<T>(ItemPool<T> cards, [Optional] Action endCallback) where T : RoguelikeInitCardBase
		{
		}

		// Token: 0x06020E3B RID: 134715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E3B")]
		protected RoguelikeInitStepPanel()
		{
		}

		// Token: 0x0402CAFB RID: 183035
		[Token(Token = "0x402CAFB")]
		public const float CARD_BORN_ANIM_DELAY = 0.08f;

		// Token: 0x0402CAFC RID: 183036
		[Token(Token = "0x402CAFC")]
		private const int MAX_CARD_INIT_DELAY_CNT = 5;

		// Token: 0x0402CAFD RID: 183037
		[Token(Token = "0x402CAFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UIReentrantFloatPanel _fadePanel;

		// Token: 0x0402CB00 RID: 183040
		[Token(Token = "0x402CB00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curContext;

		// Token: 0x0402CB01 RID: 183041
		[Token(Token = "0x402CB01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_curContext;

		// Token: 0x0402CB02 RID: 183042
		[Token(Token = "0x402CB02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiStyle;

		// Token: 0x0402CB03 RID: 183043
		[Token(Token = "0x402CB03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_uiStyle;

		// Token: 0x0402CB04 RID: 183044
		[Token(Token = "0x402CB04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateContext;

		// Token: 0x0402CB05 RID: 183045
		[Token(Token = "0x402CB05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x0402CB06 RID: 183046
		[Token(Token = "0x402CB06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdateContext;

		// Token: 0x0402CB07 RID: 183047
		[Token(Token = "0x402CB07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402CB08 RID: 183048
		[Token(Token = "0x402CB08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__PlayCardBornAnim;

		// Token: 0x0402CB09 RID: 183049
		[Token(Token = "0x402CB09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
