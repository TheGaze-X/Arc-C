using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052A3 RID: 21155
	[Token(Token = "0x20052A3")]
	public class RoguelikeClassicEndingStatsCharGroupView : RoguelikeClassicEndingStatsViewComponent<RoguelikeClassicEndingStatsCharGroupModel>
	{
		// Token: 0x0601F36C RID: 127852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F36C")]
		[Address(RVA = "0x18E3DE0", Offset = "0x18E29E0", VA = "0x1818E3DE0", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x0601F36D RID: 127853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F36D")]
		[Address(RVA = "0x18E3F20", Offset = "0x18E2B20", VA = "0x1818E3F20", Slot = "7")]
		protected override void Render(RoguelikeClassicEndingStatsCharGroupModel viewModel)
		{
		}

		// Token: 0x0601F36E RID: 127854 RVA: 0x000B1330 File Offset: 0x000AF530
		[Token(Token = "0x601F36E")]
		[Address(RVA = "0x18E41D0", Offset = "0x18E2DD0", VA = "0x1818E41D0")]
		private static float _CalcPrefabHeight(RoguelikeClassicEndingStatsCharGroupView prefab, RoguelikeClassicEndingStatsCharGroupModel viewModel)
		{
			return 0f;
		}

		// Token: 0x0601F36F RID: 127855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F36F")]
		[Address(RVA = "0x18E4340", Offset = "0x18E2F40", VA = "0x1818E4340")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F370 RID: 127856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F370")]
		[Address(RVA = "0x18E43C0", Offset = "0x18E2FC0", VA = "0x1818E43C0")]
		public RoguelikeClassicEndingStatsCharGroupView()
		{
		}

		// Token: 0x04029E81 RID: 171649
		[Token(Token = "0x4029E81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCharNum;

		// Token: 0x04029E82 RID: 171650
		[Token(Token = "0x4029E82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charLayoutContent;

		// Token: 0x04029E83 RID: 171651
		[Token(Token = "0x4029E83")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _charLayout;

		// Token: 0x04029E84 RID: 171652
		[Token(Token = "0x4029E84")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x04029E85 RID: 171653
		[Token(Token = "0x4029E85")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeEndingCharItemViewPlugin _charItemViewPluginPrefab;

		// Token: 0x04029E86 RID: 171654
		[Token(Token = "0x4029E86")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeClassicEndingStatsCharGroupView.EndingCharAdapter m_adapter;

		// Token: 0x04029E87 RID: 171655
		[Token(Token = "0x4029E87")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04029E88 RID: 171656
		[Token(Token = "0x4029E88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x04029E89 RID: 171657
		[Token(Token = "0x4029E89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029E8A RID: 171658
		[Token(Token = "0x4029E8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalcPrefabHeight;

		// Token: 0x04029E8B RID: 171659
		[Token(Token = "0x4029E8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029E8C RID: 171660
		[Token(Token = "0x4029E8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052A4 RID: 21156
		[Token(Token = "0x20052A4")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RoguelikeClassicEndingStatsCharGroupView, RoguelikeClassicEndingStatsCharGroupModel>
		{
			// Token: 0x0601F371 RID: 127857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F371")]
			[Address(RVA = "0x18F2E40", Offset = "0x18F1A40", VA = "0x1818F2E40")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x0601F372 RID: 127858 RVA: 0x000B1348 File Offset: 0x000AF548
			[Token(Token = "0x601F372")]
			[Address(RVA = "0x18F2A50", Offset = "0x18F1650", VA = "0x1818F2A50", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x04029E8D RID: 171661
			[Token(Token = "0x4029E8D")]
			[FieldOffset(Offset = "0x38")]
			private float m_cachedHeight;

			// Token: 0x04029E8E RID: 171662
			[Token(Token = "0x4029E8E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029E8F RID: 171663
			[Token(Token = "0x4029E8F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x020052A5 RID: 21157
		[Token(Token = "0x20052A5")]
		private class EndingCharAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004932 RID: 18738
			// (get) Token: 0x0601F373 RID: 127859 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601F374 RID: 127860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004932")]
			public List<RoguelikeCharCardViewModel> groupModel
			{
				[Token(Token = "0x601F373")]
				[Address(RVA = "0x18DDB50", Offset = "0x18DC750", VA = "0x1818DDB50")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601F374")]
				[Address(RVA = "0x18DDC90", Offset = "0x18DC890", VA = "0x1818DDC90")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004933 RID: 18739
			// (get) Token: 0x0601F375 RID: 127861 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601F376 RID: 127862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004933")]
			public RoguelikeEndingCharItemViewPlugin charItemViewPluginPrefab
			{
				[Token(Token = "0x601F375")]
				[Address(RVA = "0x18DDA30", Offset = "0x18DC630", VA = "0x1818DDA30")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601F376")]
				[Address(RVA = "0x18DDC10", Offset = "0x18DC810", VA = "0x1818DDC10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004934 RID: 18740
			// (get) Token: 0x0601F377 RID: 127863 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601F378 RID: 127864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004934")]
			public string topicId
			{
				[Token(Token = "0x601F377")]
				[Address(RVA = "0x18DDBB0", Offset = "0x18DC7B0", VA = "0x1818DDBB0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601F378")]
				[Address(RVA = "0x18DDD10", Offset = "0x18DC910", VA = "0x1818DDD10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004935 RID: 18741
			// (get) Token: 0x0601F379 RID: 127865 RVA: 0x000B1360 File Offset: 0x000AF560
			[Token(Token = "0x17004935")]
			public override int count
			{
				[Token(Token = "0x601F379")]
				[Address(RVA = "0x18DDA90", Offset = "0x18DC690", VA = "0x1818DDA90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601F37A RID: 127866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F37A")]
			[Address(RVA = "0x18DD750", Offset = "0x18DC350", VA = "0x1818DD750", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601F37B RID: 127867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F37B")]
			[Address(RVA = "0x18DD9D0", Offset = "0x18DC5D0", VA = "0x1818DD9D0")]
			public EndingCharAdapter()
			{
			}

			// Token: 0x04029E93 RID: 171667
			[Token(Token = "0x4029E93")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_groupModel;

			// Token: 0x04029E94 RID: 171668
			[Token(Token = "0x4029E94")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_groupModel;

			// Token: 0x04029E95 RID: 171669
			[Token(Token = "0x4029E95")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_charItemViewPluginPrefab;

			// Token: 0x04029E96 RID: 171670
			[Token(Token = "0x4029E96")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_charItemViewPluginPrefab;

			// Token: 0x04029E97 RID: 171671
			[Token(Token = "0x4029E97")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_topicId;

			// Token: 0x04029E98 RID: 171672
			[Token(Token = "0x4029E98")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_topicId;

			// Token: 0x04029E99 RID: 171673
			[Token(Token = "0x4029E99")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04029E9A RID: 171674
			[Token(Token = "0x4029E9A")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04029E9B RID: 171675
			[Token(Token = "0x4029E9B")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
