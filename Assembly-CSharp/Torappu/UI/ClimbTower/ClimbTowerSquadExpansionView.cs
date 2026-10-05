using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DA6 RID: 23974
	[Token(Token = "0x2005DA6")]
	public class ClimbTowerSquadExpansionView : DataBinder<ClimbTowerSquadExpansionProperty>
	{
		// Token: 0x17005228 RID: 21032
		// (get) Token: 0x06022C29 RID: 142377 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022C2A RID: 142378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005228")]
		public Action<bool, string, string> onCharSelect
		{
			[Token(Token = "0x6022C29")]
			[Address(RVA = "0x1D597F0", Offset = "0x1D583F0", VA = "0x181D597F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022C2A")]
			[Address(RVA = "0x1D59850", Offset = "0x1D58450", VA = "0x181D59850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022C2B RID: 142379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C2B")]
		[Address(RVA = "0x1D58E90", Offset = "0x1D57A90", VA = "0x181D58E90", Slot = "7")]
		public override void OnValueChanged(ClimbTowerSquadExpansionProperty property)
		{
		}

		// Token: 0x06022C2C RID: 142380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C2C")]
		[Address(RVA = "0x1D59300", Offset = "0x1D57F00", VA = "0x181D59300")]
		public IEnumerator PlaySpawnAnim()
		{
			return null;
		}

		// Token: 0x06022C2D RID: 142381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C2D")]
		[Address(RVA = "0x1D593B0", Offset = "0x1D57FB0", VA = "0x181D593B0")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x06022C2E RID: 142382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C2E")]
		[Address(RVA = "0x1D59560", Offset = "0x1D58160", VA = "0x181D59560")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022C2F RID: 142383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C2F")]
		[Address(RVA = "0x1D59720", Offset = "0x1D58320", VA = "0x181D59720")]
		public ClimbTowerSquadExpansionView()
		{
		}

		// Token: 0x0402FC74 RID: 195700
		[Token(Token = "0x402FC74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurrentStep;

		// Token: 0x0402FC75 RID: 195701
		[Token(Token = "0x402FC75")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalStep;

		// Token: 0x0402FC76 RID: 195702
		[Token(Token = "0x402FC76")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textPos;

		// Token: 0x0402FC77 RID: 195703
		[Token(Token = "0x402FC77")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _slotList;

		// Token: 0x0402FC78 RID: 195704
		[Token(Token = "0x402FC78")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _slotListCanvasGroup;

		// Token: 0x0402FC79 RID: 195705
		[Token(Token = "0x402FC79")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _animDelay;

		// Token: 0x0402FC7A RID: 195706
		[Token(Token = "0x402FC7A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _btnConfirmAnim;

		// Token: 0x0402FC7B RID: 195707
		[Token(Token = "0x402FC7B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _btnStateToggle;

		// Token: 0x0402FC7C RID: 195708
		[Token(Token = "0x402FC7C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ClimbTowerBackgroundController _bkgController;

		// Token: 0x0402FC7D RID: 195709
		[Token(Token = "0x402FC7D")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0402FC7E RID: 195710
		[Token(Token = "0x402FC7E")]
		[FieldOffset(Offset = "0x78")]
		private ClimbTowerSquadExpansionView.Adapter m_adapter;

		// Token: 0x0402FC7F RID: 195711
		[Token(Token = "0x402FC7F")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerSquadExpansionModel m_expansionModel;

		// Token: 0x0402FC80 RID: 195712
		[Token(Token = "0x402FC80")]
		[FieldOffset(Offset = "0x88")]
		private AnimationSwitchTween m_btnConfirmTween;

		// Token: 0x0402FC81 RID: 195713
		[Token(Token = "0x402FC81")]
		[FieldOffset(Offset = "0x90")]
		private List<ClimbTowerSquadExpansionSlotItemView> m_slotItemViewList;

		// Token: 0x0402FC83 RID: 195715
		[Token(Token = "0x402FC83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCharSelect;

		// Token: 0x0402FC84 RID: 195716
		[Token(Token = "0x402FC84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCharSelect;

		// Token: 0x0402FC85 RID: 195717
		[Token(Token = "0x402FC85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402FC86 RID: 195718
		[Token(Token = "0x402FC86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlaySpawnAnim;

		// Token: 0x0402FC87 RID: 195719
		[Token(Token = "0x402FC87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x0402FC88 RID: 195720
		[Token(Token = "0x402FC88")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FC89 RID: 195721
		[Token(Token = "0x402FC89")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DA7 RID: 23975
		[Token(Token = "0x2005DA7")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022C30 RID: 142384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022C30")]
			[Address(RVA = "0x1D49820", Offset = "0x1D48420", VA = "0x181D49820")]
			public Adapter(ClimbTowerSquadExpansionView closure)
			{
			}

			// Token: 0x17005229 RID: 21033
			// (get) Token: 0x06022C31 RID: 142385 RVA: 0x000BEBD8 File Offset: 0x000BCDD8
			[Token(Token = "0x17005229")]
			public override int count
			{
				[Token(Token = "0x6022C31")]
				[Address(RVA = "0x1D49910", Offset = "0x1D48510", VA = "0x181D49910", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022C32 RID: 142386 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022C32")]
			[Address(RVA = "0x1D490B0", Offset = "0x1D47CB0", VA = "0x181D490B0")]
			public ClimbTowerSquadExpansionSlotItemView GetItemView(int position)
			{
				return null;
			}

			// Token: 0x06022C33 RID: 142387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022C33")]
			[Address(RVA = "0x1D492C0", Offset = "0x1D47EC0", VA = "0x181D492C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022C34 RID: 142388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022C34")]
			[Address(RVA = "0x1D49190", Offset = "0x1D47D90", VA = "0x181D49190")]
			public void RegisterTutorialGo()
			{
			}

			// Token: 0x0402FC8A RID: 195722
			[Token(Token = "0x402FC8A")]
			private const int TUTORIAL_ITEM_INDEX = 1;

			// Token: 0x0402FC8B RID: 195723
			[Token(Token = "0x402FC8B")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadExpansionView m_closure;

			// Token: 0x0402FC8C RID: 195724
			[Token(Token = "0x402FC8C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FC8D RID: 195725
			[Token(Token = "0x402FC8D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FC8E RID: 195726
			[Token(Token = "0x402FC8E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetItemView;

			// Token: 0x0402FC8F RID: 195727
			[Token(Token = "0x402FC8F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402FC90 RID: 195728
			[Token(Token = "0x402FC90")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RegisterTutorialGo;
		}
	}
}
