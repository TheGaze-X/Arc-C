using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005841 RID: 22593
	[Token(Token = "0x2005841")]
	public class RL03MenuVisionAndChaosViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x17004D75 RID: 19829
		// (get) Token: 0x0602103E RID: 135230 RVA: 0x000B82A8 File Offset: 0x000B64A8
		[Token(Token = "0x17004D75")]
		public bool havePredict
		{
			[Token(Token = "0x602103E")]
			[Address(RVA = "0x1B4E600", Offset = "0x1B4D200", VA = "0x181B4E600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D76 RID: 19830
		// (get) Token: 0x0602103F RID: 135231 RVA: 0x000B82C0 File Offset: 0x000B64C0
		[Token(Token = "0x17004D76")]
		public int curChaosLevel
		{
			[Token(Token = "0x602103F")]
			[Address(RVA = "0x1B4E590", Offset = "0x1B4D190", VA = "0x181B4E590")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004D77 RID: 19831
		// (get) Token: 0x06021040 RID: 135232 RVA: 0x000B82D8 File Offset: 0x000B64D8
		[Token(Token = "0x17004D77")]
		public int maxChaosLevel
		{
			[Token(Token = "0x6021040")]
			[Address(RVA = "0x1B4E680", Offset = "0x1B4D280", VA = "0x181B4E680")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004D78 RID: 19832
		// (get) Token: 0x06021041 RID: 135233 RVA: 0x000B82F0 File Offset: 0x000B64F0
		[Token(Token = "0x17004D78")]
		public int sightNum
		{
			[Token(Token = "0x6021041")]
			[Address(RVA = "0x1B4E760", Offset = "0x1B4D360", VA = "0x181B4E760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004D79 RID: 19833
		// (get) Token: 0x06021042 RID: 135234 RVA: 0x000B8308 File Offset: 0x000B6508
		[Token(Token = "0x17004D79")]
		public int maxSightNum
		{
			[Token(Token = "0x6021042")]
			[Address(RVA = "0x1B4E6F0", Offset = "0x1B4D2F0", VA = "0x181B4E6F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021043 RID: 135235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021043")]
		[Address(RVA = "0x1B4E150", Offset = "0x1B4CD50", VA = "0x181B4E150", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x06021044 RID: 135236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021044")]
		[Address(RVA = "0x1B4E480", Offset = "0x1B4D080", VA = "0x181B4E480")]
		public RL03MenuVisionAndChaosViewModel()
		{
		}

		// Token: 0x06021045 RID: 135237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021045")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402CE71 RID: 183921
		[Token(Token = "0x402CE71")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402CE72 RID: 183922
		[Token(Token = "0x402CE72")]
		[FieldOffset(Offset = "0x20")]
		public string curZoneId;

		// Token: 0x0402CE73 RID: 183923
		[Token(Token = "0x402CE73")]
		[FieldOffset(Offset = "0x28")]
		public string curZoneName;

		// Token: 0x0402CE74 RID: 183924
		[Token(Token = "0x402CE74")]
		[FieldOffset(Offset = "0x30")]
		public string curZoneIconId;

		// Token: 0x0402CE75 RID: 183925
		[Token(Token = "0x402CE75")]
		[FieldOffset(Offset = "0x38")]
		public RL03MenuVisionAndChaosViewModel.VCWindowViewModel windowViewModel;

		// Token: 0x0402CE76 RID: 183926
		[Token(Token = "0x402CE76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_havePredict;

		// Token: 0x0402CE77 RID: 183927
		[Token(Token = "0x402CE77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curChaosLevel;

		// Token: 0x0402CE78 RID: 183928
		[Token(Token = "0x402CE78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxChaosLevel;

		// Token: 0x0402CE79 RID: 183929
		[Token(Token = "0x402CE79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sightNum;

		// Token: 0x0402CE7A RID: 183930
		[Token(Token = "0x402CE7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxSightNum;

		// Token: 0x0402CE7B RID: 183931
		[Token(Token = "0x402CE7B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CE7C RID: 183932
		[Token(Token = "0x402CE7C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005842 RID: 22594
		[Token(Token = "0x2005842")]
		public class VCWindowViewModel
		{
			// Token: 0x17004D7A RID: 19834
			// (get) Token: 0x06021046 RID: 135238 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06021047 RID: 135239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004D7A")]
			public string topicId
			{
				[Token(Token = "0x6021046")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6021047")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06021048 RID: 135240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021048")]
			[Address(RVA = "0x1B594D0", Offset = "0x1B580D0", VA = "0x181B594D0")]
			private void _Reset()
			{
			}

			// Token: 0x06021049 RID: 135241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021049")]
			[Address(RVA = "0x1B58D40", Offset = "0x1B57940", VA = "0x181B58D40")]
			public void Load(string topic, PlayerRoguelikeV2.CurrentData currentData, RoguelikeModule moduleData)
			{
			}

			// Token: 0x0602104A RID: 135242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602104A")]
			[Address(RVA = "0x1B59600", Offset = "0x1B58200", VA = "0x181B59600")]
			public VCWindowViewModel()
			{
			}

			// Token: 0x0402CE7E RID: 183934
			[Token(Token = "0x402CE7E")]
			[FieldOffset(Offset = "0x18")]
			public int visionLevel;

			// Token: 0x0402CE7F RID: 183935
			[Token(Token = "0x402CE7F")]
			[FieldOffset(Offset = "0x1C")]
			public int maxVisionLvl;

			// Token: 0x0402CE80 RID: 183936
			[Token(Token = "0x402CE80")]
			[FieldOffset(Offset = "0x20")]
			public string visionStatusIcon;

			// Token: 0x0402CE81 RID: 183937
			[Token(Token = "0x402CE81")]
			[FieldOffset(Offset = "0x28")]
			public string visionStatus;

			// Token: 0x0402CE82 RID: 183938
			[Token(Token = "0x402CE82")]
			[FieldOffset(Offset = "0x30")]
			public Color visionStatusClr;

			// Token: 0x0402CE83 RID: 183939
			[Token(Token = "0x402CE83")]
			[FieldOffset(Offset = "0x40")]
			public string visionDesc1;

			// Token: 0x0402CE84 RID: 183940
			[Token(Token = "0x402CE84")]
			[FieldOffset(Offset = "0x48")]
			public string visionDesc2;

			// Token: 0x0402CE85 RID: 183941
			[Token(Token = "0x402CE85")]
			[FieldOffset(Offset = "0x50")]
			public int chaosLevel;

			// Token: 0x0402CE86 RID: 183942
			[Token(Token = "0x402CE86")]
			[FieldOffset(Offset = "0x54")]
			public int chaosMaxLevel;

			// Token: 0x0402CE87 RID: 183943
			[Token(Token = "0x402CE87")]
			[FieldOffset(Offset = "0x58")]
			public int chaosValue;

			// Token: 0x0402CE88 RID: 183944
			[Token(Token = "0x402CE88")]
			[FieldOffset(Offset = "0x5C")]
			public int chaosMaxValue;

			// Token: 0x0402CE89 RID: 183945
			[Token(Token = "0x402CE89")]
			[FieldOffset(Offset = "0x60")]
			public string chaosValueTips;

			// Token: 0x0402CE8A RID: 183946
			[Token(Token = "0x402CE8A")]
			[FieldOffset(Offset = "0x68")]
			public List<RL03MenuVisionAndChaosViewModel.VCWindowViewModel.ChaosItemModel> chaosItems;

			// Token: 0x0402CE8B RID: 183947
			[Token(Token = "0x402CE8B")]
			[FieldOffset(Offset = "0x70")]
			public string predictChaosName;

			// Token: 0x0402CE8C RID: 183948
			[Token(Token = "0x402CE8C")]
			[FieldOffset(Offset = "0x78")]
			public string predictChaosDesc;

			// Token: 0x0402CE8D RID: 183949
			[Token(Token = "0x402CE8D")]
			[FieldOffset(Offset = "0x80")]
			public string zoneBuffDesc;

			// Token: 0x02005843 RID: 22595
			[Token(Token = "0x2005843")]
			public struct ChaosItemModel
			{
				// Token: 0x0602104B RID: 135243 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602104B")]
				[Address(RVA = "0x1B44800", Offset = "0x1B43400", VA = "0x181B44800")]
				public void Reset()
				{
				}

				// Token: 0x0402CE8E RID: 183950
				[Token(Token = "0x402CE8E")]
				[FieldOffset(Offset = "0x0")]
				public string iconId;

				// Token: 0x0402CE8F RID: 183951
				[Token(Token = "0x402CE8F")]
				[FieldOffset(Offset = "0x8")]
				public string name;

				// Token: 0x0402CE90 RID: 183952
				[Token(Token = "0x402CE90")]
				[FieldOffset(Offset = "0x10")]
				public int level;

				// Token: 0x0402CE91 RID: 183953
				[Token(Token = "0x402CE91")]
				[FieldOffset(Offset = "0x18")]
				public string desc;
			}
		}
	}
}
