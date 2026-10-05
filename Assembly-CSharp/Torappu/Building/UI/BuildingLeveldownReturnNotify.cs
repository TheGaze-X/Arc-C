using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B80 RID: 7040
	[Token(Token = "0x2001B80")]
	public class BuildingLeveldownReturnNotify : UINotifyView<BuildingLeveldownReturnNotify.Param>
	{
		// Token: 0x0600B040 RID: 45120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B040")]
		[Address(RVA = "0x32A4280", Offset = "0x32A2E80", VA = "0x1832A4280", Slot = "9")]
		protected override void Render(BuildingLeveldownReturnNotify.Param param)
		{
		}

		// Token: 0x0600B041 RID: 45121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B041")]
		[Address(RVA = "0x32A44E0", Offset = "0x32A30E0", VA = "0x1832A44E0")]
		public BuildingLeveldownReturnNotify()
		{
		}

		// Token: 0x0400AA97 RID: 43671
		[Token(Token = "0x400AA97")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400AA98 RID: 43672
		[Token(Token = "0x400AA98")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textContent;

		// Token: 0x0400AA99 RID: 43673
		[Token(Token = "0x400AA99")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _scaler;

		// Token: 0x0400AA9A RID: 43674
		[Token(Token = "0x400AA9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AA9B RID: 43675
		[Token(Token = "0x400AA9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B81 RID: 7041
		[Token(Token = "0x2001B81")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600B042 RID: 45122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B042")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400AA9C RID: 43676
			[Token(Token = "0x400AA9C")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0400AA9D RID: 43677
			[Token(Token = "0x400AA9D")]
			[FieldOffset(Offset = "0x18")]
			public int itemCount;
		}
	}
}
