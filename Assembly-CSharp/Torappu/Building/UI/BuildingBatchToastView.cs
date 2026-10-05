using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B7A RID: 7034
	[Token(Token = "0x2001B7A")]
	public class BuildingBatchToastView : UINotifyView<BuildingBatchToastView.Param>, IHotfixable
	{
		// Token: 0x0600B039 RID: 45113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B039")]
		[Address(RVA = "0x32A18D0", Offset = "0x32A04D0", VA = "0x1832A18D0", Slot = "9")]
		protected override void Render(BuildingBatchToastView.Param param)
		{
		}

		// Token: 0x0600B03A RID: 45114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B03A")]
		[Address(RVA = "0x32A19B0", Offset = "0x32A05B0", VA = "0x1832A19B0")]
		public BuildingBatchToastView()
		{
		}

		// Token: 0x0400AA82 RID: 43650
		[Token(Token = "0x400AA82")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0400AA83 RID: 43651
		[Token(Token = "0x400AA83")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _workImg;

		// Token: 0x0400AA84 RID: 43652
		[Token(Token = "0x400AA84")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _restImg;

		// Token: 0x0400AA85 RID: 43653
		[Token(Token = "0x400AA85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AA86 RID: 43654
		[Token(Token = "0x400AA86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B7B RID: 7035
		[Token(Token = "0x2001B7B")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600B03B RID: 45115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B03B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400AA87 RID: 43655
			[Token(Token = "0x400AA87")]
			[FieldOffset(Offset = "0x10")]
			public bool isWork;

			// Token: 0x0400AA88 RID: 43656
			[Token(Token = "0x400AA88")]
			[FieldOffset(Offset = "0x18")]
			public string notifyTips;
		}
	}
}
