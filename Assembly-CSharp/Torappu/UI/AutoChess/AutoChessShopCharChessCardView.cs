using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006349 RID: 25417
	[Token(Token = "0x2006349")]
	public class AutoChessShopCharChessCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005696 RID: 22166
		// (get) Token: 0x06024AB9 RID: 150201 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024ABA RID: 150202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005696")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x6024AB9")]
			[Address(RVA = "0x1F82430", Offset = "0x1F81030", VA = "0x181F82430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024ABA")]
			[Address(RVA = "0x1F82510", Offset = "0x1F81110", VA = "0x181F82510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005697 RID: 22167
		// (get) Token: 0x06024ABB RID: 150203 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024ABC RID: 150204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005697")]
		public Action<string> onCancelDiyBtnClick
		{
			[Token(Token = "0x6024ABB")]
			[Address(RVA = "0x1F823D0", Offset = "0x1F80FD0", VA = "0x181F823D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024ABC")]
			[Address(RVA = "0x1F82490", Offset = "0x1F81090", VA = "0x181F82490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005698 RID: 22168
		// (get) Token: 0x06024ABD RID: 150205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005698")]
		public GameObject objClickPart
		{
			[Token(Token = "0x6024ABD")]
			[Address(RVA = "0x1F82370", Offset = "0x1F80F70", VA = "0x181F82370")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024ABE RID: 150206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ABE")]
		[Address(RVA = "0x1F81380", Offset = "0x1F7FF80", VA = "0x181F81380")]
		public void Render(AutoChessShopCharChessCardViewModel viewModel)
		{
		}

		// Token: 0x06024ABF RID: 150207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024ABF")]
		[Address(RVA = "0x1F816D0", Offset = "0x1F802D0", VA = "0x181F816D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024AC0 RID: 150208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AC0")]
		[Address(RVA = "0x1F82100", Offset = "0x1F80D00", VA = "0x181F82100")]
		private void _RenderChessTags(AutoChessShopCharChessCardViewModel viewModel)
		{
		}

		// Token: 0x06024AC1 RID: 150209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AC1")]
		[Address(RVA = "0x1F81FF0", Offset = "0x1F80BF0", VA = "0x181F81FF0")]
		private void _RenderChessLevel(int level)
		{
		}

		// Token: 0x06024AC2 RID: 150210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AC2")]
		[Address(RVA = "0x1F82240", Offset = "0x1F80E40", VA = "0x181F82240")]
		private void _SetSelectType(int chessLevel)
		{
		}

		// Token: 0x06024AC3 RID: 150211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AC3")]
		[Address(RVA = "0x1F818F0", Offset = "0x1F804F0", VA = "0x181F818F0")]
		private void _RenderCharCardInfo(AutoChessShopCharChessCardViewModel charChessCardViewModel)
		{
		}

		// Token: 0x06024AC4 RID: 150212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AC4")]
		[Address(RVA = "0x1F81150", Offset = "0x1F7FD50", VA = "0x181F81150")]
		public void OnCardClick()
		{
		}

		// Token: 0x06024AC5 RID: 150213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AC5")]
		[Address(RVA = "0x1F81260", Offset = "0x1F7FE60", VA = "0x181F81260")]
		public void OnDiyCancelClick()
		{
		}

		// Token: 0x06024AC6 RID: 150214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AC6")]
		[Address(RVA = "0x1F822E0", Offset = "0x1F80EE0", VA = "0x181F822E0")]
		public AutoChessShopCharChessCardView()
		{
		}

		// Token: 0x040332B1 RID: 209585
		[Token(Token = "0x40332B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objBgNormal;

		// Token: 0x040332B2 RID: 209586
		[Token(Token = "0x40332B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objBgMax;

		// Token: 0x040332B3 RID: 209587
		[Token(Token = "0x40332B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objCharLevelBgEmpty;

		// Token: 0x040332B4 RID: 209588
		[Token(Token = "0x40332B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objCharLevelBgNormal;

		// Token: 0x040332B5 RID: 209589
		[Token(Token = "0x40332B5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objCharLevelBgMax;

		// Token: 0x040332B6 RID: 209590
		[Token(Token = "0x40332B6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Chess Info")]
		private Image _imgChessLevel;

		// Token: 0x040332B7 RID: 209591
		[Token(Token = "0x40332B7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objTagAssist;

		// Token: 0x040332B8 RID: 209592
		[Token(Token = "0x40332B8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objTagBackup;

		// Token: 0x040332B9 RID: 209593
		[Token(Token = "0x40332B9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objTagPreset;

		// Token: 0x040332BA RID: 209594
		[Token(Token = "0x40332BA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Chess Info")]
		private CanvasGroup _canvasDiyCancelBtn;

		// Token: 0x040332BB RID: 209595
		[Token(Token = "0x40332BB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Chess Info")]
		private GameObject _objClickArea;

		// Token: 0x040332BC RID: 209596
		[Token(Token = "0x40332BC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Chess Info/Select")]
		private CanvasGroup _canvasSelect;

		// Token: 0x040332BD RID: 209597
		[Token(Token = "0x40332BD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Chess Info/Select")]
		private GameObject _normalSelect;

		// Token: 0x040332BE RID: 209598
		[Token(Token = "0x40332BE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Chess Info/Select")]
		private GameObject _level5Select;

		// Token: 0x040332BF RID: 209599
		[Token(Token = "0x40332BF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Chess Info/Select")]
		private GameObject _level6Select;

		// Token: 0x040332C0 RID: 209600
		[Token(Token = "0x40332C0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Char Part Right")]
		private UIAtlasImage _imgPortrait;

		// Token: 0x040332C1 RID: 209601
		[Token(Token = "0x40332C1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Char Part Right")]
		private Image _imgProfession;

		// Token: 0x040332C2 RID: 209602
		[Token(Token = "0x40332C2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Char Part Right")]
		private Image _imgRarity;

		// Token: 0x040332C3 RID: 209603
		[Token(Token = "0x40332C3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Char Part Right")]
		private Text _txtCharName;

		// Token: 0x040332C4 RID: 209604
		[Token(Token = "0x40332C4")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Char Part Right")]
		private SimpleLayoutContent _bondContent;

		// Token: 0x040332C5 RID: 209605
		[Token(Token = "0x40332C5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Char Skill")]
		private GameObject _panelSkill;

		// Token: 0x040332C6 RID: 209606
		[Token(Token = "0x40332C6")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Char Skill")]
		private Image _imgSkill;

		// Token: 0x040332C7 RID: 209607
		[Token(Token = "0x40332C7")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Char Skill")]
		private GameObject _panelNoSkill;

		// Token: 0x040332C8 RID: 209608
		[Token(Token = "0x40332C8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Char Equip")]
		private GameObject _panelEquip;

		// Token: 0x040332C9 RID: 209609
		[Token(Token = "0x40332C9")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Char Equip")]
		private GameObject _panelEquipEmpty;

		// Token: 0x040332CA RID: 209610
		[Token(Token = "0x40332CA")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Char Equip")]
		private Image _imgEquip;

		// Token: 0x040332CB RID: 209611
		[Token(Token = "0x40332CB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Char Part Left")]
		private Image _imgEvolveNormal;

		// Token: 0x040332CC RID: 209612
		[Token(Token = "0x40332CC")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Char Part Left")]
		private Image _imgEvolveGolden;

		// Token: 0x040332CD RID: 209613
		[Token(Token = "0x40332CD")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Char Part Left")]
		private Text _txtLvNormal;

		// Token: 0x040332CE RID: 209614
		[Token(Token = "0x40332CE")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Char Part Left")]
		private Text _txtLvGolden;

		// Token: 0x040332CF RID: 209615
		[Token(Token = "0x40332CF")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Char Part Left")]
		private Image _imgPotential;

		// Token: 0x040332D0 RID: 209616
		[Token(Token = "0x40332D0")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Char Part Left")]
		private GameObject _panelPotential;

		// Token: 0x040332D1 RID: 209617
		[Token(Token = "0x40332D1")]
		[FieldOffset(Offset = "0x118")]
		private bool m_hasInited;

		// Token: 0x040332D2 RID: 209618
		[Token(Token = "0x40332D2")]
		[FieldOffset(Offset = "0x120")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040332D3 RID: 209619
		[Token(Token = "0x40332D3")]
		[FieldOffset(Offset = "0x130")]
		private ILoadAsset m_loader;

		// Token: 0x040332D4 RID: 209620
		[Token(Token = "0x40332D4")]
		[FieldOffset(Offset = "0x138")]
		private AutoChessShopCharChessCardView.BondAdapter m_bondAdapter;

		// Token: 0x040332D5 RID: 209621
		[Token(Token = "0x40332D5")]
		[FieldOffset(Offset = "0x140")]
		private string m_cachedChessId;

		// Token: 0x040332D6 RID: 209622
		[Token(Token = "0x40332D6")]
		[FieldOffset(Offset = "0x148")]
		private FadeSwitchTween m_selectSwitchTween;

		// Token: 0x040332D7 RID: 209623
		[Token(Token = "0x40332D7")]
		[FieldOffset(Offset = "0x150")]
		private FadeSwitchTween m_cancelDiySwitchTween;

		// Token: 0x040332DA RID: 209626
		[Token(Token = "0x40332DA")]
		private const int CHESS_LEVEL_5 = 5;

		// Token: 0x040332DB RID: 209627
		[Token(Token = "0x40332DB")]
		private const int CHESS_LEVEL_6 = 6;

		// Token: 0x040332DC RID: 209628
		[Token(Token = "0x40332DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x040332DD RID: 209629
		[Token(Token = "0x40332DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x040332DE RID: 209630
		[Token(Token = "0x40332DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCancelDiyBtnClick;

		// Token: 0x040332DF RID: 209631
		[Token(Token = "0x40332DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCancelDiyBtnClick;

		// Token: 0x040332E0 RID: 209632
		[Token(Token = "0x40332E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_objClickPart;

		// Token: 0x040332E1 RID: 209633
		[Token(Token = "0x40332E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040332E2 RID: 209634
		[Token(Token = "0x40332E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040332E3 RID: 209635
		[Token(Token = "0x40332E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderChessTags;

		// Token: 0x040332E4 RID: 209636
		[Token(Token = "0x40332E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderChessLevel;

		// Token: 0x040332E5 RID: 209637
		[Token(Token = "0x40332E5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetSelectType;

		// Token: 0x040332E6 RID: 209638
		[Token(Token = "0x40332E6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderCharCardInfo;

		// Token: 0x040332E7 RID: 209639
		[Token(Token = "0x40332E7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x040332E8 RID: 209640
		[Token(Token = "0x40332E8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDiyCancelClick;

		// Token: 0x040332E9 RID: 209641
		[Token(Token = "0x40332E9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200634A RID: 25418
		[Token(Token = "0x200634A")]
		private class BondAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005699 RID: 22169
			// (get) Token: 0x06024AC7 RID: 150215 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06024AC8 RID: 150216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005699")]
			public IList<AutoChessShopCharChessBondModel> dataSource
			{
				[Token(Token = "0x6024AC7")]
				[Address(RVA = "0x1F92C40", Offset = "0x1F91840", VA = "0x181F92C40")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6024AC8")]
				[Address(RVA = "0x1F92CA0", Offset = "0x1F918A0", VA = "0x181F92CA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700569A RID: 22170
			// (get) Token: 0x06024AC9 RID: 150217 RVA: 0x000C5310 File Offset: 0x000C3510
			[Token(Token = "0x1700569A")]
			public override int count
			{
				[Token(Token = "0x6024AC9")]
				[Address(RVA = "0x1F92B80", Offset = "0x1F91780", VA = "0x181F92B80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024ACA RID: 150218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024ACA")]
			[Address(RVA = "0x1F92B00", Offset = "0x1F91700", VA = "0x181F92B00")]
			public BondAdapter(ILoadAsset loader)
			{
			}

			// Token: 0x06024ACB RID: 150219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024ACB")]
			[Address(RVA = "0x1F92760", Offset = "0x1F91360", VA = "0x181F92760", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040332EA RID: 209642
			[Token(Token = "0x40332EA")]
			[FieldOffset(Offset = "0x20")]
			private ILoadAsset m_loader;

			// Token: 0x040332EC RID: 209644
			[Token(Token = "0x40332EC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSource;

			// Token: 0x040332ED RID: 209645
			[Token(Token = "0x40332ED")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSource;

			// Token: 0x040332EE RID: 209646
			[Token(Token = "0x40332EE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040332EF RID: 209647
			[Token(Token = "0x40332EF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040332F0 RID: 209648
			[Token(Token = "0x40332F0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
