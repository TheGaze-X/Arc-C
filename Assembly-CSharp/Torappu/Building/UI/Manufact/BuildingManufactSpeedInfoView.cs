using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DAD RID: 7597
	[Token(Token = "0x2001DAD")]
	public class BuildingManufactSpeedInfoView : DataBinder<MRoomViewPropety>
	{
		// Token: 0x0600BB54 RID: 47956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB54")]
		[Address(RVA = "0x3394C60", Offset = "0x3393860", VA = "0x183394C60", Slot = "7")]
		public override void OnValueChanged(MRoomViewPropety property)
		{
		}

		// Token: 0x0600BB55 RID: 47957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB55")]
		[Address(RVA = "0x33953E0", Offset = "0x3393FE0", VA = "0x1833953E0")]
		private IEnumerator _UpdateAutoLayoutsCoroutine()
		{
			return null;
		}

		// Token: 0x0600BB56 RID: 47958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB56")]
		[Address(RVA = "0x3395490", Offset = "0x3394090", VA = "0x183395490")]
		private void _UpdateSavedTime(MRoomViewModel viewModel, ManufactSnapshot snapshot)
		{
		}

		// Token: 0x0600BB57 RID: 47959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB57")]
		[Address(RVA = "0x3395820", Offset = "0x3394420", VA = "0x183395820")]
		private void _UpdateSecond(CountDownTask.TickValue tickValue)
		{
		}

		// Token: 0x0600BB58 RID: 47960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB58")]
		[Address(RVA = "0x3395100", Offset = "0x3393D00", VA = "0x183395100")]
		private void _FormatBuffedValues(float baseBuff, float specBuff, SimpleLayoutContent layout, ref BuildingBuffedValueView.ListAdapter refAdatper, bool usePercentFormat)
		{
		}

		// Token: 0x0600BB59 RID: 47961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB59")]
		[Address(RVA = "0x3394B60", Offset = "0x3393760", VA = "0x183394B60")]
		private void OnEnable()
		{
		}

		// Token: 0x0600BB5A RID: 47962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB5A")]
		[Address(RVA = "0x3395090", Offset = "0x3393C90", VA = "0x183395090")]
		private void Update()
		{
		}

		// Token: 0x0600BB5B RID: 47963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB5B")]
		[Address(RVA = "0x33959D0", Offset = "0x33945D0", VA = "0x1833959D0")]
		public BuildingManufactSpeedInfoView()
		{
		}

		// Token: 0x0400BAF6 RID: 47862
		[Token(Token = "0x400BAF6")]
		private const string INVALID_TIME = "--:--:--";

		// Token: 0x0400BAF7 RID: 47863
		[Token(Token = "0x400BAF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textManpowerCost;

		// Token: 0x0400BAF8 RID: 47864
		[Token(Token = "0x400BAF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _mpBuffLayout;

		// Token: 0x0400BAF9 RID: 47865
		[Token(Token = "0x400BAF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textSpeed;

		// Token: 0x0400BAFA RID: 47866
		[Token(Token = "0x400BAFA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _speedBuffLayout;

		// Token: 0x0400BAFB RID: 47867
		[Token(Token = "0x400BAFB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textSavedTime;

		// Token: 0x0400BAFC RID: 47868
		[Token(Token = "0x400BAFC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _iconSpeedUp;

		// Token: 0x0400BAFD RID: 47869
		[Token(Token = "0x400BAFD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _iconTimeDown;

		// Token: 0x0400BAFE RID: 47870
		[Token(Token = "0x400BAFE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _iconMpDown;

		// Token: 0x0400BAFF RID: 47871
		[Token(Token = "0x400BAFF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0400BB00 RID: 47872
		[Token(Token = "0x400BB00")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Buff Style")]
		private Color _bkgBuffColor;

		// Token: 0x0400BB01 RID: 47873
		[Token(Token = "0x400BB01")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Buff Style")]
		private Color _textBuffColor;

		// Token: 0x0400BB02 RID: 47874
		[Token(Token = "0x400BB02")]
		[FieldOffset(Offset = "0x88")]
		private CountDownTask m_countDown;

		// Token: 0x0400BB03 RID: 47875
		[Token(Token = "0x400BB03")]
		[FieldOffset(Offset = "0x90")]
		private ManufactInfoViewModel m_infoCache;

		// Token: 0x0400BB04 RID: 47876
		[Token(Token = "0x400BB04")]
		[FieldOffset(Offset = "0x98")]
		private string m_colorBuffedCode;

		// Token: 0x0400BB05 RID: 47877
		[Token(Token = "0x400BB05")]
		[FieldOffset(Offset = "0xA0")]
		private BuildingBuffedValueView.ListAdapter m_speedBuffAdapter;

		// Token: 0x0400BB06 RID: 47878
		[Token(Token = "0x400BB06")]
		[FieldOffset(Offset = "0xA8")]
		private BuildingBuffedValueView.ListAdapter m_mpBuffAdapter;

		// Token: 0x0400BB07 RID: 47879
		[Token(Token = "0x400BB07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BB08 RID: 47880
		[Token(Token = "0x400BB08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayoutsCoroutine;

		// Token: 0x0400BB09 RID: 47881
		[Token(Token = "0x400BB09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateSavedTime;

		// Token: 0x0400BB0A RID: 47882
		[Token(Token = "0x400BB0A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateSecond;

		// Token: 0x0400BB0B RID: 47883
		[Token(Token = "0x400BB0B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FormatBuffedValues;

		// Token: 0x0400BB0C RID: 47884
		[Token(Token = "0x400BB0C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400BB0D RID: 47885
		[Token(Token = "0x400BB0D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400BB0E RID: 47886
		[Token(Token = "0x400BB0E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
