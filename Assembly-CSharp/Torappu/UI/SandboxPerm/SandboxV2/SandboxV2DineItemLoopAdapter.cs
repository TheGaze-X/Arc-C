using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004138 RID: 16696
	[Token(Token = "0x2004138")]
	public class SandboxV2DineItemLoopAdapter : LoopScrollAdapter<SandboxV2DineItemLoopAdapter.ViewHolder, SandboxV2DineItemModel>
	{
		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x06019C7E RID: 105598 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019C7F RID: 105599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D6D")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x6019C7E")]
			[Address(RVA = "0x12AB830", Offset = "0x12AA430", VA = "0x1812AB830")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019C7F")]
			[Address(RVA = "0x12AB960", Offset = "0x12AA560", VA = "0x1812AB960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x06019C80 RID: 105600 RVA: 0x0009F5A0 File Offset: 0x0009D7A0
		// (set) Token: 0x06019C81 RID: 105601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D6E")]
		public bool initRender
		{
			[Token(Token = "0x6019C80")]
			[Address(RVA = "0x12AB7D0", Offset = "0x12AA3D0", VA = "0x1812AB7D0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6019C81")]
			[Address(RVA = "0x12AB8F0", Offset = "0x12AA4F0", VA = "0x1812AB8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x06019C82 RID: 105602 RVA: 0x0009F5B8 File Offset: 0x0009D7B8
		// (set) Token: 0x06019C83 RID: 105603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D6F")]
		public int tutorialOnlyFirstFoodIndex
		{
			[Token(Token = "0x6019C82")]
			[Address(RVA = "0x12AB890", Offset = "0x12AA490", VA = "0x1812AB890")]
			[CompilerGenerated]
			private get
			{
				return 0;
			}
			[Token(Token = "0x6019C83")]
			[Address(RVA = "0x12AB9E0", Offset = "0x12AA5E0", VA = "0x1812AB9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019C84 RID: 105604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019C84")]
		[Address(RVA = "0x12AB1A0", Offset = "0x12A9DA0", VA = "0x1812AB1A0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06019C85 RID: 105605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C85")]
		[Address(RVA = "0x12AB260", Offset = "0x12A9E60", VA = "0x1812AB260", Slot = "13")]
		public override void UpdateView(int position, GameObject view, SandboxV2DineItemLoopAdapter.ViewHolder holder, SandboxV2DineItemModel data)
		{
		}

		// Token: 0x06019C86 RID: 105606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C86")]
		[Address(RVA = "0x12AB640", Offset = "0x12AA240", VA = "0x1812AB640")]
		private void _TutorialOnly_TryRegisterTutorialGo(SandboxV2DineItemView view)
		{
		}

		// Token: 0x06019C87 RID: 105607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C87")]
		[Address(RVA = "0x12AB760", Offset = "0x12AA360", VA = "0x1812AB760")]
		public SandboxV2DineItemLoopAdapter()
		{
		}

		// Token: 0x0402057C RID: 132476
		[Token(Token = "0x402057C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SandboxV2DineItemView _itemPrefab;

		// Token: 0x04020580 RID: 132480
		[Token(Token = "0x4020580")]
		[FieldOffset(Offset = "0x70")]
		private bool m_tutorialGoRegistered;

		// Token: 0x04020581 RID: 132481
		[Token(Token = "0x4020581")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x04020582 RID: 132482
		[Token(Token = "0x4020582")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x04020583 RID: 132483
		[Token(Token = "0x4020583")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_initRender;

		// Token: 0x04020584 RID: 132484
		[Token(Token = "0x4020584")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_initRender;

		// Token: 0x04020585 RID: 132485
		[Token(Token = "0x4020585")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tutorialOnlyFirstFoodIndex;

		// Token: 0x04020586 RID: 132486
		[Token(Token = "0x4020586")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_tutorialOnlyFirstFoodIndex;

		// Token: 0x04020587 RID: 132487
		[Token(Token = "0x4020587")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04020588 RID: 132488
		[Token(Token = "0x4020588")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04020589 RID: 132489
		[Token(Token = "0x4020589")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRegisterTutorialGo;

		// Token: 0x0402058A RID: 132490
		[Token(Token = "0x402058A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004139 RID: 16697
		[Token(Token = "0x2004139")]
		public class ViewHolder
		{
			// Token: 0x06019C88 RID: 105608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C88")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0402058B RID: 132491
			[Token(Token = "0x402058B")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2DineItemView view;
		}
	}
}
