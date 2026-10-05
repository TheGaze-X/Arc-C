using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x020013A8 RID: 5032
	[Token(Token = "0x20013A8")]
	[Serializable]
	public class EquipTalentData : TalentData
	{
		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x0600738F RID: 29583 RVA: 0x00033630 File Offset: 0x00031830
		[Token(Token = "0x17000E22")]
		[JsonIgnore]
		public override bool displayRange
		{
			[Token(Token = "0x600738F")]
			[Address(RVA = "0x2205E70", Offset = "0x2204A70", VA = "0x182205E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007390")]
		[Address(RVA = "0x2205C60", Offset = "0x2204860", VA = "0x182205C60", Slot = "5")]
		public override string GetDescription()
		{
			return null;
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007391")]
		[Address(RVA = "0x2205DD0", Offset = "0x22049D0", VA = "0x182205DD0")]
		public EquipTalentData()
		{
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x00033648 File Offset: 0x00031848
		[Token(Token = "0x6007392")]
		[Address(RVA = "0x2205D70", Offset = "0x2204970", VA = "0x182205D70")]
		private bool <>xLuaBaseProxy_get_displayRange()
		{
			return default(bool);
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007393")]
		[Address(RVA = "0x2205D10", Offset = "0x2204910", VA = "0x182205D10")]
		private string <>xLuaBaseProxy_GetDescription()
		{
			return null;
		}

		// Token: 0x04006FDF RID: 28639
		[Token(Token = "0x4006FDF")]
		[FieldOffset(Offset = "0x58")]
		public bool displayRangeId;

		// Token: 0x04006FE0 RID: 28640
		[Token(Token = "0x4006FE0")]
		[FieldOffset(Offset = "0x60")]
		public string upgradeDescription;

		// Token: 0x04006FE1 RID: 28641
		[Token(Token = "0x4006FE1")]
		[FieldOffset(Offset = "0x68")]
		public int talentIndex;

		// Token: 0x04006FE2 RID: 28642
		[Token(Token = "0x4006FE2")]
		[FieldOffset(Offset = "0x70")]
		public int[] validModeIndices;

		// Token: 0x04006FE3 RID: 28643
		[Token(Token = "0x4006FE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayRange;

		// Token: 0x04006FE4 RID: 28644
		[Token(Token = "0x4006FE4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDescription;

		// Token: 0x04006FE5 RID: 28645
		[Token(Token = "0x4006FE5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
