using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F2C RID: 20268
	[Token(Token = "0x2004F2C")]
	public class EnemyHandBookDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E318 RID: 123672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E318")]
		[Address(RVA = "0x17E8180", Offset = "0x17E6D80", VA = "0x1817E8180")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E319 RID: 123673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E319")]
		[Address(RVA = "0x17E7570", Offset = "0x17E6170", VA = "0x1817E7570")]
		public void Init(EnemyHandBookEverViewModel viewModel)
		{
		}

		// Token: 0x0601E31A RID: 123674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E31A")]
		[Address(RVA = "0x17E83A0", Offset = "0x17E6FA0", VA = "0x1817E83A0")]
		public EnemyHandBookDetailView()
		{
		}

		// Token: 0x0402838F RID: 164751
		[Token(Token = "0x402838F")]
		public const string WARNING_COLOR_PARAM = "C51717";

		// Token: 0x04028390 RID: 164752
		[Token(Token = "0x4028390")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _enemyImage;

		// Token: 0x04028391 RID: 164753
		[Token(Token = "0x4028391")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bossImage;

		// Token: 0x04028392 RID: 164754
		[Token(Token = "0x4028392")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _eliteImage;

		// Token: 0x04028393 RID: 164755
		[Token(Token = "0x4028393")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _enemyName;

		// Token: 0x04028394 RID: 164756
		[Token(Token = "0x4028394")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _enemyRace;

		// Token: 0x04028395 RID: 164757
		[Token(Token = "0x4028395")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _enemyDescrption;

		// Token: 0x04028396 RID: 164758
		[Token(Token = "0x4028396")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _enemyIndex;

		// Token: 0x04028397 RID: 164759
		[Token(Token = "0x4028397")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _hp;

		// Token: 0x04028398 RID: 164760
		[Token(Token = "0x4028398")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _attack;

		// Token: 0x04028399 RID: 164761
		[Token(Token = "0x4028399")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _defence;

		// Token: 0x0402839A RID: 164762
		[Token(Token = "0x402839A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _magDef;

		// Token: 0x0402839B RID: 164763
		[Token(Token = "0x402839B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _atkSpeed;

		// Token: 0x0402839C RID: 164764
		[Token(Token = "0x402839C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _moveSpeed;

		// Token: 0x0402839D RID: 164765
		[Token(Token = "0x402839D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _weightRate;

		// Token: 0x0402839E RID: 164766
		[Token(Token = "0x402839E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _atkType;

		// Token: 0x0402839F RID: 164767
		[Token(Token = "0x402839F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _enemyDamageRes;

		// Token: 0x040283A0 RID: 164768
		[Token(Token = "0x40283A0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _enemyRes;

		// Token: 0x040283A1 RID: 164769
		[Token(Token = "0x40283A1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _frozenImmune;

		// Token: 0x040283A2 RID: 164770
		[Token(Token = "0x40283A2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _levitateImmune;

		// Token: 0x040283A3 RID: 164771
		[Token(Token = "0x40283A3")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _sleepImmune;

		// Token: 0x040283A4 RID: 164772
		[Token(Token = "0x40283A4")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _stunImmune;

		// Token: 0x040283A5 RID: 164773
		[Token(Token = "0x40283A5")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _disarmImmune;

		// Token: 0x040283A6 RID: 164774
		[Token(Token = "0x40283A6")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _fearedImmune;

		// Token: 0x040283A7 RID: 164775
		[Token(Token = "0x40283A7")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _palsyImmune;

		// Token: 0x040283A8 RID: 164776
		[Token(Token = "0x40283A8")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _attractImmune;

		// Token: 0x040283A9 RID: 164777
		[Token(Token = "0x40283A9")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private SimpleLayoutContent _detailTextGroup;

		// Token: 0x040283AA RID: 164778
		[Token(Token = "0x40283AA")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _abilityTitlePart;

		// Token: 0x040283AB RID: 164779
		[Token(Token = "0x40283AB")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _immunePart;

		// Token: 0x040283AC RID: 164780
		[Token(Token = "0x40283AC")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _spPart;

		// Token: 0x040283AD RID: 164781
		[Token(Token = "0x40283AD")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private SimpleLayoutContent _linkContent;

		// Token: 0x040283AE RID: 164782
		[Token(Token = "0x40283AE")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIStringEvent _linkClick;

		// Token: 0x040283AF RID: 164783
		[Token(Token = "0x40283AF")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _moreCountPart;

		// Token: 0x040283B0 RID: 164784
		[Token(Token = "0x40283B0")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _moreCountIcon;

		// Token: 0x040283B1 RID: 164785
		[Token(Token = "0x40283B1")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject _noCountIcon;

		// Token: 0x040283B2 RID: 164786
		[Token(Token = "0x40283B2")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Text _moreCountText;

		// Token: 0x040283B3 RID: 164787
		[Token(Token = "0x40283B3")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040283B4 RID: 164788
		[Token(Token = "0x40283B4")]
		[FieldOffset(Offset = "0x138")]
		private EnemyHandBookDetailView.Adapter m_adapter;

		// Token: 0x040283B5 RID: 164789
		[Token(Token = "0x40283B5")]
		[FieldOffset(Offset = "0x140")]
		private EnemyHandbookLinkEnemyAdapter m_linkAdapter;

		// Token: 0x040283B6 RID: 164790
		[Token(Token = "0x40283B6")]
		[FieldOffset(Offset = "0x148")]
		private bool m_isInited;

		// Token: 0x040283B7 RID: 164791
		[Token(Token = "0x40283B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040283B8 RID: 164792
		[Token(Token = "0x40283B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040283B9 RID: 164793
		[Token(Token = "0x40283B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F2D RID: 20269
		[Token(Token = "0x2004F2D")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170046C8 RID: 18120
			// (get) Token: 0x0601E31B RID: 123675 RVA: 0x000ADCA0 File Offset: 0x000ABEA0
			[Token(Token = "0x170046C8")]
			public override int count
			{
				[Token(Token = "0x601E31B")]
				[Address(RVA = "0x17E0770", Offset = "0x17DF370", VA = "0x1817E0770", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E31C RID: 123676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E31C")]
			[Address(RVA = "0x17DFEB0", Offset = "0x17DEAB0", VA = "0x1817DFEB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601E31D RID: 123677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E31D")]
			[Address(RVA = "0x17E05A0", Offset = "0x17DF1A0", VA = "0x1817E05A0")]
			public Adapter()
			{
			}

			// Token: 0x040283BA RID: 164794
			[Token(Token = "0x40283BA")]
			[FieldOffset(Offset = "0x20")]
			public List<EnemyHandBookData.Abilty> abilties;

			// Token: 0x040283BB RID: 164795
			[Token(Token = "0x40283BB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040283BC RID: 164796
			[Token(Token = "0x40283BC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040283BD RID: 164797
			[Token(Token = "0x40283BD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
