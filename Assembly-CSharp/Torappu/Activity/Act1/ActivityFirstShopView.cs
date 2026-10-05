using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B46 RID: 31558
	[Token(Token = "0x2007B46")]
	public class ActivityFirstShopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C2D5 RID: 180949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2D5")]
		[Address(RVA = "0x2816860", Offset = "0x2815460", VA = "0x182816860")]
		private void _InitData(List<ActivityShopData> shopDataList)
		{
		}

		// Token: 0x0602C2D6 RID: 180950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2D6")]
		[Address(RVA = "0x28166D0", Offset = "0x28152D0", VA = "0x1828166D0")]
		public void RenderData(List<ActivityShopData> shopDataList)
		{
		}

		// Token: 0x0602C2D7 RID: 180951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2D7")]
		[Address(RVA = "0x2816A30", Offset = "0x2815630", VA = "0x182816A30")]
		public ActivityFirstShopView()
		{
		}

		// Token: 0x040400B4 RID: 262324
		[Token(Token = "0x40400B4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActivityFirstShopObject _shopObj;

		// Token: 0x040400B5 RID: 262325
		[Token(Token = "0x40400B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _shopContainer;

		// Token: 0x040400B6 RID: 262326
		[Token(Token = "0x40400B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIActShopEvent _stringEvent;

		// Token: 0x040400B7 RID: 262327
		[Token(Token = "0x40400B7")]
		[FieldOffset(Offset = "0x30")]
		private List<ActivityFirstShopObject> m_shopObjList;

		// Token: 0x040400B8 RID: 262328
		[Token(Token = "0x40400B8")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x040400B9 RID: 262329
		[Token(Token = "0x40400B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x040400BA RID: 262330
		[Token(Token = "0x40400BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderData;

		// Token: 0x040400BB RID: 262331
		[Token(Token = "0x40400BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
