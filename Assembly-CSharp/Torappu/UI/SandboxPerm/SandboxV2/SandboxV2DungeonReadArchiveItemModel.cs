using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041B4 RID: 16820
	[Token(Token = "0x20041B4")]
	public class SandboxV2DungeonReadArchiveItemModel : IHotfixable
	{
		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x06019F03 RID: 106243 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019F04 RID: 106244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DC4")]
		public string dayTitle
		{
			[Token(Token = "0x6019F03")]
			[Address(RVA = "0x12DFE30", Offset = "0x12DEA30", VA = "0x1812DFE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019F04")]
			[Address(RVA = "0x12DFFB0", Offset = "0x12DEBB0", VA = "0x1812DFFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x06019F05 RID: 106245 RVA: 0x0009FC60 File Offset: 0x0009DE60
		// (set) Token: 0x06019F06 RID: 106246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DC5")]
		public int day
		{
			[Token(Token = "0x6019F05")]
			[Address(RVA = "0x12DFE90", Offset = "0x12DEA90", VA = "0x1812DFE90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019F06")]
			[Address(RVA = "0x12E0030", Offset = "0x12DEC30", VA = "0x1812E0030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x06019F07 RID: 106247 RVA: 0x0009FC78 File Offset: 0x0009DE78
		// (set) Token: 0x06019F08 RID: 106248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DC6")]
		public int maxAp
		{
			[Token(Token = "0x6019F07")]
			[Address(RVA = "0x12DFEF0", Offset = "0x12DEAF0", VA = "0x1812DFEF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019F08")]
			[Address(RVA = "0x12E00A0", Offset = "0x12DECA0", VA = "0x1812E00A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x06019F09 RID: 106249 RVA: 0x0009FC90 File Offset: 0x0009DE90
		// (set) Token: 0x06019F0A RID: 106250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DC7")]
		public float seasonShowAngle
		{
			[Token(Token = "0x6019F09")]
			[Address(RVA = "0x12DFF50", Offset = "0x12DEB50", VA = "0x1812DFF50")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6019F0A")]
			[Address(RVA = "0x12E0110", Offset = "0x12DED10", VA = "0x1812E0110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019F0B RID: 106251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F0B")]
		[Address(RVA = "0x12DFA90", Offset = "0x12DE690", VA = "0x1812DFA90")]
		public void LoadData(PlayerSandboxV2.Save saveInfo, SandboxV2GameConst gameConst)
		{
		}

		// Token: 0x06019F0C RID: 106252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F0C")]
		[Address(RVA = "0x12DFDD0", Offset = "0x12DE9D0", VA = "0x1812DFDD0")]
		public SandboxV2DungeonReadArchiveItemModel()
		{
		}

		// Token: 0x04020A86 RID: 133766
		[Token(Token = "0x4020A86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dayTitle;

		// Token: 0x04020A87 RID: 133767
		[Token(Token = "0x4020A87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dayTitle;

		// Token: 0x04020A88 RID: 133768
		[Token(Token = "0x4020A88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_day;

		// Token: 0x04020A89 RID: 133769
		[Token(Token = "0x4020A89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_day;

		// Token: 0x04020A8A RID: 133770
		[Token(Token = "0x4020A8A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxAp;

		// Token: 0x04020A8B RID: 133771
		[Token(Token = "0x4020A8B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_maxAp;

		// Token: 0x04020A8C RID: 133772
		[Token(Token = "0x4020A8C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_seasonShowAngle;

		// Token: 0x04020A8D RID: 133773
		[Token(Token = "0x4020A8D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_seasonShowAngle;

		// Token: 0x04020A8E RID: 133774
		[Token(Token = "0x4020A8E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04020A8F RID: 133775
		[Token(Token = "0x4020A8F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
