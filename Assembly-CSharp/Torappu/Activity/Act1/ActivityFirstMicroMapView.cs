using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B59 RID: 31577
	[Token(Token = "0x2007B59")]
	public class ActivityFirstMicroMapView : DataBinder<ActivityFirstMapProperty>, IHotfixable
	{
		// Token: 0x0602C332 RID: 181042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C332")]
		[Address(RVA = "0x281DA40", Offset = "0x281C640", VA = "0x18281DA40")]
		private void _InitIfNot(List<DefaultZoneData> zoneList)
		{
		}

		// Token: 0x0602C333 RID: 181043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C333")]
		[Address(RVA = "0x281D3B0", Offset = "0x281BFB0", VA = "0x18281D3B0")]
		public void OnSelect(string zoneId, DefaultZoneData zoneData)
		{
		}

		// Token: 0x0602C334 RID: 181044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C334")]
		[Address(RVA = "0x281D830", Offset = "0x281C430", VA = "0x18281D830", Slot = "7")]
		public override void OnValueChanged(ActivityFirstMapProperty property)
		{
		}

		// Token: 0x0602C335 RID: 181045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C335")]
		[Address(RVA = "0x281DD00", Offset = "0x281C900", VA = "0x18281DD00")]
		private void _OnItemCardClicked(int position)
		{
		}

		// Token: 0x0602C336 RID: 181046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C336")]
		[Address(RVA = "0x281DE10", Offset = "0x281CA10", VA = "0x18281DE10")]
		public ActivityFirstMicroMapView()
		{
		}

		// Token: 0x04040125 RID: 262437
		[Token(Token = "0x4040125")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityFirstMicroMapObj _obj;

		// Token: 0x04040126 RID: 262438
		[Token(Token = "0x4040126")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _objContainer;

		// Token: 0x04040127 RID: 262439
		[Token(Token = "0x4040127")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _dropItemContainer;

		// Token: 0x04040128 RID: 262440
		[Token(Token = "0x4040128")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _detailInfo;

		// Token: 0x04040129 RID: 262441
		[Token(Token = "0x4040129")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _itemCardScaleFactor;

		// Token: 0x0404012A RID: 262442
		[Token(Token = "0x404012A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _stringEvent;

		// Token: 0x0404012B RID: 262443
		[Token(Token = "0x404012B")]
		[FieldOffset(Offset = "0x50")]
		private UIItemCard m_itemObj;

		// Token: 0x0404012C RID: 262444
		[Token(Token = "0x404012C")]
		[FieldOffset(Offset = "0x58")]
		private bool m_initFlag;

		// Token: 0x0404012D RID: 262445
		[Token(Token = "0x404012D")]
		[FieldOffset(Offset = "0x60")]
		private List<UIItemCard> m_itemList;

		// Token: 0x0404012E RID: 262446
		[Token(Token = "0x404012E")]
		[FieldOffset(Offset = "0x68")]
		private List<ActivityFirstMicroMapObj> m_objList;

		// Token: 0x0404012F RID: 262447
		[Token(Token = "0x404012F")]
		[FieldOffset(Offset = "0x70")]
		private ActivityFirstUtil m_cacheLoader;

		// Token: 0x04040130 RID: 262448
		[Token(Token = "0x4040130")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04040131 RID: 262449
		[Token(Token = "0x4040131")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x04040132 RID: 262450
		[Token(Token = "0x4040132")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04040133 RID: 262451
		[Token(Token = "0x4040133")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x04040134 RID: 262452
		[Token(Token = "0x4040134")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
