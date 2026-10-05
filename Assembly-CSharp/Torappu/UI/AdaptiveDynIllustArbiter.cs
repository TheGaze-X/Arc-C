using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034BF RID: 13503
	[Token(Token = "0x20034BF")]
	public class AdaptiveDynIllustArbiter : IHotfixable
	{
		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0601584D RID: 88141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032D3")]
		public string illustId
		{
			[Token(Token = "0x601584D")]
			[Address(RVA = "0xDF67D0", Offset = "0xDF53D0", VA = "0x180DF67D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601584E RID: 88142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601584E")]
		[Address(RVA = "0xDF64E0", Offset = "0xDF50E0", VA = "0x180DF64E0")]
		public void ChangeDynIllustTarget(UICharacterDynIllust illustTarget)
		{
		}

		// Token: 0x0601584F RID: 88143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601584F")]
		[Address(RVA = "0xDF65C0", Offset = "0xDF51C0", VA = "0x180DF65C0")]
		public void FindTargetDynIllust(List<UICharacterDynIllust> dynIllustList, out bool isCoexist, out UICharacterDynIllust dynIllust)
		{
		}

		// Token: 0x06015850 RID: 88144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015850")]
		[Address(RVA = "0xDF6770", Offset = "0xDF5370", VA = "0x180DF6770")]
		public AdaptiveDynIllustArbiter()
		{
		}

		// Token: 0x04019C9C RID: 105628
		[Token(Token = "0x4019C9C")]
		[FieldOffset(Offset = "0x10")]
		private string m_illustId;

		// Token: 0x04019C9D RID: 105629
		[Token(Token = "0x4019C9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_illustId;

		// Token: 0x04019C9E RID: 105630
		[Token(Token = "0x4019C9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ChangeDynIllustTarget;

		// Token: 0x04019C9F RID: 105631
		[Token(Token = "0x4019C9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindTargetDynIllust;

		// Token: 0x04019CA0 RID: 105632
		[Token(Token = "0x4019CA0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
