using System;
using Il2CppDummyDll;
using Torappu.UI.MissionArchive;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F07 RID: 20231
	[Token(Token = "0x2004F07")]
	public class FifthAnnivMissionArchiveExteriorPlayer : MissionArchiveExteriorPlayer
	{
		// Token: 0x0601E287 RID: 123527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E287")]
		[Address(RVA = "0x17DC2D0", Offset = "0x17DAED0", VA = "0x1817DC2D0", Slot = "4")]
		public override void Init(MissionArchiveController controller)
		{
		}

		// Token: 0x0601E288 RID: 123528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E288")]
		[Address(RVA = "0x17DC620", Offset = "0x17DB220", VA = "0x1817DC620", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x0601E289 RID: 123529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E289")]
		[Address(RVA = "0x17DC590", Offset = "0x17DB190", VA = "0x1817DC590", Slot = "6")]
		public override void Play(bool isHidden)
		{
		}

		// Token: 0x0601E28A RID: 123530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E28A")]
		[Address(RVA = "0x17DC6B0", Offset = "0x17DB2B0", VA = "0x1817DC6B0", Slot = "7")]
		public override void Stop()
		{
		}

		// Token: 0x0601E28B RID: 123531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E28B")]
		[Address(RVA = "0x17DC4C0", Offset = "0x17DB0C0", VA = "0x1817DC4C0", Slot = "8")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0601E28C RID: 123532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E28C")]
		[Address(RVA = "0x17DC3F0", Offset = "0x17DAFF0", VA = "0x1817DC3F0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601E28D RID: 123533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E28D")]
		[Address(RVA = "0x17DC770", Offset = "0x17DB370", VA = "0x1817DC770")]
		private void _ActivateCameraIfNecessary()
		{
		}

		// Token: 0x0601E28E RID: 123534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E28E")]
		[Address(RVA = "0x17DC800", Offset = "0x17DB400", VA = "0x1817DC800")]
		public FifthAnnivMissionArchiveExteriorPlayer()
		{
		}

		// Token: 0x0601E28F RID: 123535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E28F")]
		[Address(RVA = "0x17DC740", Offset = "0x17DB340", VA = "0x1817DC740")]
		private void <>xLuaBaseProxy_Init(MissionArchiveController P0)
		{
		}

		// Token: 0x0601E290 RID: 123536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E290")]
		[Address(RVA = "0x17DC760", Offset = "0x17DB360", VA = "0x1817DC760")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x0601E291 RID: 123537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E291")]
		[Address(RVA = "0x17DC750", Offset = "0x17DB350", VA = "0x1817DC750")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04028256 RID: 164438
		[Token(Token = "0x4028256")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04028257 RID: 164439
		[Token(Token = "0x4028257")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RenderTexture _renderTexture;

		// Token: 0x04028258 RID: 164440
		[Token(Token = "0x4028258")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _normalPlayAnimation;

		// Token: 0x04028259 RID: 164441
		[Token(Token = "0x4028259")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _normalStopAnimation;

		// Token: 0x0402825A RID: 164442
		[Token(Token = "0x402825A")]
		[FieldOffset(Offset = "0x48")]
		private AnimationWrapper m_playWrapper;

		// Token: 0x0402825B RID: 164443
		[Token(Token = "0x402825B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isActivated;

		// Token: 0x0402825C RID: 164444
		[Token(Token = "0x402825C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402825D RID: 164445
		[Token(Token = "0x402825D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402825E RID: 164446
		[Token(Token = "0x402825E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0402825F RID: 164447
		[Token(Token = "0x402825F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x04028260 RID: 164448
		[Token(Token = "0x4028260")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04028261 RID: 164449
		[Token(Token = "0x4028261")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04028262 RID: 164450
		[Token(Token = "0x4028262")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ActivateCameraIfNecessary;

		// Token: 0x04028263 RID: 164451
		[Token(Token = "0x4028263")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
