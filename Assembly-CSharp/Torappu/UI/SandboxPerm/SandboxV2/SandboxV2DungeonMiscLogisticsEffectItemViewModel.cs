using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042A4 RID: 17060
	[Token(Token = "0x20042A4")]
	public class SandboxV2DungeonMiscLogisticsEffectItemViewModel : IComparable<SandboxV2DungeonMiscLogisticsEffectItemViewModel>, IHotfixable
	{
		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x0601A452 RID: 107602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E57")]
		public string desc
		{
			[Token(Token = "0x601A452")]
			[Address(RVA = "0x1330820", Offset = "0x132F420", VA = "0x181330820")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A453 RID: 107603 RVA: 0x000A0A58 File Offset: 0x0009EC58
		[Token(Token = "0x601A453")]
		[Address(RVA = "0x1330690", Offset = "0x132F290", VA = "0x181330690", Slot = "4")]
		public int CompareTo(SandboxV2DungeonMiscLogisticsEffectItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A454 RID: 107604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A454")]
		[Address(RVA = "0x1330710", Offset = "0x132F310", VA = "0x181330710")]
		public void LoadData(SandboxV2LogisticsData logisticsData)
		{
		}

		// Token: 0x0601A455 RID: 107605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A455")]
		[Address(RVA = "0x13307C0", Offset = "0x132F3C0", VA = "0x1813307C0")]
		public SandboxV2DungeonMiscLogisticsEffectItemViewModel()
		{
		}

		// Token: 0x04021455 RID: 136277
		[Token(Token = "0x4021455")]
		[FieldOffset(Offset = "0x10")]
		public ProfessionCategory profession;

		// Token: 0x04021456 RID: 136278
		[Token(Token = "0x4021456")]
		[FieldOffset(Offset = "0x14")]
		public int sortId;

		// Token: 0x04021457 RID: 136279
		[Token(Token = "0x4021457")]
		[FieldOffset(Offset = "0x18")]
		public string baseDesc;

		// Token: 0x04021458 RID: 136280
		[Token(Token = "0x4021458")]
		[FieldOffset(Offset = "0x20")]
		public string[] levelParams;

		// Token: 0x04021459 RID: 136281
		[Token(Token = "0x4021459")]
		[FieldOffset(Offset = "0x28")]
		public int charBeanCount;

		// Token: 0x0402145A RID: 136282
		[Token(Token = "0x402145A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402145B RID: 136283
		[Token(Token = "0x402145B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402145C RID: 136284
		[Token(Token = "0x402145C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402145D RID: 136285
		[Token(Token = "0x402145D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
