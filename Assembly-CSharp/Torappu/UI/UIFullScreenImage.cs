using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037FF RID: 14335
	[Token(Token = "0x20037FF")]
	public class UIFullScreenImage : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016B52 RID: 93010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B52")]
		[Address(RVA = "0xF14CF0", Offset = "0xF138F0", VA = "0x180F14CF0")]
		public void SetRTSpriteToImage(Sprite rtSprite)
		{
		}

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x06016B53 RID: 93011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003649")]
		public Image image
		{
			[Token(Token = "0x6016B53")]
			[Address(RVA = "0xF15390", Offset = "0xF13F90", VA = "0x180F15390")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x06016B54 RID: 93012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700364A")]
		private UICanvasScalerHelper scaler
		{
			[Token(Token = "0x6016B54")]
			[Address(RVA = "0xF15530", Offset = "0xF14130", VA = "0x180F15530")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016B55 RID: 93013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B55")]
		[Address(RVA = "0xF14C70", Offset = "0xF13870", VA = "0x180F14C70")]
		public void OnSafeRectUpdated(SafeRect safeRect)
		{
		}

		// Token: 0x06016B56 RID: 93014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B56")]
		[Address(RVA = "0xF14EB0", Offset = "0xF13AB0", VA = "0x180F14EB0")]
		private void Start()
		{
		}

		// Token: 0x06016B57 RID: 93015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B57")]
		[Address(RVA = "0xF14AE0", Offset = "0xF136E0", VA = "0x180F14AE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016B58 RID: 93016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B58")]
		[Address(RVA = "0xF14FC0", Offset = "0xF13BC0", VA = "0x180F14FC0")]
		public void UpdateSize()
		{
		}

		// Token: 0x06016B59 RID: 93017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B59")]
		[Address(RVA = "0xF151E0", Offset = "0xF13DE0", VA = "0x180F151E0")]
		private void _OnScalerChanged(CanvasScaler canvasScaler)
		{
		}

		// Token: 0x06016B5A RID: 93018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B5A")]
		[Address(RVA = "0xF15330", Offset = "0xF13F30", VA = "0x180F15330")]
		public UIFullScreenImage()
		{
		}

		// Token: 0x0401B5D2 RID: 112082
		[Token(Token = "0x401B5D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("")]
		private UICanvasScalerHelper _targetScaler;

		// Token: 0x0401B5D3 RID: 112083
		[Token(Token = "0x401B5D3")]
		[FieldOffset(Offset = "0x20")]
		private Image m_image;

		// Token: 0x0401B5D4 RID: 112084
		[Token(Token = "0x401B5D4")]
		[FieldOffset(Offset = "0x28")]
		private UICanvasScalerHelper m_scaler;

		// Token: 0x0401B5D5 RID: 112085
		[Token(Token = "0x401B5D5")]
		[FieldOffset(Offset = "0x30")]
		private Sprite m_rtSprite;

		// Token: 0x0401B5D6 RID: 112086
		[Token(Token = "0x401B5D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetRTSpriteToImage;

		// Token: 0x0401B5D7 RID: 112087
		[Token(Token = "0x401B5D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_image;

		// Token: 0x0401B5D8 RID: 112088
		[Token(Token = "0x401B5D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_scaler;

		// Token: 0x0401B5D9 RID: 112089
		[Token(Token = "0x401B5D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSafeRectUpdated;

		// Token: 0x0401B5DA RID: 112090
		[Token(Token = "0x401B5DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B5DB RID: 112091
		[Token(Token = "0x401B5DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B5DC RID: 112092
		[Token(Token = "0x401B5DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateSize;

		// Token: 0x0401B5DD RID: 112093
		[Token(Token = "0x401B5DD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnScalerChanged;

		// Token: 0x0401B5DE RID: 112094
		[Token(Token = "0x401B5DE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
