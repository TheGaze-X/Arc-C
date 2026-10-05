using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x0200202E RID: 8238
	[Token(Token = "0x200202E")]
	[RequireComponent(typeof(Camera))]
	public class FxCameraRectScaler : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600CB03 RID: 51971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB03")]
		[Address(RVA = "0x34C0BA0", Offset = "0x34BF7A0", VA = "0x1834C0BA0")]
		private void Awake()
		{
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB04")]
		[Address(RVA = "0x34C0E10", Offset = "0x34BFA10", VA = "0x1834C0E10")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB05 RID: 51973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB05")]
		[Address(RVA = "0x34C0D90", Offset = "0x34BF990", VA = "0x1834C0D90")]
		private void OnDisable()
		{
		}

		// Token: 0x0600CB06 RID: 51974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB06")]
		[Address(RVA = "0x34C0D00", Offset = "0x34BF900", VA = "0x1834C0D00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CB07 RID: 51975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB07")]
		[Address(RVA = "0x34C0C20", Offset = "0x34BF820", VA = "0x1834C0C20")]
		private void InitCommandBuffer()
		{
		}

		// Token: 0x0600CB08 RID: 51976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB08")]
		[Address(RVA = "0x34C10B0", Offset = "0x34BFCB0", VA = "0x1834C10B0")]
		private void RefreshCommandBuffer()
		{
		}

		// Token: 0x0600CB09 RID: 51977 RVA: 0x00049770 File Offset: 0x00047970
		[Token(Token = "0x600CB09")]
		[Address(RVA = "0x34C1460", Offset = "0x34C0060", VA = "0x1834C1460")]
		private bool _CheckScissorEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600CB0A RID: 51978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB0A")]
		[Address(RVA = "0x34C1500", Offset = "0x34C0100", VA = "0x1834C1500")]
		public FxCameraRectScaler()
		{
		}

		// Token: 0x0400D4E6 RID: 54502
		[Token(Token = "0x400D4E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxAspect;

		// Token: 0x0400D4E7 RID: 54503
		[Token(Token = "0x400D4E7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color _backgroundColor;

		// Token: 0x0400D4E8 RID: 54504
		[Token(Token = "0x400D4E8")]
		[FieldOffset(Offset = "0x2C")]
		private int m_tempRTId;

		// Token: 0x0400D4E9 RID: 54505
		[Token(Token = "0x400D4E9")]
		[FieldOffset(Offset = "0x30")]
		private Camera m_camera;

		// Token: 0x0400D4EA RID: 54506
		[Token(Token = "0x400D4EA")]
		[FieldOffset(Offset = "0x38")]
		private CommandBuffer m_commandBuffer;

		// Token: 0x0400D4EB RID: 54507
		[Token(Token = "0x400D4EB")]
		[FieldOffset(Offset = "0x40")]
		private bool m_scissorEnabled;

		// Token: 0x0400D4EC RID: 54508
		[Token(Token = "0x400D4EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400D4ED RID: 54509
		[Token(Token = "0x400D4ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400D4EE RID: 54510
		[Token(Token = "0x400D4EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400D4EF RID: 54511
		[Token(Token = "0x400D4EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400D4F0 RID: 54512
		[Token(Token = "0x400D4F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitCommandBuffer;

		// Token: 0x0400D4F1 RID: 54513
		[Token(Token = "0x400D4F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshCommandBuffer;

		// Token: 0x0400D4F2 RID: 54514
		[Token(Token = "0x400D4F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckScissorEnabled;

		// Token: 0x0400D4F3 RID: 54515
		[Token(Token = "0x400D4F3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
