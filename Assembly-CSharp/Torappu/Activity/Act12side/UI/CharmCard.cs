using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A75 RID: 31349
	[Token(Token = "0x2007A75")]
	public class CharmCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066F8 RID: 26360
		// (get) Token: 0x0602BE92 RID: 179858 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BE93 RID: 179859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066F8")]
		public CharmModel data
		{
			[Token(Token = "0x602BE92")]
			[Address(RVA = "0x27D2810", Offset = "0x27D1410", VA = "0x1827D2810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BE93")]
			[Address(RVA = "0x27D2A20", Offset = "0x27D1620", VA = "0x1827D2A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602BE94 RID: 179860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE94")]
		[Address(RVA = "0x27D1E80", Offset = "0x27D0A80", VA = "0x1827D1E80")]
		public void Flush(CharmModel cm, CharmCardMode mode = CharmCardMode.DEFAULT)
		{
		}

		// Token: 0x0602BE95 RID: 179861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE95")]
		[Address(RVA = "0x27D2560", Offset = "0x27D1160", VA = "0x1827D2560")]
		public void SetVisible(bool v)
		{
		}

		// Token: 0x170066F9 RID: 26361
		// (get) Token: 0x0602BE96 RID: 179862 RVA: 0x000DDA78 File Offset: 0x000DBC78
		[Token(Token = "0x170066F9")]
		public bool visible
		{
			[Token(Token = "0x602BE96")]
			[Address(RVA = "0x27D2920", Offset = "0x27D1520", VA = "0x1827D2920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170066FA RID: 26362
		// (get) Token: 0x0602BE97 RID: 179863 RVA: 0x000DDA90 File Offset: 0x000DBC90
		// (set) Token: 0x0602BE98 RID: 179864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066FA")]
		public bool selected
		{
			[Token(Token = "0x602BE97")]
			[Address(RVA = "0x27D2870", Offset = "0x27D1470", VA = "0x1827D2870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602BE98")]
			[Address(RVA = "0x27D2AA0", Offset = "0x27D16A0", VA = "0x1827D2AA0")]
			set
			{
			}
		}

		// Token: 0x0602BE99 RID: 179865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE99")]
		[Address(RVA = "0x27D23A0", Offset = "0x27D0FA0", VA = "0x1827D23A0")]
		public void SetSelected(bool sel, bool notify = true)
		{
		}

		// Token: 0x0602BE9A RID: 179866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE9A")]
		[Address(RVA = "0x27D25E0", Offset = "0x27D11E0", VA = "0x1827D25E0")]
		private void _UpdateSelectStatus(bool sel, int selIdx)
		{
		}

		// Token: 0x0602BE9B RID: 179867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE9B")]
		[Address(RVA = "0x27D1DF0", Offset = "0x27D09F0", VA = "0x1827D1DF0")]
		public Tween FadeOut()
		{
			return null;
		}

		// Token: 0x0602BE9C RID: 179868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE9C")]
		[Address(RVA = "0x27D1C90", Offset = "0x27D0890", VA = "0x1827D1C90")]
		public void EventOnClick()
		{
		}

		// Token: 0x170066FB RID: 26363
		// (get) Token: 0x0602BE9D RID: 179869 RVA: 0x000DDAA8 File Offset: 0x000DBCA8
		// (set) Token: 0x0602BE9E RID: 179870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066FB")]
		public bool clickable
		{
			[Token(Token = "0x602BE9D")]
			[Address(RVA = "0x27D2790", Offset = "0x27D1390", VA = "0x1827D2790")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602BE9E")]
			[Address(RVA = "0x27D2990", Offset = "0x27D1590", VA = "0x1827D2990")]
			set
			{
			}
		}

		// Token: 0x0602BE9F RID: 179871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE9F")]
		[Address(RVA = "0x27D2730", Offset = "0x27D1330", VA = "0x1827D2730")]
		public CharmCard()
		{
		}

		// Token: 0x0403F968 RID: 260456
		[Token(Token = "0x403F968")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _btn;

		// Token: 0x0403F969 RID: 260457
		[Token(Token = "0x403F969")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite[] _raritySprites;

		// Token: 0x0403F96A RID: 260458
		[Token(Token = "0x403F96A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403F96B RID: 260459
		[Token(Token = "0x403F96B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectedFlag;

		// Token: 0x0403F96C RID: 260460
		[Token(Token = "0x403F96C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _selectedIdx;

		// Token: 0x0403F96D RID: 260461
		[Token(Token = "0x403F96D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _duplication;

		// Token: 0x0403F96E RID: 260462
		[Token(Token = "0x403F96E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _dupIdx;

		// Token: 0x0403F96F RID: 260463
		[Token(Token = "0x403F96F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _newFlag;

		// Token: 0x0403F970 RID: 260464
		[Token(Token = "0x403F970")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _priceGO;

		// Token: 0x0403F971 RID: 260465
		[Token(Token = "0x403F971")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _priceLabel;

		// Token: 0x0403F972 RID: 260466
		[Token(Token = "0x403F972")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _recycleBuble;

		// Token: 0x0403F973 RID: 260467
		[Token(Token = "0x403F973")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _recycleNum;

		// Token: 0x0403F974 RID: 260468
		[Token(Token = "0x403F974")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403F975 RID: 260469
		[Token(Token = "0x403F975")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403F976 RID: 260470
		[Token(Token = "0x403F976")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("NOT_OWN")]
		private GameObject _notOwnFlag;

		// Token: 0x0403F977 RID: 260471
		[Token(Token = "0x403F977")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("NOT_OWN")]
		private Color _iconNotOwnClr;

		// Token: 0x0403F978 RID: 260472
		[Token(Token = "0x403F978")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("NOT_OWN")]
		private Color _bgNotOwnClr;

		// Token: 0x0403F979 RID: 260473
		[Token(Token = "0x403F979")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403F97A RID: 260474
		[Token(Token = "0x403F97A")]
		private const string ANIM_FADE_OUT = "charm_card_fadeout";

		// Token: 0x0403F97C RID: 260476
		[Token(Token = "0x403F97C")]
		[FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		public Action<CharmCard> onSelectChanged;

		// Token: 0x0403F97D RID: 260477
		[Token(Token = "0x403F97D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x0403F97E RID: 260478
		[Token(Token = "0x403F97E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_data;

		// Token: 0x0403F97F RID: 260479
		[Token(Token = "0x403F97F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x0403F980 RID: 260480
		[Token(Token = "0x403F980")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x0403F981 RID: 260481
		[Token(Token = "0x403F981")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_visible;

		// Token: 0x0403F982 RID: 260482
		[Token(Token = "0x403F982")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selected;

		// Token: 0x0403F983 RID: 260483
		[Token(Token = "0x403F983")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x0403F984 RID: 260484
		[Token(Token = "0x403F984")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetSelected;

		// Token: 0x0403F985 RID: 260485
		[Token(Token = "0x403F985")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateSelectStatus;

		// Token: 0x0403F986 RID: 260486
		[Token(Token = "0x403F986")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FadeOut;

		// Token: 0x0403F987 RID: 260487
		[Token(Token = "0x403F987")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403F988 RID: 260488
		[Token(Token = "0x403F988")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_clickable;

		// Token: 0x0403F989 RID: 260489
		[Token(Token = "0x403F989")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_clickable;

		// Token: 0x0403F98A RID: 260490
		[Token(Token = "0x403F98A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
