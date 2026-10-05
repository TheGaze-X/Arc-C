using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200703D RID: 28733
	[Token(Token = "0x200703D")]
	public class ActMultiV3PrepareMainCharCardModel : IHotfixable
	{
		// Token: 0x17006061 RID: 24673
		// (get) Token: 0x06028C9F RID: 167071 RVA: 0x000D3020 File Offset: 0x000D1220
		// (set) Token: 0x06028CA0 RID: 167072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006061")]
		public int innerInstId
		{
			[Token(Token = "0x6028C9F")]
			[Address(RVA = "0x24326D0", Offset = "0x24312D0", VA = "0x1824326D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028CA0")]
			[Address(RVA = "0x2432810", Offset = "0x2431410", VA = "0x182432810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006062 RID: 24674
		// (get) Token: 0x06028CA1 RID: 167073 RVA: 0x000D3038 File Offset: 0x000D1238
		// (set) Token: 0x06028CA2 RID: 167074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006062")]
		public ActMultiV3IdentityType identityType
		{
			[Token(Token = "0x6028CA1")]
			[Address(RVA = "0x2432670", Offset = "0x2431270", VA = "0x182432670")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3IdentityType.NONE;
			}
			[Token(Token = "0x6028CA2")]
			[Address(RVA = "0x24327A0", Offset = "0x24313A0", VA = "0x1824327A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006063 RID: 24675
		// (get) Token: 0x06028CA3 RID: 167075 RVA: 0x000D3050 File Offset: 0x000D1250
		[Token(Token = "0x17006063")]
		public bool isEmpty
		{
			[Token(Token = "0x6028CA3")]
			[Address(RVA = "0x2432730", Offset = "0x2431330", VA = "0x182432730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028CA4 RID: 167076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CA4")]
		[Address(RVA = "0x2432480", Offset = "0x2431080", VA = "0x182432480")]
		public void Load(int instId, ActMultiV3CharViewModel cardViewModel, ActMultiV3IdentityType iType, bool showSkillAndEquip)
		{
		}

		// Token: 0x06028CA5 RID: 167077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CA5")]
		[Address(RVA = "0x24325C0", Offset = "0x24311C0", VA = "0x1824325C0")]
		public ActMultiV3PrepareMainCharCardModel()
		{
		}

		// Token: 0x0403A27B RID: 238203
		[Token(Token = "0x403A27B")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3CharCardBase.Param baseParam;

		// Token: 0x0403A27C RID: 238204
		[Token(Token = "0x403A27C")]
		[FieldOffset(Offset = "0x20")]
		public int skipNum;

		// Token: 0x0403A27D RID: 238205
		[Token(Token = "0x403A27D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_innerInstId;

		// Token: 0x0403A27E RID: 238206
		[Token(Token = "0x403A27E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_innerInstId;

		// Token: 0x0403A27F RID: 238207
		[Token(Token = "0x403A27F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_identityType;

		// Token: 0x0403A280 RID: 238208
		[Token(Token = "0x403A280")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_identityType;

		// Token: 0x0403A281 RID: 238209
		[Token(Token = "0x403A281")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403A282 RID: 238210
		[Token(Token = "0x403A282")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0403A283 RID: 238211
		[Token(Token = "0x403A283")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
