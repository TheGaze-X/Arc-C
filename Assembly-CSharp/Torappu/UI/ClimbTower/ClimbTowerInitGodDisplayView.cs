using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D4B RID: 23883
	[Token(Token = "0x2005D4B")]
	public class ClimbTowerInitGodDisplayView : DataBinder<ClimbTowerInitGodDisplayProp>
	{
		// Token: 0x17005171 RID: 20849
		// (get) Token: 0x06022964 RID: 141668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022965 RID: 141669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005171")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x6022964")]
			[Address(RVA = "0x1D1BF80", Offset = "0x1D1AB80", VA = "0x181D1BF80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022965")]
			[Address(RVA = "0x1D1BFE0", Offset = "0x1D1ABE0", VA = "0x181D1BFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022966 RID: 141670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022966")]
		[Address(RVA = "0x1D1BA60", Offset = "0x1D1A660", VA = "0x181D1BA60", Slot = "7")]
		public override void OnValueChanged(ClimbTowerInitGodDisplayProp property)
		{
		}

		// Token: 0x06022967 RID: 141671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022967")]
		[Address(RVA = "0x1D1BD90", Offset = "0x1D1A990", VA = "0x181D1BD90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022968 RID: 141672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022968")]
		[Address(RVA = "0x1D1BF10", Offset = "0x1D1AB10", VA = "0x181D1BF10")]
		public ClimbTowerInitGodDisplayView()
		{
		}

		// Token: 0x0402F892 RID: 194706
		[Token(Token = "0x402F892")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _stepList;

		// Token: 0x0402F893 RID: 194707
		[Token(Token = "0x402F893")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _godCardList;

		// Token: 0x0402F894 RID: 194708
		[Token(Token = "0x402F894")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0402F895 RID: 194709
		[Token(Token = "0x402F895")]
		[FieldOffset(Offset = "0x38")]
		private ClimbTowerInitStepListAdapter m_stepAdapter;

		// Token: 0x0402F896 RID: 194710
		[Token(Token = "0x402F896")]
		[FieldOffset(Offset = "0x40")]
		private ClimbTowerInitGodDisplayModel m_displayModel;

		// Token: 0x0402F897 RID: 194711
		[Token(Token = "0x402F897")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerInitGodDisplayView.Adapter m_godCardListAdapter;

		// Token: 0x0402F899 RID: 194713
		[Token(Token = "0x402F899")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0402F89A RID: 194714
		[Token(Token = "0x402F89A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0402F89B RID: 194715
		[Token(Token = "0x402F89B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F89C RID: 194716
		[Token(Token = "0x402F89C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F89D RID: 194717
		[Token(Token = "0x402F89D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D4C RID: 23884
		[Token(Token = "0x2005D4C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022969 RID: 141673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022969")]
			[Address(RVA = "0x1D15F90", Offset = "0x1D14B90", VA = "0x181D15F90")]
			public Adapter(ClimbTowerInitGodDisplayView closure)
			{
			}

			// Token: 0x17005172 RID: 20850
			// (get) Token: 0x0602296A RID: 141674 RVA: 0x000BDF90 File Offset: 0x000BC190
			[Token(Token = "0x17005172")]
			public override int count
			{
				[Token(Token = "0x602296A")]
				[Address(RVA = "0x1D16180", Offset = "0x1D14D80", VA = "0x181D16180", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602296B RID: 141675 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602296B")]
			[Address(RVA = "0x1D15B60", Offset = "0x1D14760", VA = "0x181D15B60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F89E RID: 194718
			[Token(Token = "0x402F89E")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerInitGodDisplayView m_closure;

			// Token: 0x0402F89F RID: 194719
			[Token(Token = "0x402F89F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F8A0 RID: 194720
			[Token(Token = "0x402F8A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F8A1 RID: 194721
			[Token(Token = "0x402F8A1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
