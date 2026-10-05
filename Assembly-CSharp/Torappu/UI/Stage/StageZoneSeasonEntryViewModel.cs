using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068B7 RID: 26807
	[Token(Token = "0x20068B7")]
	public abstract class StageZoneSeasonEntryViewModel : IHotfixable
	{
		// Token: 0x06026675 RID: 157301
		[Token(Token = "0x6026675")]
		public abstract void InitData();

		// Token: 0x06026676 RID: 157302
		[Token(Token = "0x6026676")]
		public abstract bool HasActiveSeason();

		// Token: 0x06026677 RID: 157303 RVA: 0x000CAE30 File Offset: 0x000C9030
		[Token(Token = "0x6026677")]
		[Address(RVA = "0x217BD60", Offset = "0x217A960", VA = "0x18217BD60", Slot = "6")]
		public virtual bool CheckIfEnabled()
		{
			return default(bool);
		}

		// Token: 0x06026678 RID: 157304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026678")]
		[Address(RVA = "0x218CC50", Offset = "0x218B850", VA = "0x18218CC50")]
		protected StageZoneSeasonEntryViewModel()
		{
		}

		// Token: 0x0403617C RID: 221564
		[Token(Token = "0x403617C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfEnabled;

		// Token: 0x0403617D RID: 221565
		[Token(Token = "0x403617D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
