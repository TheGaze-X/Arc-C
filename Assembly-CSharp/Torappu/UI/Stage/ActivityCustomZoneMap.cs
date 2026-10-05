using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068D6 RID: 26838
	[Token(Token = "0x20068D6")]
	public class ActivityCustomZoneMap : MonoBehaviour, IActivityCustomZoneMap, IHotfixable
	{
		// Token: 0x17005AD3 RID: 23251
		// (get) Token: 0x06026745 RID: 157509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AD3")]
		public ActivityCustomZoneStageButton[] stageButtons
		{
			[Token(Token = "0x6026745")]
			[Address(RVA = "0x2177590", Offset = "0x2176190", VA = "0x182177590", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005AD4 RID: 23252
		// (get) Token: 0x06026746 RID: 157510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AD4")]
		public ActivityCustomZoneMapBasePlugin[] plugins
		{
			[Token(Token = "0x6026746")]
			[Address(RVA = "0x2177530", Offset = "0x2176130", VA = "0x182177530")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026747 RID: 157511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026747")]
		[Address(RVA = "0x2177200", Offset = "0x2175E00", VA = "0x182177200", Slot = "4")]
		public void Render(ActivityCustomZoneMapViewModel model, bool isFastMode)
		{
		}

		// Token: 0x06026748 RID: 157512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026748")]
		[Address(RVA = "0x21774D0", Offset = "0x21760D0", VA = "0x1821774D0")]
		public ActivityCustomZoneMap()
		{
		}

		// Token: 0x040362D7 RID: 221911
		[Token(Token = "0x40362D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActivityCustomZoneMapBasePlugin[] _plugins;

		// Token: 0x040362D8 RID: 221912
		[Token(Token = "0x40362D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityCustomZoneStageButton[] _stageButtons;

		// Token: 0x040362D9 RID: 221913
		[Token(Token = "0x40362D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageButtons;

		// Token: 0x040362DA RID: 221914
		[Token(Token = "0x40362DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_plugins;

		// Token: 0x040362DB RID: 221915
		[Token(Token = "0x40362DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040362DC RID: 221916
		[Token(Token = "0x40362DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
