using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032B7 RID: 12983
	[Token(Token = "0x20032B7")]
	public class UICard : MonoBehaviour, IHotfixable
	{
		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x060149FD RID: 84477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030D4")]
		private Animator comboImageUnderAnimator
		{
			[Token(Token = "0x60149FD")]
			[Address(RVA = "0xCEB990", Offset = "0xCEA590", VA = "0x180CEB990")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x060149FE RID: 84478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030D5")]
		private Animator comboImageIconAnimator
		{
			[Token(Token = "0x60149FE")]
			[Address(RVA = "0xCEB8A0", Offset = "0xCEA4A0", VA = "0x180CEB8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x060149FF RID: 84479 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014A00 RID: 84480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030D6")]
		public Deck.Card card
		{
			[Token(Token = "0x60149FF")]
			[Address(RVA = "0xCEB840", Offset = "0xCEA440", VA = "0x180CEB840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6014A00")]
			[Address(RVA = "0xCEBE30", Offset = "0xCEAA30", VA = "0x180CEBE30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06014A01 RID: 84481 RVA: 0x00087CD8 File Offset: 0x00085ED8
		// (set) Token: 0x06014A02 RID: 84482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030D7")]
		public bool isEnabled
		{
			[Token(Token = "0x6014A01")]
			[Address(RVA = "0xCEBBA0", Offset = "0xCEA7A0", VA = "0x180CEBBA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014A02")]
			[Address(RVA = "0xCEC010", Offset = "0xCEAC10", VA = "0x180CEC010")]
			private set
			{
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06014A03 RID: 84483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030D8")]
		public Transform bgRoot
		{
			[Token(Token = "0x6014A03")]
			[Address(RVA = "0xCEB780", Offset = "0xCEA380", VA = "0x180CEB780")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06014A04 RID: 84484 RVA: 0x00087CF0 File Offset: 0x00085EF0
		// (set) Token: 0x06014A05 RID: 84485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030D9")]
		public bool isOn
		{
			[Token(Token = "0x6014A04")]
			[Address(RVA = "0xCEBC00", Offset = "0xCEA800", VA = "0x180CEBC00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014A05")]
			[Address(RVA = "0xCEC090", Offset = "0xCEAC90", VA = "0x180CEC090")]
			set
			{
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06014A06 RID: 84486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030DA")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6014A06")]
			[Address(RVA = "0xCEBCD0", Offset = "0xCEA8D0", VA = "0x180CEBCD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06014A07 RID: 84487 RVA: 0x00087D08 File Offset: 0x00085F08
		// (set) Token: 0x06014A08 RID: 84488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030DB")]
		public int currentPointerId
		{
			[Token(Token = "0x6014A07")]
			[Address(RVA = "0xCEBA80", Offset = "0xCEA680", VA = "0x180CEBA80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6014A08")]
			[Address(RVA = "0xCEBEB0", Offset = "0xCEAAB0", VA = "0x180CEBEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x06014A09 RID: 84489 RVA: 0x00087D20 File Offset: 0x00085F20
		// (set) Token: 0x06014A0A RID: 84490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030DC")]
		private protected int index
		{
			[Token(Token = "0x6014A09")]
			[Address(RVA = "0xCEBB40", Offset = "0xCEA740", VA = "0x180CEBB40")]
			[CompilerGenerated]
			protected get
			{
				return 0;
			}
			[Token(Token = "0x6014A0A")]
			[Address(RVA = "0xCEBFA0", Offset = "0xCEABA0", VA = "0x180CEBFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x06014A0B RID: 84491 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014A0C RID: 84492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030DD")]
		private protected UICardList cardList
		{
			[Token(Token = "0x6014A0B")]
			[Address(RVA = "0xCEB7E0", Offset = "0xCEA3E0", VA = "0x180CEB7E0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6014A0C")]
			[Address(RVA = "0xCEBDB0", Offset = "0xCEA9B0", VA = "0x180CEBDB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x06014A0D RID: 84493 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014A0E RID: 84494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030DE")]
		private protected UICardEffectHolder effectHolder
		{
			[Token(Token = "0x6014A0D")]
			[Address(RVA = "0xCEBAE0", Offset = "0xCEA6E0", VA = "0x180CEBAE0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6014A0E")]
			[Address(RVA = "0xCEBF20", Offset = "0xCEAB20", VA = "0x180CEBF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06014A0F RID: 84495 RVA: 0x00087D38 File Offset: 0x00085F38
		// (set) Token: 0x06014A10 RID: 84496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170030DF")]
		public float localPositionY
		{
			[Token(Token = "0x6014A0F")]
			[Address(RVA = "0xCEBC70", Offset = "0xCEA870", VA = "0x180CEBC70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6014A10")]
			[Address(RVA = "0xCEC120", Offset = "0xCEAD20", VA = "0x180CEC120")]
			set
			{
			}
		}

		// Token: 0x06014A11 RID: 84497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A11")]
		[Address(RVA = "0xCE9C40", Offset = "0xCE8840", VA = "0x180CE9C40")]
		public void SetToggleGroup(bool isEnabled)
		{
		}

		// Token: 0x06014A12 RID: 84498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A12")]
		[Address(RVA = "0xCE9780", Offset = "0xCE8380", VA = "0x180CE9780")]
		public void SetData(Deck.Card card, int index, UICardList cardList, UICardEffectHolder cardEffectHolder)
		{
		}

		// Token: 0x06014A13 RID: 84499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A13")]
		[Address(RVA = "0xCE8AC0", Offset = "0xCE76C0", VA = "0x180CE8AC0")]
		public void RefreshCardAppearanceE(Deck.Card card)
		{
		}

		// Token: 0x06014A14 RID: 84500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A14")]
		[Address(RVA = "0xCE95B0", Offset = "0xCE81B0", VA = "0x180CE95B0")]
		public void RefreshEffect(Deck.Card card)
		{
		}

		// Token: 0x06014A15 RID: 84501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A15")]
		[Address(RVA = "0xCE9B00", Offset = "0xCE8700", VA = "0x180CE9B00")]
		public void SetProfessionIcon(Sprite icon, Color color)
		{
		}

		// Token: 0x06014A16 RID: 84502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A16")]
		[Address(RVA = "0xCE9D80", Offset = "0xCE8980", VA = "0x180CE9D80")]
		public void ShowCardSelectForLegion(bool isSelect)
		{
		}

		// Token: 0x06014A17 RID: 84503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A17")]
		[Address(RVA = "0xCE94A0", Offset = "0xCE80A0", VA = "0x180CE94A0")]
		public void RefreshCost(Deck.Card card)
		{
		}

		// Token: 0x06014A18 RID: 84504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A18")]
		[Address(RVA = "0xCE9680", Offset = "0xCE8280", VA = "0x180CE9680")]
		public void RefreshRespawnTime(Deck.Card card)
		{
		}

		// Token: 0x06014A19 RID: 84505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A19")]
		[Address(RVA = "0xCE7B60", Offset = "0xCE6760", VA = "0x180CE7B60")]
		public void OnDrag(BaseEventData eventData)
		{
		}

		// Token: 0x06014A1A RID: 84506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A1A")]
		[Address(RVA = "0xCE7A50", Offset = "0xCE6650", VA = "0x180CE7A50")]
		public void OnDisable()
		{
		}

		// Token: 0x06014A1B RID: 84507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A1B")]
		[Address(RVA = "0xCE7420", Offset = "0xCE6020", VA = "0x180CE7420")]
		public void OnBeginDrag(BaseEventData eventData)
		{
		}

		// Token: 0x06014A1C RID: 84508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A1C")]
		[Address(RVA = "0xCE7D30", Offset = "0xCE6930", VA = "0x180CE7D30")]
		public void OnEndDrag(BaseEventData eventData)
		{
		}

		// Token: 0x06014A1D RID: 84509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A1D")]
		[Address(RVA = "0xCE7220", Offset = "0xCE5E20", VA = "0x180CE7220")]
		public void KillCardTween(bool complete)
		{
		}

		// Token: 0x06014A1E RID: 84510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A1E")]
		[Address(RVA = "0xCE82B0", Offset = "0xCE6EB0", VA = "0x180CE82B0")]
		public void OnToggled()
		{
		}

		// Token: 0x06014A1F RID: 84511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A1F")]
		[Address(RVA = "0xCE7F30", Offset = "0xCE6B30", VA = "0x180CE7F30")]
		public void OnHover(bool isHover)
		{
		}

		// Token: 0x06014A20 RID: 84512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A20")]
		[Address(RVA = "0xCE76C0", Offset = "0xCE62C0", VA = "0x180CE76C0")]
		public void OnBlink()
		{
		}

		// Token: 0x06014A21 RID: 84513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A21")]
		[Address(RVA = "0xCEA7E0", Offset = "0xCE93E0", VA = "0x180CEA7E0")]
		private void _UpdateComboState()
		{
		}

		// Token: 0x06014A22 RID: 84514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A22")]
		[Address(RVA = "0xCEABD0", Offset = "0xCE97D0", VA = "0x180CEABD0")]
		private void _UpdateMhwrbgState()
		{
		}

		// Token: 0x06014A23 RID: 84515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A23")]
		[Address(RVA = "0xCEA740", Offset = "0xCE9340", VA = "0x180CEA740")]
		private void _SetRarityRank(RarityRank rarity)
		{
		}

		// Token: 0x06014A24 RID: 84516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A24")]
		[Address(RVA = "0xCEA5D0", Offset = "0xCE91D0", VA = "0x180CEA5D0")]
		private void _SetProfession(ProfessionCategory profession)
		{
		}

		// Token: 0x06014A25 RID: 84517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A25")]
		[Address(RVA = "0xCEA480", Offset = "0xCE9080", VA = "0x180CEA480")]
		private void _SetEvolvePhase(EvolvePhase evolvePhase)
		{
		}

		// Token: 0x06014A26 RID: 84518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A26")]
		[Address(RVA = "0xCEA200", Offset = "0xCE8E00", VA = "0x180CEA200")]
		private void _SetEnabled(bool value, bool force)
		{
		}

		// Token: 0x06014A27 RID: 84519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A27")]
		[Address(RVA = "0xCEACE0", Offset = "0xCE98E0", VA = "0x180CEACE0")]
		private void _UpdateStatus(bool force)
		{
		}

		// Token: 0x06014A28 RID: 84520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A28")]
		[Address(RVA = "0xCEA0B0", Offset = "0xCE8CB0", VA = "0x180CEA0B0")]
		private void _RecycleOldPlayingCardAnims()
		{
		}

		// Token: 0x06014A29 RID: 84521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014A29")]
		[Address(RVA = "0xCE6A10", Offset = "0xCE5610", VA = "0x180CE6A10")]
		public MonoBehaviour AttachPlugin(UICard.IUICardPlugin pluginPrefab, out bool isNewPlugin)
		{
			return null;
		}

		// Token: 0x06014A2A RID: 84522 RVA: 0x00087D50 File Offset: 0x00085F50
		[Token(Token = "0x6014A2A")]
		[Address(RVA = "0xCE72E0", Offset = "0xCE5EE0", VA = "0x180CE72E0")]
		public bool OnBeforeCardlistRefresh([TupleElementNames(new string[]
		{
			"cardAnim",
			"animName"
		})] out ValueTuple<GameObject, string> animObject)
		{
			return default(bool);
		}

		// Token: 0x06014A2B RID: 84523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A2B")]
		[Address(RVA = "0xCE6430", Offset = "0xCE5030", VA = "0x180CE6430")]
		public void AttachPluginIfNot(IEnumerable<UICard.IUICardPlugin> pluginPrefabs)
		{
		}

		// Token: 0x06014A2C RID: 84524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A2C")]
		[Address(RVA = "0xCE8940", Offset = "0xCE7540", VA = "0x180CE8940")]
		public void PlayCardAnim(string assetPath, string animName)
		{
		}

		// Token: 0x06014A2D RID: 84525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A2D")]
		[Address(RVA = "0xCE86F0", Offset = "0xCE72F0", VA = "0x180CE86F0")]
		public void PlayCardAnimObject(GameObject animObject, string animName, bool isContinued = false)
		{
		}

		// Token: 0x06014A2E RID: 84526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014A2E")]
		[Address(RVA = "0xCE6EB0", Offset = "0xCE5AB0", VA = "0x180CE6EB0")]
		public UIPluginTalent.UnitTalentUIPlugin AttachTalentPlugin(UIPluginTalent.UnitTalentUIPlugin pluginSource, Unit source, UIPluginTalent pluginTalent)
		{
			return null;
		}

		// Token: 0x06014A2F RID: 84527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A2F")]
		[Address(RVA = "0xCE80C0", Offset = "0xCE6CC0", VA = "0x180CE80C0")]
		public void OnRecycle()
		{
		}

		// Token: 0x06014A30 RID: 84528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A30")]
		[Address(RVA = "0xCE9F30", Offset = "0xCE8B30", VA = "0x180CE9F30")]
		private void Update()
		{
		}

		// Token: 0x06014A31 RID: 84529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A31")]
		[Address(RVA = "0xCE7130", Offset = "0xCE5D30", VA = "0x180CE7130")]
		private void Awake()
		{
		}

		// Token: 0x06014A32 RID: 84530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014A32")]
		[Address(RVA = "0xCE9F90", Offset = "0xCE8B90", VA = "0x180CE9F90")]
		private Transform _GetMountPoint(UICard.UICardMountPoint mountPoint)
		{
			return null;
		}

		// Token: 0x06014A33 RID: 84531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014A33")]
		[Address(RVA = "0xCEB5E0", Offset = "0xCEA1E0", VA = "0x180CEB5E0")]
		public UICard()
		{
		}

		// Token: 0x040186F4 RID: 100084
		[Token(Token = "0x40186F4")]
		private const string REMAINING_CNT_FORMAT = "x{0}";

		// Token: 0x040186F5 RID: 100085
		[Token(Token = "0x40186F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Widgets")]
		private Image _avatarImage;

		// Token: 0x040186F6 RID: 100086
		[Token(Token = "0x40186F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Widgets")]
		private Image _professionIcon;

		// Token: 0x040186F7 RID: 100087
		[Token(Token = "0x40186F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Widgets")]
		private Image _professionMark;

		// Token: 0x040186F8 RID: 100088
		[Token(Token = "0x40186F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Widgets")]
		private Image _rarityMark;

		// Token: 0x040186F9 RID: 100089
		[Token(Token = "0x40186F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Widgets")]
		private Image _eliteIcon;

		// Token: 0x040186FA RID: 100090
		[Token(Token = "0x40186FA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Widgets")]
		private Image _assistCharIcon;

		// Token: 0x040186FB RID: 100091
		[Token(Token = "0x40186FB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Widgets")]
		private Text _costLabel;

		// Token: 0x040186FC RID: 100092
		[Token(Token = "0x40186FC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Widgets")]
		private Image _remainingBackImage;

		// Token: 0x040186FD RID: 100093
		[Token(Token = "0x40186FD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Widgets")]
		private Text _remainingCntLabel;

		// Token: 0x040186FE RID: 100094
		[Token(Token = "0x40186FE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Widgets")]
		private Slider _respawnSlider;

		// Token: 0x040186FF RID: 100095
		[Token(Token = "0x40186FF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Widgets")]
		private Text _respawnLabel;

		// Token: 0x04018700 RID: 100096
		[Token(Token = "0x4018700")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Widgets")]
		private Toggle _toggle;

		// Token: 0x04018701 RID: 100097
		[Token(Token = "0x4018701")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Config")]
		[FormerlySerializedAs("_professionSprites")]
		private UICard.ProfessionData[] _professionData;

		// Token: 0x04018702 RID: 100098
		[Token(Token = "0x4018702")]
		[FieldOffset(Offset = "0x80")]
		[Collection(6)]
		[SerializeField]
		[Group("Config")]
		private Sprite[] _rarityColors;

		// Token: 0x04018703 RID: 100099
		[Token(Token = "0x4018703")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Config")]
		[Collection(4)]
		private Sprite[] _evolveIcons;

		// Token: 0x04018704 RID: 100100
		[Token(Token = "0x4018704")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Tint")]
		private Graphic[] _tintTargets;

		// Token: 0x04018705 RID: 100101
		[Token(Token = "0x4018705")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Tint")]
		private Color _defaultColor;

		// Token: 0x04018706 RID: 100102
		[Token(Token = "0x4018706")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Tint")]
		private Color _disableColor;

		// Token: 0x04018707 RID: 100103
		[Token(Token = "0x4018707")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Tint")]
		private float _toggleDuration;

		// Token: 0x04018708 RID: 100104
		[Token(Token = "0x4018708")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Group("Tint")]
		private float _toggleOffset;

		// Token: 0x04018709 RID: 100105
		[Token(Token = "0x4018709")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Tint")]
		private float _fadeDuration;

		// Token: 0x0401870A RID: 100106
		[Token(Token = "0x401870A")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Group("Blink")]
		private float _blinkDuration;

		// Token: 0x0401870B RID: 100107
		[Token(Token = "0x401870B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[RangeValue(0f, 1f)]
		[Group("Blink")]
		private float _blinkEasePart;

		// Token: 0x0401870C RID: 100108
		[Token(Token = "0x401870C")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[Group("Blink")]
		private Ease _blinkEaseStart;

		// Token: 0x0401870D RID: 100109
		[Token(Token = "0x401870D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Blink")]
		private Ease _blinkEaseEnd;

		// Token: 0x0401870E RID: 100110
		[Token(Token = "0x401870E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Combo")]
		private Image _comboImageUnder;

		// Token: 0x0401870F RID: 100111
		[Token(Token = "0x401870F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Combo")]
		private Image _comboImageIcon;

		// Token: 0x04018710 RID: 100112
		[Token(Token = "0x4018710")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Act24side")]
		private Image _mhImageUnder;

		// Token: 0x04018711 RID: 100113
		[Token(Token = "0x4018711")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Act24side")]
		private Image _mhImageIcon;

		// Token: 0x04018712 RID: 100114
		[Token(Token = "0x4018712")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Transform _pluginRoot;

		// Token: 0x04018713 RID: 100115
		[Token(Token = "0x4018713")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Transform _contentRoot;

		// Token: 0x04018714 RID: 100116
		[Token(Token = "0x4018714")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Transform _bgRoot;

		// Token: 0x04018715 RID: 100117
		[Token(Token = "0x4018715")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Widgets")]
		private UICard.PluginRootConfig[] _mountPluginRoots;

		// Token: 0x04018716 RID: 100118
		[Token(Token = "0x4018716")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isEnabled;

		// Token: 0x04018717 RID: 100119
		[Token(Token = "0x4018717")]
		[FieldOffset(Offset = "0x11C")]
		private Vector3 m_originLocalPosition;

		// Token: 0x04018718 RID: 100120
		[Token(Token = "0x4018718")]
		[FieldOffset(Offset = "0x128")]
		private RectTransform m_rectTransform;

		// Token: 0x04018719 RID: 100121
		[Token(Token = "0x4018719")]
		[FieldOffset(Offset = "0x130")]
		[TupleElementNames(new string[]
		{
			"animObject",
			"animName",
			"cardAnim"
		})]
		[Inspect]
		private ValueTuple<GameObject, string, AnimationWrapper> m_cardAnim;

		// Token: 0x0401871A RID: 100122
		[Token(Token = "0x401871A")]
		[FieldOffset(Offset = "0x148")]
		private CanvasGroup[] m_canvasGroup;

		// Token: 0x0401871B RID: 100123
		[Token(Token = "0x401871B")]
		private const float SELECTED_ALPHA = 0.5f;

		// Token: 0x0401871C RID: 100124
		[Token(Token = "0x401871C")]
		[FieldOffset(Offset = "0x150")]
		private Animator m_comboImageUnderAnimator;

		// Token: 0x0401871D RID: 100125
		[Token(Token = "0x401871D")]
		[FieldOffset(Offset = "0x158")]
		private List<ObjectPtr<UICard.IUICardPlugin>> m_plugin;

		// Token: 0x0401871E RID: 100126
		[Token(Token = "0x401871E")]
		[FieldOffset(Offset = "0x160")]
		private Animator m_comboImageIconAnimator;

		// Token: 0x04018724 RID: 100132
		[Token(Token = "0x4018724")]
		[FieldOffset(Offset = "0x188")]
		private Sequence m_tweenSeq;

		// Token: 0x04018725 RID: 100133
		[Token(Token = "0x4018725")]
		[FieldOffset(Offset = "0x190")]
		private float m_localPositionY;

		// Token: 0x04018726 RID: 100134
		[Token(Token = "0x4018726")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_comboImageUnderAnimator;

		// Token: 0x04018727 RID: 100135
		[Token(Token = "0x4018727")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_comboImageIconAnimator;

		// Token: 0x04018728 RID: 100136
		[Token(Token = "0x4018728")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_card;

		// Token: 0x04018729 RID: 100137
		[Token(Token = "0x4018729")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_card;

		// Token: 0x0401872A RID: 100138
		[Token(Token = "0x401872A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isEnabled;

		// Token: 0x0401872B RID: 100139
		[Token(Token = "0x401872B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isEnabled;

		// Token: 0x0401872C RID: 100140
		[Token(Token = "0x401872C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bgRoot;

		// Token: 0x0401872D RID: 100141
		[Token(Token = "0x401872D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isOn;

		// Token: 0x0401872E RID: 100142
		[Token(Token = "0x401872E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_isOn;

		// Token: 0x0401872F RID: 100143
		[Token(Token = "0x401872F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_rectTransform;

		// Token: 0x04018730 RID: 100144
		[Token(Token = "0x4018730")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_currentPointerId;

		// Token: 0x04018731 RID: 100145
		[Token(Token = "0x4018731")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_currentPointerId;

		// Token: 0x04018732 RID: 100146
		[Token(Token = "0x4018732")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_index;

		// Token: 0x04018733 RID: 100147
		[Token(Token = "0x4018733")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_index;

		// Token: 0x04018734 RID: 100148
		[Token(Token = "0x4018734")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_cardList;

		// Token: 0x04018735 RID: 100149
		[Token(Token = "0x4018735")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_cardList;

		// Token: 0x04018736 RID: 100150
		[Token(Token = "0x4018736")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_effectHolder;

		// Token: 0x04018737 RID: 100151
		[Token(Token = "0x4018737")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_effectHolder;

		// Token: 0x04018738 RID: 100152
		[Token(Token = "0x4018738")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_localPositionY;

		// Token: 0x04018739 RID: 100153
		[Token(Token = "0x4018739")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_localPositionY;

		// Token: 0x0401873A RID: 100154
		[Token(Token = "0x401873A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetToggleGroup;

		// Token: 0x0401873B RID: 100155
		[Token(Token = "0x401873B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401873C RID: 100156
		[Token(Token = "0x401873C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshCardAppearanceE;

		// Token: 0x0401873D RID: 100157
		[Token(Token = "0x401873D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RefreshEffect;

		// Token: 0x0401873E RID: 100158
		[Token(Token = "0x401873E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SetProfessionIcon;

		// Token: 0x0401873F RID: 100159
		[Token(Token = "0x401873F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ShowCardSelectForLegion;

		// Token: 0x04018740 RID: 100160
		[Token(Token = "0x4018740")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_RefreshCost;

		// Token: 0x04018741 RID: 100161
		[Token(Token = "0x4018741")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RefreshRespawnTime;

		// Token: 0x04018742 RID: 100162
		[Token(Token = "0x4018742")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x04018743 RID: 100163
		[Token(Token = "0x4018743")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04018744 RID: 100164
		[Token(Token = "0x4018744")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x04018745 RID: 100165
		[Token(Token = "0x4018745")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x04018746 RID: 100166
		[Token(Token = "0x4018746")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_KillCardTween;

		// Token: 0x04018747 RID: 100167
		[Token(Token = "0x4018747")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnToggled;

		// Token: 0x04018748 RID: 100168
		[Token(Token = "0x4018748")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnHover;

		// Token: 0x04018749 RID: 100169
		[Token(Token = "0x4018749")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnBlink;

		// Token: 0x0401874A RID: 100170
		[Token(Token = "0x401874A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__UpdateComboState;

		// Token: 0x0401874B RID: 100171
		[Token(Token = "0x401874B")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__UpdateMhwrbgState;

		// Token: 0x0401874C RID: 100172
		[Token(Token = "0x401874C")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__SetRarityRank;

		// Token: 0x0401874D RID: 100173
		[Token(Token = "0x401874D")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__SetProfession;

		// Token: 0x0401874E RID: 100174
		[Token(Token = "0x401874E")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SetEvolvePhase;

		// Token: 0x0401874F RID: 100175
		[Token(Token = "0x401874F")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__SetEnabled;

		// Token: 0x04018750 RID: 100176
		[Token(Token = "0x4018750")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__UpdateStatus;

		// Token: 0x04018751 RID: 100177
		[Token(Token = "0x4018751")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__RecycleOldPlayingCardAnims;

		// Token: 0x04018752 RID: 100178
		[Token(Token = "0x4018752")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_AttachPlugin;

		// Token: 0x04018753 RID: 100179
		[Token(Token = "0x4018753")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OnBeforeCardlistRefresh;

		// Token: 0x04018754 RID: 100180
		[Token(Token = "0x4018754")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_AttachPluginIfNot;

		// Token: 0x04018755 RID: 100181
		[Token(Token = "0x4018755")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_PlayCardAnim;

		// Token: 0x04018756 RID: 100182
		[Token(Token = "0x4018756")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_PlayCardAnimObject;

		// Token: 0x04018757 RID: 100183
		[Token(Token = "0x4018757")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_AttachTalentPlugin;

		// Token: 0x04018758 RID: 100184
		[Token(Token = "0x4018758")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04018759 RID: 100185
		[Token(Token = "0x4018759")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401875A RID: 100186
		[Token(Token = "0x401875A")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401875B RID: 100187
		[Token(Token = "0x401875B")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__GetMountPoint;

		// Token: 0x0401875C RID: 100188
		[Token(Token = "0x401875C")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020032B8 RID: 12984
		[Token(Token = "0x20032B8")]
		public enum UICardMountPoint
		{
			// Token: 0x0401875E RID: 100190
			[Token(Token = "0x401875E")]
			DEFAULT_PLUGIN_ROOT,
			// Token: 0x0401875F RID: 100191
			[Token(Token = "0x401875F")]
			IMAGE_UNDERFRAME,
			// Token: 0x04018760 RID: 100192
			[Token(Token = "0x4018760")]
			CONTENT_ROOT
		}

		// Token: 0x020032B9 RID: 12985
		[Token(Token = "0x20032B9")]
		[Serializable]
		public class PluginRootConfig
		{
			// Token: 0x06014A34 RID: 84532 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A34")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PluginRootConfig()
			{
			}

			// Token: 0x04018761 RID: 100193
			[Token(Token = "0x4018761")]
			[FieldOffset(Offset = "0x10")]
			public Transform rootTransform;

			// Token: 0x04018762 RID: 100194
			[Token(Token = "0x4018762")]
			[FieldOffset(Offset = "0x18")]
			public UICard.UICardMountPoint mountPoint;
		}

		// Token: 0x020032BA RID: 12986
		[Token(Token = "0x20032BA")]
		public interface IUICardPlugin : IReusableObject, IReusable, IPtrObject
		{
			// Token: 0x170030E0 RID: 12512
			// (get) Token: 0x06014A35 RID: 84533
			[Token(Token = "0x170030E0")]
			string pluginId { [Token(Token = "0x6014A35")] get; }

			// Token: 0x170030E1 RID: 12513
			// (get) Token: 0x06014A36 RID: 84534 RVA: 0x00087D68 File Offset: 0x00085F68
			[Token(Token = "0x170030E1")]
			uint sourcInstId
			{
				[Token(Token = "0x6014A36")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "1")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x170030E2 RID: 12514
			// (get) Token: 0x06014A37 RID: 84535 RVA: 0x00087D80 File Offset: 0x00085F80
			[Token(Token = "0x170030E2")]
			UICard.UICardMountPoint mountPoint
			{
				[Token(Token = "0x6014A37")]
				[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "2")]
				get
				{
					return UICard.UICardMountPoint.DEFAULT_PLUGIN_ROOT;
				}
			}

			// Token: 0x06014A38 RID: 84536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A38")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "3")]
			void OnAppearanceRefresh(UICard card)
			{
			}

			// Token: 0x06014A39 RID: 84537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A39")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
			void OnRender(UICard card)
			{
			}

			// Token: 0x06014A3A RID: 84538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A3A")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			void OnInit(UICard uiCard)
			{
			}

			// Token: 0x06014A3B RID: 84539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014A3B")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			void OnBlink(UICard card)
			{
			}

			// Token: 0x06014A3C RID: 84540
			[Token(Token = "0x6014A3C")]
			MonoBehaviour GetRootMono();

			// Token: 0x06014A3D RID: 84541 RVA: 0x00087D98 File Offset: 0x00085F98
			[Token(Token = "0x6014A3D")]
			[Address(RVA = "0xCE0600", Offset = "0xCDF200", VA = "0x180CE0600", Slot = "8")]
			bool IsTheSamePlugin(UICard.IUICardPlugin other)
			{
				return default(bool);
			}
		}

		// Token: 0x020032BB RID: 12987
		[Token(Token = "0x20032BB")]
		[Serializable]
		public struct ProfessionData
		{
			// Token: 0x06014A3E RID: 84542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6014A3E")]
			[Address(RVA = "0xCE0720", Offset = "0xCDF320", VA = "0x180CE0720", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04018763 RID: 100195
			[Token(Token = "0x4018763")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory profession;

			// Token: 0x04018764 RID: 100196
			[Token(Token = "0x4018764")]
			[FieldOffset(Offset = "0x8")]
			public Sprite sprite;

			// Token: 0x04018765 RID: 100197
			[Token(Token = "0x4018765")]
			[FieldOffset(Offset = "0x10")]
			public Color color;
		}
	}
}
