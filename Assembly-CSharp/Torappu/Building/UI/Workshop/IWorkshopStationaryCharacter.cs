using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001C00 RID: 7168
	[Token(Token = "0x2001C00")]
	public interface IWorkshopStationaryCharacter
	{
		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x0600B2A4 RID: 45732
		[Token(Token = "0x17001568")]
		string charId { [Token(Token = "0x600B2A4")] get; }

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x0600B2A5 RID: 45733
		[Token(Token = "0x17001569")]
		string name { [Token(Token = "0x600B2A5")] get; }

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x0600B2A6 RID: 45734
		[Token(Token = "0x1700156A")]
		SpriteRenderData portrait { [Token(Token = "0x600B2A6")] get; }

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x0600B2A7 RID: 45735
		[Token(Token = "0x1700156B")]
		long manpower { [Token(Token = "0x600B2A7")] get; }

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x0600B2A8 RID: 45736
		[Token(Token = "0x1700156C")]
		int mood { [Token(Token = "0x600B2A8")] get; }

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x0600B2A9 RID: 45737
		[Token(Token = "0x1700156D")]
		int maxMood { [Token(Token = "0x600B2A9")] get; }

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x0600B2AA RID: 45738
		[Token(Token = "0x1700156E")]
		CharManpowerState mpState { [Token(Token = "0x600B2AA")] get; }

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x0600B2AB RID: 45739
		[Token(Token = "0x1700156F")]
		IWorkshopBuildingBuff buildingBuff { [Token(Token = "0x600B2AB")] get; }
	}
}
