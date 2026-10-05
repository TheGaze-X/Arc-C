using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200325A RID: 12890
	[Token(Token = "0x200325A")]
	public class ScaleAnimationSpeedBehaviour : Effect.Behaviour
	{
		// Token: 0x06014715 RID: 83733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014715")]
		[Address(RVA = "0xCB59C0", Offset = "0xCB45C0", VA = "0x180CB59C0", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014716 RID: 83734 RVA: 0x00086DA8 File Offset: 0x00084FA8
		[Token(Token = "0x6014716")]
		[Address(RVA = "0xCB5BF0", Offset = "0xCB47F0", VA = "0x180CB5BF0")]
		private float _GetSpeed()
		{
			return 0f;
		}

		// Token: 0x06014717 RID: 83735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014717")]
		[Address(RVA = "0xCB5D00", Offset = "0xCB4900", VA = "0x180CB5D00")]
		public ScaleAnimationSpeedBehaviour()
		{
		}

		// Token: 0x06014718 RID: 83736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014718")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x04018266 RID: 98918
		[Token(Token = "0x4018266")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScaleAnimationSpeedBehaviour.ScaleAnimationSpeedBy _scaleBy;

		// Token: 0x04018267 RID: 98919
		[Token(Token = "0x4018267")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _sampledWidth;

		// Token: 0x04018268 RID: 98920
		[Token(Token = "0x4018268")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018269 RID: 98921
		[Token(Token = "0x4018269")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetSpeed;

		// Token: 0x0401826A RID: 98922
		[Token(Token = "0x401826A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200325B RID: 12891
		[Token(Token = "0x200325B")]
		public enum ScaleAnimationSpeedBy
		{
			// Token: 0x0401826C RID: 98924
			[Token(Token = "0x401826C")]
			MAP_TILE_WIDTH
		}
	}
}
