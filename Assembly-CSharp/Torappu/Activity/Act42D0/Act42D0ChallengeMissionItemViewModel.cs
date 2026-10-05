using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007363 RID: 29539
	[Token(Token = "0x2007363")]
	public class Act42D0ChallengeMissionItemViewModel : IHotfixable
	{
		// Token: 0x170062A6 RID: 25254
		// (get) Token: 0x06029C5B RID: 171099 RVA: 0x000D6890 File Offset: 0x000D4A90
		// (set) Token: 0x06029C5C RID: 171100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170062A6")]
		public bool isCompleted
		{
			[Token(Token = "0x6029C5B")]
			[Address(RVA = "0x2555140", Offset = "0x2553D40", VA = "0x182555140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6029C5C")]
			[Address(RVA = "0x25551A0", Offset = "0x2553DA0", VA = "0x1825551A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06029C5D RID: 171101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C5D")]
		[Address(RVA = "0x2555040", Offset = "0x2553C40", VA = "0x182555040")]
		public void SetIsCompleted(bool isCompleted)
		{
		}

		// Token: 0x06029C5E RID: 171102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C5E")]
		[Address(RVA = "0x25550E0", Offset = "0x2553CE0", VA = "0x1825550E0")]
		public Act42D0ChallengeMissionItemViewModel()
		{
		}

		// Token: 0x0403BCD2 RID: 244946
		[Token(Token = "0x403BCD2")]
		[FieldOffset(Offset = "0x10")]
		public Act42D0Data.Act42D0ChallengeMissionData missionData;

		// Token: 0x0403BCD4 RID: 244948
		[Token(Token = "0x403BCD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCompleted;

		// Token: 0x0403BCD5 RID: 244949
		[Token(Token = "0x403BCD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isCompleted;

		// Token: 0x0403BCD6 RID: 244950
		[Token(Token = "0x403BCD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetIsCompleted;

		// Token: 0x0403BCD7 RID: 244951
		[Token(Token = "0x403BCD7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
