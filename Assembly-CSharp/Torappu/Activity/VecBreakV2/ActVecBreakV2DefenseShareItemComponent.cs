using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E02 RID: 28162
	[Token(Token = "0x2006E02")]
	public class ActVecBreakV2DefenseShareItemComponent : CrossAppShareRemakeBaseComponent<ActVecBreakV2DefenseShareItemModel>
	{
		// Token: 0x06028173 RID: 164211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028173")]
		[Address(RVA = "0x23625D0", Offset = "0x23611D0", VA = "0x1823625D0", Slot = "5")]
		protected override void ApplyTypedModel(ActVecBreakV2DefenseShareItemModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06028174 RID: 164212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028174")]
		[Address(RVA = "0x2363710", Offset = "0x2362310", VA = "0x182363710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028175 RID: 164213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028175")]
		[Address(RVA = "0x2362E80", Offset = "0x2361A80", VA = "0x182362E80")]
		private void _ApplyBackgroundTypePanel(ActVecBreakV2DefenseStageBaseItem.InputParam input)
		{
		}

		// Token: 0x06028176 RID: 164214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028176")]
		[Address(RVA = "0x2363440", Offset = "0x2362040", VA = "0x182363440")]
		private void _ApplyDecoVariants(ActVecBreakV2DefenseStageBaseItem.InputParam input)
		{
		}

		// Token: 0x06028177 RID: 164215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028177")]
		[Address(RVA = "0x2362C40", Offset = "0x2361840", VA = "0x182362C40")]
		private void _ApplyBackgroundAndIconColor(ActVecBreakV2DefenseStageBaseItem.InputParam input)
		{
		}

		// Token: 0x06028178 RID: 164216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028178")]
		[Address(RVA = "0x23635C0", Offset = "0x23621C0", VA = "0x1823635C0")]
		private void _ApplySeasonTag(string actId, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x06028179 RID: 164217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028179")]
		[Address(RVA = "0x2363130", Offset = "0x2361D30", VA = "0x182363130")]
		private void _ApplyContentIfNeed(ActVecBreakV2DefenseStageBaseItem.InputParam input, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602817A RID: 164218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602817A")]
		[Address(RVA = "0x2363050", Offset = "0x2361C50", VA = "0x182363050")]
		private void _ApplyBuffIcon(ActVecBreakV2DefenseStageBaseItem.InputParam input, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602817B RID: 164219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602817B")]
		[Address(RVA = "0x2363850", Offset = "0x2362450", VA = "0x182363850")]
		private void _RenderCharSlotList(ActVecBreakV2DefenseStageBaseItem.InputParam input)
		{
		}

		// Token: 0x0602817C RID: 164220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602817C")]
		[Address(RVA = "0x23639A0", Offset = "0x23625A0", VA = "0x1823639A0")]
		public ActVecBreakV2DefenseShareItemComponent()
		{
		}

		// Token: 0x04038E1F RID: 232991
		[Token(Token = "0x4038E1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActVecBreakV2DefenseShareItemComponent.BackgroundTypePanelConfig[] _panelConfigs;

		// Token: 0x04038E20 RID: 232992
		[Token(Token = "0x4038E20")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _split;

		// Token: 0x04038E21 RID: 232993
		[Token(Token = "0x4038E21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockedVariant;

		// Token: 0x04038E22 RID: 232994
		[Token(Token = "0x4038E22")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _noForceVariant;

		// Token: 0x04038E23 RID: 232995
		[Token(Token = "0x4038E23")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _unselectedVariant;

		// Token: 0x04038E24 RID: 232996
		[Token(Token = "0x4038E24")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectedVariant;

		// Token: 0x04038E25 RID: 232997
		[Token(Token = "0x4038E25")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image[] _backgroundImages;

		// Token: 0x04038E26 RID: 232998
		[Token(Token = "0x4038E26")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _backgroundColorNoForce;

		// Token: 0x04038E27 RID: 232999
		[Token(Token = "0x4038E27")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _backgroundColorUnselected;

		// Token: 0x04038E28 RID: 233000
		[Token(Token = "0x4038E28")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _backgroundColorSelected;

		// Token: 0x04038E29 RID: 233001
		[Token(Token = "0x4038E29")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _buffIconImage;

		// Token: 0x04038E2A RID: 233002
		[Token(Token = "0x4038E2A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _buffIconColorNoForce;

		// Token: 0x04038E2B RID: 233003
		[Token(Token = "0x4038E2B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _buffIconColorUnselected;

		// Token: 0x04038E2C RID: 233004
		[Token(Token = "0x4038E2C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _buffIconColorSelected;

		// Token: 0x04038E2D RID: 233005
		[Token(Token = "0x4038E2D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Image[] _seasonCodeImages;

		// Token: 0x04038E2E RID: 233006
		[Token(Token = "0x4038E2E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _contentGroup;

		// Token: 0x04038E2F RID: 233007
		[Token(Token = "0x4038E2F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private SimpleLayoutContent _charSlotListContent;

		// Token: 0x04038E30 RID: 233008
		[Token(Token = "0x4038E30")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInited;

		// Token: 0x04038E31 RID: 233009
		[Token(Token = "0x4038E31")]
		[FieldOffset(Offset = "0xE0")]
		private ActVecBreakV2DefenseShareItemComponent.CharItemAdapter m_adapter;

		// Token: 0x04038E32 RID: 233010
		[Token(Token = "0x4038E32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyTypedModel;

		// Token: 0x04038E33 RID: 233011
		[Token(Token = "0x4038E33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038E34 RID: 233012
		[Token(Token = "0x4038E34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyBackgroundTypePanel;

		// Token: 0x04038E35 RID: 233013
		[Token(Token = "0x4038E35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyDecoVariants;

		// Token: 0x04038E36 RID: 233014
		[Token(Token = "0x4038E36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ApplyBackgroundAndIconColor;

		// Token: 0x04038E37 RID: 233015
		[Token(Token = "0x4038E37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplySeasonTag;

		// Token: 0x04038E38 RID: 233016
		[Token(Token = "0x4038E38")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyContentIfNeed;

		// Token: 0x04038E39 RID: 233017
		[Token(Token = "0x4038E39")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ApplyBuffIcon;

		// Token: 0x04038E3A RID: 233018
		[Token(Token = "0x4038E3A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderCharSlotList;

		// Token: 0x04038E3B RID: 233019
		[Token(Token = "0x4038E3B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E03 RID: 28163
		[Token(Token = "0x2006E03")]
		private class CharItemAdapter : SimpleLayoutAdapter<ActVecBreakV2DefenseCharItemView>
		{
			// Token: 0x17005ED3 RID: 24275
			// (get) Token: 0x0602817D RID: 164221 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602817E RID: 164222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005ED3")]
			public List<ActVecBreakV2DefenseCharSlotModel> dataSource
			{
				[Token(Token = "0x602817D")]
				[Address(RVA = "0x2373D20", Offset = "0x2372920", VA = "0x182373D20")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602817E")]
				[Address(RVA = "0x2373D80", Offset = "0x2372980", VA = "0x182373D80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005ED4 RID: 24276
			// (get) Token: 0x0602817F RID: 164223 RVA: 0x000D0AE8 File Offset: 0x000CECE8
			[Token(Token = "0x17005ED4")]
			public override int count
			{
				[Token(Token = "0x602817F")]
				[Address(RVA = "0x2373C70", Offset = "0x2372870", VA = "0x182373C70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028180 RID: 164224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028180")]
			[Address(RVA = "0x2373AF0", Offset = "0x23726F0", VA = "0x182373AF0", Slot = "9")]
			protected override void OnRender(int position, ActVecBreakV2DefenseCharItemView view, bool isNewlyCreated)
			{
			}

			// Token: 0x06028181 RID: 164225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028181")]
			[Address(RVA = "0x2373C00", Offset = "0x2372800", VA = "0x182373C00")]
			public CharItemAdapter()
			{
			}

			// Token: 0x04038E3D RID: 233021
			[Token(Token = "0x4038E3D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSource;

			// Token: 0x04038E3E RID: 233022
			[Token(Token = "0x4038E3E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSource;

			// Token: 0x04038E3F RID: 233023
			[Token(Token = "0x4038E3F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038E40 RID: 233024
			[Token(Token = "0x4038E40")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnRender;

			// Token: 0x04038E41 RID: 233025
			[Token(Token = "0x4038E41")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006E04 RID: 28164
		[Token(Token = "0x2006E04")]
		[Serializable]
		private struct BackgroundTypePanelConfig
		{
			// Token: 0x06028182 RID: 164226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028182")]
			[Address(RVA = "0x2372CC0", Offset = "0x23718C0", VA = "0x182372CC0")]
			public void ApplyPanels(ActVecBreakV2DefenseStageBaseItem.BackgroundType type)
			{
			}

			// Token: 0x04038E42 RID: 233026
			[Token(Token = "0x4038E42")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private ActVecBreakV2DefenseStageBaseItem.BackgroundType _type;

			// Token: 0x04038E43 RID: 233027
			[Token(Token = "0x4038E43")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private GameObject[] _panels;
		}
	}
}
