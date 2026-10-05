using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F2C RID: 28460
	[Token(Token = "0x2006F2C")]
	public class ActMultiV3EntrySquadViewModel : IHotfixable
	{
		// Token: 0x17005F5F RID: 24415
		// (get) Token: 0x060286D9 RID: 165593 RVA: 0x000D1C58 File Offset: 0x000CFE58
		[Token(Token = "0x17005F5F")]
		public bool showTrackPoint
		{
			[Token(Token = "0x60286D9")]
			[Address(RVA = "0x23AF3D0", Offset = "0x23ADFD0", VA = "0x1823AF3D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060286DA RID: 165594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286DA")]
		[Address(RVA = "0x23AF140", Offset = "0x23ADD40", VA = "0x1823AF140")]
		public void LoadData(string actId, ActMultiV3Data actData)
		{
		}

		// Token: 0x060286DB RID: 165595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286DB")]
		[Address(RVA = "0x23AF330", Offset = "0x23ADF30", VA = "0x1823AF330")]
		public ActMultiV3EntrySquadViewModel()
		{
		}

		// Token: 0x040397FB RID: 235515
		[Token(Token = "0x40397FB")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3SquadEffectTrackPointModel squadEffectTrackPoint;

		// Token: 0x040397FC RID: 235516
		[Token(Token = "0x40397FC")]
		[FieldOffset(Offset = "0x18")]
		public bool hasNewUnlockedSquad;

		// Token: 0x040397FD RID: 235517
		[Token(Token = "0x40397FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showTrackPoint;

		// Token: 0x040397FE RID: 235518
		[Token(Token = "0x40397FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040397FF RID: 235519
		[Token(Token = "0x40397FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
