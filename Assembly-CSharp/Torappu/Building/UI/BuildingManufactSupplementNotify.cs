using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B84 RID: 7044
	[Token(Token = "0x2001B84")]
	public class BuildingManufactSupplementNotify : UINotifyView<BuildingManufactSupplementNotify.Param>
	{
		// Token: 0x0600B046 RID: 45126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B046")]
		[Address(RVA = "0x32A4820", Offset = "0x32A3420", VA = "0x1832A4820", Slot = "9")]
		protected override void Render(BuildingManufactSupplementNotify.Param param)
		{
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B047")]
		[Address(RVA = "0x32A48F0", Offset = "0x32A34F0", VA = "0x1832A48F0")]
		public BuildingManufactSupplementNotify()
		{
		}

		// Token: 0x0400AAA5 RID: 43685
		[Token(Token = "0x400AAA5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainContent;

		// Token: 0x0400AAA6 RID: 43686
		[Token(Token = "0x400AAA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AAA7 RID: 43687
		[Token(Token = "0x400AAA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B85 RID: 7045
		[Token(Token = "0x2001B85")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600B048 RID: 45128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B048")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400AAA8 RID: 43688
			[Token(Token = "0x400AAA8")]
			[FieldOffset(Offset = "0x10")]
			public string mainContent;
		}
	}
}
