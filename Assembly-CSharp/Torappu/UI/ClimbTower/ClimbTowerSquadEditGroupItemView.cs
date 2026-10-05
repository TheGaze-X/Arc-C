using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D64 RID: 23908
	[Token(Token = "0x2005D64")]
	public class ClimbTowerSquadEditGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051A5 RID: 20901
		// (get) Token: 0x06022A37 RID: 141879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051A5")]
		public GridLayoutGroup gridLayout
		{
			[Token(Token = "0x6022A37")]
			[Address(RVA = "0x1D26810", Offset = "0x1D25410", VA = "0x181D26810")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051A6 RID: 20902
		// (get) Token: 0x06022A38 RID: 141880 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022A39 RID: 141881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051A6")]
		public Action<int> onCharClick
		{
			[Token(Token = "0x6022A38")]
			[Address(RVA = "0x1D26870", Offset = "0x1D25470", VA = "0x181D26870")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022A39")]
			[Address(RVA = "0x1D268D0", Offset = "0x1D254D0", VA = "0x181D268D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022A3A RID: 141882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A3A")]
		[Address(RVA = "0x1D26400", Offset = "0x1D25000", VA = "0x181D26400")]
		public void Render(ProfessionCategory profession, List<ClimbTowerSquadItemModel> characterList, SpriteHub professionSpriteHub, long gameStartTs)
		{
		}

		// Token: 0x06022A3B RID: 141883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A3B")]
		[Address(RVA = "0x1D26620", Offset = "0x1D25220", VA = "0x181D26620")]
		public void SetViewIndex(int viewIndex)
		{
		}

		// Token: 0x06022A3C RID: 141884 RVA: 0x000BE338 File Offset: 0x000BC538
		[Token(Token = "0x6022A3C")]
		[Address(RVA = "0x1D263A0", Offset = "0x1D24FA0", VA = "0x181D263A0")]
		public int GetViewIndex()
		{
			return 0;
		}

		// Token: 0x06022A3D RID: 141885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A3D")]
		[Address(RVA = "0x1D26690", Offset = "0x1D25290", VA = "0x181D26690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022A3E RID: 141886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A3E")]
		[Address(RVA = "0x1D267B0", Offset = "0x1D253B0", VA = "0x181D267B0")]
		public ClimbTowerSquadEditGroupItemView()
		{
		}

		// Token: 0x0402F9B7 RID: 194999
		[Token(Token = "0x402F9B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0402F9B8 RID: 195000
		[Token(Token = "0x402F9B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x0402F9B9 RID: 195001
		[Token(Token = "0x402F9B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		// Token: 0x0402F9BA RID: 195002
		[Token(Token = "0x402F9BA")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0402F9BB RID: 195003
		[Token(Token = "0x402F9BB")]
		[FieldOffset(Offset = "0x38")]
		private List<ClimbTowerSquadItemModel> m_characterList;

		// Token: 0x0402F9BC RID: 195004
		[Token(Token = "0x402F9BC")]
		[FieldOffset(Offset = "0x40")]
		private SpriteHub m_professionHub;

		// Token: 0x0402F9BD RID: 195005
		[Token(Token = "0x402F9BD")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerSquadEditGroupItemView.Adapter m_adapter;

		// Token: 0x0402F9BE RID: 195006
		[Token(Token = "0x402F9BE")]
		[FieldOffset(Offset = "0x50")]
		private int m_viewIndex;

		// Token: 0x0402F9BF RID: 195007
		[Token(Token = "0x402F9BF")]
		[FieldOffset(Offset = "0x58")]
		private long m_cachedGameStartTs;

		// Token: 0x0402F9C1 RID: 195009
		[Token(Token = "0x402F9C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gridLayout;

		// Token: 0x0402F9C2 RID: 195010
		[Token(Token = "0x402F9C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onCharClick;

		// Token: 0x0402F9C3 RID: 195011
		[Token(Token = "0x402F9C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onCharClick;

		// Token: 0x0402F9C4 RID: 195012
		[Token(Token = "0x402F9C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F9C5 RID: 195013
		[Token(Token = "0x402F9C5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetViewIndex;

		// Token: 0x0402F9C6 RID: 195014
		[Token(Token = "0x402F9C6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetViewIndex;

		// Token: 0x0402F9C7 RID: 195015
		[Token(Token = "0x402F9C7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F9C8 RID: 195016
		[Token(Token = "0x402F9C8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D65 RID: 23909
		[Token(Token = "0x2005D65")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06022A3F RID: 141887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022A3F")]
			[Address(RVA = "0x1D15E90", Offset = "0x1D14A90", VA = "0x181D15E90")]
			public Adapter(ClimbTowerSquadEditGroupItemView closure)
			{
			}

			// Token: 0x170051A7 RID: 20903
			// (get) Token: 0x06022A40 RID: 141888 RVA: 0x000BE350 File Offset: 0x000BC550
			[Token(Token = "0x170051A7")]
			public override int count
			{
				[Token(Token = "0x6022A40")]
				[Address(RVA = "0x1D16010", Offset = "0x1D14C10", VA = "0x181D16010", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022A41 RID: 141889 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022A41")]
			[Address(RVA = "0x1D15910", Offset = "0x1D14510", VA = "0x181D15910", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F9C9 RID: 195017
			[Token(Token = "0x402F9C9")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadEditGroupItemView m_closure;

			// Token: 0x0402F9CA RID: 195018
			[Token(Token = "0x402F9CA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F9CB RID: 195019
			[Token(Token = "0x402F9CB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F9CC RID: 195020
			[Token(Token = "0x402F9CC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
