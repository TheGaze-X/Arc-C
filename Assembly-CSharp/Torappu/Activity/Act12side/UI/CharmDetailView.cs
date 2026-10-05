using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A78 RID: 31352
	[Token(Token = "0x2007A78")]
	public class CharmDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BEA6 RID: 179878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEA6")]
		[Address(RVA = "0x27D2CA0", Offset = "0x27D18A0", VA = "0x1827D2CA0")]
		public void Flush(CharmModel cm, string activityID)
		{
		}

		// Token: 0x0602BEA7 RID: 179879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEA7")]
		[Address(RVA = "0x27D3700", Offset = "0x27D2300", VA = "0x1827D3700")]
		public CharmDetailView()
		{
		}

		// Token: 0x0403F995 RID: 260501
		[Token(Token = "0x403F995")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403F996 RID: 260502
		[Token(Token = "0x403F996")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _rarityIcones;

		// Token: 0x0403F997 RID: 260503
		[Token(Token = "0x403F997")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _price;

		// Token: 0x0403F998 RID: 260504
		[Token(Token = "0x403F998")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _effect;

		// Token: 0x0403F999 RID: 260505
		[Token(Token = "0x403F999")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403F99A RID: 260506
		[Token(Token = "0x403F99A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _specialObtainLine;

		// Token: 0x0403F99B RID: 260507
		[Token(Token = "0x403F99B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _sepcialObtainLabel;

		// Token: 0x0403F99C RID: 260508
		[Token(Token = "0x403F99C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _dropView;

		// Token: 0x0403F99D RID: 260509
		[Token(Token = "0x403F99D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _dropRoot;

		// Token: 0x0403F99E RID: 260510
		[Token(Token = "0x403F99E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharmDropStageItem _dropItemPrefab;

		// Token: 0x0403F99F RID: 260511
		[Token(Token = "0x403F99F")]
		[FieldOffset(Offset = "0x68")]
		private List<CharmDropStageItem> m_dropItems;

		// Token: 0x0403F9A0 RID: 260512
		[Token(Token = "0x403F9A0")]
		[FieldOffset(Offset = "0x70")]
		private List<string> m_dropStages;

		// Token: 0x0403F9A1 RID: 260513
		[Token(Token = "0x403F9A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Flush;

		// Token: 0x0403F9A2 RID: 260514
		[Token(Token = "0x403F9A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
