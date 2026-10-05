using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x02003302 RID: 13058
	[Token(Token = "0x2003302")]
	[RequireComponent(typeof(CanvasGroup))]
	public class UIBattleSystemMenuPanel : MonoBehaviour
	{
		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x06014BCE RID: 84942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003119")]
		protected UIBattleSystemMenuPanel.StyleController currentStyle
		{
			[Token(Token = "0x6014BCE")]
			[Address(RVA = "0xD23150", Offset = "0xD21D50", VA = "0x180D23150")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014BCF RID: 84943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BCF")]
		[Address(RVA = "0xD226C0", Offset = "0xD212C0", VA = "0x180D226C0")]
		public void Show()
		{
		}

		// Token: 0x06014BD0 RID: 84944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BD0")]
		[Address(RVA = "0xD224E0", Offset = "0xD210E0", VA = "0x180D224E0")]
		public void Hide()
		{
		}

		// Token: 0x06014BD1 RID: 84945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BD1")]
		[Address(RVA = "0xD224E0", Offset = "0xD210E0", VA = "0x180D224E0")]
		public void OnInit()
		{
		}

		// Token: 0x06014BD2 RID: 84946 RVA: 0x000882C0 File Offset: 0x000864C0
		[Token(Token = "0x6014BD2")]
		[Address(RVA = "0xD22440", Offset = "0xD21040", VA = "0x180D22440")]
		public UIBattleSystemMenuPanel.BattleReward GetEstimatedReward()
		{
			return default(UIBattleSystemMenuPanel.BattleReward);
		}

		// Token: 0x06014BD3 RID: 84947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BD3")]
		[Address(RVA = "0xD225B0", Offset = "0xD211B0", VA = "0x180D225B0")]
		protected void SetData()
		{
		}

		// Token: 0x06014BD4 RID: 84948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BD4")]
		[Address(RVA = "0xD22E90", Offset = "0xD21A90", VA = "0x180D22E90")]
		private void _InitStyleIfNot()
		{
		}

		// Token: 0x06014BD5 RID: 84949 RVA: 0x000882D8 File Offset: 0x000864D8
		[Token(Token = "0x6014BD5")]
		[Address(RVA = "0xD22860", Offset = "0xD21460", VA = "0x180D22860")]
		private UIBattleSystemMenuPanel.BattleReward _GetEstimatedReward(float progress)
		{
			return default(UIBattleSystemMenuPanel.BattleReward);
		}

		// Token: 0x06014BD6 RID: 84950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BD6")]
		[Address(RVA = "0xD223F0", Offset = "0xD20FF0", VA = "0x180D223F0")]
		private void Awake()
		{
		}

		// Token: 0x06014BD7 RID: 84951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BD7")]
		[Address(RVA = "0xD23140", Offset = "0xD21D40", VA = "0x180D23140")]
		public UIBattleSystemMenuPanel()
		{
		}

		// Token: 0x04018A7E RID: 100990
		[Token(Token = "0x4018A7E")]
		private const string REWARD_STR_FORMAT = "+{0}";

		// Token: 0x04018A7F RID: 100991
		[Token(Token = "0x4018A7F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _fadeInTime;

		// Token: 0x04018A80 RID: 100992
		[Token(Token = "0x4018A80")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Collection(typeof(BattleSysMenuStyle))]
		private UIBattleSystemMenuPanel.StyleController[] _menuStyles;

		// Token: 0x04018A81 RID: 100993
		[Token(Token = "0x4018A81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _debugPanel;

		// Token: 0x04018A82 RID: 100994
		[Token(Token = "0x4018A82")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isStyleInited;

		// Token: 0x04018A83 RID: 100995
		[Token(Token = "0x4018A83")]
		[FieldOffset(Offset = "0x38")]
		private UIBattleSystemMenuPanel.StyleController m_currentStyle;

		// Token: 0x04018A84 RID: 100996
		[Token(Token = "0x4018A84")]
		[FieldOffset(Offset = "0x40")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x02003303 RID: 13059
		[Token(Token = "0x2003303")]
		public struct BattleReward
		{
			// Token: 0x1700311A RID: 12570
			// (get) Token: 0x06014BD8 RID: 84952 RVA: 0x000882F0 File Offset: 0x000864F0
			[Token(Token = "0x1700311A")]
			public bool hasGoldOrExpReward
			{
				[Token(Token = "0x6014BD8")]
				[Address(RVA = "0xD18980", Offset = "0xD17580", VA = "0x180D18980")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06014BD9 RID: 84953 RVA: 0x00088308 File Offset: 0x00086508
			[Token(Token = "0x6014BD9")]
			[Address(RVA = "0xD18420", Offset = "0xD17020", VA = "0x180D18420")]
			public int GetRealApCostIfFailed()
			{
				return 0;
			}

			// Token: 0x06014BDA RID: 84954 RVA: 0x00088320 File Offset: 0x00086520
			[Token(Token = "0x6014BDA")]
			[Address(RVA = "0xD18710", Offset = "0xD17310", VA = "0x180D18710")]
			public int GetRealEtCostIfFailed()
			{
				return 0;
			}

			// Token: 0x04018A85 RID: 100997
			[Token(Token = "0x4018A85")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIBattleSystemMenuPanel.BattleReward ZERO;

			// Token: 0x04018A86 RID: 100998
			[Token(Token = "0x4018A86")]
			[FieldOffset(Offset = "0x0")]
			public int gold;

			// Token: 0x04018A87 RID: 100999
			[Token(Token = "0x4018A87")]
			[FieldOffset(Offset = "0x4")]
			public int exp;

			// Token: 0x04018A88 RID: 101000
			[Token(Token = "0x4018A88")]
			[FieldOffset(Offset = "0x8")]
			public int apFailReturn;

			// Token: 0x04018A89 RID: 101001
			[Token(Token = "0x4018A89")]
			[FieldOffset(Offset = "0xC")]
			public int etFailReturn;
		}

		// Token: 0x02003304 RID: 13060
		[Token(Token = "0x2003304")]
		public abstract class StyleController : MonoBehaviour
		{
			// Token: 0x06014BDC RID: 84956
			[Token(Token = "0x6014BDC")]
			public abstract void SetData(float progress, ref UIBattleSystemMenuPanel.BattleReward reward);

			// Token: 0x06014BDD RID: 84957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014BDD")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public virtual void Hide()
			{
			}

			// Token: 0x06014BDE RID: 84958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014BDE")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			protected StyleController()
			{
			}
		}
	}
}
