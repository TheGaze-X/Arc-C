using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005221 RID: 21025
	[Token(Token = "0x2005221")]
	public abstract class RoguelikeDungeonGeneSpZonePluginBase : IHotfixable
	{
		// Token: 0x0601F05A RID: 127066
		[Token(Token = "0x601F05A")]
		public abstract RoguelikeDungeonZone GenSpZoneCurrentDungeonZone(PlayerRoguelikeV2Zone playerZone);

		// Token: 0x0601F05B RID: 127067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F05B")]
		[Address(RVA = "0x18B7B40", Offset = "0x18B6740", VA = "0x1818B7B40")]
		protected RoguelikeDungeonGeneSpZonePluginBase()
		{
		}

		// Token: 0x040299D1 RID: 170449
		[Token(Token = "0x40299D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
