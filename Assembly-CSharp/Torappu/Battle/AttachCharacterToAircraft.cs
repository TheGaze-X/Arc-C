using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002386 RID: 9094
	[Token(Token = "0x2002386")]
	public class AttachCharacterToAircraft : Tile.Behaviour
	{
		// Token: 0x0600E6B9 RID: 59065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6B9")]
		[Address(RVA = "0x5B5620", Offset = "0x5B4220", VA = "0x1805B5620", Slot = "8")]
		public override void OnEntityLeave(Entity entity)
		{
		}

		// Token: 0x0600E6BA RID: 59066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6BA")]
		[Address(RVA = "0x5B5520", Offset = "0x5B4120", VA = "0x1805B5520", Slot = "7")]
		public override void OnEntityEnter(Entity entity)
		{
		}

		// Token: 0x0600E6BB RID: 59067 RVA: 0x00054150 File Offset: 0x00052350
		[Token(Token = "0x600E6BB")]
		[Address(RVA = "0x5B5720", Offset = "0x5B4320", VA = "0x1805B5720")]
		private bool _CheckGameMode()
		{
			return default(bool);
		}

		// Token: 0x0600E6BC RID: 59068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6BC")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public AttachCharacterToAircraft()
		{
		}
	}
}
