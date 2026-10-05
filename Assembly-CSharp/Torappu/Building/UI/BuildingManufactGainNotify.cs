using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B82 RID: 7042
	[Token(Token = "0x2001B82")]
	public class BuildingManufactGainNotify : UINotifyView<BuildingManufactGainNotify.Param>
	{
		// Token: 0x0600B043 RID: 45123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B043")]
		[Address(RVA = "0x32A4550", Offset = "0x32A3150", VA = "0x1832A4550", Slot = "9")]
		protected override void Render(BuildingManufactGainNotify.Param param)
		{
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B044")]
		[Address(RVA = "0x32A47B0", Offset = "0x32A33B0", VA = "0x1832A47B0")]
		public BuildingManufactGainNotify()
		{
		}

		// Token: 0x0400AA9E RID: 43678
		[Token(Token = "0x400AA9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400AA9F RID: 43679
		[Token(Token = "0x400AA9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x0400AAA0 RID: 43680
		[Token(Token = "0x400AAA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _scaler;

		// Token: 0x0400AAA1 RID: 43681
		[Token(Token = "0x400AAA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AAA2 RID: 43682
		[Token(Token = "0x400AAA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B83 RID: 7043
		[Token(Token = "0x2001B83")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600B045 RID: 45125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B045")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400AAA3 RID: 43683
			[Token(Token = "0x400AAA3")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0400AAA4 RID: 43684
			[Token(Token = "0x400AAA4")]
			[FieldOffset(Offset = "0x18")]
			public int itemCount;
		}
	}
}
