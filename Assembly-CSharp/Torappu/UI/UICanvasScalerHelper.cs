using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037C3 RID: 14275
	[Token(Token = "0x20037C3")]
	[RequireComponent(typeof(CanvasScaler))]
	public class UICanvasScalerHelper : MonoBehaviour, ISafeAreaListener, IHotfixable
	{
		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x06016A0B RID: 92683 RVA: 0x00092088 File Offset: 0x00090288
		// (set) Token: 0x06016A0C RID: 92684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003622")]
		public bool isInited
		{
			[Token(Token = "0x6016A0B")]
			[Address(RVA = "0xF0E200", Offset = "0xF0CE00", VA = "0x180F0E200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016A0C")]
			[Address(RVA = "0xF0E570", Offset = "0xF0D170", VA = "0x180F0E570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x06016A0D RID: 92685 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06016A0E RID: 92686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000075")]
		public event Action<CanvasScaler> onScalerChanged
		{
			[Token(Token = "0x6016A0D")]
			[Address(RVA = "0xF0DFC0", Offset = "0xF0CBC0", VA = "0x180F0DFC0")]
			add
			{
			}
			[Token(Token = "0x6016A0E")]
			[Address(RVA = "0xF0E480", Offset = "0xF0D080", VA = "0x180F0E480")]
			remove
			{
			}
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x06016A0F RID: 92687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003623")]
		public CanvasScaler scaler
		{
			[Token(Token = "0x6016A0F")]
			[Address(RVA = "0xF0E320", Offset = "0xF0CF20", VA = "0x180F0E320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x06016A10 RID: 92688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003624")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x6016A10")]
			[Address(RVA = "0xF0E260", Offset = "0xF0CE60", VA = "0x180F0E260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x06016A11 RID: 92689 RVA: 0x000920A0 File Offset: 0x000902A0
		[Token(Token = "0x17003625")]
		public Vector2 size
		{
			[Token(Token = "0x6016A11")]
			[Address(RVA = "0xF0E3F0", Offset = "0xF0CFF0", VA = "0x180F0E3F0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06016A12 RID: 92690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A12")]
		[Address(RVA = "0xF0D9E0", Offset = "0xF0C5E0", VA = "0x180F0D9E0", Slot = "4")]
		public void OnSafeRectUpdated(SafeRect rect)
		{
		}

		// Token: 0x06016A13 RID: 92691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A13")]
		[Address(RVA = "0xF0DAD0", Offset = "0xF0C6D0", VA = "0x180F0DAD0")]
		private void Start()
		{
		}

		// Token: 0x06016A14 RID: 92692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A14")]
		[Address(RVA = "0xF0D960", Offset = "0xF0C560", VA = "0x180F0D960")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016A15 RID: 92693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A15")]
		[Address(RVA = "0xF0DA60", Offset = "0xF0C660", VA = "0x180F0DA60")]
		public void OnScalerChange()
		{
		}

		// Token: 0x06016A16 RID: 92694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A16")]
		[Address(RVA = "0xF0DC70", Offset = "0xF0C870", VA = "0x180F0DC70")]
		private void _UpdateMatchMethod()
		{
		}

		// Token: 0x06016A17 RID: 92695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A17")]
		[Address(RVA = "0xF0DBA0", Offset = "0xF0C7A0", VA = "0x180F0DBA0")]
		public static void UpdateScalerFitMode(CanvasScaler scaler)
		{
		}

		// Token: 0x06016A18 RID: 92696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A18")]
		[Address(RVA = "0xF0DF60", Offset = "0xF0CB60", VA = "0x180F0DF60")]
		public UICanvasScalerHelper()
		{
		}

		// Token: 0x0401B46C RID: 111724
		[Token(Token = "0x401B46C")]
		[FieldOffset(Offset = "0x18")]
		private CanvasScaler m_scaler;

		// Token: 0x0401B46D RID: 111725
		[Token(Token = "0x401B46D")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_rectTrans;

		// Token: 0x0401B46E RID: 111726
		[Token(Token = "0x401B46E")]
		[FieldOffset(Offset = "0x28")]
		private Action<CanvasScaler> m_onScalerChanged;

		// Token: 0x0401B470 RID: 111728
		[Token(Token = "0x401B470")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInited;

		// Token: 0x0401B471 RID: 111729
		[Token(Token = "0x401B471")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isInited;

		// Token: 0x0401B472 RID: 111730
		[Token(Token = "0x401B472")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_add_onScalerChanged;

		// Token: 0x0401B473 RID: 111731
		[Token(Token = "0x401B473")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_remove_onScalerChanged;

		// Token: 0x0401B474 RID: 111732
		[Token(Token = "0x401B474")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_scaler;

		// Token: 0x0401B475 RID: 111733
		[Token(Token = "0x401B475")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rectTrans;

		// Token: 0x0401B476 RID: 111734
		[Token(Token = "0x401B476")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_size;

		// Token: 0x0401B477 RID: 111735
		[Token(Token = "0x401B477")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSafeRectUpdated;

		// Token: 0x0401B478 RID: 111736
		[Token(Token = "0x401B478")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B479 RID: 111737
		[Token(Token = "0x401B479")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B47A RID: 111738
		[Token(Token = "0x401B47A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnScalerChange;

		// Token: 0x0401B47B RID: 111739
		[Token(Token = "0x401B47B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateMatchMethod;

		// Token: 0x0401B47C RID: 111740
		[Token(Token = "0x401B47C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateScalerFitMode;

		// Token: 0x0401B47D RID: 111741
		[Token(Token = "0x401B47D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
