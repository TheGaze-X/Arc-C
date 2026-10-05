using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DED RID: 24045
	[Token(Token = "0x2005DED")]
	public class CharacterShowBuildingPanelView : CharacterShowRightInfoViewBase
	{
		// Token: 0x06022D88 RID: 142728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D88")]
		[Address(RVA = "0x1D6C600", Offset = "0x1D6B200", VA = "0x181D6C600", Slot = "7")]
		public override void OnValueChanged(CharacterShowProp property)
		{
		}

		// Token: 0x06022D89 RID: 142729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D89")]
		[Address(RVA = "0x1D6C820", Offset = "0x1D6B420", VA = "0x181D6C820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022D8A RID: 142730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D8A")]
		[Address(RVA = "0x1D6C940", Offset = "0x1D6B540", VA = "0x181D6C940")]
		public CharacterShowBuildingPanelView()
		{
		}

		// Token: 0x0402FF80 RID: 196480
		[Token(Token = "0x402FF80")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x0402FF81 RID: 196481
		[Token(Token = "0x402FF81")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0402FF82 RID: 196482
		[Token(Token = "0x402FF82")]
		[FieldOffset(Offset = "0x30")]
		private CharacterShowBuildingPanelView.BuildingBuffList m_buffListAdapter;

		// Token: 0x0402FF83 RID: 196483
		[Token(Token = "0x402FF83")]
		[FieldOffset(Offset = "0x38")]
		private CharacterShowV2Model m_charShowModel;

		// Token: 0x0402FF84 RID: 196484
		[Token(Token = "0x402FF84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402FF85 RID: 196485
		[Token(Token = "0x402FF85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FF86 RID: 196486
		[Token(Token = "0x402FF86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DEE RID: 24046
		[Token(Token = "0x2005DEE")]
		private class BuildingBuffList : SimpleLayoutAdapter
		{
			// Token: 0x06022D8B RID: 142731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022D8B")]
			[Address(RVA = "0x1D602E0", Offset = "0x1D5EEE0", VA = "0x181D602E0")]
			public BuildingBuffList(CharacterShowBuildingPanelView closure)
			{
			}

			// Token: 0x1700528E RID: 21134
			// (get) Token: 0x06022D8C RID: 142732 RVA: 0x000BF430 File Offset: 0x000BD630
			[Token(Token = "0x1700528E")]
			public override int count
			{
				[Token(Token = "0x6022D8C")]
				[Address(RVA = "0x1D60360", Offset = "0x1D5EF60", VA = "0x181D60360", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022D8D RID: 142733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022D8D")]
			[Address(RVA = "0x1D600A0", Offset = "0x1D5ECA0", VA = "0x181D600A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FF87 RID: 196487
			[Token(Token = "0x402FF87")]
			[FieldOffset(Offset = "0x20")]
			private CharacterShowBuildingPanelView m_closure;

			// Token: 0x0402FF88 RID: 196488
			[Token(Token = "0x402FF88")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FF89 RID: 196489
			[Token(Token = "0x402FF89")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FF8A RID: 196490
			[Token(Token = "0x402FF8A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
