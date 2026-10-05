using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B72 RID: 23410
	[Token(Token = "0x2005B72")]
	public class SocialGetCrisisV2ViewModel : IHotfixable
	{
		// Token: 0x06021FCB RID: 139211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FCB")]
		[Address(RVA = "0x1C81780", Offset = "0x1C80380", VA = "0x181C81780")]
		public void LoadData(string seasonId)
		{
		}

		// Token: 0x06021FCC RID: 139212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FCC")]
		[Address(RVA = "0x1C81A30", Offset = "0x1C80630", VA = "0x181C81A30")]
		public SocialGetCrisisV2ViewModel()
		{
		}

		// Token: 0x0402E951 RID: 190801
		[Token(Token = "0x402E951")]
		[FieldOffset(Offset = "0x10")]
		public int totalUsedTime;

		// Token: 0x0402E952 RID: 190802
		[Token(Token = "0x402E952")]
		[FieldOffset(Offset = "0x14")]
		public int highestScore;

		// Token: 0x0402E953 RID: 190803
		[Token(Token = "0x402E953")]
		[FieldOffset(Offset = "0x18")]
		public List<SocialGetCrisisV2ViewModel.CharWithUsedTimes> chars;

		// Token: 0x0402E954 RID: 190804
		[Token(Token = "0x402E954")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402E955 RID: 190805
		[Token(Token = "0x402E955")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005B73 RID: 23411
		[Token(Token = "0x2005B73")]
		public class CharWithUsedTimes : IComparable<SocialGetCrisisV2ViewModel.CharWithUsedTimes>, IHotfixable
		{
			// Token: 0x06021FCD RID: 139213 RVA: 0x000BC220 File Offset: 0x000BA420
			[Token(Token = "0x6021FCD")]
			[Address(RVA = "0x1C6E900", Offset = "0x1C6D500", VA = "0x181C6E900", Slot = "4")]
			public int CompareTo(SocialGetCrisisV2ViewModel.CharWithUsedTimes other)
			{
				return 0;
			}

			// Token: 0x06021FCE RID: 139214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021FCE")]
			[Address(RVA = "0x1C6E9A0", Offset = "0x1C6D5A0", VA = "0x181C6E9A0")]
			public CharWithUsedTimes()
			{
			}

			// Token: 0x0402E956 RID: 190806
			[Token(Token = "0x402E956")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0402E957 RID: 190807
			[Token(Token = "0x402E957")]
			[FieldOffset(Offset = "0x18")]
			public int usedTimes;

			// Token: 0x0402E958 RID: 190808
			[Token(Token = "0x402E958")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x0402E959 RID: 190809
			[Token(Token = "0x402E959")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
