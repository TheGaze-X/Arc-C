using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B88 RID: 7048
	[Token(Token = "0x2001B88")]
	public class BuildingTwoContentNotify : UINotifyView<BuildingTwoContentNotify.Param>
	{
		// Token: 0x0600B04C RID: 45132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B04C")]
		[Address(RVA = "0x32AA500", Offset = "0x32A9100", VA = "0x1832AA500", Slot = "9")]
		protected override void Render(BuildingTwoContentNotify.Param param)
		{
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B04D")]
		[Address(RVA = "0x32AA620", Offset = "0x32A9220", VA = "0x1832AA620")]
		public BuildingTwoContentNotify()
		{
		}

		// Token: 0x0400AAB0 RID: 43696
		[Token(Token = "0x400AAB0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainContent;

		// Token: 0x0400AAB1 RID: 43697
		[Token(Token = "0x400AAB1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _subContent;

		// Token: 0x0400AAB2 RID: 43698
		[Token(Token = "0x400AAB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AAB3 RID: 43699
		[Token(Token = "0x400AAB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B89 RID: 7049
		[Token(Token = "0x2001B89")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600B04E RID: 45134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B04E")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400AAB4 RID: 43700
			[Token(Token = "0x400AAB4")]
			[FieldOffset(Offset = "0x10")]
			public string mainContent;

			// Token: 0x0400AAB5 RID: 43701
			[Token(Token = "0x400AAB5")]
			[FieldOffset(Offset = "0x18")]
			public string subContent;
		}
	}
}
