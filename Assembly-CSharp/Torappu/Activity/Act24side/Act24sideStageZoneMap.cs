using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007559 RID: 30041
	[Token(Token = "0x2007559")]
	public class Act24sideStageZoneMap : StageMainZoneMapPlugin
	{
		// Token: 0x0602A4E0 RID: 173280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4E0")]
		[Address(RVA = "0x2602A80", Offset = "0x2601680", VA = "0x182602A80", Slot = "5")]
		public override void OnMapPositionChanged(StageMainZoneMapPlugin.MapPosInfo posInfo)
		{
		}

		// Token: 0x0602A4E1 RID: 173281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4E1")]
		[Address(RVA = "0x2602B80", Offset = "0x2601780", VA = "0x182602B80")]
		public Act24sideStageZoneMap()
		{
		}

		// Token: 0x0602A4E2 RID: 173282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4E2")]
		[Address(RVA = "0x21FDB40", Offset = "0x21FC740", VA = "0x1821FDB40")]
		private void <>xLuaBaseProxy_OnMapPositionChanged(StageMainZoneMapPlugin.MapPosInfo P0)
		{
		}

		// Token: 0x0403CD39 RID: 249145
		[Token(Token = "0x403CD39")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _cloudSpeed;

		// Token: 0x0403CD3A RID: 249146
		[Token(Token = "0x403CD3A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _mountainSpeed;

		// Token: 0x0403CD3B RID: 249147
		[Token(Token = "0x403CD3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cloudRect;

		// Token: 0x0403CD3C RID: 249148
		[Token(Token = "0x403CD3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _mountainRect;

		// Token: 0x0403CD3D RID: 249149
		[Token(Token = "0x403CD3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMapPositionChanged;

		// Token: 0x0403CD3E RID: 249150
		[Token(Token = "0x403CD3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
