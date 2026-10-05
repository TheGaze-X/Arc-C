using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040D2 RID: 16594
	[Token(Token = "0x20040D2")]
	public class SandboxV2ScienceLineSegmentModel : IHotfixable
	{
		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x06019AC8 RID: 105160 RVA: 0x0009F0C0 File Offset: 0x0009D2C0
		[Token(Token = "0x17003D40")]
		public bool isPublic
		{
			[Token(Token = "0x6019AC8")]
			[Address(RVA = "0x1289E90", Offset = "0x1288A90", VA = "0x181289E90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06019AC9 RID: 105161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019AC9")]
		[Address(RVA = "0x1289E30", Offset = "0x1288A30", VA = "0x181289E30")]
		public SandboxV2ScienceLineSegmentModel()
		{
		}

		// Token: 0x04020197 RID: 131479
		[Token(Token = "0x4020197")]
		[FieldOffset(Offset = "0x10")]
		public string fromNodeId;

		// Token: 0x04020198 RID: 131480
		[Token(Token = "0x4020198")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2DevelopmentLineSegmentData segmentData;

		// Token: 0x04020199 RID: 131481
		[Token(Token = "0x4020199")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 fromNodePos;

		// Token: 0x0402019A RID: 131482
		[Token(Token = "0x402019A")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 toNodePos;

		// Token: 0x0402019B RID: 131483
		[Token(Token = "0x402019B")]
		[FieldOffset(Offset = "0x30")]
		public bool isSegmentUnlock;

		// Token: 0x0402019C RID: 131484
		[Token(Token = "0x402019C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isPublic;

		// Token: 0x0402019D RID: 131485
		[Token(Token = "0x402019D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
