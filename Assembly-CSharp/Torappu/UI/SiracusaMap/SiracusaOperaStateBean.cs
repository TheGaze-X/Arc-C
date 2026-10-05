using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F42 RID: 16194
	[Token(Token = "0x2003F42")]
	public class SiracusaOperaStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06019255 RID: 102997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019255")]
		[Address(RVA = "0x11DD900", Offset = "0x11DC500", VA = "0x1811DD900")]
		public void InitData()
		{
		}

		// Token: 0x06019256 RID: 102998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019256")]
		[Address(RVA = "0x11DDE60", Offset = "0x11DCA60", VA = "0x1811DDE60")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06019257 RID: 102999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019257")]
		[Address(RVA = "0x11DE2C0", Offset = "0x11DCEC0", VA = "0x1811DE2C0")]
		public SiracusaOperaStateBean()
		{
		}

		// Token: 0x0401F276 RID: 127606
		[Token(Token = "0x401F276")]
		[FieldOffset(Offset = "0x10")]
		public List<SiracusaOperaFrameViewModel> viewModelList;

		// Token: 0x0401F277 RID: 127607
		[Token(Token = "0x401F277")]
		[FieldOffset(Offset = "0x18")]
		public int selectIndex;

		// Token: 0x0401F278 RID: 127608
		[Token(Token = "0x401F278")]
		[FieldOffset(Offset = "0x1C")]
		public int totalSelect;

		// Token: 0x0401F279 RID: 127609
		[Token(Token = "0x401F279")]
		[FieldOffset(Offset = "0x20")]
		public int remainSelect;

		// Token: 0x0401F27A RID: 127610
		[Token(Token = "0x401F27A")]
		[FieldOffset(Offset = "0x28")]
		public string selectId;

		// Token: 0x0401F27B RID: 127611
		[Token(Token = "0x401F27B")]
		[FieldOffset(Offset = "0x30")]
		public bool isAllRelease;

		// Token: 0x0401F27C RID: 127612
		[Token(Token = "0x401F27C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401F27D RID: 127613
		[Token(Token = "0x401F27D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0401F27E RID: 127614
		[Token(Token = "0x401F27E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
