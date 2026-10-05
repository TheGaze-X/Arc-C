using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200322D RID: 12845
	[Token(Token = "0x200322D")]
	public class FollowDirection : Effect.Behaviour
	{
		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x060145ED RID: 83437 RVA: 0x000869D0 File Offset: 0x00084BD0
		[Token(Token = "0x17003039")]
		public bool useFaceToInsteadOfFaceVector
		{
			[Token(Token = "0x60145ED")]
			[Address(RVA = "0xC9E0D0", Offset = "0xC9CCD0", VA = "0x180C9E0D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060145EE RID: 83438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145EE")]
		[Address(RVA = "0xC9D5D0", Offset = "0xC9C1D0", VA = "0x180C9D5D0", Slot = "7")]
		public override void OnRecycle()
		{
		}

		// Token: 0x060145EF RID: 83439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145EF")]
		[Address(RVA = "0xC9D560", Offset = "0xC9C160", VA = "0x180C9D560", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145F0 RID: 83440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F0")]
		[Address(RVA = "0xC9D7C0", Offset = "0xC9C3C0", VA = "0x180C9D7C0")]
		private void Update()
		{
		}

		// Token: 0x060145F1 RID: 83441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F1")]
		[Address(RVA = "0xC9D6F0", Offset = "0xC9C2F0", VA = "0x180C9D6F0")]
		private void UpdateDirection()
		{
		}

		// Token: 0x060145F2 RID: 83442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F2")]
		[Address(RVA = "0xC9D830", Offset = "0xC9C430", VA = "0x180C9D830")]
		private void _FollowDirection(Entity entity)
		{
		}

		// Token: 0x060145F3 RID: 83443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F3")]
		[Address(RVA = "0xC9DC70", Offset = "0xC9C870", VA = "0x180C9DC70")]
		private void _LerpDirection(Enemy enemy)
		{
		}

		// Token: 0x060145F4 RID: 83444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F4")]
		[Address(RVA = "0xC9DFB0", Offset = "0xC9CBB0", VA = "0x180C9DFB0")]
		public FollowDirection()
		{
		}

		// Token: 0x060145F5 RID: 83445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F5")]
		[Address(RVA = "0xC9CBA0", Offset = "0xC9B7A0", VA = "0x180C9CBA0")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x060145F6 RID: 83446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145F6")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0401808F RID: 98447
		[Token(Token = "0x401808F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _useFourDir;

		// Token: 0x04018090 RID: 98448
		[Token(Token = "0x4018090")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _useOwnerDirection;

		// Token: 0x04018091 RID: 98449
		[Token(Token = "0x4018091")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _useOwnerMoveDirection;

		// Token: 0x04018092 RID: 98450
		[Token(Token = "0x4018092")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		private bool _leftIsDefault;

		// Token: 0x04018093 RID: 98451
		[Token(Token = "0x4018093")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _useFaceToInsteadOfFaceVector;

		// Token: 0x04018094 RID: 98452
		[Token(Token = "0x4018094")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _useFaceSwitcherFaceLORR;

		// Token: 0x04018095 RID: 98453
		[Token(Token = "0x4018095")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		[Inspect("useFaceToInsteadOfFaceVector")]
		private bool _flipWhenFaceToVertical;

		// Token: 0x04018096 RID: 98454
		[Token(Token = "0x4018096")]
		[FieldOffset(Offset = "0x27")]
		[SerializeField]
		private bool _onlyFollowOnPlay;

		// Token: 0x04018097 RID: 98455
		[Token(Token = "0x4018097")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useDirectionLerp;

		// Token: 0x04018098 RID: 98456
		[Token(Token = "0x4018098")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lerpDuration;

		// Token: 0x04018099 RID: 98457
		[Token(Token = "0x4018099")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 m_sourceDir;

		// Token: 0x0401809A RID: 98458
		[Token(Token = "0x401809A")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 m_targetDir;

		// Token: 0x0401809B RID: 98459
		[Token(Token = "0x401809B")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 m_currDir;

		// Token: 0x0401809C RID: 98460
		[Token(Token = "0x401809C")]
		[FieldOffset(Offset = "0x48")]
		private float m_currTime;

		// Token: 0x0401809D RID: 98461
		[Token(Token = "0x401809D")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isLerping;

		// Token: 0x0401809E RID: 98462
		[Token(Token = "0x401809E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useFaceToInsteadOfFaceVector;

		// Token: 0x0401809F RID: 98463
		[Token(Token = "0x401809F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x040180A0 RID: 98464
		[Token(Token = "0x40180A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040180A1 RID: 98465
		[Token(Token = "0x40180A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040180A2 RID: 98466
		[Token(Token = "0x40180A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateDirection;

		// Token: 0x040180A3 RID: 98467
		[Token(Token = "0x40180A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FollowDirection;

		// Token: 0x040180A4 RID: 98468
		[Token(Token = "0x40180A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LerpDirection;

		// Token: 0x040180A5 RID: 98469
		[Token(Token = "0x40180A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
