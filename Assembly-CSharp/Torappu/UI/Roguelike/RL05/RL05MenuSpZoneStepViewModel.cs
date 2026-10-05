using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055F4 RID: 22004
	[Token(Token = "0x20055F4")]
	public class RL05MenuSpZoneStepViewModel : RoguelikeMenuCompViewModel
	{
		// Token: 0x060204CA RID: 132298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204CA")]
		[Address(RVA = "0x1A65CE0", Offset = "0x1A648E0", VA = "0x181A65CE0", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x060204CB RID: 132299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204CB")]
		[Address(RVA = "0x1A66070", Offset = "0x1A64C70", VA = "0x181A66070")]
		private void _LoadZoneInfo()
		{
		}

		// Token: 0x060204CC RID: 132300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204CC")]
		[Address(RVA = "0x1A66220", Offset = "0x1A64E20", VA = "0x181A66220")]
		public RL05MenuSpZoneStepViewModel()
		{
		}

		// Token: 0x060204CD RID: 132301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204CD")]
		[Address(RVA = "0x1A629A0", Offset = "0x1A615A0", VA = "0x181A629A0")]
		private void <>xLuaBaseProxy_LoadData(string P0)
		{
		}

		// Token: 0x0402BB6F RID: 179055
		[Token(Token = "0x402BB6F")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402BB70 RID: 179056
		[Token(Token = "0x402BB70")]
		[FieldOffset(Offset = "0x20")]
		public int stepCount;

		// Token: 0x0402BB71 RID: 179057
		[Token(Token = "0x402BB71")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x0402BB72 RID: 179058
		[Token(Token = "0x402BB72")]
		[FieldOffset(Offset = "0x30")]
		public bool isInSpZone;

		// Token: 0x0402BB73 RID: 179059
		[Token(Token = "0x402BB73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BB74 RID: 179060
		[Token(Token = "0x402BB74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadZoneInfo;

		// Token: 0x0402BB75 RID: 179061
		[Token(Token = "0x402BB75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
