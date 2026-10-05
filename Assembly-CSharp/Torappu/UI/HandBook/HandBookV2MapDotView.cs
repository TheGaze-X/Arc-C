using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066F8 RID: 26360
	[Token(Token = "0x20066F8")]
	public class HandBookV2MapDotView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005999 RID: 22937
		// (get) Token: 0x06025D5C RID: 154972 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025D5D RID: 154973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005999")]
		public Action onDotClick
		{
			[Token(Token = "0x6025D5C")]
			[Address(RVA = "0x20C5040", Offset = "0x20C3C40", VA = "0x1820C5040")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025D5D")]
			[Address(RVA = "0x20C50A0", Offset = "0x20C3CA0", VA = "0x1820C50A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025D5E RID: 154974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D5E")]
		[Address(RVA = "0x20C4BB0", Offset = "0x20C37B0", VA = "0x1820C4BB0")]
		public void OnDotClick()
		{
		}

		// Token: 0x06025D5F RID: 154975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D5F")]
		[Address(RVA = "0x20C4CC0", Offset = "0x20C38C0", VA = "0x1820C4CC0")]
		public void RenderColor(string colorStr, bool isCharUnlock)
		{
		}

		// Token: 0x06025D60 RID: 154976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D60")]
		[Address(RVA = "0x20C4E20", Offset = "0x20C3A20", VA = "0x1820C4E20")]
		public void Render(HandBookV2PointData pointData, string htmlColor, bool isForceUnlock)
		{
		}

		// Token: 0x06025D61 RID: 154977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D61")]
		[Address(RVA = "0x20C4FE0", Offset = "0x20C3BE0", VA = "0x1820C4FE0")]
		public HandBookV2MapDotView()
		{
		}

		// Token: 0x04035302 RID: 217858
		[Token(Token = "0x4035302")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2AlphaHexagonView _dotSprite;

		// Token: 0x04035304 RID: 217860
		[Token(Token = "0x4035304")]
		private const float backAlpha = 0.05f;

		// Token: 0x04035305 RID: 217861
		[Token(Token = "0x4035305")]
		private const float dotAlpha = 0.5f;

		// Token: 0x04035306 RID: 217862
		[Token(Token = "0x4035306")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onDotClick;

		// Token: 0x04035307 RID: 217863
		[Token(Token = "0x4035307")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onDotClick;

		// Token: 0x04035308 RID: 217864
		[Token(Token = "0x4035308")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDotClick;

		// Token: 0x04035309 RID: 217865
		[Token(Token = "0x4035309")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderColor;

		// Token: 0x0403530A RID: 217866
		[Token(Token = "0x403530A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403530B RID: 217867
		[Token(Token = "0x403530B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
