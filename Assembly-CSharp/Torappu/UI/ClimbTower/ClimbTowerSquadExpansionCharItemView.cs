using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D93 RID: 23955
	[Token(Token = "0x2005D93")]
	public class ClimbTowerSquadExpansionCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170051FE RID: 20990
		// (get) Token: 0x06022BA9 RID: 142249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051FE")]
		public GameObject hotspotGo
		{
			[Token(Token = "0x6022BA9")]
			[Address(RVA = "0x1D37B50", Offset = "0x1D36750", VA = "0x181D37B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051FF RID: 20991
		// (get) Token: 0x06022BAA RID: 142250 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022BAB RID: 142251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051FF")]
		public Action<bool, string, string> onCharSelect
		{
			[Token(Token = "0x6022BAA")]
			[Address(RVA = "0x1D37C10", Offset = "0x1D36810", VA = "0x181D37C10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022BAB")]
			[Address(RVA = "0x1D37C70", Offset = "0x1D36870", VA = "0x181D37C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005200 RID: 20992
		// (get) Token: 0x06022BAC RID: 142252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005200")]
		public LayoutElement layoutElement
		{
			[Token(Token = "0x6022BAC")]
			[Address(RVA = "0x1D37BB0", Offset = "0x1D367B0", VA = "0x181D37BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022BAD RID: 142253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BAD")]
		[Address(RVA = "0x1D37650", Offset = "0x1D36250", VA = "0x181D37650")]
		public void RenderGiveUpView(bool isSelected, bool haveAnySelect)
		{
		}

		// Token: 0x06022BAE RID: 142254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BAE")]
		[Address(RVA = "0x1D37290", Offset = "0x1D35E90", VA = "0x181D37290")]
		public void RenderCharView(int index, string groupId, bool isGroup, bool isCharSelect, bool haveAnySelect, ClimbTowerSquadExpansionCharModel charModel, float spacing)
		{
		}

		// Token: 0x06022BAF RID: 142255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BAF")]
		[Address(RVA = "0x1D377C0", Offset = "0x1D363C0", VA = "0x181D377C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022BB0 RID: 142256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022BB0")]
		[Address(RVA = "0x1D371C0", Offset = "0x1D35DC0", VA = "0x181D371C0")]
		public IEnumerator PlayEnterAnim(Action tickAction)
		{
			return null;
		}

		// Token: 0x06022BB1 RID: 142257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BB1")]
		[Address(RVA = "0x1D37750", Offset = "0x1D36350", VA = "0x181D37750")]
		public void ResetEnterAnim()
		{
		}

		// Token: 0x06022BB2 RID: 142258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BB2")]
		[Address(RVA = "0x1D37070", Offset = "0x1D35C70", VA = "0x181D37070")]
		public void OnCharSelect()
		{
		}

		// Token: 0x06022BB3 RID: 142259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022BB3")]
		[Address(RVA = "0x1D37AE0", Offset = "0x1D366E0", VA = "0x181D37AE0")]
		public ClimbTowerSquadExpansionCharItemView()
		{
		}

		// Token: 0x0402FBDA RID: 195546
		[Token(Token = "0x402FBDA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imageChrPortrait;

		// Token: 0x0402FBDB RID: 195547
		[Token(Token = "0x402FBDB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0402FBDC RID: 195548
		[Token(Token = "0x402FBDC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgRarity;

		// Token: 0x0402FBDD RID: 195549
		[Token(Token = "0x402FBDD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgEvolve;

		// Token: 0x0402FBDE RID: 195550
		[Token(Token = "0x402FBDE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402FBDF RID: 195551
		[Token(Token = "0x402FBDF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x0402FBE0 RID: 195552
		[Token(Token = "0x402FBE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402FBE1 RID: 195553
		[Token(Token = "0x402FBE1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0402FBE2 RID: 195554
		[Token(Token = "0x402FBE2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _maskSwitchAnim;

		// Token: 0x0402FBE3 RID: 195555
		[Token(Token = "0x402FBE3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402FBE4 RID: 195556
		[Token(Token = "0x402FBE4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _enterTweenDuration;

		// Token: 0x0402FBE5 RID: 195557
		[Token(Token = "0x402FBE5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _spIconGo;

		// Token: 0x0402FBE6 RID: 195558
		[Token(Token = "0x402FBE6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _npcIconGo;

		// Token: 0x0402FBE7 RID: 195559
		[Token(Token = "0x402FBE7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _hotspotGo;

		// Token: 0x0402FBE8 RID: 195560
		[Token(Token = "0x402FBE8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TwoStateToggle _toggleView;

		// Token: 0x0402FBE9 RID: 195561
		[Token(Token = "0x402FBE9")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0402FBEA RID: 195562
		[Token(Token = "0x402FBEA")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_isGiveUp;

		// Token: 0x0402FBEB RID: 195563
		[Token(Token = "0x402FBEB")]
		[FieldOffset(Offset = "0xA8")]
		private string m_portraitCache;

		// Token: 0x0402FBEC RID: 195564
		[Token(Token = "0x402FBEC")]
		[FieldOffset(Offset = "0xB0")]
		private int m_index;

		// Token: 0x0402FBED RID: 195565
		[Token(Token = "0x402FBED")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_isSelect;

		// Token: 0x0402FBEE RID: 195566
		[Token(Token = "0x402FBEE")]
		[FieldOffset(Offset = "0xB8")]
		private string m_charId;

		// Token: 0x0402FBEF RID: 195567
		[Token(Token = "0x402FBEF")]
		[FieldOffset(Offset = "0xC0")]
		private float m_spacing;

		// Token: 0x0402FBF0 RID: 195568
		[Token(Token = "0x402FBF0")]
		[FieldOffset(Offset = "0xC8")]
		private string m_groupId;

		// Token: 0x0402FBF1 RID: 195569
		[Token(Token = "0x402FBF1")]
		[FieldOffset(Offset = "0xD0")]
		private UISwitchTween m_enterTween;

		// Token: 0x0402FBF2 RID: 195570
		[Token(Token = "0x402FBF2")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402FBF3 RID: 195571
		[Token(Token = "0x402FBF3")]
		[FieldOffset(Offset = "0xE0")]
		private AnimationSwitchTween m_maskSwitchTween;

		// Token: 0x0402FBF5 RID: 195573
		[Token(Token = "0x402FBF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hotspotGo;

		// Token: 0x0402FBF6 RID: 195574
		[Token(Token = "0x402FBF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onCharSelect;

		// Token: 0x0402FBF7 RID: 195575
		[Token(Token = "0x402FBF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onCharSelect;

		// Token: 0x0402FBF8 RID: 195576
		[Token(Token = "0x402FBF8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_layoutElement;

		// Token: 0x0402FBF9 RID: 195577
		[Token(Token = "0x402FBF9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderGiveUpView;

		// Token: 0x0402FBFA RID: 195578
		[Token(Token = "0x402FBFA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderCharView;

		// Token: 0x0402FBFB RID: 195579
		[Token(Token = "0x402FBFB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FBFC RID: 195580
		[Token(Token = "0x402FBFC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x0402FBFD RID: 195581
		[Token(Token = "0x402FBFD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetEnterAnim;

		// Token: 0x0402FBFE RID: 195582
		[Token(Token = "0x402FBFE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnCharSelect;

		// Token: 0x0402FBFF RID: 195583
		[Token(Token = "0x402FBFF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
