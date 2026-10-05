using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D10 RID: 7440
	[Token(Token = "0x2001D10")]
	public interface IMeetingStationaryCharacter : IHotfixable
	{
		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x0600B79B RID: 47003
		[Token(Token = "0x17001615")]
		string name { [Token(Token = "0x600B79B")] get; }

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x0600B79C RID: 47004
		[Token(Token = "0x17001616")]
		SpriteRenderData portrait { [Token(Token = "0x600B79C")] get; }

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x0600B79D RID: 47005
		[Token(Token = "0x17001617")]
		Sprite face { [Token(Token = "0x600B79D")] get; }

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600B79E RID: 47006
		[Token(Token = "0x17001618")]
		IMeetingBuildingBuff buildingBuff { [Token(Token = "0x600B79E")] get; }

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600B79F RID: 47007
		[Token(Token = "0x17001619")]
		BuildingCharModel charModel { [Token(Token = "0x600B79F")] get; }
	}
}
