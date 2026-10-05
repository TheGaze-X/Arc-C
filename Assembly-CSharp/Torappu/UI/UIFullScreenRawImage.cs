using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003800 RID: 14336
	[Token(Token = "0x2003800")]
	public class UIFullScreenRawImage : MonoBehaviour
	{
		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x06016B5B RID: 93019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700364B")]
		private RawImage image
		{
			[Token(Token = "0x6016B5B")]
			[Address(RVA = "0xF15980", Offset = "0xF14580", VA = "0x180F15980")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x06016B5C RID: 93020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700364C")]
		private UICanvasScalerHelper scaler
		{
			[Token(Token = "0x6016B5C")]
			[Address(RVA = "0xF15AF0", Offset = "0xF146F0", VA = "0x180F15AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016B5D RID: 93021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B5D")]
		[Address(RVA = "0xF15790", Offset = "0xF14390", VA = "0x180F15790")]
		private void Start()
		{
		}

		// Token: 0x06016B5E RID: 93022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B5E")]
		[Address(RVA = "0xF156B0", Offset = "0xF142B0", VA = "0x180F156B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016B5F RID: 93023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B5F")]
		[Address(RVA = "0xF15870", Offset = "0xF14470", VA = "0x180F15870")]
		private void _OnScalerChanged(CanvasScaler canvasScaler)
		{
		}

		// Token: 0x06016B60 RID: 93024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B60")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIFullScreenRawImage()
		{
		}

		// Token: 0x0401B5DF RID: 112095
		[Token(Token = "0x401B5DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICanvasScalerHelper _targetScaler;

		// Token: 0x0401B5E0 RID: 112096
		[Token(Token = "0x401B5E0")]
		[FieldOffset(Offset = "0x20")]
		private RawImage m_image;

		// Token: 0x0401B5E1 RID: 112097
		[Token(Token = "0x401B5E1")]
		[FieldOffset(Offset = "0x28")]
		private UICanvasScalerHelper m_scaler;
	}
}
