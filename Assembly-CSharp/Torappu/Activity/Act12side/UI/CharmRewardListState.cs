using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A87 RID: 31367
	[Token(Token = "0x2007A87")]
	public class CharmRewardListState : PopupFloatState
	{
		// Token: 0x0602BF00 RID: 179968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF00")]
		[Address(RVA = "0x27E75D0", Offset = "0x27E61D0", VA = "0x1827E75D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BF01 RID: 179969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF01")]
		[Address(RVA = "0x27E7630", Offset = "0x27E6230", VA = "0x1827E7630", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BF02 RID: 179970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF02")]
		[Address(RVA = "0x27E7BC0", Offset = "0x27E67C0", VA = "0x1827E7BC0")]
		private void _Refresh()
		{
		}

		// Token: 0x0602BF03 RID: 179971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF03")]
		[Address(RVA = "0x27E77F0", Offset = "0x27E63F0", VA = "0x1827E77F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BF04 RID: 179972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF04")]
		[Address(RVA = "0x27E7570", Offset = "0x27E6170", VA = "0x1827E7570", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BF05 RID: 179973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF05")]
		[Address(RVA = "0x27E74F0", Offset = "0x27E60F0", VA = "0x1827E74F0")]
		public void EventOnClose()
		{
		}

		// Token: 0x0602BF06 RID: 179974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF06")]
		[Address(RVA = "0x27E7690", Offset = "0x27E6290", VA = "0x1827E7690")]
		private string _GetTheActivityOpenedMe()
		{
			return null;
		}

		// Token: 0x0602BF07 RID: 179975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF07")]
		[Address(RVA = "0x27E8060", Offset = "0x27E6C60", VA = "0x1827E8060")]
		public CharmRewardListState()
		{
		}

		// Token: 0x0602BF08 RID: 179976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF08")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BF09 RID: 179977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF09")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403FA55 RID: 260693
		[Token(Token = "0x403FA55")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _intro;

		// Token: 0x0403FA56 RID: 260694
		[Token(Token = "0x403FA56")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharmCard _cardPrefab;

		// Token: 0x0403FA57 RID: 260695
		[Token(Token = "0x403FA57")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0403FA58 RID: 260696
		[Token(Token = "0x403FA58")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403FA59 RID: 260697
		[Token(Token = "0x403FA59")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _cnt;

		// Token: 0x0403FA5A RID: 260698
		[Token(Token = "0x403FA5A")]
		[FieldOffset(Offset = "0x98")]
		private List<CharmModel> m_charmModels;

		// Token: 0x0403FA5B RID: 260699
		[Token(Token = "0x403FA5B")]
		[FieldOffset(Offset = "0xA0")]
		private List<CharmCard> m_items;

		// Token: 0x0403FA5C RID: 260700
		[Token(Token = "0x403FA5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FA5D RID: 260701
		[Token(Token = "0x403FA5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403FA5E RID: 260702
		[Token(Token = "0x403FA5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x0403FA5F RID: 260703
		[Token(Token = "0x403FA5F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FA60 RID: 260704
		[Token(Token = "0x403FA60")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FA61 RID: 260705
		[Token(Token = "0x403FA61")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x0403FA62 RID: 260706
		[Token(Token = "0x403FA62")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetTheActivityOpenedMe;

		// Token: 0x0403FA63 RID: 260707
		[Token(Token = "0x403FA63")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
