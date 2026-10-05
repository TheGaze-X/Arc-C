using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D89 RID: 23945
	[Token(Token = "0x2005D89")]
	public class ClimbTowerSquadSingleEditGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051EA RID: 20970
		// (get) Token: 0x06022B55 RID: 142165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022B56 RID: 142166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051EA")]
		public Action<int> onCharSelect
		{
			[Token(Token = "0x6022B55")]
			[Address(RVA = "0x1D435A0", Offset = "0x1D421A0", VA = "0x181D435A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022B56")]
			[Address(RVA = "0x1D43600", Offset = "0x1D42200", VA = "0x181D43600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051EB RID: 20971
		// (get) Token: 0x06022B57 RID: 142167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051EB")]
		public GridLayoutGroup gridLayout
		{
			[Token(Token = "0x6022B57")]
			[Address(RVA = "0x1D43540", Offset = "0x1D42140", VA = "0x181D43540")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022B58 RID: 142168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B58")]
		[Address(RVA = "0x1D43130", Offset = "0x1D41D30", VA = "0x181D43130")]
		public void InitView(ProfessionCategory profession, List<ClimbTowerSquadItemModel> charList, SpriteHub professionSpriteHub, long gameStartTs)
		{
		}

		// Token: 0x06022B59 RID: 142169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B59")]
		[Address(RVA = "0x1D43320", Offset = "0x1D41F20", VA = "0x181D43320")]
		public void Refresh(int selectCardId)
		{
		}

		// Token: 0x06022B5A RID: 142170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B5A")]
		[Address(RVA = "0x1D433C0", Offset = "0x1D41FC0", VA = "0x181D433C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022B5B RID: 142171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B5B")]
		[Address(RVA = "0x1D434E0", Offset = "0x1D420E0", VA = "0x181D434E0")]
		public ClimbTowerSquadSingleEditGroupItemView()
		{
		}

		// Token: 0x0402FB79 RID: 195449
		[Token(Token = "0x402FB79")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0402FB7A RID: 195450
		[Token(Token = "0x402FB7A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x0402FB7B RID: 195451
		[Token(Token = "0x402FB7B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		// Token: 0x0402FB7D RID: 195453
		[Token(Token = "0x402FB7D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402FB7E RID: 195454
		[Token(Token = "0x402FB7E")]
		[FieldOffset(Offset = "0x40")]
		private List<ClimbTowerSquadItemModel> m_characterList;

		// Token: 0x0402FB7F RID: 195455
		[Token(Token = "0x402FB7F")]
		[FieldOffset(Offset = "0x48")]
		private SpriteHub m_professionHub;

		// Token: 0x0402FB80 RID: 195456
		[Token(Token = "0x402FB80")]
		[FieldOffset(Offset = "0x50")]
		private int m_selectCardId;

		// Token: 0x0402FB81 RID: 195457
		[Token(Token = "0x402FB81")]
		[FieldOffset(Offset = "0x58")]
		private ClimbTowerSquadSingleEditGroupItemView.Adapter m_adapter;

		// Token: 0x0402FB82 RID: 195458
		[Token(Token = "0x402FB82")]
		[FieldOffset(Offset = "0x60")]
		private long m_cachedGameStartTs;

		// Token: 0x0402FB83 RID: 195459
		[Token(Token = "0x402FB83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCharSelect;

		// Token: 0x0402FB84 RID: 195460
		[Token(Token = "0x402FB84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCharSelect;

		// Token: 0x0402FB85 RID: 195461
		[Token(Token = "0x402FB85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gridLayout;

		// Token: 0x0402FB86 RID: 195462
		[Token(Token = "0x402FB86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0402FB87 RID: 195463
		[Token(Token = "0x402FB87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0402FB88 RID: 195464
		[Token(Token = "0x402FB88")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FB89 RID: 195465
		[Token(Token = "0x402FB89")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D8A RID: 23946
		[Token(Token = "0x2005D8A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022B5C RID: 142172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022B5C")]
			[Address(RVA = "0x1D31530", Offset = "0x1D30130", VA = "0x181D31530")]
			public Adapter(ClimbTowerSquadSingleEditGroupItemView closure)
			{
			}

			// Token: 0x170051EC RID: 20972
			// (get) Token: 0x06022B5D RID: 142173 RVA: 0x000BE8D8 File Offset: 0x000BCAD8
			[Token(Token = "0x170051EC")]
			public override int count
			{
				[Token(Token = "0x6022B5D")]
				[Address(RVA = "0x1D31630", Offset = "0x1D30230", VA = "0x181D31630", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022B5E RID: 142174 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022B5E")]
			[Address(RVA = "0x1D30FB0", Offset = "0x1D2FBB0", VA = "0x181D30FB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FB8A RID: 195466
			[Token(Token = "0x402FB8A")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadSingleEditGroupItemView m_closure;

			// Token: 0x0402FB8B RID: 195467
			[Token(Token = "0x402FB8B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FB8C RID: 195468
			[Token(Token = "0x402FB8C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FB8D RID: 195469
			[Token(Token = "0x402FB8D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
