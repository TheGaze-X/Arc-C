using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070BD RID: 28861
	[Token(Token = "0x20070BD")]
	public class Act1BossRushMileStoneItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700613C RID: 24892
		// (get) Token: 0x0602904F RID: 168015 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029050 RID: 168016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700613C")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x602904F")]
			[Address(RVA = "0x2468090", Offset = "0x2466C90", VA = "0x182468090")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6029050")]
			[Address(RVA = "0x24680F0", Offset = "0x2466CF0", VA = "0x1824680F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06029051 RID: 168017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029051")]
		[Address(RVA = "0x2467A90", Offset = "0x2466690", VA = "0x182467A90")]
		public void Render(Act1BossRushMileStoneItemViewModel viewModel)
		{
		}

		// Token: 0x06029052 RID: 168018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029052")]
		[Address(RVA = "0x24679B0", Offset = "0x24665B0", VA = "0x1824679B0")]
		public void OnClick()
		{
		}

		// Token: 0x06029053 RID: 168019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029053")]
		[Address(RVA = "0x2467ED0", Offset = "0x2466AD0", VA = "0x182467ED0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029054 RID: 168020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029054")]
		[Address(RVA = "0x2468030", Offset = "0x2466C30", VA = "0x182468030")]
		public Act1BossRushMileStoneItemView()
		{
		}

		// Token: 0x0403A8D2 RID: 239826
		[Token(Token = "0x403A8D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIColorGraphic _btnRaycast;

		// Token: 0x0403A8D3 RID: 239827
		[Token(Token = "0x403A8D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggleCanReceive;

		// Token: 0x0403A8D4 RID: 239828
		[Token(Token = "0x403A8D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0403A8D5 RID: 239829
		[Token(Token = "0x403A8D5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0403A8D6 RID: 239830
		[Token(Token = "0x403A8D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x0403A8D7 RID: 239831
		[Token(Token = "0x403A8D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textItemCount;

		// Token: 0x0403A8D8 RID: 239832
		[Token(Token = "0x403A8D8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _itemViewContainer;

		// Token: 0x0403A8D9 RID: 239833
		[Token(Token = "0x403A8D9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _scaleInfo;

		// Token: 0x0403A8DA RID: 239834
		[Token(Token = "0x403A8DA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _toggleTextConst;

		// Token: 0x0403A8DB RID: 239835
		[Token(Token = "0x403A8DB")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemCard;

		// Token: 0x0403A8DD RID: 239837
		[Token(Token = "0x403A8DD")]
		[FieldOffset(Offset = "0x70")]
		private string m_cacheId;

		// Token: 0x0403A8DE RID: 239838
		[Token(Token = "0x403A8DE")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0403A8DF RID: 239839
		[Token(Token = "0x403A8DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403A8E0 RID: 239840
		[Token(Token = "0x403A8E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403A8E1 RID: 239841
		[Token(Token = "0x403A8E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A8E2 RID: 239842
		[Token(Token = "0x403A8E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403A8E3 RID: 239843
		[Token(Token = "0x403A8E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A8E4 RID: 239844
		[Token(Token = "0x403A8E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
