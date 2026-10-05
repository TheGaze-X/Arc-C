using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007233 RID: 29235
	[Token(Token = "0x2007233")]
	public class Act5D1RuneUnlockNotify : UINotifyView<Act5D1RuneUnlockNotify.Param>, IHotfixable
	{
		// Token: 0x060296E2 RID: 169698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296E2")]
		[Address(RVA = "0x24CFE30", Offset = "0x24CEA30", VA = "0x1824CFE30", Slot = "9")]
		protected override void Render(Act5D1RuneUnlockNotify.Param param)
		{
		}

		// Token: 0x060296E3 RID: 169699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296E3")]
		[Address(RVA = "0x24CFFB0", Offset = "0x24CEBB0", VA = "0x1824CFFB0")]
		public Act5D1RuneUnlockNotify()
		{
		}

		// Token: 0x0403B2F1 RID: 242417
		[Token(Token = "0x403B2F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _sprite;

		// Token: 0x0403B2F2 RID: 242418
		[Token(Token = "0x403B2F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _unlockText;

		// Token: 0x0403B2F3 RID: 242419
		[Token(Token = "0x403B2F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B2F4 RID: 242420
		[Token(Token = "0x403B2F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007234 RID: 29236
		[Token(Token = "0x2007234")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060296E4 RID: 169700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60296E4")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0403B2F5 RID: 242421
			[Token(Token = "0x403B2F5")]
			[FieldOffset(Offset = "0x10")]
			public string runeId;

			// Token: 0x0403B2F6 RID: 242422
			[Token(Token = "0x403B2F6")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;
		}
	}
}
