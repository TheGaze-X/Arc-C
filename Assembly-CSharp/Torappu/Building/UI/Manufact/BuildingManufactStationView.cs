using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DAF RID: 7599
	[Token(Token = "0x2001DAF")]
	public class BuildingManufactStationView : DataBinder<MRoomViewPropety>, BuildingCharAvatarStationAdatper.IProvider
	{
		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x00045EB8 File Offset: 0x000440B8
		[Token(Token = "0x170016A9")]
		public int finalMaxCharNum
		{
			[Token(Token = "0x600BB62")]
			[Address(RVA = "0x3395CE0", Offset = "0x33948E0", VA = "0x183395CE0", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x0600BB63 RID: 47971 RVA: 0x00045ED0 File Offset: 0x000440D0
		[Token(Token = "0x170016AA")]
		public int curMaxCharNum
		{
			[Token(Token = "0x600BB63")]
			[Address(RVA = "0x3395C60", Offset = "0x3394860", VA = "0x183395C60", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016AB")]
		public BuildingCharModel[] stationedChars
		{
			[Token(Token = "0x600BB64")]
			[Address(RVA = "0x3395DF0", Offset = "0x33949F0", VA = "0x183395DF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x0600BB65 RID: 47973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016AC")]
		private Action<BuildingCharModel, int> onCharClicked
		{
			[Token(Token = "0x600BB65")]
			[Address(RVA = "0x3395B30", Offset = "0x3394730", VA = "0x183395B30", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016AD")]
		public string slotId
		{
			[Token(Token = "0x600BB66")]
			[Address(RVA = "0x3395D60", Offset = "0x3394960", VA = "0x183395D60", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x0600BB67 RID: 47975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016AE")]
		public SimpleLayoutContent avatarContainer
		{
			[Token(Token = "0x600BB67")]
			[Address(RVA = "0x3395C00", Offset = "0x3394800", VA = "0x183395C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BB68 RID: 47976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB68")]
		[Address(RVA = "0x3395A40", Offset = "0x3394640", VA = "0x183395A40", Slot = "7")]
		public override void OnValueChanged(MRoomViewPropety property)
		{
		}

		// Token: 0x0600BB69 RID: 47977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB69")]
		[Address(RVA = "0x3395B90", Offset = "0x3394790", VA = "0x183395B90")]
		public BuildingManufactStationView()
		{
		}

		// Token: 0x0400BB12 RID: 47890
		[Token(Token = "0x400BB12")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _charLayout;

		// Token: 0x0400BB13 RID: 47891
		[Token(Token = "0x400BB13")]
		[FieldOffset(Offset = "0x28")]
		private MRoomViewModel m_viewModel;

		// Token: 0x0400BB14 RID: 47892
		[Token(Token = "0x400BB14")]
		[FieldOffset(Offset = "0x30")]
		private BuildingCharAvatarStationAdatper m_adapter;

		// Token: 0x0400BB15 RID: 47893
		[Token(Token = "0x400BB15")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0400BB16 RID: 47894
		[Token(Token = "0x400BB16")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<BuildingCharModel, int> onCharClicked;

		// Token: 0x0400BB17 RID: 47895
		[Token(Token = "0x400BB17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_finalMaxCharNum;

		// Token: 0x0400BB18 RID: 47896
		[Token(Token = "0x400BB18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curMaxCharNum;

		// Token: 0x0400BB19 RID: 47897
		[Token(Token = "0x400BB19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stationedChars;

		// Token: 0x0400BB1A RID: 47898
		[Token(Token = "0x400BB1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge get_onCharClicked;

		// Token: 0x0400BB1B RID: 47899
		[Token(Token = "0x400BB1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_slotId;

		// Token: 0x0400BB1C RID: 47900
		[Token(Token = "0x400BB1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_avatarContainer;

		// Token: 0x0400BB1D RID: 47901
		[Token(Token = "0x400BB1D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BB1E RID: 47902
		[Token(Token = "0x400BB1E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
