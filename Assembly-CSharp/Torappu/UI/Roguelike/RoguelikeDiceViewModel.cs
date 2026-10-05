using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Dice;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051F8 RID: 20984
	[Token(Token = "0x20051F8")]
	public class RoguelikeDiceViewModel : IHotfixable
	{
		// Token: 0x17004853 RID: 18515
		// (get) Token: 0x0601EFA5 RID: 126885 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EFA6 RID: 126886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004853")]
		public string topicId
		{
			[Token(Token = "0x601EFA5")]
			[Address(RVA = "0x18B3A50", Offset = "0x18B2650", VA = "0x1818B3A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EFA6")]
			[Address(RVA = "0x18B3D60", Offset = "0x18B2960", VA = "0x1818B3D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004854 RID: 18516
		// (get) Token: 0x0601EFA7 RID: 126887 RVA: 0x000B04A8 File Offset: 0x000AE6A8
		// (set) Token: 0x0601EFA8 RID: 126888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004854")]
		public RoguelikeDiceModelType diceType
		{
			[Token(Token = "0x601EFA7")]
			[Address(RVA = "0x18B3930", Offset = "0x18B2530", VA = "0x1818B3930")]
			[CompilerGenerated]
			get
			{
				return (RoguelikeDiceModelType)0;
			}
			[Token(Token = "0x601EFA8")]
			[Address(RVA = "0x18B3BF0", Offset = "0x18B27F0", VA = "0x1818B3BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004855 RID: 18517
		// (get) Token: 0x0601EFA9 RID: 126889 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EFAA RID: 126890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004855")]
		public Type typeOfPlugin
		{
			[Token(Token = "0x601EFA9")]
			[Address(RVA = "0x18B3AB0", Offset = "0x18B26B0", VA = "0x1818B3AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EFAA")]
			[Address(RVA = "0x18B3DE0", Offset = "0x18B29E0", VA = "0x1818B3DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x0601EFAB RID: 126891 RVA: 0x000B04C0 File Offset: 0x000AE6C0
		// (set) Token: 0x0601EFAC RID: 126892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004856")]
		public int dicePoints
		{
			[Token(Token = "0x601EFAB")]
			[Address(RVA = "0x18B38D0", Offset = "0x18B24D0", VA = "0x1818B38D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601EFAC")]
			[Address(RVA = "0x18B3B80", Offset = "0x18B2780", VA = "0x1818B3B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x0601EFAD RID: 126893 RVA: 0x000B04D8 File Offset: 0x000AE6D8
		// (set) Token: 0x0601EFAE RID: 126894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004857")]
		public int canRerollCnt
		{
			[Token(Token = "0x601EFAD")]
			[Address(RVA = "0x18B3870", Offset = "0x18B2470", VA = "0x1818B3870")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601EFAE")]
			[Address(RVA = "0x18B3B10", Offset = "0x18B2710", VA = "0x1818B3B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x0601EFAF RID: 126895 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EFB0 RID: 126896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004858")]
		public RoguelikeDiceRuleData ruleData
		{
			[Token(Token = "0x601EFAF")]
			[Address(RVA = "0x18B39F0", Offset = "0x18B25F0", VA = "0x1818B39F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EFB0")]
			[Address(RVA = "0x18B3CE0", Offset = "0x18B28E0", VA = "0x1818B3CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004859 RID: 18521
		// (get) Token: 0x0601EFB1 RID: 126897 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EFB2 RID: 126898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004859")]
		public RoguelikeDiceResultViewModel result
		{
			[Token(Token = "0x601EFB1")]
			[Address(RVA = "0x18B3990", Offset = "0x18B2590", VA = "0x1818B3990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EFB2")]
			[Address(RVA = "0x18B3C60", Offset = "0x18B2860", VA = "0x1818B3C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601EFB3 RID: 126899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFB3")]
		[Address(RVA = "0x18B2DD0", Offset = "0x18B19D0", VA = "0x1818B2DD0")]
		public void Init(string topic, Type pluginType, Dictionary<DiceResultShowType, RoguelikeDiceResultViewBase.DiceResultViewModelCreator> resultViewModelCreators)
		{
		}

		// Token: 0x0601EFB4 RID: 126900 RVA: 0x000B04F0 File Offset: 0x000AE6F0
		[Token(Token = "0x601EFB4")]
		[Address(RVA = "0x18B3170", Offset = "0x18B1D70", VA = "0x1818B3170")]
		public bool LoadResult()
		{
			return default(bool);
		}

		// Token: 0x0601EFB5 RID: 126901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EFB5")]
		[Address(RVA = "0x18B36E0", Offset = "0x18B22E0", VA = "0x1818B36E0")]
		private RoguelikeDiceResultViewModel _LoadResult(PlayerRoguelikePendingEvent.Dice.Result result, RoguelikeDiceRuleData data)
		{
			return null;
		}

		// Token: 0x0601EFB6 RID: 126902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFB6")]
		[Address(RVA = "0x18B3810", Offset = "0x18B2410", VA = "0x1818B3810")]
		public RoguelikeDiceViewModel()
		{
		}

		// Token: 0x0402992F RID: 170287
		[Token(Token = "0x402992F")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<DiceResultShowType, RoguelikeDiceResultViewBase.DiceResultViewModelCreator> m_resultViewModelCreators;

		// Token: 0x04029930 RID: 170288
		[Token(Token = "0x4029930")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04029931 RID: 170289
		[Token(Token = "0x4029931")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04029932 RID: 170290
		[Token(Token = "0x4029932")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_diceType;

		// Token: 0x04029933 RID: 170291
		[Token(Token = "0x4029933")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_diceType;

		// Token: 0x04029934 RID: 170292
		[Token(Token = "0x4029934")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_typeOfPlugin;

		// Token: 0x04029935 RID: 170293
		[Token(Token = "0x4029935")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_typeOfPlugin;

		// Token: 0x04029936 RID: 170294
		[Token(Token = "0x4029936")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_dicePoints;

		// Token: 0x04029937 RID: 170295
		[Token(Token = "0x4029937")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_dicePoints;

		// Token: 0x04029938 RID: 170296
		[Token(Token = "0x4029938")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_canRerollCnt;

		// Token: 0x04029939 RID: 170297
		[Token(Token = "0x4029939")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_canRerollCnt;

		// Token: 0x0402993A RID: 170298
		[Token(Token = "0x402993A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_ruleData;

		// Token: 0x0402993B RID: 170299
		[Token(Token = "0x402993B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_ruleData;

		// Token: 0x0402993C RID: 170300
		[Token(Token = "0x402993C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_result;

		// Token: 0x0402993D RID: 170301
		[Token(Token = "0x402993D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_result;

		// Token: 0x0402993E RID: 170302
		[Token(Token = "0x402993E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402993F RID: 170303
		[Token(Token = "0x402993F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadResult;

		// Token: 0x04029940 RID: 170304
		[Token(Token = "0x4029940")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadResult;

		// Token: 0x04029941 RID: 170305
		[Token(Token = "0x4029941")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
