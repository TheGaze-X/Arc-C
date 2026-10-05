using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A3B RID: 31291
	[Token(Token = "0x2007A3B")]
	public class Act13sideMissionPoolItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066CD RID: 26317
		// (get) Token: 0x0602BD80 RID: 179584 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BD81 RID: 179585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066CD")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x602BD80")]
			[Address(RVA = "0x27CDDC0", Offset = "0x27CC9C0", VA = "0x1827CDDC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602BD81")]
			[Address(RVA = "0x27CDE20", Offset = "0x27CCA20", VA = "0x1827CDE20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BD82 RID: 179586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD82")]
		[Address(RVA = "0x27CD860", Offset = "0x27CC460", VA = "0x1827CD860")]
		public void Render(string actId, Act13sideDailyMissionItemViewModel poolItemModel, int index, bool isSelected)
		{
		}

		// Token: 0x0602BD83 RID: 179587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD83")]
		[Address(RVA = "0x27CD7C0", Offset = "0x27CC3C0", VA = "0x1827CD7C0")]
		public void PlayAcceptAnim()
		{
		}

		// Token: 0x0602BD84 RID: 179588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD84")]
		[Address(RVA = "0x27CD6B0", Offset = "0x27CC2B0", VA = "0x1827CD6B0")]
		public void OnItemClick()
		{
		}

		// Token: 0x0602BD85 RID: 179589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD85")]
		[Address(RVA = "0x27CDD50", Offset = "0x27CC950", VA = "0x1827CDD50")]
		public Act13sideMissionPoolItemView()
		{
		}

		// Token: 0x0403F78D RID: 259981
		[Token(Token = "0x403F78D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x0403F78E RID: 259982
		[Token(Token = "0x403F78E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x0403F78F RID: 259983
		[Token(Token = "0x403F78F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedBgGo;

		// Token: 0x0403F790 RID: 259984
		[Token(Token = "0x403F790")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalBgGo;

		// Token: 0x0403F791 RID: 259985
		[Token(Token = "0x403F791")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textOrgName;

		// Token: 0x0403F792 RID: 259986
		[Token(Token = "0x403F792")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textPrincipalName;

		// Token: 0x0403F793 RID: 259987
		[Token(Token = "0x403F793")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgAvatar;

		// Token: 0x0403F794 RID: 259988
		[Token(Token = "0x403F794")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _itemParent;

		// Token: 0x0403F795 RID: 259989
		[Token(Token = "0x403F795")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0403F796 RID: 259990
		[Token(Token = "0x403F796")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _acceptAnim;

		// Token: 0x0403F798 RID: 259992
		[Token(Token = "0x403F798")]
		[FieldOffset(Offset = "0x78")]
		private Act13sideDailyMissionItemViewModel m_poolItemModel;

		// Token: 0x0403F799 RID: 259993
		[Token(Token = "0x403F799")]
		[FieldOffset(Offset = "0x80")]
		private int m_index;

		// Token: 0x0403F79A RID: 259994
		[Token(Token = "0x403F79A")]
		[FieldOffset(Offset = "0x88")]
		private UIItemCard m_rewardItemView;

		// Token: 0x0403F79B RID: 259995
		[Token(Token = "0x403F79B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0403F79C RID: 259996
		[Token(Token = "0x403F79C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0403F79D RID: 259997
		[Token(Token = "0x403F79D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F79E RID: 259998
		[Token(Token = "0x403F79E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayAcceptAnim;

		// Token: 0x0403F79F RID: 259999
		[Token(Token = "0x403F79F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403F7A0 RID: 260000
		[Token(Token = "0x403F7A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
