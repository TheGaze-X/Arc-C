using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E37 RID: 20023
	[Token(Token = "0x2004E37")]
	public class FireworkPlateNotify : UINotifyView<FireworkPlateNotify.Param>, IHotfixable
	{
		// Token: 0x0601DE91 RID: 122513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE91")]
		[Address(RVA = "0x176FB80", Offset = "0x176E780", VA = "0x18176FB80", Slot = "9")]
		protected override void Render(FireworkPlateNotify.Param param)
		{
		}

		// Token: 0x0601DE92 RID: 122514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE92")]
		[Address(RVA = "0x176FC50", Offset = "0x176E850", VA = "0x18176FC50")]
		public FireworkPlateNotify()
		{
		}

		// Token: 0x04027AFD RID: 162557
		[Token(Token = "0x4027AFD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x04027AFE RID: 162558
		[Token(Token = "0x4027AFE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027AFF RID: 162559
		[Token(Token = "0x4027AFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E38 RID: 20024
		[Token(Token = "0x2004E38")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0601DE93 RID: 122515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DE93")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04027B00 RID: 162560
			[Token(Token = "0x4027B00")]
			[FieldOffset(Offset = "0x10")]
			public string toastInfo;
		}
	}
}
