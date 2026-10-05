using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005839 RID: 22585
	[Token(Token = "0x2005839")]
	public class RL03MenuVisionAndChaosWindow : RoguelikeMenuWindow<RL03MenuVisionAndChaosViewModel>
	{
		// Token: 0x17004D73 RID: 19827
		// (get) Token: 0x06021027 RID: 135207 RVA: 0x000B8260 File Offset: 0x000B6460
		[Token(Token = "0x17004D73")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x6021027")]
			[Address(RVA = "0x1B4EDF0", Offset = "0x1B4D9F0", VA = "0x181B4EDF0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06021028 RID: 135208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021028")]
		[Address(RVA = "0x1B4E940", Offset = "0x1B4D540", VA = "0x181B4E940", Slot = "10")]
		public override void Render(RL03MenuVisionAndChaosViewModel viewModel)
		{
		}

		// Token: 0x06021029 RID: 135209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021029")]
		[Address(RVA = "0x1B4E7D0", Offset = "0x1B4D3D0", VA = "0x181B4E7D0", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0602102A RID: 135210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602102A")]
		[Address(RVA = "0x1B4EB20", Offset = "0x1B4D720", VA = "0x181B4EB20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602102B RID: 135211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602102B")]
		[Address(RVA = "0x1B4ED80", Offset = "0x1B4D980", VA = "0x181B4ED80")]
		public RL03MenuVisionAndChaosWindow()
		{
		}

		// Token: 0x0602102C RID: 135212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602102C")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402CE3F RID: 183871
		[Token(Token = "0x402CE3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL03MenuVCWindowElement[] _elements;

		// Token: 0x0402CE40 RID: 183872
		[Token(Token = "0x402CE40")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _chaosList;

		// Token: 0x0402CE41 RID: 183873
		[Token(Token = "0x402CE41")]
		[FieldOffset(Offset = "0x38")]
		private RL03MenuVisionAndChaosWindow.ChaosListAdapter m_adapter;

		// Token: 0x0402CE42 RID: 183874
		[Token(Token = "0x402CE42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402CE43 RID: 183875
		[Token(Token = "0x402CE43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CE44 RID: 183876
		[Token(Token = "0x402CE44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402CE45 RID: 183877
		[Token(Token = "0x402CE45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CE46 RID: 183878
		[Token(Token = "0x402CE46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200583A RID: 22586
		[Token(Token = "0x200583A")]
		private class ChaosListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602102D RID: 135213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602102D")]
			[Address(RVA = "0x1B44AD0", Offset = "0x1B436D0", VA = "0x181B44AD0")]
			public ChaosListAdapter(RL03MenuVisionAndChaosWindow win)
			{
			}

			// Token: 0x17004D74 RID: 19828
			// (get) Token: 0x0602102E RID: 135214 RVA: 0x000B8278 File Offset: 0x000B6478
			[Token(Token = "0x17004D74")]
			public override int count
			{
				[Token(Token = "0x602102E")]
				[Address(RVA = "0x1B44B50", Offset = "0x1B43750", VA = "0x181B44B50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602102F RID: 135215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602102F")]
			[Address(RVA = "0x1B44880", Offset = "0x1B43480", VA = "0x181B44880", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402CE47 RID: 183879
			[Token(Token = "0x402CE47")]
			[FieldOffset(Offset = "0x20")]
			private RL03MenuVisionAndChaosWindow m_window;

			// Token: 0x0402CE48 RID: 183880
			[Token(Token = "0x402CE48")]
			[FieldOffset(Offset = "0x28")]
			public List<RL03MenuVisionAndChaosViewModel.VCWindowViewModel.ChaosItemModel> items;

			// Token: 0x0402CE49 RID: 183881
			[Token(Token = "0x402CE49")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CE4A RID: 183882
			[Token(Token = "0x402CE4A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402CE4B RID: 183883
			[Token(Token = "0x402CE4B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
