using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042C9 RID: 17097
	[Token(Token = "0x20042C9")]
	public class SandboxV2DungeonEventNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4DB RID: 107739 RVA: 0x000A0F38 File Offset: 0x0009F138
		[Token(Token = "0x601A4DB")]
		[Address(RVA = "0x132CF20", Offset = "0x132BB20", VA = "0x18132CF20", Slot = "5")]
		protected override bool IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4DC RID: 107740 RVA: 0x000A0F50 File Offset: 0x0009F150
		[Token(Token = "0x601A4DC")]
		[Address(RVA = "0x132CEC0", Offset = "0x132BAC0", VA = "0x18132CEC0", Slot = "9")]
		protected override SandboxV2EnemyDetailShowType GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0601A4DD RID: 107741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4DD")]
		[Address(RVA = "0x132CF80", Offset = "0x132BB80", VA = "0x18132CF80")]
		public SandboxV2DungeonEventNodeViewModel()
		{
		}

		// Token: 0x0601A4DE RID: 107742 RVA: 0x000A0F68 File Offset: 0x0009F168
		[Token(Token = "0x601A4DE")]
		[Address(RVA = "0x1329670", Offset = "0x1328270", VA = "0x181329670")]
		private bool <>xLuaBaseProxy_IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4DF RID: 107743 RVA: 0x000A0F80 File Offset: 0x0009F180
		[Token(Token = "0x601A4DF")]
		[Address(RVA = "0x132A070", Offset = "0x1328C70", VA = "0x18132A070")]
		private SandboxV2EnemyDetailShowType <>xLuaBaseProxy_GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0402158B RID: 136587
		[Token(Token = "0x402158B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCleared;

		// Token: 0x0402158C RID: 136588
		[Token(Token = "0x402158C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNodeEnemyDetailShowType;

		// Token: 0x0402158D RID: 136589
		[Token(Token = "0x402158D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
