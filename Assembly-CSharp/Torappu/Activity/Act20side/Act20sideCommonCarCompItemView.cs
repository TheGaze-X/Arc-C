using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007683 RID: 30339
	[Token(Token = "0x2007683")]
	public class Act20sideCommonCarCompItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006443 RID: 25667
		// (get) Token: 0x0602AACB RID: 174795 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AACC RID: 174796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006443")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x602AACB")]
			[Address(RVA = "0x2673330", Offset = "0x2671F30", VA = "0x182673330")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602AACC")]
			[Address(RVA = "0x2673390", Offset = "0x2671F90", VA = "0x182673390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602AACD RID: 174797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AACD")]
		[Address(RVA = "0x2673200", Offset = "0x2671E00", VA = "0x182673200")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AACE RID: 174798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AACE")]
		[Address(RVA = "0x2672EF0", Offset = "0x2671AF0", VA = "0x182672EF0")]
		public void Render(Act20sideCollectionItemViewModel model, string selectItemId)
		{
		}

		// Token: 0x0602AACF RID: 174799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AACF")]
		[Address(RVA = "0x2672DE0", Offset = "0x26719E0", VA = "0x182672DE0")]
		public void OnItemClick()
		{
		}

		// Token: 0x0602AAD0 RID: 174800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAD0")]
		[Address(RVA = "0x2673290", Offset = "0x2671E90", VA = "0x182673290")]
		public Act20sideCommonCarCompItemView()
		{
		}

		// Token: 0x0403D793 RID: 251795
		[Token(Token = "0x403D793")]
		private const string RARITY_FRAME_NAME_FORMAT = "rarity_{0}";

		// Token: 0x0403D794 RID: 251796
		[Token(Token = "0x403D794")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemNum;

		// Token: 0x0403D795 RID: 251797
		[Token(Token = "0x403D795")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNum;

		// Token: 0x0403D796 RID: 251798
		[Token(Token = "0x403D796")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0403D797 RID: 251799
		[Token(Token = "0x403D797")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0403D798 RID: 251800
		[Token(Token = "0x403D798")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _rarityFrameImg;

		// Token: 0x0403D799 RID: 251801
		[Token(Token = "0x403D799")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _rarityFrameHolder;

		// Token: 0x0403D79A RID: 251802
		[Token(Token = "0x403D79A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectFrameImg;

		// Token: 0x0403D79B RID: 251803
		[Token(Token = "0x403D79B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _unobtainedMask;

		// Token: 0x0403D79C RID: 251804
		[Token(Token = "0x403D79C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403D79D RID: 251805
		[Token(Token = "0x403D79D")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedId;

		// Token: 0x0403D79E RID: 251806
		[Token(Token = "0x403D79E")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0403D79F RID: 251807
		[Token(Token = "0x403D79F")]
		[FieldOffset(Offset = "0x70")]
		private TrackPointViewProperty m_itemNewProperty;

		// Token: 0x0403D7A1 RID: 251809
		[Token(Token = "0x403D7A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0403D7A2 RID: 251810
		[Token(Token = "0x403D7A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0403D7A3 RID: 251811
		[Token(Token = "0x403D7A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D7A4 RID: 251812
		[Token(Token = "0x403D7A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D7A5 RID: 251813
		[Token(Token = "0x403D7A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403D7A6 RID: 251814
		[Token(Token = "0x403D7A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
