using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200524A RID: 21066
	[Token(Token = "0x200524A")]
	public class RL03DetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F140 RID: 127296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F140")]
		[Address(RVA = "0x18C7EB0", Offset = "0x18C6AB0", VA = "0x1818C7EB0")]
		private void _InitAdapter(string topicId, RoguelikeRewardStyle style)
		{
		}

		// Token: 0x0601F141 RID: 127297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F141")]
		[Address(RVA = "0x18C7BC0", Offset = "0x18C67C0", VA = "0x1818C7BC0")]
		public void OnRender(RL03DetailItemView.Options options)
		{
		}

		// Token: 0x0601F142 RID: 127298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F142")]
		[Address(RVA = "0x18C7AE0", Offset = "0x18C66E0", VA = "0x1818C7AE0")]
		public void HidePanel()
		{
		}

		// Token: 0x0601F143 RID: 127299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F143")]
		[Address(RVA = "0x18C81D0", Offset = "0x18C6DD0", VA = "0x1818C81D0")]
		public RL03DetailItemView()
		{
		}

		// Token: 0x04029ADA RID: 170714
		[Token(Token = "0x4029ADA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x04029ADB RID: 170715
		[Token(Token = "0x4029ADB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panel;

		// Token: 0x04029ADC RID: 170716
		[Token(Token = "0x4029ADC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x04029ADD RID: 170717
		[Token(Token = "0x4029ADD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _orContent;

		// Token: 0x04029ADE RID: 170718
		[Token(Token = "0x4029ADE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _itemViewCanvasGroup;

		// Token: 0x04029ADF RID: 170719
		[Token(Token = "0x4029ADF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _morePart;

		// Token: 0x04029AE0 RID: 170720
		[Token(Token = "0x4029AE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HorizontalLayoutGroup _layout;

		// Token: 0x04029AE1 RID: 170721
		[Token(Token = "0x4029AE1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int _spacingWithOr;

		// Token: 0x04029AE2 RID: 170722
		[Token(Token = "0x4029AE2")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private int _spacingWithoutOr;

		// Token: 0x04029AE3 RID: 170723
		[Token(Token = "0x4029AE3")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_panelFade;

		// Token: 0x04029AE4 RID: 170724
		[Token(Token = "0x4029AE4")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeRewardSelectView.ConstAdapter m_constAdapter;

		// Token: 0x04029AE5 RID: 170725
		[Token(Token = "0x4029AE5")]
		[FieldOffset(Offset = "0x68")]
		private RL03DetailItemView.Adapter m_adapter;

		// Token: 0x04029AE6 RID: 170726
		[Token(Token = "0x4029AE6")]
		[FieldOffset(Offset = "0x70")]
		private string m_adapterCacheId;

		// Token: 0x04029AE7 RID: 170727
		[Token(Token = "0x4029AE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitAdapter;

		// Token: 0x04029AE8 RID: 170728
		[Token(Token = "0x4029AE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04029AE9 RID: 170729
		[Token(Token = "0x4029AE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HidePanel;

		// Token: 0x04029AEA RID: 170730
		[Token(Token = "0x4029AEA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200524B RID: 21067
		[Token(Token = "0x200524B")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601F144 RID: 127300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F144")]
			[Address(RVA = "0x18C7660", Offset = "0x18C6260", VA = "0x1818C7660")]
			public Adapter(RoguelikeRewardStyle style)
			{
			}

			// Token: 0x170048AF RID: 18607
			// (get) Token: 0x0601F145 RID: 127301 RVA: 0x000B0DA8 File Offset: 0x000AEFA8
			[Token(Token = "0x170048AF")]
			public override int count
			{
				[Token(Token = "0x601F145")]
				[Address(RVA = "0x18C77E0", Offset = "0x18C63E0", VA = "0x1818C77E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601F146 RID: 127302 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F146")]
			[Address(RVA = "0x18C73F0", Offset = "0x18C5FF0", VA = "0x1818C73F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04029AEB RID: 170731
			[Token(Token = "0x4029AEB")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikeSortItemViewStruct> itemList;

			// Token: 0x04029AEC RID: 170732
			[Token(Token = "0x4029AEC")]
			[FieldOffset(Offset = "0x28")]
			private GameObject m_itemPrefab;

			// Token: 0x04029AED RID: 170733
			[Token(Token = "0x4029AED")]
			[FieldOffset(Offset = "0x30")]
			private RoguelikeRewardStyle m_style;

			// Token: 0x04029AEE RID: 170734
			[Token(Token = "0x4029AEE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029AEF RID: 170735
			[Token(Token = "0x4029AEF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04029AF0 RID: 170736
			[Token(Token = "0x4029AF0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200524C RID: 21068
		[Token(Token = "0x200524C")]
		public struct Options
		{
			// Token: 0x04029AF1 RID: 170737
			[Token(Token = "0x4029AF1")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04029AF2 RID: 170738
			[Token(Token = "0x4029AF2")]
			[FieldOffset(Offset = "0x8")]
			public List<RoguelikeSortItemViewStruct> viewStructsList;

			// Token: 0x04029AF3 RID: 170739
			[Token(Token = "0x4029AF3")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeRewardStyle style;

			// Token: 0x04029AF4 RID: 170740
			[Token(Token = "0x4029AF4")]
			[FieldOffset(Offset = "0x18")]
			public string paramText;

			// Token: 0x04029AF5 RID: 170741
			[Token(Token = "0x4029AF5")]
			[FieldOffset(Offset = "0x20")]
			public bool showOrContent;
		}
	}
}
