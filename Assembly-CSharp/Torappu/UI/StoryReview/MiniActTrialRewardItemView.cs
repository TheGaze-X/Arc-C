using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048C8 RID: 18632
	[Token(Token = "0x20048C8")]
	public class MiniActTrialRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170042B9 RID: 17081
		// (get) Token: 0x0601C1B6 RID: 115126 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C1B7 RID: 115127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042B9")]
		public Action<string, List<string>> onTrialCollect
		{
			[Token(Token = "0x601C1B6")]
			[Address(RVA = "0x159C480", Offset = "0x159B080", VA = "0x18159C480")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C1B7")]
			[Address(RVA = "0x159C4E0", Offset = "0x159B0E0", VA = "0x18159C4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601C1B8 RID: 115128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1B8")]
		[Address(RVA = "0x159BB50", Offset = "0x159A750", VA = "0x18159BB50")]
		public void Render(MiniActTrialRewardItemModel rewardItemModel)
		{
		}

		// Token: 0x0601C1B9 RID: 115129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1B9")]
		[Address(RVA = "0x159B980", Offset = "0x159A580", VA = "0x18159B980")]
		public void OnTrialCollect()
		{
		}

		// Token: 0x0601C1BA RID: 115130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1BA")]
		[Address(RVA = "0x159C3D0", Offset = "0x159AFD0", VA = "0x18159C3D0")]
		public MiniActTrialRewardItemView()
		{
		}

		// Token: 0x04024BD6 RID: 150486
		[Token(Token = "0x4024BD6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _completedAlpha;

		// Token: 0x04024BD7 RID: 150487
		[Token(Token = "0x4024BD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04024BD8 RID: 150488
		[Token(Token = "0x4024BD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _gotPartGo;

		// Token: 0x04024BD9 RID: 150489
		[Token(Token = "0x4024BD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemParent;

		// Token: 0x04024BDA RID: 150490
		[Token(Token = "0x4024BDA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x04024BDB RID: 150491
		[Token(Token = "0x4024BDB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04024BDC RID: 150492
		[Token(Token = "0x4024BDC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04024BDD RID: 150493
		[Token(Token = "0x4024BDD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgCross;

		// Token: 0x04024BDE RID: 150494
		[Token(Token = "0x4024BDE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDeco1;

		// Token: 0x04024BDF RID: 150495
		[Token(Token = "0x4024BDF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDeco2;

		// Token: 0x04024BE0 RID: 150496
		[Token(Token = "0x4024BE0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _btnCollectGo;

		// Token: 0x04024BE1 RID: 150497
		[Token(Token = "0x4024BE1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Unachieve Part")]
		private GameObject _unachievePartGo;

		// Token: 0x04024BE2 RID: 150498
		[Token(Token = "0x4024BE2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Unachieve Part")]
		private Color _colorUnachieveItemText;

		// Token: 0x04024BE3 RID: 150499
		[Token(Token = "0x4024BE3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Unachieve Part")]
		private Color _colorUnachieveDecoText;

		// Token: 0x04024BE4 RID: 150500
		[Token(Token = "0x4024BE4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Unachieve Part")]
		private Color _colorUnachieveGotDecoText;

		// Token: 0x04024BE5 RID: 150501
		[Token(Token = "0x4024BE5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Achieve Part")]
		private GameObject _achievePartGo;

		// Token: 0x04024BE6 RID: 150502
		[Token(Token = "0x4024BE6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Achieve Part")]
		private Color _colorAchieveItemText;

		// Token: 0x04024BE7 RID: 150503
		[Token(Token = "0x4024BE7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Achieve Part")]
		private Color _colorAchieveDecoText;

		// Token: 0x04024BE8 RID: 150504
		[Token(Token = "0x4024BE8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Achieve Part")]
		private Color _colorAchieveGotDecoText;

		// Token: 0x04024BE9 RID: 150505
		[Token(Token = "0x4024BE9")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Achieve Part")]
		private Image _imgTheme;

		// Token: 0x04024BEA RID: 150506
		[Token(Token = "0x4024BEA")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Achieve Part")]
		private Image _imgBlink;

		// Token: 0x04024BEB RID: 150507
		[Token(Token = "0x4024BEB")]
		[FieldOffset(Offset = "0xF0")]
		private MiniActTrialRewardItemModel m_rewardModel;

		// Token: 0x04024BEC RID: 150508
		[Token(Token = "0x4024BEC")]
		[FieldOffset(Offset = "0xF8")]
		private UIItemCard m_itemCard;

		// Token: 0x04024BED RID: 150509
		[Token(Token = "0x4024BED")]
		[FieldOffset(Offset = "0x100")]
		private UIItemViewModel m_rewardViewModel;

		// Token: 0x04024BEF RID: 150511
		[Token(Token = "0x4024BEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTrialCollect;

		// Token: 0x04024BF0 RID: 150512
		[Token(Token = "0x4024BF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTrialCollect;

		// Token: 0x04024BF1 RID: 150513
		[Token(Token = "0x4024BF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024BF2 RID: 150514
		[Token(Token = "0x4024BF2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTrialCollect;

		// Token: 0x04024BF3 RID: 150515
		[Token(Token = "0x4024BF3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
