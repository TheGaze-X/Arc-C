using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007657 RID: 30295
	[Token(Token = "0x2007657")]
	public class Act20sideCarDetailView : DataBinder<Act20sideCartCompSelectProperty>, IHotfixable
	{
		// Token: 0x0602A9D6 RID: 174550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9D6")]
		[Address(RVA = "0x2651BE0", Offset = "0x26507E0", VA = "0x182651BE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A9D7 RID: 174551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9D7")]
		[Address(RVA = "0x2651580", Offset = "0x2650180", VA = "0x182651580", Slot = "7")]
		public override void OnValueChanged(Act20sideCartCompSelectProperty property)
		{
		}

		// Token: 0x0602A9D8 RID: 174552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9D8")]
		[Address(RVA = "0x2651CC0", Offset = "0x26508C0", VA = "0x182651CC0")]
		public Act20sideCarDetailView()
		{
		}

		// Token: 0x0403D5D2 RID: 251346
		[Token(Token = "0x403D5D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act20sideCarBlueprintView _bluePrintCar;

		// Token: 0x0403D5D3 RID: 251347
		[Token(Token = "0x403D5D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act20sideCarDetailSelectCompObj> _carCompList;

		// Token: 0x0403D5D4 RID: 251348
		[Token(Token = "0x403D5D4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act20sideRecycleCompAdapter _adapter;

		// Token: 0x0403D5D5 RID: 251349
		[Token(Token = "0x403D5D5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AccessPosEvent _onClickEvent;

		// Token: 0x0403D5D6 RID: 251350
		[Token(Token = "0x403D5D6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act20sideCarObject _carObject;

		// Token: 0x0403D5D7 RID: 251351
		[Token(Token = "0x403D5D7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _carContainer;

		// Token: 0x0403D5D8 RID: 251352
		[Token(Token = "0x403D5D8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act20sideCarOSObj _carOsObj;

		// Token: 0x0403D5D9 RID: 251353
		[Token(Token = "0x403D5D9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _detailPart;

		// Token: 0x0403D5DA RID: 251354
		[Token(Token = "0x403D5DA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403D5DB RID: 251355
		[Token(Token = "0x403D5DB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x0403D5DC RID: 251356
		[Token(Token = "0x403D5DC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _notEmptyPart;

		// Token: 0x0403D5DD RID: 251357
		[Token(Token = "0x403D5DD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _coloredImg;

		// Token: 0x0403D5DE RID: 251358
		[Token(Token = "0x403D5DE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _exhibitDiffObjects;

		// Token: 0x0403D5DF RID: 251359
		[Token(Token = "0x403D5DF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject[] _battleDiffObjects;

		// Token: 0x0403D5E0 RID: 251360
		[Token(Token = "0x403D5E0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _applyBtn;

		// Token: 0x0403D5E1 RID: 251361
		[Token(Token = "0x403D5E1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _compName;

		// Token: 0x0403D5E2 RID: 251362
		[Token(Token = "0x403D5E2")]
		[FieldOffset(Offset = "0xA0")]
		private Act20sideCarObject m_carObject;

		// Token: 0x0403D5E3 RID: 251363
		[Token(Token = "0x403D5E3")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0403D5E4 RID: 251364
		[Token(Token = "0x403D5E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D5E5 RID: 251365
		[Token(Token = "0x403D5E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403D5E6 RID: 251366
		[Token(Token = "0x403D5E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
