using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F27 RID: 20263
	[Token(Token = "0x2004F27")]
	public class FifthAnnivExploreTargetInfoViewModel
	{
		// Token: 0x170046C6 RID: 18118
		// (get) Token: 0x0601E305 RID: 123653 RVA: 0x000ADC28 File Offset: 0x000ABE28
		// (set) Token: 0x0601E304 RID: 123652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046C6")]
		public bool isShow
		{
			[Token(Token = "0x601E305")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E304")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E306 RID: 123654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E306")]
		[Address(RVA = "0x17F2D20", Offset = "0x17F1920", VA = "0x1817F2D20")]
		public void LoadData()
		{
		}

		// Token: 0x0601E307 RID: 123655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E307")]
		[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
		public void SetIsShow(bool isShow)
		{
		}

		// Token: 0x0601E308 RID: 123656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E308")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FifthAnnivExploreTargetInfoViewModel()
		{
		}

		// Token: 0x04028368 RID: 164712
		[Token(Token = "0x4028368")]
		[FieldOffset(Offset = "0x10")]
		public string stageName;

		// Token: 0x04028369 RID: 164713
		[Token(Token = "0x4028369")]
		[FieldOffset(Offset = "0x18")]
		public string stageNum;

		// Token: 0x0402836A RID: 164714
		[Token(Token = "0x402836A")]
		[FieldOffset(Offset = "0x20")]
		public string apNum;

		// Token: 0x0402836B RID: 164715
		[Token(Token = "0x402836B")]
		[FieldOffset(Offset = "0x28")]
		public List<FifthAnnivExploreTargetInfoItemViewModel> itemViewModels;
	}
}
