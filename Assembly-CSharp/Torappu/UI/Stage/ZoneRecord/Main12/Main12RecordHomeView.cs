using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A0E RID: 27150
	[Token(Token = "0x2006A0E")]
	public class Main12RecordHomeView : DataBinder<Main12ZoneRecordViewProperty>
	{
		// Token: 0x17005B9B RID: 23451
		// (get) Token: 0x06026D02 RID: 158978 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D03 RID: 158979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B9B")]
		public Action<string> onClickBtn
		{
			[Token(Token = "0x6026D02")]
			[Address(RVA = "0x21D3B70", Offset = "0x21D2770", VA = "0x1821D3B70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026D03")]
			[Address(RVA = "0x21D3CB0", Offset = "0x21D28B0", VA = "0x1821D3CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005B9C RID: 23452
		// (get) Token: 0x06026D04 RID: 158980 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D05 RID: 158981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B9C")]
		public Action onClickAllRewardBtn
		{
			[Token(Token = "0x6026D04")]
			[Address(RVA = "0x21D3B10", Offset = "0x21D2710", VA = "0x1821D3B10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026D05")]
			[Address(RVA = "0x21D3C30", Offset = "0x21D2830", VA = "0x1821D3C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005B9D RID: 23453
		// (get) Token: 0x06026D06 RID: 158982 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D07 RID: 158983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B9D")]
		public Action onClickRewardBuffBtn
		{
			[Token(Token = "0x6026D06")]
			[Address(RVA = "0x21D3BD0", Offset = "0x21D27D0", VA = "0x1821D3BD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6026D07")]
			[Address(RVA = "0x21D3D30", Offset = "0x21D2930", VA = "0x1821D3D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026D08 RID: 158984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D08")]
		[Address(RVA = "0x21D3660", Offset = "0x21D2260", VA = "0x1821D3660", Slot = "7")]
		public override void OnValueChanged(Main12ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026D09 RID: 158985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D09")]
		[Address(RVA = "0x21D3440", Offset = "0x21D2040", VA = "0x1821D3440")]
		public void OnClickAllRewardBtn()
		{
		}

		// Token: 0x06026D0A RID: 158986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D0A")]
		[Address(RVA = "0x21D3550", Offset = "0x21D2150", VA = "0x1821D3550")]
		public void OnClickRewardBuffBtn()
		{
		}

		// Token: 0x06026D0B RID: 158987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D0B")]
		[Address(RVA = "0x21D3890", Offset = "0x21D2490", VA = "0x1821D3890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D0C RID: 158988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D0C")]
		[Address(RVA = "0x21D3AA0", Offset = "0x21D26A0", VA = "0x1821D3AA0")]
		public Main12RecordHomeView()
		{
		}

		// Token: 0x04036D53 RID: 224595
		[Token(Token = "0x4036D53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Main12RecordHomeButtonView> _buttonViews;

		// Token: 0x04036D54 RID: 224596
		[Token(Token = "0x4036D54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _recordTitle;

		// Token: 0x04036D55 RID: 224597
		[Token(Token = "0x4036D55")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _recordDesc;

		// Token: 0x04036D56 RID: 224598
		[Token(Token = "0x4036D56")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ZoneRecordRewardBuffPlugin _rewardBuffPlugin;

		// Token: 0x04036D57 RID: 224599
		[Token(Token = "0x4036D57")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04036D5B RID: 224603
		[Token(Token = "0x4036D5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickBtn;

		// Token: 0x04036D5C RID: 224604
		[Token(Token = "0x4036D5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickBtn;

		// Token: 0x04036D5D RID: 224605
		[Token(Token = "0x4036D5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClickAllRewardBtn;

		// Token: 0x04036D5E RID: 224606
		[Token(Token = "0x4036D5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClickAllRewardBtn;

		// Token: 0x04036D5F RID: 224607
		[Token(Token = "0x4036D5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onClickRewardBuffBtn;

		// Token: 0x04036D60 RID: 224608
		[Token(Token = "0x4036D60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onClickRewardBuffBtn;

		// Token: 0x04036D61 RID: 224609
		[Token(Token = "0x4036D61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036D62 RID: 224610
		[Token(Token = "0x4036D62")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickAllRewardBtn;

		// Token: 0x04036D63 RID: 224611
		[Token(Token = "0x4036D63")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClickRewardBuffBtn;

		// Token: 0x04036D64 RID: 224612
		[Token(Token = "0x4036D64")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036D65 RID: 224613
		[Token(Token = "0x4036D65")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
