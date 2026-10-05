using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F56 RID: 16214
	[Token(Token = "0x2003F56")]
	public class SiracusaMapNotify : UINotifyView<SiracusaMapNotify.Param>
	{
		// Token: 0x060192D7 RID: 103127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192D7")]
		[Address(RVA = "0x11EEBC0", Offset = "0x11ED7C0", VA = "0x1811EEBC0", Slot = "9")]
		protected override void Render(SiracusaMapNotify.Param param)
		{
		}

		// Token: 0x060192D8 RID: 103128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60192D8")]
		[Address(RVA = "0x11EEC90", Offset = "0x11ED890", VA = "0x1811EEC90")]
		public SiracusaMapNotify()
		{
		}

		// Token: 0x0401F377 RID: 127863
		[Token(Token = "0x401F377")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtNotify;

		// Token: 0x0401F378 RID: 127864
		[Token(Token = "0x401F378")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F379 RID: 127865
		[Token(Token = "0x401F379")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F57 RID: 16215
		[Token(Token = "0x2003F57")]
		public class Param : NotifyViewParam
		{
			// Token: 0x060192D9 RID: 103129 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60192D9")]
			[Address(RVA = "0x11E0020", Offset = "0x11DEC20", VA = "0x1811E0020", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x060192DA RID: 103130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60192DA")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0401F37A RID: 127866
			[Token(Token = "0x401F37A")]
			[FieldOffset(Offset = "0x10")]
			public string notifyTips;

			// Token: 0x0401F37B RID: 127867
			[Token(Token = "0x401F37B")]
			[FieldOffset(Offset = "0x18")]
			public bool isStrongAlert;
		}
	}
}
