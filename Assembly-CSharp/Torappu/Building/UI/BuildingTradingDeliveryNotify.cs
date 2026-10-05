using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B86 RID: 7046
	[Token(Token = "0x2001B86")]
	public class BuildingTradingDeliveryNotify : UINotifyView<BuildingTradingDeliveryNotify.Param>
	{
		// Token: 0x0600B049 RID: 45129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B049")]
		[Address(RVA = "0x32AA230", Offset = "0x32A8E30", VA = "0x1832AA230", Slot = "9")]
		protected override void Render(BuildingTradingDeliveryNotify.Param param)
		{
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B04A")]
		[Address(RVA = "0x32AA490", Offset = "0x32A9090", VA = "0x1832AA490")]
		public BuildingTradingDeliveryNotify()
		{
		}

		// Token: 0x0400AAA9 RID: 43689
		[Token(Token = "0x400AAA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400AAAA RID: 43690
		[Token(Token = "0x400AAAA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x0400AAAB RID: 43691
		[Token(Token = "0x400AAAB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _scaler;

		// Token: 0x0400AAAC RID: 43692
		[Token(Token = "0x400AAAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AAAD RID: 43693
		[Token(Token = "0x400AAAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B87 RID: 7047
		[Token(Token = "0x2001B87")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600B04B RID: 45131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B04B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400AAAE RID: 43694
			[Token(Token = "0x400AAAE")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0400AAAF RID: 43695
			[Token(Token = "0x400AAAF")]
			[FieldOffset(Offset = "0x18")]
			public int itemCount;
		}
	}
}
