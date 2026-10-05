using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B8A RID: 7050
	[Token(Token = "0x2001B8A")]
	public class BuildingWorkshopBySideNotify : UINotifyView<BuildingWorkshopBySideNotify.Param>
	{
		// Token: 0x0600B04F RID: 45135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B04F")]
		[Address(RVA = "0x32AAEC0", Offset = "0x32A9AC0", VA = "0x1832AAEC0", Slot = "9")]
		protected override void Render(BuildingWorkshopBySideNotify.Param param)
		{
		}

		// Token: 0x0600B050 RID: 45136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B050")]
		[Address(RVA = "0x32AB120", Offset = "0x32A9D20", VA = "0x1832AB120")]
		public BuildingWorkshopBySideNotify()
		{
		}

		// Token: 0x0400AAB6 RID: 43702
		[Token(Token = "0x400AAB6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400AAB7 RID: 43703
		[Token(Token = "0x400AAB7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x0400AAB8 RID: 43704
		[Token(Token = "0x400AAB8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _scaler;

		// Token: 0x0400AAB9 RID: 43705
		[Token(Token = "0x400AAB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AABA RID: 43706
		[Token(Token = "0x400AABA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B8B RID: 7051
		[Token(Token = "0x2001B8B")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600B051 RID: 45137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B051")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400AABB RID: 43707
			[Token(Token = "0x400AABB")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0400AABC RID: 43708
			[Token(Token = "0x400AABC")]
			[FieldOffset(Offset = "0x18")]
			public int itemCount;
		}
	}
}
