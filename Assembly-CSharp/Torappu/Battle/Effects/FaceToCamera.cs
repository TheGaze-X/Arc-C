using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003228 RID: 12840
	[Token(Token = "0x2003228")]
	public class FaceToCamera : Effect.Behaviour
	{
		// Token: 0x060145D5 RID: 83413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D5")]
		[Address(RVA = "0xC9BC80", Offset = "0xC9A880", VA = "0x180C9BC80", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145D6 RID: 83414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D6")]
		[Address(RVA = "0xC9BCE0", Offset = "0xC9A8E0", VA = "0x180C9BCE0")]
		private void Update()
		{
		}

		// Token: 0x060145D7 RID: 83415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D7")]
		[Address(RVA = "0xC9BD50", Offset = "0xC9A950", VA = "0x180C9BD50")]
		private void _FaceToCamera()
		{
		}

		// Token: 0x060145D8 RID: 83416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D8")]
		[Address(RVA = "0xC9BE20", Offset = "0xC9AA20", VA = "0x180C9BE20")]
		public FaceToCamera()
		{
		}

		// Token: 0x060145D9 RID: 83417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145D9")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0401806A RID: 98410
		[Token(Token = "0x401806A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _onlyFaceOnPlay;

		// Token: 0x0401806B RID: 98411
		[Token(Token = "0x401806B")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _onlyRotateX;

		// Token: 0x0401806C RID: 98412
		[Token(Token = "0x401806C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401806D RID: 98413
		[Token(Token = "0x401806D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401806E RID: 98414
		[Token(Token = "0x401806E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FaceToCamera;

		// Token: 0x0401806F RID: 98415
		[Token(Token = "0x401806F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
