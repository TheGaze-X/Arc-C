using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D79 RID: 23929
	[Token(Token = "0x2005D79")]
	public class ClimbTowerSquadMultiEditGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051C9 RID: 20937
		// (get) Token: 0x06022ADC RID: 142044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022ADD RID: 142045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051C9")]
		public Action<int, string> onSkillSelect
		{
			[Token(Token = "0x6022ADC")]
			[Address(RVA = "0x1D3E220", Offset = "0x1D3CE20", VA = "0x181D3E220")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022ADD")]
			[Address(RVA = "0x1D3E300", Offset = "0x1D3CF00", VA = "0x181D3E300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051CA RID: 20938
		// (get) Token: 0x06022ADE RID: 142046 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022ADF RID: 142047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051CA")]
		public Action<int, string> onEquipSelect
		{
			[Token(Token = "0x6022ADE")]
			[Address(RVA = "0x1D3E1C0", Offset = "0x1D3CDC0", VA = "0x181D3E1C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022ADF")]
			[Address(RVA = "0x1D3E280", Offset = "0x1D3CE80", VA = "0x181D3E280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170051CB RID: 20939
		// (get) Token: 0x06022AE0 RID: 142048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051CB")]
		public GridLayoutGroup gridLayout
		{
			[Token(Token = "0x6022AE0")]
			[Address(RVA = "0x1D3E160", Offset = "0x1D3CD60", VA = "0x181D3E160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022AE1 RID: 142049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AE1")]
		[Address(RVA = "0x1D3DCC0", Offset = "0x1D3C8C0", VA = "0x181D3DCC0")]
		public void InitView(ProfessionCategory profession, List<ClimbTowerSquadMultiEditCharModel> charList, SpriteHub professionSpriteHub, long gameStartTs)
		{
		}

		// Token: 0x06022AE2 RID: 142050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AE2")]
		[Address(RVA = "0x1D3DF70", Offset = "0x1D3CB70", VA = "0x181D3DF70")]
		public void SetViewIndex(int viewIndex)
		{
		}

		// Token: 0x06022AE3 RID: 142051 RVA: 0x000BE650 File Offset: 0x000BC850
		[Token(Token = "0x6022AE3")]
		[Address(RVA = "0x1D3DC60", Offset = "0x1D3C860", VA = "0x181D3DC60")]
		public int GetViewIndex()
		{
			return 0;
		}

		// Token: 0x06022AE4 RID: 142052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AE4")]
		[Address(RVA = "0x1D3DEB0", Offset = "0x1D3CAB0", VA = "0x181D3DEB0")]
		public void Refresh(ClimbTowerSquadMultiEditModel.EditType editType, bool needRebuild)
		{
		}

		// Token: 0x06022AE5 RID: 142053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AE5")]
		[Address(RVA = "0x1D3DFE0", Offset = "0x1D3CBE0", VA = "0x181D3DFE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022AE6 RID: 142054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AE6")]
		[Address(RVA = "0x1D3E100", Offset = "0x1D3CD00", VA = "0x181D3E100")]
		public ClimbTowerSquadMultiEditGroupItemView()
		{
		}

		// Token: 0x0402FAC5 RID: 195269
		[Token(Token = "0x402FAC5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0402FAC6 RID: 195270
		[Token(Token = "0x402FAC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x0402FAC7 RID: 195271
		[Token(Token = "0x402FAC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		// Token: 0x0402FAC8 RID: 195272
		[Token(Token = "0x402FAC8")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0402FAC9 RID: 195273
		[Token(Token = "0x402FAC9")]
		[FieldOffset(Offset = "0x38")]
		private List<ClimbTowerSquadMultiEditCharModel> m_characterList;

		// Token: 0x0402FACA RID: 195274
		[Token(Token = "0x402FACA")]
		[FieldOffset(Offset = "0x40")]
		private SpriteHub m_professionHub;

		// Token: 0x0402FACB RID: 195275
		[Token(Token = "0x402FACB")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerSquadMultiEditModel.EditType m_editType;

		// Token: 0x0402FACC RID: 195276
		[Token(Token = "0x402FACC")]
		[FieldOffset(Offset = "0x50")]
		private ClimbTowerSquadMultiEditGroupItemView.Adapter m_adapter;

		// Token: 0x0402FACD RID: 195277
		[Token(Token = "0x402FACD")]
		[FieldOffset(Offset = "0x58")]
		private int m_viewIndex;

		// Token: 0x0402FACE RID: 195278
		[Token(Token = "0x402FACE")]
		[FieldOffset(Offset = "0x60")]
		private long m_cachedGameStartTs;

		// Token: 0x0402FACF RID: 195279
		[Token(Token = "0x402FACF")]
		[FieldOffset(Offset = "0x68")]
		private bool m_needRebuild;

		// Token: 0x0402FAD2 RID: 195282
		[Token(Token = "0x402FAD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSkillSelect;

		// Token: 0x0402FAD3 RID: 195283
		[Token(Token = "0x402FAD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSkillSelect;

		// Token: 0x0402FAD4 RID: 195284
		[Token(Token = "0x402FAD4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onEquipSelect;

		// Token: 0x0402FAD5 RID: 195285
		[Token(Token = "0x402FAD5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onEquipSelect;

		// Token: 0x0402FAD6 RID: 195286
		[Token(Token = "0x402FAD6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_gridLayout;

		// Token: 0x0402FAD7 RID: 195287
		[Token(Token = "0x402FAD7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0402FAD8 RID: 195288
		[Token(Token = "0x402FAD8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetViewIndex;

		// Token: 0x0402FAD9 RID: 195289
		[Token(Token = "0x402FAD9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetViewIndex;

		// Token: 0x0402FADA RID: 195290
		[Token(Token = "0x402FADA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0402FADB RID: 195291
		[Token(Token = "0x402FADB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FADC RID: 195292
		[Token(Token = "0x402FADC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D7A RID: 23930
		[Token(Token = "0x2005D7A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022AE7 RID: 142055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022AE7")]
			[Address(RVA = "0x1D315B0", Offset = "0x1D301B0", VA = "0x181D315B0")]
			public Adapter(ClimbTowerSquadMultiEditGroupItemView closure)
			{
			}

			// Token: 0x170051CC RID: 20940
			// (get) Token: 0x06022AE8 RID: 142056 RVA: 0x000BE668 File Offset: 0x000BC868
			[Token(Token = "0x170051CC")]
			public override int count
			{
				[Token(Token = "0x6022AE8")]
				[Address(RVA = "0x1D31790", Offset = "0x1D30390", VA = "0x181D31790", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022AE9 RID: 142057 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022AE9")]
			[Address(RVA = "0x1D30C40", Offset = "0x1D2F840", VA = "0x181D30C40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FADD RID: 195293
			[Token(Token = "0x402FADD")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadMultiEditGroupItemView m_closure;

			// Token: 0x0402FADE RID: 195294
			[Token(Token = "0x402FADE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FADF RID: 195295
			[Token(Token = "0x402FADF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FAE0 RID: 195296
			[Token(Token = "0x402FAE0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
