using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG.Holders
{
	// Token: 0x02001F96 RID: 8086
	[Token(Token = "0x2001F96")]
	public class AVGDisplayableEffectHolder : AVGDisplayableHolder, AVGDisplayableHolder.IPositionFeature, AVGDisplayableHolder.IFeature, IHotfixable, AVGDisplayableHolder.IRotationFeature
	{
		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x0600C8ED RID: 51437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017CC")]
		public Transform contentTransform
		{
			[Token(Token = "0x600C8ED")]
			[Address(RVA = "0x348C630", Offset = "0x348B230", VA = "0x18348C630", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C8EE RID: 51438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C8EE")]
		[Address(RVA = "0x348C300", Offset = "0x348AF00", VA = "0x18348C300", Slot = "5")]
		public override GameObject GenerateContent(AVGDisplayableHolder.AVGDisplayParam param)
		{
			return null;
		}

		// Token: 0x0600C8EF RID: 51439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8EF")]
		[Address(RVA = "0x348C5D0", Offset = "0x348B1D0", VA = "0x18348C5D0")]
		public AVGDisplayableEffectHolder()
		{
		}

		// Token: 0x0400CF79 RID: 53113
		[Token(Token = "0x400CF79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_contentTransform;

		// Token: 0x0400CF7A RID: 53114
		[Token(Token = "0x400CF7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateContent;

		// Token: 0x0400CF7B RID: 53115
		[Token(Token = "0x400CF7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
