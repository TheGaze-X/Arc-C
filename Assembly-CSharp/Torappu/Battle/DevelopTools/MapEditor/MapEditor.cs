using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.DevelopTools.MapEditor
{
	// Token: 0x020028AA RID: 10410
	[Token(Token = "0x20028AA")]
	public class MapEditor : SingletonMonoBehaviour<MapEditor>
	{
		// Token: 0x060114FC RID: 70908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114FC")]
		[Address(RVA = "0x921AE0", Offset = "0x9206E0", VA = "0x180921AE0")]
		public MapEditor()
		{
		}

		// Token: 0x04013579 RID: 79225
		[Token(Token = "0x4013579")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ToolsGroup]
		private BattleFactory _factory;

		// Token: 0x0401357A RID: 79226
		[Token(Token = "0x401357A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ToolsGroup]
		private string _mapId;

		// Token: 0x0401357B RID: 79227
		[Token(Token = "0x401357B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
