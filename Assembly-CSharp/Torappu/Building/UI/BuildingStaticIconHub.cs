using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B41 RID: 6977
	[Token(Token = "0x2001B41")]
	public class BuildingStaticIconHub : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AF7F RID: 44927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AF7F")]
		[Address(RVA = "0x32A65D0", Offset = "0x32A51D0", VA = "0x1832A65D0")]
		public Sprite GetIcon(BuildingStaticIconHub.IconType type)
		{
			return null;
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF80")]
		[Address(RVA = "0x32A6680", Offset = "0x32A5280", VA = "0x1832A6680")]
		public BuildingStaticIconHub()
		{
		}

		// Token: 0x0400A925 RID: 43301
		[Token(Token = "0x400A925")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("RoomTitle")]
		private Sprite _iconWorkshop;

		// Token: 0x0400A926 RID: 43302
		[Token(Token = "0x400A926")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("RoomTitle")]
		private Sprite _iconManufact;

		// Token: 0x0400A927 RID: 43303
		[Token(Token = "0x400A927")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("ResMenu")]
		private Sprite _iconGold;

		// Token: 0x0400A928 RID: 43304
		[Token(Token = "0x400A928")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIcon;

		// Token: 0x0400A929 RID: 43305
		[Token(Token = "0x400A929")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B42 RID: 6978
		[Token(Token = "0x2001B42")]
		public enum IconType
		{
			// Token: 0x0400A92B RID: 43307
			[Token(Token = "0x400A92B")]
			NONE,
			// Token: 0x0400A92C RID: 43308
			[Token(Token = "0x400A92C")]
			WORKSHOP,
			// Token: 0x0400A92D RID: 43309
			[Token(Token = "0x400A92D")]
			MANUFACT,
			// Token: 0x0400A92E RID: 43310
			[Token(Token = "0x400A92E")]
			GOLD = 10
		}
	}
}
