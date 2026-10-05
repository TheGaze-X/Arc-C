using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003529 RID: 13609
	[Token(Token = "0x2003529")]
	public class UICharacterCardPanel : MonoBehaviour, IHotfixable, IAsyncDataView<UICharacterCardPanel.AsyncParams>
	{
		// Token: 0x06015B07 RID: 88839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B07")]
		[Address(RVA = "0xE49180", Offset = "0xE47D80", VA = "0x180E49180", Slot = "4")]
		public void AsyncSetData(UICharacterCardPanel.AsyncParams data)
		{
		}

		// Token: 0x06015B08 RID: 88840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B08")]
		[Address(RVA = "0xE49CB0", Offset = "0xE488B0", VA = "0x180E49CB0", Slot = "5")]
		public virtual void UpdateViewData(CharacterCardViewModel viewModel)
		{
		}

		// Token: 0x06015B09 RID: 88841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B09")]
		[Address(RVA = "0xE492A0", Offset = "0xE47EA0", VA = "0x180E492A0")]
		public void UpdateViewData(CharacterCardViewModel viewModel, UICharacterCardPanel.Options options)
		{
		}

		// Token: 0x17003386 RID: 13190
		// (set) Token: 0x06015B0A RID: 88842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003386")]
		public Action<int> onClick
		{
			[Token(Token = "0x6015B0A")]
			[Address(RVA = "0xE49F10", Offset = "0xE48B10", VA = "0x180E49F10")]
			set
			{
			}
		}

		// Token: 0x06015B0B RID: 88843 RVA: 0x0008D780 File Offset: 0x0008B980
		[Token(Token = "0x6015B0B")]
		[Address(RVA = "0xE49D70", Offset = "0xE48970", VA = "0x180E49D70")]
		private static bool _IsCharBasicChanged(BasicCharInfoModel prevInfo, BasicCharInfoModel curInfo)
		{
			return default(bool);
		}

		// Token: 0x06015B0C RID: 88844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B0C")]
		[Address(RVA = "0xE49210", Offset = "0xE47E10", VA = "0x180E49210")]
		public void OnCardClick()
		{
		}

		// Token: 0x06015B0D RID: 88845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B0D")]
		[Address(RVA = "0xE49E70", Offset = "0xE48A70", VA = "0x180E49E70")]
		public UICharacterCardPanel()
		{
		}

		// Token: 0x0401A0C6 RID: 106694
		[Token(Token = "0x401A0C6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imageChrPortrait;

		// Token: 0x0401A0C7 RID: 106695
		[Token(Token = "0x401A0C7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _iconProfession;

		// Token: 0x0401A0C8 RID: 106696
		[Token(Token = "0x401A0C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSkill;

		// Token: 0x0401A0C9 RID: 106697
		[Token(Token = "0x401A0C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNoSkill;

		// Token: 0x0401A0CA RID: 106698
		[Token(Token = "0x401A0CA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _iconSkill;

		// Token: 0x0401A0CB RID: 106699
		[Token(Token = "0x401A0CB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelPotential;

		// Token: 0x0401A0CC RID: 106700
		[Token(Token = "0x401A0CC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _iconPotential;

		// Token: 0x0401A0CD RID: 106701
		[Token(Token = "0x401A0CD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _iconEvolve;

		// Token: 0x0401A0CE RID: 106702
		[Token(Token = "0x401A0CE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelUniequip;

		// Token: 0x0401A0CF RID: 106703
		[Token(Token = "0x401A0CF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _iconUniequip;

		// Token: 0x0401A0D0 RID: 106704
		[Token(Token = "0x401A0D0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0401A0D1 RID: 106705
		[Token(Token = "0x401A0D1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imageLvlPercent;

		// Token: 0x0401A0D2 RID: 106706
		[Token(Token = "0x401A0D2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textRealName;

		// Token: 0x0401A0D3 RID: 106707
		[Token(Token = "0x401A0D3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imageStarMark;

		// Token: 0x0401A0D4 RID: 106708
		[Token(Token = "0x401A0D4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imgCustomMark;

		// Token: 0x0401A0D5 RID: 106709
		[Token(Token = "0x401A0D5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICharCardRankWidget _panelStars;

		// Token: 0x0401A0D6 RID: 106710
		[Token(Token = "0x401A0D6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UICharRarityImage _panelUpperHub;

		// Token: 0x0401A0D7 RID: 106711
		[Token(Token = "0x401A0D7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UICharRarityImage _panelLowerHub;

		// Token: 0x0401A0D8 RID: 106712
		[Token(Token = "0x401A0D8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UICharRarityImage _panelRarityLight;

		// Token: 0x0401A0D9 RID: 106713
		[Token(Token = "0x401A0D9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UICharRarityImage _panelBkg;

		// Token: 0x0401A0DA RID: 106714
		[Token(Token = "0x401A0DA")]
		[FieldOffset(Offset = "0xB8")]
		private Action<int> m_clickListener;

		// Token: 0x0401A0DB RID: 106715
		[Token(Token = "0x401A0DB")]
		[FieldOffset(Offset = "0xC0")]
		private string m_skillIdCache;

		// Token: 0x0401A0DC RID: 106716
		[Token(Token = "0x401A0DC")]
		[FieldOffset(Offset = "0xC8")]
		private string m_portraitCache;

		// Token: 0x0401A0DD RID: 106717
		[Token(Token = "0x401A0DD")]
		[FieldOffset(Offset = "0xD0")]
		private string m_uniequipCache;

		// Token: 0x0401A0DE RID: 106718
		[Token(Token = "0x401A0DE")]
		[FieldOffset(Offset = "0xD8")]
		private BasicCharInfoModel m_infoCache;

		// Token: 0x0401A0DF RID: 106719
		[Token(Token = "0x401A0DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x0401A0E0 RID: 106720
		[Token(Token = "0x401A0E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateViewData;

		// Token: 0x0401A0E1 RID: 106721
		[Token(Token = "0x401A0E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_UpdateViewData;

		// Token: 0x0401A0E2 RID: 106722
		[Token(Token = "0x401A0E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0401A0E3 RID: 106723
		[Token(Token = "0x401A0E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsCharBasicChanged;

		// Token: 0x0401A0E4 RID: 106724
		[Token(Token = "0x401A0E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x0401A0E5 RID: 106725
		[Token(Token = "0x401A0E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200352A RID: 13610
		[Token(Token = "0x200352A")]
		public struct AsyncParams
		{
			// Token: 0x0401A0E6 RID: 106726
			[Token(Token = "0x401A0E6")]
			[FieldOffset(Offset = "0x0")]
			public CharacterCardViewModel cardModel;
		}

		// Token: 0x0200352B RID: 13611
		[Token(Token = "0x200352B")]
		[Serializable]
		private struct ViewBundle
		{
			// Token: 0x06015B0E RID: 88846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015B0E")]
			[Address(RVA = "0xE5A9A0", Offset = "0xE595A0", VA = "0x180E5A9A0")]
			public void SetActive(bool isActive)
			{
			}

			// Token: 0x0401A0E7 RID: 106727
			[Token(Token = "0x401A0E7")]
			[FieldOffset(Offset = "0x0")]
			public GameObject[] views;
		}

		// Token: 0x0200352C RID: 13612
		[Token(Token = "0x200352C")]
		public struct Options
		{
			// Token: 0x0401A0E8 RID: 106728
			[Token(Token = "0x401A0E8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UICharacterCardPanel.Options DEFAULT;

			// Token: 0x0401A0E9 RID: 106729
			[Token(Token = "0x401A0E9")]
			[FieldOffset(Offset = "0x0")]
			public bool disablePotential;

			// Token: 0x0401A0EA RID: 106730
			[Token(Token = "0x401A0EA")]
			[FieldOffset(Offset = "0x1")]
			public bool disableSkill;

			// Token: 0x0401A0EB RID: 106731
			[Token(Token = "0x401A0EB")]
			[FieldOffset(Offset = "0x8")]
			public Sprite customMarkSprite;
		}
	}
}
